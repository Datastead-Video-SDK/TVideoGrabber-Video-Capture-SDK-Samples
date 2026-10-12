/// GENERATED from the VCL MainDemo by Sources\DEMOS\FmxDemoGen\regen_fmx_demo.cmd: do not edit,
/// the changes are overwritten by the next generation. Edit the VCL MainDemo, or the generator
/// (FireMonkey code of this unit: FmxDemoGen\overrides\VUMeterConfigForm.inc).
unit VUMeterConfigForm;

(*
 * Non-modal VU-meter configuration dialog.
 *
 * Lets the user pick and tweak any of the supported VU-meter types
 * (vu_Disabled, vu_Analog, vu_AnalogVintage, vu_Bargraph, vu_SegmentLed,
 * vu_SmoothBar, vu_Spectrum, vu_MixingTable) and every TVUMeterSetting
 * option.
 *
 * The historical "Overlay" variants (vu_AnalogOverlay, vu_BargraphOverlay)
 * are NOT exposed here: the overlay-over-video mode is now toggled with
 * vu_OverlayOverVideo on any display type.
 *
 * Changes are applied live to both channels (VU_LEFT = 0 and VU_RIGHT = 1)
 * of the TVideoGrabber instance passed in. The actual TYPE change is routed
 * through the OnApplyType callback, so the main form can take care of the
 * panel resize and the vu_Handle wiring.
 *)

interface

uses
   VidGrab,
   Winapi.Windows, Winapi.Messages, System.SysUtils, System.Classes, System.Types,
   Vcl.Graphics,
   System.UITypes, FMX.Types, FMX.Controls, FMX.Forms, FMX.Graphics, FMX.Dialogs, FMX.StdCtrls,
   FMX.Controls.Presentation, FMX.Edit, FMX.ListBox, FMX.TabControl, FMX.Objects, FMX.Layouts,
   FmxDemoHelpers;

