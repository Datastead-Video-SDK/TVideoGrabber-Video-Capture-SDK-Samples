#include <vcl.h>
#pragma hdrstop

#include "miscCameraControl.h"
#include "MainForm.h"
#pragma package(smart_init)
#pragma resource "*.dfm"

#pragma warn -8057

TfrmCameraControl *frmCameraControl;

__fastcall TfrmCameraControl::TfrmCameraControl(TComponent* Owner) : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TfrmCameraControl::FormCreate(TObject *Sender)
{
   FInitializing = False;

}
//---------------------------------------------------------------------------

// used because the vertical trackbar positions are inverted
void SetCameraControlVerticalTrackbarPosition (TTrackBar *TrackBar, int Position)
{
    TrackBar->Position = TrackBar->Max - Position + TrackBar->Min;
}
int GetCameraControlVerticalTrackbarPosition (TTrackBar *TrackBar)
{
    return (TrackBar->Max - TrackBar->Position + TrackBar->Min);
}
//---------------------------------------------------------------------------

void __fastcall TfrmCameraControl::InitTrackBar (TCheckBox *chkAuto, TButton *btnDefault, TTrackBar *tbrValue, TCameraControl Setting)
{
   tbrValue->Tag = Setting;
   chkAuto->Tag = Setting;
   btnDefault->Tag = Setting;

   FSettingGroup[Setting].tbrValue = tbrValue;
   FSettingGroup[Setting].chkAuto = chkAuto;
   FSettingGroup[Setting].btnDefault = btnDefault;

   if (! frmMainForm->VideoGrabber->IsCameraControlSettingAvailable (Setting)) {
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
      chkAuto->Checked = frmMainForm->VideoGrabber->CameraControlAuto (Setting);
      btnDefault->Enabled = ! chkAuto->Checked;
      tbrValue->Enabled = ! chkAuto->Checked;
      tbrValue->Min = frmMainForm->VideoGrabber->CameraControlMin (Setting);
      tbrValue->Max = frmMainForm->VideoGrabber->CameraControlMax (Setting);
      tbrValue->Frequency = frmMainForm->VideoGrabber->CameraControlStep (Setting);
	  SetCameraControlVerticalTrackbarPosition (tbrValue, frmMainForm->VideoGrabber->CameraControlValue (Setting));
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmCameraControl::InitTrackBars ()
{
   FInitializing = True;
   InitTrackBar (chkPan,      btnPan,      tbrPan,      cc_Pan);
   InitTrackBar (chkTilt,     btnTilt,     tbrTilt,     cc_Tilt);
   InitTrackBar (chkRoll,     btnRoll,     tbrRoll,     cc_Roll);
   InitTrackBar (chkZoom,     btnZoom,     tbrZoom,     cc_Zoom);
   InitTrackBar (chkExposure, btnExposure, tbrExposure, cc_Exposure);
   InitTrackBar (chkIris,     btnIris,     tbrIris,     cc_Iris);
   InitTrackBar (chkFocus,    btnFocus,    tbrFocus,    cc_Focus);
   FInitializing = False;
}
//---------------------------------------------------------------------------

void __fastcall TfrmCameraControl::OnSetValue (TObject *Sender)
{
   TCameraControl Setting;

   if (! FInitializing) {
	  Setting = TCameraControl (((TComponent*) (Sender))->Tag);
	  frmMainForm->VideoGrabber->SetCameraControl (Setting, FSettingGroup[Setting].chkAuto->Checked, False, GetCameraControlVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
      FSettingGroup[Setting].btnDefault->Enabled = ! FSettingGroup[Setting].chkAuto->Checked;
      FSettingGroup[Setting].tbrValue->Enabled = ! FSettingGroup[Setting].chkAuto->Checked;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmCameraControl::OnSetDefault (TObject *Sender)
{
   TCameraControl Setting;

   if (! FInitializing) {
      Setting = TCameraControl (((TComponent*) (Sender))->Tag);
      frmMainForm->VideoGrabber->SetCameraControl (Setting, FSettingGroup[Setting].chkAuto->Checked, True, GetCameraControlVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue));
	  SetCameraControlVerticalTrackbarPosition (FSettingGroup[Setting].tbrValue, frmMainForm->VideoGrabber->CameraControlValue (Setting));
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmCameraControl::FormShow(TObject *Sender)
{
   InitTrackBars();
}
//---------------------------------------------------------------------------

void __fastcall TfrmCameraControl::btnCloseClick(TObject *Sender)
{
   Close();
}
//---------------------------------------------------------------------------





