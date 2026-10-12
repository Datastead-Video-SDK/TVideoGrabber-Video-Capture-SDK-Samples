unit FmxDemoHelpers;

{$RANGECHECKS OFF}
{$OVERFLOWCHECKS OFF}

/// Helpers used by the FireMonkey MainDemo to keep the code close to the VCL MainDemo:
/// - TFmxRadioGroup: VCL TRadioGroup behavior on top of a TGroupBox and its TRadioButtons
/// - TFmxUpDown: VCL TUpDown behavior on top of 2 TSpeedButtons, with an optional associated TEdit
/// - TNativeChildWindow: native child window kept over an FMX placeholder control, for the APIs
///   that draw into an HWND (VU meters)
/// - VCL <-> FMX bitmap conversions, color conversions, color picker (ChooseColor)
/// - programmatic change guard for the TComboBox.OnChange events (the VCL OnChange only occurs
///   on user changes, the FMX OnChange also occurs when ItemIndex is set by code)

interface

uses
   Winapi.Windows,
   Winapi.Messages,
   Winapi.CommDlg,
   System.SysUtils,
   System.Classes,
   System.Types,
   System.Generics.Collections,
   /// Vcl.Graphics before System.UITypes and the FMX units: TPixelFormat and TBitmap must resolve
   /// to the FMX/System.UITypes declarations, VCL types are qualified where needed
   Vcl.Graphics,
   System.UITypes,
   FMX.Types,
   FMX.Controls,
   FMX.Graphics,
   FMX.StdCtrls,
   FMX.Edit,
   FMX.ListBox,
   FMX.Forms,
   FMX.Platform.Win;

type
   /// same identifiers as Vcl.ComCtrls.TUDBtnType
   TUDBtnType = (btNext, btPrev);
   TUDClickEvent = procedure (Sender: TObject; Button: TUDBtnType) of object;

   TFmxRadioGroup = class (TComponent)
   private
      FGroupBox: TGroupBox;
      FButtons: TList<TRadioButton>;
      FItemIndex: Integer;
      FUpdating: Boolean;
      FOnClick: TNotifyEvent;
      procedure ButtonChange (Sender: TObject);
      function  GetCount: Integer;
      function  GetEnabled: Boolean;
      procedure SetEnabled (Value: Boolean);
      procedure SetItemIndex (Value: Integer);
   public
      /// AGroupBox must contain the radio buttons, ordered by their Tag (0..n-1)
      constructor Create (AOwner: TComponent; AGroupBox: TGroupBox; AOnClick: TNotifyEvent); reintroduce;
      destructor Destroy; override;
      property  Count: Integer read GetCount;
      property  Enabled: Boolean read GetEnabled write SetEnabled;
      property  GroupBox: TGroupBox read FGroupBox;
      /// as with the VCL, OnClick occurs when ItemIndex changes, by code or by the user
      property  ItemIndex: Integer read FItemIndex write SetItemIndex;
      property  OnClick: TNotifyEvent read FOnClick write FOnClick;
   end;

   TFmxUpDown = class (TComponent)
   private
      FLayout: TControl;
      FBtnUp: TSpeedButton;
      FBtnDown: TSpeedButton;
      FAssociate: TEdit;
      FMin: Integer;
      FMax: Integer;
      FPosition: Integer;
      FOnClick: TUDClickEvent;
      procedure BtnClick (Sender: TObject);
      function  GetEnabled: Boolean;
      procedure SetEnabled (Value: Boolean);
      procedure SetPosition (Value: Integer);
      procedure UpdateAssociate;
   public
      constructor Create (AOwner: TComponent; ALayout: TControl; ABtnUp: TSpeedButton; ABtnDown: TSpeedButton; AAssociate: TEdit; AMin: Integer; AMax: Integer; APosition: Integer; AOnClick: TUDClickEvent); reintroduce;
      property  Enabled: Boolean read GetEnabled write SetEnabled;
      property  Max: Integer read FMax write FMax;
      property  Min: Integer read FMin write FMin;
      property  Position: Integer read FPosition write SetPosition;
      property  OnClick: TUDClickEvent read FOnClick write FOnClick;
   end;

   TNativeChildWindow = class (TComponent)
   private
      FPlaceholder: TControl;
      FWnd: HWND;
      FParentWnd: HWND;
      FTimer: TTimer;
      FLastRect: TRect;
      FLastVisible: Boolean;
      FOnHandleChanged: TNotifyEvent;
      procedure CreateNativeWindow;
      procedure DestroyNativeWindow;
      function  GetHandle: HWND;
      procedure TimerTick (Sender: TObject);
   public
      constructor Create (AOwner: TComponent; APlaceholder: TControl); reintroduce;
      destructor Destroy; override;
      /// moves/shows/hides the native window according to the placeholder, also done by a timer
      procedure UpdateBounds;
      property  Handle: HWND read GetHandle;
      /// occurs when the native window has been created by UpdateBounds (first creation, or
      /// recreation after the form handle has been recreated)
      property  OnHandleChanged: TNotifyEvent read FOnHandleChanged write FOnHandleChanged;
   end;