type
   TVUMeterTypeApplyEvent = procedure (VUMeter: TVUMeter) of object;

   TfrmVUMeterConfig = class (TForm)
      pcMain: TTabControl;
      tsType: TTabItem;
      lblVUMeter: TLabel;
      cboVUMeter: TComboBox;
      grbDisplayOptions: TGroupBox;
      chkOverlayOverVideo: TCheckBox;
      chkTransparent: TCheckBox;
      chkFlipVert: TCheckBox;
      chkFlipHorz: TCheckBox;
      chkLogarithmic: TCheckBox;
      btnDisablePeak: TButton;
      grbOverlayRect: TGroupBox;
      lblOverlayLeft: TLabel;
      lblOverlayTop: TLabel;
      lblOverlayWidth: TLabel;
      lblOverlayHeight: TLabel;
      edtOverlayLeft: TEdit;
      edtOverlayTop: TEdit;
      edtOverlayWidth: TEdit;
      edtOverlayHeight: TEdit;
      tsLevelsColors: TTabItem;
      grbWarningPercent: TGroupBox;
      lblWarningPercentValue: TLabel;
      tbrWarningPercent: TTrackBar;
      grbPeakPercent: TGroupBox;
      lblPeakPercentValue: TLabel;
      tbrPeakPercent: TTrackBar;
      grbColors: TGroupBox;
      lblBkgndColor: TLabel;
      lblNormalColor: TLabel;
      lblWarningColor: TLabel;
      lblPeakColor: TLabel;
      pnBkgndColor: TRectangle;
      btnBkgndColor: TButton;
      pnNormalColor: TRectangle;
      btnNormalColor: TButton;
      pnWarningColor: TRectangle;
      btnWarningColor: TButton;
      pnPeakColor: TRectangle;
      btnPeakColor: TButton;
      tsDrawing: TTabItem;
      lblTickSize: TLabel;
      lblTickInterval: TLabel;
      lblNeedleThickness: TLabel;
      lblDrawingHint: TLabel;
      edtTickSize: TEdit;
      lay_updTickSize: TLayout;
      updTickSize_Up: TSpeedButton;
      updTickSize_Down: TSpeedButton;
      edtTickInterval: TEdit;
      lay_updTickInterval: TLayout;
      updTickInterval_Up: TSpeedButton;
      updTickInterval_Down: TSpeedButton;
      edtNeedleThickness: TEdit;
      lay_updNeedleThickness: TLayout;
      updNeedleThickness_Up: TSpeedButton;
      updNeedleThickness_Down: TSpeedButton;
      tsBallistics: TTabItem;
      lblBallisticProfile: TLabel;
      lblAttackMs: TLabel;
      lblReleaseMs: TLabel;
      lblPeakHoldMs: TLabel;
      lblBallisticHint: TLabel;
      cboBallisticProfile: TComboBox;
      edtAttackMs: TEdit;
      lay_updAttackMs: TLayout;
      updAttackMs_Up: TSpeedButton;
      updAttackMs_Down: TSpeedButton;
      edtReleaseMs: TEdit;
      lay_updReleaseMs: TLayout;
      updReleaseMs_Up: TSpeedButton;
      updReleaseMs_Down: TSpeedButton;
      edtPeakHoldMs: TEdit;
      lay_updPeakHoldMs: TLayout;
      updPeakHoldMs_Up: TSpeedButton;
      updPeakHoldMs_Down: TSpeedButton;
      btnRefresh: TButton;
      btnClose: TButton;

      procedure FormCreate (Sender: TObject);
      procedure FormShow (Sender: TObject);

      procedure cboVUMeterChange (Sender: TObject);

      procedure chkOverlayOverVideoClick (Sender: TObject);
      procedure chkTransparentClick (Sender: TObject);
      procedure chkFlipVertClick (Sender: TObject);
      procedure chkFlipHorzClick (Sender: TObject);
      procedure chkLogarithmicClick (Sender: TObject);

      procedure edtOverlayLeftChange (Sender: TObject);
      procedure edtOverlayTopChange (Sender: TObject);
      procedure edtOverlayWidthChange (Sender: TObject);
      procedure edtOverlayHeightChange (Sender: TObject);

      procedure tbrWarningPercentChange (Sender: TObject);
      procedure tbrPeakPercentChange (Sender: TObject);

      procedure btnColorClick (Sender: TObject);

      // Drawing & Ballistics numeric edits: handler on the TEdit (OnChange)
      // rather than on the TUpDown (OnChangingEx) so the value is applied
      // both on keyboard typing AND on spinner button clicks.
      procedure edtTickSizeChange (Sender: TObject);
      procedure edtTickIntervalChange (Sender: TObject);
      procedure edtNeedleThicknessChange (Sender: TObject);

      procedure cboBallisticProfileChange (Sender: TObject);

      procedure edtAttackMsChange (Sender: TObject);
      procedure edtReleaseMsChange (Sender: TObject);
      procedure edtPeakHoldMsChange (Sender: TObject);

      procedure btnCloseClick (Sender: TObject);
      procedure btnRefreshClick (Sender: TObject);
    procedure btnDisablePeakClick(Sender: TObject);

   private
      /// FireMonkey has no TUpDown: emulated, see FmxDemoHelpers
      updTickSize: TFmxUpDown;
      updTickInterval: TFmxUpDown;
      updNeedleThickness: TFmxUpDown;
      updAttackMs: TFmxUpDown;
      updReleaseMs: TFmxUpDown;
      updPeakHoldMs: TFmxUpDown;
      FVideoGrabber: TVideoGrabber;
      FOnApplyType: TVUMeterTypeApplyEvent;
      FLoading: Boolean;
      procedure SetBothChannels (Setting: TVUMeterSetting; Value: NativeInt);
      procedure UpdateColorPanel (Panel: TRectangle; Color: TColor);
      procedure LoadFromGrabber;
      procedure ApplyBallisticProfilePreset (ProfileIdx: Integer);
   public
      property VideoGrabber: TVideoGrabber read FVideoGrabber write FVideoGrabber;
      property OnApplyType: TVUMeterTypeApplyEvent
         read FOnApplyType write FOnApplyType;
      procedure RefreshControls;
   end;

implementation

{$R *.fmx}

const
   /// FireMonkey: the VU meter type of each cboVUMeter item (the VCL version stores it in
   /// Items.Objects)
   VU_METER_TYPES: array [0..7] of TVUMeter = (vu_Disabled, vu_Analog, vu_AnalogVintage,
      vu_Bargraph, vu_SegmentLed, vu_SmoothBar, vu_Spectrum, vu_MixingTable);

