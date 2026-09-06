#include <vcl.h>
#pragma hdrstop

#include "miscVideoQuality.h"
#include "MainForm.h"
#pragma package(smart_init)
#pragma resource "*.dfm"

#pragma warn -8057

TfrmVideoQuality *frmVideoQuality;

__fastcall TfrmVideoQuality::TfrmVideoQuality(TComponent* Owner) : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoQuality::FormCreate(TObject *Sender)
{
   FInitializing = False;

}
//---------------------------------------------------------------------------

// used because the vertical trackbar positions are inverted
void SetVideoQualityVerticalTrackbarPosition (TTrackBar *TrackBar, int Position)
{
    TrackBar->Position = TrackBar->Max - Position + TrackBar->Min;
}
int GetVideoQualityVerticalTrackbarPosition (TTrackBar *TrackBar)
{
    return (TrackBar->Max - TrackBar->Position + TrackBar->Min);
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoQuality::InitTrackBar (TCheckBox *chkAuto, TButton *btnDefault, TTrackBar *tbrValue, TVideoQuality Setting)
{
   tbrValue->Tag = Setting;
   chkAuto->Tag = Setting;
   btnDefault->Tag = Setting;

   FSettingGroup[Setting].tbrValue = tbrValue;
   FSettingGroup[Setting].chkAuto = chkAuto;
   FSettingGroup[Setting].btnDefault = btnDefault;

   if (! frmMainForm->VideoGrabber->IsVideoQualitySettingAvailable (Setting)) {
      tbrValue->Enabled = False;
      tbrValue->Frequency = 0;
      tbrValue->Min = 0;
      tbrValue->Max = 1;
      tbrValue->Position = 1;
      chkAuto->Enabled = False;
      btnDefault->Enabled = False;
   }
   else {
      chkAuto->Enabled = True;
      chkAuto->Checked = frmMainForm->VideoGrabber->VideoQualityAuto (Setting);
      tbrValue->Enabled = ! chkAuto->Checked;
      btnDefault->Enabled = ! chkAuto->Checked;
      tbrValue->Min = frmMainForm->VideoGrabber->VideoQualityMin (Setting);
      tbrValue->Max = frmMainForm->VideoGrabber->VideoQualityMax (Setting);
      tbrValue->Frequency = frmMainForm->VideoGrabber->VideoQualityStep (Setting);
	  SetVideoQualityVerticalTrackbarPosition (tbrValue, frmMainForm->VideoGrabber->VideoQualityValue (Setting));
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoQuality::InitTrackBars ()
{
   FInitializing = True;
   InitTrackBar (chkBrightness,    btnBrightness,   tbrBrightness,   vq_Brightness);
   InitTrackBar (chkContrast,      btnContrast,     tbrContrast,     vq_Contrast);
   InitTrackBar (chkHue,           btnHue,          tbrHue,          vq_Hue);
   InitTrackBar (chkSaturation,    btnSaturation,   tbrSaturation,   vq_Saturation);
   InitTrackBar (chkSharpness,     btnSharpness,    tbrSharpness,    vq_Sharpness);
   InitTrackBar (chkGamma,         btnGamma,        tbrGamma,        vq_Gamma);
   InitTrackBar (chkWhiteBalance,  btnWhiteBalance, tbrWhiteBalance, vq_WhiteBalance);
   InitTrackBar (chkGain,          btnGain,         tbrGain,         vq_Gain);
   InitTrackBar (chkBacklight,     btnBacklight,    tbrBacklight,    vq_BacklightCompensation);
   InitTrackBar (chkColorEnable,   btnColorEnable,  tbrColorEnable,  vq_ColorEnable);
   FInitializing = False;
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoQuality::OnSetValue (TObject *Sender)
{
   TVideoQuality Setting;

   if (! FInitializing) {
      Setting = TVideoQuality (((TComponent*) (Sender))->Tag);
      frmMainForm->VideoGrabber->SetVideoQuality (Setting, FSettingGroup[Setting].chkAuto->Checked, False, GetVideoQualityVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
      FSettingGroup[Setting].tbrValue->Enabled = ! FSettingGroup[Setting].chkAuto->Checked;
      FSettingGroup[Setting].btnDefault->Enabled = ! FSettingGroup[Setting].chkAuto->Checked;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoQuality::OnSetDefault (TObject *Sender)
{
   TVideoQuality Setting;

   if (! FInitializing) {
      Setting = TVideoQuality (((TComponent*) (Sender))->Tag);
	  frmMainForm->VideoGrabber->SetVideoQuality (Setting, FSettingGroup[Setting].chkAuto->Checked, True, GetVideoQualityVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
	  SetVideoQualityVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue, frmMainForm->VideoGrabber->VideoQualityValue (Setting));
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoQuality::FormShow(TObject *Sender)
{
   InitTrackBars();
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoQuality::btnCloseClick(TObject *Sender)
{
   Close();
}
//---------------------------------------------------------------------------