function  IsProgrammaticChange: Boolean;
procedure BeginProgrammaticChange;
procedure EndProgrammaticChange;
procedure ComboBoxAssignList (ComboBox: TComboBox; const List: string; Index: Integer);
procedure ComboBoxSetIndex (ComboBox: TComboBox; Index: Integer);

procedure VclBitmapToFmx (Src: Vcl.Graphics.TBitmap; Dst: FMX.Graphics.TBitmap);
procedure FmxBitmapToVcl (Src: FMX.Graphics.TBitmap; Dst: Vcl.Graphics.TBitmap);
function  VclColorToAlpha (Color: TColor): TAlphaColor;
function  AlphaToVclColor (Color: TAlphaColor): TColor;
function  PickColor (OwnerForm: TCommonCustomForm; var Color: TColor): Boolean;
procedure SetControlFontColor (Control: TControl; Color: TAlphaColor);
procedure RunInMainThread (const Proc: TThreadProcedure);

implementation

var
   GProgrammaticChange: Integer = 0;
   GCustomColors: array [0..15] of COLORREF;
   GNativeClassRegistered: Boolean = False;

const
   NATIVE_HOST_CLASS = 'DatasteadFmxNativeHost';

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
function IsProgrammaticChange: Boolean;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   Result := GProgrammaticChange > 0;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure BeginProgrammaticChange;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   Inc (GProgrammaticChange);
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure EndProgrammaticChange;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if GProgrammaticChange > 0 then begin
      Dec (GProgrammaticChange);
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure ComboBoxAssignList (ComboBox: TComboBox; const List: string; Index: Integer);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   BeginProgrammaticChange;
   try
      ComboBox.Items.Text := List;
      if (ComboBox.Items.Count > 0) and (Index >= 0) and (Index < ComboBox.Items.Count) then begin
         ComboBox.ItemIndex := Index;
      end;
   finally
      EndProgrammaticChange;
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure ComboBoxSetIndex (ComboBox: TComboBox; Index: Integer);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   BeginProgrammaticChange;
   try
      if Index < ComboBox.Items.Count then begin
         ComboBox.ItemIndex := Index;
      end;
   finally
      EndProgrammaticChange;
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure VclBitmapToFmx (Src: Vcl.Graphics.TBitmap; Dst: FMX.Graphics.TBitmap);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   Tmp: Vcl.Graphics.TBitmap;
   Data: TBitmapData;
   x, y: Integer;
   pSrc: PCardinal;
   pDst: PCardinal;
   Pixel: Cardinal;
   SwapRB: Boolean;
begin
   if (Src = nil) or (Dst = nil) or (Src.Width <= 0) or (Src.Height <= 0) then Exit;
   Tmp := Vcl.Graphics.TBitmap.Create;
   try
      Tmp.Assign (Src);
      Tmp.PixelFormat := pf32bit;
      Dst.SetSize (Tmp.Width, Tmp.Height);
      if Dst.Map (TMapAccess.Write, Data) then begin
         try
            SwapRB := Data.PixelFormat = TPixelFormat.RGBA;
            for y := 0 to Tmp.Height - 1 do begin
               pSrc := PCardinal (Tmp.ScanLine[y]);
               pDst := PCardinal (Data.GetScanline (y));
               for x := 0 to Tmp.Width - 1 do begin
                  Pixel := pSrc^ or $FF000000;
                  if SwapRB then begin
                     Pixel := (Pixel and $FF00FF00) or ((Pixel and $FF) shl 16) or ((Pixel shr 16) and $FF);
                  end;
                  pDst^ := Pixel;
                  Inc (pSrc);
                  Inc (pDst);
               end;
            end;
         finally
            Dst.Unmap (Data);
         end;
      end;
   finally
      Tmp.Free;
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure FmxBitmapToVcl (Src: FMX.Graphics.TBitmap; Dst: Vcl.Graphics.TBitmap);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   Data: TBitmapData;
   x, y: Integer;
   pSrc: PCardinal;
   pDst: PCardinal;
   Pixel: Cardinal;
   SwapRB: Boolean;