const
   VU_LEFT  = 0;
   VU_RIGHT = 1;

   // Indices in cboBallisticProfile (kept in sync with FormCreate)
   PROFILE_CUSTOM       = 0;
   PROFILE_DEFAULT      = 1;
   PROFILE_VU_CLASSIC   = 2;
   PROFILE_PPM          = 3;
   PROFILE_FAST_PEAK    = 4;
   PROFILE_SLOW_RMS     = 5;
   PROFILE_INSTANT      = 6;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.FormCreate (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   FLoading := True;

   /// FireMonkey: TUpDown emulation
   updTickSize := TFmxUpDown.Create (Self, lay_updTickSize, updTickSize_Up, updTickSize_Down, edtTickSize, 1, 100, 6, nil);
   updTickInterval := TFmxUpDown.Create (Self, lay_updTickInterval, updTickInterval_Up, updTickInterval_Down, edtTickInterval, 1, 100, 10, nil);
   updNeedleThickness := TFmxUpDown.Create (Self, lay_updNeedleThickness, updNeedleThickness_Up, updNeedleThickness_Down, edtNeedleThickness, 1, 20, 2, nil);
   updAttackMs := TFmxUpDown.Create (Self, lay_updAttackMs, updAttackMs_Up, updAttackMs_Down, edtAttackMs, 0, 10000, 10, nil);
   updReleaseMs := TFmxUpDown.Create (Self, lay_updReleaseMs, updReleaseMs_Up, updReleaseMs_Down, edtReleaseMs, 0, 10000, 300, nil);
   updPeakHoldMs := TFmxUpDown.Create (Self, lay_updPeakHoldMs, updPeakHoldMs_Up, updPeakHoldMs_Down, edtPeakHoldMs, 0, 10000, 800, nil);

   // VU-meter type list (the legacy "*Overlay" variants are intentionally
   // not exposed - use vu_OverlayOverVideo instead).
   // same order as VU_METER_TYPES
   cboVUMeter.Items.Clear;
   cboVUMeter.Items.Add ('Disabled');
   cboVUMeter.Items.Add ('Analog');
   cboVUMeter.Items.Add ('Analog Vintage');
   cboVUMeter.Items.Add ('Bargraph');
   cboVUMeter.Items.Add ('Segment LED');
   cboVUMeter.Items.Add ('Smooth Bar');
   cboVUMeter.Items.Add ('Spectrum');
   cboVUMeter.Items.Add ('Mixing Table');

   // Ballistic presets (shortcuts that fill AttackMs/ReleaseMs/PeakHoldMs)
   cboBallisticProfile.Items.Clear;
   cboBallisticProfile.Items.Add ('(custom)');
   cboBallisticProfile.Items.Add ('Default (10 / 300 / 800 ms)');
   cboBallisticProfile.Items.Add ('VU Classic IEC (300 / 300 / 0 ms)');
   cboBallisticProfile.Items.Add ('PPM Broadcast (10 / 600 / 1500 ms)');
   cboBallisticProfile.Items.Add ('Fast Peak (1 / 1500 / 2000 ms)');
   cboBallisticProfile.Items.Add ('Slow RMS (200 / 2000 / 3000 ms)');
   cboBallisticProfile.Items.Add ('Instant (1 / 100 / 0 ms)');
   cboBallisticProfile.ItemIndex := PROFILE_CUSTOM;

   pcMain.TabIndex := 0;
   FLoading := False;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.FormShow (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   RefreshControls;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.SetBothChannels (Setting: TVUMeterSetting;
   Value: NativeInt);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FVideoGrabber = nil then Exit;
   FVideoGrabber.SetVUMeterSetting (VU_LEFT,  Setting, Value);
   FVideoGrabber.SetVUMeterSetting (VU_RIGHT, Setting, Value);
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.UpdateColorPanel (Panel: TRectangle; Color: TColor);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   Panel.Fill.Color := VclColorToAlpha (Color);
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.RefreshControls;
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FVideoGrabber = nil then Exit;
   FLoading := True;
   try
      LoadFromGrabber;
   finally
      FLoading := False;
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.LoadFromGrabber;
// Pulls every setting from the LEFT channel (VU_LEFT). Both channels are
// expected to stay in sync - if they don't, the next SetBothChannels call
// will realign the right channel.
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   i: Integer;
begin
   // Current type
   for i := 0 to cboVUMeter.Items.Count - 1 do begin
      if VU_METER_TYPES[i] = FVideoGrabber.VUMeter then begin
         cboVUMeter.ItemIndex := i;
         Break;
      end;
   end;

   // Display options
   chkOverlayOverVideo.IsChecked := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_OverlayOverVideo) <> 0;
   chkTransparent.IsChecked      := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_Transparent)      <> 0;
   chkFlipVert.IsChecked         := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_FlipVert)         <> 0;
   chkFlipHorz.IsChecked         := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_FlipHorz)         <> 0;
   chkLogarithmic.IsChecked      := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_LogarithmicScale) <> 0;

   // Overlay rect
   edtOverlayLeft.Text   := IntToStr (FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_OverlayLeft));
   edtOverlayTop.Text    := IntToStr (FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_OverlayTop));
   edtOverlayWidth.Text  := IntToStr (FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_OverlayWidth));
   edtOverlayHeight.Text := IntToStr (FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_OverlayHeight));

   // Levels (0..100 TrackBars)
   tbrWarningPercent.Value    := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_WarningPercent);
   lblWarningPercentValue.Text := IntToStr (Round(tbrWarningPercent.Value)) + ' %';
   tbrPeakPercent.Value       := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_PeakPercent);
   lblPeakPercentValue.Text   := IntToStr (Round(tbrPeakPercent.Value)) + ' %';

   // Colors
   UpdateColorPanel (pnBkgndColor,   FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_BkgndColor));
   UpdateColorPanel (pnNormalColor,  FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_NormalColor));
   UpdateColorPanel (pnWarningColor, FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_WarningColor));
   UpdateColorPanel (pnPeakColor,    FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_PeakColor));

   // Drawing
   updTickSize.Position        := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_TickSize);
   updTickInterval.Position    := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_TickInterval);
   updNeedleThickness.Position := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_NeedleThickness);

   // Ballistics
   updAttackMs.Position   := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_AttackMs);
   updReleaseMs.Position  := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_ReleaseMs);
   updPeakHoldMs.Position := FVideoGrabber.GetVUMeterSetting (VU_LEFT, vu_PeakHoldMs);
   // No attempt at guessing which preset matches the current values: stay on (custom)
   cboBallisticProfile.ItemIndex := PROFILE_CUSTOM;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.cboVUMeterChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   M: TVUMeter;
