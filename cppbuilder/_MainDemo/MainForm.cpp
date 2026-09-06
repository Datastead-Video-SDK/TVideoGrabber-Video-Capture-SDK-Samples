//---------------------------------------------------------------------------
#include <vcl.h>
#include <jpeg.hpp>
#include <shellapi.h>
#include <typinfo.hpp>
#pragma hdrstop

#include "miscCameraControl.h"
#include "miscVideoQuality.h"
#include "MainForm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "VidGrab"
#pragma resource "*.dfm"

#pragma warn -8057

#ifndef NativeInt
#define NativeInt int
#endif

TfrmMainForm *frmMainForm;

   const String AUDIO_CLIPS = "*.mp3;*.wav;*.wma;*.mid";
   const String VIDEO_CLIPS = "*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.webm;*.ts;*.m4v;*.mp4v;*.ogg;*.amv;*.rm;*.m2t*";
   const String IMAGE_FILES = "*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png";
   const String OPEN_MEDIA_FILES = "All media files|" + VIDEO_CLIPS + ";" + AUDIO_CLIPS + ";" + IMAGE_FILES
                    + "|Video clips|" + VIDEO_CLIPS
                    + "|Audio clips|" + AUDIO_CLIPS;
   const String OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES
                    + "|Image files|" + IMAGE_FILES;
   const String OPEN_IMAGE_FILES = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg";

#if __BORLANDC__ <= 0x550
df
//---------------------------------------------------------------------------
Extended StrToFloatDef(String S, const Extended Default)
{
  Extended Result;
  if (! TextToFloat(S.c_str(), &Result, fvExtended)) {
     Result = Default;
  }
  return Result;
}
#endif