begin
   if (Src = nil) or (Dst = nil) or Src.IsEmpty then Exit;
   Dst.PixelFormat := pf32bit;
   Dst.SetSize (Src.Width, Src.Height);
   if Src.Map (TMapAccess.Read, Data) then begin
      try
         SwapRB := Data.PixelFormat = TPixelFormat.RGBA;
         for y := 0 to Src.Height - 1 do begin
            pSrc := PCardinal (Data.GetScanline (y));
            pDst := PCardinal (Dst.ScanLine[y]);
            for x := 0 to Src.Width - 1 do begin
               Pixel := pSrc^;
               if SwapRB then begin
                  Pixel := (Pixel and $FF00FF00) or ((Pixel and $FF) shl 16) or ((Pixel shr 16) and $FF);
               end;
               pDst^ := Pixel;
               Inc (pSrc);
               Inc (pDst);
            end;
         end;
      finally
         Src.Unmap (Data);
      end;
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
function VclColorToAlpha (Color: TColor): TAlphaColor;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   RGB: Cardinal;
begin
   RGB := Cardinal (ColorToRGB (Color));
   Result := $FF000000 or ((RGB and $FF) shl 16) or (RGB and $FF00) or ((RGB shr 16) and $FF);
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
function AlphaToVclColor (Color: TAlphaColor): TColor;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   Result := TColor (((Color shr 16) and $FF) or (Color and $FF00) or ((Color and $FF) shl 16));
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
function PickColor (OwnerForm: TCommonCustomForm; var Color: TColor): Boolean;
/// Windows color dialog (FMX has no color dialog)
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   CC: TChooseColor;
begin
   FillChar (CC, SizeOf (CC), 0);
   CC.lStructSize := SizeOf (CC);
   if Assigned (OwnerForm) then begin
      CC.hWndOwner := FormToHWND (OwnerForm);
   end;
   CC.rgbResult := COLORREF (ColorToRGB (Color));
   CC.lpCustColors := @GCustomColors[0];
   CC.Flags := CC_RGBINIT or CC_FULLOPEN;
   Result := ChooseColor (CC);
   if Result then begin
      Color := TColor (CC.rgbResult);
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure SetControlFontColor (Control: TControl; Color: TAlphaColor);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   Settings: ITextSettings;
begin
   if Supports (Control, ITextSettings, Settings) then begin
      Settings.StyledSettings := Settings.StyledSettings - [TStyledSetting.FontColor];
      Settings.TextSettings.FontColor := Color;
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure RunInMainThread (const Proc: TThreadProcedure);
/// TVideoGrabber may fire some events (e.g. OnFrameBitmap) from a worker thread: FMX controls
/// must only be accessed from the main thread
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if TThread.CurrentThread.ThreadID = MainThreadID then begin
      Proc ();
   end
   else begin
      TThread.Queue (nil, Proc);
   end;
end;

{ TFmxRadioGroup }

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
constructor TFmxRadioGroup.Create (AOwner: TComponent; AGroupBox: TGroupBox; AOnClick: TNotifyEvent);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   i, j: Integer;
   Button: TRadioButton;