begin
   if FLoading then Exit;
   if cboVUMeter.ItemIndex < 0 then Exit;
   M := VU_METER_TYPES[cboVUMeter.ItemIndex];
   // The main form is the one that knows how to handle the panels (resize,
   // vu_Handle), so delegate to it via the callback. If no callback is set,
   // just apply the change directly to the grabber.
   if Assigned (FOnApplyType) then
      FOnApplyType (M)
   else if FVideoGrabber <> nil then
      FVideoGrabber.VUMeter := M;
   RefreshControls;
end;

// ============================================================================
//  Display options
// ============================================================================

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.chkOverlayOverVideoClick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_OverlayOverVideo, Ord (chkOverlayOverVideo.IsChecked));
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.chkTransparentClick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_Transparent, Ord (chkTransparent.IsChecked));
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.chkFlipVertClick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_FlipVert, Ord (chkFlipVert.IsChecked));
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.chkFlipHorzClick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_FlipHorz, Ord (chkFlipHorz.IsChecked));
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.chkLogarithmicClick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_LogarithmicScale, Ord (chkLogarithmic.IsChecked));
end;

// ============================================================================
//  Overlay rect
// ============================================================================

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtOverlayLeftChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   // Per-channel horizontal offset so the two meters don't overlap: the
   // left channel keeps the entered Left value, the right channel is
   // shifted by Width + 10 px (mirrors the layout of the original demo).
   if FVideoGrabber = nil then Exit;
   FVideoGrabber.SetVUMeterSetting (VU_LEFT,  vu_OverlayLeft,
      StrToIntDef (edtOverlayLeft.Text, 0));
   FVideoGrabber.SetVUMeterSetting (VU_RIGHT, vu_OverlayLeft,
      StrToIntDef (edtOverlayLeft.Text, 0)
      + StrToIntDef (edtOverlayWidth.Text, 0) + 10);
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtOverlayTopChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_OverlayTop, StrToIntDef (edtOverlayTop.Text, 0));
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtOverlayWidthChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_OverlayWidth, StrToIntDef (edtOverlayWidth.Text, 0));
   // Also re-trigger the right channel offset recompute
   edtOverlayLeftChange (nil);
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtOverlayHeightChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_OverlayHeight, StrToIntDef (edtOverlayHeight.Text, 0));
end;

// ============================================================================
//  Levels (warning / peak percent)
// ============================================================================

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.tbrWarningPercentChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   lblWarningPercentValue.Text := IntToStr (Round(tbrWarningPercent.Value)) + ' %';
   if FLoading then Exit;
   SetBothChannels (vu_WarningPercent, Round(tbrWarningPercent.Value));
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.tbrPeakPercentChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   lblPeakPercentValue.Text := IntToStr (Round(tbrPeakPercent.Value)) + ' %';
   if FLoading then Exit;
   SetBothChannels (vu_PeakPercent, Round(tbrPeakPercent.Value));
end;