//---------------------------------------------------------------------------
__fastcall TfrmMainForm::TfrmMainForm(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall AssignListToComboBox (TComboBox* ComboBox, String List, int Index)
{
   ComboBox->Items->Text = List;
   if (ComboBox->Items->Count > 0) {
      ComboBox->ItemIndex = Index;
   }
}
//---------------------------------------------------------------------------

void UpdateFont(TControl *Control)
{
   TFont *f;
   if (IsPublishedProp(Control, "Parentfont")) {
      if (GetOrdProp(Control, "Parentfont") == 0) {
         if (IsPublishedProp(Control, "font")) {
            f = (TFont*) GetObjectProp(Control, "font", __classid(TFont));
            f->Name = "Arial";
            f->Size = 9;
         }
      }
   }
}
//---------------------------------------------------------------------------

void UpdateFonts (TWinControl *ctrl)
{
   int i;

  UpdateFont(ctrl);
  for (i = 0; i < ctrl->ControlCount ; i ++) {
     if (ctrl->Controls[i]->InheritsFrom(__classid(TWinControl))) {
        UpdateFonts((TWinControl*)ctrl->Controls[i]);
     }
     else {
        UpdateFont(ctrl->Controls[i]);
     }
  }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::FormCreate(TObject *Sender)
{

   UpdateFonts(this); /// for cosmetic purpose only

   VideoGrabber->AutoRefreshPreview = true;  // the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

   FiFreeHandMouseDrawing = 0;                // used for free-hand mouse drawing
   FFreeHandMouseDrawingEnabled = false;      // used for free-hand mouse drawing
   FSearchBmpOrJPEGFilesOpened = false;       // used for the "video from bitmaps" in the VideoGrabberVideoFromBitmaps_NextFrameNeeded event

   FKBWritten_LastReportTime = 0;             // used to store the last time, to report periodically the KB written from the OnFrameProgress2 event (in this demo every 5 seconds)

   FDisplaySelected = 0;

   FImageOverlayIndex = 0;
   FTextOverlayIndex = 0;

   FStartupWidth = Width;
   FStartupHeight = Height;

   FMultipurposeUDPStreamingID = -1;

   //pctMain->ActivePage = tbsVideoDevice;

   // - controls using global TVideoGrabber properties, e.g. like the VideoDevices list, are updated from the FormCreate event
   // - controls that depend of the current video device are set in the OnVideoDeviceSelected event
   // - controls that depend of the current audio device are set in the OnAudioDeviceSelected event


   ///////////////////////// Controls on main form
   edtoragePath->Text = VideoGrabber->StoragePath;

   ///////////////////////// Video source tab
   AssignListToComboBox (cboVideoSource, VideoGrabber->VideoSources, VideoGrabber->VideoSource);
   AssignListToComboBox (cboVideoDevices, VideoGrabber->VideoDevices, VideoGrabber->VideoDevice);
   btnAutoRefreshPreview->Checked = VideoGrabber->AutoRefreshPreview;
   cboVideoSource->ItemIndex = VideoGrabber->VideoSource;
   chkScreenRecordingWithCursor->Checked = VideoGrabber->ScreenRecordingWithCursor;
   edtMonitorNumber->Text = IntToStr (VideoGrabber->ScreenRecordingMonitor);
   VideoGrabber->VideoSource_FileOrURL = edtVideoSourceFileOrUrl->Text;

   ///////////////////////// Audio tab
   AssignListToComboBox (cboAudioDevices, VideoGrabber->AudioDevices, VideoGrabber->AudioDevice);
   AssignListToComboBox (cboAudioRenderers, VideoGrabber->AudioRenderers, VideoGrabber->AudioRenderer);
   chkRenderAudioDevice->Checked = VideoGrabber->AudioDeviceRendering;
   chkMuteAudioRendering->Checked = VideoGrabber->MuteAudioRendering;

   ///////////////////////// RECORDING tab
   rdgRecordingMethod->ItemIndex = VideoGrabber->RecordingMethod;
   grbRecordingTimer->ItemIndex = VideoGrabber->RecordingTimer;
   chkRecordingCanPause->Checked = VideoGrabber->RecordingCanPause;
   if (VideoGrabber->RecordingFileName > "") {
      edtRecordingFileName->Text = VideoGrabber->RecordingFileName;
      chkAVISaveToThisFile->Checked = true;
   }
   chkRecordingPauseCreatesNewFile->Checked = VideoGrabber->RecordingPauseCreatesNewFile;
   chkPreserveNativeFormat->Checked = VideoGrabber->RecordingInNativeFormat;

   rdgCompressMode->ItemIndex = VideoGrabber->CompressionMode;
   chkAudioRecording->Checked = VideoGrabber->AudioRecording;

   AssignListToComboBox (cboVideoCompressors, VideoGrabber->VideoCompressors, VideoGrabber->VideoCompressor);
   AssignListToComboBox (cboAudioCompressors, VideoGrabber->AudioCompressors, VideoGrabber->AudioCompressor);

   ///////////////////////// IP Camera tab

   chkOpenURLAsync->Checked = VideoGrabber->OpenURLAsync;   
   tbrPTZSpeedRatio->Position = 100; // speed ratio in the 0..1 range and trackbar in the 0..100 range, so value = trackbar position / 100
   FPTZMoveDurationMs = 300; // 300 ms
   FPTZRelativeMove = 0.01;
   FPTZSpeedRatio = 0.5; //
   FUpdatingPTZTrackbars = false;

   ///////////////////////// Player tab
   edtPlayerSpeedRatio->Text = FormatFloat ("0.0", VideoGrabber->PlayerSpeedRatio);

   updPlayerFastSeekSpeed->Position = (short) VideoGrabber->PlayerFastSeekSpeedRatio;
   edtPlayerFastSeekSpeed->Text = IntToStr (VideoGrabber->PlayerFastSeekSpeedRatio);

   rdgHwAccel->ItemIndex = THwAccel (VideoGrabber->PlayerHwAccel);

   btnAutoPlay->Checked = VideoGrabber->AutoStartPlayer;
   chkPlayerAudioRendering->Checked = VideoGrabber->PlayerAudioRendering;
   chkUseClock->Checked = VideoGrabber->UseClock;
   chkRefreshPausedDisplay->Checked = VideoGrabber->PlayerRefreshPausedDisplay;

   ///////////////////////// Frame grabber tab
   edtAVIAutoFilePrefix->Text = VideoGrabber->AutoFilePrefix;
   rgdFrameGrabberFormat->ItemIndex = VideoGrabber->FrameGrabberRGBFormat;
   rgdFrameGrabber->ItemIndex = VideoGrabber->FrameGrabber;
   cboAutoFileName->ItemIndex = VideoGrabber->AutoFileName;
   edtFrameCaptureWidth->Text = IntToStr (VideoGrabber->FrameCaptureWidth);
   edtFrameCaptureHeight->Text = IntToStr (VideoGrabber->FrameCaptureHeight);

   ///////////////////////// Frame capture tab
   edtBurstCount->Text = IntToStr (VideoGrabber->BurstCount);
   edtBurstInterval->Text = IntToStr (VideoGrabber->BurstInterval);
   tbrCaptureZoomSize->Position = VideoGrabber->FrameCaptureZoomSize;

   ///////////////////////// Motion detection tab

   chkMotionDetectionEnabled->Checked = VideoGrabber->MotionDetector_Enabled;
   chkCompareRed->Checked = VideoGrabber->MotionDetector_CompareRed;
   chkCompareGreen->Checked = VideoGrabber->MotionDetector_CompareGreen;
   chkCompareBlue->Checked = VideoGrabber->MotionDetector_CompareBlue;
   chk_GreyScale->Checked = VideoGrabber->MotionDetector_GreyScale;
   chkReduceVideoNoise->Checked = VideoGrabber->MotionDetector_ReduceVideoNoise;
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
   edtGridColCount->Text = IntToStr (VideoGrabber->MotionDetector_GridXCount);
   edtGridRowCount->Text = IntToStr (VideoGrabber->MotionDetector_GridYCount);
   chkTriggered->Checked = VideoGrabber->MotionDetector_Triggered;

   ///////////////////////// Overlay tab
   rdgTextOverlaySelector->ItemIndex = 0;
   rdgTextOverlaySelectorClick (this); // reload the settings for the text overlay with index 0
   chkAdjustOverlayAspectRatio->Checked = VideoGrabber->AdjustOverlayAspectRatio;

   rdgImageOverlaySelector->ItemIndex = 0;
   rdgImageOverlaySelectorClick (this);  // reload the settings for the image overlay with index 0

   ///////////////////////// Video processing tab
   rdgVideoRotation->ItemIndex = VideoGrabber->VideoProcessing_Rotation;
   tbrBrightness->Position = - VideoGrabber->VideoProcessing_Brightness;
   tbrConstrast->Position = - VideoGrabber->VideoProcessing_Contrast;
   tbrSaturation->Position = - VideoGrabber->VideoProcessing_Saturation;
   tbrHue->Position = VideoGrabber->VideoProcessing_Hue;
   edtCustomRotationAngle->Text = FormatFloat ("0.00", VideoGrabber->VideoProcessing_RotationCustomAngle);

   rdgDeinterlacing->ItemIndex = VideoGrabber->VideoProcessing_Deinterlacing;
   chkGreyScale->Checked = VideoGrabber->VideoProcessing_GrayScale;
   chkInvertColors->Checked = VideoGrabber->VideoProcessing_InvertColors;
   chkFlipVertical->Checked = VideoGrabber->VideoProcessing_FlipVertical;
   chkFlipHorizontal->Checked = VideoGrabber->VideoProcessing_FlipHorizontal;

   chkCroppingEnabled->Checked = VideoGrabber->Cropping_Enabled;
   chkCroppingOutbounds->Checked = VideoGrabber->Cropping_Outbounds;
   edtCroppingWidth->Text = IntToStr (VideoGrabber->Cropping_Width);
   edtCroppingHeight->Text = IntToStr (VideoGrabber->Cropping_Height);
   trkCroppingZoom->Position = VideoGrabber->Cropping_Zoom * 100;

   // trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event
   trkCroppingY->Position = VideoGrabber->Cropping_Y;
   trkCroppingX->Position = VideoGrabber->Cropping_X;


   ///////////////////////// Display tab
   chkVideoVisibleWhenStopped->Checked = VideoGrabber->VideoVisibleWhenStopped;
   chkAdjustPixelAspectRatio->Checked = VideoGrabber->AdjustPixelAspectRatio;
   chkBorder->Checked = VideoGrabber->BorderStyle == bsSingle;
   chkTransparency->Checked = VideoGrabber->ColorKeyEnabled;
   rdgVideoRenderer->ItemIndex = VideoGrabber->VideoRenderer;
   RefreshDisplayOptions();

   ///////////////////////// reencoding tab
   chkWMVOutput->Checked = VideoGrabber->Reencoding_WMVOutput;
   chkIncludeVideoStream->Checked = VideoGrabber->Reencoding_IncludeVideoStream;
   chkIncludeAudioStream->Checked = VideoGrabber->Reencoding_IncludeAudioStream ;
   chkUseFrameGrabber->Checked = VideoGrabber->Reencoding_UseFrameGrabber;
   chkUseCurrentVideoCompressor->Checked = VideoGrabber->Reencoding_UseVideoCompressor;
   chkUseCurrentAudioCompressor->Checked = VideoGrabber->Reencoding_UseAudioCompressor;
   edtReencStartTime->Text = IntToStr (VideoGrabber->Reencoding_StartTime);
   edtReencStartFrame->Text = IntToStr (VideoGrabber->Reencoding_StartFrame);
   edtReencStopTime->Text = IntToStr (VideoGrabber->Reencoding_StopTime);
   edtReencStopFrame->Text = IntToStr (VideoGrabber->Reencoding_StopFrame);
   rdgReencodingMethod->ItemIndex = Integer (VideoGrabber->Reencoding_Method);
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                            VIDEO DEVICE TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::VideoGrabberVideoDeviceSelected(
      TObject *Sender)
{
   // from this event update the properties that depend of the current video capture device->
   // This event occurs when you assign a new value to the VideoDevice property->

   AssignListToComboBox (cboVideoSizes, VideoGrabber->VideoSizes, VideoGrabber->VideoSize);
   AssignListToComboBox (cboVideoSubtypes, VideoGrabber->VideoSubtypes, VideoGrabber->VideoSubtype);
   AssignListToComboBox (cboAnalogVideoStandard, VideoGrabber->AnalogVideoStandards, VideoGrabber->AnalogVideoStandard);
   AssignListToComboBox (cboVideoInputs, VideoGrabber->VideoInputs, VideoGrabber->VideoInput);

   RefreshDeviceControls();
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboVideoSourceChange(TObject *Sender)
{
  switch (cboVideoSource->ItemIndex) {
     case 0: VideoGrabber->VideoSource = vs_VideoCaptureDevice; break;
     case 1: VideoGrabber->VideoSource = vs_ScreenRecording;  break;
     case 2: VideoGrabber->VideoSource = vs_VideoFileOrURL; break;
     case 3: VideoGrabber->VideoSource = vs_JPEGsOrBitmaps; break;
     case 4: VideoGrabber->VideoSource = vs_IPCamera; break;
     default:
        mmoLog->Lines->Add ("this option is not demonstrated in this demo");
  }
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::cboVideoDevicesChange(TObject *Sender)
{
   VideoGrabber->VideoDevice = cboVideoDevices->ItemIndex;
   // when selecting another video device, the OnVideoDeviceSelected event occurs.
   // be sure to refresh all your device-dependent controls from this event.
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartPreviewClick(TObject *Sender)
{
   VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStopPreviewClick(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPausePreviewClick(TObject *Sender)
{
   VideoGrabber->PausePreview();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResumePreviewClick(TObject *Sender)
{
   VideoGrabber->ResumePreview();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAutoRefreshPreviewClick(TObject *Sender)
{
   VideoGrabber->AutoRefreshPreview = btnAutoRefreshPreview->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkEnableSnapshotButtonClick(TObject *Sender)
{
   if (chkEnableSnapshotButton->Enabled) {
      VideoGrabber->WebcamStillCaptureButton = wb_Enabled;
   }
   else {
      VideoGrabber->WebcamStillCaptureButton = wb_Disabled;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboVideoInputsChange(TObject *Sender)
{
   VideoGrabber->VideoInput = cboVideoInputs->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboVideoSizesChange(TObject *Sender)
{
   VideoGrabber->VideoSize = cboVideoSizes->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboAnalogVideoStandardChange(TObject *Sender)
{
   VideoGrabber->AnalogVideoStandard = cboAnalogVideoStandard->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboVideoSubtypesChange(TObject *Sender)
{
   VideoGrabber->VideoSubtype = cboVideoSubtypes->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkSetLogoClick(TObject *Sender)
{
   if (chkSetLogo->Checked) {
      VideoGrabber->SetLogoFromTImage (imgLogo);
      VideoGrabber->LogoLayout = lg_Stretched;
      VideoGrabber->LogoDisplayed = true;
   }
   else {
      VideoGrabber->LogoDisplayed = false;
   }
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::btnDeviceDialogClick(TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_VideoDevice);
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::btnCameraControlDialogClick(TObject *Sender)
{
   ShowFormAboveVideo (frmCameraControl);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnVideoQualityDialogClick(TObject *Sender)
{
   ShowFormAboveVideo (frmVideoQuality);
}
//---------------------------------------------------------------------------



void __fastcall TfrmMainForm::btnSelectFileOrUrlClick(TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES;
   if (OpenDlg->Execute()) {
      edtVideoSourceFileOrUrl->Text = OpenDlg->FileName;
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnUrlConfClick(TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_NetShowConfig);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnFrameRateClick(TObject *Sender)
{
   float Value;

   Value = StrToFloatDef (edtFrameRate->Text, -1); // replace by StrToFloat (edtFrameRate->Text) in case of compilation error
   VideoGrabber->FrameRate = Value;
   if (VideoGrabber->CurrentState == cs_Preview) {
      mmoLog->Lines->Add ("current frame rate: " + FormatFloat ("0.00", VideoGrabber->CurrentFrameRate) + " fps.");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAboutFrameRateClick(TObject *Sender)
{
   ShowMessage ("0 means that the default frame rate of the device will be used.\nAfter the OnPreviewStarted or OnRecordingStarted event occurs,\nits value is available in the CurrentFrameRate property.");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtVideoSourceFileOrUrlChange(
	  TObject *Sender)
{
   VideoGrabber->VideoSource_FileOrURL = edtVideoSourceFileOrUrl->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoSourceFileOrUrl_UserNameChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_StreamingUrl, VideoSourceFileOrUrl_UserName->Text, VideoSourceFileOrUrl_Password->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoSourceFileOrUrl_PasswordChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_StreamingUrl, VideoSourceFileOrUrl_UserName->Text, VideoSourceFileOrUrl_Password->Text);
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::btnDemoURLClick(TObject *Sender)
{
   ShellExecute(0, L"open", L"http://www.datastead.com/demo/StreamingURL.htm", NULL, NULL, SW_SHOW);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnScreenRecordingWindowClick(
      TObject *Sender)
{
   VideoGrabber->SetWindowRecordingByName (edtScreenRecordingWindow->Text, false); // set to "true" for an exact and case-sensitive match
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkScreenRecordingWithCursorClick(
      TObject *Sender)
{
   VideoGrabber->ScreenRecordingWithCursor = chkScreenRecordingWithCursor->Checked;
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::edtMonitorNumberChange(TObject *Sender)
{
   VideoGrabber->ScreenRecordingMonitor = StrToIntDef (edtMonitorNumber->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnMonitorNumberInfoClick(TObject *Sender)
{
   ShowMessage ("-1 = whole desktop (across monitors)    0 = 1st monitor     1 = 2nd monitor     etc...");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPreviewStarted(TObject *Sender)
{
   mmoLog->Lines->Add ("");
   mmoLog->Lines->Add ("video source size: " + IntToStr (VideoGrabber->VideoWidth) + "x" + IntToStr (VideoGrabber->VideoHeight));
   mmoLog->Lines->Add ("display aspect ratio: " + IntToStr (VideoGrabber->VideoWidth_PreferredAspectRatio) + "x" + IntToStr (VideoGrabber->VideoHeight_PreferredAspectRatio));
   mmoLog->Lines->Add ("current frame rate: " + FormatFloat ("0.00", VideoGrabber->CurrentFrameRate) + " fps.");
   mmoLog->Lines->Add ("");
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                           AUDIO TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::VideoGrabberAudioDeviceSelected(
      TObject *Sender)
{
   // from this event set the parameters that change when the current audio capture device change

   cboAudioDevices->ItemIndex = VideoGrabber->AudioDevice; // be sure the listbox index matches the current index value

   AssignListToComboBox (cboAudioInputs, VideoGrabber->AudioInputs, VideoGrabber->AudioInput);
   tbrAudioInputLevel->Position = VideoGrabber->AudioInputLevel;
   tbrAudioInputBalance->Position = VideoGrabber->AudioInputBalance;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartAudioRenderingClick(TObject *Sender)
{
   VideoGrabber->StartAudioRendering();
   if (! VideoGrabber->AudioDeviceRendering) {
      if (btnStartAudioRendering->Tag == 0) {
         btnStartAudioRendering->Tag = 1; // to show the popup only one time
         ShowMessage ("StartAudioRendering acts as 'preview', e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers");
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartWAVRecordingClick(TObject *Sender)
{
   VideoGrabber->RecordingMethod = rm_AVI;
   VideoGrabber->CompressionMode = cm_NoCompression;
   VideoGrabber->StartAudioRecording();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartMP3RecordingClick(TObject *Sender)
{
   VideoGrabber->RecordingMethod = rm_AVI;
   VideoGrabber->CompressionMode = cm_CompressOnTheFly;
   VideoGrabber->CompressionType = ct_Audio;
   VideoGrabber->AudioCompressor = VideoGrabber->FindIndexInListByName (VideoGrabber->AudioCompressors, "LAME Audio Encoder", false, true);
   if (VideoGrabber->AudioCompressor == -1) {
      ShowMessage ("The LAME 3.99.5 DirectShow Filter is required, download it from https://www.rarewares.org/mp3-lame-dshow-acm.php and register lame.ax with regsvr32.exe");
   }
   else {
      VideoGrabber->StartAudioRecording();
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStopAudioClick(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkUseAudioOfVideoCaptureDeviceClick(
      TObject *Sender)
{
   if (chkUseAudioOfVideoCaptureDevice->Checked) {
      VideoGrabber->VideoDevice = 0; // in this demo, by default we choose the 1st
   }
   else {
      VideoGrabber->VideoDevice = -1; // this deactivates the video capture device
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkRenderAudioDeviceClick(TObject *Sender)
{
   VideoGrabber->AudioDeviceRendering = chkRenderAudioDevice->Checked;
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::cboAudioDevicesChange(TObject *Sender)
{
   VideoGrabber->AudioDevice = cboAudioDevices->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnDlgAudioDeviceClick(TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_AudioDevice);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboAudioInputsChange(TObject *Sender)
{
   VideoGrabber->AudioInput = cboAudioInputs->ItemIndex;
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::tbrAudioInputLevelChange(TObject *Sender)
{
   VideoGrabber->AudioInputLevel = tbrAudioInputLevel->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrAudioInputBalanceChange(TObject *Sender)
{
   VideoGrabber->AudioInputBalance = tbrAudioInputBalance->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboAudioRenderersChange(TObject *Sender)
{
   VideoGrabber->AudioRenderer = cboAudioRenderers->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrAudioVolumeChange(TObject *Sender)
{
   VideoGrabber->AudioVolume = tbrAudioVolume->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrAudioBalanceChange(TObject *Sender)
{
   VideoGrabber->AudioBalance = tbrAudioBalance->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkMuteAudioRenderingClick(TObject *Sender)
{
   VideoGrabber->MuteAudioRendering = chkMuteAudioRendering->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgVUMetersClick(TObject *Sender)
{
   int VU_LEFT = 0;
   int VU_RIGHT = 1;

   switch (rdgVUMeters->ItemIndex) {
      case 0: {
         VideoGrabber->VuMeter = vu_Disabled;
      }; break;
      case 1: {
         VideoGrabber->VuMeter = vu_Analog;

         pnLeftVUMeter->Width = (pnLeftVUMeter->Height * 4) / 3;
         pnRightVUMeter->Width = (pnRightVUMeter->Height * 4) / 3;

         VideoGrabber->SetVUMeterSetting (VU_LEFT, vu_BkgndColor, clBlack);
         VideoGrabber->SetVUMeterSetting (VU_RIGHT, vu_BkgndColor, clBlack);
      }; break;
      case 2: {
         VideoGrabber->VuMeter = vu_Bargraph;

         pnLeftVUMeter->Width = (pnLeftVUMeter->Height * 2) / 10;
         pnRightVUMeter->Width = (pnRightVUMeter->Height * 2) / 10;

         VideoGrabber->SetVUMeterSetting (VU_LEFT, vu_BkgndColor, TColor (0x404040));
         VideoGrabber->SetVUMeterSetting (VU_RIGHT, vu_BkgndColor, TColor (0x404040));
      }; break;
   }
   if (VideoGrabber->VuMeter != vu_Disabled) {
      VideoGrabber->SetVUMeterSetting (VU_LEFT, vu_Handle, (NativeInt) pnLeftVUMeter->Handle);   // we use a TPanel to display the VU meters,
      VideoGrabber->SetVUMeterSetting (VU_RIGHT, vu_Handle, (NativeInt) pnRightVUMeter->Handle); // this is activated by assigning the TPanel's handle->->->
   }
   else {
      VideoGrabber->SetVUMeterSetting (VU_LEFT, vu_Handle, 0); // ->->->and the TPanel is freed by passing 0 as handle
      VideoGrabber->SetVUMeterSetting (VU_RIGHT, vu_Handle, 0);
   }

}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                             RECORDING TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::btnStartRecordingImmediatelyClick(
      TObject *Sender)
{
   VideoGrabber->HoldRecording = false; // let's start recording as soon as the graph is built.
   VideoGrabber->StartRecording();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartRecordingControlledClick(
      TObject *Sender)
{
   VideoGrabber->HoldRecording = true;
   VideoGrabber->StartRecording();

   // Enabling HoldRecording prevents the recording to start when the recording graph is built.
   // after the OnRecordingReadyToStart event occurs, you can accurately start the
   // recording by invoking ResumeRecording.
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::btnStopRecordingClick(TObject *Sender)
{
   VideoGrabber->Stop();
}

//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnRenewRecordingFileClick(TObject *Sender)
{
	VideoGrabber->RecordToNewFileNow (edtNewFileDuringRecording->Text, true);
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::rdgRecordingMethodClick(TObject *Sender)
{
   VideoGrabber->RecordingMethod = TRecordingMethod (rdgRecordingMethod->ItemIndex);
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkRecordingCanPauseClick(TObject *Sender)
{
   VideoGrabber->RecordingCanPause = chkRecordingCanPause->Checked;
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkRecordingPauseCreatesNewFileClick(
      TObject *Sender)
{
   VideoGrabber->RecordingPauseCreatesNewFile = chkRecordingPauseCreatesNewFile->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkRecordingOnMotionClick(TObject *Sender)
{
   VideoGrabber->RecordingOnMotion_Enabled = chkRecordingOnMotion->Checked;
   chkRecordingCanPause->Checked = chkRecordingOnMotion->Checked;
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::btnPauseRecordingClick(TObject *Sender)
{
   VideoGrabber->PauseRecording();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResumeRecordingClick(TObject *Sender)
{
   VideoGrabber->ResumeRecording();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkAVISaveToThisFileClick(TObject *Sender)
{
   if (chkAVISaveToThisFile->Checked) {
      VideoGrabber->RecordingFileName = edtRecordingFileName->Text;
   }
   else {
      VideoGrabber->RecordingFileName = "";
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtRecordingFileNameChange(TObject *Sender)
{
   if (chkAVISaveToThisFile->Checked) {
	  VideoGrabber->RecordingFileName = edtRecordingFileName->Text;
   }
}

void __fastcall TfrmMainForm::chkAudioRecordingClick(TObject *Sender)
{
   VideoGrabber->AudioRecording = chkAudioRecording->Checked;
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::grbRecordingTimerClick(TObject *Sender)
{
   VideoGrabber->RecordingTimer = TRecordingTimer (grbRecordingTimer->ItemIndex);
   VideoGrabber->RecordingTimerInterval = StrToIntDef (edtRecordingTimerInterval->Text, 0);
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::edtRecordingTimerIntervalChange(
      TObject *Sender)
{
   VideoGrabber->RecordingTimerInterval = StrToIntDef (edtRecordingTimerInterval->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPreserveNativeFormatClick(TObject *Sender)
{
   VideoGrabber->RecordingInNativeFormat = chkPreserveNativeFormat->Checked;
}
//---------------------------------------------------------------------------




void __fastcall TfrmMainForm::cboVideoCompressorsChange(TObject *Sender)
{
   VideoGrabber->VideoCompressor = cboVideoCompressors->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboAudioCompressorsChange(TObject *Sender)
{
   VideoGrabber->AudioCompressor = cboAudioCompressors->ItemIndex;
}
//---------------------------------------------------------------------------


String GetRecordingMethodName (TRecordingMethod Value)
{
   switch (Value) {
      case rm_ASF         : return "rm_ASF";
      case rm_SendToDV    : return "rm_sDV";
      case rm_MKV         : return "rm_MKV";
      case rm_FLV         : return "rm_FLV";
      case rm_MP4         : return "rm_MP4";
      case rm_Multiplexer : return "rm_Mux";
   default:
      return "rm_AVI";
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnVideoCompressorSettingsClick(
      TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_VideoCompressor);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAudioCompressorSettingsClick(
	  TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_AudioCompressor);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::Button1Click(TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_Multiplexer);

}
//---------------------------------------------------------------------------





void __fastcall TfrmMainForm::rdgCompressModeClick(TObject *Sender)
{
   VideoGrabber->CompressionMode = TCompressionMode (rdgCompressMode->ItemIndex);
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::VideoGrabberRecordingReadyToStart(
      TObject *Sender)
{
   if (MessageDlg ("Ready to start recording!", mtInformation, TMsgDlgButtons() << mbOK << mbCancel, 0) == mrOk) {
      VideoGrabber->ResumeRecording();
   }
   else {
      VideoGrabber->Stop();
   }
}

void __fastcall TfrmMainForm::VideoGrabberRecordingStarted(TObject *Sender,
      String FileName)
{
   mmoLog->Lines->Add ("recording to " + FileName + ":");
   mmoLog->Lines->Add (IntToStr (VideoGrabber->RecordingWidth) + "x" + IntToStr (VideoGrabber->RecordingHeight));
   mmoLog->Lines->Add ("current frame rate: " + FormatFloat ("0.00", VideoGrabber->CurrentFrameRate) + " fps.");
   FKBWritten_LastReportTime = 0;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberRecordingPaused(TObject *Sender)
{
      mmoLog->Lines->Add ("recording paused...");

}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::VideoGrabberRecordingCompleted(
      TObject *Sender, String FileName, bool Success)
{
   if (Success) {
      mmoLog->Lines->Add (FileName + " successfully created.");
      mmoLog->Lines->Add ("size: " + IntToStr ((int) VideoGrabber->RecordingKBytesWrittenToDisk()) + " KB");
   }
   else {
      mmoLog->Lines->Add ("recording failed.");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberReencodingStarted(
      TObject *Sender, String SourceFile, String DestFile)
{
   mmoLog->Lines->Add ("reencoding " + SourceFile + " to " + DestFile + "...");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberReencodingProgress(
      TObject *Sender, int Percent, Int64 Position, Int64 Duration)
{
   mmoLog->Lines->Add (IntToStr (Percent) + "% completed...");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberReencodingCompleted(
      TObject *Sender, String SourceFile, String DestFile,
      bool Success)
{
   if (Success) {
      mmoLog->Lines->Add (SourceFile + "successfully reencoded to " + DestFile);
   }
   else {
      mmoLog->Lines->Add ("ERROR: failed to reencode " + SourceFile + " to " + DestFile);
   }
}
//---------------------------------------------------------------------------


////////////////////////////////////////////////////////////////////////////////
//                             FRAME GRABBER TAB
////////////////////////////////////////////////////////////////////////////////


void __fastcall TfrmMainForm::rgdFrameGrabberClick(TObject *Sender)
{
   VideoGrabber->FrameGrabber = TFrameGrabber (rgdFrameGrabber->ItemIndex);
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rgdFrameGrabberFormatClick(TObject *Sender)
{
   VideoGrabber->FrameGrabberRGBFormat = TFrameGrabberRGBFormat (rgdFrameGrabberFormat->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgAutoFileNameClick(TObject *Sender)
{
   VideoGrabber->AutoFileName = TAutoFileName (cboAutoFileName->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtAVIAutoFilePrefixChange(TObject *Sender)
{
   VideoGrabber->AutoFilePrefix = edtAVIAutoFilePrefix->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOneShotTBitmapClick(TObject *Sender)
{
   VideoGrabber->CaptureFrameTo (fc_TBitmap, "");
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOneShotBMPFileClick(TObject *Sender)
{
   if (chkUseThisFileName->Checked) {
      VideoGrabber->CaptureFrameTo (fc_BmpFile, edtUseThisFileName->Text);
   }
   else {
      VideoGrabber->CaptureFrameTo (fc_BmpFile, "");
   }
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOneShotJPEGFileClick(TObject *Sender)
{
   if (chkUseThisFileName->Checked) {
      VideoGrabber->CaptureFrameTo (fc_JpegFile, edtUseThisFileName->Text);
   }
   else {
      VideoGrabber->CaptureFrameTo (fc_JpegFile, "");
   }
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOneShotClipboardClick(TObject *Sender)
{
      VideoGrabber->CaptureFrameTo (fc_Clipboard, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkUseThisFileNameClick(TObject *Sender)
{
   edtUseThisFileName->Enabled = chkUseThisFileName->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeTBitmapClick(TObject *Sender)
{
   VideoGrabber->BurstType = fc_TBitmap;
   VideoGrabber->BurstMode = true;
   // The frame capture starts when BurstMode is set to true.
   // if BurstCount = 0 the frame capture does not stop.
   // Captured frames will be returned by the OnFrameCaptureCompleted event.
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeBMPFileClick(TObject *Sender)
{
   VideoGrabber->BurstType = fc_BmpFile;
   VideoGrabber->BurstMode = true;
   // The frame capture starts when BurstMode is set to true.
   // if BurstCount = 0 the frame capture does not stop.
   // BMP file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeJPEGFileClick(TObject *Sender)
{
   VideoGrabber->BurstType = fc_JpegFile;
   VideoGrabber->BurstMode = true;
   // The frame capture starts when BurstMode is set to true.
   // if BurstCount = 0 the frame capture does not stop.
   // JPEG file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event->
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeClipboardClick(TObject *Sender)
{
   VideoGrabber->BurstType = fc_Clipboard;
   VideoGrabber->BurstMode = true;
   // The frame capture starts when BurstMode is set to true.
   // if BurstCount = 0 the frame capture does not stop.
   // Captured frames will be returned by the OnFrameCaptureCompleted event.
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeStopClick(TObject *Sender)
{
   VideoGrabber->BurstMode = false;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtBurstCountChange(TObject *Sender)
{
   VideoGrabber->BurstCount = StrToIntDef (edtBurstCount->Text, 1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkModuloClick(TObject *Sender)
{
   if (chkModulo->Checked) {
      VideoGrabber->AutoFileName = fn_Modulo;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtBurstIntervalChange(TObject *Sender)
{
   VideoGrabber->BurstInterval = StrToIntDef (edtBurstInterval->Text, 1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrCaptureZoomSizeChange(TObject *Sender)
{
   VideoGrabber->FrameCaptureZoomSize = tbrCaptureZoomSize->Position;
   edtCaptureZoomSize->Text = IntToStr (tbrCaptureZoomSize->Position) + "%";
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResetCaptureZoomSizeClick(TObject *Sender)
{
   tbrCaptureZoomSize->Position = 100;
}

//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtFrameCaptureWidthChange(TObject *Sender)
{
   VideoGrabber->FrameCaptureWidth = StrToIntDef (edtFrameCaptureWidth->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtFrameCaptureHeightChange(TObject *Sender)
{
   VideoGrabber->FrameCaptureHeight = StrToIntDef (edtFrameCaptureHeight->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberFrameProgress2(TObject *Sender,
      pFrameInfo FrameInfo)
{
   TVarRec FrameTimeVars[] = {FrameInfo->FrameTime_Hour, FrameInfo->FrameTime_Min, FrameInfo->FrameTime_Sec, FrameInfo->FrameTime_Hs};

   if (FrameInfo->CurrentState == cs_Playback) {  // no dropped frames during playback
      edtFrameCount->Text = "frame: " + IntToStr (FrameInfo->FrameNumber) + " time:" + Format ("%.2d:%.2d:%.2d %.2d", FrameTimeVars, (ARRAYSIZE(FrameTimeVars) -1));
   }
   else {
      edtFrameCount->Text = "frame: " + IntToStr (FrameInfo->FrameNumber) + " dropped:" + IntToStr (FrameInfo->DroppedFrameCount) + " time:" + Format ("%.2d:%.2d:%.2d %.2d", FrameTimeVars, (ARRAYSIZE(FrameTimeVars) -1));
   }

   if (VideoGrabber->CurrentState == cs_Recording) {
      if ((FrameInfo->FrameTime - FKBWritten_LastReportTime) > 50000000) { // 5 seconds
         FKBWritten_LastReportTime = FrameInfo->FrameTime;
		 mmoLog->Lines->Add ("written to disk: " + IntToStr ((int) VideoGrabber->RecordingKBytesWrittenToDisk()) + " KB");
	  }
   }
   if (FrameInfo->NTPFrameTime > 0) {
	   edtIPCameraNTPFrameTime->Text = "ntp: " + IntToStr (FrameInfo->NTPFrameTime);
   }
}
//---------------------------------------------------------------------------

void CopyFrameToBitmapDemo (pFrameBitmapInfo BitmapInfo)
{
   // this code shows how to make a copy of the current video frame to an Image, invoke it from the OnFrameBitmap event below

   Graphics::TBitmap *NewBitmap = new Graphics::TBitmap();
   NewBitmap->Canvas->Lock();
   NewBitmap->Width = BitmapInfo->BitmapWidth;
   NewBitmap->Height = BitmapInfo->BitmapHeight;
   switch (BitmapInfo->BitmapBitsPerPixel) {
      case 32: NewBitmap->PixelFormat = pf32bit; break;
      case 24: NewBitmap->PixelFormat = pf24bit; break;
      case 16: NewBitmap->PixelFormat = pf16bit; break;
      case 15: NewBitmap->PixelFormat = pf15bit; break;
      case  8: NewBitmap->PixelFormat =  pf8bit; break;
      default: NewBitmap->PixelFormat = pf24bit; break;
   }
   BitBlt (NewBitmap->Canvas->Handle, 0, 0, BitmapInfo->BitmapWidth, BitmapInfo->BitmapHeight, BitmapInfo->BitmapDC, 0, 0, SRCCOPY);
   NewBitmap->Canvas->Unlock();
   NewBitmap->SaveToFile ("c:\\myfolder\\myframecapture.bmp");
   delete (NewBitmap);
}
//---------------------------------------------------------------------------

void DrawCircle (TCanvas *Canvas, int xCenter, int yCenter, int Radius)
{
   int xCenterAndRadius = xCenter + Radius;
   Canvas->Arc (xCenter - Radius, yCenter - Radius, xCenterAndRadius, yCenter + Radius, xCenterAndRadius, xCenter, xCenterAndRadius, xCenter);
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::VideoGrabberFrameBitmap(TObject *Sender,
      pFrameInfo FrameInfo, pFrameBitmapInfo BitmapInfo)
{

//    From this event you should not perform any actions with the potential to block:
//    1. do not hold a critical section or wait on another thread,
//    2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
//    3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
//       of a ListBox component. If you need to read a such property, set an intermediary variable when
//       the property changes, and then read the intermediary variable from this event.


   // -----------------------------------------------------------
   // CopyFrameToBitmapDemo (BitmapInfo); // CopyFrameToBitmapDemo shows how to make a copy of the current video frame, just uncomment this line to use it
   // -----------------------------------------------------------

   // DRAWS A TARGET AT THE MOUSE LOCATION
   // =============================================================

   if (chkDrawTarget->Checked) {
      if (BitmapInfo->LastMouseButtonClicked == mbLeft) {

         int TargetRadius = 50;

         TCanvas *Canvas = new TCanvas();
         Canvas->Handle = BitmapInfo->BitmapDC;
         Canvas->Pen->Color = clRed;
         DrawCircle (Canvas, BitmapInfo->LastXMouseDownLocation, BitmapInfo->LastYMouseDownLocation, TargetRadius);
         Canvas->MoveTo (BitmapInfo->LastXMouseDownLocation - TargetRadius, BitmapInfo->LastYMouseDownLocation);
         Canvas->LineTo (BitmapInfo->LastXMouseDownLocation + TargetRadius, BitmapInfo->LastYMouseDownLocation);
         Canvas->MoveTo (BitmapInfo->LastXMouseDownLocation, BitmapInfo->LastYMouseDownLocation - TargetRadius);
         Canvas->LineTo (BitmapInfo->LastXMouseDownLocation, BitmapInfo->LastYMouseDownLocation + TargetRadius);
         delete (Canvas);
      }
   }

   // DIRECT ACCESS TO THE RGB PIXELS
   // ===============================

   if (chkChangePixels->Checked) {
	  BYTE *BitmapLinePtr = (BYTE*) BitmapInfo->BitmapDataPtr;

      if (BitmapInfo->BitmapBitsPerPixel == 24) {   // case where FrameGrabberRGBFormat is set to fgf_RGB24 (you can select it in the "frame grabber" tab)
		 for (int i = 0 ; i < BitmapInfo->BitmapHeight ; i++) {
			TRGBTriple *RGB24Line = (TRGBTriple*) BitmapLinePtr;
			for (int iCol = 0 ; iCol < BitmapInfo->BitmapWidth ; iCol ++) {
               RGB24Line[iCol].rgbtGreen = 0; // e.g. we remove the green color -> purple image
            }
            BitmapLinePtr += BitmapInfo->BitmapLineSize;
         }
	  }
      else if (BitmapInfo->BitmapBitsPerPixel == 32) {   // case where FrameGrabberRGBFormat is set to fgf_RGB32 (default setting) (you can select it in the "frame grabber" tab)
         for (int i = 0 ; i < BitmapInfo->BitmapHeight ; i++) {
            TRGBQuad *RGB32Line = (TRGBQuad*) BitmapLinePtr;
            for (int iCol = 0 ; iCol < BitmapInfo->BitmapWidth ; iCol ++) {
               RGB32Line[iCol].rgbBlue = 0; // e.g. we remove the blue color -> yellow image
            }
            BitmapLinePtr += BitmapInfo->BitmapLineSize;
         }
      }
   }

   // GRID DRAWING BY USING THE CANVAS DC AND FILLRECT
   // ================================================

   if (chkDrawGridOverFrames->Checked) {

      int xStep = BitmapInfo->BitmapWidth / 10;
      int yStep = BitmapInfo->BitmapHeight / 10;

      int xLocation = xStep;
      int yLocation = yStep;

      TCanvas *Canvas = new TCanvas;
      Canvas->Brush->Color = clBlue;
      Canvas->Brush->Style = bsSolid;
      Canvas->Handle = BitmapInfo->BitmapDC;

      while (xLocation < BitmapInfo->BitmapWidth) {
         Canvas->FillRect(Rect(xLocation, 0, xLocation + 1, BitmapInfo->BitmapHeight));
         xLocation += xStep;
      }

      while (yLocation < BitmapInfo->BitmapHeight) {
         Canvas->FillRect(Rect(0, yLocation, BitmapInfo->BitmapWidth, yLocation + 1));
         yLocation += yStep;
      }

      Canvas->Free();
   }

   // FREE HAND DRANWING BY USING THE CANVAS DC AND LINETO / MOVETO
   // =============================================================

   if (FiFreeHandMouseDrawing > 0) { // see VideoGrabberMouseMove event below
      TCanvas *Canvas = new TCanvas;
      Canvas->Handle = BitmapInfo->BitmapDC;
      Canvas->Pen->Color = clRed;
      for (int i = 0;  i < FiFreeHandMouseDrawing ; i++) {
         if (FFreeHandMouseDrawing[i].Right == 0) { // Right is used as boolean to know if (it is a MoveTo or a LineTo
            Canvas->MoveTo (FFreeHandMouseDrawing[i].Left, FFreeHandMouseDrawing[i].Top);
            Canvas->Pixels[FFreeHandMouseDrawing[i].Left][FFreeHandMouseDrawing[i].Top] = clRed;
         }
         else {
            Canvas->LineTo (FFreeHandMouseDrawing[i].Left, FFreeHandMouseDrawing[i].Top);
         }
      }
      Canvas->Free();
   }

   // VIDEO SIGNAL DETECTION
   // ======================

   if (rdgDetectVideoSignal->ItemIndex > 0) {
      int NewVideoSignalState = false;
      if (rdgDetectVideoSignal->ItemIndex == 1) { // no video signal (dark screen)
         NewVideoSignalState = VideoGrabber->IsVideoSignalDetected (false, true, 30, 30, 30, true);
      }
      else if (rdgDetectVideoSignal->ItemIndex == 2) { // Connexant blue screen (no signal)
         NewVideoSignalState = VideoGrabber->IsVideoSignalDetected (true, false, 0, 0, 0, false);
      }
      if (NewVideoSignalState != FOldVideoSignalState) {
         FOldVideoSignalState = NewVideoSignalState; // memorize the new state
         if (NewVideoSignalState) {
            mmoLog->Lines->Add ("Video signal is back");
         }
         else {
            mmoLog->Lines->Add ("VIDEO SIGNAL LOST");
         }
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberFrameCaptureCompleted(
      TObject *Sender, Pointer FrameBitmap, int BitmapWidth,
      int BitmapHeight, DWORD FrameNumber, Int64 FrameTime,
      TFrameCaptureDest DestType, String FileName, bool Success,
      int FrameId)
{
   TForm *DestForm;
   TImage *DestImage;
   Graphics::TBitmap *Frame_Bitmap;

   Frame_Bitmap = (Graphics::TBitmap*) FrameBitmap;

   if (Success) {
      mmoFrameCaptureLog->Lines->Add ("frame #" + IntToStr ((Int64) FrameNumber) + " captured");
   }
   switch (DestType) {
	  // ______ bmp or jpeg file
	  case fc_BmpFile:
	  case fc_TiffFile:
	  case fc_PngFile:
	  case fc_JpegFile: {
		 if (Success) {
			 mmoFrameCaptureLog->Lines->Add (FileName);
		  }
		  else {
			 mmoFrameCaptureLog->Lines->Add ("error: failed to create " + FileName);
		  }
	   } break;

	  // ______ memory bitmap
	  case fc_TBitmap: {
		 DestForm = NULL;
		 if (VideoGrabber->CanProcessMessages()) { // to prevent crash in synchrone mode (mainly when Player is playing and UseClock is disabled)
			if ((! VideoGrabber->BurstMode) || (VideoGrabber->BurstMode && (VideoGrabber->BurstCount == 0))) { // reuse the same form
			   if (! FSnapForm) {
				  Application->CreateForm (__classid (TForm), &FSnapForm);
				  FSnapForm->Position = poDefault;
				  FSnapForm->FormStyle = fsStayOnTop;
			   }
			   if (FSnapImage) {
				  FSnapImage->Free();
			   }
			   FSnapImage = new TImage (DestForm);
			   DestForm = FSnapForm;
			   DestImage = FSnapImage;
			}
			else { // create a form for each image
			   Application->CreateForm (__classid (TForm), &DestForm);
			   DestForm->Position = poDefault;
			   DestForm->FormStyle = fsStayOnTop;
                           DestForm->DoubleBuffered = true;
			   DestImage = new TImage (DestForm);
			   DestImage->Parent = DestForm;
			}

			DestForm->ClientWidth = Frame_Bitmap->Width;
			DestForm->ClientHeight = Frame_Bitmap->Height;
			DestImage->AutoSize = true;

			bool AlternateMethod = false; // you can choose one of the 2 methods below (set true to test the 2nd)

			if (! AlternateMethod) { // this code reassign the bitmap handle to the picture (saves CPU)
			   DestImage->Picture->Bitmap->Handle = Frame_Bitmap->Handle;
			   Frame_Bitmap->ReleaseHandle();
			}
			else { // this code makes a copy of the bitmap
			   DestImage->Picture->Assign (Frame_Bitmap);
			}

			DestImage->Parent = DestForm;

			if (! DestForm->Visible) {
			   DestForm->Show();
			}
		 }
	  } break;
	  case fc_Clipboard:
	  break;
	}
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                             PLAYER TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::btnPlayerOpenFileClick(TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES_EXTENDED;
   if (OpenDlg->Execute()) {
      edtPlayerClip->Text =OpenDlg->FileName;
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnGetClipDurationClick(TObject *Sender)
{
   __int64 Duration;
   __int64 FrameCount;

   if (VideoGrabber->AVIDuration (edtPlayerClip->Text, Duration, FrameCount)) {
       mmoLog->Lines->Add ("Duration: " + IntToStr (Duration));
       mmoLog->Lines->Add ("Frame count: " + IntToStr (FrameCount));
   }
   else {
       mmoLog->Lines->Add ("failed to get info for this clip");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgHwAccelClick(TObject *Sender)
{
   VideoGrabber->PlayerHwAccel = (THwAccel) rdgHwAccel->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnGeneralInfoClick(TObject *Sender)
{
   __int64 Duration;
   __int64 FrameCount;
   int VideoWidth;
   int VideoHeight;
   String VideoCodec;
   String AudioCodec;
   double VideoFrameRateFps;
   int AvgBitRate;
   int AudioChannels;
   int AudioSamplesPerSec;
   int AudioBitsPerSample;

   if (VideoGrabber->AVIInfo (edtPlayerClip->Text, Duration, FrameCount, VideoWidth, VideoHeight, VideoFrameRateFps, AvgBitRate, AudioChannels, AudioSamplesPerSec, AudioBitsPerSample, VideoCodec, AudioCodec)) {
      mmoLog->Lines->Add ("");
      mmoLog->Lines->Add (edtPlayerClip->Text + ":");
      mmoLog->Lines->Add ("duration (in sec): " + FormatFloat ("0.00", Duration / 100000));
      mmoLog->Lines->Add ("frame count: " + IntToStr (FrameCount));
      mmoLog->Lines->Add ("video width: " + IntToStr (VideoWidth));
      mmoLog->Lines->Add ("video height: " + IntToStr (VideoHeight));
      mmoLog->Lines->Add ("video frame rate (fps): " + FormatFloat ("0.00", VideoFrameRateFps));
      mmoLog->Lines->Add ("average bit rate (kb/s): " + IntToStr (AvgBitRate / 1024));
      mmoLog->Lines->Add ("audio channels: " + IntToStr (AudioChannels));
      mmoLog->Lines->Add ("audio samples/sec: " + IntToStr (AudioSamplesPerSec));
      mmoLog->Lines->Add ("audio bits per sample: " + IntToStr (AudioBitsPerSample));
      mmoLog->Lines->Add ("video codec: " + VideoCodec);
      mmoLog->Lines->Add ("audio codec: " + AudioCodec);
   }
   else {
      mmoLog->Lines->Add (edtPlayerClip->Text + " clip not found->");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnHeaderInfoClick(TObject *Sender)
{
    mmoLog->Lines->Add ("");
    mmoLog->Lines->Add (edtPlayerClip->Text + " headers:");
    mmoLog->Lines->Add ("Title: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Title));
    mmoLog->Lines->Add ("Description: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Description));
    mmoLog->Lines->Add ("Author: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Author));
    mmoLog->Lines->Add ("Copyright: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Copyright));
    mmoLog->Lines->Add ("Album Artist: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_AlbumArtist));
    mmoLog->Lines->Add ("Album Title: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_AlbumTitle));
    mmoLog->Lines->Add ("Composer: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Composer));
    mmoLog->Lines->Add ("Content Distributor: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_ContentDistributor));
    mmoLog->Lines->Add ("Director: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Director));
    mmoLog->Lines->Add ("Encoding Time: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_EncodingTime));
    mmoLog->Lines->Add ("Genre: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Genre));
    mmoLog->Lines->Add ("Language: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Language));
    mmoLog->Lines->Add ("Parental Rating: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_ParentalRating));
    mmoLog->Lines->Add ("Producer: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Producer));
    mmoLog->Lines->Add ("Provider: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Provider));
    mmoLog->Lines->Add ("ToolName: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_ToolName));
    mmoLog->Lines->Add ("Tool Version: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_ToolVersion));
    mmoLog->Lines->Add ("Writer: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Writer));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenClipClick(TObject *Sender)
{
   VideoGrabber->PlayerFileName = edtPlayerClip->Text;
   VideoGrabber->OpenPlayer();

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerCloseClipClick(TObject *Sender)
{
 VideoGrabber->ClosePlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenLastClipRecordedClick(TObject *Sender)
{
   if (VideoGrabber->Last_Recording_FileName != "") {
      edtPlayerClip->Text = VideoGrabber->Last_Recording_FileName;
      VideoGrabber->PlayerFileName = edtPlayerClip->Text;
      VideoGrabber->OpenPlayer();
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenLastClipPlayedClick(TObject *Sender)
{
   if (VideoGrabber->Last_Clip_Played != "") {
      edtPlayerClip->Text = VideoGrabber->Last_Clip_Played;
      VideoGrabber->PlayerFileName = edtPlayerClip->Text;
      VideoGrabber->OpenPlayer();
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerCloseFileClick(TObject *Sender)
{
   VideoGrabber->ClosePlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerPauseClick(TObject *Sender)
{
   VideoGrabber->PausePlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerStopClick(TObject *Sender)
{
   VideoGrabber->StopPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerStartPlayingClick(TObject *Sender)
{
   VideoGrabber->RunPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerFrameStepClick(TObject *Sender)
{
   VideoGrabber->PlayerFrameStep (1);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerBackwardsClick(TObject *Sender)
{
   VideoGrabber->RunPlayerBackwards();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerRewindClick(TObject *Sender)
{
   VideoGrabber->RewindPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerFastForwardClick(TObject *Sender)
{
   VideoGrabber->FastForwardPlayer();

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAutoPlayClick(TObject *Sender)
{
   VideoGrabber->AutoStartPlayer = btnAutoPlay->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk360VideoDecodingClick(TObject *Sender)
{
   VideoGrabber->v360_Enabled = chk360VideoDecoding->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrPlayerProgressChange(TObject *Sender)
{
    // the tbrPlayer trackbar is assigned directly to the VideoGrabber.PlayerTrackBar property, that handle the position automatically
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPlayerTrackbarSynchroneClick(
      TObject *Sender)
{
   VideoGrabber->PlayerTrackBarSynchrone = chkPlayerTrackbarSynchrone->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPlayerAudioRenderingClick(TObject *Sender)
{
   VideoGrabber->PlayerAudioRendering = chkPlayerAudioRendering->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkUseClockClick(TObject *Sender)
{
   VideoGrabber->UseClock = chkUseClock->Checked;
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkRefreshPausedDisplayClick(TObject *Sender)
{
   VideoGrabber->PlayerRefreshPausedDisplay = chkRefreshPausedDisplay->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtPlayerSpeedRatioChange(TObject *Sender)
{
   double OldSpeedRatio = VideoGrabber->PlayerSpeedRatio;
   VideoGrabber->PlayerSpeedRatio = StrToFloatDef (edtPlayerSpeedRatio->Text, 1.0);
   if (VideoGrabber->PlayerSpeedRatio != OldSpeedRatio) {
      mmoLog->Lines->Add ("player speed ratio selected: " + FormatFloat ("0.0", VideoGrabber->PlayerSpeedRatio));
   }

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updPlayerFastSeekSpeedClick(TObject *Sender,
      TUDBtnType Button)
{
   VideoGrabber->PlayerFastSeekSpeedRatio = updPlayerFastSeekSpeed->Position;
   edtPlayerFastSeekSpeed->Text = IntToStr (VideoGrabber->PlayerFastSeekSpeedRatio);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPlayerOpened(TObject *Sender)
{
   mmoLog->Lines->Add ("");
   mmoLog->Lines->Add ("playing " + VideoGrabber->PlayerFileName);
   if (VideoGrabber->IsPlayerVideoStreamAvailable == ts_True) {
      mmoLog->Lines->Add ("this clip has a video stream");
   }
   else if (VideoGrabber->IsPlayerVideoStreamAvailable == ts_False) {
      mmoLog->Lines->Add ("this clip does not have video");
   }
   if (VideoGrabber->IsPlayerAudioStreamAvailable == ts_True) {
      mmoLog->Lines->Add ("this clip has an audio stream");
   }
   else if (VideoGrabber->IsPlayerAudioStreamAvailable == ts_False) {
      mmoLog->Lines->Add ("this clip does not have audio");
   }
   mmoLog->Lines->Add ("");
   mmoLog->Lines->Add ("video codec: " + VideoGrabber->PlayerVideoCodec);
   mmoLog->Lines->Add ("audio codec: " + VideoGrabber->PlayerAudioCodec);
   mmoLog->Lines->Add ("");
   mmoLog->Lines->Add ("Duration: " + FormatFloat ("0.00", VideoGrabber->PlayerDuration / 10000000));
   mmoLog->Lines->Add ("Frame count: " + IntToStr (VideoGrabber->PlayerFrameCount));
   mmoLog->Lines->Add ("Frame rate: " + FormatFloat ("0.00", VideoGrabber->PlayerFrameRate));
   mmoLog->Lines->Add ("video source size:" + IntToStr (VideoGrabber->VideoWidth) + "x" + IntToStr (VideoGrabber->VideoHeight));
   mmoLog->Lines->Add ("display aspect ratio: " + IntToStr (VideoGrabber->VideoWidth_PreferredAspectRatio) + "x" + IntToStr (VideoGrabber->VideoHeight_PreferredAspectRatio));

   if (VideoGrabber->IsPlaylistActive() ) {
      lstPlaylist->ItemIndex = VideoGrabber->PlaylistIndex;
   }

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPlayerBufferingData(
      TObject *Sender, bool StartingToBuffer)
{
   if (StartingToBuffer) {
      mmoLog->Lines->Add ("buffering data...");
   }
   else {
      mmoLog->Lines->Add ("buffering completed.");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAddToPlaylistClick(TObject *Sender)
{
   int i;

   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES_EXTENDED;
   OpenDlg->Options = OpenDlg->Options << ofAllowMultiSelect;
   if (OpenDlg->Execute()) {
      for (i = 0 ; i <OpenDlg->Files->Count ; i ++) {
         VideoGrabber->Playlist (pl_Add, OpenDlg->Files->Strings[i]);
         lstPlaylist->Items->Add (OpenDlg->Files->Strings[i]);
      }
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlaylistPlayClick(TObject *Sender)
{
   VideoGrabber->Playlist (pl_Play, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlaylistNextClick(TObject *Sender)
{
   VideoGrabber->Playlist (pl_Next, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlaylistPreviousClick(TObject *Sender)
{
   VideoGrabber->Playlist (pl_Previous, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlaylistStopClick(TObject *Sender)
{
   VideoGrabber->Playlist (pl_Stop, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnClosePlaylistClick(TObject *Sender)
{
   VideoGrabber->ClosePlayer();

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPlaylistLoopClick(TObject *Sender)
{
   if (chkPlaylistLoop->Checked) {
      VideoGrabber->Playlist (pl_Loop, "");
   }
   else {
      VideoGrabber->Playlist (pl_NoLoop, "");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPlaylistRandomClick(TObject *Sender)
{
   if (chkPlaylistLoop->Checked) {
      VideoGrabber->Playlist (pl_Random, "");
   }
   else {
      VideoGrabber->Playlist (pl_Sequential, "");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::lstPlaylistClick(TObject *Sender)
{
   VideoGrabber->PlaylistIndex = lstPlaylist->ItemIndex;
   VideoGrabber->Playlist (pl_Play, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPlayerEndOfStream(
      TObject *Sender)
{
   mmoLog->Lines->Add ("End of stream.");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPlayerEndOfPlaylist(
      TObject *Sender)
{
   mmoLog->Lines->Add ("END OF PLAYLIST.");
}
//---------------------------------------------------------------------------


////////////////////////////////////////////////////////////////////////////////
//                            FRAME OVERLAY TAB
////////////////////////////////////////////////////////////////////////////////



void __fastcall TfrmMainForm::chkTextOverlayEnabledClick(TObject *Sender)
{
   VideoGrabber->SetTextOverlay_String(FTextOverlayIndex, mmoTextOverlayString->Text);

   VideoGrabber->SetTextOverlay_Enabled(FTextOverlayIndex, chkTextOverlayEnabled->Checked);

   if (! chkTextOverlayEnabled->Checked) {
	  chkTextOverlayEnabled->Font->Color = clRed;
   }
   else {
	  chkTextOverlayEnabled->Font->Color = clBlack;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTextOverlayHighResFontClick(
	  TObject *Sender)
{
   VideoGrabber->SetTextOverlay_HighResFont(FTextOverlayIndex, chkTextOverlayHighResFont->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTextOverlayTargetDisplayChange(
      TObject *Sender)
{
   VideoGrabber->SetTextOverlay_TargetDisplay(FTextOverlayIndex, StrToIntDef (edtTextOverlayTargetDisplay->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTextOverlayTransparentClick(
      TObject *Sender)
{
   VideoGrabber->SetTextOverlay_Transparent(FTextOverlayIndex, chkTextOverlayTransparent->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updTextOverlaySizeClick(TObject *Sender,
      TUDBtnType Button)
{
   int OldSize = VideoGrabber->GetTextOverlay_Font(FTextOverlayIndex)->Size;
   switch (Button) {
	  case btPrev: VideoGrabber->GetTextOverlay_Font(FTextOverlayIndex)->Size = OldSize - 1; break;
      case btNext: VideoGrabber->GetTextOverlay_Font(FTextOverlayIndex)->Size = OldSize + 1; break;
   }
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::chkAdjustOverlayAspectRatioClick(
      TObject *Sender)
{
   VideoGrabber->AdjustOverlayAspectRatio = chkAdjustOverlayAspectRatio->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTextOverlayShadowClick(TObject *Sender)
{
   VideoGrabber->SetTextOverlay_Shadow(FTextOverlayIndex, chkTextOverlayShadow->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgTextOverlayAlignClick(TObject *Sender)
{
   VideoGrabber->SetTextOverlay_Align(FTextOverlayIndex, TTextOverlayAlign (rdgTextOverlayAlign->ItemIndex));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::mmoTextOverlayStringChange(TObject *Sender)
{
   VideoGrabber->SetTextOverlay_String(FTextOverlayIndex, mmoTextOverlayString->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTextOverlayLeftChange(TObject *Sender)
{
   VideoGrabber->SetTextOverlay_Left(FTextOverlayIndex, StrToIntDef (edtTextOverlayLeft->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTextOverlayTopChange(TObject *Sender)
{
   VideoGrabber->SetTextOverlay_Top(FTextOverlayIndex, StrToIntDef (edtTextOverlayTop->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTextOverlayRightChange(TObject *Sender)
{
   VideoGrabber->SetTextOverlay_Right(FTextOverlayIndex, StrToIntDef (edtTextOverlayRight->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBkgndColorClick(TObject *Sender)
{
   TColorDialog *dlgTextOverlayColor = new TColorDialog(NULL);
   dlgTextOverlayColor->Color = VideoGrabber->GetTextOverlay_Font(FTextOverlayIndex)->Color;
   if (dlgTextOverlayColor->Execute()) {
      VideoGrabber->GetTextOverlay_Font(FTextOverlayIndex)->Color = dlgTextOverlayColor->Color;
   }
   delete (dlgTextOverlayColor);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTextOverlayScrollingClick(TObject *Sender)
{
   VideoGrabber->SetTextOverlay_Scrolling(FTextOverlayIndex, chkTextOverlayScrolling->Checked);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTextOverlayScrollingSpeedChange(
      TObject *Sender)
{
   VideoGrabber->SetTextOverlay_ScrollingSpeed(FTextOverlayIndex, StrToIntDef (edtTextOverlayScrollingSpeed->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnTextOverlayColorClick(TObject *Sender)
{
   TColorDialog *dlgTextOverlayColor = new TColorDialog(NULL);
   dlgTextOverlayColor->Color = VideoGrabber->GetTextOverlay_BkColor(FTextOverlayIndex);
   if (dlgTextOverlayColor->Execute()) {
      VideoGrabber->SetTextOverlay_BkColor(FTextOverlayIndex, dlgTextOverlayColor->Color);
   }
   delete (dlgTextOverlayColor);
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::rdgTextOverlaySelectorClick(TObject *Sender)
{
   FTextOverlayIndex = rdgTextOverlaySelector->ItemIndex;

   // as we have selected another set, let's reload the corresponding values
   chkTextOverlayEnabled->Checked = VideoGrabber->GetTextOverlay_Enabled(FTextOverlayIndex);
   if (! chkTextOverlayEnabled->Checked) {
      chkTextOverlayEnabled->Font->Color = clRed;
   }
   else {
      chkTextOverlayEnabled->Font->Color = clBlack;
   }

   edtTextOverlayTargetDisplay->Text = IntToStr (VideoGrabber->GetTextOverlay_TargetDisplay(FTextOverlayIndex));
   chkTextOverlayHighResFont->Checked = VideoGrabber->GetTextOverlay_HighResFont(FTextOverlayIndex);

   mmoTextOverlayString->Text = VideoGrabber->GetTextOverlay_String(FTextOverlayIndex);
   edtTextOverlayLeft->Text = IntToStr (VideoGrabber->GetTextOverlay_Left(FTextOverlayIndex));
   edtTextOverlayTop->Text = IntToStr (VideoGrabber->GetTextOverlay_Top(FTextOverlayIndex));
   edtTextOverlayRight->Text = IntToStr (VideoGrabber->GetTextOverlay_Right(FTextOverlayIndex));
   rdgTextOverlayAlign->ItemIndex = Integer (VideoGrabber->GetTextOverlay_Align(FTextOverlayIndex));
   chkTextOverlayScrolling->Checked = VideoGrabber->GetTextOverlay_Scrolling(FTextOverlayIndex);
   edtTextOverlayScrollingSpeed->Text = IntToStr (VideoGrabber->GetTextOverlay_ScrollingSpeed(FTextOverlayIndex));
   chkTextOverlayTransparent->Checked = VideoGrabber->GetTextOverlay_Transparent(FTextOverlayIndex);
   chkTextOverlayShadow->Checked = VideoGrabber->GetTextOverlay_Shadow(FTextOverlayIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkChangePixelsClick(TObject *Sender)
{
   // chkChangePixels->Checked is tested in the TfrmMainForm::VideoGrabberFrameBitmap event's code
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkDrawGridOverFramesClick(TObject *Sender)
{
   // chkDrawGridOverFrames->Checked is tested in the TfrmMainForm::VideoGrabberFrameBitmap event's code
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkFreeHandEnabledClick(TObject *Sender)
{
   // chkFreeHandEnabled->Checked is tested in the TfrmMainForm::VideoGrabberFrameBitmap event's code
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnFreeHandEraseClick(TObject *Sender)
{
   FiFreeHandMouseDrawing = 0;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnLoadImageOverlayFromFileClick(
      TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_IMAGE_FILES;
   if (OpenDlg->Execute()) {
      VideoGrabber->SetImageOverlayFromImageFile2 (FImageOverlayIndex, OpenDlg->FileName);
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayEnabledClick(TObject *Sender)
{
   VideoGrabber->SetImageOverlay_Enabled(FImageOverlayIndex, chkImageOverlayEnabled->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayTargetDisplayChange(
      TObject *Sender)
{
   VideoGrabber->SetImageOverlay_TargetDisplay(FTextOverlayIndex, StrToIntDef (edtImageOverlayTargetDisplay->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMouseDown(TObject *Sender,
      int VideoWindow, TMouseButton Button, TShiftState Shift, int X,
      int Y)
{
   if (VideoWindow != -1) { // if the video is displayed
      if (chkFreeHandEnabled->Checked) {
         FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left = X;
         FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top = Y;
         FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right = 0; // Right is used as boolean to know if (it is a MoveTo or a LineTo
         FiFreeHandMouseDrawing ++;
         FFreeHandMouseDrawingEnabled = true;
         VideoGrabber->RefreshPlayerOverlays();
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMouseMove(TObject *Sender,
      int VideoWindow, TShiftState Shift, int X, int Y)
{
   if (VideoWindow != -1) { // if the video is displayed
      if (FFreeHandMouseDrawingEnabled) { // has been enabled in the MouseDown event above
         if (FiFreeHandMouseDrawing < CFreeHandMouseMax) {
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left = X;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top = Y;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right = 1; // Right is used as boolean to know if (it is a MoveTo or a LineTo
            FiFreeHandMouseDrawing ++;
            VideoGrabber->RefreshPlayerOverlays();
         }
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMouseUp(TObject *Sender,
      int VideoWindow, TMouseButton Button, TShiftState Shift, int X,
      int Y)
{
   FFreeHandMouseDrawingEnabled = false;
   VideoGrabber->RefreshPlayerOverlays();
}

//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberResizeVideo(TObject *Sender,
      int SourceWidth, int SourceHeight)
{
   trkCroppingX->Min = -VideoGrabber->Cropping_Width;
   trkCroppingY->Min = -VideoGrabber->Cropping_Height;
   trkCroppingX->Max = VideoGrabber->Cropping_XMax;
   trkCroppingY->Max = VideoGrabber->Cropping_YMax;
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                           VIDEO PROCESSING TAB
////////////////////////////////////////////////////////////////////////////////


void __fastcall TfrmMainForm::rdgVideoRotationClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Rotation = TVideoRotation (rdgVideoRotation->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtCustomRotationAngleChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_RotationCustomAngle = StrToFloatDef (edtCustomRotationAngle->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updPixellizationClick(TObject *Sender,
      TUDBtnType Button)
{
   VideoGrabber->VideoProcessing_Pixellization = updPixellization->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgDeinterlacingClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Deinterlacing = TVideoDeinterlacing (rdgDeinterlacing->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrBrightnessChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Brightness = - tbrBrightness->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrConstrastChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Contrast = - tbrConstrast->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrSaturationChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Saturation = - tbrSaturation->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrHueChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Hue = tbrHue->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResetAllClick(TObject *Sender)
{
   rdgVideoRotation->ItemIndex = 0;
   rdgDeinterlacing->ItemIndex = 0;
   tbrBrightness->Position = 0;
   tbrConstrast->Position = 0;
   tbrSaturation->Position = 0;
   tbrHue->Position = 0;
   chkGreyScale->Checked = false;
   chkInvertColors->Checked = false;
   chkFlipVertical->Checked = false;
   chkFlipHorizontal->Checked = false;
   updPixellization->Position = 1;
   VideoGrabber->VideoProcessing_Pixellization = 1;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkFlipVerticalClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_FlipVertical = chkFlipVertical->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkFlipHorizontalClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_FlipHorizontal = chkFlipHorizontal->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkGreyScaleClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_GrayScale = chkGreyScale->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkInvertColorsClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_InvertColors = chkInvertColors->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::vmr9FixRangeClick(TObject *Sender)
{
   // fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::tbrVMR9BrightnessChange(TObject *Sender)
{
   VideoGrabber->SetVMR9ImageAdjustmentValue (true, vmr9_Brightness, tbrVMR9Brightness->Position, false);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrVMR9ContrastChange(TObject *Sender)
{
   VideoGrabber->SetVMR9ImageAdjustmentValue (true, vmr9_Contrast, tbrVMR9Contrast->Position, vmr9FixRange->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrVMR9SaturationChange(TObject *Sender)
{
   VideoGrabber->SetVMR9ImageAdjustmentValue (true, vmr9_Saturation, tbrVMR9Saturation->Position, vmr9FixRange->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrVMR9HueChange(TObject *Sender)
{
   VideoGrabber->SetVMR9ImageAdjustmentValue (true, vmr9_Hue, tbrVMR9Hue->Position, false);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::InitVMR9Trackbar (TVMR9ImageAdjustment VMR9ImageAdjustment, TTrackBar *TrackBar)
{
   int MinValue, MaxValue, StepSize, DefaultValue, CurrentValue;

   TrackBar->Enabled = VideoGrabber->GetVMR9ImageAdjustmentBounds (true, VMR9ImageAdjustment, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue);
   if (TrackBar->Enabled) {
      TrackBar->Min = MinValue;
      TrackBar->Max = MaxValue;
      TrackBar->Frequency = StepSize;
      TrackBar->Position = CurrentValue;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberGraphBuilt(TObject *Sender)
{
   InitVMR9Trackbar (vmr9_Brightness, tbrVMR9Brightness);
   InitVMR9Trackbar (vmr9_Contrast, tbrVMR9Contrast);
   InitVMR9Trackbar (vmr9_Saturation, tbrVMR9Saturation);
   InitVMR9Trackbar (vmr9_Hue, tbrVMR9Hue);

   tbrAudioBalance->Position = VideoGrabber->AudioBalance;
   tbrAudioVolume->Position = VideoGrabber->AudioVolume;

   tbrZoomX->Min = - (VideoGrabber->VideoWidth / 2);
   tbrZoomX->Max = VideoGrabber->VideoWidth / 2;
   tbrZoomY->Min = - (VideoGrabber->VideoHeight / 2);
   tbrZoomY->Max = VideoGrabber->VideoHeight / 2;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrZoomChange(TObject *Sender)
{
   VideoGrabber->ZoomCoeff = tbrZoom->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrZoomXChange(TObject *Sender)
{
   VideoGrabber->ZoomXCenter = tbrZoomX->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrZoomYChange(TObject *Sender)
{
   VideoGrabber->ZoomYCenter = tbrZoomY->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCroppingEnabledClick(TObject *Sender)
{
   VideoGrabber->Cropping_Enabled = chkCroppingEnabled->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCroppingOutboundsClick(TObject *Sender)
{
   VideoGrabber->Cropping_Outbounds = chkCroppingOutbounds->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtCroppingWidthChange(TObject *Sender)
{
   VideoGrabber->Cropping_Width = StrToIntDef (edtCroppingWidth->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtCroppingHeightChange(TObject *Sender)
{
   VideoGrabber->Cropping_Height = StrToIntDef (edtCroppingHeight->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::trkCroppingZoomChange(TObject *Sender)
{
   VideoGrabber->Cropping_Zoom = trkCroppingZoom->Position / 100;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnCroppingZoomResetClick(TObject *Sender)
{
   trkCroppingZoom->Position = 100;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::trkCroppingYChange(TObject *Sender)
{
   // trkCroppingX->Max and trkCroppingY->Max are set from the OnResizeVideo event
   VideoGrabber->Cropping_Y = trkCroppingY->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::trkCroppingXChange(TObject *Sender)
{
   // trkCroppingX->Max and trkCroppingY->Max are set from the OnResizeVideo event
   VideoGrabber->Cropping_X = trkCroppingX->Position;
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                                DISPLAY TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall EnableOrDisableGroupBoxControls (TGroupBox *GroupBox, bool Value)
{
   int i;

   for (i = 0 ; i < GroupBox->ControlCount ; i ++) {
      GroupBox->Controls[i]->Enabled = Value;
   }
}

void __fastcall TfrmMainForm::RefreshDisplayOptions(void)
{
   if (ComponentState.Contains(csDestroying)) return; // do nothing if the app terminates

   // let's refresh the controls according to the TVideoGrabber's states

   chkDisplayActive->Checked = VideoGrabber->GetDisplayActive (FDisplaySelected);
   chkVisible->Checked           = VideoGrabber->GetDisplayVisible (FDisplaySelected);
   chkEmbedded->Checked          = VideoGrabber->GetDisplayEmbedded (FDisplaySelected);
   chkFullScreen->Checked        = VideoGrabber->GetDisplayFullScreen (FDisplaySelected);
   chkStayOnTop->Checked         = VideoGrabber->GetDisplayStayOnTop (FDisplaySelected);
   chkUseVideoPort->Checked      = VideoGrabber->GetDisplayVideoPortEnabled (FDisplaySelected);
   chkMouseMovesWindow->Checked  = VideoGrabber->GetDisplayMouseMovesWindow (FDisplaySelected);
   chkAutoSize->Checked          = VideoGrabber->GetDisplayAutoSize (FDisplaySelected);
   rdgAspectRatio->ItemIndex     = VideoGrabber->GetDisplayAspectRatio (FDisplaySelected);
   tbrPanScan->Position          = VideoGrabber->GetDisplayPanScanRatio (FDisplaySelected);
   chkAlphablend->Checked        = VideoGrabber->GetDisplayAlphaBlendEnabled (FDisplaySelected);
   tbrAlphablend->Position       = VideoGrabber->GetDisplayAlphaBlendValue (FDisplaySelected);
   chkTranspColor->Checked       = VideoGrabber->GetDisplayTransparentColorEnabled (FDisplaySelected);
   TVarRec VarRec[] = {VideoGrabber->GetDisplayTransparentColorValue (FDisplaySelected)};
   edtTranspColor->Text          = Format ("%.6X", VarRec, (ARRAYSIZE(VarRec) -1));

   edtAssignToMonitorNumber->Text  = IntToStr (VideoGrabber->GetDisplayMonitor (FDisplaySelected));

   EnableOrDisableGroupBoxControls (grbMainVideoWindow, VideoGrabber->GetDisplayActive (FDisplaySelected));

   if (VideoGrabber->GetDisplayActive (FDisplaySelected)) {
      chkStayOnTop->Enabled             = (! VideoGrabber->GetDisplayEmbedded (FDisplaySelected)) || VideoGrabber->GetDisplayFullScreen (FDisplaySelected);
      edtAssignToMonitorLabel->Enabled  = VideoGrabber->MonitorsCount() > 1;
      edtAssignToMonitorNumber->Enabled = VideoGrabber->MonitorsCount() > 1;
      chkMouseMovesWindow->Enabled      = ! VideoGrabber->GetDisplayEmbedded (FDisplaySelected);
      btnNewLocation2->Enabled          = ! VideoGrabber->GetDisplayEmbedded (FDisplaySelected);
      chkUseVideoPort->Enabled          = VideoGrabber->IsVideoPortAvailable;
      chkAlphablend->Enabled            = ! VideoGrabber->GetDisplayEmbedded (FDisplaySelected);
      chkTranspColor->Enabled           = ! VideoGrabber->GetDisplayEmbedded (FDisplaySelected);
   }
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkBlackMagicDecklinkClick(TObject *Sender)
{
   if (chkBlackMagicDecklink->Checked)
   {
      VideoGrabber->VideoRendererExternal = vre_BlackMagic_Decklink;
   }
   else
   {
      VideoGrabber->VideoRendererExternal = vre_None;
   }
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkVideoVisibleWhenStoppedClick(
      TObject *Sender)
{
   VideoGrabber->VideoVisibleWhenStopped = chkVideoVisibleWhenStopped->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkAdjustPixelAspectRatioClick(
      TObject *Sender)
{
   VideoGrabber->AdjustPixelAspectRatio = chkAdjustPixelAspectRatio->Checked;
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkChangeCursorClick(TObject *Sender)
{
   if (chkChangeCursor->Checked) {
      VideoGrabber->VideoCursor = crCross;
   }
   else {
      VideoGrabber->VideoCursor = crDefault;
   }
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkBorderClick(TObject *Sender)
{
   if (chkBorder->Checked) {
      VideoGrabber->BorderStyle = bsSingle;
   }
   else {
      VideoGrabber->BorderStyle = bsNone;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTransparencyClick(TObject *Sender)
{
   VideoGrabber->ColorKeyEnabled = chkTransparency->Checked;
   if (VideoGrabber->ColorKeyEnabled) {
      if (FTransparentForm == NULL) {
         Application->CreateForm (__classid (TForm), &FTransparentForm);
         FTransparentForm->Width = 300;
         FTransparentForm->Height = 200;
         FTransparentForm->Position = poScreenCenter;
         FTransparentForm->FormStyle = fsStayOnTop;
         FTransparentPanel = new TPanel (FTransparentForm);
         FTransparentPanel->Parent = FTransparentForm;
         FTransparentPanel->BevelInner = bvNone;
         FTransparentPanel->BevelOuter = bvNone;
         //FTransparentPanel->Align = alClient;
         FTransparentPanel->Caption = "transparent window";
         FTransparentPanel->Font->Color = clRed;
         FTransparentPanel->Font->Size = 16;
         TButton *Button = new TButton(FTransparentForm);
         Button->Top = 100;
	 Button->Width = 200;
	 Button->Parent = FTransparentForm;
	 Button->Caption = "click to remove border";
	 Button->OnClick = TransparentFormButtonClick;
      }

      FTransparentForm->Color = VideoGrabber->ColorKey;
      FTransparentPanel->Color = VideoGrabber->ColorKey;
      VideoGrabber->SetWindowTransparency (FTransparentForm->Handle, true, false, 0);
      FTransparentForm->Show();
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::TransparentFormButtonClick(TObject *Sender)
{
        FTransparentForm->BorderStyle = bsNone;
	VideoGrabber->SetWindowTransparency (FTransparentForm->Handle, true, false, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgVideoRendererClick(TObject *Sender)
{
   VideoGrabber->VideoRenderer = TVideoRenderer (rdgVideoRenderer->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgDisplaySelectedClick(TObject *Sender)
{
   FDisplaySelected = rdgDisplaySelected->ItemIndex;
   RefreshDisplayOptions();

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkDisplayActiveClick(TObject *Sender)
{
   VideoGrabber->SetDisplayActive (FDisplaySelected, chkDisplayActive->Checked);
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkVisibleClick(TObject *Sender)
{
   VideoGrabber->SetDisplayVisible (FDisplaySelected, chkVisible->Checked);
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkEmbeddedClick(TObject *Sender)
{
   VideoGrabber->SetDisplayEmbedded (FDisplaySelected, chkEmbedded->Checked);
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkAutoSizeClick(TObject *Sender)
{
   VideoGrabber->SetDisplayAutoSize (FDisplaySelected, chkAutoSize->Checked);
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkMouseMovesWindowClick(TObject *Sender)
{
   VideoGrabber->SetDisplayMouseMovesWindow (FDisplaySelected, chkMouseMovesWindow->Checked);
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkFullScreenClick(TObject *Sender)
{
   VideoGrabber->SetDisplayFullScreen (FDisplaySelected, chkFullScreen->Checked);
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkStayOnTopClick(TObject *Sender)
{
   VideoGrabber->SetDisplayStayOnTop (FDisplaySelected, chkStayOnTop->Checked);
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtAssignToMonitorNumberChange(
      TObject *Sender)
{
   VideoGrabber->SetDisplayMonitor (FDisplaySelected, StrToIntDef (edtAssignToMonitorNumber->Text, 0));
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTranspColorChange(TObject *Sender)
{
   VideoGrabber->SetDisplayTransparentColorValue (FDisplaySelected, StrToIntDef (edtTranspColor->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkUseVideoPortClick(TObject *Sender)
{
   VideoGrabber->SetDisplayVideoPortEnabled (FDisplaySelected, chkUseVideoPort->Checked);
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnNewLocationClick(TObject *Sender)
{
   VideoGrabber->SetDisplayAutoSize (FDisplaySelected, true);  // the component"s video size will be used
   VideoGrabber->SetDisplayEmbedded (FDisplaySelected, false); // detach from component
   VideoGrabber->SetDisplayLocation (FDisplaySelected, 10, 10, 320, 240); // 320 and 240 are ! used because of AutoSize above
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnNewLocation2Click(TObject *Sender)
{
   VideoGrabber->SetDisplayAutoSize (FDisplaySelected, false); // we will specify the size below
   VideoGrabber->SetDisplayEmbedded (FDisplaySelected, false); // detach from component
   VideoGrabber->SetDisplayLocation (FDisplaySelected, 20, 20, 480, 360); // new size: 480 x 360
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgAspectRatioClick(TObject *Sender)
{
   VideoGrabber->SetDisplayAspectRatio (FDisplaySelected, (TAspectRatio) rdgAspectRatio->ItemIndex);
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::tbrAlphablendChange(TObject *Sender)
{
   VideoGrabber->SetDisplayAlphaBlendValue (FDisplaySelected, tbrAlphablend->Position);

}

//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrPanScanChange(TObject *Sender)
{
   VideoGrabber->SetDisplayPanScanRatio (FDisplaySelected, tbrPanScan->Position);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnTestPanScanClick(TObject *Sender)
{
   rdgAspectRatio->ItemIndex = ar_PanScan;
   VideoGrabber->SetDisplayAspectRatio (FDisplaySelected, ar_PanScan);
   VideoGrabber->SetDisplayEmbedded (FDisplaySelected, true);
   VideoGrabber->SetDisplayAutoSize (FDisplaySelected, false);
   VideoGrabber->Width = 400;
   VideoGrabber->Height = VideoGrabber->Width * 9 / 16;
}

////////////////////////////////////////////////////////////////////////////////
//                            MOTION DETECTOR TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::chkMotionDetectionEnabledClick(
      TObject *Sender)
{
   VideoGrabber->MotionDetector_Enabled = chkMotionDetectionEnabled->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCompareRedClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_CompareRed = chkCompareRed->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCompareGreenClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_CompareGreen = chkCompareGreen->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCompareBlueClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_CompareBlue = chkCompareBlue->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk_GreyScaleClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_GreyScale = chk_GreyScale->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkReduceVideoNoiseClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_ReduceVideoNoise = chkReduceVideoNoise->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtGridChange(TObject *Sender)
{
   VideoGrabber->MotionDetector_Grid = edtGrid->Text;
   if (VideoGrabber->MotionDetector_IsGridValid) {
      shpGridValid->Brush->Color = clLime;
      lblGridValid->Caption = "valid";
   }
   else {
      shpGridValid->Brush->Color = clRed;
      lblGridValid->Caption = "invalid";
   }
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updGlobalGridSensitivityClick(
      TObject *Sender, TUDBtnType Button)
{
   if (Button == Comctrls::btNext) {
      VideoGrabber->MotionDetector_GloballyIncOrDecSensitivity (1);
   }
   else {
      VideoGrabber->MotionDetector_GloballyIncOrDecSensitivity (-1);
   }
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnApplyGridSizeClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_SetGridSize (StrToInt (edtGridColCount->Text), StrToInt (edtGridRowCount->Text));
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnSetCellsSensitivityClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_SetCellSensitivity (StrToInt (edtXCell->Text), StrToInt (edtYCell->Text), StrToInt (edtCellSensitivity->Text));
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnShowGridDialogClick(TObject *Sender)
{
   if ((VideoGrabber->CurrentState != cs_Preview) && (VideoGrabber->CurrentState != cs_Recording)) {
      ShowMessage ("you should start preview or recording to see the video frame under the grid");
   }
   else if (! VideoGrabber->MotionDetector_Enabled) {
      ShowMessage ("you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid");
   }
   VideoGrabber->MotionDetector_ShowGridDialog();
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTriggeredClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_Triggered = chkTriggered->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnTriggerNowClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_TriggerNow();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMotionDetected(TObject *Sender,
      double GlobalMotionRatio, int MaxMotionCellX, int MaxMotionCellY,
      Pointer FrameBitmap, DWORD FrameNumber, Int64 FrameTime, int FrameId,
      bool &CaptureFrame)
{
   int MaxMotionXLocation, MaxMotionYLocation;
   Graphics::TBitmap *MotionBitmap;

   shpMotionDetected->Brush->Color = clLime;
   edtMotionRatio->Text = FormatFloat ("0.000", VideoGrabber->MotionDetector_GlobalMotionRatio);

   edtMaxMotionXY->Text = "X:" + IntToStr (MaxMotionCellX) + " ; Y:" + IntToStr (MaxMotionCellY);
   if (VideoGrabber->MotionDetector_GetCellLocation (MaxMotionCellX, MaxMotionCellY, MaxMotionXLocation, MaxMotionYLocation)) {
      edtMaxMotionCoord->Text = "x: " + IntToStr (MaxMotionXLocation) + " ; y: " + IntToStr (MaxMotionYLocation);
   }

   mmoMotionGrid->Text = VideoGrabber->MotionDetector_Get2DTextMotion();

   MotionBitmap = VideoGrabber->GetLastFrameAsTBitmap (0, false, 0, 0, 0, 0, imgMotionDetected->Width, imgMotionDetected->Height, 0);
   if (MotionBitmap != NULL) {
      imgMotionDetected->Picture->Assign (MotionBitmap);
      delete (MotionBitmap);
   }

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMotionNotDetected(
      TObject *Sender, Pointer FrameBitmap, DWORD FrameNumber,
      Int64 FrameTime, int FrameId, bool &CaptureFrame)
{
   shpMotionDetected->Brush->Color = clGreen;
   edtMotionRatio->Text = "";
   mmoMotionGrid->Text = VideoGrabber->MotionDetector_Get2DTextMotion();
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                         "CLIP REENCODING" TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::btnSourceVideoClipClick(TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES;
   if (OpenDlg->Execute()) {
      edtSourceVideoClip->Text = OpenDlg->FileName;
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnDurationClick(TObject *Sender)
{
   __int64 Duration;
   __int64 FrameCount;

   if (VideoGrabber->AVIDuration (edtSourceVideoClip->Text, Duration, FrameCount)) {
      edtReencDuration->Text = IntToStr (Duration);
      edtReencFrameCount->Text = IntToStr (FrameCount);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartReencodingClick(TObject *Sender)
{
   VideoGrabber->Reencoding_SourceVideoClip = edtSourceVideoClip->Text;
   VideoGrabber->Reencoding_NewVideoClip = edtDestinationVideoClip->Text;

   VideoGrabber->Reencoding_WMVOutput = chkWMVOutput->Checked;
   VideoGrabber->Reencoding_IncludeVideoStream = chkIncludeVideoStream->Checked;
   VideoGrabber->Reencoding_IncludeAudioStream = chkIncludeAudioStream->Checked;
   VideoGrabber->Reencoding_UseFrameGrabber = chkUseFrameGrabber->Checked;
   VideoGrabber->Reencoding_UseVideoCompressor = chkUseCurrentVideoCompressor->Checked;
   VideoGrabber->Reencoding_UseAudioCompressor = chkUseCurrentAudioCompressor->Checked;
   VideoGrabber->Reencoding_Method = TRecordingMethod (rdgReencodingMethod->ItemIndex);

   // if a frame number is specified (<> -1), it is mandatory, so the time is ignored
   VideoGrabber->Reencoding_StartTime  = StrToInt64Def (edtReencStartTime->Text, -1);
   VideoGrabber->Reencoding_StartFrame  = StrToInt64Def (edtReencStartFrame->Text, -1);
   VideoGrabber->Reencoding_StopTime   = StrToInt64Def (edtReencStopTime->Text, -1);
   VideoGrabber->Reencoding_StopFrame   = StrToInt64Def (edtReencStopFrame->Text, -1);

   VideoGrabber->StartReencoding();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStopReencodingClick(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                                    MISC.
////////////////////////////////////////////////////////////////////////////////


void __fastcall TfrmMainForm::edtoragePathChange(TObject *Sender)
{
   VideoGrabber->StoragePath = edtoragePath->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::RefreshDeviceControls(void)
{
   if (ComponentState == (TComponentState() << csDestroying)) {
      // we do nothing if the app terminates
      return;
   }

   // refresh the controls according to the TVideoGrabber's states

   btnPauseRecording->Enabled = VideoGrabber->RecordingCanPause;
   btnResumeRecording->Enabled = VideoGrabber->RecordingCanPause;

   btnCameraControlDialog->Enabled = VideoGrabber->IsCameraControlAvailable;
   btnVideoQualityDialog->Enabled = VideoGrabber->IsVideoQualityAvailable;

   cboAnalogVideoStandard->Enabled = VideoGrabber->IsAnalogVideoDecoderAvailable;
   cboVideoInputs->Enabled = VideoGrabber->IsVideoCrossbarAvailable;

   edtFrameRate->Text = FormatFloat ("0.00", VideoGrabber->FrameRate);

   lblFrameOverlayRequiresFrameGrabber->Visible = VideoGrabber->FrameGrabber == fg_Disabled;
   lblMotionDetectorRequiresFrameGrabber->Visible = VideoGrabber->FrameGrabber == fg_Disabled;

}

void __fastcall TfrmMainForm::Resetvideocapturedevicesettings1Click(
      TObject *Sender)
{
   VideoGrabber->ResetVideoDeviceSettings();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberDVDiscontinuity(TObject *Sender,
      bool &DeliverNewFrame)
{
   // SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame = false;
   // VideoGrabber->RecordToNewFileNow();

   // SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame = false;
   // VideoGrabber->Stop();

   // Important: from this event you should not perform any actions with the potential to block, such as holding
   //   a critical section or waiting on another thread. Also, do not call any GDI or USER32.DLL APIs.
   
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberLog(TObject *Sender,
      TLogType LogType, String Severity, String InfoMsg)
{
   mmoLog->Lines->Add ("[" + Severity + "] " + InfoMsg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberInactive(TObject *Sender)
{
   mmoLog->Lines->Add ("(done)");
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::ShowFormAboveVideo (TForm *Form)
{
   if (Form == NULL) return;
   Form->Top = Top + VideoGrabber->Top - Form->Height;
   Form->Left = Left + VideoGrabber->Left - Form->Width;
   if (Form->Top < 0) {
      Form->Top = 0;
   }
   if (Form->Left < 0) {
      Form->Left = 0;
   }
   Form->Show();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::mnuAboutClick(TObject *Sender)
{
   VideoGrabber->About();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberResize(TObject *Sender)
{
   int NewWidth;
   int NewHeight;

   NewWidth = VideoGrabber->Left + VideoGrabber->Width + 30;
   NewHeight = VideoGrabber->Top + VideoGrabber->Height + 60;
   if (NewWidth < FStartupWidth) {
      NewWidth = FStartupWidth;
   }
   if (NewHeight < FStartupHeight) {
      NewHeight = FStartupHeight;
   }
   if ((NewWidth >= Width) && (NewHeight >= Height)) {
      Width = NewWidth;
      Height = NewHeight;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberDeviceLost(TObject *Sender)
{
   mmoLog->Lines->Add ("DEVICE LOST!");
   AssignListToComboBox (cboVideoDevices, VideoGrabber->VideoDevices, VideoGrabber->VideoDevice);
   AssignListToComboBox (cboAudioDevices, VideoGrabber->AudioDevices, VideoGrabber->AudioDevice);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberDiskFull(TObject *Sender)
{
   mmoLog->Lines->Add ("DISK FULL!");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberReinitializing(TObject *Sender)
{
   mmoLog->Clear();
   FOldVideoSignalState = false;
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::VideoGrabberDeviceArrivalOrRemoval(
      TObject *Sender, bool IsDeviceArrival, bool IsVideoDevice,
      String DeviceName, int DeviceIndex)
{
   String AudioOrVideoDevice;

   if (IsVideoDevice) {
      AudioOrVideoDevice= "video device ";
   }
   else {
      AudioOrVideoDevice= "audio device ";
   }
   if (IsDeviceArrival) {
      mmoLog->Lines->Add (AudioOrVideoDevice + "arrival:");
   }
   else {
      mmoLog->Lines->Add (AudioOrVideoDevice + "removal:");
   }
   mmoLog->Lines->Add (DeviceName);
   if (IsVideoDevice) {
      AssignListToComboBox (cboVideoDevices, VideoGrabber->VideoDevices, VideoGrabber->VideoDevice);
   }
   else {
      AssignListToComboBox (cboAudioDevices, VideoGrabber->AudioDevices, VideoGrabber->AudioDevice);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberVideoFromBitmapsNextFrameNeeded(
      TObject *Sender, bool FirstSample)
{
   // you can pass to this event:
   // - either the path to a BMP file or a JPEG file (this is the case in this example)
   // - either a the HBITMAP handle of a bitmap

   // FirstSample is true the first time the event occurs (useful to know e.g. when a file search must be restarted from the beginning)

   bool FileAvailable;
   bool EndOfData;
   String BMPorJPEGFilePath;

   FileAvailable = false;
   EndOfData = false;

   if (FirstSample || (! FSearchBmpOrJPEGFilesOpened))  { // let's start from the first file
      if (FSearchBmpOrJPEGFilesOpened) {
        FindClose (FSearchBmpOrJPEGFiles);
        FSearchBmpOrJPEGFilesOpened = false;
      }

      if (VideoGrabber->StoragePath.Length() > 0) { // let's add a trailing slash if required
         if (VideoGrabber->StoragePath.SubString (VideoGrabber->StoragePath.Length(), 1) == "\\") {
            FSearchBmpPath = VideoGrabber->StoragePath;
         }
         else {
            FSearchBmpPath = VideoGrabber->StoragePath + "\\";
         }
      }
      else {
         FSearchBmpPath = ".\\";
      }

      if (FindFirst (FSearchBmpPath + "*.bmp", faAnyFile, FSearchBmpOrJPEGFiles) == 0) {
         FileAvailable = true;
         FSearchBmpOrJPEGFilesOpened = true;
      }
      else if (FindFirst (FSearchBmpPath + "*.jpg", faAnyFile, FSearchBmpOrJPEGFiles) == 0) {
         FileAvailable = true;
         FSearchBmpOrJPEGFilesOpened = true;
      }
      else {
         mmoLog->Lines->Add ("");
         mmoLog->Lines->Add ("no bitmap files found in the StoragePath directory! Capture frames to BMP files first by using the frame grabber.");
         EndOfData = true;
      }
   }
   else {
      if (FindNext (FSearchBmpOrJPEGFiles) == 0) {
         FileAvailable = true;
      }
      else {
         FindClose (FSearchBmpOrJPEGFiles);
         FSearchBmpOrJPEGFilesOpened = false;
         EndOfData = true;
      };
   };

   if (FileAvailable) {
      BMPorJPEGFilePath = FSearchBmpPath + FSearchBmpOrJPEGFiles.Name;
      VideoGrabber->SendImageToVideoFromBitmaps (BMPorJPEGFilePath, NULL, false, EndOfData);
   }
   else {
      // to notify no more images available we pass an empty file name and set the EndOfData parameter to "true"
      VideoGrabber->SendImageToVideoFromBitmaps (NULL, NULL, false, true);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenAtFramesClick(TObject *Sender)
{
   // -2 is just used to check if the numeric value is valid
   if ((StrToIntDef (edtartFrame->Text, -2) != -2) && (StrToIntDef (edtopFrame->Text, -2) != -2)) {
      VideoGrabber->OpenPlayerAtFramePositions (StrToInt (edtartFrame->Text), StrToInt (edtopFrame->Text), chkKeepBounds->Checked, chkReopen->Checked);
   }
   else {
      ShowMessage ("invalid start frame or stop frame");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenAtTimesClick(TObject *Sender)
{
   // -2 is just used to check if the numeric value is valid
   if ((StrToIntDef (edtartTime->Text, -2) != -2) && (StrToIntDef (edtopTime->Text, -2) != -2)) {
      VideoGrabber->OpenPlayerAtTimePositions (StrToInt (edtartTime->Text), StrToInt (edtopTime->Text), chkKeepBounds->Checked, chkReopen->Checked);
   }
   else {
      ShowMessage ("invalid start Time or stop Time");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbsIPCamerasShow(TObject *Sender)
{
   lblChooseIPCamera->Visible = (VideoGrabber->VideoSource != vs_IPCamera);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnCurrentIPCameraURLClick(TObject *Sender)
{
	  ShellExecute(0, L"open", L"http://www.datastead.com/demo/IPCam.htm", NULL, NULL, SW_SHOW);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCameraURLChange(TObject *Sender)
{
   VideoGrabber->IPCameraURL = edtIPCameraURL->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkOpenURLAsyncClick(TObject *Sender)
{
    VideoGrabber->OpenURLAsync = chkOpenURLAsync->Checked;
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::chkUseExternalAudioforRTSPClick(
      TObject *Sender)
{
   if (chkUseExternalAudioforRTSP->Checked) {
      VideoGrabber->AudioSource = as_UseExternalAudio;
   }
   else {
      VideoGrabber->AudioSource = as_Default;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCamUserNameChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_IPCamera, edtIPCamUserName->Text, edtIPCamPassword->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCamPasswordChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_IPCamera, edtIPCamUserName->Text, edtIPCamPassword->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCamConnectionTimeoutChange(
      TObject *Sender)
{
   VideoGrabber->SetIPCameraSetting (ips_ConnectionTimeout, StrToIntDef (edtIPCamConnectionTimeout->Text, 10000));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCamReceiveTimeoutChange(TObject *Sender)
{
   VideoGrabber->SetIPCameraSetting (ips_ReceiveTimeout, StrToIntDef (edtIPCamReceiveTimeout->Text, 5000));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnIPCamStartPreviewClick(TObject *Sender)
{
   if (VideoGrabber->VideoSource != vs_IPCamera) {
      if (VideoGrabber->CurrentState == cs_Down) {
         VideoGrabber->VideoSource = vs_IPCamera;
         mmoLog->Lines->Add ("VideoSource set to vs_IPCamera");
      }
      else {
         ShowMessage ("stop the current action, then select 'IP camera' in the 'Video sources' list of the 'Video Source' tab");
      }
   }
   edtIPCameraURL->Text = VideoGrabber->IPCameraURL; // to reflect the current URL configured
   VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnIPCameraStopClick(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnIPCameraStarttMP4RecordingClick(
      TObject *Sender)
{
   if (VideoGrabber->VideoSource != vs_IPCamera) {
      if (VideoGrabber->CurrentState == cs_Down) {
         VideoGrabber->VideoSource = vs_IPCamera;
         mmoLog->Lines->Add ("VideoSource set to vs_IPCamera");
      }
      else {
         ShowMessage ("stop the current action, then select 'IP camera' in the 'Video sources' list of the 'Video Source' tab");
      }
   }
   edtIPCameraURL->Text = VideoGrabber->IPCameraURL; // to reflect the current URL configured
   rdgRecordingMethod->ItemIndex = (Integer) rm_MP4;
   VideoGrabber->StartRecording();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnIPCamAuthenticationInfoClick(
      TObject *Sender)
{
   ShowMessage ("when an authentication is required to connect to the IP camera, the OnAuthenticationNeeded event occurs.\nThe user name and password must be passed to the UserName and Password parameters of this event.");

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::FormDestroy(TObject *Sender)
{
   if (FSearchBmpOrJPEGFilesOpened) {
      FindClose (FSearchBmpOrJPEGFiles);
      FSearchBmpOrJPEGFilesOpened = false;
   }
}
//---------------------------------------------------------------------------

int PIPMixIndex = -1;

TVideoGrabber *PIPVideoGrabber = NULL;

void __fastcall TfrmMainForm::btnPIPFromAnotherTVideoGrabberClick(
      TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES;
   if (OpenDlg->Execute()) {
      if (PIPVideoGrabber == NULL) {
         PIPVideoGrabber = new TVideoGrabber(this);
         PIPVideoGrabber->VideoRenderer = vr_None;
         PIPVideoGrabber->Visible = false;
         if (PIPMixIndex > -1) {
            VideoGrabber->Mixer_RemoveFromMixer (PIPMixIndex);
         }
         VideoGrabber->Mixer_SetupPIPFromSource (PIPVideoGrabber->UniqueID, 0, 0, 0, 0, true, 10, 10, 200, 150, false);
      }
      PIPVideoGrabber->PlayerFileName = OpenDlg->FileName;
      PIPVideoGrabber->OpenPlayer();
   }
   delete (OpenDlg);
}

//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPIPStopClick(TObject *Sender)
{
   if (PIPMixIndex > -1) {
      VideoGrabber->Mixer_RemoveFromMixer (PIPMixIndex);
      PIPMixIndex = -1;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgImageOverlaySelectorClick(TObject *Sender)
{
   FImageOverlayIndex = rdgImageOverlaySelector->ItemIndex;

   chkImageOverlayEnabled->Checked = VideoGrabber->GetImageOverlay_Enabled(FImageOverlayIndex);
   edtImageOverlayTargetDisplay->Text = IntToStr (VideoGrabber->GetImageOverlay_TargetDisplay(FImageOverlayIndex));
   edtImageOverlayLeft->Text = IntToStr (VideoGrabber->GetImageOverlay_LeftLocation(FImageOverlayIndex));
   edtImageOverlayTop->Text = IntToStr (VideoGrabber->GetImageOverlay_TopLocation(FImageOverlayIndex));
   edtImageOverlayWidth->Text = IntToStr (VideoGrabber->GetImageOverlay_Width(FImageOverlayIndex));
   edtImageOverlayHeight->Text = IntToStr (VideoGrabber->GetImageOverlay_Height(FImageOverlayIndex));

   chkImageOverlayTransparent->Checked = VideoGrabber->GetImageOverlay_Transparent(FImageOverlayIndex);
   chkImageOverlayUseTransparentColor->Checked = VideoGrabber->GetImageOverlay_UseTransparentColor(FImageOverlayIndex);
   TVarRec TransparentColorValueVar[] = {VideoGrabber->GetImageOverlay_TransparentColorValue(FImageOverlayIndex)};
   edtImageOverlayTransparentColorValue->Text = Format ("$%.6X", TransparentColorValueVar, (ARRAYSIZE(TransparentColorValueVar) -1));

   chkImageOverlayAlphaBlend->Checked = VideoGrabber->GetImageOverlay_AlphaBlend(FImageOverlayIndex);
   chkImageOverlayAlphablendCoeff->Position = (short) VideoGrabber->GetImageOverlay_AlphaBlendValue(FImageOverlayIndex);

   chkImageOverlayChromaKey->Checked = VideoGrabber->GetImageOverlay_ChromaKey(FImageOverlayIndex);
   edtChromaKeyLeewayPercent->Position = VideoGrabber->GetImageOverlay_ChromaKeyLeewayPercent(FImageOverlayIndex);
   TVarRec ChromaKeyColorValueVar[] = {VideoGrabber->GetImageOverlay_ChromaKeyRGBColor(FImageOverlayIndex)};
   edtChromaKeyColorValue->Text = Format ("%.6X", ChromaKeyColorValueVar, (ARRAYSIZE(ChromaKeyColorValueVar) -1));

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayLeftChange(TObject *Sender)
{
   VideoGrabber->SetImageOverlay_LeftLocation(FImageOverlayIndex, StrToIntDef (edtImageOverlayLeft->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayTopChange(TObject *Sender)
{
   VideoGrabber->SetImageOverlay_TopLocation(FImageOverlayIndex, StrToIntDef (edtImageOverlayTop->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayWidthChange(TObject *Sender)
{
   VideoGrabber->SetImageOverlay_Width(FImageOverlayIndex, StrToIntDef (edtImageOverlayWidth->Text, -1));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayHeightChange(TObject *Sender)
{
   VideoGrabber->SetImageOverlay_Height(FImageOverlayIndex, StrToIntDef (edtImageOverlayHeight->Text, -1));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayTransparentClick(
      TObject *Sender)
{
   VideoGrabber->SetImageOverlay_Transparent(FImageOverlayIndex,chkImageOverlayTransparent->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnImageOverlayPickupColorClick(
      TObject *Sender)
{
   DWORD MouseLocationRGBValue = VideoGrabber->GetRGBPixelAt (-1, -1);
   VideoGrabber->SetImageOverlay_TransparentColorValue(FImageOverlayIndex, MouseLocationRGBValue);
   TVarRec RGBPixelValueVar[] = {(int) MouseLocationRGBValue};
   edtImageOverlayTransparentColorValue->Text = Format ("%.6X", RGBPixelValueVar, (ARRAYSIZE(RGBPixelValueVar) -1));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnImageOverlayPickupHelpClick(
      TObject *Sender)
{
   ShowMessage ("while the preview is running:\n- load the image overlay\n- enable ""transparent"" and ""use transp. color value""\n- in the video window, click on the video frame on the color of the overlayed image you want to be transparent\n- click on 'pickup the transparent color'");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayUseTransparentColorClick(
      TObject *Sender)
{
   VideoGrabber->SetImageOverlay_UseTransparentColor(FImageOverlayIndex, chkImageOverlayUseTransparentColor->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayTransparentColorValueChange(
      TObject *Sender)
{
   VideoGrabber->SetImageOverlay_TransparentColorValue(FImageOverlayIndex, StrToIntDef (edtImageOverlayTransparentColorValue->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayAlphaBlendClick(
      TObject *Sender)
{
   VideoGrabber->SetImageOverlay_AlphaBlend(FImageOverlayIndex, chkImageOverlayAlphaBlend->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayAlphablendCoeffChange(
      TObject *Sender)
{
   VideoGrabber->SetImageOverlay_AlphaBlendValue(FImageOverlayIndex, chkImageOverlayAlphablendCoeff->Position);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updImageAlphaBendClick(TObject *Sender,
      TUDBtnType Button)
{
   VideoGrabber->SetImageOverlay_AlphaBlendValue(FImageOverlayIndex, chkImageOverlayAlphablendCoeff->Position);
}
//---------------------------------------------------------------------------



void __fastcall TfrmMainForm::chkImageOverlayChromaKeyClick(
      TObject *Sender)
{
   VideoGrabber->SetImageOverlay_ChromaKey(FImageOverlayIndex, chkImageOverlayChromaKey->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtChromaKeyLeewayPercentChange(
      TObject *Sender)
{
   VideoGrabber->SetImageOverlay_ChromaKeyLeewayPercent(FImageOverlayIndex, edtChromaKeyLeewayPercent->Position);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtChromaKeyColorValueChange(TObject *Sender)
{
   VideoGrabber->SetImageOverlay_ChromaKeyRGBColor(FImageOverlayIndex, StrToIntDef (edtChromaKeyColorValue->Text, 0));
}

//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::BtnCodecExamplesClick(TObject *Sender)
{
   ShellExecute(0, L"open", L"https://www.datastead.com/faq/how-can-the-tvideograbber-sdk-record-in-mp4-through-the-multipurpose-encoder/", NULL, NULL, SW_SHOW);

}
//---------------------------------------------------------------------------

void ShowTargetDisplayInfo()
{
   ShowMessage (
    "SetTextOverlay_TargetDisplay / SetImageOverlay_TargetDisplay determines how the overlay is be applied (*):\n" \
    "\n" \
    "TargetDisplay = -1: OVERLAY APPLIED TO THE VIDEO FRAME\n" \
    "advantage: the overlay can applied on the recording if RecordingInNativeFormat is disabled\n" \
    "disadvantage: if the frame is stretched (e.g. full screen display) the overlay is stretched as well\n" \
    "\n" \
    "TargetDisplay = -2: OVERLAY APPLIED TO ALL THE VIDEO WINDOWS but not to the video frames (recorded or captured)\n" \
    "advantage: when stretching the video windows (e.g. full screen display), the overlays are not stretched\n" \
    "disadvantage: it is applied the same way on all the renderers (e.g. if DualDisplay or more renderers are enabled)\n" \
    "\n" \
    "TargetDisplay = n (in the 0..n-1 range): OVERLAY APPLIED TO THE SPECIFIED VIDEO WINDOW\n" \
    "advantage: when more than 1 renderer is used, it is possible to display this overlay only one the specified renderer\n" \
    "Possible values:\n" \
    "0: Display... renderer\n" \
    "1: DualDisplay... renderer\n" \
    "2 to 9: third to tenth video renderer\n" \
    "\n" \
    "(*) notes:\n" \
    "- TargetDisplay <> -1 REQUIRES VideoRenderer to be set to vr_Auto or vr_RecordingPriority\n" \
    "- to quick see what happens when changing TargetDisplay, go to theDisplay tab, activate e.g. 4 or 5 video windows and try -1, -2, 0, 1, 2, 3, 4, 5 as TargetDisplay value"
    );
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnTargetDisplayInfoClick(TObject *Sender)
{
   ShowTargetDisplayInfo();

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnImageOverlayInfoClick(TObject *Sender)
{
   ShowTargetDisplayInfo();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkMPERecordingClick(TObject *Sender)
{
   VideoGrabber->EnableMultipurposeEncoder (mpe_Recording, chkMPERecording->Checked);
   edtMPERecordingChange(this); // to apply the recording settings
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkMPEStreamingClick(TObject *Sender)
{
   VideoGrabber->EnableMultipurposeEncoder (mpe_Streaming, chkMPEStreaming->Checked);
   edtMPEStreamingChange(this); // to apply the streaming settings
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtMPERecordingChange(TObject *Sender)
{
   VideoGrabber->SetMultipurposeEncoderSettings (mpe_Recording, edtMPERecording->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtMPEReencodingChange(TObject *Sender)
{
   VideoGrabber->SetMultipurposeEncoderSettings (mpe_Reencoding, edtMPEReencoding->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtMPEStreamingChange(TObject *Sender)
{
   VideoGrabber->SetMultipurposeEncoderSettings (mpe_Streaming, edtMPEStreaming->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartMPEReencodingClick(TObject *Sender)
{
   edtMPEReencodingChange(this); // to apply the reencoding settings
   VideoGrabber->EnableMultipurposeEncoder (mpe_Reencoding, true);
   VideoGrabber->StartReencoding();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStopMPEReencodingClick(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::VideoGrabberMultipurposeEncoderProgress(
      TObject *Sender,
      TMultipurposeEncoderInstance MultipurposeEncoderInstance)
{
   unsigned int InputsTotalDurationMs;
   unsigned int FrameCount;
   double fps;
   double quality;
   double SizeWrittenKb;
   unsigned int TimeMs;
   double BitRate;
   unsigned int DuplicatedCount;
   unsigned int DroppedCount;
   int ExitCode;
   String ProgressInfo;

   VideoGrabber->MultipurposeEncoder_GetCurrentInfo (MultipurposeEncoderInstance,
      InputsTotalDurationMs,
      FrameCount,
      fps,
      quality,
      SizeWrittenKb,
      TimeMs,
      BitRate,
      DuplicatedCount,
      DroppedCount,
      ExitCode);

   System::TVarRec ProgressInfoVars[] = {(int) FrameCount, (long double) fps, (int) TimeMs, (int) SizeWrittenKb, (int) BitRate, (int) DroppedCount};

   ProgressInfo = Format("Frame count: %4d       Fps: %2.1f        Time(ms):%10d       Written(kb): %5.1f       Bitrate(kbps): %5.1f       Dropped:  %4d", ProgressInfoVars, (ARRAYSIZE(ProgressInfoVars) -1));

   if (MultipurposeEncoderInstance == mpe_Recording) {
      lblMPERecordingProgressInfo->Caption = ProgressInfo;
      mmoMPERecordingLog->Lines->Add (VideoGrabber->MultipurposeEncoder_GetLastLog(mpe_Recording));
   }
   else if (MultipurposeEncoderInstance == mpe_Streaming) {
	  lblMPEStreamingProgressInfo->Caption = ProgressInfo;
      mmoMPEStreamingLog->Lines->Add (VideoGrabber->MultipurposeEncoder_GetLastLog(mpe_Streaming));
   }
   else if (MultipurposeEncoderInstance == mpe_Reencoding) {
	  lblMPEReencodingProgressInfo->Caption = ProgressInfo;
	  mmoMPEReencodingLog->Lines->Add (VideoGrabber->MultipurposeEncoder_GetLastLog(mpe_Reencoding));
   }
}



void __fastcall TfrmMainForm::btnBargraphOverlayClick(TObject *Sender)
{
   VideoGrabber->SetVUMeterSetting (2, vu_OverlayLeft, 10);
   VideoGrabber->SetVUMeterSetting (3, vu_OverlayLeft, 140);
   for (int i = 2; i <= 3; i ++) {
      VideoGrabber->SetVuMeter_Enabled(i, vu_BargraphOverlay);
      VideoGrabber->SetVUMeterSetting (i, vu_Transparent, 1);
      VideoGrabber->SetVUMeterSetting (i, vu_OverlayTop, 10);
      VideoGrabber->SetVUMeterSetting (i, vu_OverlayWidth, 100);
      VideoGrabber->SetVUMeterSetting (i, vu_OverlayHeight, 60);
      VideoGrabber->SetVUMeterSetting (i, vu_BkgndColor, 0x800000);
      VideoGrabber->SetVUMeterSetting (i, vu_NormalColor, 0x000080);
      VideoGrabber->SetVUMeterSetting (i, vu_WarningColor, 0x00A5FF);
      VideoGrabber->SetVUMeterSetting (i, vu_PeakColor, 0x00FFFF);
      VideoGrabber->SetVUMeterSetting (i, vu_WarningPercent, 20);
      VideoGrabber->SetVUMeterSetting (i, vu_PeakPercent, 40);
   }

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrPTZSpeedRatioChange(TObject *Sender)
{
        FPTZSpeedRatio = tbrPTZSpeedRatio->Position / 100;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnHelpPTZSpeedRatioClick(TObject *Sender)
{
   ShowMessage ("the 'PTZ speed adjustment' and 'absolute PTZ move' capabilities are not supported by all the brands/models of ONVIF cameras");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPTZHelpDurationClick(TObject *Sender)
{
   ShowMessage ("Duration of the motion expressed in milliseconds.\n0 = continuous move\n\nNote: some cameras may not support a motion duration and move continuously even if a duration is specified.\n In this case invoke StartMove(), wait the desired duration with a timer then invoke ONVIFPTZStopMove()");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::PTZStopContinuousMove()
{
   VideoGrabber->ONVIFPTZStopMove("Tilt");
   VideoGrabber->ONVIFPTZStopMove("Pan");
   VideoGrabber->ONVIFPTZStopMove("Zoom");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::PTZStopClick(TObject *Sender)
{
   PTZStopContinuousMove();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgIRCutFilterClick(TObject *Sender)
{
   switch (rdgIRCutFilter->ItemIndex) {
      case 0:
         VideoGrabber->ONVIF_SetStr ("RTSP_Source_Axis_IrCutFilter_str", "auto");
         break;
      case 1:
         VideoGrabber->ONVIF_SetStr ("RTSP_Source_Axis_IrCutFilter_str", "enabled");
         break;
      case 2:
         VideoGrabber->ONVIF_SetStr ("RTSP_Source_Axis_IrCutFilter_str", "disabled");
         break;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::ptzButtonsMouseUp(TObject *Sender,
      TMouseButton Button, TShiftState Shift, int X, int Y)
{
   if (chkPTZMouseUpStop->Checked) {
      PTZStopContinuousMove();
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtPTZDurationMsChange(TObject *Sender)
{
   FPTZMoveDurationMs = StrToIntDef (edtPTZDurationMs->Text, 300);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPTZTiltUpClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZStartMove ("Tilt", false, FPTZSpeedRatio, FPTZMoveDurationMs);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPTZTiltDownClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZStartMove ("Tilt", true, FPTZSpeedRatio, FPTZMoveDurationMs);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPTZPanLeftClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZStartMove ("Pan", false, FPTZSpeedRatio, FPTZMoveDurationMs);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPTZPanRightClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZStartMove ("Pan", true, FPTZSpeedRatio, FPTZMoveDurationMs);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPTZZoomOutClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZStartMove ("Zoom", false, FPTZSpeedRatio, FPTZMoveDurationMs);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPTZZoomInClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZStartMove ("Zoom", true, FPTZSpeedRatio, FPTZMoveDurationMs);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::DoPTZAbsolute()
{
   double dPan, dTilt, dZoom;

   if (!FUpdatingPTZTrackbars) {
      if ((GetKeyState(VK_LBUTTON) & 0x8000) == 0) { // to do something only when the mouse button is released on the trackbar
         dPan =tbrPTZPan->Position / 100;
         dTilt =tbrPTZTilt->Position / 100;
         dZoom =tbrPTZZoom->Position / 100;
         VideoGrabber->ONVIFPTZSetPosition (dPan, dTilt, dZoom, FPTZSpeedRatio, false);
      }
   }
}
//---------------------------------------------------------------------------



void __fastcall TfrmMainForm::tbrPTZPanChange(TObject *Sender)
{
   DoPTZAbsolute();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrPTZZoomChange(TObject *Sender)
{
   DoPTZAbsolute();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrPTZTiltChange(TObject *Sender)
{
   DoPTZAbsolute();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPTZSetTrackbarLimitsClick(TObject *Sender)
{
   double dPan_Min, dPan_Max, dTilt_Min, dTilt_Max, dZoom_Min, dZoom_Max;
   double dPan, dTilt, dZoom;
   __int64 UTCTime;
   int IsMoving;

   if (VideoGrabber->ONVIFPTZGetLimits (dPan_Min, dPan_Max, dTilt_Min, dTilt_Max, dZoom_Min, dZoom_Max)) {
      FUpdatingPTZTrackbars = true;
      tbrPTZPan->Min = dPan_Min * 100.0;
      tbrPTZPan->Max = dPan_Max * 100.0;
      tbrPTZTilt->Min = dTilt_Min * 100.0;
      tbrPTZTilt->Max = dTilt_Max * 100.0;
      tbrPTZZoom->Min = dZoom_Min * 100.0;
      tbrPTZZoom->Max = dZoom_Max * 100.0;
      tbrPTZSpeedRatio->Min = 0;
      tbrPTZSpeedRatio->Max = 100;
      tbrPTZSpeedRatio->Position = FPTZSpeedRatio * 100.0;

      if (VideoGrabber->ONVIFPTZGetPosition (dPan, dTilt, dZoom, UTCTime, IsMoving)) {
         tbrPTZPan->Position = dPan * 100.0;
         tbrPTZTilt->Position = dTilt * 100.0;
         tbrPTZZoom->Position = dZoom * 100.0;
      }
      FUpdatingPTZTrackbars = false;
   }

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtPTZRelativeMoveChange(TObject *Sender)
{
   FPTZRelativeMove = StrToFloatDef (edtPTZRelativeMove->Text, 0.01);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnRelativeTiltUpClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZSetPosition (0, FPTZRelativeMove, 0, FPTZSpeedRatio, true);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnRelativeTiltDownClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZSetPosition (0, -FPTZRelativeMove, 0, FPTZSpeedRatio, true);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnRelativePanLeftClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZSetPosition (FPTZRelativeMove, 0, 0, FPTZSpeedRatio, true);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnRelativePanRightClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZSetPosition (-FPTZRelativeMove, 0, 0, FPTZSpeedRatio, true);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnRelativeZoomOutClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZSetPosition (0, 0, -FPTZRelativeMove, FPTZSpeedRatio, true);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnRelativeZoomInClick(TObject *Sender)
{
   VideoGrabber->ONVIFPTZSetPosition (0, 0, FPTZRelativeMove, FPTZSpeedRatio, true);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::mnuExitClick(TObject *Sender)
{
   Close();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdbAudioSourceDefaultClick(TObject *Sender)
{
   VideoGrabber->AudioSource = as_Default;

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdbExternalAudioClick(TObject *Sender)
{
   VideoGrabber->AudioSource = as_UseExternalAudio;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdbAudioSourceSpeakerOutputClick(
      TObject *Sender)
{
   VideoGrabber->AudioSource = as_SpeakerOutput;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdbAudioSourceDefaultWithSpeakerRecordingClick(
      TObject *Sender)
{
   VideoGrabber->AudioSource = as_DefaultWithSpeakerRecording;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgPreferredVideoSizeClick(TObject *Sender)
{
  switch (rdgPreferredVideoSize->ItemIndex) {
     case 0: VideoGrabber->UseNearestVideoSize (0, 0, chkretchPreferredVideoSize->Checked); break;
     case 1: VideoGrabber->UseNearestVideoSize ( 640, 360, chkretchPreferredVideoSize->Checked); break;
     case 2: VideoGrabber->UseNearestVideoSize (1280, 720, chkretchPreferredVideoSize->Checked); break;
     case 3: VideoGrabber->UseNearestVideoSize (1920, 1080, chkretchPreferredVideoSize->Checked); break;
     // or any other custom value
  }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkretchPreferredVideoSizeClick(
      TObject *Sender)
{
   rdgPreferredVideoSizeClick (this);
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::edtDatasteadEncoder_CodecNameChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetStr (ENCODER_RECORDING_ID, Enc_Video_Codec, edtDatasteadEncoder_CodecName->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtDatasteadEncoder_Video_Bitrate_kbChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_BitRate_kb, StrToIntDef (edtDatasteadEncoder_Video_Bitrate_kb->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtDatasteadEncoder_Video_rc_MinBitRate_kbChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_rc_MinBitRate_kb, StrToIntDef (edtDatasteadEncoder_Video_rc_MinBitRate_kb->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtDatasteadEncoder_Video_rc_MaxBitRate_kbChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_rc_MaxBitRate_kb, StrToIntDef (edtDatasteadEncoder_Video_rc_MaxBitRate_kb->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtDatasteadEncoder_Video_rc_BufferSize_kbChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_rc_BufferSize_kb, StrToIntDef (edtDatasteadEncoder_Video_rc_BufferSize_kb->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtDatasteadEncoder_Video_IDRIntervalChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_IDR_Interval, StrToIntDef (edtDatasteadEncoder_Video_IDRInterval->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtDatasteadEncoder_Video_MaxBframesChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_Max_BFrames, StrToIntDef (edtDatasteadEncoder_Video_MaxBframes->Text, 0));
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::edtDatasteadEncoder_Video_ThreadCountChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_Thread_Count, StrToIntDef (edtDatasteadEncoder_Video_ThreadCount->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtDatasteadEncoder_Audio_SamplesPerSecondChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Audio_SamplesPerSec, StrToIntDef (edtDatasteadEncoder_Audio_SamplesPerSecond->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtDatasteadEncoder_Audio_BitRate_kbChange(
      TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Audio_BitRate_kb, StrToIntDef (edtDatasteadEncoder_Audio_BitRate_kb->Text, 0));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cmbGPUEncoderChange(TObject *Sender)
{
   VideoGrabber->Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_GPU_Encoder, cmbGPUEncoder->ItemIndex);
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::mmoExtraParametersChange(TObject *Sender)
{
   VideoGrabber->Encoder_SetStr (ENCODER_RECORDING_ID, Enc_Extra_Parameters, mmoExtraParameters->Lines->Text);

}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::btnMultipurposeUDPStreamingClick(TObject *Sender)
{
	if (FMultipurposeUDPStreamingID == -1) {
	   FMultipurposeUDPStreamingID = VideoGrabber->Encoders_CreateInstanceForStreaming ("udp://239.255.0.1:10124");
	}
	if (FMultipurposeUDPStreamingID > -1) {
	   /// uncomment one of the lines below to use a specific codec, e.g.:
	   //VideoGrabber->Encoder_SetStr (FMultipurposeUDPStreamingID, Enc_Video_Codec, "hevc");
	   //VideoGrabber->Encoder_SetStr (FMultipurposeUDPStreamingID, Enc_Video_Codec, "h264");

	   VideoGrabber->Encoder_SetInt (FMultipurposeUDPStreamingID, Enc_Video_Enabled_bool, 1);
	   VideoGrabber->Encoder_SetInt (FMultipurposeUDPStreamingID, Enc_Audio_Enabled_bool, 1);
	   if (!chkStreamingVideoEnabled->Checked) {
		  VideoGrabber->Encoder_SetInt (FMultipurposeUDPStreamingID, Enc_Video_Enabled_bool, 0);
	   }
	   if (!chkStreamingAudioEnabled->Checked) {
		  VideoGrabber->Encoder_SetInt (FMultipurposeUDPStreamingID, Enc_Audio_Enabled_bool, 0);
	   }
	   VideoGrabber->Encoder_SetInt (FMultipurposeUDPStreamingID, Enc_Video_BitRate_kb, 2000);
	   VideoGrabber->Encoder_SetInt (FMultipurposeUDPStreamingID, Enc_Video_rc_MinBitRate_kb, 1800);
	   VideoGrabber->Encoder_SetInt (FMultipurposeUDPStreamingID, Enc_Video_rc_MaxBitRate_kb, 2200);
	   VideoGrabber->Encoder_SetInt (FMultipurposeUDPStreamingID, Enc_Video_IDR_Interval, 30);
	   /// uncomment to enable the GPU encoder, if available for h264 or hevc
	   // VideoGrabber->Encoder_SetInt (FStreamingEncoderId, Enc_Video_GPU_Encoder, LongInt (Enc_GPU_Auto));  // or specify directly Enc_GPU_Intel_QSV, Enc_GPU_NVidia_NVENC or Enc_GPU_AMD_AMF
	   VideoGrabber->Encoder_SetInt (FMultipurposeUDPStreamingID, Enc_IsActive_bool, 1);
	}

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPauseStreamingClick(TObject *Sender)
{
   VideoGrabber->Encoder_Pause (FMultipurposeUDPStreamingID);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResumeStreamingClick(TObject *Sender)
{
   VideoGrabber->Encoder_Resume (FMultipurposeUDPStreamingID);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnNDIStreamingOKClick(TObject *Sender)
{
   if (chkStreamingVideoEnabled->Checked  && chkStreamingAudioEnabled->Checked)
   {
	  VideoGrabber->NetworkStreamingType = nst_AudioVideoStreaming;
   }
   else if (chkStreamingVideoEnabled->Checked)
   {
	  VideoGrabber->NetworkStreamingType = nst_VideoStreaming;
   }
   else if (chkStreamingAudioEnabled->Checked)
   {
	  VideoGrabber->NetworkStreamingType = nst_AudioStreaming;
   }
   VideoGrabber->NDIName = edtNDISessionName->Text;
   VideoGrabber->NetworkStreaming = ns_NDI;
   mmoLog->Lines->Add ("NDI streaming enabled");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnNDIStreamingClientViewClick(TObject *Sender)
{
   VideoGrabber->VideoSource = vs_VideoFileOrURL;
   VideoGrabber->VideoSource_FileOrURL = edtNDIRemoteHostAndSession->Text;
   VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::edtDatasteadEncoder_AudioCodecNameChange(TObject *Sender)

{
   VideoGrabber->Encoder_SetStr (ENCODER_RECORDING_ID, Enc_Audio_Codec, edtDatasteadEncoder_AudioCodecName->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnNDISessionsClick(TObject *Sender)
{
   String SessionList = VideoGrabber->GetNDISessions(false, false);
   mmoLog->Lines->Add("ndi sessions available:");
   mmoLog->Lines->Add(SessionList);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtNDIReceiveTimeoutChange(TObject *Sender)
{
  VideoGrabber->NDIReceiveTimeoutMs = StrToIntDef (edtNDIReceiveTimeout->Text, 0);
}
//---------------------------------------------------------------------------