begin
   inherited Create (AOwner);
   FGroupBox := AGroupBox;
   FButtons := TList<TRadioButton>.Create;
   FItemIndex := -1;
   for i := 0 to AGroupBox.ChildrenCount - 1 do begin
      if AGroupBox.Children[i] is TRadioButton then begin
         Button := TRadioButton (AGroupBox.Children[i]);
         /// insertion by Tag order
         j := 0;
         while (j < FButtons.Count) and (FButtons[j].Tag < Button.Tag) do begin
            Inc (j);
         end;
         FButtons.Insert (j, Button);
      end;
   end;
   for i := 0 to FButtons.Count - 1 do begin
      if FButtons[i].IsChecked then begin
         FItemIndex := i;
      end;
      FButtons[i].OnChange := ButtonChange;
   end;
   FOnClick := AOnClick;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
destructor TFmxRadioGroup.Destroy;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   FButtons.Free;
   inherited Destroy;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TFmxRadioGroup.ButtonChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   Index: Integer;
begin
   if FUpdating then Exit;
   if not TRadioButton (Sender).IsChecked then Exit;
   Index := FButtons.IndexOf (TRadioButton (Sender));
   if Index = FItemIndex then Exit;
   FItemIndex := Index;
   if Assigned (FOnClick) then begin
      FOnClick (Self);
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
function TFmxRadioGroup.GetCount: Integer;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   Result := FButtons.Count;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
function TFmxRadioGroup.GetEnabled: Boolean;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   Result := FGroupBox.Enabled;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TFmxRadioGroup.SetEnabled (Value: Boolean);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   FGroupBox.Enabled := Value;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TFmxRadioGroup.SetItemIndex (Value: Integer);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   i: Integer;
begin
   if (Value < -1) or (Value >= FButtons.Count) then Exit;
   if Value = FItemIndex then Exit;
   FUpdating := True;
   try
      for i := 0 to FButtons.Count - 1 do begin
         FButtons[i].IsChecked := i = Value;
      end;
   finally
      FUpdating := False;
   end;
   FItemIndex := Value;
   if (Value >= 0) and Assigned (FOnClick) then begin
      FOnClick (Self);
   end;
end;

{ TFmxUpDown }

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
constructor TFmxUpDown.Create (AOwner: TComponent; ALayout: TControl; ABtnUp: TSpeedButton; ABtnDown: TSpeedButton; AAssociate: TEdit; AMin: Integer; AMax: Integer; APosition: Integer; AOnClick: TUDClickEvent);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   inherited Create (AOwner);
   FLayout := ALayout;
   FBtnUp := ABtnUp;
   FBtnDown := ABtnDown;
   FAssociate := AAssociate;
   FMin := AMin;
   FMax := AMax;
   FPosition := APosition;
   FBtnUp.OnClick := BtnClick;
   FBtnDown.OnClick := BtnClick;
   UpdateAssociate;
   FOnClick := AOnClick;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TFmxUpDown.BtnClick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   NewPosition: Integer;
begin
   if Assigned (FAssociate) then begin
      /// the user may have typed a value into the associated edit
      FPosition := StrToIntDef (FAssociate.Text, FPosition);
   end;
   NewPosition := FPosition;
   if Sender = FBtnUp then begin
      Inc (NewPosition);
   end
   else begin
      Dec (NewPosition);
   end;
   SetPosition (NewPosition);
   /// as with the VCL TUpDown, the associated edit change event occurs (FMX may not fire it
   /// when Text is set by code)
   if Assigned (FAssociate) and Assigned (FAssociate.OnChangeTracking) then begin
      FAssociate.OnChangeTracking (FAssociate);
   end;
   if Assigned (FOnClick) then begin
      if Sender = FBtnUp then begin
         FOnClick (Self, btNext);
      end
      else begin
         FOnClick (Self, btPrev);
      end;
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
function TFmxUpDown.GetEnabled: Boolean;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   Result := FLayout.Enabled;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TFmxUpDown.SetEnabled (Value: Boolean);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   FLayout.Enabled := Value;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TFmxUpDown.SetPosition (Value: Integer);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if Value < FMin then Value := FMin;
   if Value > FMax then Value := FMax;
   FPosition := Value;
   UpdateAssociate;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TFmxUpDown.UpdateAssociate;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if Assigned (FAssociate) then begin
      FAssociate.Text := IntToStr (FPosition);
   end;
end;