// ============================================================================
//  Colors (one shared handler for the 4 buttons, dispatched via Tag)
// ============================================================================

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.btnColorClick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   Btn: TButton;
   Panel: TRectangle;
   Setting: TVUMeterSetting;
   Color: TColor;
begin
   if not (Sender is TButton) then Exit;
   Btn := TButton (Sender);
   case Btn.Tag of
      0: begin Panel := pnBkgndColor;   Setting := vu_BkgndColor;   end;
      1: begin Panel := pnNormalColor;  Setting := vu_NormalColor;  end;
      2: begin Panel := pnWarningColor; Setting := vu_WarningColor; end;
      3: begin Panel := pnPeakColor;    Setting := vu_PeakColor;    end;
   else
      Exit;
   end;
   /// FireMonkey has no color dialog: Windows ChooseColor, see FmxDemoHelpers.PickColor
   Color := AlphaToVclColor (Panel.Fill.Color);
   if PickColor (Self, Color) then begin
      Panel.Fill.Color := VclColorToAlpha (Color);
      SetBothChannels (Setting, Color);
   end;
end;

procedure TfrmVUMeterConfig.btnDisablePeakClick(Sender: TObject);
begin
   SetBothChannels (vu_PeakHoldMs, 0);
   RefreshControls;
end;

// ============================================================================
//  Drawing (tick size, tick interval, needle thickness)
//  Handlers live on the TEdit (OnChange) so both keyboard typing and the
//  associated TUpDown spinner clicks push the new value to the grabber.
//  StrToIntDef returns the current default on partial input, no harm done.
// ============================================================================

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtTickSizeChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_TickSize, StrToIntDef (edtTickSize.Text, 0));
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtTickIntervalChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_TickInterval, StrToIntDef (edtTickInterval.Text, 0));
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtNeedleThicknessChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_NeedleThickness, StrToIntDef (edtNeedleThickness.Text, 1));
end;

// ============================================================================
//  Ballistics
// ============================================================================

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.ApplyBallisticProfilePreset (ProfileIdx: Integer);
// Fills the three values (Attack/Release/PeakHold) corresponding to the
// chosen preset. This covers both worlds: if the current runtime still
// honors vu_BallisticProfile, it gets pushed too; otherwise the three
// granular settings are enough on their own.
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
var
   A, R, H: NativeInt;
begin
   case ProfileIdx of
      PROFILE_DEFAULT:    begin A :=  10; R :=  300; H :=  800; end;
      PROFILE_VU_CLASSIC: begin A := 300; R :=  300; H :=    0; end;
      PROFILE_PPM:        begin A :=  10; R :=  600; H := 1500; end;
      PROFILE_FAST_PEAK:  begin A :=   1; R := 1500; H := 2000; end;
      PROFILE_SLOW_RMS:   begin A := 200; R := 2000; H := 3000; end;
      PROFILE_INSTANT:    begin A :=   1; R :=  100; H :=    0; end;
   else
      Exit;
   end;
   // Forward-compat: also push vu_BallisticProfile (NativeInt = index into
   // the runtime-side TVUBallisticProfile enum). 0 = vub_Default.
   // Harmless if the current runtime no longer handles this setting.
   SetBothChannels (vu_AttackMs,   A);
   SetBothChannels (vu_ReleaseMs,  R);
   SetBothChannels (vu_PeakHoldMs, H);
   // Reflect the new values in the UI
   FLoading := True;
   try
      updAttackMs.Position   := A;
      updReleaseMs.Position  := R;
      updPeakHoldMs.Position := H;
   finally
      FLoading := False;
   end;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.cboBallisticProfileChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   if cboBallisticProfile.ItemIndex <= PROFILE_CUSTOM then Exit;
   ApplyBallisticProfilePreset (cboBallisticProfile.ItemIndex);
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtAttackMsChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_AttackMs, StrToIntDef (edtAttackMs.Text, 0));
   cboBallisticProfile.ItemIndex := PROFILE_CUSTOM;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtReleaseMsChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_ReleaseMs, StrToIntDef (edtReleaseMs.Text, 0));
   cboBallisticProfile.ItemIndex := PROFILE_CUSTOM;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.edtPeakHoldMsChange (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   if FLoading then Exit;
   SetBothChannels (vu_PeakHoldMs, StrToIntDef (edtPeakHoldMs.Text, 0));
   cboBallisticProfile.ItemIndex := PROFILE_CUSTOM;
end;

// ============================================================================
//  Footer
// ============================================================================

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.btnCloseClick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   Close;
end;

(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
procedure TfrmVUMeterConfig.btnRefreshClick (Sender: TObject);
(*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*)
begin
   RefreshControls;
end;

end.
