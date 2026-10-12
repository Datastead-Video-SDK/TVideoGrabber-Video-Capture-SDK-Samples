/// GENERATED from the VCL MainDemo by Sources\DEMOS\FmxDemoGen\regen_fmx_demo.cmd: do not edit,
/// the changes are overwritten by the next generation. Edit the VCL MainDemo, or the generator.
unit miscVideoQuality;

interface

uses
  VidGrab,
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Classes, System.Types,
  System.UITypes, FMX.Types, FMX.Controls, FMX.Forms, FMX.Graphics, FMX.Dialogs, FMX.StdCtrls,
  FMX.Controls.Presentation, FMX.Edit;

type
  TSettingGroup = record
     tbrValue: TTrackbar;
     chkAuto: TCheckBox;
     btnDefault: TButton;
  end;

  TfrmVideoQuality = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    btnClose: TButton;
    tbrHue: TTrackBar;
    tbrContrast: TTrackBar;
    tbrSaturation: TTrackBar;
    tbrBrightness: TTrackBar;
    tbrSharpness: TTrackBar;
    tbrGamma: TTrackBar;
    tbrWhiteBalance: TTrackBar;
    chkBrightness: TCheckBox;
    chkContrast: TCheckBox;
    chkHue: TCheckBox;
    chkSaturation: TCheckBox;
    chkSharpness: TCheckBox;
    chkGamma: TCheckBox;
    chkWhiteBalance: TCheckBox;
    btnBrightness: TButton;
    btnContrast: TButton;
    btnHue: TButton;
    btnSaturation: TButton;
    btnSharpness: TButton;
    btnGamma: TButton;
    btnWhiteBalance: TButton;
    tbrGain: TTrackBar;
    btnGain: TButton;
    chkGain: TCheckBox;
    tbrBacklight: TTrackBar;
    btnBacklight: TButton;
    chkBacklight: TCheckBox;
    tbrColorEnable: TTrackBar;
    btnColorEnable: TButton;
    chkColorEnable: TCheckBox;
    procedure btnCloseClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure OnSetValue (Sender: TObject);
    procedure OnSetDefault (Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
     FSettingGroup: array[low(TVideoQuality)..high(TVideoQuality)] of TSettingGroup;
     FInitializing: Boolean;
     procedure InitTrackBar (chkAuto: TCheckBox; btnDefault: TButton; tbrValue: TTrackBar; Setting: TVideoQuality);
  public
     constructor Create (AOwner: TComponent); override;
     procedure InitTrackBars;
  end;

var
  frmVideoQuality: TfrmVideoQuality;

implementation

uses MainForm;

{$R *.fmx}

// ----------------------------------------------------
// used because the vertical trackbar positions are inverted
procedure SetVerticalTrackbarPosition (Trackbar: TTrackbar; Position: Integer);
begin
    Trackbar.Value := Trackbar.Max - Position + Trackbar.Min;
end;
function GetVerticalTrackbarPosition (Trackbar: TTrackbar): Integer;
begin
    Result := Round (Trackbar.Max - Trackbar.Value + Trackbar.Min);
end;
// ----------------------------------------------------

constructor TfrmVideoQuality.Create (AOwner: TComponent);
begin
   /// FireMonkey: change events may occur while the form is loading, OnSetValue must ignore them
   /// (FormCreate resets FInitializing)
   FInitializing := True;
   inherited Create (AOwner);
end;

procedure TfrmVideoQuality.FormCreate(Sender: TObject);
begin
   FInitializing := False;
end;

procedure TfrmVideoQuality.InitTrackBar (chkAuto: TCheckBox; btnDefault: TButton; tbrValue: TTrackBar; Setting: TVideoQuality);
begin
   tbrValue.Tag := integer (Setting);
   chkAuto.Tag := integer (Setting);
   btnDefault.Tag := integer (Setting);

   FSettingGroup[Setting].tbrValue := tbrValue;
   FSettingGroup[Setting].chkAuto := chkAuto;
   FSettingGroup[Setting].btnDefault := btnDefault;

   if not frmMainForm.VideoGrabber.IsVideoQualitySettingAvailable (Setting) then begin
      tbrValue.Enabled := False;
      tbrValue.Frequency := 0;
      tbrValue.Min := 0;
      tbrValue.Max := 1;
      tbrValue.Value := 1;
      ChkAuto.Enabled := False;
      btnDefault.Enabled := False;
   end
   else begin
      ChkAuto.Enabled := True;
      ChkAuto.IsChecked := frmMainForm.VideoGrabber.VideoQualityAuto (Setting);
      tbrValue.Enabled := not ChkAuto.IsChecked;
      btnDefault.Enabled := not ChkAuto.IsChecked;
      tbrValue.Min := frmMainForm.VideoGrabber.VideoQualityMin (Setting);
      tbrValue.Max := frmMainForm.VideoGrabber.VideoQualityMax (Setting);
      tbrValue.Frequency := frmMainForm.VideoGrabber.VideoQualityStep (Setting);
      SetVerticalTrackbarPosition (tbrValue, frmMainForm.VideoGrabber.VideoQualityValue (Setting));
   end;
end;


procedure TfrmVideoQuality.InitTrackBars;
begin
   FInitializing := True;
   InitTrackBar (chkBrightness,    btnBrightness,   tbrBrightness,   vq_Brightness);
   InitTrackBar (chkContrast,      btnContrast,     tbrContrast,     vq_Contrast);
   InitTrackBar (chkHue,           btnHue,          tbrHue,          vq_Hue);
   InitTrackBar (chkSaturation,    btnSaturation,   tbrSaturation,   vq_Saturation);
   InitTrackBar (chkSharpness,     btnSharpness,    tbrSharpness,    vq_Sharpness);
   InitTrackBar (chkGamma,         btnGamma,        tbrGamma,        vq_Gamma);
   InitTrackBar (chkWhiteBalance,  btnWhiteBalance, tbrWhiteBalance, vq_WhiteBalance);
   InitTrackBar (chkGain,          btnGain,         tbrGain,         vq_Gain);
   InitTrackBar (chkBacklight,     btnBacklight,    tbrBackLight,    vq_BacklightCompensation);
   InitTrackBar (chkColorEnable,   btnColorEnable,  tbrColorEnable,  vq_ColorEnable);
   FInitializing := False;
end;

procedure TfrmVideoQuality.OnSetValue (Sender: TObject);
var
   Setting: TVideoQuality;
begin
   if FInitializing then Exit;
   Setting := TVideoQuality (TComponent(Sender).Tag);
   frmMainForm.VideoGrabber.SetVideoQuality (Setting, FSettingGroup[Setting].ChkAuto.IsChecked, False, GetVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
   FSettingGroup[Setting].tbrValue.Enabled := not FSettingGroup[Setting].ChkAuto.IsChecked;
   FSettingGroup[Setting].btnDefault.Enabled := not FSettingGroup[Setting].ChkAuto.IsChecked;
end;

procedure TfrmVideoQuality.OnSetDefault (Sender: TObject);
var
   Setting: TVideoQuality;
begin
   if FInitializing then Exit;
   Setting := TVideoQuality (TComponent(Sender).Tag);
   frmMainForm.VideoGrabber.SetVideoQuality (Setting, FSettingGroup[Setting].ChkAuto.IsChecked, True, GetVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
   SetVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue, frmMainForm.VideoGrabber.VideoQualityValue (Setting));
end;

procedure TfrmVideoQuality.FormShow(Sender: TObject);
begin
   frmVideoQuality.InitTrackBars;
end;

procedure TfrmVideoQuality.btnCloseClick(Sender: TObject);
begin
   Close;
end;

end.