{ TNativeChildWindow }

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
constructor TNativeChildWindow.Create (AOwner: TComponent; APlaceholder: TControl);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   inherited Create (AOwner);
   FPlaceholder := APlaceholder;
   FTimer := TTimer.Create (Self);
   FTimer.Interval := 100;
   FTimer.OnTimer := TimerTick;
   FTimer.Enabled := True;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
destructor TNativeChildWindow.Destroy;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   FTimer.Enabled := False;
   DestroyNativeWindow;
   inherited Destroy;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TNativeChildWindow.CreateNativeWindow;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   WndClass: TWndClass;
   Form: TCommonCustomForm;
begin
   if not GNativeClassRegistered then begin
      FillChar (WndClass, SizeOf (WndClass), 0);
      WndClass.lpfnWndProc := @DefWindowProc;
      WndClass.hInstance := HInstance;
      WndClass.hCursor := LoadCursor (0, IDC_ARROW);
      WndClass.hbrBackground := GetStockObject (BLACK_BRUSH);
      WndClass.lpszClassName := NATIVE_HOST_CLASS;
      GNativeClassRegistered := Winapi.Windows.RegisterClass (WndClass) <> 0;
   end;
   if (FPlaceholder.Root = nil) or not (FPlaceholder.Root.GetObject is TCommonCustomForm) then Exit;
   Form := TCommonCustomForm (FPlaceholder.Root.GetObject);
   if Form.Handle = nil then Exit;
   FParentWnd := FormToHWND (Form);
   if FParentWnd = 0 then Exit;
   FWnd := CreateWindowEx (0, NATIVE_HOST_CLASS, '', WS_CHILD or WS_CLIPSIBLINGS, 0, 0, 1, 1, FParentWnd, 0, HInstance, nil);
   FLastRect := Rect (0, 0, 0, 0);
   FLastVisible := False;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TNativeChildWindow.DestroyNativeWindow;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if (FWnd <> 0) and IsWindow (FWnd) then begin
      DestroyWindow (FWnd);
   end;
   FWnd := 0;
   FParentWnd := 0;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
function TNativeChildWindow.GetHandle: HWND;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if (FWnd = 0) or (not IsWindow (FWnd)) then begin
      FWnd := 0;
      CreateNativeWindow;
   end;
   Result := FWnd;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TNativeChildWindow.UpdateBounds;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   Form: TCommonCustomForm;
   Scale: Single;
   TopLeft: TPointF;
   R: TRect;
   ShouldBeVisible: Boolean;
begin
   if (FPlaceholder.Root = nil) or not (FPlaceholder.Root.GetObject is TCommonCustomForm) then Exit;
   Form := TCommonCustomForm (FPlaceholder.Root.GetObject);
   if Form.Handle = nil then Exit;
   /// the form window may have been recreated: the native window must follow
   if (FWnd <> 0) and ((not IsWindow (FWnd)) or (FParentWnd <> FormToHWND (Form))) then begin
      DestroyNativeWindow;
   end;
   if FWnd = 0 then begin
      CreateNativeWindow;
      if FWnd = 0 then Exit;
      /// first creation (Handle may have been read before the form window existed) or recreation
      if Assigned (FOnHandleChanged) then begin
         FOnHandleChanged (Self);
      end;
   end;
   Scale := Form.Handle.Scale;
   if Scale <= 0 then Scale := 1;
   TopLeft := FPlaceholder.LocalToAbsolute (PointF (0, 0));
   R.Left := Round (TopLeft.X * Scale);
   R.Top := Round (TopLeft.Y * Scale);
   R.Right := R.Left + Round (FPlaceholder.Width * Scale);
   R.Bottom := R.Top + Round (FPlaceholder.Height * Scale);
   ShouldBeVisible := FPlaceholder.ParentedVisible and Form.Visible;
   if (ShouldBeVisible <> FLastVisible) or (not EqualRect (R, FLastRect)) then begin
      if ShouldBeVisible then begin
         SetWindowPos (FWnd, HWND_TOP, R.Left, R.Top, R.Right - R.Left, R.Bottom - R.Top, SWP_NOACTIVATE or SWP_SHOWWINDOW);
      end
      else begin
         ShowWindow (FWnd, SW_HIDE);
      end;
      FLastRect := R;
      FLastVisible := ShouldBeVisible;
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TNativeChildWindow.TimerTick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   UpdateBounds;
end;

end.
