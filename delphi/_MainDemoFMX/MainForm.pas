/// FireMonkey version of the VCL MainDemo (_MainDemo folder).
unit MainForm;

interface

uses
   VidGrab,
   Winapi.Windows, Winapi.Messages, Winapi.ShellAPI, System.SysUtils, System.Types, System.Classes,
   System.Variants,
   /// Vcl.Graphics and Vcl.Forms before System.UITypes and the FMX units: the shared names (TBitmap,
   /// TCanvas, TForm, Application...) resolve to FMX, the VCL types required by the TVideoGrabber
   /// events are qualified (Vcl.Graphics.TBitmap). Vcl.Forms provides bsNone/bsSingle
   /// (TVideoGrabber.BorderStyle)
   Vcl.Graphics,
   Vcl.Forms,
   System.UITypes,
   FMX.Types, FMX.Controls, FMX.Forms, FMX.Graphics, FMX.Dialogs, FMX.StdCtrls,
   FMX.Controls.Presentation, FMX.Edit, FMX.ListBox, FMX.Layouts, FMX.Memo, FMX.Memo.Types,
   FMX.ScrollBox, FMX.TabControl, FMX.Objects, FMX.Menus, FMX.Platform.Win,
   VidgrabFMX, FmxDemoHelpers;

const
   FreeHandMouseCoordinatesMax = 5000;

type
   TfrmMainForm = class(TForm)
      Label9: TLabel;
      Label52: TLabel;
      Label18: TLabel;
      Label105: TLabel;
      Label107: TLabel;
      mmoLog: TMemo;
      edtStoragePath: TEdit;
      edtFrameCount: TEdit;
      grbPlayerControl: TGroupBox;
      btnPlayerBackwards: TSpeedButton;
      btnPlayerBackwards_Glyph: TImage;
      btnPlayerPause: TSpeedButton;
      btnPlayerPause_Glyph: TImage;
      btnPlayerStop: TSpeedButton;
      btnPlayerStop_Glyph: TImage;
      btnPlayerStartPlaying: TSpeedButton;
      btnPlayerStartPlaying_Glyph: TImage;
      btnPlayerRewind: TSpeedButton;
      btnPlayerRewind_Glyph: TImage;
      btnPlayerFastForward: TSpeedButton;
      btnPlayerFastForward_Glyph: TImage;
      btnPlayerFrameStep: TSpeedButton;
      btnPlayerFrameStep_Glyph: TImage;
      tbrPlayerProgress: TTrackBar;
      chkPlayerTrackbarSynchrone: TCheckBox;
      pnlVideo: TRectangle;
      pctMain: TTabControl;
      tbsVideoDevice: TTabItem;
      Label28: TLabel;
      grbVideoDeviceDialogs: TGroupBox;
      btnDeviceDialog: TButton;
      btnCameraControlDialog: TButton;
      btnVideoQualityDialog: TButton;
      grbVsVideoCaptureDevice: TGroupBox;
      Label2: TLabel;
      Label19: TLabel;
      Label81: TLabel;
      Label104: TLabel;
      Label4: TLabel;
      cboVideoInputs: TComboBox;
      cboAnalogVideoStandard: TComboBox;
      cboVideoDevices: TComboBox;
      cboVideoFormats: TComboBox;
      cboVideoSubtypes: TComboBox;
      cboVideoSizes: TComboBox;
      btnAutoRefreshPreview: TCheckBox;
      grbVsFileOrUrl: TGroupBox;
      btnSelectFileOrUrl: TSpeedButton;
      btnSelectFileOrUrl_Glyph: TImage;
      Label100: TLabel;
      Label101: TLabel;
      edtVideoSourceFileOrUrl: TEdit;
      VideoSourceFileOrUrl_UserName: TEdit;
      VideoSourceFileOrUrl_Password: TEdit;
      grbVideoSource: TGroupBox;
      cboVideoSource: TComboBox;
      grbPreview: TGroupBox;
      btnStartPreview: TButton;
      btnStopPreview: TButton;
      btnPausePreview: TButton;
      btnResumePreview: TButton;
      grbFrameRate: TGroupBox;
      edtFrameRate: TEdit;
      btnFrameRate: TButton;
      btnAboutFrameRate: TButton;
      chkEnableSnapshotButton: TCheckBox;
      grbVsScreenRecording: TGroupBox;
      Label35: TLabel;
      Label90: TLabel;
      edtScreenRecordingWindow: TEdit;
      btnScreenRecordingWindow: TButton;
      edtMonitorNumber: TEdit;
      btnMonitorNumberInfo: TButton;
      chkScreenRecordingWithCursor: TCheckBox;
      chkretchPreferredVideoSize: TCheckBox;
      tbsIPCameras: TTabItem;
      lblChooseIPCamera: TLabel;
      Label91: TLabel;
      Label92: TLabel;
      Label98: TLabel;
      Label94: TLabel;
      Label95: TLabel;
      Label67: TLabel;
      Label68: TLabel;
      Label69: TLabel;
      Label70: TLabel;
      edtIPCameraURL: TEdit;
      btnIPCamStartPreview: TButton;
      edtIPCamConnectionTimeout: TEdit;
      chkOpenURLAsync: TCheckBox;
      btnIPCameraStop: TButton;
      btnIPCameraStarttMP4Recording: TButton;
      RichEdit1: TMemo;
      edtBacktimedRecordingSeconds: TEdit;
      chkBacktimedRecordingSeconds: TCheckBox;
      edtIPCamUserName: TEdit;
      edtIPCamPassword: TEdit;
      chkUseExternalAudioforRTSP: TCheckBox;
      rdgIRCutFilter_Box: TGroupBox;
      rdgIRCutFilter_Item0: TRadioButton;
      rdgIRCutFilter_Item1: TRadioButton;
      rdgIRCutFilter_Item2: TRadioButton;
      GroupBox9: TGroupBox;
      Label114: TLabel;
      PageControl1: TTabControl;
      TabSheet2: TTabItem;
      Label108: TLabel;
      Label109: TLabel;
      Label99: TLabel;
      Label110: TLabel;
      btnPTZTiltUp: TButton;
      btnPTZPanLeft: TButton;
      btnPTZPanRight: TButton;
      btnPTZTiltDown: TButton;
      btnPTZZoomOut: TButton;
      btnPTZZoomIn: TButton;
      edtPTZDurationMs: TEdit;
      btnPTZHelpDuration: TButton;
      chkPTZMouseUpStop: TCheckBox;
      TabSheet3: TTabItem;
      Label111: TLabel;
      Label112: TLabel;
      Label113: TLabel;
      btnPTZSetTrackbarLimits: TButton;
      tbrPTZPan: TTrackBar;
      tbrPTZZoom: TTrackBar;
      tbrPTZTilt: TTrackBar;
      TabSheet4: TTabItem;
      Label115: TLabel;
      Label117: TLabel;
      Label118: TLabel;
      edtPTZRelativeMove: TEdit;
      btnRelativePanLeft: TButton;
      btnRelativeTiltUp: TButton;
      btnRelativePanRight: TButton;
      btnRelativeTiltDown: TButton;
      btnRelativeZoomOut: TButton;
      btnRelativeZoomIn: TButton;
      PTZStop: TButton;
      tbrPTZSpeedRatio: TTrackBar;
      btnHelpPTZSpeedRatio: TButton;
      btnONVIFReplayRecordingsList: TButton;
      btnIPCamStartPTZ: TButton;
      btnDiscoverONVIFFromMulticast: TButton;
      edtOnvifDiscoveryIPRange_FirstIP: TEdit;
      edtOnvifDiscoveryIPRange_LastIP: TEdit;
      lsbOnvifURLsDiscovered: TListBox;
      btnDiscoverONVIFFromIPRange: TButton;
      edtDiscoveryTimeoutSeconds: TEdit;
      btnCancelDiscovery: TButton;
      tbsAudio: TTabItem;
      grbAudioRendering: TGroupBox;
      Label1: TLabel;
      Label17: TLabel;
      tbrAudioVolume: TTrackBar;
      tbrAudioBalance: TTrackBar;
      chkMuteAudioRendering: TCheckBox;
      cboAudioRenderers: TComboBox;
      btnConfigureVUMeters: TButton;
      pnLeftVUMeter: TRectangle;
      pnRightVUMeter: TRectangle;
      GroupBox2: TGroupBox;
      btnStartAudioRendering: TButton;
      btnStartWAVRecording: TButton;
      btnStartMP3Recording: TButton;
      btnStopAudio: TButton;
      btnStartASFRecording: TButton;
      chkRenderAudioDevice: TCheckBox;
      grbAudioCaptureDevice: TGroupBox;
      Label26: TLabel;
      Label49: TLabel;
      Label36: TLabel;
      cboAudioDevices: TComboBox;
      cboAudioInputs: TComboBox;
      tbrAudioInputLevel: TTrackBar;
      tbrAudioInputBalance: TTrackBar;
      tbsRecording: TTabItem;
      Label6: TLabel;
      Label16: TLabel;
      Label24: TLabel;
      Label65: TLabel;
      Label66: TLabel;
      Label46: TLabel;
      btnRenewRecordingFile: TButton;
      btnStopRecording: TButton;
      btnStartRecordingControlled: TButton;
      btnStartRecordingImmediately: TButton;
      chkAudioRecording: TCheckBox;
      chkPreserveNativeFormat: TCheckBox;
      chkAVISaveToThisFile: TCheckBox;
      edtRecordingFileName: TEdit;
      rdgRecordingMethod_Box: TGroupBox;
      rdgRecordingMethod_Item0: TRadioButton;
      rdgRecordingMethod_Item1: TRadioButton;
      rdgRecordingMethod_Item2: TRadioButton;
      rdgRecordingMethod_Item3: TRadioButton;
      rdgRecordingMethod_Item4: TRadioButton;
      rdgRecordingMethod_Item5: TRadioButton;
      rdgRecordingMethod_Item6: TRadioButton;
      rdgRecordingMethod_Item7: TRadioButton;
      rdgRecordingMethod_Item8: TRadioButton;
      rdgRecordingMethod_Item9: TRadioButton;
      rdgRecordingMethod_Item10: TRadioButton;
      GroupBox5: TGroupBox;
      Label29: TLabel;
      grbRecordingTimer_Box: TGroupBox;
      grbRecordingTimer_Item0: TRadioButton;
      grbRecordingTimer_Item1: TRadioButton;
      grbRecordingTimer_Item2: TRadioButton;
      grbRecordingTimer_Item3: TRadioButton;
      edtRecordingTimerInterval: TEdit;
      chkRecordingCanPause: TCheckBox;
      chkRecordingPauseCreatesNewFile: TCheckBox;
      chkRecordingOnMotion: TCheckBox;
      btnPauseRecording: TButton;
      btnResumeRecording: TButton;
      cboVideoCompressors: TComboBox;
      btnVideoCompressorSettings: TButton;
      cboAudioCompressors: TComboBox;
      btnAudioCompressorSettings: TButton;
      rdgCompressMode_Box: TGroupBox;
      rdgCompressMode_Item0: TRadioButton;
      rdgCompressMode_Item1: TRadioButton;
      rdgCompressMode_Item2: TRadioButton;
      BtnCodecExamples: TButton;
      edtNewFileDuringRecording: TEdit;
      cboAutoFileName: TComboBox;
      edtAVIAutoFilePrefix: TEdit;
      tbsEncryption: TTabItem;
      lblEncryptionKey: TLabel;
      lblDecryptionKey: TLabel;
      grbEncryptionMethod: TGroupBox;
      rdbAESencryption: TRadioButton;
      rdbFastEncryption: TRadioButton;
      edtEncryptionKey: TEdit;
      btnSetEncryptionKey: TButton;
      btnClearEncryption: TButton;
      edtDecryptionKey: TEdit;
      btnSetDecryptionKey: TButton;
      btnClearDecryption: TButton;
      grbEncryptDecryptFiles: TGroupBox;
      spdSourceVideoClip: TSpeedButton;
      spdSourceVideoClip_Glyph: TImage;
      lblEncryptDecryptDestination: TLabel;
      edtEncryptDecryptSourceVideoClip: TEdit;
      edtEncryptDecryptDestinationVideoClip: TEdit;
      chkEncryptDecryptOverwriteDestination: TCheckBox;
      btnEncryptVideoClip: TButton;
      btnDecryptVideoClip: TButton;
      mmoEncryptionHelp: TMemo;
      tbsMPE: TTabItem;
      Label11: TLabel;
      Memo2: TMemo;
      video: TGroupBox;
      Label128: TLabel;
      Label129: TLabel;
      Label130: TLabel;
      Label134: TLabel;
      Label135: TLabel;
      Label137: TLabel;
      Label136: TLabel;
      edtDatasteadEncoder_VideoCodecName: TEdit;
      edtDatasteadEncoder_Video_Bitrate_kb: TEdit;
      GroupBox10: TGroupBox;
      Label131: TLabel;
      Label132: TLabel;
      Label133: TLabel;
      edtDatasteadEncoder_Video_rc_MinBitRate_kb: TEdit;
      edtDatasteadEncoder_Video_rc_MaxBitRate_kb: TEdit;
      edtDatasteadEncoder_Video_rc_BufferSize_kb: TEdit;
      edtDatasteadEncoder_Video_IDRInterval: TEdit;
      edtDatasteadEncoder_Video_MaxBframes: TEdit;
      edtDatasteadEncoder_Video_ThreadCount: TEdit;
      cmbGPUEncoder: TComboBox;
      GroupBox12: TGroupBox;
      Label138: TLabel;
      Label139: TLabel;
      Label38: TLabel;
      Label32: TLabel;
      edtDatasteadEncoder_Audio_SamplesPerSecond: TEdit;
      edtDatasteadEncoder_Audio_BitRate_kb: TEdit;
      edtDatasteadEncoder_AudioCodecName: TEdit;
      mmoExtraParameters: TMemo;
      TabSheet5: TTabItem;
      Label120: TLabel;
      Label10: TLabel;
      chkStreamingVideoEnabled: TCheckBox;
      chkStreamingAudioEnabled: TCheckBox;
      GroupBox3: TGroupBox;
      Label5: TLabel;
      btnMultipurposeUDPStreaming: TButton;
      btnPauseStreaming: TButton;
      btnResumeStreaming: TButton;
      GroupBox7: TGroupBox;
      Label34: TLabel;
      Label39: TLabel;
      Label44: TLabel;
      btnNDIStreamingClientView: TButton;
      edtNDIRemoteHostAndSession: TEdit;
      btnNDISessions: TButton;
      edtNDIReceiveTimeout: TEdit;
      GroupBox11: TGroupBox;
      Label125: TLabel;
      Label127: TLabel;
      edtNDISessionName: TEdit;
      btnNDIStreamingOK: TButton;
      tbsPlayer: TTabItem;
      btnOpenLastClipRecorded: TSpeedButton;
      btnPlayerOpenFile: TSpeedButton;
      btnPlayerOpenFile_Glyph: TImage;
      Label23: TLabel;
      Label8: TLabel;
      Label40: TLabel;
      Label41: TLabel;
      btnPlayerOpenStreamingURL: TSpeedButton;
      btnOpenLastClipPlayed: TSpeedButton;
      Label77: TLabel;
      Label80: TLabel;
      Label89: TLabel;
      edtPlayerFastSeekSpeed: TEdit;
      edtPlayerSpeedRatio: TEdit;
      lay_updPlayerFastSeekSpeed: TLayout;
      updPlayerFastSeekSpeed_Up: TSpeedButton;
      updPlayerFastSeekSpeed_Down: TSpeedButton;
      btnAutoPlay: TCheckBox;
      edtPlayerClip: TEdit;
      chkPlayerAudioRendering: TCheckBox;
      chkRefreshPausedDisplay: TCheckBox;
      btnOpenClip: TButton;
      btnPlayerCloseClip: TButton;
      btnGetClipDuration: TButton;
      btnGeneralInfo: TButton;
      btnHeaderInfo: TButton;
      chkUseClock: TCheckBox;
      grbPlayList: TGroupBox;
      btnAddToPlaylist: TSpeedButton;
      btnAddToPlaylist_Glyph: TImage;
      chkPlaylistLoop: TCheckBox;
      btnPlaylistPlay: TButton;
      btnPlaylistNext: TButton;
      btnPlaylistPrevious: TButton;
      chkPlaylistRandom: TCheckBox;
      btnPlaylistStop: TButton;
      lstPlaylist: TListBox;
      btnClosePlaylist: TButton;
      btnOpenAtFrames: TButton;
      btnOpenAtTimes: TButton;
      edtartFrame: TEdit;
      edtopFrame: TEdit;
      edtartTime: TEdit;
      edtopTime: TEdit;
      chkKeepBounds: TCheckBox;
      chkReopen: TCheckBox;
      chkPlayerLoop: TCheckBox;
      rgdHwAccel_Box: TGroupBox;
      rgdHwAccel_Item0: TRadioButton;
      rgdHwAccel_Item1: TRadioButton;
      rgdHwAccel_Item2: TRadioButton;
      rgdHwAccel_Item3: TRadioButton;
      rgdHwAccel_Item4: TRadioButton;
      chk360VideoDecoding: TCheckBox;
      tbsFrameGrabber: TTabItem;
      Label42: TLabel;
      Label43: TLabel;
      Label72: TLabel;
      Label73: TLabel;
      rgdFrameGrabberFormat_Box: TGroupBox;
      rgdFrameGrabberFormat_Item0: TRadioButton;
      rgdFrameGrabberFormat_Item1: TRadioButton;
      rgdFrameGrabberFormat_Item2: TRadioButton;
      rgdFrameGrabberFormat_Item3: TRadioButton;
      rgdFrameGrabberFormat_Item4: TRadioButton;
      rgdFrameGrabberFormat_Item5: TRadioButton;
      rgdFrameGrabberFormat_Item6: TRadioButton;
      rgdFrameGrabberFormat_Item7: TRadioButton;
      rgdFrameGrabber_Box: TGroupBox;
      rgdFrameGrabber_Item0: TRadioButton;
      rgdFrameGrabber_Item1: TRadioButton;
      rgdFrameGrabber_Item2: TRadioButton;
      rgdFrameGrabber_Item3: TRadioButton;
      grbOneShot: TGroupBox;
      edtUseThisFileName: TEdit;
      btnOneShotTBitmap: TButton;
      btnOneShotBMPFile: TButton;
      btnOneShotJPEGFile: TButton;
      chkUseThisFileName: TCheckBox;
      btnOneShotClipboard: TButton;
      btnOneShotPngFile: TButton;
      BtnOneShotTiffFile: TButton;
      grbBurstMode: TGroupBox;
      Label14: TLabel;
      Label15: TLabel;
      btnBurstModeBMPFile: TButton;
      btnBurstModeJPEGFile: TButton;
      edtBurstCount: TEdit;
      edtBurstInterval: TEdit;
      btnBurstModeStop: TButton;
      btnBurstModeTBitmap: TButton;
      btnBurstModeClipboard: TButton;
      chkModulo: TCheckBox;
      btnBurstModePNGFile: TButton;
      btnBurstModeTIFFFile: TButton;
      grbZoomSize: TGroupBox;
      Label12: TLabel;
      tbrCaptureZoomSize: TTrackBar;
      edtCaptureZoomSize: TEdit;
      btnResetCaptureZoomSize: TButton;
      mmoFrameCaptureLog: TMemo;
      edtFrameCaptureWidth: TEdit;
      edtFrameCaptureHeight: TEdit;
      TabSheet1: TTabItem;
      Label53: TLabel;
      lblMotionDetectorRequiresFrameGrabber: TLabel;
      Label54: TLabel;
      imgMotionDetected: TImage;
      mmoSensitivityGrid: TMemo;
      mmoMotionGrid: TMemo;
      chkMotionDetectionEnabled: TCheckBox;
      chkReduceVideoNoise: TCheckBox;
      btnShowGridDialog: TButton;
      chkCompareRed: TCheckBox;
      chkCompareGreen: TCheckBox;
      chkCompareBlue: TCheckBox;
      chk_GreyScale: TCheckBox;
      grbMotionRatio: TGroupBox;
      shpMotionDetected: TEllipse;
      edtMotionRatio: TEdit;
      grbXYMaxMotion: TGroupBox;
      edtMaxMotionXY: TEdit;
      edtMaxMotionCoord: TEdit;
      grbCellsSensitivity: TGroupBox;
      Label57: TLabel;
      Label58: TLabel;
      Label59: TLabel;
      edtXCell: TEdit;
      lay_updXCell: TLayout;
      updXCell_Up: TSpeedButton;
      updXCell_Down: TSpeedButton;
      edtYCell: TEdit;
      lay_updYCell: TLayout;
      updYCell_Up: TSpeedButton;
      updYCell_Down: TSpeedButton;
      edtCellSensitivity: TEdit;
      lay_updCellSensitivity: TLayout;
      updCellSensitivity_Up: TSpeedButton;
      updCellSensitivity_Down: TSpeedButton;
      btnSetCellsSensitivity: TButton;
      grbGridSize: TGroupBox;
      Label55: TLabel;
      Label56: TLabel;
      edtGridColCount: TEdit;
      lay_updGridColCount: TLayout;
      updGridColCount_Up: TSpeedButton;
      updGridColCount_Down: TSpeedButton;
      edtGridRowCount: TEdit;
      lay_updGridRowCount: TLayout;
      updGridRowCount_Up: TSpeedButton;
      updGridRowCount_Down: TSpeedButton;
      btnApplyGridSize: TButton;
      grbGridString: TGroupBox;
      Label51: TLabel;
      lblGridValid: TLabel;
      shpGridValid: TRoundRect;
      edtGrid: TEdit;
      lay_updGlobalGridSensitivity: TLayout;
      updGlobalGridSensitivity_Up: TSpeedButton;
      updGlobalGridSensitivity_Down: TSpeedButton;
      chkTriggered: TCheckBox;
      btnTriggerNow: TButton;
      tbsFrameOverlay: TTabItem;
      lblFrameOverlayRequiresFrameGrabber: TLabel;
      btnPIPFromAnotherTVideoGrabber: TSpeedButton;
      btnPIPFromAnotherTVideoGrabber_Glyph: TImage;
      grbFreeHand: TGroupBox;
      Label27: TLabel;
      chkFreeHandEnabled: TCheckBox;
      btnFreeHandErase: TButton;
      chkChangePixels: TCheckBox;
      chkDrawGridOverFrames: TCheckBox;
      chkDrawTarget: TCheckBox;
      grbTextOverlay: TGroupBox;
      Label13: TLabel;
      Label20: TLabel;
      Label22: TLabel;
      Label33: TLabel;
      Label37: TLabel;
      Label3: TLabel;
      Label106: TLabel;
      rdgTextOverlayAlign_Box: TGroupBox;
      rdgTextOverlayAlign_Item0: TRadioButton;
      rdgTextOverlayAlign_Item1: TRadioButton;
      rdgTextOverlayAlign_Item2: TRadioButton;
      chkTextOverlayEnabled: TCheckBox;
      chkTextOverlayTransparent: TCheckBox;
      mmoTextOverlayString: TMemo;
      edtTextOverlayTop: TEdit;
      edtTextOverlayLeft: TEdit;
      edtTextOverlayRight: TEdit;
      chkTextOverlayShadow: TCheckBox;
      lay_updTextOverlaySize: TLayout;
      updTextOverlaySize_Up: TSpeedButton;
      updTextOverlaySize_Down: TSpeedButton;
      rdgTextOverlaySelector_Box: TGroupBox;
      rdgTextOverlaySelector_Item0: TRadioButton;
      rdgTextOverlaySelector_Item1: TRadioButton;
      rdgTextOverlaySelector_Item2: TRadioButton;
      rdgTextOverlaySelector_Item3: TRadioButton;
      rdgTextOverlaySelector_Item4: TRadioButton;
      rdgTextOverlaySelector_Item5: TRadioButton;
      rdgTextOverlaySelector_Item6: TRadioButton;
      rdgTextOverlaySelector_Item7: TRadioButton;
      rdgTextOverlaySelector_Item8: TRadioButton;
      rdgTextOverlaySelector_Item9: TRadioButton;
      btnTextOverlayColor: TButton;
      btnBkgndColor: TButton;
      chkTextOverlayHighResFont: TCheckBox;
      edtTextOverlayTargetDisplay: TEdit;
      btnTargetDisplayInfo: TButton;
      chkTextOverlayScrolling: TCheckBox;
      edtTextOverlayScrollingSpeed: TEdit;
      chkOverlayOrientation_Box: TGroupBox;
      chkOverlayOrientation_Item0: TRadioButton;
      chkOverlayOrientation_Item1: TRadioButton;
      chkOverlayOrientation_Item2: TRadioButton;
      chkTextOverlayAlphablend: TCheckBox;
      tbrTextOverlayAlphablendValue: TTrackBar;
      chkTextOverlayProportional: TCheckBox;
      chkAdjustOverlayAspectRatio: TCheckBox;
      grbBitmapOverlay: TGroupBox;
      Label48: TLabel;
      btnLoadImageOverlayFromFile: TSpeedButton;
      btnLoadImageOverlayFromFile_Glyph: TImage;
      Label25: TLabel;
      Label82: TLabel;
      Label96: TLabel;
      Label47: TLabel;
      Label102: TLabel;
      Label103: TLabel;
      Label97: TLabel;
      edtImageOverlayTransparentColorValue: TEdit;
      rdgImageOverlaySelector_Box: TGroupBox;
      rdgImageOverlaySelector_Item0: TRadioButton;
      rdgImageOverlaySelector_Item1: TRadioButton;
      rdgImageOverlaySelector_Item2: TRadioButton;
      rdgImageOverlaySelector_Item3: TRadioButton;
      rdgImageOverlaySelector_Item4: TRadioButton;
      rdgImageOverlaySelector_Item5: TRadioButton;
      rdgImageOverlaySelector_Item6: TRadioButton;
      rdgImageOverlaySelector_Item7: TRadioButton;
      rdgImageOverlaySelector_Item8: TRadioButton;
      rdgImageOverlaySelector_Item9: TRadioButton;
      edtChromaKeyLeewayPercent: TTrackBar;
      chkImageOverlayEnabled: TCheckBox;
      edtImageOverlayLeft: TEdit;
      edtImageOverlayTop: TEdit;
      chkImageOverlayTransparent: TCheckBox;
      chkImageOverlayUseTransparentColor: TCheckBox;
      btnImageOverlayPickupColor: TButton;
      btnImageOverlayPickupHelp: TButton;
      edtImageOverlayWidth: TEdit;
      edtImageOverlayHeight: TEdit;
      chkImageOverlayAlphaBlend: TCheckBox;
      chkImageOverlayAlphablendCoeff: TTrackBar;
      chkImageOverlayChromaKey: TCheckBox;
      edtChromaKeyColorValue: TEdit;
      edtImageOverlayTargetDisplay: TEdit;
      btnImageOverlayInfo: TButton;
      btnPIPStop: TButton;
      tbsVideoProcessing: TTabItem;
      grbCropping: TGroupBox;
      Label85: TLabel;
      Label86: TLabel;
      Label87: TLabel;
      Label84: TLabel;
      Label88: TLabel;
      chkCroppingEnabled: TCheckBox;
      trkCroppingX: TTrackBar;
      trkCroppingY: TTrackBar;
      edtCroppingWidth: TEdit;
      edtCroppingHeight: TEdit;
      trkCroppingZoom: TTrackBar;
      chkCroppingOutbounds: TCheckBox;
      btnCroppingZoomReset: TButton;
      grbVMR9Adjust: TGroupBox;
      Label7: TLabel;
      Label21: TLabel;
      tbrVMR9Brightness: TTrackBar;
      tbrVMR9Contrast: TTrackBar;
      tbrVMR9Saturation: TTrackBar;
      tbrVMR9Hue: TTrackBar;
      vmr9FixRange: TCheckBox;
      grbSoftwareVideoProcessing: TGroupBox;
      Label31: TLabel;
      Label50: TLabel;
      Label60: TLabel;
      rdgVideoRotation_Box: TGroupBox;
      rdgVideoRotation_Item0: TRadioButton;
      rdgVideoRotation_Item1: TRadioButton;
      rdgVideoRotation_Item2: TRadioButton;
      rdgVideoRotation_Item3: TRadioButton;
      rdgVideoRotation_Item4: TRadioButton;
      rdgVideoRotation_Item5: TRadioButton;
      rdgVideoRotation_Item6: TRadioButton;
      rdgVideoRotation_Item7: TRadioButton;
      rdgVideoRotation_Item8: TRadioButton;
      rdgVideoRotation_Item9: TRadioButton;
      rdgDeinterlacing_Box: TGroupBox;
      rdgDeinterlacing_Item0: TRadioButton;
      rdgDeinterlacing_Item1: TRadioButton;
      rdgDeinterlacing_Item2: TRadioButton;
      rdgDeinterlacing_Item3: TRadioButton;
      rdgDeinterlacing_Item4: TRadioButton;
      rdgDeinterlacing_Item5: TRadioButton;
      chkFlipVertical: TCheckBox;
      chkFlipHorizontal: TCheckBox;
      chkGreyScale: TCheckBox;
      chkInvertColors: TCheckBox;
      btnResetAll: TButton;
      tbrBrightness: TTrackBar;
      tbrConstrast: TTrackBar;
      tbrSaturation: TTrackBar;
      tbrHue: TTrackBar;
      edtPixellization: TEdit;
      lay_updPixellization: TLayout;
      updPixellization_Up: TSpeedButton;
      updPixellization_Down: TSpeedButton;
      edtCustomRotationAngle: TEdit;
      rdgDetectVideoSignal_Box: TGroupBox;
      rdgDetectVideoSignal_Item0: TRadioButton;
      rdgDetectVideoSignal_Item1: TRadioButton;
      rdgDetectVideoSignal_Item2: TRadioButton;
      tbsDisplay: TTabItem;
      imgLogo: TImage;
      Label76: TLabel;
      rdgVideoRenderer_Box: TGroupBox;
      rdgVideoRenderer_Item0: TRadioButton;
      rdgVideoRenderer_Item1: TRadioButton;
      rdgVideoRenderer_Item2: TRadioButton;
      rdgVideoRenderer_Item3: TRadioButton;
      rdgVideoRenderer_Item4: TRadioButton;
      rdgVideoRenderer_Item5: TRadioButton;
      rdgVideoRenderer_Item6: TRadioButton;
      rdgVideoRenderer_Item7: TRadioButton;
      rdgVideoRenderer_Item8: TRadioButton;
      chkVideoVisibleWhenStopped: TCheckBox;
      chkChangeCursor: TCheckBox;
      chkBorder: TCheckBox;
      chkTransparency: TCheckBox;
      chkSetLogo: TCheckBox;
      chkAdjustPixelAspectRatio: TCheckBox;
      chkBlackMagicDecklink: TCheckBox;
      chkZeroLatency: TCheckBox;
      chk1stVideoWindowActive: TCheckBox;
      chk2ndVideoWindowActive: TCheckBox;
      grbMainVideoWindow: TGroupBox;
      Label74: TLabel;
      chk1stEmbedded: TCheckBox;
      chk1stFullScreen: TCheckBox;
      chk1stStayOnTop: TCheckBox;
      rdg1stDisplayedOn_Box: TGroupBox;
      rdg1stDisplayedOn_Item0: TRadioButton;
      rdg1stDisplayedOn_Item1: TRadioButton;
      chk1stMouseMovesWindow: TCheckBox;
      chk1stAutoSize: TCheckBox;
      btnEG1stNewLocation2: TButton;
      rdg1AspectRatio_Box: TGroupBox;
      rdg1AspectRatio_Item0: TRadioButton;
      rdg1AspectRatio_Item1: TRadioButton;
      rdg1AspectRatio_Item2: TRadioButton;
      rdg1AspectRatio_Item3: TRadioButton;
      chk1stVisible: TCheckBox;
      tbr1PanScan: TTrackBar;
      btnTestPanScan: TButton;
      chk1stAlphablend: TCheckBox;
      chk1stTranspColor: TCheckBox;
      tbr1stAlphablend: TTrackBar;
      edt1sttranspColor: TEdit;
      grb2ndVideoWindow: TGroupBox;
      Label45: TLabel;
      chk2ndEmbedded: TCheckBox;
      chk2ndFullScreen: TCheckBox;
      chk2ndStayOnTop: TCheckBox;
      rdg2ndDisplayedOn_Box: TGroupBox;
      rdg2ndDisplayedOn_Item0: TRadioButton;
      rdg2ndDisplayedOn_Item1: TRadioButton;
      chk2ndMouseMovesWindow: TCheckBox;
      chk2ndAutoSize: TCheckBox;
      btnEG2ndNewLocation2: TButton;
      chk2ndVisible: TCheckBox;
      rdg2AspectRatio_Box: TGroupBox;
      rdg2AspectRatio_Item0: TRadioButton;
      rdg2AspectRatio_Item1: TRadioButton;
      rdg2AspectRatio_Item2: TRadioButton;
      rdg2AspectRatio_Item3: TRadioButton;
      tbr2PanScan: TTrackBar;
      chk2ndAlphaBlend: TCheckBox;
      chk2ndTranspColor: TCheckBox;
      edt2ndTranspColor: TEdit;
      tbr2ndAlphaBlend: TTrackBar;
      tbrZoomY: TTrackBar;
      tbrZoomX: TTrackBar;
      tbrZoom: TTrackBar;
      edtIPCameraNTPTime: TEdit;
      MainMenu1: TMainMenu;
      mnuFile: TMenuItem;
      mnuExit: TMenuItem;
      Options1: TMenuItem;
      Resetvideocapturedevicesettings1: TMenuItem;
      mnuAbout: TMenuItem;
      procedure btnAudioCompressorSettingsClick(Sender: TObject);
      procedure btnAutoPlayClick(Sender: TObject);
      procedure btnAutoRefreshPreviewClick(Sender: TObject);
      procedure btnBurstModeBMPFileClick(Sender: TObject);
      procedure btnBurstModeJPEGFileClick(Sender: TObject);
		procedure btnBurstModeStopClick(Sender: TObject);
      procedure btnBurstModeTBitmapClick(Sender: TObject);
      procedure btnCameraControlDialogClick(Sender: TObject);
      procedure btnDeviceDialogClick(Sender: TObject);
      procedure btnFrameRateClick(Sender: TObject);
      procedure btnFreeHandEraseClick(Sender: TObject);
      procedure btnOneShotBMPFileClick(Sender: TObject);
      procedure btnOneShotJPEGFileClick(Sender: TObject);
      procedure btnOneShotTBitmapClick(Sender: TObject);
      procedure btnPauseRecordingClick(Sender: TObject);
      procedure btnPlayerBackwardsClick(Sender: TObject);
      procedure btnPlayerCloseClipClick(Sender: TObject);
      procedure btnPlayerFastForwardClick(Sender: TObject);
      procedure btnOpenLastClipRecordedClick(Sender: TObject);
      procedure btnPlayerOpenFileClick(Sender: TObject);
      procedure btnPlayerPauseClick(Sender: TObject);
      procedure btnPlayerRewindClick(Sender: TObject);
      procedure btnPlayerStartPlayingClick(Sender: TObject);
      procedure btnPlayerStopClick(Sender: TObject);
      procedure btnResetAllClick(Sender: TObject);
      procedure btnResetCaptureZoomSizeClick(Sender: TObject);
      procedure btnResumeRecordingClick(Sender: TObject);
      procedure btnStartRecordingImmediatelyClick(Sender: TObject);
      procedure btnStartPreviewClick(Sender: TObject);
      procedure btnStopRecordingClick(Sender: TObject);
      procedure btnStopPreviewClick(Sender: TObject);
      procedure btnVideoCompressorSettingsClick(Sender: TObject);
      procedure btnVideoQualityDialogClick(Sender: TObject);
      procedure cboAnalogVideoStandardChange(Sender: TObject);
      procedure cboAudioCompressorsChange(Sender: TObject);
      procedure cboAudioDevicesChange(Sender: TObject);
      procedure cboAudioInputsChange(Sender: TObject);
      procedure cboVideoCompressorsChange(Sender: TObject);
      procedure cboVideoDevicesChange(Sender: TObject);
      procedure cboVideoInputsChange(Sender: TObject);
      procedure cboVideoSizesChange(Sender: TObject);
      procedure cboVideoSubtypesChange(Sender: TObject);
      procedure chkRecordingCanPauseClick(Sender: TObject);
      procedure chkBorderClick(Sender: TObject);
      procedure chkFlipHorizontalClick(Sender: TObject);
      procedure chkFlipVerticalClick(Sender: TObject);
      procedure chkGreyScaleClick(Sender: TObject);
      procedure chkInvertColorsClick(Sender: TObject);
      procedure chkPlayerAudioRenderingClick(Sender: TObject);
      procedure chkRenderAudioDeviceClick(Sender: TObject);
      procedure chkTextOverlayEnabledClick(Sender: TObject);
      procedure chkTextOverlayTransparentClick(Sender: TObject);
      procedure chkTransparencyClick(Sender: TObject);
      procedure chkUseThisFileNameClick(Sender: TObject);
      procedure edtAVIAutoFilePrefixChange(Sender: TObject);
      procedure edtBurstCountChange(Sender: TObject);
      procedure edtBurstIntervalChange(Sender: TObject);
      procedure edtStoragePathChange(Sender: TObject);
      procedure edtTextOverlayLeftChange(Sender: TObject);
      procedure edtTextOverlayTopChange(Sender: TObject);
      procedure edtTextOverlayRightChange(Sender: TObject);
      procedure FormCreate(Sender: TObject);
      procedure mmoTextOverlayStringChange(Sender: TObject);
      procedure mnuAboutClick(Sender: TObject);
      procedure mnuExitClick(Sender: TObject);
      procedure rdgCompressModeClick(Sender: TObject);
      procedure rdgTextOverlayAlignClick(Sender: TObject);
      procedure rdgVideoRendererClick(Sender: TObject);
      procedure rgdFrameGrabberClick(Sender: TObject);
      procedure rgdFrameGrabberFormatClick(Sender: TObject);
		procedure tbrAudioBalanceChange(Sender: TObject);
      procedure tbrBrightnessChange(Sender: TObject);
		procedure tbrCaptureZoomSizeChange(Sender: TObject);
      procedure tbrConstrastChange(Sender: TObject);
      procedure tbrHueChange(Sender: TObject);
      procedure tbrSaturationChange(Sender: TObject);
      procedure updPlayerFastSeekSpeedClick(Sender: TObject;
        Button: TUDBtnType);
      procedure VideoGrabberDeviceArrivalOrRemoval(Sender: TObject;
        IsDeviceArrival, IsVideoDevice: Boolean; DeviceName: String;
        DeviceIndex: Integer);
      procedure VideoGrabberDeviceLost(Sender: TObject);
      procedure VideoGrabberDiskFull(Sender: TObject);
      procedure VideoGrabberPlayerEndOfStream(Sender: TObject);
      procedure VideoGrabberPreviewStarted(Sender: TObject);
      procedure VideoGrabberResizeVideo(Sender: TObject;
        SourceWidth, SourceHeight: Integer);
      procedure tbrAudioInputLevelChange(Sender: TObject);
      procedure VideoGrabberDVCommandCompleted(Sender: TObject;
        NewStateValue: Integer; NewStateLabel: String);
      procedure rdgVideoRotationClick(Sender: TObject);
      procedure rdgDeinterlacingClick(Sender: TObject);
      procedure rdgRecordingMethodClick(Sender: TObject);
      procedure chkCompareRedClick(Sender: TObject);
      procedure chkCompareGreenClick(Sender: TObject);
      procedure chkCompareBlueClick(Sender: TObject);
      procedure chk_GreyScaleClick(Sender: TObject);
      procedure chkReduceVideoNoiseClick(Sender: TObject);
      procedure edtGridChange(Sender: TObject);
      procedure updGlobalGridSensitivityClick(Sender: TObject;
        Button: TUDBtnType);
      procedure btnApplyGridSizeClick(Sender: TObject);
      procedure btnSetCellsSensitivityClick(Sender: TObject);
      procedure btnShowGridDialogClick(Sender: TObject);
      procedure chkMotionDetectionEnabledClick(Sender: TObject);
      procedure VideoGrabberPlayerBufferingData(Sender: TObject;
        StartingToBuffer: Boolean);
      procedure VideoGrabberAudioDeviceSelected(Sender: TObject);
      procedure VideoGrabberLog(Sender: TObject; LogType: TLogType;
        Severity, InfoMsg: String);
      procedure VideoGrabberVideoDeviceSelected(Sender: TObject);
      procedure tbrAudioInputBalanceChange(Sender: TObject);
      procedure VideoGrabberReinitializing(Sender: TObject);
      procedure VideoGrabberRecordingCompleted(Sender: TObject;
        FileName: String; Success: Boolean);
      procedure VideoGrabberRecordingStarted(Sender: TObject; FileName: String);
      procedure VideoGrabberReencodingStarted(Sender: TObject;
        SourceFile, DestFile: String);
      procedure VideoGrabberReencodingCompleted(Sender: TObject;
        SourceFile, DestFile: String; Success: Boolean);
      procedure btnViewDirectNetworkStreamingClick(Sender: TObject);
      procedure VideoGrabberInactive(Sender: TObject);
      procedure VideoGrabberRecordingReadyToStart(Sender: TObject);
      procedure btnStartRecordingControlledClick(Sender: TObject);
      procedure chkRefreshPausedDisplayClick(Sender: TObject);
      procedure VideoGrabberPlayerOpened(Sender: TObject);
      procedure chkPreserveNativeFormatClick(Sender: TObject);
      procedure chkSetLogoClick(Sender: TObject);
      procedure btnOpenLastClipPlayedClick(Sender: TObject);
      procedure cboVideoSourceChange(Sender: TObject);
      procedure chkScreenRecordingWithCursorClick(Sender: TObject);
      procedure chkCroppingEnabledClick(Sender: TObject);
      procedure chkCroppingOutboundsClick(Sender: TObject);
      procedure edtCroppingWidthChange(Sender: TObject);
      procedure edtCroppingHeightChange(Sender: TObject);
      procedure trkCroppingZoomChange(Sender: TObject);
      procedure btnCroppingZoomResetClick(Sender: TObject);
      procedure trkCroppingYChange(Sender: TObject);
      procedure trkCroppingXChange(Sender: TObject);
      procedure tbrVMR9BrightnessChange(Sender: TObject);
      procedure tbrVMR9ContrastChange(Sender: TObject);
      procedure tbrVMR9SaturationChange(Sender: TObject);
      procedure tbrVMR9HueChange(Sender: TObject);
      procedure VideoGrabberGraphBuilt(Sender: TObject);
      procedure vmr9FixRangeClick(Sender: TObject);
      procedure chkChangeCursorClick(Sender: TObject);
      procedure btnSelectFileOrUrlClick(Sender: TObject);
      procedure edtVideoSourceFileOrUrlChange(Sender: TObject);
      procedure FormDestroy(Sender: TObject);
      procedure chkAudioRecordingClick(Sender: TObject);
      procedure tbrAudioVolumeChange(Sender: TObject);
      procedure chkMuteAudioRenderingClick(Sender: TObject);
      procedure btnRenewRecordingFileClick(Sender: TObject);
      procedure btnLoadImageOverlayFromFileClick(Sender: TObject);
      procedure btnOpenClipClick(Sender: TObject);
      procedure btnGetClipDurationClick(Sender: TObject);
      procedure chkTriggeredClick(Sender: TObject);
      procedure btnTriggerNowClick(Sender: TObject);
      procedure chkRecordingPauseCreatesNewFileClick(Sender: TObject);
      procedure btnGeneralInfoClick(Sender: TObject);
      procedure btnHeaderInfoClick(Sender: TObject);
      procedure btnConfigureVUMetersClick(Sender: TObject);
      procedure VUMeterConfigFormClose(Sender: TObject; var Action: TCloseAction);
      procedure chkTextOverlayShadowClick(Sender: TObject);
      procedure updTextOverlaySizeClick(Sender: TObject; Button: TUDBtnType);
      procedure btnAboutFrameRateClick(Sender: TObject);
      procedure btnStartAudioRenderingClick(Sender: TObject);
      procedure btnStartMP3RecordingClick(Sender: TObject);
      procedure btnStartWAVRecordingClick(Sender: TObject);
      procedure btnStopAudioClick(Sender: TObject);
      procedure btnStartASFRecordingClick(Sender: TObject);
      procedure chkRecordingOnMotionClick(Sender: TObject);
      procedure chkUseClockClick(Sender: TObject);
      procedure btnScreenRecordingWindowClick(Sender: TObject);
      procedure chkVideoVisibleWhenStoppedClick(Sender: TObject);
      procedure btnAddToPlaylistClick(Sender: TObject);
      procedure btnPlaylistPlayClick(Sender: TObject);
      procedure btnPlaylistNextClick(Sender: TObject);
      procedure btnPlaylistPreviousClick(Sender: TObject);
      procedure btnPlaylistStopClick(Sender: TObject);
      procedure chkPlaylistLoopClick(Sender: TObject);
      procedure chkPlaylistRandomClick(Sender: TObject);
      procedure VideoGrabberPlayerEndOfPlaylist(Sender: TObject);
      procedure lstPlaylistClick(const Sender: TCustomListBox; const Item: TListBoxItem);
      procedure btnClosePlaylistClick(Sender: TObject);
      procedure VideoGrabberDVDiscontinuity(Sender: TObject;
        var DeliverNewFrame: Boolean);
      procedure btnOneShotClipboardClick(Sender: TObject);
      procedure btnBurstModeClipboardClick(Sender: TObject);
      procedure cboAudioRenderersChange(Sender: TObject);
      procedure VideoGrabberClientConnection(Sender: TObject;
        Connected: Boolean; ClientInfo: String);
      procedure updPixellizationClick(Sender: TObject; Button: TUDBtnType);
      procedure rdgTextOverlaySelectorClick(Sender: TObject);
      procedure btnTextOverlayColorClick(Sender: TObject);
      procedure btnBkgndColorClick(Sender: TObject);
      procedure edtCustomRotationAngleChange(Sender: TObject);
      procedure edtFrameCaptureWidthChange(Sender: TObject);
      procedure edtFrameCaptureHeightChange(Sender: TObject);
      procedure btnOpenAtFramesClick(Sender: TObject);
      procedure btnOpenAtTimesClick(Sender: TObject);
      procedure edtMonitorNumberChange(Sender: TObject);
      procedure btnMonitorNumberInfoClick(Sender: TObject);
      procedure tbsIPCamerasShow(Sender: TObject);
      procedure btnIPCamStartPreviewClick(Sender: TObject);
      procedure edtIPCamConnectionTimeoutChange(Sender: TObject);
      procedure btnCurrentIPCameraURLClick(Sender: TObject);
      procedure btnUrlConfClick(Sender: TObject);
      procedure chkImageOverlayEnabledClick(Sender: TObject);
      procedure rdgImageOverlaySelectorClick(Sender: TObject);
      procedure chkImageOverlayTransparentClick(Sender: TObject);
      procedure chkImageOverlayUseTransparentColorClick(Sender: TObject);
      procedure chkImageOverlayAlphaBlendClick(Sender: TObject);
      procedure updImageAlphaBendClick(Sender: TObject; Button: TUDBtnType);
      procedure edtImageOverlayTransparentColorValueChange(Sender: TObject);
      procedure edtImageOverlayLeftChange(Sender: TObject);
      procedure edtImageOverlayTopChange(Sender: TObject);
      procedure edtImageOverlayWidthChange(Sender: TObject);
      procedure edtImageOverlayHeightChange(Sender: TObject);
      procedure btnImageOverlayPickupColorClick(Sender: TObject);
      procedure btnImageOverlayPickupHelpClick(Sender: TObject);
      procedure VideoSourceFileOrUrl_UserNameChange(Sender: TObject);
      procedure VideoSourceFileOrUrl_PasswordChange(Sender: TObject);
      procedure edtIPCamUserNameChange(Sender: TObject);
      procedure edtIPCamPasswordChange(Sender: TObject);
      procedure chkAdjustPixelAspectRatioClick(Sender: TObject);
      procedure edtChromaKeyColorValueChange(Sender: TObject);
      procedure edtChromaKeyLeewayPercentChange(Sender: TObject);
      procedure chkImageOverlayChromaKeyClick(Sender: TObject);
      procedure chkImageOverlayAlphablendCoeffChange(Sender: TObject);
      procedure chkPlayerLoopClick(Sender: TObject);
      procedure chkFreeHandEnabledClick(Sender: TObject);
      procedure chkDrawGridOverFramesClick(Sender: TObject);
      procedure VideoGrabberVideoFromBitmapsNextFrameNeeded(Sender: TObject;
        FirstSample: Boolean);
      procedure chkAVISaveToThisFileClick(Sender: TObject);
      procedure edtRecordingFileNameChange(Sender: TObject);
      procedure edtRecordingTimerIntervalChange(Sender: TObject);
      procedure grbRecordingTimerClick(Sender: TObject);
      procedure cboVideoFormatsChange(Sender: TObject);
      procedure mmoLogKeyUp(Sender: TObject; var Key: Word; var KeyChar: WideChar; Shift: TShiftState);
      procedure edtTextOverlayScrollingSpeedChange(Sender: TObject);
      procedure chkChangePixelsClick(Sender: TObject);
      procedure chkPlayerTrackbarSynchroneClick(Sender: TObject);
      procedure tbrPlayerProgressChange(Sender: TObject);
      procedure tbrZoomChange(Sender: TObject);
      procedure tbrZoomYChange(Sender: TObject);
      procedure tbrZoomXChange(Sender: TObject);
      procedure VideoGrabberFrameProgress2(Sender: TObject;
        FrameInfo: pFrameInfo);
      procedure VideoGrabberFrameBitmap(Sender: TObject; FrameInfo: pFrameInfo;
        BitmapInfo: pFrameBitmapInfo);
      procedure btnPausePreviewClick(Sender: TObject);
      procedure btnResumePreviewClick(Sender: TObject);
      procedure btnPlayerFrameStepClick(Sender: TObject);
      procedure btnPIPFromAnotherTVideoGrabberClick(Sender: TObject);
      procedure VideoGrabberRecordingPaused(Sender: TObject);
      procedure Resetvideocapturedevicesettings1Click(Sender: TObject);
      procedure edtPlayerSpeedRatioChange(Sender: TObject);
      procedure chkAdjustOverlayAspectRatioClick(Sender: TObject);
      procedure chkTextOverlayScrollingClick(Sender: TObject);
      procedure chkBlackMagicDecklinkClick(Sender: TObject);
      procedure chkEnableSnapshotButtonClick(Sender: TObject);
      procedure chkTextOverlayHighResFontClick(Sender: TObject);
      procedure edtTextOverlayTargetDisplayChange(Sender: TObject);
      procedure btnTargetDisplayInfoClick(Sender: TObject);
      procedure edtImageOverlayTargetDisplayChange(Sender: TObject);
      procedure chkOpenURLAsyncClick(Sender: TObject);
      procedure chkModuloClick(Sender: TObject);
      procedure chkOverlayOrientationClick(Sender: TObject);
      procedure chkZeroLatencyClick(Sender: TObject);
      procedure btnBargraphOverlayClick(Sender: TObject);
      procedure chkTextOverlayAlphablendClick(Sender: TObject);
      procedure tbrTextOverlayAlphablendValueChange(Sender: TObject);
      procedure chkTextOverlayProportionalClick(Sender: TObject);
      procedure btnIPCameraStarttMP4RecordingClick(Sender: TObject);
      procedure btnIPCameraStopClick(Sender: TObject);
      procedure edtIPCameraURLChange(Sender: TObject);
      procedure btnPIPStopClick(Sender: TObject);
      procedure tbrPTZSpeedRatioChange(Sender: TObject);
      procedure btnPTZHelpDurationClick(Sender: TObject);
      procedure btnHelpPTZSpeedRatioClick(Sender: TObject);
      procedure PTZStopClick(Sender: TObject);
      procedure PTZButtonsMouseUp(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Single);
      procedure edtPTZDurationMsChange(Sender: TObject);
      procedure btnPTZTiltUpMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Single);
      procedure btnPTZPanLeftMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Single);
      procedure btnPTZPanRightMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Single);
      procedure btnPTZTiltDownMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Single);
      procedure btnPTZZoomOutMouseDown(Sender: TObject; Button: TMouseButton;
        Shift: TShiftState; X, Y: Single);
      procedure btnPTZZoomInClick(Sender: TObject);
      procedure tbrPTZPanChange(Sender: TObject);
      procedure tbrPTZZoomChange(Sender: TObject);
      procedure tbrPTZTiltChange(Sender: TObject);
      procedure btnPTZSetTrackbarLimitsClick(Sender: TObject);
      procedure edtPTZRelativeMoveChange(Sender: TObject);
      procedure btnRelativeTiltUpClick(Sender: TObject);
      procedure btnRelativePanLeftClick(Sender: TObject);
      procedure btnRelativePanRightClick(Sender: TObject);
      procedure btnRelativeTiltDownClick(Sender: TObject);
      procedure btnRelativeZoomOutClick(Sender: TObject);
      procedure btnRelativeZoomInClick(Sender: TObject);
      procedure rgdHwAccelClick(Sender: TObject);
      procedure rdgIRCutFilterClick(Sender: TObject);
      procedure btnOneShotPngFileClick(Sender: TObject);
      procedure BtnOneShotTiffFileClick(Sender: TObject);
      procedure btnBurstModePNGFileClick(Sender: TObject);
      procedure btnBurstModeTIFFFileClick(Sender: TObject);
      procedure btnNDIStreamingOKClick(Sender: TObject);
      procedure btnViewNDIStreamingHelpClick(Sender: TObject);
      procedure btnNDIStreamingClientViewClick(Sender: TObject);
      procedure btnNDIClientHelpClick(Sender: TObject);
      procedure chk360VideoDecodingClick(Sender: TObject);
      procedure edtDatasteadEncoder_Video_Bitrate_kbChange(Sender: TObject);
      procedure edtDatasteadEncoder_Video_rc_MinBitRate_kbChange
        (Sender: TObject);
      procedure edtDatasteadEncoder_Video_rc_MaxBitRate_kbChange
        (Sender: TObject);
      procedure edtDatasteadEncoder_Video_rc_BufferSize_kbChange
        (Sender: TObject);
      procedure edtDatasteadEncoder_Video_IDRIntervalChange(Sender: TObject);
      procedure edtDatasteadEncoder_Video_MaxBframesChange(Sender: TObject);
      procedure edtDatasteadEncoder_Video_ThreadCountChange(Sender: TObject);
      procedure edtDatasteadEncoder_Audio_SamplesPerSecondChange
        (Sender: TObject);
      procedure edtDatasteadEncoder_Audio_BitRate_kbChange(Sender: TObject);
      procedure BtnCodecExamplesClick(Sender: TObject);
      procedure mmoExtraParametersChange(Sender: TObject);
      procedure cmbGPUEncoderChange(Sender: TObject);
      procedure btnMultipurposeUDPStreamingClick(Sender: TObject);
      procedure btnResumeStreamingClick(Sender: TObject);
      procedure btnPauseStreamingClick(Sender: TObject);
      procedure edtDatasteadEncoder_VideoCodecNameChange(Sender: TObject);
      procedure edtDatasteadEncoder_AudioCodecNameChange(Sender: TObject);
      procedure btnNDISessionsClick(Sender: TObject);
      procedure edtNDIReceiveTimeoutChange(Sender: TObject);
      procedure btnONVIFReplayRecordingsListClick(Sender: TObject);
      procedure cboAutoFileNameChange(Sender: TObject);
      procedure btnIPCamStartPTZClick(Sender: TObject);
      procedure VideoGrabberFrameCaptureCompleted(Sender: TObject;
        FrameBitmap: Vcl.Graphics.TBitmap; BitmapWidth, BitmapHeight: LongInt;
        FrameNumber: LongWord; FrameTime: LargeInteger;
        DestType: TFrameCaptureDest; FileName: string; Success: Boolean;
        FrameId: LongInt);
      procedure VideoGrabberReencodingProgress(Sender: TObject;
        Percent: LongInt; Position, Duration: LargeInteger);
      procedure VideoGrabberMotionDetected(Sender: TObject;
        GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: LongInt;
        FrameBitmap: Vcl.Graphics.TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
        FrameId: LongInt; var CaptureFrame: Boolean);
      procedure VideoGrabberMotionNotDetected(Sender: TObject;
        FrameBitmap: Vcl.Graphics.TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
        FrameId: LongInt; var CaptureFrame: Boolean);
	 procedure lsbOnvifURLsDiscoveredClick(const Sender: TCustomListBox; const Item: TListBoxItem);
    procedure btnDiscoverONVIFFromMulticastClick(Sender: TObject);
    procedure btnDiscoverONVIFFromIPRangeClick(Sender: TObject);
    procedure btnCancelDiscoveryClick(Sender: TObject);
    procedure VideoGrabberONVIFDiscoveryCompleted(Sender: TObject;
      DiscoveryCallbackStatus: TDiscoveryCallbackStatus; CameraCount: LongInt);
    procedure chkUseExternalAudioforRTSPClick(Sender: TObject);
    procedure chk1stVideoWindowActiveClick(Sender: TObject);
    procedure chk2ndVideoWindowActiveClick(Sender: TObject);
    procedure chk1stVisibleClick(Sender: TObject);
    procedure chk1stEmbeddedClick(Sender: TObject);
    procedure chk1stAutoSizeClick(Sender: TObject);
    procedure chk1stStayOnTopClick(Sender: TObject);
    procedure chk1stFullScreenClick(Sender: TObject);
    procedure chk1stMouseMovesWindowClick(Sender: TObject);
    procedure rdg1stDisplayedOnClick(Sender: TObject);
    procedure btnEG1stNewLocation2Click(Sender: TObject);
    procedure rdg1AspectRatioClick(Sender: TObject);
    procedure chk1stAlphablendClick(Sender: TObject);
    procedure chk1stTranspColorClick(Sender: TObject);
    procedure edt1sttranspColorChange(Sender: TObject);
    procedure btnTestPanScanClick(Sender: TObject);
    procedure tbr1PanScanChange(Sender: TObject);
    procedure chk2ndVisibleClick(Sender: TObject);
    procedure chk2ndEmbeddedClick(Sender: TObject);
    procedure chk2ndAutoSizeClick(Sender: TObject);
    procedure chk2ndStayOnTopClick(Sender: TObject);
    procedure chk2ndFullScreenClick(Sender: TObject);
    procedure chk2ndMouseMovesWindowClick(Sender: TObject);
    procedure rdg2ndDisplayedOnClick(Sender: TObject);
    procedure btnEG2ndNewLocation2Click(Sender: TObject);
    procedure rdg2AspectRatioClick(Sender: TObject);
    procedure chk2ndAlphaBlendClick(Sender: TObject);
    procedure chk2ndTranspColorClick(Sender: TObject);
    procedure edt2ndTranspColorChange(Sender: TObject);
    procedure tbr2PanScanChange(Sender: TObject);
    procedure rdbAESencryptionClick(Sender: TObject);
    procedure rdbFastEncryptionClick(Sender: TObject);
    procedure btnSetEncryptionKeyClick(Sender: TObject);
    procedure btnClearEncryptionClick(Sender: TObject);
    procedure btnSetDecryptionKeyClick(Sender: TObject);
    procedure btnClearDecryptionClick(Sender: TObject);
    procedure spdSourceVideoClipClick(Sender: TObject);
    procedure btnEncryptVideoClipClick(Sender: TObject);
    procedure btnDecryptVideoClipClick(Sender: TObject);
    procedure pctMainChange(Sender: TObject);

   private
      /// FireMonkey: video display control, it wraps the VCL TVideoGrabber (see VideoGrabber below)
      FVideoFMX: TVideoGrabberFMX;
      /// FireMonkey: native child windows hosting the VU meters (the SDK draws into a HWND)
      FLeftVUHost: TNativeChildWindow;
      FRightVUHost: TNativeChildWindow;
      /// FireMonkey: last click on the video, in video frame coordinates
      FLastVideoClick: TPoint;
      FLastVideoClickLeft: Boolean;
      FUpdatingPlayerTrackBar: Boolean;

      /// FireMonkey has no TRadioGroup and no TUpDown: emulated, see FmxDemoHelpers
      rdgIRCutFilter: TFmxRadioGroup;
      rdgRecordingMethod: TFmxRadioGroup;
      grbRecordingTimer: TFmxRadioGroup;
      rdgCompressMode: TFmxRadioGroup;
      rgdHwAccel: TFmxRadioGroup;
      rgdFrameGrabberFormat: TFmxRadioGroup;
      rgdFrameGrabber: TFmxRadioGroup;
      rdgTextOverlayAlign: TFmxRadioGroup;
      rdgTextOverlaySelector: TFmxRadioGroup;
      chkOverlayOrientation: TFmxRadioGroup;
      rdgImageOverlaySelector: TFmxRadioGroup;
      rdgVideoRotation: TFmxRadioGroup;
      rdgDeinterlacing: TFmxRadioGroup;
      rdgDetectVideoSignal: TFmxRadioGroup;
      rdgVideoRenderer: TFmxRadioGroup;
      rdg1stDisplayedOn: TFmxRadioGroup;
      rdg1AspectRatio: TFmxRadioGroup;
      rdg2ndDisplayedOn: TFmxRadioGroup;
      rdg2AspectRatio: TFmxRadioGroup;
      updPlayerFastSeekSpeed: TFmxUpDown;
      updXCell: TFmxUpDown;
      updYCell: TFmxUpDown;
      updCellSensitivity: TFmxUpDown;
      updGridColCount: TFmxUpDown;
      updGridRowCount: TFmxUpDown;
      updGlobalGridSensitivity: TFmxUpDown;
      updTextOverlaySize: TFmxUpDown;
      updPixellization: TFmxUpDown;

      FStartupWidth: Integer;
      FStartupHeight: Integer;

      FTransparentForm: TForm;
      FTransparentPanel: TRectangle;
      FSnapForm: TForm;
      FSnapImage: TImage;

      FImageOverlayIndex: LongInt;
      FTextOverlayIndex: LongInt;

      FDisplaySelected: LongInt;

      FKBWritten_LastReportTime: int64;

      FFreeHandMouseDrawing: array [0 .. FreeHandMouseCoordinatesMax +
        1] of TRect;
      FFreeHandMouseDrawingEnabled: Boolean;
      FiFreeHandMouseDrawing: LongInt;

      FSearchBmpFiles: TSearchRec;
      FSearchBmpFilesOpened: Boolean;
      FSearchBmpPath: String;

      FOldVideoSignalState: Boolean;

      FPTZSpeedRatio: Double;
      FPTZRelativeMove: Double;
      FUpdatingPTZTrackbars: Boolean;
      FPTZMoveDurationMs: LongInt;

      FMultipurposeUDPStreamingID: LongInt;

      FEncryptionMethod: TEncryptionMethod; /// 261028de method used by SetEncryptionKey / SetDecryptionKey (encryption tab)

      // VU-meter configuration window (non-modal, instantiated on demand)
      FVUMeterConfigForm: TForm;

      // Design-time (DFM) sizes of the VU-meter host panels. Captured in
      // FormCreate so that the resize done by ConfigureVUMeters always uses
      // the SAME reference, instead of compounding successive ratios (which
      // would shrink the panels a bit more on every type switch).
      FInitialLeftVUMeterWidth   : Integer;
      FInitialLeftVUMeterHeight  : Integer;
      FInitialRightVUMeterWidth  : Integer;
      FInitialRightVUMeterHeight : Integer;

      procedure ShowFormAboveVideo(Form: TForm);
      procedure RefreshDeviceControls;
      procedure RefreshDisplayOptions;

      procedure TransparentFormButtonClick(Sender: TObject);
      procedure PTZStopContinuousMove();
      procedure DoPTZAbsolute();

      procedure ChangeVideoSource (VideoSource: TVideoSource);
      procedure ConfigureVUMeters (VUMeter: TVUMeter);
      procedure WarnFrameBitmapOptionInNV12 (OptionEnabled: Boolean);
      procedure ReapplyEncryptionKeys;

      procedure SetupVideoGrabber;
      procedure CreateFmxHelpers;
      procedure LogFromAnyThread (const Msg: string);
      procedure UpdatePlayerTrackBar (PositionMs: Single);
      procedure VUHostHandleChanged (Sender: TObject);
      procedure VideoDisplayMouseDown (Sender: TObject; Button: TMouseButton; Shift: TShiftState; X, Y: Single);
      procedure VideoDisplayMouseMove (Sender: TObject; Shift: TShiftState; X, Y: Single);
      procedure VideoDisplayMouseUp (Sender: TObject; Button: TMouseButton; Shift: TShiftState; X, Y: Single);
   public
      /// the VCL TVideoGrabber wrapped by the TVideoGrabberFMX control (created at runtime)
      VideoGrabber: TVideoGrabber;
   end;

var
   frmMainForm: TfrmMainForm;
   mpeRecordingExamplesForm: TForm = nil;
   mpeStreamingExamplesForm: TForm = nil;

implementation

uses
   typinfo,
   FMX.DialogService.Sync,
   miscVideoQuality,
   miscCameraControl,
   VUMeterConfigForm;

const
   AUDIO_CLIPS = '*.mp3;*.wav;*.wma;*.mid';
   VIDEO_CLIPS =
     '*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.wemb;*.ts;*.m4v;*.mp4v;*.ogg;*.amv;*.rm;*.m2t*';
   IMAGE_FILES = '*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png';
   OPEN_MEDIA_FILES = 'All media files|' + VIDEO_CLIPS + ';' + AUDIO_CLIPS + ';'
     + IMAGE_FILES + '|Video clips|' + VIDEO_CLIPS + '|Audio clips|' +
     AUDIO_CLIPS;
   OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES + '|Image files|' + IMAGE_FILES;
   OPEN_IMAGE_FILES =
     'Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg';
{$R *.fmx}
{$IFNDEF VER160}

function StrToFloatDef(const S: string; const Default: Extended): Extended;
begin
   if not TextToFloat(PChar(S), Result, fvExtended) then
      Result := Default;
end;
{$ENDIF VER160}

procedure AssignListToComboBox(ComboBox: TComboBox; List: String;
  Index: Integer);
begin
   /// FireMonkey: TComboBox.OnChange also occurs when ItemIndex is set by code, the combo box
   /// OnChange handlers ignore the changes done through ComboBoxAssignList / ComboBoxSetIndex
   ComboBoxAssignList(ComboBox, List, Index);
end;

procedure TfrmMainForm.FormCreate(Sender: TObject);
begin
   SetupVideoGrabber;

	VideoGrabber.SetDisplayAspectRatio(0, ar_Box);
   // preserves the aspect ratio in the display window, whatever the size of the control
   VideoGrabber.AutoRefreshPreview := true;
   // the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

   FImageOverlayIndex := 0;
   FTextOverlayIndex := 0;

   FMultipurposeUDPStreamingID := -1;

   FEncryptionMethod := em_AES_Encryption; /// 261028de AES recommended (rdbAESencryption checked in the form)

   // Capture the design-time sizes of the VU-meter host panels
   // (FInitial*VUMeter* fields) - used as the resize reference by
   // ConfigureVUMeters.
   FInitialLeftVUMeterWidth   := Round(pnLeftVUMeter.Width);
   FInitialLeftVUMeterHeight  := Round(pnLeftVUMeter.Height);
   FInitialRightVUMeterWidth  := Round(pnRightVUMeter.Width);
   FInitialRightVUMeterHeight := Round(pnRightVUMeter.Height);

   FFreeHandMouseDrawingEnabled := False; // used for free-hand mouse drawing
   FiFreeHandMouseDrawing := 0; // used for free-hand mouse drawing
   FSearchBmpFilesOpened := False;
   // used for the "video from bitmaps" in the VideoGrabberVideoFromBitmaps_NextFrameNeeded event

   FKBWritten_LastReportTime := 0;
   // used to store the last time, to report periodically the KB written from the OnFrameProgress event (in this demo every 5 seconds)

   FStartupWidth := Width;
   FStartupHeight := Height;

   FOldVideoSignalState := False;
   FDisplaySelected := 0;

   // pctMain.ActivePage := tbsVideoDevice;


   // - controls using global TVideoGrabber properties, e.g. like the VideoDevices list, are updated from the FormCreate event
   // - controls that depend of the current video device are set in the VideoDeviceSelected event
   // - controls that depend of the current audio device are set in the AudioDeviceSelected event

   /// ////////////////////// Controls on main form
   edtStoragePath.Text := VideoGrabber.StoragePath;

   /// ////////////////////// Video source tab
   AssignListToComboBox(cboVideoSource, VideoGrabber.VideoSources,
     Integer(VideoGrabber.VideoSource));
   AssignListToComboBox(cboVideoDevices, VideoGrabber.VideoDevices,
     VideoGrabber.VideoDevice);
   btnAutoRefreshPreview.IsChecked := VideoGrabber.AutoRefreshPreview;
   ComboBoxSetIndex(cboVideoSource, Integer(VideoGrabber.VideoSource));
   chkScreenRecordingWithCursor.IsChecked :=
     VideoGrabber.ScreenRecordingWithCursor;
   edtMonitorNumber.Text := IntToStr(VideoGrabber.ScreenRecordingMonitor);
   VideoGrabber.VideoSource_FileOrUrl := edtVideoSourceFileOrUrl.Text;

   /// ////////////////////// Audio tab
   AssignListToComboBox(cboAudioDevices, VideoGrabber.AudioDevices,
     VideoGrabber.AudioDevice);
   AssignListToComboBox(cboAudioRenderers, VideoGrabber.AudioRenderers,
     VideoGrabber.AudioRenderer);
   chkRenderAudioDevice.IsChecked := VideoGrabber.AudioDeviceRendering;
   chkMuteAudioRendering.IsChecked := VideoGrabber.MuteAudioRendering;

   // Activate the Spectrum analyzer as the default VU meter.
   // Safe to call here: the FInitial*VUMeter* reference sizes have already
   // been captured earlier in this FormCreate.
   ConfigureVUMeters (vu_Spectrum);

   /// ////////////////////// RECORDING tab
   rdgRecordingMethod.ItemIndex := Integer(VideoGrabber.RecordingMethod);
   grbRecordingTimer.ItemIndex := Integer(VideoGrabber.RecordingTimer);
   if VideoGrabber.RecordingFileName <> '' then
   begin
      edtRecordingFileName.Text := VideoGrabber.RecordingFileName;
      chkAVISaveToThisFile.IsChecked := true;
   end;
   chkRecordingCanPause.IsChecked := VideoGrabber.RecordingCanPause;
   chkRecordingPauseCreatesNewFile.IsChecked :=
     VideoGrabber.RecordingPauseCreatesNewFile;
   chkPreserveNativeFormat.IsChecked := VideoGrabber.RecordingInNativeFormat;

   rdgCompressMode.ItemIndex := Integer(VideoGrabber.CompressionMode);
   chkAudioRecording.IsChecked := VideoGrabber.AudioRecording;
   AssignListToComboBox(cboVideoCompressors, VideoGrabber.VideoCompressors,
     VideoGrabber.VideoCompressor);
   AssignListToComboBox(cboAudioCompressors, VideoGrabber.AudioCompressors,
     VideoGrabber.AudioCompressor);

   /// ////////////////////// IP Camera tab
   chkOpenURLAsync.IsChecked := VideoGrabber.OpenURLAsync;
   tbrPTZSpeedRatio.Value := 100;
   // speed ratio in the 0..1 range and trackbar in the 0..100 range, so value = trackbar position / 100
   FPTZMoveDurationMs := 300; // 300 ms
   FPTZRelativeMove := 0.01;
   FPTZSpeedRatio := 0.5; //
   FUpdatingPTZTrackbars := False;

   /// ////////////////////// Player tab
   edtPlayerSpeedRatio.Text := FormatFloat('0.0',
     VideoGrabber.PlayerSpeedRatio);

   updPlayerFastSeekSpeed.Position := VideoGrabber.PlayerFastSeekSpeedRatio;
   edtPlayerFastSeekSpeed.Text :=
     IntToStr(VideoGrabber.PlayerFastSeekSpeedRatio);

   btnAutoPlay.IsChecked := VideoGrabber.AutoStartPlayer;
   chkPlayerAudioRendering.IsChecked := VideoGrabber.PlayerAudioRendering;
   chkUseClock.IsChecked := VideoGrabber.UseClock;
   chkRefreshPausedDisplay.IsChecked := VideoGrabber.PlayerRefreshPausedDisplay;

   rgdHwAccel.ItemIndex := Integer(VideoGrabber.PlayerHWAccel);

   /// ////////////////////// Frame grabber tab
   edtAVIAutoFilePrefix.Text := VideoGrabber.AutoFilePrefix;
   rgdFrameGrabberFormat.ItemIndex :=
     Integer(VideoGrabber.FrameGrabberRGBFormat);
   rgdFrameGrabber.ItemIndex := Integer(VideoGrabber.FrameGrabber);
   ComboBoxSetIndex(cboAutoFileName, Integer(VideoGrabber.AutoFileName));
   edtFrameCaptureWidth.Text := IntToStr(VideoGrabber.FrameCaptureWidth);
   edtFrameCaptureHeight.Text := IntToStr(VideoGrabber.FrameCaptureHeight);

   /// ////////////////////// Frame capture tab
   edtBurstCount.Text := IntToStr(VideoGrabber.BurstCount);
   edtBurstInterval.Text := IntToStr(VideoGrabber.BurstInterval);
   tbrCaptureZoomSize.Value := VideoGrabber.FrameCaptureZoomSize;

   /// ////////////////////// Motion detection tab

   chkMotionDetectionEnabled.IsChecked := VideoGrabber.MotionDetector_Enabled;
   chkCompareRed.IsChecked := VideoGrabber.MotionDetector_CompareRed;
   chkCompareGreen.IsChecked := VideoGrabber.MotionDetector_CompareGreen;
   chkCompareBlue.IsChecked := VideoGrabber.MotionDetector_CompareBlue;
   chk_GreyScale.IsChecked := VideoGrabber.MotionDetector_GreyScale;
   chkReduceVideoNoise.IsChecked := VideoGrabber.MotionDetector_ReduceVideoNoise;
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
   edtGridColCount.Text := IntToStr(VideoGrabber.MotionDetector_GridXCount);
   edtGridRowCount.Text := IntToStr(VideoGrabber.MotionDetector_GridYCount);
   chkTriggered.IsChecked := VideoGrabber.MotionDetector_Triggered;

   /// ////////////////////// Overlay tab
   rdgImageOverlaySelector.ItemIndex := 0;
   rdgImageOverlaySelectorClick(Self);
   // reloads the image overlay settings for the index 0
   chkAdjustOverlayAspectRatio.IsChecked := VideoGrabber.AdjustOverlayAspectRatio;

   rdgTextOverlaySelector.ItemIndex := 0;
   rdgTextOverlaySelectorClick(Self);
   // reloads the text overlay settings for the index 0

   /// ////////////////////// Video processing tab
   rdgVideoRotation.ItemIndex := Integer(VideoGrabber.VideoProcessing_Rotation);
   tbrBrightness.Value := -VideoGrabber.VideoProcessing_Brightness;
   tbrConstrast.Value := -VideoGrabber.VideoProcessing_Contrast;
   tbrSaturation.Value := -VideoGrabber.VideoProcessing_Saturation;
   tbrHue.Value := VideoGrabber.VideoProcessing_Hue;
   edtCustomRotationAngle.Text := FormatFloat('0.00',
     VideoGrabber.VideoProcessing_RotationCustomAngle);

   rdgDeinterlacing.ItemIndex :=
     Integer(VideoGrabber.VideoProcessing_Deinterlacing);
   chkGreyScale.IsChecked := VideoGrabber.VideoProcessing_GrayScale;
   chkInvertColors.IsChecked := VideoGrabber.VideoProcessing_InvertColors;
   chkFlipVertical.IsChecked := VideoGrabber.VideoProcessing_FlipVertical;
   chkFlipHorizontal.IsChecked := VideoGrabber.VideoProcessing_FlipHorizontal;

   chkCroppingEnabled.IsChecked := VideoGrabber.Cropping_Enabled;
   chkCroppingOutbounds.IsChecked := VideoGrabber.Cropping_Outbounds;
   edtCroppingWidth.Text := IntToStr(VideoGrabber.Cropping_Width);
   edtCroppingHeight.Text := IntToStr(VideoGrabber.Cropping_Height);
   trkCroppingZoom.Value := Round(VideoGrabber.Cropping_Zoom * 100);

   // trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event
   trkCroppingY.Value := VideoGrabber.Cropping_Y;
   trkCroppingX.Value := VideoGrabber.Cropping_X;

   /// ////////////////////// Display tab
   VideoGrabber.SetDisplayTransparentColorValue(0, $0000FF);
   VideoGrabber.SetDisplayTransparentColorValue(1, $FF0000);

   chkZeroLatency.IsChecked := (VideoGrabber.SyncPreview = sp_Disabled);
   chkVideoVisibleWhenStopped.IsChecked := VideoGrabber.VideoVisibleWhenStopped;
   chkAdjustPixelAspectRatio.IsChecked := VideoGrabber.AdjustPixelAspectRatio;
   chkBorder.IsChecked := VideoGrabber.BorderStyle = bsSingle;
   chkTransparency.IsChecked := VideoGrabber.ColorKeyEnabled;
   rdgVideoRenderer.ItemIndex := Integer(VideoGrabber.VideoRenderer);
   RefreshDisplayOptions;

end;

/// /////////////////////////////////////////////////////////////////////////////
// VIDEO DEVICE TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.VideoGrabberVideoDeviceSelected(Sender: TObject);
begin
   ComboBoxSetIndex(cboVideoDevices, VideoGrabber.VideoDevice);
   // be sure the listbox index matches the current index value

   // from this event update the properties that depend of the current video capture device.
   // This event occurs when a new value is assigned to the VideoDevice property.
   RefreshDeviceControls;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.ChangeVideoSource (VideoSource: TVideoSource);
var
   VideoSourceName: string;
begin
   if VideoGrabber.VideoSource <> VideoSource then begin
      VideoGrabber.VideoSource := VideoSource;
      case VideoSource of
         vs_VideoCaptureDevice: begin
            ComboBoxSetIndex(cboVideoSource, 0);
            VideoSourceName := 'vs_VideoCaptureDevice';
         end;
         vs_ScreenRecording: begin
            ComboBoxSetIndex(cboVideoSource, 1);
            VideoSourceName := 'vs_ScreenRecording';
         end;
         vs_VideoFileOrURL: begin
            ComboBoxSetIndex(cboVideoSource, 2);
            VideoSourceName := 'vs_VideoFileOrURL';
         end;
         vs_JPEGsOrBitmaps: begin
            ComboBoxSetIndex(cboVideoSource, 3);
            VideoSourceName := 'vs_JPEGsOrBitmaps';
         end;
         vs_IPCamera: begin
            ComboBoxSetIndex(cboVideoSource, 4);
            VideoSourceName := 'vs_IPCamera';
         end;
         vs_Mixer: begin
            ComboBoxSetIndex(cboVideoSource, 5);
            VideoSourceName := 'vs_Mixer';
         end;
      else
         VideoSourceName := '';
         mmoLog.Lines.Add('this "VideoSource" option is not used in this demo');
      end;
      if VideoSourceName <> '' then begin
         mmoLog.Lines.Add('changing VideoSource to: ' + VideoSourceName);
      end;
   end;
end;

procedure TfrmMainForm.cboVideoSourceChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   ChangeVideoSource (TVideoSource (cboVideoSource.ItemIndex));
end;

procedure TfrmMainForm.cboVideoDevicesChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   if cboVideoDevices.ItemIndex >= 0 then begin
      ChangeVideoSource (vs_VideoCaptureDevice);
   end;
   VideoGrabber.VideoDevice := cboVideoDevices.ItemIndex;
   // when selecting another video capture device, the OnVideoDeviceSelected event occurs.
   // be sure to refresh all your device-dependent controls from the OnVideoDeviceSelected event.
end;

procedure TfrmMainForm.btnStartPreviewClick(Sender: TObject);
begin
   VideoGrabber.StartPreview;
end;

procedure TfrmMainForm.btnPausePreviewClick(Sender: TObject);
begin
   VideoGrabber.PausePreview;
end;

procedure TfrmMainForm.btnResumePreviewClick(Sender: TObject);
begin
   VideoGrabber.ResumePreview;
end;

procedure TfrmMainForm.btnStopPreviewClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

procedure TfrmMainForm.btnAutoRefreshPreviewClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AutoRefreshPreview := btnAutoRefreshPreview.IsChecked;
end;

procedure TfrmMainForm.chkEnableSnapshotButtonClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkEnableSnapshotButton.Enabled then
   begin
      VideoGrabber.WebcamStillCaptureButton := wb_Enabled;
   end
   else
   begin
      VideoGrabber.WebcamStillCaptureButton := wb_Disabled;
   end;
end;

procedure TfrmMainForm.cboVideoInputsChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.VideoInput := cboVideoInputs.ItemIndex;
end;

procedure TfrmMainForm.cboVideoFormatsChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.VideoFormat := cboVideoFormats.ItemIndex;
   AssignListToComboBox(cboVideoSizes, VideoGrabber.VideoSizes,
     VideoGrabber.VideoSize); // updates VideoSizes accordingly
   AssignListToComboBox(cboVideoSubtypes, VideoGrabber.VideoSubtypes,
     VideoGrabber.VideoSubtype); // updates VideoSubtypes accordingly
end;

procedure TfrmMainForm.cboVideoSizesChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.VideoSize := cboVideoSizes.ItemIndex;
   AssignListToComboBox(cboVideoFormats, VideoGrabber.VideoFormats,
     VideoGrabber.VideoFormat); // updates VideoFormats accordingly
end;

procedure TfrmMainForm.cboVideoSubtypesChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.VideoSubtype := cboVideoSubtypes.ItemIndex;
   AssignListToComboBox(cboVideoFormats, VideoGrabber.VideoFormats,
     VideoGrabber.VideoFormat); // updates VideoFormats accordingly
end;

procedure TfrmMainForm.cboAnalogVideoStandardChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.AnalogVideoStandard := cboAnalogVideoStandard.ItemIndex;
end;

procedure TfrmMainForm.chkSetLogoClick(Sender: TObject);
var
   LogoBitmap: Vcl.Graphics.TBitmap;
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   /// FireMonkey: the logo is displayed by the native video window while the video is stopped,
   /// it is not visible through TVideoGrabberFMX. SetLogoFromTImage expects a VCL TImage: the FMX
   /// image is converted to a VCL bitmap.
   if chkSetLogo.IsChecked then
   begin
      LogoBitmap := Vcl.Graphics.TBitmap.Create;
      try
         FmxBitmapToVcl(imgLogo.MultiResBitmap.Bitmaps[1.0], LogoBitmap);
         VideoGrabber.SetLogoFromTBitmap(LogoBitmap);
      finally
         LogoBitmap.Free;
      end;
      VideoGrabber.LogoLayout := lg_Stretched;
      VideoGrabber.LogoDisplayed := true;
   end
   else
   begin
      VideoGrabber.LogoDisplayed := False;
   end;
end;

procedure TfrmMainForm.btnCameraControlDialogClick(Sender: TObject);
begin
   if not assigned(frmCameraControl) then
   begin
      frmCameraControl := TfrmCameraControl.Create(Application);
   end;
   ShowFormAboveVideo(frmCameraControl);
end;

procedure TfrmMainForm.btnCancelDiscoveryClick(Sender: TObject);
begin
	VideoGrabber.ONVIFCancelDiscovery();
end;

procedure TfrmMainForm.btnVideoQualityDialogClick(Sender: TObject);
begin
   if not assigned(frmVideoQuality) then
   begin
      frmVideoQuality := TfrmVideoQuality.Create(Application);
   end;
   ShowFormAboveVideo(frmVideoQuality);
end;

procedure TfrmMainForm.btnFrameRateClick(Sender: TObject);
var
   Value: Double;
begin
   Value := StrToFloatDef(edtFrameRate.Text, -1);
   VideoGrabber.FrameRate := Value;

   if VideoGrabber.CurrentState = cs_Preview then
   begin
      mmoLog.Lines.Add('current frame rate: ' + FormatFloat('0.00',
        VideoGrabber.CurrentFrameRate) + ' fps.');
   end;
end;

procedure TfrmMainForm.btnAboutFrameRateClick(Sender: TObject);
begin
   ShowMessage('0 means that the default frame rate of the device will be used.'
     + #13#10 + 'After the OnPreviewStarted or OnRecordingStarted event occurs,'
     + #13#10 + 'its value is available in the CurrentFrameRate property.');
end;

procedure TfrmMainForm.btnSelectFileOrUrlClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES;
   if OpenDlg.Execute then
   begin
      edtVideoSourceFileOrUrl.Text := OpenDlg.FileName;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.edtVideoSourceFileOrUrlChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoSource_FileOrUrl := edtVideoSourceFileOrUrl.Text;
end;

procedure TfrmMainForm.VideoSourceFileOrUrl_UserNameChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetAuthentication(at_StreamingUrl,
     VideoSourceFileOrUrl_UserName.Text, VideoSourceFileOrUrl_Password.Text);
end;

procedure TfrmMainForm.VideoSourceFileOrUrl_PasswordChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetAuthentication(at_StreamingUrl,
     VideoSourceFileOrUrl_UserName.Text, VideoSourceFileOrUrl_Password.Text);
end;

procedure TfrmMainForm.btnUrlConfClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog(dlg_NetShowConfig);
end;

procedure TfrmMainForm.btnScreenRecordingWindowClick(Sender: TObject);
begin
   VideoGrabber.SetWindowRecordingByName(edtScreenRecordingWindow.Text, False);
   // set to "true" for an exact and case-sensitive match
end;

procedure TfrmMainForm.chkScreenRecordingWithCursorClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.ScreenRecordingWithCursor :=
     chkScreenRecordingWithCursor.IsChecked;
end;

procedure TfrmMainForm.edtMonitorNumberChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.ScreenRecordingMonitor := StrToIntDef(edtMonitorNumber.Text, 0);
end;

procedure TfrmMainForm.btnMonitorNumberInfoClick(Sender: TObject);
begin
   ShowMessage('-1 = full desktop, 0 = 1st monitor, 1 = 2nd monitor, etc...');
end;

procedure TfrmMainForm.btnMultipurposeUDPStreamingClick(Sender: TObject);
begin
   if FMultipurposeUDPStreamingID = -1 then
   begin
      FMultipurposeUDPStreamingID :=
        VideoGrabber.Encoders_CreateInstanceForStreaming
        ('udp://239.255.0.1:10124');
   end;
   if FMultipurposeUDPStreamingID > -1 then
   begin
      /// uncomment one of the lines below to use a specific codec, e.g.:
      // VideoGrabber.Encoder_SetStr (FMultipurposeUDPStreamingID, Enc_Video_Codec, 'hevc');
      // VideoGrabber.Encoder_SetStr (FMultipurposeUDPStreamingID, Enc_Video_Codec, 'h264');

      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_Enabled_bool, 1);
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Audio_Enabled_bool, 1);
      if not chkStreamingVideoEnabled.IsChecked then
      begin
         VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
           Enc_Video_Enabled_bool, 0);
      end;
      if not chkStreamingAudioEnabled.IsChecked then
      begin
         VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
           Enc_Audio_Enabled_bool, 0);
      end;
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_BitRate_kb, 2000);
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_rc_MinBitRate_kb, 1800);
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_rc_MaxBitRate_kb, 2200);
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_Video_IDR_Interval, 30);
      /// uncomment to enable the GPU encoder, if available for h264 or hevc
      // VideoGrabber.Encoder_SetInt (FStreamingEncoderId, Enc_Video_GPU_Encoder, LongInt (Enc_GPU_Auto));  // or specify directly Enc_GPU_Intel_QSV, Enc_GPU_NVidia_NVENC or Enc_GPU_AMD_AMF
      VideoGrabber.Encoder_SetInt(FMultipurposeUDPStreamingID,
        Enc_IsActive_bool, 1);
   end;
end;

procedure TfrmMainForm.btnPauseStreamingClick(Sender: TObject);
begin
   VideoGrabber.Encoder_Pause(FMultipurposeUDPStreamingID);
end;

procedure TfrmMainForm.btnResumeStreamingClick(Sender: TObject);
begin
   VideoGrabber.Encoder_Resume(FMultipurposeUDPStreamingID);
end;

procedure TfrmMainForm.VideoGrabberPreviewStarted(Sender: TObject);
begin
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add('video source size: ' + IntToStr(VideoGrabber.VideoWidth) +
     'x' + IntToStr(VideoGrabber.VideoHeight));
   mmoLog.Lines.Add('display aspect ratio: ' +
     IntToStr(VideoGrabber.VideoWidth_PreferredAspectRatio) + 'x' +
     IntToStr(VideoGrabber.VideoHeight_PreferredAspectRatio));
   mmoLog.Lines.Add('current frame rate: ' + FormatFloat('0.00',
     VideoGrabber.CurrentFrameRate) + ' fps.');
   mmoLog.Lines.Add('');
end;

/// /////////////////////////////////////////////////////////////////////////////
// AUDIO TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.VideoGrabberAudioDeviceSelected(Sender: TObject);
begin
   // from this event set the parameters that change when the current audio capture device change
   ComboBoxSetIndex(cboAudioDevices, VideoGrabber.AudioDevice);
   // be sure the listbox index matches the current index value

   AssignListToComboBox(cboAudioInputs, VideoGrabber.AudioInputs,
     Integer(VideoGrabber.AudioInput));
   tbrAudioInputLevel.Value := VideoGrabber.AudioInputLevel;
   tbrAudioInputBalance.Value := VideoGrabber.AudioInputBalance;
end;

procedure TfrmMainForm.btnStartAudioRenderingClick(Sender: TObject);
begin
   VideoGrabber.StartAudioRendering;
   if not VideoGrabber.AudioDeviceRendering then
   begin
      if btnStartAudioRendering.Tag = 0 then
      begin
         btnStartAudioRendering.Tag := 1; // to show the popup only one time
         ShowMessage
           ('StartAudioRendering acts as "preview", e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers');
      end;
   end;
end;

procedure TfrmMainForm.btnStartWAVRecordingClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := cm_NoCompression;
   VideoGrabber.RecordingMethod := rm_AVI;
   VideoGrabber.StartAudioRecording;
end;

procedure TfrmMainForm.btnStartMP3RecordingClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := cm_CompressOnTheFly;
   VideoGrabber.CompressionType := ct_Audio;
   VideoGrabber.RecordingMethod := rm_AVI;
   VideoGrabber.AudioCompressor := VideoGrabber.FindIndexInListByName
     (VideoGrabber.AudioCompressors, 'MP3 (Microsoft)', False, true);
   if VideoGrabber.AudioCompressor = -1 then
   begin
      ShowMessage
        ('MP3 (Microsoft) audio compressor not found, please contact support@datastead.com');
   end
   else
   begin
      VideoGrabber.StartAudioRecording;
   end;
end;

procedure TfrmMainForm.btnStartASFRecordingClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := cm_NoCompression;
   VideoGrabber.RecordingMethod := rm_ASF;
   VideoGrabber.StartAudioRecording;
end;

procedure TfrmMainForm.btnStopAudioClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

procedure TfrmMainForm.chkRenderAudioDeviceClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AudioDeviceRendering := chkRenderAudioDevice.IsChecked;
end;

procedure TfrmMainForm.cboAudioDevicesChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.AudioDevice := cboAudioDevices.ItemIndex;
end;

procedure TfrmMainForm.cboAudioInputsChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.AudioInput := cboAudioInputs.ItemIndex;
end;

procedure TfrmMainForm.tbrAudioInputLevelChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AudioInputLevel := Round(tbrAudioInputLevel.Value);
end;

procedure TfrmMainForm.tbrAudioInputBalanceChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AudioInputBalance := Round(tbrAudioInputBalance.Value);
end;

procedure TfrmMainForm.cboAudioRenderersChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.AudioRenderer := cboAudioRenderers.ItemIndex;
end;

procedure TfrmMainForm.cboAutoFileNameChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.AutoFileName := TAutoFileName(cboAutoFileName.ItemIndex);
end;

procedure TfrmMainForm.tbrAudioVolumeChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AudioVolume := Round(tbrAudioVolume.Value);
end;

procedure TfrmMainForm.tbr1PanScanChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_PanScanRatio := Round(tbr1PanScan.Value);
end;

procedure TfrmMainForm.tbr2PanScanChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_PanScanRatio := Round(tbr2PanScan.Value);
end;

procedure TfrmMainForm.tbrAudioBalanceChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AudioBalance := Round(tbrAudioBalance.Value);
end;

procedure TfrmMainForm.chkMuteAudioRenderingClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.MuteAudioRendering := chkMuteAudioRendering.IsChecked;
end;

procedure TfrmMainForm.ConfigureVUMeters (VUMeter: TVUMeter);
// Applies the selected VU-meter type: resizes the host panels
// (pnLeftVUMeter / pnRightVUMeter) according to the type and attaches
// (or detaches) the native window handles.
//
// IMPORTANT: resizes ALWAYS start from the initial sizes (FInitial*VUMeter*)
// captured in FormCreate, never from the current sizes. Otherwise, chaining
// several type changes (e.g. Analog -> Vintage -> Analog -> Vintage ...)
// would shrink the panels progressively, each ratio compounding onto the
// previous result.
//
// Called either directly or through the TfrmVUMeterConfig dialog
// (OnApplyType callback).
const
   VU_LEFT  = 0;
   VU_RIGHT = 1;
begin
   VideoGrabber.VUMeter := VUMeter;

   case VUMeter of
      vu_Analog:
         begin
            // 4:3 aspect for the analog galvanometer: keep the initial
            // height and compute the width from it.
            pnLeftVUMeter.Width   := (FInitialLeftVUMeterHeight  * 4) div 3;
            pnLeftVUMeter.Height  :=  FInitialLeftVUMeterHeight;
            pnRightVUMeter.Width  := (FInitialRightVUMeterHeight * 4) div 3;
            pnRightVUMeter.Height :=  FInitialRightVUMeterHeight;
            VideoGrabber.SetVUMeterSetting(VU_LEFT,  vu_bkGndColor, clBlack);
            VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_bkGndColor, clBlack);
         end;
      vu_AnalogVintage, vu_Spectrum:
         begin
            // 2:1 horizontal aspect: keep the initial width and compute
            // the height from it.
            pnLeftVUMeter.Width   :=  FInitialLeftVUMeterWidth;
            pnLeftVUMeter.Height  := (FInitialLeftVUMeterWidth  * 2) div 4;
            pnRightVUMeter.Width  :=  FInitialRightVUMeterWidth;
            pnRightVUMeter.Height := (FInitialRightVUMeterWidth * 2) div 4;
            VideoGrabber.SetVUMeterSetting(VU_LEFT,  vu_bkGndColor, clBlack);
            VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_bkGndColor, clBlack);
         end;
      vu_Bargraph, vu_SegmentLed, vu_SmoothBar, vu_MixingTable:
         begin
            // Thin vertical column: keep the initial height and compute
            // the (narrow) width from it.
            pnLeftVUMeter.Width   := (FInitialLeftVUMeterHeight  * 2) div 10;
            pnLeftVUMeter.Height  :=  FInitialLeftVUMeterHeight;
            pnRightVUMeter.Width  := (FInitialRightVUMeterHeight * 2) div 10;
            pnRightVUMeter.Height :=  FInitialRightVUMeterHeight;
            VideoGrabber.SetVUMeterSetting(VU_LEFT,  vu_bkGndColor, TColor($404040));
            VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_bkGndColor, TColor($404040));
         end;
      vu_Disabled:
         begin
            // Off state: restore the exact design-time sizes so the next
            // selection starts from a clean baseline.
            pnLeftVUMeter.Width   := FInitialLeftVUMeterWidth;
            pnLeftVUMeter.Height  := FInitialLeftVUMeterHeight;
            pnRightVUMeter.Width  := FInitialRightVUMeterWidth;
            pnRightVUMeter.Height := FInitialRightVUMeterHeight;
         end;
   end;

   /// FireMonkey: the placeholders have no window handle, the SDK paints onto native child windows
   /// kept over them
   FLeftVUHost.UpdateBounds;
   FRightVUHost.UpdateBounds;

   if VUMeter <> vu_Disabled then
   begin
      VideoGrabber.SetVUMeterSetting(VU_LEFT,  vu_Handle, FLeftVUHost.Handle);
      VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_Handle, FRightVUHost.Handle);
   end
   else
   begin
      // Detach: passing 0 as the handle releases the TPanel
      VideoGrabber.SetVUMeterSetting(VU_LEFT,  vu_Handle, 0);
      VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_Handle, 0);
   end;
end;

procedure TfrmMainForm.btnConfigureVUMetersClick(Sender: TObject);
// Opens the VU-meter configuration window (non-modal).
// The form is instantiated on first open and freed on close (caFree),
// with FVUMeterConfigForm reset to nil in VUMeterConfigFormClose.
var
   ConfigForm: TfrmVUMeterConfig;
begin
   if FVUMeterConfigForm = nil then
   begin
      ConfigForm := TfrmVUMeterConfig.Create(Self);
      ConfigForm.VideoGrabber := VideoGrabber;
      ConfigForm.OnApplyType := ConfigureVUMeters;
      ConfigForm.OnClose := VUMeterConfigFormClose;
      FVUMeterConfigForm := ConfigForm;
   end;
   FVUMeterConfigForm.Show;
   FVUMeterConfigForm.BringToFront;
end;

procedure TfrmMainForm.VUMeterConfigFormClose(Sender: TObject;
   var Action: TCloseAction);
begin
   Action := TCloseAction.caFree;
   FVUMeterConfigForm := nil;
end;

procedure TfrmMainForm.btnBargraphOverlayClick(Sender: TObject);
var
   i: LongInt;
begin
   VideoGrabber.SetVUMeterSetting(2, vu_OverlayLeft, 10);
   VideoGrabber.SetVUMeterSetting(3, vu_OverlayLeft, 140);
   for i := 2 to 3 do
   begin
      VideoGrabber.SetVUMeter_Enabled(i, vu_BargraphOverlay);
      VideoGrabber.SetVUMeterSetting(i, vu_Transparent, 1);
      VideoGrabber.SetVUMeterSetting(i, vu_OverlayTop, 10);
      VideoGrabber.SetVUMeterSetting(i, vu_OverlayWidth, 100);
      VideoGrabber.SetVUMeterSetting(i, vu_OverlayHeight, 60);
      VideoGrabber.SetVUMeterSetting(i, vu_bkGndColor, $800000);
      VideoGrabber.SetVUMeterSetting(i, vu_NormalColor, $000080);
      VideoGrabber.SetVUMeterSetting(i, vu_WarningColor, $00A5FF);
      VideoGrabber.SetVUMeterSetting(i, vu_PeakColor, $00FFFF);
      VideoGrabber.SetVUMeterSetting(i, vu_WarningPercent, 20);
      VideoGrabber.SetVUMeterSetting(i, vu_PeakPercent, 40);
   end;
end;

/// /////////////////////////////////////////////////////////////////////////////
// RECORDING TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnStartRecordingImmediatelyClick(Sender: TObject);
begin
   VideoGrabber.HoldRecording := False;
   // let's start recording as soon as the graph is built.
   VideoGrabber.StartRecording;
end;

procedure TfrmMainForm.btnStartRecordingControlledClick(Sender: TObject);
begin
   VideoGrabber.HoldRecording := true;
   VideoGrabber.StartRecording;

   // Enabling HoldRecording prevents the recording to start when the recording graph is built.
   // after the OnRecordingReadyToStart event occurs, you can accurately start the
   // recording by invoking ResumeRecording.
end;

procedure TfrmMainForm.btnStopRecordingClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

procedure TfrmMainForm.btnRenewRecordingFileClick(Sender: TObject);
begin
   VideoGrabber.RecordToNewFileNow(edtNewFileDuringRecording.Text, true);
end;

procedure TfrmMainForm.rdgRecordingMethodClick(Sender: TObject);
begin
   VideoGrabber.RecordingMethod :=
     TRecordingMethod(rdgRecordingMethod.ItemIndex);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.chkRecordingCanPauseClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.RecordingCanPause := chkRecordingCanPause.IsChecked;
   RefreshDeviceControls;
end;

procedure TfrmMainForm.chkRecordingPauseCreatesNewFileClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.RecordingPauseCreatesNewFile :=
     chkRecordingPauseCreatesNewFile.IsChecked;
end;

procedure TfrmMainForm.chkRecordingOnMotionClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.RecordingOnMotion_Enabled := chkRecordingOnMotion.IsChecked;
   chkRecordingCanPause.IsChecked := chkRecordingOnMotion.IsChecked;
end;

procedure TfrmMainForm.btnPauseRecordingClick(Sender: TObject);
begin
   VideoGrabber.PauseRecording;
end;

procedure TfrmMainForm.btnResumeRecordingClick(Sender: TObject);
begin
   VideoGrabber.ResumeRecording;
end;

procedure TfrmMainForm.chkAVISaveToThisFileClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkAVISaveToThisFile.IsChecked then
   begin
      VideoGrabber.RecordingFileName := edtRecordingFileName.Text;
   end
   else
   begin
      VideoGrabber.RecordingFileName := '';
   end;
end;

procedure TfrmMainForm.edtRecordingFileNameChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkAVISaveToThisFile.IsChecked then
   begin
      VideoGrabber.RecordingFileName := edtRecordingFileName.Text;
   end;
end;

procedure TfrmMainForm.chkAudioRecordingClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AudioRecording := chkAudioRecording.IsChecked;
   RefreshDeviceControls;
end;

procedure TfrmMainForm.grbRecordingTimerClick(Sender: TObject);
begin
   VideoGrabber.RecordingTimer := TRecordingTimer(grbRecordingTimer.ItemIndex);
   VideoGrabber.RecordingTimerInterval :=
     StrToIntDef(edtRecordingTimerInterval.Text, 0);
end;

procedure TfrmMainForm.edtRecordingTimerIntervalChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.RecordingTimerInterval :=
     StrToIntDef(edtRecordingTimerInterval.Text, 0);
end;

procedure TfrmMainForm.chkPreserveNativeFormatClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.RecordingInNativeFormat := chkPreserveNativeFormat.IsChecked;
end;

procedure TfrmMainForm.cboVideoCompressorsChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.VideoCompressor := cboVideoCompressors.ItemIndex;
end;

procedure TfrmMainForm.cboAudioCompressorsChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.AudioCompressor := cboAudioCompressors.ItemIndex;
end;

function GetRecordingMethodName(Value: TRecordingMethod): string;
begin
   case Value of
      rm_ASF:
         Result := 'rm_ASF';
      rm_SendToDV:
         Result := 'rm_sDV';
      rm_MKV:
         Result := 'rm_MKV';
      rm_FLV:
         Result := 'rm_FLV';
      rm_MP4:
         Result := 'rm_MP4';
      rm_MPG:
         Result := 'rm_MPG';
      rm_Multiplexer:
         Result := 'rm_Mux';
   else
      Result := 'rm_AVI';
   end;
end;

procedure TfrmMainForm.btnVideoCompressorSettingsClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog(dlg_VideoCompressor);
end;

procedure TfrmMainForm.btnAudioCompressorSettingsClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog(dlg_AudioCompressor);
end;

procedure TfrmMainForm.rdg1AspectRatioClick(Sender: TObject);
begin
   VideoGrabber.Display_AspectRatio := TAspectRatio (rdg1AspectRatio.ItemIndex);
   /// FireMonkey: aspect ratio applied by the TVideoGrabberFMX control (no pan-scan)
   case TAspectRatio (rdg1AspectRatio.ItemIndex) of
      ar_Stretch: FVideoFMX.DisplayMode := vdm_Stretch;
      ar_NoResize: FVideoFMX.DisplayMode := vdm_Center;
   else
      FVideoFMX.DisplayMode := vdm_Fit;
   end;
end;

procedure TfrmMainForm.rdg1stDisplayedOnClick(Sender: TObject);
begin
   VideoGrabber.Display_Monitor := rdg1stDisplayedOn.ItemIndex; // 0 or 1
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.rdg2AspectRatioClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_AspectRatio := TAspectRatio (rdg2AspectRatio.ItemIndex);
end;

procedure TfrmMainForm.rdg2ndDisplayedOnClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_Monitor := rdg2ndDisplayedOn.ItemIndex; // 0 or 1
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.rdgCompressModeClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := TCompressionMode(rdgCompressMode.ItemIndex);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.VideoGrabberRecordingReadyToStart(Sender: TObject);
begin
   if TDialogServiceSync.MessageDialog('Ready to start recording!', TMsgDlgType.mtInformation,
     [TMsgDlgBtn.mbOK, TMsgDlgBtn.mbCancel], TMsgDlgBtn.mbOK, 0) = mrOk then
   begin
      VideoGrabber.ResumeRecording;
   end
   else
   begin
      VideoGrabber.Stop;
   end;
end;

procedure TfrmMainForm.VideoGrabberRecordingStarted(Sender: TObject;
  FileName: String);
begin
   mmoLog.Lines.Add('recording to ' + FileName + ':');
   mmoLog.Lines.Add(IntToStr(VideoGrabber.RecordingWidth) + 'x' +
     IntToStr(VideoGrabber.RecordingHeight));
   mmoLog.Lines.Add('current frame rate: ' + FormatFloat('0.00',
     VideoGrabber.CurrentFrameRate) + ' fps.');
   FKBWritten_LastReportTime := 0;
end;

procedure TfrmMainForm.VideoGrabberReencodingProgress(Sender: TObject;
  Percent: LongInt; Position, Duration: LargeInteger);
begin
   mmoLog.Lines.Add(IntToStr(Percent) + '% completed...');
end;

procedure TfrmMainForm.VideoGrabberRecordingPaused(Sender: TObject);
begin
   mmoLog.Lines.Add('recording paused...');
end;

procedure TfrmMainForm.VideoGrabberRecordingCompleted(Sender: TObject;
  FileName: String; Success: Boolean);
begin
   if Success then
   begin
      mmoLog.Lines.Add(FileName + ' successfully created.');
      mmoLog.Lines.Add('size: ' +
        IntToStr(VideoGrabber.RecordingKBytesWrittenToDisk) + ' KB');
   end
   else
   begin
      mmoLog.Lines.Add('recording failed.');
   end;
end;

procedure TfrmMainForm.VideoGrabberReencodingStarted(Sender: TObject;
  SourceFile, DestFile: String);
begin
   mmoLog.Lines.Add('reencoding ' + SourceFile + ' to ' + DestFile + '...');
end;

procedure TfrmMainForm.VideoGrabberReencodingCompleted(Sender: TObject;
  SourceFile, DestFile: String; Success: Boolean);
begin
   if Success then
   begin
      mmoLog.Lines.Add(SourceFile + ' successfully reencoded to ' + DestFile);
   end
   else
   begin
      mmoLog.Lines.Add('Failed to reencode ' + SourceFile + ' to ' + DestFile);
   end;
end;

/// /////////////////////////////////////////////////////////////////////////////
// FRAME GRABBER TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.rgdFrameGrabberClick(Sender: TObject);
begin
   VideoGrabber.FrameGrabber := TFrameGrabber(rgdFrameGrabber.ItemIndex);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.rgdFrameGrabberFormatClick(Sender: TObject);
begin
   VideoGrabber.FrameGrabberRGBFormat :=
     TFrameGrabberRGBFormat(rgdFrameGrabberFormat.ItemIndex);
end;

procedure TfrmMainForm.edt1sttranspColorChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_TransparentColorValue := StrToIntDef ('$' + edt1stTranspColor.Text, 0);
end;

procedure TfrmMainForm.edt2ndTranspColorChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_TransparentColorValue := StrToIntDef ('$' + edt2ndTranspColor.Text, 0);
end;

procedure TfrmMainForm.edtAVIAutoFilePrefixChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AutoFilePrefix := edtAVIAutoFilePrefix.Text;
end;

procedure TfrmMainForm.btnOneShotTBitmapClick(Sender: TObject);
begin
   VideoGrabber.CaptureFrameTo(fc_TBitmap, '');
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotBMPFileClick(Sender: TObject);
begin
   if chkUseThisFileName.IsChecked then
   begin
      VideoGrabber.CaptureFrameTo(fc_BmpFile, edtUseThisFileName.Text);
   end
   else
   begin
      VideoGrabber.CaptureFrameTo(fc_BmpFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotJPEGFileClick(Sender: TObject);
begin
   if chkUseThisFileName.IsChecked then
   begin
      VideoGrabber.CaptureFrameTo(fc_JpegFile, edtUseThisFileName.Text);
   end
   else
   begin
      VideoGrabber.CaptureFrameTo(fc_JpegFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotPngFileClick(Sender: TObject);
begin
   if chkUseThisFileName.IsChecked then
   begin
      VideoGrabber.CaptureFrameTo(fc_PngFile, edtUseThisFileName.Text);
   end
   else
   begin
      VideoGrabber.CaptureFrameTo(fc_PngFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.BtnOneShotTiffFileClick(Sender: TObject);
begin
   if chkUseThisFileName.IsChecked then
   begin
      VideoGrabber.CaptureFrameTo(fc_TiffFile, edtUseThisFileName.Text);
   end
   else
   begin
      VideoGrabber.CaptureFrameTo(fc_TiffFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotClipboardClick(Sender: TObject);
begin
   VideoGrabber.CaptureFrameTo(fc_Clipboard, '');
end;

procedure TfrmMainForm.chkUseThisFileNameClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   edtUseThisFileName.Enabled := chkUseThisFileName.IsChecked;
end;

procedure TfrmMainForm.btnBurstModeTBitmapClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_TBitmap;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // Captured frames will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeBMPFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_BmpFile;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // BMP file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeJPEGFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_JpegFile;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // JPEG file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeClipboardClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_Clipboard;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
end;

procedure TfrmMainForm.btnBurstModePNGFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_PngFile;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // JPEG file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeTIFFFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_TiffFile;
   VideoGrabber.BurstMode := true;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // JPEG file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeStopClick(Sender: TObject);
begin
   VideoGrabber.BurstMode := False;
end;

procedure TfrmMainForm.edtBurstCountChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.BurstCount := StrToIntDef(edtBurstCount.Text, 1);
end;

procedure TfrmMainForm.chkModuloClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkModulo.IsChecked then
   begin
      VideoGrabber.AutoFileName := fn_Modulo;
   end;
end;

procedure TfrmMainForm.edtBurstIntervalChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.BurstInterval := StrToIntDef(edtBurstInterval.Text, 1);
end;

procedure TfrmMainForm.tbrCaptureZoomSizeChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.FrameCaptureZoomSize := Round(tbrCaptureZoomSize.Value);
   edtCaptureZoomSize.Text := IntToStr(Round(tbrCaptureZoomSize.Value)) + '%';
end;

procedure TfrmMainForm.btnResetCaptureZoomSizeClick(Sender: TObject);
begin
   tbrCaptureZoomSize.Value := 100;
end;

procedure TfrmMainForm.edtFrameCaptureWidthChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.FrameCaptureWidth := StrToIntDef(edtFrameCaptureWidth.Text, -1);
end;

procedure TfrmMainForm.edtFrameCaptureHeightChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.FrameCaptureHeight :=
     StrToIntDef(edtFrameCaptureHeight.Text, -1);
end;

procedure TfrmMainForm.VideoGrabberFrameProgress2(Sender: TObject;
  FrameInfo: pFrameInfo);
var
   KbWritten: DWORD;
   FrameCountText: string;
   KbWrittenText: string;
   NTPText: string;
   IsPlayback: Boolean;
   FrameTimeMs: Single;
begin
   KbWrittenText := '';
   NTPText := '';
   with FrameInfo^ do
   begin
      IsPlayback := CurrentState = cs_Playback;
      if IsPlayback then
      begin // no dropped frames in playback mode
         FrameCountText := Format('frame: %d time:%.2d:%.2d:%.2d %.2d',
           [FrameNumber, FrameTime_Hour, FrameTime_Min, FrameTime_Sec,
           FrameTime_Hs]);
      end
      else
      begin
         FrameCountText :=
           Format('frame: %d dropped: %d time:%.2d:%.2d:%.2d %.2d',
           [FrameNumber, DroppedFrameCount, FrameTime_Hour, FrameTime_Min,
           FrameTime_Sec, FrameTime_Hs]);
      end;
      FrameTimeMs := FrameTime / 10000;

      if VideoGrabber.CurrentState = cs_Recording then
      begin
         if (FrameTime - FKBWritten_LastReportTime) > 50000000 then
         begin // 5 seconds
            FKBWritten_LastReportTime := FrameTime;
            KbWritten := VideoGrabber.RecordingKBytesWrittenToDisk;
            if KbWritten > 0 then
            begin
               KbWrittenText := 'written to disk: ' + IntToStr(KbWritten) + ' KB';
            end;
         end;
      end;
      if FrameInfo^.NTPFrameTime > 0 then
      begin
         NTPText := 'ntp: ' + IntToStr(FrameInfo^.NTPFrameTime);
      end;
   end;

   /// FireMonkey: FMX controls must only be accessed from the main thread
   RunInMainThread(
      procedure
      begin
         edtFrameCount.Text := FrameCountText;
         if KbWrittenText <> '' then
         begin
            mmoLog.Lines.Add(KbWrittenText);
         end;
         if NTPText <> '' then
         begin
            edtIPCameraNTPTime.Text := NTPText;
         end;
         if IsPlayback then
         begin
            UpdatePlayerTrackBar(FrameTimeMs);
         end;
      end);
end;

procedure CopyFrameToBitmapDemo(BitmapInfo: pFrameBitmapInfo);
var
   NewBitmap: Vcl.Graphics.TBitmap;
begin
   // this code shows how to make a copy of the current video frame to an Image, invoke it from the OnFrameBitmap event below

   NewBitmap := Vcl.Graphics.TBitmap.Create;
   NewBitmap.Canvas.Lock;
   NewBitmap.Width := BitmapInfo^.BitmapWidth;
   NewBitmap.Height := BitmapInfo^.BitmapHeight;
   case BitmapInfo^.BitmapBitsPerPixel of
      32:
         NewBitmap.PixelFormat := pf32Bit;
      24:
         NewBitmap.PixelFormat := pf24Bit;
      16:
         NewBitmap.PixelFormat := pf16Bit;
      15:
         NewBitmap.PixelFormat := pf15Bit;
      8:
         NewBitmap.PixelFormat := pf8Bit;
   else
      NewBitmap.PixelFormat := pf24Bit;
   end;
   BitBlt(NewBitmap.Canvas.Handle, 0, 0, BitmapInfo^.BitmapWidth,
     BitmapInfo^.BitmapHeight, BitmapInfo^.BitmapDC, 0, 0, SRCCOPY);
   NewBitmap.Canvas.Unlock;
   NewBitmap.SaveToFile('c:\myfolder\myframecapture.bmp');
   NewBitmap.Free;
end;

procedure DrawCircle(Canvas: Vcl.Graphics.TCanvas; xCenter, yCenter, Radius: LongInt);
var
   xCenterAndRadius: LongInt;
begin
   xCenterAndRadius := xCenter + Radius;
   Canvas.Arc(xCenter - Radius, yCenter - Radius, xCenterAndRadius,
     yCenter + Radius, xCenterAndRadius, xCenter, xCenterAndRadius, xCenter);
end;

procedure TfrmMainForm.VideoGrabberFrameBitmap(Sender: TObject;
  FrameInfo: pFrameInfo; BitmapInfo: pFrameBitmapInfo);
type
   pTRGB24Array = ^TRGB24Array;
   TRGB24Array = array [0 .. 65535] of TRGBTriple;

   pTRGB32Array = ^TRGB32Array;
   TRGB32Array = array [0 .. 65535] of TRGBQuad;
var
   i, iCol: Integer;
   Canvas: Vcl.Graphics.TCanvas;
   NewVideoSignalState: Boolean;
   xStep, yStep, xLocation, yLocation: LongInt;
   BitmapLinePtr: PBYTE;
   RGB32Line: pTRGB32Array;
   RGB24Line: pTRGB24Array;
   TargetRadius: LongInt;
begin
   // From this event you should not perform any actions with the potential to block:
   // 1. do not hold a critical section or wait on another thread,
   // 2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
   // 3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
   // of a ListBox component. If you need to read a such property, set an intermediary variable when
   // the property changes, and then read the intermediary variable from this event.

   // -----------------------------------------------------------
   // CopyFrameToBitmapDemo (BitmapInfo); // CopyFrameToBitmapDemo shows how to make a copy of the current video frame, just uncomment this line to use it
   // -----------------------------------------------------------

   with BitmapInfo^ do
   begin

      // DRAWS A TARGET AT THE MOUSE LOCATION
      // ====================================

      if chkDrawTarget.IsChecked then
      begin
         /// FireMonkey: the last click is tracked by VideoDisplayMouseDown (the VCL window is hidden)
         if FLastVideoClickLeft then
         begin
            Canvas := Vcl.Graphics.TCanvas.Create;
            Canvas.Handle := BitmapDC;
            Canvas.Pen.Color := clRed;
            TargetRadius := 50;
            DrawCircle(Canvas, FLastVideoClick.X, FLastVideoClick.Y,
              TargetRadius);
            Canvas.MoveTo(FLastVideoClick.X - TargetRadius,
              FLastVideoClick.Y);
            Canvas.LineTo(FLastVideoClick.X + TargetRadius,
              FLastVideoClick.Y);
            Canvas.MoveTo(FLastVideoClick.X, FLastVideoClick.Y -
              TargetRadius);
            Canvas.LineTo(FLastVideoClick.X, FLastVideoClick.Y +
              TargetRadius);
            Canvas.Free;
         end;
      end;

      // DIRECT ACCESS TO THE RGB PIXELS
      // ===============================

      if chkChangePixels.IsChecked then
      begin
         BitmapLinePtr := BitmapDataPtr;

         if BitmapBitsPerPixel = 24 then
         begin // case where FrameGrabberRGBFormat is set to fgf_RGB24 (you can select it in the "frame grabber" tab)
            for i := 0 to BitmapHeight - 1 do
            begin
               RGB24Line := pTRGB24Array(BitmapLinePtr);
               for iCol := 0 to BitmapWidth - 1 do
               begin
                  RGB24Line[iCol].rgbtGreen := 0;
                  // e.g. we remove the green color -> purple image
               end;
               inc(BitmapLinePtr, BitmapLineSize);
            end;
         end
         else if BitmapBitsPerPixel = 32 then
         begin // case where FrameGrabberRGBFormat is set to fgf_RGB32 (default setting) (you can select it in the "frame grabber" tab)
            for i := 0 to BitmapHeight - 1 do
            begin
               RGB32Line := pTRGB32Array(BitmapLinePtr);
               for iCol := 0 to BitmapWidth - 1 do
               begin
                  RGB32Line[iCol].rgbBlue := 0;
                  // e.g. we remove the blue color -> yellow image
               end;
               inc(BitmapLinePtr, BitmapLineSize);
            end;
         end;
      end;

      // GRID DRAWING BY USING THE CANVAS DC AND FILLRECT
      // ================================================

      if chkDrawGridOverFrames.IsChecked then
      begin

         xStep := BitmapWidth div 10;
         yStep := BitmapHeight div 10;

         xLocation := xStep;
         yLocation := yStep;

         Canvas := Vcl.Graphics.TCanvas.Create;
         Canvas.Brush.Color := clBlue;
         Canvas.Brush.Style := bsSolid;
         Canvas.Handle := BitmapDC;

         while xLocation < BitmapWidth do
         begin
            Canvas.FillRect(Rect(xLocation, 0, xLocation + 1, BitmapHeight));
            inc(xLocation, xStep);
         end;

         while yLocation < BitmapHeight do
         begin
            Canvas.FillRect(Rect(0, yLocation, BitmapWidth, yLocation + 1));
            inc(yLocation, yStep);
         end;

         Canvas.Free;
      end;

      // FREE HAND DRANWING BY USING THE CANVAS DC AND LINETO / MOVETO
      // =============================================================

      if FiFreeHandMouseDrawing > 0 then
      begin // see VideoGrabberMouseMove event below
         Canvas := Vcl.Graphics.TCanvas.Create;
         Canvas.Handle := BitmapDC;
         Canvas.Pen.Color := clRed;
         for i := 0 to FiFreeHandMouseDrawing - 1 do
         begin
            if FFreeHandMouseDrawing[i].Right = 0 then
            begin // Right is used as boolean to know if it is a MoveTo or a LineTo
               Canvas.MoveTo(FFreeHandMouseDrawing[i].Left,
                 FFreeHandMouseDrawing[i].Top);
               Canvas.Pixels[FFreeHandMouseDrawing[i].Left,
                 FFreeHandMouseDrawing[i].Top] := clRed;
            end
            else
            begin
               Canvas.LineTo(FFreeHandMouseDrawing[i].Left,
                 FFreeHandMouseDrawing[i].Top);
            end;
         end;
         Canvas.Free;
      end;

      // VIDEO SIGNAL DETECTION
      // ======================

      if rdgDetectVideoSignal.ItemIndex > 0 then
      begin
         NewVideoSignalState := False;
         if rdgDetectVideoSignal.ItemIndex = 1 then
         begin // no video signal (dark screen)
            NewVideoSignalState := VideoGrabber.IsVideoSignalDetected(False,
              true, 30, 30, 30, true);
         end
         else if rdgDetectVideoSignal.ItemIndex = 2 then
         begin // Connexant blue screen (no signal)
            NewVideoSignalState := VideoGrabber.IsVideoSignalDetected(true,
              False, 0, 0, 0, False);
         end;
         if NewVideoSignalState <> FOldVideoSignalState then
         begin
            FOldVideoSignalState := NewVideoSignalState;
            // memorize the new state
            if NewVideoSignalState then
            begin
               LogFromAnyThread('Video signal is back');
            end
            else
            begin
               LogFromAnyThread('VIDEO SIGNAL LOST');
            end;
         end;
      end;
   end;
end;

procedure TfrmMainForm.VideoGrabberFrameCaptureCompleted(Sender: TObject;
  FrameBitmap: Vcl.Graphics.TBitmap; BitmapWidth, BitmapHeight: LongInt;
  FrameNumber: LongWord; FrameTime: LargeInteger; DestType: TFrameCaptureDest;
  FileName: string; Success: Boolean; FrameId: LongInt);
var
   DestForm: TForm;
   DestImage: TImage;
   FmxBitmap: FMX.Graphics.TBitmap;
begin
   if Success then
   begin
      mmoFrameCaptureLog.Lines.Add('frame #' + IntToStr(FrameNumber) +
        ' captured');
   end;
   Case DestType of
      fc_BmpFile, fc_JpegFile:
         begin
            if Success then
            begin
               mmoFrameCaptureLog.Lines.Add(FileName);
            end
            else
            begin
               mmoFrameCaptureLog.Lines.Add('error: failed to create ' +
                 FileName);
            end;
         end;

      fc_TBitmap:
         begin
            if VideoGrabber.CanProcessMessages then
            begin // to prevent crash in synchrone mode (mainly when Player is playing and UseClock is disabled)
               if (not VideoGrabber.BurstMode) or
                 (VideoGrabber.BurstMode and (VideoGrabber.BurstCount = 0)) then
               begin // reuse the same form
                  if not assigned(FSnapForm) then
                  begin
                     FSnapForm := TForm.CreateNew(Self);
                     FSnapForm.Position := TFormPosition.Default;
                     FSnapForm.FormStyle := TFormStyle.StayOnTop;
                  end;
                  if not assigned(FSnapImage) then
                  begin
                     FSnapImage := TImage.Create(FSnapForm);
                     FSnapImage.Parent := FSnapForm;
                     FSnapImage.Align := TAlignLayout.Client;
                     FSnapImage.WrapMode := TImageWrapMode.Original;
                  end;
                  DestForm := FSnapForm;
                  DestImage := FSnapImage;
               end
               else
               begin
                  DestForm := TForm.CreateNew(Self);
                  DestForm.Position := TFormPosition.Default;
                  DestForm.FormStyle := TFormStyle.StayOnTop;
                  DestImage := TImage.Create(DestForm);
                  DestImage.Parent := DestForm;
                  DestImage.Align := TAlignLayout.Client;
                  DestImage.WrapMode := TImageWrapMode.Original;
               end;

               DestForm.ClientWidth := BitmapWidth;
               DestForm.ClientHeight := BitmapHeight;

               /// FireMonkey: the captured frame is a VCL TBitmap, converted to an FMX bitmap
               FmxBitmap := FMX.Graphics.TBitmap.Create;
               try
                  VclBitmapToFmx(FrameBitmap, FmxBitmap);
                  DestImage.Bitmap.Assign(FmxBitmap);
               finally
                  FmxBitmap.Free;
               end;

               if not DestForm.Visible then
               begin
                  DestForm.Show;
               end;
            end;
         end;
   end;
end;

/// /////////////////////////////////////////////////////////////////////////////
// PLAYER TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnPlayerOpenFileClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES_EXTENDED;
   if OpenDlg.Execute then
   begin
      edtPlayerClip.Text := OpenDlg.FileName;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnOpenLastClipRecordedClick(Sender: TObject);
begin
   if VideoGrabber.Last_Recording_FileName <> '' then
   begin
      edtPlayerClip.Text := VideoGrabber.Last_Recording_FileName;
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayer;
   end;
end;

procedure TfrmMainForm.btnOpenLastClipPlayedClick(Sender: TObject);
begin
   if VideoGrabber.Last_Clip_Played <> '' then
   begin
      edtPlayerClip.Text := VideoGrabber.Last_Clip_Played;
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayer;
   end;
end;

procedure TfrmMainForm.btnGetClipDurationClick(Sender: TObject);
var
   Duration: int64;
   FrameCount: int64;
begin
   if VideoGrabber.AVIDuration(edtPlayerClip.Text, Duration, FrameCount) then
   begin
      mmoLog.Lines.Add('Duration: ' + IntToStr(Duration));
      mmoLog.Lines.Add('Frame count: ' + IntToStr(FrameCount));
   end
   else
   begin
      mmoLog.Lines.Add('failed to get info for this clip');
   end;
end;

procedure TfrmMainForm.rgdHwAccelClick(Sender: TObject);
begin
   VideoGrabber.PlayerHWAccel := THWAccel(rgdHwAccel.ItemIndex);
end;

procedure TfrmMainForm.btnGeneralInfoClick(Sender: TObject);
var
   Duration: int64;
   FrameCount: int64;
   VideoWidth: LongInt;
   VideoHeight: LongInt;
   VideoCodec: string;
   AudioCodec: string;
   VideoFrameRateFps: Double;
   AvgBitRate: LongInt;
   AudioChannels: LongInt;
   AudioSamplesPerSec: LongInt;
   AudioBitsPerSample: LongInt;
begin
   if VideoGrabber.AVIInfo(edtPlayerClip.Text, Duration, FrameCount, VideoWidth,
     VideoHeight, VideoFrameRateFps, AvgBitRate, AudioChannels,
     AudioSamplesPerSec, AudioBitsPerSample, VideoCodec, AudioCodec) then
   begin
      mmoLog.Lines.Add('');
      mmoLog.Lines.Add(edtPlayerClip.Text + ':');
      mmoLog.Lines.Add('duration (in sec): ' + FormatFloat('0.00',
        Duration / 10000000));
      mmoLog.Lines.Add('frame count: ' + IntToStr(FrameCount));
      mmoLog.Lines.Add('video source width: ' + IntToStr(VideoWidth));
      mmoLog.Lines.Add('video source height: ' + IntToStr(VideoHeight));
      mmoLog.Lines.Add('video frame rate (fps): ' + FormatFloat('0.00',
        VideoFrameRateFps));
      mmoLog.Lines.Add('average bit rate (kb/s): ' +
        IntToStr(AvgBitRate div 1024));
      mmoLog.Lines.Add('audio channels: ' + IntToStr(AudioChannels));
      mmoLog.Lines.Add('audio samples/sec: ' + IntToStr(AudioSamplesPerSec));
      mmoLog.Lines.Add('audio bits per sample: ' +
        IntToStr(AudioBitsPerSample));
      mmoLog.Lines.Add('video codec: ' + VideoCodec);
      mmoLog.Lines.Add('audio codec: ' + AudioCodec);
   end
   else
   begin
      mmoLog.Lines.Add(edtPlayerClip.Text + ' clip not found.');
   end;
end;

procedure TfrmMainForm.btnHeaderInfoClick(Sender: TObject);
begin
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add(edtPlayerClip.Text + ' headers:');
   mmoLog.Lines.Add('Title: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text,
     ha_Title));
   mmoLog.Lines.Add('Description: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Description));
   mmoLog.Lines.Add('Author: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text,
     ha_Author));
   mmoLog.Lines.Add('Copyright: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Copyright));
   mmoLog.Lines.Add('Album Artist: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_AlbumArtist));
   mmoLog.Lines.Add('Album Title: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_AlbumTitle));
   mmoLog.Lines.Add('Composer: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Composer));
   mmoLog.Lines.Add('Content Distributor: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_ContentDistributor));
   mmoLog.Lines.Add('Director: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Director));
   mmoLog.Lines.Add('Encoding Time: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_EncodingTime));
   mmoLog.Lines.Add('Genre: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text,
     ha_Genre));
   mmoLog.Lines.Add('Language: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Language));
   mmoLog.Lines.Add('Parental Rating: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_ParentalRating));
   mmoLog.Lines.Add('Producer: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Producer));
   mmoLog.Lines.Add('Provider: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_Provider));
   mmoLog.Lines.Add('ToolName: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_ToolName));
   mmoLog.Lines.Add('Tool Version: ' + VideoGrabber.AVIHeaderInfo
     (edtPlayerClip.Text, ha_ToolVersion));
   mmoLog.Lines.Add('Writer: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text,
     ha_Writer));
end;

procedure TfrmMainForm.btnOpenClipClick(Sender: TObject);
begin
   VideoGrabber.PlayerFileName := edtPlayerClip.Text;
   VideoGrabber.OpenPlayer;
end;

procedure TfrmMainForm.btnPlayerCloseClipClick(Sender: TObject);
begin
   VideoGrabber.ClosePlayer;
end;

procedure TfrmMainForm.btnPlayerPauseClick(Sender: TObject);
begin
   VideoGrabber.PausePlayer;
end;

procedure TfrmMainForm.btnPlayerStopClick(Sender: TObject);
begin
   VideoGrabber.StopPlayer;
end;

procedure TfrmMainForm.btnPlayerStartPlayingClick(Sender: TObject);
begin
   VideoGrabber.RunPlayer;
end;

procedure TfrmMainForm.btnPlayerFrameStepClick(Sender: TObject);
begin
   VideoGrabber.PlayerFrameStep(1);
end;

procedure TfrmMainForm.btnPlayerBackwardsClick(Sender: TObject);
begin
   VideoGrabber.RunPlayerBackwards;
end;

procedure TfrmMainForm.btnPlayerRewindClick(Sender: TObject);
begin
   VideoGrabber.RewindPlayer;
end;

procedure TfrmMainForm.btnPlayerFastForwardClick(Sender: TObject);
begin
   VideoGrabber.FastForwardPlayer;
end;

procedure TfrmMainForm.btnAutoPlayClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AutoStartPlayer := btnAutoPlay.IsChecked;
end;

procedure TfrmMainForm.chk1stAlphablendClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_AlphaBlendEnabled := chk1stAlphablend.IsChecked;
end;

procedure TfrmMainForm.chk1stAutoSizeClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_AutoSize := chk1stAutoSize.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stEmbeddedClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_Embedded := chk1stEmbedded.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stFullScreenClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_FullScreen := chk1stFullScreen.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stMouseMovesWindowClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_MouseMovesWindow := chk1stMouseMovesWindow.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stStayOnTopClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_StayOnTop := chk1stStayOnTop.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stTranspColorClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_TransparentColorEnabled := chk1stTranspColor.IsChecked;
end;

procedure TfrmMainForm.chk1stVideoWindowActiveClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Display_Active := chk1stVideoWindowActive.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stVisibleClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   /// FireMonkey: visibility of the TVideoGrabberFMX control (Display_Visible applies to the
   /// native video window)
   FVideoFMX.Visible := chk1stVisible.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndAlphaBlendClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_AlphaBlendEnabled := chk2ndAlphablend.IsChecked;
end;

procedure TfrmMainForm.chk2ndAutoSizeClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_AutoSize := chk2ndAutoSize.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndEmbeddedClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_Embedded := chk2ndEmbedded.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndFullScreenClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_FullScreen := chk2ndFullScreen.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndMouseMovesWindowClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_MouseMovesWindow := chk2ndMouseMovesWindow.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndStayOnTopClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_StayOnTop := chk2ndStayOnTop.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndTranspColorClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_TransparentColorEnabled := chk2ndTranspColor.IsChecked;
end;

procedure TfrmMainForm.chk2ndVideoWindowActiveClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_Active := chk2ndVideoWindowActive.IsChecked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndVisibleClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.DualDisplay_Visible := chk2ndVisible.IsChecked;
   RefreshDisplayOptions;

end;

procedure TfrmMainForm.chk360VideoDecodingClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.v360_Enabled := chk360VideoDecoding.IsChecked;
end;

procedure TfrmMainForm.tbrPlayerProgressChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   /// FireMonkey: the VideoGrabber.PlayerTrackBar property drives a VCL TTrackBar only. The FMX
   /// trackbar is updated from OnFrameProgress2 (UpdatePlayerTrackBar) and seeks the player here
   /// (when the thumb is released, or while dragging if "trackbar synchrone" is checked)
   if FUpdatingPlayerTrackBar then Exit;
   if VideoGrabber.CurrentState <> cs_Playback then Exit;
   VideoGrabber.PlayerTimePosition := Round(tbrPlayerProgress.Value) * Int64(10000);
end;

procedure TfrmMainForm.chkPlayerTrackbarSynchroneClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.PlayerTrackBarSynchrone := chkPlayerTrackbarSynchrone.IsChecked;
   /// FireMonkey: seek while dragging the thumb
   tbrPlayerProgress.Tracking := chkPlayerTrackbarSynchrone.IsChecked;
end;

procedure TfrmMainForm.chkPlayerAudioRenderingClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.PlayerAudioRendering := chkPlayerAudioRendering.IsChecked;
end;

procedure TfrmMainForm.chkPlayerLoopClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   // the code is in the PlayerEndOfStream event
end;

procedure TfrmMainForm.chkUseClockClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.UseClock := chkUseClock.IsChecked;
end;

procedure TfrmMainForm.chkUseExternalAudioforRTSPClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkUseExternalAudioforRTSP.IsChecked then begin
      VideoGrabber.AudioSource := as_UseExternalAudio;
   end
   else begin
      VideoGrabber.AudioSource := as_Default;
   end;
end;

procedure TfrmMainForm.chkRefreshPausedDisplayClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.PlayerRefreshPausedDisplay := chkRefreshPausedDisplay.IsChecked;
end;

procedure TfrmMainForm.edtPlayerSpeedRatioChange(Sender: TObject);
var
   OldSpeedRatio: Double;
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   OldSpeedRatio := VideoGrabber.PlayerSpeedRatio;
   VideoGrabber.PlayerSpeedRatio :=
     StrToFloatDef(edtPlayerSpeedRatio.Text, 1.0);
   if VideoGrabber.PlayerSpeedRatio <> OldSpeedRatio then
   begin
      mmoLog.Lines.Add('player speed ratio selected: ' + FormatFloat('0.0',
        VideoGrabber.PlayerSpeedRatio));
   end;
end;

procedure TfrmMainForm.updPlayerFastSeekSpeedClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabber.PlayerFastSeekSpeedRatio := updPlayerFastSeekSpeed.Position;
   edtPlayerFastSeekSpeed.Text :=
     IntToStr(VideoGrabber.PlayerFastSeekSpeedRatio);
end;

procedure TfrmMainForm.VideoGrabberPlayerOpened(Sender: TObject);
begin
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add('playing ' + VideoGrabber.PlayerFileName);
   if VideoGrabber.IsPlayervideoStreamAvailable = ts_True then
   begin
      mmoLog.Lines.Add('this clip has a video stream');
   end
   else if VideoGrabber.IsPlayervideoStreamAvailable = ts_False then
   begin
      mmoLog.Lines.Add('this clip does not have video');
   end;
   if VideoGrabber.IsPlayerAudioStreamAvailable = ts_True then
   begin
      mmoLog.Lines.Add('this clip has an audio stream');
   end
   else if VideoGrabber.IsPlayerAudioStreamAvailable = ts_False then
   begin
      mmoLog.Lines.Add('this clip does not have audio');
   end;
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add('video codec: ' + VideoGrabber.PlayerVideoCodec);
   mmoLog.Lines.Add('audio codec: ' + VideoGrabber.PlayerAudioCodec);
   mmoLog.Lines.Add('');
   mmoLog.Lines.Add('Duration: ' + FormatFloat('0.00',
     VideoGrabber.PlayerDuration / 10000000));
   mmoLog.Lines.Add('Frame count: ' + IntToStr(VideoGrabber.PlayerFrameCount));
   mmoLog.Lines.Add('Frame rate: ' + FormatFloat('0.00',
     VideoGrabber.PlayerFrameRate));
   mmoLog.Lines.Add('video source size: ' + IntToStr(VideoGrabber.VideoWidth) +
     'x' + IntToStr(VideoGrabber.VideoHeight));
   mmoLog.Lines.Add('display aspect ratio: ' +
     IntToStr(VideoGrabber.VideoWidth_PreferredAspectRatio) + 'x' +
     IntToStr(VideoGrabber.VideoHeight_PreferredAspectRatio));

   if VideoGrabber.IsPlaylistActive then
   begin
      lstPlaylist.ItemIndex := VideoGrabber.PlaylistIndex;
   end;
   UpdatePlayerTrackBar(0);
end;

procedure TfrmMainForm.VideoGrabberPlayerBufferingData(Sender: TObject;
  StartingToBuffer: Boolean);
begin
   if StartingToBuffer then
   begin
      mmoLog.Lines.Add('buffering data...');
   end
   else
   begin
      mmoLog.Lines.Add('buffering completed.');
   end;
end;

procedure TfrmMainForm.btnAddToPlaylistClick(Sender: TObject);
var
   i: LongInt;
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES_EXTENDED;
   OpenDlg.Options := [TOpenOption.ofAllowMultiSelect];
   if OpenDlg.Execute then
   begin
      for i := 0 to OpenDlg.Files.Count - 1 do
      begin
         VideoGrabber.Playlist(pl_Add, OpenDlg.Files[i]);
         lstPlaylist.Items.Add(OpenDlg.Files[i]);
      end;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnPlaylistPlayClick(Sender: TObject);
begin
   VideoGrabber.Playlist(pl_Play, '');
end;

procedure TfrmMainForm.btnPlaylistNextClick(Sender: TObject);
begin
   VideoGrabber.Playlist(pl_Next, '');
end;

procedure TfrmMainForm.btnPlaylistPreviousClick(Sender: TObject);
begin
   VideoGrabber.Playlist(pl_Previous, '');
end;

procedure TfrmMainForm.btnPlaylistStopClick(Sender: TObject);
begin
   VideoGrabber.Playlist(pl_Stop, '');
end;

procedure TfrmMainForm.btnClosePlaylistClick(Sender: TObject);
begin
   VideoGrabber.ClosePlayer;
end;

procedure TfrmMainForm.chkPlaylistLoopClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkPlaylistLoop.IsChecked then
   begin
      VideoGrabber.Playlist(pl_Loop, '');
   end
   else
   begin
      VideoGrabber.Playlist(pl_NoLoop, '');
   end;
end;

procedure TfrmMainForm.chkPlaylistRandomClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkPlaylistRandom.IsChecked then
   begin
      VideoGrabber.Playlist(pl_Random, '');
   end
   else
   begin
      VideoGrabber.Playlist(pl_Sequential, '');
   end;
end;

// begin ONVIF discovery

procedure TfrmMainForm.btnDiscoverONVIFFromIPRangeClick(Sender: TObject);
begin
   if lsbOnvifURLsDiscovered.Items.Count > 0 then begin
      lsbOnvifURLsDiscovered.Items.Clear();
   end;
	if VideoGrabber.ONVIFDiscoverCameras_IPrange(edtOnvifDiscoveryIPRange_FirstIP.Text, edtOnvifDiscoveryIPRange_LastIP.Text, StrToIntDef (edtDiscoveryTimeoutSeconds.Text, 0)) then begin
		 mmoLog.Lines.Add ('ONVIF discovery from IP range in progress...');
	end
	else begin
		 mmoLog.Lines.Add ('failed to start ONVIF discovery from IP range');
	end;
end;

procedure TfrmMainForm.btnDiscoverONVIFFromMulticastClick(Sender: TObject);
begin
   if lsbOnvifURLsDiscovered.Items.Count > 0 then begin
      lsbOnvifURLsDiscovered.Items.Clear();
   end;
	if VideoGrabber.ONVIFDiscoverCameras_Multicast(StrToIntDef (edtDiscoveryTimeoutSeconds.Text, 0)) then begin
		 mmoLog.Lines.Add ('ONVIF discovery from multicast in progress...');
	end
	else begin
		 mmoLog.Lines.Add ('failed to start ONVIF discovery from multicast');
	end;
end;

procedure TfrmMainForm.btnEG1stNewLocation2Click(Sender: TObject);
begin
   VideoGrabber.Display_AutoSize := False; // we will specify the size below
   VideoGrabber.Display_Embedded := False; // detach from component
   VideoGrabber.Display_SetLocation (20, 20, 640, 480); // Display_AutoSize=false, we can specify a size
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.btnEG2ndNewLocation2Click(Sender: TObject);
begin
   VideoGrabber.DualDisplay_AutoSize := False; // we will specify the size below
   VideoGrabber.DualDisplay_Embedded := False; // detach from component
   VideoGrabber.DualDisplay_SetLocation (30, 30, 640, 480); // DualDisplay_AutoSize=false, we can specify a size
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.lsbOnvifURLsDiscoveredClick(const Sender: TCustomListBox; const Item: TListBoxItem);
var
	CameraInfo: string;
	ServiceURL: String;
	OnvifURL: string;
	pURL: LongInt;
begin
	CameraInfo := Item.Text;
	pURL := pos ('] ', CameraInfo);
	if pURL > 0 then begin
		ServiceURL := copy (CameraInfo, pURL + 2, MAXINT);
		if ServiceURL <> '' then begin
			OnvifURL := VideoGrabber.GetONVIFURLFromServiceURL (ServiceURL);
			if OnvifURL <> '' then begin
				edtIPCameraURL.Text := ONVIFUrl;
			end;
		end;
	end;
end;

// end ONVIF discovery

procedure TfrmMainForm.lstPlaylistClick(const Sender: TCustomListBox; const Item: TListBoxItem);
begin
   VideoGrabber.PlaylistIndex := lstPlaylist.ItemIndex;
   VideoGrabber.Playlist(pl_Play, '');
end;

procedure TfrmMainForm.VideoGrabberPlayerEndOfStream(Sender: TObject);
begin
   mmoLog.Lines.Add('end of stream.');
   if chkPlayerLoop.IsChecked then
   begin
      VideoGrabber.RunPlayer;
   end;
end;

procedure TfrmMainForm.VideoGrabberPlayerEndOfPlaylist(Sender: TObject);
begin
   mmoLog.Lines.Add('END OF PLAYLIST.');
end;

procedure TfrmMainForm.btnViewDirectNetworkStreamingClick(Sender: TObject);
begin
   if VideoGrabber.StreamingURL <> '' then
   begin
      ShellExecute(0, 'open', PChar(VideoGrabber.StreamingURL), '', '',
        SW_SHOW);
   end;
end;

procedure TfrmMainForm.VideoGrabberClientConnection(Sender: TObject;
  Connected: Boolean; ClientInfo: String);
begin
end;

/// /////////////////////////////////////////////////////////////////////////////
// FRAME OVERLAY TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.chkTextOverlayEnabledClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_Enabled(FTextOverlayIndex,
     chkTextOverlayEnabled.IsChecked);
   if chkTextOverlayEnabled.IsChecked then
   begin
      SetControlFontColor(chkTextOverlayEnabled, TAlphaColors.Black);
   end
   else
   begin
      SetControlFontColor(chkTextOverlayEnabled, TAlphaColors.Red);
   end;
end;

procedure TfrmMainForm.chkTextOverlayHighResFontClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_HighResFont(FTextOverlayIndex,
     chkTextOverlayHighResFont.IsChecked);
end;

procedure TfrmMainForm.edtTextOverlayTargetDisplayChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_TargetDisplay(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayTargetDisplay.Text, 0));
end;

procedure TfrmMainForm.chkTextOverlayScrollingClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_Scrolling(FTextOverlayIndex,
     chkTextOverlayScrolling.IsChecked);
end;

procedure TfrmMainForm.edtTextOverlayScrollingSpeedChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_ScrollingSpeed(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayScrollingSpeed.Text, 0));
end;

procedure TfrmMainForm.btnTestPanScanClick(Sender: TObject);
begin
   /// FireMonkey: the pan-scan aspect ratio applies to the native video windows
   ShowMessage('pan-scan applies to the native video windows, not available with TVideoGrabberFMX');
end;

procedure TfrmMainForm.btnTextOverlayColorClick(Sender: TObject);
var
   Color: TColor;
begin
   /// FireMonkey has no color dialog: Windows ChooseColor, see FmxDemoHelpers.PickColor
   Color := VideoGrabber.GetTextOverlay_Font(FTextOverlayIndex).Color;
   if PickColor(Self, Color) then
   begin
      VideoGrabber.GetTextOverlay_Font(FTextOverlayIndex).Color := Color;
   end;
end;

procedure TfrmMainForm.btnBkgndColorClick(Sender: TObject);
var
   Color: TColor;
begin
   Color := VideoGrabber.GetTextOverlay_BkColor(FTextOverlayIndex);
   if PickColor(Self, Color) then
   begin
      VideoGrabber.SetTextOverlay_BkColor(FTextOverlayIndex, Color);
   end;
end;

procedure TfrmMainForm.chkTextOverlayTransparentClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_Transparent(FTextOverlayIndex,
     chkTextOverlayTransparent.IsChecked);
end;

procedure TfrmMainForm.updTextOverlaySizeClick(Sender: TObject;
  Button: TUDBtnType);
var
   OldSize: LongInt;
begin
   OldSize := VideoGrabber.GetTextOverlay_Font(FTextOverlayIndex).Size;
   case Button of
      btPrev:
         VideoGrabber.GetTextOverlay_Font(FTextOverlayIndex).Size :=
           OldSize - 1;
      btNext:
         VideoGrabber.GetTextOverlay_Font(FTextOverlayIndex).Size :=
           OldSize + 1;
   end;
end;

procedure TfrmMainForm.chkTextOverlayShadowClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_Shadow(FTextOverlayIndex,
     chkTextOverlayShadow.IsChecked);
end;

procedure TfrmMainForm.chkOverlayOrientationClick(Sender: TObject);
begin
   case chkOverlayOrientation.ItemIndex of
      0:
         VideoGrabber.SetTextOverlay_Orientation(FTextOverlayIndex,
           to_Horizontal);
      1:
         VideoGrabber.SetTextOverlay_Orientation(FTextOverlayIndex,
           to_Vertical);
      2:
         VideoGrabber.SetTextOverlay_Orientation(FTextOverlayIndex,
           to_VerticalInverted);
   end;
end;

procedure TfrmMainForm.chkAdjustOverlayAspectRatioClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AdjustOverlayAspectRatio := chkAdjustOverlayAspectRatio.IsChecked;
end;

procedure TfrmMainForm.rdgTextOverlayAlignClick(Sender: TObject);
begin
   VideoGrabber.SetTextOverlay_Align(FTextOverlayIndex,
     TTextOverlayAlign(rdgTextOverlayAlign.ItemIndex));
end;

procedure TfrmMainForm.chkTextOverlayAlphablendClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_AlphaBlend(FTextOverlayIndex,
     chkTextOverlayAlphablend.IsChecked);
end;

procedure TfrmMainForm.tbrTextOverlayAlphablendValueChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_AlphaBlendValue(FTextOverlayIndex,
     Round(tbrTextOverlayAlphablendValue.Value));
end;

procedure TfrmMainForm.chkTextOverlayProportionalClick(Sender: TObject);
/// font size, left, top, right and scrolling speed of the selected text overlay scaled to the video height
/// (values given for 1080 lines), see SetTextOverlay_Proportional
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_Proportional(FTextOverlayIndex,
     chkTextOverlayProportional.IsChecked);
end;

procedure TfrmMainForm.mmoTextOverlayStringChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_String(FTextOverlayIndex,
     mmoTextOverlayString.Text);
end;

procedure TfrmMainForm.edtTextOverlayLeftChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_Left(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayLeft.Text, 0));
end;

procedure TfrmMainForm.edtTextOverlayTopChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_Top(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayTop.Text, 0));
end;

procedure TfrmMainForm.edtTextOverlayRightChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetTextOverlay_Right(FTextOverlayIndex,
     StrToIntDef(edtTextOverlayRight.Text, 0));
end;

procedure TfrmMainForm.rdgTextOverlaySelectorClick(Sender: TObject);
begin
   FTextOverlayIndex := rdgTextOverlaySelector.ItemIndex;

   // as we have selected another set, let's reload the corresponding values
   chkTextOverlayEnabled.IsChecked := VideoGrabber.GetTextOverlay_Enabled
     (FTextOverlayIndex);
   chkTextOverlayHighResFont.IsChecked := VideoGrabber.GetTextOverlay_HighResFont
     (FTextOverlayIndex);
   edtTextOverlayTargetDisplay.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_TargetDisplay(FTextOverlayIndex));

   if not chkTextOverlayEnabled.IsChecked then
   begin
      SetControlFontColor(chkTextOverlayEnabled, TAlphaColors.Red);
   end
   else
   begin
      SetControlFontColor(chkTextOverlayEnabled, TAlphaColors.Black);
   end;
   mmoTextOverlayString.Text := VideoGrabber.GetTextOverlay_String
     (FTextOverlayIndex);
   edtTextOverlayLeft.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_Left(FTextOverlayIndex));
   edtTextOverlayTop.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_Top(FTextOverlayIndex));
   edtTextOverlayRight.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_Right(FTextOverlayIndex));
   rdgTextOverlayAlign.ItemIndex :=
     Integer(VideoGrabber.GetTextOverlay_Align(FTextOverlayIndex));
   chkTextOverlayScrolling.IsChecked := VideoGrabber.GetTextOverlay_Scrolling
     (FTextOverlayIndex);
   edtTextOverlayScrollingSpeed.Text :=
     IntToStr(VideoGrabber.GetTextOverlay_ScrollingSpeed(FTextOverlayIndex));
   chkTextOverlayTransparent.IsChecked := VideoGrabber.GetTextOverlay_Transparent
     (FTextOverlayIndex);
   chkTextOverlayShadow.IsChecked := VideoGrabber.GetTextOverlay_Shadow
     (FTextOverlayIndex);
   chkTextOverlayProportional.IsChecked := VideoGrabber.GetTextOverlay_Proportional
     (FTextOverlayIndex);
end;

procedure TfrmMainForm.WarnFrameBitmapOptionInNV12 (OptionEnabled: Boolean);
/// the options of the "FrameBitmap event drawing" group are drawn from the OnFrameBitmap event, which is not
/// raised while the frames are kept in NV12 (4K / 8K video with FrameGrabberRGBFormat = fgf_Default, or fgf_NV12).
begin
   if OptionEnabled and (VideoGrabber.FrameGrabberCurrentRGBFormat = fgf_NV12) then
   begin
      ShowMessage('This option is drawn from the OnFrameBitmap event, which is not raised while the frames are kept in NV12 (4K / 8K video with the "default" frame grabber format, or "NV12" selected).'
        + #13#10#13#10 + 'To use it, select "RGB32" in "frame grabber format" (frame grabber tab), then open the video again.');
   end;
end;

procedure TfrmMainForm.chkChangePixelsClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   // chkChangePixels.IsChecked is tested in the TfrmMainForm.VideoGrabberFrameBitmap event's code
   WarnFrameBitmapOptionInNV12(chkChangePixels.IsChecked);
end;

procedure TfrmMainForm.chkDrawGridOverFramesClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   // chkDrawTarget.IsChecked is tested in the TfrmMainForm.VideoGrabberFrameBitmap event's code
   if Sender = chkDrawTarget then /// handler shared by chkDrawGridOverFrames and chkDrawTarget
      WarnFrameBitmapOptionInNV12(chkDrawTarget.IsChecked)
   else
      WarnFrameBitmapOptionInNV12(chkDrawGridOverFrames.IsChecked);
end;

procedure TfrmMainForm.chkFreeHandEnabledClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   // chkFreeHandEnabled.IsChecked is tested in the TfrmMainForm.VideoGrabberFrameBitmap event's code
   WarnFrameBitmapOptionInNV12(chkFreeHandEnabled.IsChecked);
end;

procedure TfrmMainForm.btnFreeHandEraseClick(Sender: TObject);
begin
   FiFreeHandMouseDrawing := 0;
   VideoGrabber.RefreshPlayerOverlays;
end;

procedure TfrmMainForm.btnLoadImageOverlayFromFileClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_IMAGE_FILES;
   if OpenDlg.Execute then
   begin
      VideoGrabber.SetImageOverlayFromImageFile2(FImageOverlayIndex,
        OpenDlg.FileName);
   end;
   OpenDlg.Free;
end;

var
   PIPVideoGrabber: TVideoGrabber = nil;
   PIPMixIndex: LongInt = -1;

procedure TfrmMainForm.btnPIPFromAnotherTVideoGrabberClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES;
   if OpenDlg.Execute then
   begin
      if not assigned(PIPVideoGrabber) then
      begin
         PIPVideoGrabber := TVideoGrabber.Create(Self);
         PIPVideoGrabber.VideoRenderer := vr_None;
         PIPVideoGrabber.Visible := False;
         if PIPMixIndex > -1 then
         begin
            VideoGrabber.Mixer_RemoveFromMixer(PIPMixIndex);
         end;
         PIPMixIndex := VideoGrabber.Mixer_SetupPIPFromSource
           (PIPVideoGrabber.UniqueId, 0, 0, 0, 0, true, 10, 10, 200,
           150, False);
      end;
      PIPVideoGrabber.PlayerFileName := OpenDlg.FileName;
      PIPVideoGrabber.OpenPlayer();
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnPIPStopClick(Sender: TObject);
begin
   if PIPMixIndex > -1 then
   begin
      VideoGrabber.Mixer_RemoveFromMixer(PIPMixIndex);
      PIPMixIndex := -1;
   end;
end;

procedure TfrmMainForm.rdgImageOverlaySelectorClick(Sender: TObject);
begin
   FImageOverlayIndex := rdgImageOverlaySelector.ItemIndex;
   chkImageOverlayEnabled.IsChecked := VideoGrabber.GetImageOverlay_Enabled
     (FImageOverlayIndex);

   edtImageOverlayTargetDisplay.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_TargetDisplay(FImageOverlayIndex));

   edtImageOverlayLeft.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_LeftLocation(FImageOverlayIndex));
   edtImageOverlayTop.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_TopLocation(FImageOverlayIndex));
   edtImageOverlayWidth.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_Width(FImageOverlayIndex));
   edtImageOverlayHeight.Text :=
     IntToStr(VideoGrabber.GetImageOverlay_Height(FImageOverlayIndex));

   chkImageOverlayTransparent.IsChecked :=
     VideoGrabber.GetImageOverlay_Transparent(FImageOverlayIndex);
   chkImageOverlayUseTransparentColor.IsChecked :=
     VideoGrabber.GetImageOverlay_UseTransparentColor(FImageOverlayIndex);
   edtImageOverlayTransparentColorValue.Text :=
     Format('%.6X', [VideoGrabber.GetImageOverlay_TransparentColorValue
     (FImageOverlayIndex)]);

   chkImageOverlayAlphaBlend.IsChecked := VideoGrabber.GetImageOverlay_AlphaBlend
     (FImageOverlayIndex);
   chkImageOverlayAlphablendCoeff.Value :=
     VideoGrabber.GetImageOverlay_AlphaBlendValue(FImageOverlayIndex);

   chkImageOverlayChromaKey.IsChecked := VideoGrabber.GetImageOverlay_ChromaKey
     (FImageOverlayIndex);
   edtChromaKeyColorValue.Text :=
     Format('%.6X', [VideoGrabber.GetImageOverlay_ChromaKeyRGBColor
     (FImageOverlayIndex)]);
   edtChromaKeyLeewayPercent.Value :=
     VideoGrabber.GetImageOverlay_ChromaKeyLeewayPercent(FImageOverlayIndex);

end;

procedure TfrmMainForm.chkImageOverlayEnabledClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_Enabled(FImageOverlayIndex,
     chkImageOverlayEnabled.IsChecked);
end;

procedure TfrmMainForm.edtImageOverlayLeftChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_LeftLocation(FImageOverlayIndex,
     StrToIntDef(edtImageOverlayLeft.Text, 0));
end;

procedure TfrmMainForm.edtImageOverlayTopChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_TopLocation(FImageOverlayIndex,
     StrToIntDef(edtImageOverlayTop.Text, 0));
end;

procedure TfrmMainForm.edtImageOverlayWidthChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_Width(FImageOverlayIndex,
     StrToIntDef(edtImageOverlayWidth.Text, -1));
end;

procedure TfrmMainForm.edtImageOverlayHeightChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_Height(FImageOverlayIndex,
     StrToIntDef(edtImageOverlayHeight.Text, -1));
end;

procedure TfrmMainForm.chkImageOverlayTransparentClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_Transparent(FImageOverlayIndex,
     chkImageOverlayTransparent.IsChecked);
end;

procedure TfrmMainForm.edtImageOverlayTargetDisplayChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_TargetDisplay(FTextOverlayIndex,
     StrToIntDef(edtImageOverlayTargetDisplay.Text, 0));
end;

procedure TfrmMainForm.btnImageOverlayPickupColorClick(Sender: TObject);
var
   LastClickRGBValue: DWORD;
begin
   /// FireMonkey: last click tracked by VideoDisplayMouseDown, in video frame coordinates
   LastClickRGBValue := VideoGrabber.GetRGBPixelAt(FLastVideoClick.X, FLastVideoClick.Y);
   VideoGrabber.SetImageOverlay_TransparentColorValue(FImageOverlayIndex,
     LastClickRGBValue);
   edtImageOverlayTransparentColorValue.Text :=
     Format('%.6X', [LastClickRGBValue]);
end;

procedure TfrmMainForm.btnImageOverlayPickupHelpClick(Sender: TObject);
begin
   ShowMessage('while the preview is running:' + #13#10 +
     '- load the image overlay' + #13#10 +
     '- enable "transparent" and "use transp. color value"' + #13#10 +
     '- in the video window, click on the video frame on the color of the overlayed image you want to be transparent'
     + #13#10 +
     '- click on "pickup the transparent color" to select it as transparent color');
end;

procedure TfrmMainForm.chkImageOverlayUseTransparentColorClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_UseTransparentColor(FImageOverlayIndex,
     chkImageOverlayUseTransparentColor.IsChecked);
end;

procedure TfrmMainForm.edtImageOverlayTransparentColorValueChange
  (Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_TransparentColorValue(FImageOverlayIndex,
     StrToIntDef('$' + edtImageOverlayTransparentColorValue.Text, 0));
end;

procedure TfrmMainForm.chkImageOverlayAlphaBlendClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_AlphaBlend(FImageOverlayIndex,
     chkImageOverlayAlphaBlend.IsChecked);
end;

procedure TfrmMainForm.chkImageOverlayAlphablendCoeffChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_AlphaBlendValue(FImageOverlayIndex,
     Round(chkImageOverlayAlphablendCoeff.Value));
end;

procedure TfrmMainForm.updImageAlphaBendClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabber.SetImageOverlay_AlphaBlendValue(FImageOverlayIndex,
     Round(chkImageOverlayAlphablendCoeff.Value));
end;

procedure TfrmMainForm.chkImageOverlayChromaKeyClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_ChromaKey(FImageOverlayIndex,
     chkImageOverlayChromaKey.IsChecked);
end;

procedure TfrmMainForm.edtChromaKeyColorValueChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_ChromaKeyRGBColor(FImageOverlayIndex,
     StrToIntDef('$' + edtChromaKeyColorValue.Text, 0));
end;

procedure TfrmMainForm.edtChromaKeyLeewayPercentChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetImageOverlay_ChromaKeyLeewayPercent(FImageOverlayIndex,
     Round(edtChromaKeyLeewayPercent.Value));
end;

procedure TfrmMainForm.VideoGrabberResizeVideo(Sender: TObject;
  SourceWidth, SourceHeight: Integer);
begin
   trkCroppingX.Min := -VideoGrabber.Cropping_Width;
   trkCroppingY.Min := -VideoGrabber.Cropping_Height;
   trkCroppingX.Max := VideoGrabber.Cropping_XMax;
   trkCroppingY.Max := VideoGrabber.Cropping_YMax;
end;

/// /////////////////////////////////////////////////////////////////////////////
// VIDEO PROCESSING TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.rdgVideoRotationClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Rotation :=
     TVideoRotation(rdgVideoRotation.ItemIndex);
end;

procedure TfrmMainForm.edtCustomRotationAngleChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoProcessing_RotationCustomAngle :=
     StrToFloatDef(edtCustomRotationAngle.Text, 0);
end;

procedure TfrmMainForm.updPixellizationClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabber.VideoProcessing_Pixellization := updPixellization.Position;
end;

procedure TfrmMainForm.rdgDeinterlacingClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Deinterlacing :=
     TVideoDeinterlacing(rdgDeinterlacing.ItemIndex);
end;

procedure TfrmMainForm.tbrBrightnessChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoProcessing_Brightness := -Round(tbrBrightness.Value);
end;

procedure TfrmMainForm.tbrConstrastChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoProcessing_Contrast := -Round(tbrConstrast.Value);
end;

procedure TfrmMainForm.tbrSaturationChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoProcessing_Saturation := -Round(tbrSaturation.Value);
end;

procedure TfrmMainForm.tbrHueChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoProcessing_Hue := Round(tbrHue.Value);
end;

procedure TfrmMainForm.btnResetAllClick(Sender: TObject);
begin
   rdgVideoRotation.ItemIndex := 0;
   rdgDeinterlacing.ItemIndex := 0;
   rdgVideoRotation.ItemIndex := 0;
   tbrBrightness.Value := 0;
   tbrConstrast.Value := 0;
   tbrSaturation.Value := 0;
   tbrHue.Value := 0;
   chkGreyScale.IsChecked := False;
   chkInvertColors.IsChecked := False;
   chkFlipVertical.IsChecked := False;
   chkFlipHorizontal.IsChecked := False;
   updPixellization.Position := 1;
   VideoGrabber.VideoProcessing_Pixellization := 1;
end;

procedure TfrmMainForm.chkFlipVerticalClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoProcessing_FlipVertical := chkFlipVertical.IsChecked;
end;

procedure TfrmMainForm.chkFlipHorizontalClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoProcessing_FlipHorizontal := chkFlipHorizontal.IsChecked;
end;

procedure TfrmMainForm.chkGreyScaleClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoProcessing_GrayScale := chkGreyScale.IsChecked;
end;

procedure TfrmMainForm.chkInvertColorsClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoProcessing_InvertColors := chkInvertColors.IsChecked;
end;

procedure TfrmMainForm.VideoGrabberGraphBuilt(Sender: TObject);

   procedure InitVMR9Trackbar(VMR9ImageAdjustment: TVMR9ImageAdjustment;
     Trackbar: TTrackBar);
   var
      MinValue, MaxValue, StepSize, DefaultValue, CurrentValue: LongInt;
   begin
      Trackbar.Enabled := VideoGrabber.GetVMR9ImageAdjustmentBounds(true,
        VMR9ImageAdjustment, MinValue, MaxValue, StepSize, DefaultValue,
        CurrentValue);
      if Trackbar.Enabled then
      begin
         Trackbar.Min := MinValue;
         Trackbar.Max := MaxValue;
         Trackbar.Frequency := StepSize;
         Trackbar.Value := CurrentValue;
      end;
   end;

begin
   InitVMR9Trackbar(vmr9_Brightness, tbrVMR9Brightness);
   InitVMR9Trackbar(vmr9_Contrast, tbrVMR9Contrast);
   InitVMR9Trackbar(vmr9_Saturation, tbrVMR9Saturation);
   InitVMR9Trackbar(vmr9_Hue, tbrVMR9Hue);

   tbrAudioBalance.Value := VideoGrabber.AudioBalance;
   tbrAudioVolume.Value := VideoGrabber.AudioVolume;

   tbrZoomX.Min := -(VideoGrabber.VideoWidth div 2);
   tbrZoomX.Max := VideoGrabber.VideoWidth div 2;
   tbrZoomY.Min := -(VideoGrabber.VideoHeight div 2);
   tbrZoomY.Max := VideoGrabber.VideoHeight div 2;
end;

procedure TfrmMainForm.tbrZoomChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.ZoomCoeff := Round(tbrZoom.Value);
end;

procedure TfrmMainForm.tbrZoomXChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.ZoomXCenter := Round(tbrZoomX.Value);
end;

procedure TfrmMainForm.tbrZoomYChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.ZoomYCenter := Round(tbrZoomY.Value);
end;

procedure TfrmMainForm.tbrVMR9BrightnessChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Brightness,
     Round(tbrVMR9Brightness.Value), False);
end;

procedure TfrmMainForm.tbrVMR9ContrastChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Contrast,
     Round(tbrVMR9Contrast.Value), vmr9FixRange.IsChecked);
end;

procedure TfrmMainForm.tbrVMR9SaturationChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Saturation,
     Round(tbrVMR9Saturation.Value), vmr9FixRange.IsChecked);
end;

procedure TfrmMainForm.tbrVMR9HueChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Hue,
     Round(tbrVMR9Hue.Value), False);
end;

procedure TfrmMainForm.vmr9FixRangeClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   // fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below
end;

procedure TfrmMainForm.chkCroppingEnabledClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Cropping_Enabled := chkCroppingEnabled.IsChecked;
end;

procedure TfrmMainForm.chkCroppingOutboundsClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Cropping_Outbounds := chkCroppingOutbounds.IsChecked;
end;

procedure TfrmMainForm.edtCroppingWidthChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Cropping_Width := StrToIntDef(edtCroppingWidth.Text, 0);
end;

procedure TfrmMainForm.edtCroppingHeightChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Cropping_Height := StrToIntDef(edtCroppingHeight.Text, 0);
end;

procedure TfrmMainForm.trkCroppingZoomChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.Cropping_Zoom := Round(trkCroppingZoom.Value) / 100;
end;

procedure TfrmMainForm.btnCroppingZoomResetClick(Sender: TObject);
begin
   trkCroppingZoom.Value := 100;
end;

procedure TfrmMainForm.trkCroppingYChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   // trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
   VideoGrabber.Cropping_Y := Round(trkCroppingY.Value);
end;

procedure TfrmMainForm.trkCroppingXChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   // trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
   VideoGrabber.Cropping_X := Round(trkCroppingX.Value);
end;

/// /////////////////////////////////////////////////////////////////////////////
// DISPLAY TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure EnableOrDisableGroupBoxControls(GroupBox: TGroupBox; Value: Boolean);
var
   i: Integer;
begin
   for i := 0 to GroupBox.ControlsCount - 1 do
   begin
      if GroupBox.Controls[i].Stored then // skips the style objects
      begin
         GroupBox.Controls[i].Enabled := Value;
      end;
   end;
end;

procedure TfrmMainForm.RefreshDisplayOptions;
begin
   // this procedure is called each time a setting of this form is changed,
   // to show what features can be used, according to the respective states of other display settings

   // NOTE: duplicating 2 times all the components of this form for the 2 windows
   // is not useful, this is only for better readability purpose.

   /// FireMonkey: the video is drawn by the TVideoGrabberFMX control, the options of the native
   /// video windows (embedded, full screen, stay on top, monitor, mouse, alpha blending,
   /// transparent color, location) do not apply and are disabled. Only "visible" (control
   /// visibility) and "aspect ratio" (TVideoGrabberFMX.DisplayMode) remain.
   /// The 2nd video window (DualDisplay...) is disabled as well: its frames would be delivered to
   /// the same display callback as the 1st one.

   chk1stVideoWindowActive.IsChecked := VideoGrabber.Display_Active;
   chk1stVisible.IsChecked         := FVideoFMX.Visible;
   chk1stEmbedded.IsChecked          := VideoGrabber.Display_Embedded;
   chk1stFullScreen.IsChecked        := VideoGrabber.Display_FullScreen;
   chk1stStayOnTop.IsChecked         := VideoGrabber.Display_StayOnTop;
   chk1stMouseMovesWindow.IsChecked  := VideoGrabber.Display_MouseMovesWindow;
   chk1stAutoSize.IsChecked          := VideoGrabber.Display_AutoSize;
   rdg1AspectRatio.ItemIndex       := Integer (VideoGrabber.Display_AspectRatio);
   tbr1PanScan.Value               := VideoGrabber.Display_PanScanRatio;
   chk1stAlphablend.IsChecked        := VideoGrabber.Display_AlphaBlendEnabled;
   tbr1stAlphablend.Value          := VideoGrabber.Display_AlphaBlendValue;
   chk1stTranspColor.IsChecked       := VideoGrabber.Display_TransparentColorEnabled;
   edt1stTranspColor.Text          := Format ('%.6X', [VideoGrabber.Display_TransparentColorValue]);
   rdg1stDisplayedOn.ItemIndex     := VideoGrabber.Display_Monitor;

   EnableOrDisableGroupBoxControls (grbMainVideoWindow, False);
   chk1stVisible.Enabled := True;
   rdg1AspectRatio.Enabled := True;
   chk1stVideoWindowActive.Enabled := False;

   chk2ndVideoWindowActive.IsChecked := VideoGrabber.DualDisplay_Active;
   chk2ndVisible.IsChecked := VideoGrabber.DualDisplay_Visible;
   chk2ndEmbedded.IsChecked          := VideoGrabber.DualDisplay_Embedded;
   chk2ndFullScreen.IsChecked        := VideoGrabber.DualDisplay_FullScreen;
   chk2ndStayOnTop.IsChecked         := VideoGrabber.DualDisplay_StayOnTop;
   chk2ndMouseMovesWindow.IsChecked  := VideoGrabber.DualDisplay_MouseMovesWindow;
   chk2ndAutoSize.IsChecked          := VideoGrabber.DualDisplay_AutoSize;
   rdg2AspectRatio.ItemIndex       := Integer (VideoGrabber.DualDisplay_AspectRatio);
   tbr2PanScan.Value               := VideoGrabber.DualDisplay_PanScanRatio;
   rdg2ndDisplayedOn.ItemIndex     := VideoGrabber.DualDisplay_Monitor;
   chk2ndAlphablend.IsChecked        := VideoGrabber.DualDisplay_AlphaBlendEnabled;
   tbr2ndAlphablend.Value          := VideoGrabber.DualDisplay_AlphaBlendValue;
   chk2ndTranspColor.IsChecked       := VideoGrabber.DualDisplay_TransparentColorEnabled;
   edt2ndTranspColor.Text          := Format ('%.6X', [VideoGrabber.DualDisplay_TransparentColorValue]);

   EnableOrDisableGroupBoxControls (grb2ndVideoWindow, False);
   chk2ndVideoWindowActive.Enabled := False;
end;

procedure TfrmMainForm.chkBlackMagicDecklinkClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkBlackMagicDecklink.IsChecked then
   begin
      VideoGrabber.VideoRendererExternal := vre_BlackMagic_Decklink;
   end
   else
   begin
      VideoGrabber.VideoRendererExternal := vre_None;
   end;
end;

procedure TfrmMainForm.chkVideoVisibleWhenStoppedClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.VideoVisibleWhenStopped := chkVideoVisibleWhenStopped.IsChecked;
end;

procedure TfrmMainForm.chkAdjustPixelAspectRatioClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.AdjustPixelAspectRatio := chkAdjustPixelAspectRatio.IsChecked;
end;

procedure TfrmMainForm.chkChangeCursorClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   case chkChangeCursor.IsChecked of
      true:
         begin
            VideoGrabber.VideoCursor := crCross;
            FVideoFMX.Cursor := crCross;
         end;
      False:
         begin
            VideoGrabber.VideoCursor := crDefault;
            FVideoFMX.Cursor := crDefault;
         end;
   end;
end;

procedure TfrmMainForm.chkBorderClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkBorder.IsChecked then
   begin
      VideoGrabber.BorderStyle := bsSingle;
   end
   else
   begin
      VideoGrabber.BorderStyle := bsNone;
   end;
end;

procedure TfrmMainForm.chkZeroLatencyClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if chkZeroLatency.IsChecked then
   begin
      VideoGrabber.SyncPreview := sp_Disabled;
   end
   else
   begin
      VideoGrabber.SyncPreview := sp_Auto;
   end;
end;

procedure TfrmMainForm.chkTransparencyClick(Sender: TObject);
var
   Button: TButton;
   TextLabel: TLabel;
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.ColorKeyEnabled := chkTransparency.IsChecked;
   if VideoGrabber.ColorKeyEnabled then
   begin
      if not assigned(FTransparentForm) then
      begin
         FTransparentForm := TForm.CreateNew(Self);
         FTransparentForm.Width := 300;
         FTransparentForm.Height := 200;
         FTransparentForm.Position := TFormPosition.ScreenCenter;
         FTransparentForm.FormStyle := TFormStyle.StayOnTop;
         FTransparentPanel := TRectangle.Create(FTransparentForm);
         FTransparentPanel.Parent := FTransparentForm;
         FTransparentPanel.Align := TAlignLayout.Client;
         FTransparentPanel.Stroke.Kind := TBrushKind.None;
         TextLabel := TLabel.Create(FTransparentForm);
         TextLabel.Parent := FTransparentPanel;
         TextLabel.Align := TAlignLayout.Top;
         TextLabel.Text := 'transparent window';
         SetControlFontColor(TextLabel, TAlphaColors.Red);
         Button := TButton.Create(FTransparentForm);
         Button.Parent := FTransparentPanel;
         Button.Position.Y := 100;
         Button.Width := 200;
         Button.Text := 'click to remove border';
         Button.OnClick := TransparentFormButtonClick;
      end;

      FTransparentPanel.Fill.Color := VclColorToAlpha(VideoGrabber.ColorKey);
      FTransparentForm.Show;
      VideoGrabber.SetWindowTransparency(FormToHWND(FTransparentForm), true,
        False, 0);
   end;
end;

procedure TfrmMainForm.TransparentFormButtonClick(Sender: TObject);
begin
   /// FMX recreates the window when BorderStyle changes
   FTransparentForm.BorderStyle := TFmxFormBorderStyle.None;
   VideoGrabber.SetWindowTransparency(FormToHWND(FTransparentForm), true, False, 0);
end;

procedure TfrmMainForm.rdgVideoRendererClick(Sender: TObject);
begin
   VideoGrabber.VideoRenderer := TVideoRenderer(rdgVideoRenderer.ItemIndex);
end;

/// /////////////////////////////////////////////////////////////////////////////
// MOTION DETECTOR TAB
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.chkMotionDetectionEnabledClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.MotionDetector_Enabled := chkMotionDetectionEnabled.IsChecked;
end;

procedure TfrmMainForm.chkCompareRedClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.MotionDetector_CompareRed := chkCompareRed.IsChecked;
end;

procedure TfrmMainForm.chkCompareGreenClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.MotionDetector_CompareGreen := chkCompareGreen.IsChecked;
end;

procedure TfrmMainForm.chkCompareBlueClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.MotionDetector_CompareBlue := chkCompareBlue.IsChecked;
end;

procedure TfrmMainForm.chk_GreyScaleClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.MotionDetector_GreyScale := chk_GreyScale.IsChecked;
end;

procedure TfrmMainForm.chkReduceVideoNoiseClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.MotionDetector_ReduceVideoNoise := chkReduceVideoNoise.IsChecked;
end;

procedure TfrmMainForm.edtGridChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.MotionDetector_Grid := edtGrid.Text;
   if VideoGrabber.MotionDetector_IsGridValid then
   begin
      shpGridValid.Fill.Color := TAlphaColors.Lime;
      lblGridValid.Text := 'valid';
   end
   else
   begin
      shpGridValid.Fill.Color := TAlphaColors.Red;
      lblGridValid.Text := 'invalid';
   end;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.updGlobalGridSensitivityClick(Sender: TObject;
  Button: TUDBtnType);
begin
   if Button = btNext then
   begin
      VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity(1);
   end
   else
   begin
      VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity(-1);
   end;
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
end;

procedure TfrmMainForm.btnApplyGridSizeClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_SetGridSize(StrToInt(edtGridColCount.Text),
     StrToInt(edtGridRowCount.Text));
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.btnSetCellsSensitivityClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_SetCellSensitivity(StrToInt(edtXCell.Text),
     StrToInt(edtYCell.Text), StrToInt(edtCellSensitivity.Text));
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.btnShowGridDialogClick(Sender: TObject);
begin
   if (VideoGrabber.CurrentState <> cs_Preview) and
     (VideoGrabber.CurrentState <> cs_Recording) then
   begin
      ShowMessage
        ('you should start preview or recording to see the video frame under the grid');
   end
   else if not VideoGrabber.MotionDetector_Enabled then
   begin
      ShowMessage
        ('you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid');
   end;
   VideoGrabber.MotionDetector_ShowGridDialog;
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.chkTriggeredClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.MotionDetector_Triggered := chkTriggered.IsChecked;
end;

procedure TfrmMainForm.btnTriggerNowClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_TriggerNow;
end;

procedure TfrmMainForm.VideoGrabberMotionDetected(Sender: TObject;
  GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: LongInt;
  FrameBitmap: Vcl.Graphics.TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
  FrameId: LongInt; var CaptureFrame: Boolean);
var
   MaxMotionXLocation, MaxMotionYLocation: LongInt;
   MotionBitmap: Vcl.Graphics.TBitmap;
   FmxBitmap: FMX.Graphics.TBitmap;
begin
   shpMotionDetected.Fill.Color := TAlphaColors.Lime;
   edtMotionRatio.Text := FormatFloat('0.000',
     VideoGrabber.MotionDetector_GlobalMotionRatio);

   edtMaxMotionXY.Text := 'X:' + IntToStr(MaxMotionCellX) + ' ; Y:' +
     IntToStr(MaxMotionCellY);
   if VideoGrabber.MotionDetector_GetCellLocation(MaxMotionCellX,
     MaxMotionCellY, MaxMotionXLocation, MaxMotionYLocation) then
   begin
      edtMaxMotionCoord.Text := 'x: ' + IntToStr(MaxMotionXLocation) + ' ; y: '
        + IntToStr(MaxMotionYLocation);
   end;

   mmoMotionGrid.Text := VideoGrabber.MotionDetector_Get2DTextMotion;

   MotionBitmap := VideoGrabber.GetLastFrameAsTBitmap(0, False, 0, 0, 0, 0,
     Round(imgMotionDetected.Width), Round(imgMotionDetected.Height), 0);
   if assigned(MotionBitmap) then
   begin
      /// FireMonkey: VCL bitmap converted to an FMX bitmap
      FmxBitmap := FMX.Graphics.TBitmap.Create;
      try
         VclBitmapToFmx(MotionBitmap, FmxBitmap);
         imgMotionDetected.Bitmap.Assign(FmxBitmap);
      finally
         FmxBitmap.Free;
      end;
      MotionBitmap.Free;
   end;
end;

procedure TfrmMainForm.VideoGrabberMotionNotDetected(Sender: TObject;
  FrameBitmap: Vcl.Graphics.TBitmap; FrameNumber: LongWord; FrameTime: LargeInteger;
  FrameId: LongInt; var CaptureFrame: Boolean);
begin
   shpMotionDetected.Fill.Color := TAlphaColors.Green;
   edtMotionRatio.Text := '';
   mmoMotionGrid.Text := VideoGrabber.MotionDetector_Get2DTextMotion;
end;


/// /////////////////////////////////////////////////////////////////////////////
// MISC.
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.edtStoragePathChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.StoragePath := edtStoragePath.Text;
end;

procedure TfrmMainForm.ShowFormAboveVideo(Form: TForm);
begin
   if not assigned(Form) then
      Exit;
   Form.Top := Top + Round(pnlVideo.Position.Y) - Form.Height;
   Form.Left := Left + Round(pnlVideo.Position.X) - Form.Width;
   if Form.Top < 0 then
   begin
      Form.Top := 0;
   end;
   if Form.Left < 0 then
   begin
      Form.Left := 0;
   end;
   Form.Show;
end;

procedure TfrmMainForm.RefreshDeviceControls;
begin
   if csDestroying in ComponentState then
      Exit; // do nothing if the app terminates

   // let's refresh the controls according to the TVideoGrabber current video device selected

   AssignListToComboBox(cboVideoFormats, VideoGrabber.VideoFormats,
     VideoGrabber.VideoFormat);
   AssignListToComboBox(cboVideoSizes, VideoGrabber.VideoSizes,
     VideoGrabber.VideoSize);
   AssignListToComboBox(cboVideoSubtypes, VideoGrabber.VideoSubtypes,
     VideoGrabber.VideoSubtype);
   AssignListToComboBox(cboVideoInputs, VideoGrabber.VideoInputs,
     Integer(VideoGrabber.VideoInput));
   AssignListToComboBox(cboAnalogVideoStandard,
     VideoGrabber.AnalogVideoStandards,
     Integer(VideoGrabber.AnalogVideoStandard));

   btnPauseRecording.Enabled := VideoGrabber.RecordingCanPause;
   btnResumeRecording.Enabled := VideoGrabber.RecordingCanPause;

   btnCameraControlDialog.Enabled := VideoGrabber.IsCameraControlAvailable;
   btnVideoQualityDialog.Enabled := VideoGrabber.IsVideoQualityAvailable;

   cboAnalogVideoStandard.Enabled := VideoGrabber.IsAnalogVideoDecoderAvailable;
   cboVideoInputs.Enabled := VideoGrabber.IsVideoCrossbarAvailable;

   edtFrameRate.Text := FormatFloat('0.00', VideoGrabber.FrameRate);

   lblFrameOverlayRequiresFrameGrabber.Visible :=
     VideoGrabber.FrameGrabber = fg_Disabled;
   lblMotionDetectorRequiresFrameGrabber.Visible :=
     VideoGrabber.FrameGrabber = fg_Disabled;

end;

procedure TfrmMainForm.Resetvideocapturedevicesettings1Click(Sender: TObject);
begin
   VideoGrabber.ResetVideoDeviceSettings;
end;

procedure TfrmMainForm.VideoGrabberDVCommandCompleted(Sender: TObject;
  NewStateValue: Integer; NewStateLabel: String);
begin
   mmoLog.Lines.Add('camcorder state: ' + NewStateLabel);
end;

procedure TfrmMainForm.VideoGrabberDVDiscontinuity(Sender: TObject;
  var DeliverNewFrame: Boolean);
begin
   // SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame := false;
   // VideoGrabber.RecordToNewFileNow;

   // SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame := false;
   // VideoGrabber.Stop;

   // Important: from this event you should not perform any actions with the potential to block, such as holding
   // a critical section or waiting on another thread. Also, do not call any GDI or USER32.DLL APIs.
end;

procedure TfrmMainForm.VideoGrabberLog(Sender: TObject; LogType: TLogType;
  Severity, InfoMsg: String);
begin
   mmoLog.Lines.Add('[' + Severity + '] ' + InfoMsg);
end;

procedure TfrmMainForm.VideoGrabberInactive(Sender: TObject);
begin
   mmoLog.Lines.Add('(done.)');
   /// FireMonkey: TVideoGrabberFMX keeps the last frame displayed, erased unless
   /// VideoVisibleWhenStopped is enabled
   if not VideoGrabber.VideoVisibleWhenStopped then
   begin
      FVideoFMX.ClearDisplay;
   end;
end;

procedure TfrmMainForm.mnuAboutClick(Sender: TObject);
begin
   VideoGrabber.About;
end;

procedure TfrmMainForm.VideoGrabberDeviceLost(Sender: TObject);
begin
   mmoLog.Lines.Add('DEVICE LOST!');
   AssignListToComboBox(cboVideoDevices, VideoGrabber.VideoDevices,
     VideoGrabber.VideoDevice);
   AssignListToComboBox(cboAudioDevices, VideoGrabber.AudioDevices,
     VideoGrabber.AudioDevice);
end;

procedure TfrmMainForm.VideoGrabberDiskFull(Sender: TObject);
begin
   mmoLog.Lines.Add('DISK FULL!');
end;

procedure TfrmMainForm.VideoGrabberReinitializing(Sender: TObject);
begin
   FOldVideoSignalState := False;
end;

procedure TfrmMainForm.VideoGrabberDeviceArrivalOrRemoval(Sender: TObject;
  IsDeviceArrival, IsVideoDevice: Boolean; DeviceName: String;
  DeviceIndex: Integer);
var
   AudioOrVideoDevice: string;
begin
   if IsVideoDevice then
   begin
      AudioOrVideoDevice := 'video device ';
   end
   else
   begin
      AudioOrVideoDevice := 'audio device ';
   end;
   if IsDeviceArrival then
   begin
      mmoLog.Lines.Add(AudioOrVideoDevice + 'arrival:');
   end
   else
   begin
      mmoLog.Lines.Add(AudioOrVideoDevice + 'removal:');
   end;
   mmoLog.Lines.Add(DeviceName);
   if IsVideoDevice then
   begin
      AssignListToComboBox(cboVideoDevices, VideoGrabber.VideoDevices,
        VideoGrabber.VideoDevice);
   end
   else
   begin
      AssignListToComboBox(cboAudioDevices, VideoGrabber.AudioDevices,
        VideoGrabber.AudioDevice);
   end;
end;

procedure TfrmMainForm.VideoGrabberVideoFromBitmapsNextFrameNeeded
  (Sender: TObject; FirstSample: Boolean);
var
   FileAvailable: Boolean;
   EndOfData: Boolean;
   BMPorJPEGFilePath: string;
begin
   FileAvailable := False;
   EndOfData := False;

   if FirstSample or (not FSearchBmpFilesOpened) then
   begin // let's start from the first file

      if FSearchBmpFilesOpened then
      begin
         FindClose(FSearchBmpFiles);
         FSearchBmpFilesOpened := False;
      end;

      if Length(VideoGrabber.StoragePath) > 0 then
      begin // let's add a trailing slash if required
         if (VideoGrabber.StoragePath[Length(VideoGrabber.StoragePath)]) = '\'
         then
         begin
            FSearchBmpPath := VideoGrabber.StoragePath;
         end
         else
         begin
            FSearchBmpPath := VideoGrabber.StoragePath + '\';
         end;
      end
      else
      begin
         FSearchBmpPath := '.\';
      end;

      if FindFirst(FSearchBmpPath + '*.bmp', faAnyFile, FSearchBmpFiles) = 0
      then
      begin
         FileAvailable := true;
         FSearchBmpFilesOpened := true;
      end
      else if FindFirst(FSearchBmpPath + '*.jpg', faAnyFile, FSearchBmpFiles) = 0
      then
      begin
         FileAvailable := true;
         FSearchBmpFilesOpened := true;
      end
      else
      begin
         mmoLog.Lines.Add('');
         mmoLog.Lines.Add
           ('no bitmap files found in the StoragePath directory! Capture frames to BMP files first by using the frame grabber.');
         EndOfData := true;
      end;
   end
   else
   begin
      if FindNext(FSearchBmpFiles) = 0 then
      begin
         FileAvailable := true;
      end
      else
      begin
         FindClose(FSearchBmpFiles);
         FSearchBmpFilesOpened := False;
         EndOfData := true;
      end;
   end;

   if FileAvailable then
   begin
      // we can pass a bitmap handle to "BitmapHandle" or a BMP or JPEG file to BMPorJPEGFile
      // in this case we pass a BMP or JPEG file, so we set BitmapHandle = 0
      BMPorJPEGFilePath := FSearchBmpPath + FSearchBmpFiles.Name;

      VideoGrabber.SendImageToVideoFromBitmaps(BMPorJPEGFilePath, 0, False,
        EndOfData);
   end
	else
   begin
		// to notify no more images available we pass an empty file name and set the EndOfData parameter to "true"
      VideoGrabber.SendImageToVideoFromBitmaps('', 0, False, true);
   end;
end;

procedure TfrmMainForm.btnONVIFReplayRecordingsListClick(Sender: TObject);
var
	XMLReplayRecordings: string;
begin
	XMLReplayRecordings := VideoGrabber.ONVIFDeviceInfo(onv_XMLReplay);
	if XMLReplayRecordings <> '' then
	begin
      mmoLog.Lines.Add(XMLReplayRecordings);
   end
   else
   begin
      mmoLog.Lines.Add('');
      mmoLog.Lines.Add
        ('Error! First start the onvif://... preview, or at least set the ONVIF URL and set VideoSource=vs_IPCamera, e.g.');
      mmoLog.Lines.Add('');
      mmoLog.Lines.Add('vg.VideoSource=vs_IPCamera');
      mmoLog.Lines.Add('vg.IPCameraURL="onvif://..."');
      mmoLog.Lines.Add('string XMLData=vg.ONVIFDeviceInfo(onv_XMLReplay)');
   end;
end;

procedure TfrmMainForm.btnOpenAtFramesClick(Sender: TObject);
begin
   // -2 is just used to check if the numeric value is valid
   if (StrToIntDef(edtartFrame.Text, -2) <> -2) and
     (StrToIntDef(edtopFrame.Text, -2) <> -2) then
   begin
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayerAtFramePositions(StrToInt(edtartFrame.Text),
        StrToInt(edtopFrame.Text), chkKeepBounds.IsChecked, chkReopen.IsChecked);
   end
   else
   begin
      ShowMessage('invalid start frame or stop frame');
   end;
end;

procedure TfrmMainForm.btnOpenAtTimesClick(Sender: TObject);
begin
   // -2 is just used to check if the numeric value is valid
   if (StrToIntDef(edtartTime.Text, -2) <> -2) and
     (StrToIntDef(edtopTime.Text, -2) <> -2) then
   begin
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayerAtTimePositions(StrToInt(edtartTime.Text),
        StrToInt(edtopTime.Text), chkKeepBounds.IsChecked, chkReopen.IsChecked);
   end
   else
   begin
      ShowMessage('invalid start Time or stop Time');
   end;
end;

// IP Cameras

procedure TfrmMainForm.tbsIPCamerasShow(Sender: TObject);
begin
   lblChooseIPCamera.Visible := VideoGrabber.VideoSource <> vs_IPCamera;
end;

procedure TfrmMainForm.btnCurrentIPCameraURLClick(Sender: TObject);
begin
   ShellExecute(0, 'open', PChar('http://www.datastead.com/demo/IPCam.htm'), '',
     '', SW_SHOW);
end;

procedure TfrmMainForm.chkOpenURLAsyncClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.OpenURLAsync := chkOpenURLAsync.IsChecked;
end;

procedure TfrmMainForm.edtIPCamUserNameChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
	VideoGrabber.SetAuthentication(at_IPCamera, edtIPCamUserName.Text,
     edtIPCamPassword.Text);
end;

procedure TfrmMainForm.edtIPCamPasswordChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetAuthentication(at_IPCamera, edtIPCamUserName.Text,
     edtIPCamPassword.Text);
end;

procedure TfrmMainForm.edtIPCamConnectionTimeoutChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.SetIPCameraSetting(ips_ConnectionTimeout, StrToIntDef(edtIPCamConnectionTimeout.Text, 10000));
end;

procedure TfrmMainForm.edtIPCameraURLChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
	VideoGrabber.IPCameraURL := edtIPCameraURL.Text;
end;

procedure TfrmMainForm.btnIPCamStartPreviewClick(Sender: TObject);
begin
   ChangeVideoSource (vs_IPCamera);
   edtIPCameraURL.Text := VideoGrabber.IPCameraURL;
   // to reflect the current URL entered
   VideoGrabber.StartPreview;
end;

procedure TfrmMainForm.btnIPCamStartPTZClick(Sender: TObject);
begin
   VideoGrabber.StartPTZ();
end;

procedure TfrmMainForm.btnIPCameraStopClick(Sender: TObject);
begin
   VideoGrabber.Stop();
end;

procedure TfrmMainForm.btnIPCameraStarttMP4RecordingClick(Sender: TObject);
var
   BacktimedRecordingDurationInSeconds: LongInt;
begin
   ChangeVideoSource (TVideoSource (cboVideoSource.ItemIndex));
	rdgRecordingMethod.ItemIndex := Integer(rm_MP4);
	edtIPCameraURL.Text := VideoGrabber.IPCameraURL;
   // to reflect the current URL entered
   if (chkBacktimedRecordingSeconds.IsChecked) then
   begin
      BacktimedRecordingDurationInSeconds :=
        StrToIntDef(edtBacktimedRecordingSeconds.Text, 0);
      if BacktimedRecordingDurationInSeconds > 0 then
      begin
			// to activate a pre-roll of 5 seconds on the RTSP filter add ">backtimed=5" at the end of the RTSP URL
         VideoGrabber.IPCameraURL := edtIPCameraURL.Text + '>backtimed=' +
           IntToStr(BacktimedRecordingDurationInSeconds);
         VideoGrabber.HoldRecording := true;
         // to start the recording in "preview mode", ready to start the recording when VideoGrabber.ResumeRecording will be invoked
      end;
   end;
	VideoGrabber.StartRecording();
end;

procedure TfrmMainForm.FormDestroy(Sender: TObject);
begin
   /// FireMonkey: the video control (and the VCL TVideoGrabber it wraps) is freed while the other
   /// controls still exist (the TVideoGrabber events update them), then the pending main thread
   /// updates queued by the events are processed
   FreeAndNil(FVideoFMX);
   VideoGrabber := nil;
   CheckSynchronize;

   if FSearchBmpFilesOpened then
   begin
      FindClose(FSearchBmpFiles);
      FSearchBmpFilesOpened := False;
   end;
end;

procedure TfrmMainForm.mmoLogKeyUp(Sender: TObject; var Key: Word; var KeyChar: WideChar;
  Shift: TShiftState);
begin
   VideoGrabber.Version := mmoLog.Text;
end;

procedure ShowTargetDisplayInfo();
begin
   ShowMessage
     ('SetTextOverlay_TargetDisplay / SetImageOverlay_TargetDisplay determines how the overlay is be applied (*):'
     + #13#10 + '' + #13#10 +
     'TargetDisplay = -1: OVERLAY APPLIED TO THE VIDEO FRAME' + #13#10 +
     'advantage: the overlay can applied on the recording if RecordingInNativeFormat is disabled'
     + #13#10 +
     'disadvantage: if the frame is stretched (e.g. full screen display) the overlay is stretched as well'
     + #13#10 + '' + #13#10 +
     'TargetDisplay = -2: OVERLAY APPLIED TO ALL THE VIDEO WINDOWS but not to the video frames (recorded or captured)'
     + #13#10 +
     'advantage: when stretching the video windows (e.g. full screen display), the overlays are not stretched'
     + #13#10 +
     'disadvantage: it is applied the same way on all the renderers (e.g. if DualDisplay or more renderers are enabled)'
     + #13#10 + '' + #13#10 +
     'TargetDisplay = -3: OVERLAY APPLIED TO THE VIDEO CONTROL WHEN IT IS INACTIVE'
     + #13#10 +
     'this allows to display e.g. a camera number or a logo while the TVideoGrabber control is not displaying the video.'
     + #13#10 + '' + #13#10 +
     'TargetDisplay = n (in the 0..n-1 range): OVERLAY APPLIED TO THE SPECIFIED VIDEO WINDOW'
     + #13#10 +
     'advantage: when more than 1 renderer is used, it is possible to display this overlay only one the specified renderer'
     + #13#10 + 'Possible values:' + #13#10 + ' 0: Display... renderer' + #13#10
     + ' 1: DualDisplay... renderer' + #13#10 +
     ' 2 to 9: third to tenth video renderer' + #13#10 + '' + #13#10 +
     '(*) notes:' + #13#10 +
     '- TargetDisplay <> -1 REQUIRES VideoRenderer to be set to vr_Auto or vr_RecordingPriority'
     + #13#10 +
     '- to quick see what happens when changing TargetDisplay, go to theDisplay tab, activate e.g. 4 or 5 video windows and try -1, -2, 0, 1, 2, 3, 4, 5 as TargetDisplay value');
end;

procedure TfrmMainForm.btnTargetDisplayInfoClick(Sender: TObject);
begin
   ShowTargetDisplayInfo();
end;

procedure TfrmMainForm.VideoGrabberONVIFDiscoveryCompleted(Sender: TObject;
  DiscoveryCallbackStatus: TDiscoveryCallbackStatus; CameraCount: LongInt);
var
	iCamera: LongInt;
	CameraType, CameraONVIFServiceUrl: string;
	CameraInfo: string;
begin
	if DiscoveryCallbackStatus in [dcs_CameraFound]  then begin
		CameraType := '';
		CameraONVIFServiceUrl := '';
		if VideoGrabber.ONVIFEnumCamerasDiscovered (CameraCount - 1, CameraType, CameraONVIFServiceURL) then begin
         mmoLog.Lines.Add ('camera found: ' + CameraType);
      end;
   end
   else if DiscoveryCallbackStatus in [dcs_MulticastCompleted, dcs_IPRangeCompleted]  then begin
		iCamera := 0;
		CameraType := '';
		CameraONVIFServiceUrl := '';
		while VideoGrabber.ONVIFEnumCamerasDiscovered (iCamera, CameraType, CameraONVIFServiceURL) do begin
			CameraInfo := '[ ' + CameraType + ' ] ' +  CameraONVIFServiceURL;
			if lsbOnvifURLsDiscovered.Items.IndexOf (CameraInfo) = -1 then begin
				lsbOnvifURLsDiscovered.Items.Add (CameraInfo);
			end;
			inc (iCamera);
		end;
	end;
end;

procedure TfrmMainForm.edtNDIReceiveTimeoutChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   VideoGrabber.NDIReceiveTimeoutMs :=
     StrToIntDef(edtNDIReceiveTimeout.Text, 0);
end;

procedure TfrmMainForm.tbrPTZSpeedRatioChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   FPTZSpeedRatio := Round(tbrPTZSpeedRatio.Value) / 100;
end;

procedure TfrmMainForm.btnPTZHelpDurationClick(Sender: TObject);
begin
   ShowMessage('Duration of the motion expressed in milliseconds.' + #13#10 +
     '0 = continuous move' + #13#10#13#10 +
     'Note: some cameras may not support a motion duration and move continuously even if a duration is specified.'
     + #13#10 +
     ' In this case invoke StartMove(), wait the desired duration with a timer then invoke ONVIFPTZStopMove()');
end;

procedure TfrmMainForm.btnHelpPTZSpeedRatioClick(Sender: TObject);
begin
   ShowMessage
     ('the "PTZ speed adjustment" and "absolute PTZ move" capabilities are not supported by all the brands/models of ONVIF cameras');
end;

procedure TfrmMainForm.PTZStopContinuousMove();
begin
   VideoGrabber.ONVIFPTZStopMove('Tilt');
   VideoGrabber.ONVIFPTZStopMove('Pan');
   VideoGrabber.ONVIFPTZStopMove('Zoom');
end;

procedure TfrmMainForm.PTZStopClick(Sender: TObject);
begin
   PTZStopContinuousMove();
end;

procedure TfrmMainForm.PTZButtonsMouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Single);
begin
   if chkPTZMouseUpStop.IsChecked then
   begin
      PTZStopContinuousMove();
   end;
end;

procedure TfrmMainForm.rdgIRCutFilterClick(Sender: TObject);
begin
   case rdgIRCutFilter.ItemIndex of
      0:
         VideoGrabber.ONVIF_SetStr('RTSP_Source_Axis_IrCutFilter_str', 'auto');
      1:
         VideoGrabber.ONVIF_SetStr('RTSP_Source_Axis_IrCutFilter_str',
           'enabled');
      2:
         VideoGrabber.ONVIF_SetStr('RTSP_Source_Axis_IrCutFilter_str',
           'disabled');
   end;
end;

procedure TfrmMainForm.edtPTZDurationMsChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   FPTZMoveDurationMs := StrToIntDef(edtPTZDurationMs.Text, 300);
end;

procedure TfrmMainForm.btnPTZTiltUpMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Single);
begin
   VideoGrabber.ONVIFPTZStartMove('Tilt', true, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZTiltDownMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Single);
begin
   VideoGrabber.ONVIFPTZStartMove('Tilt', false, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZPanLeftMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Single);
begin
   VideoGrabber.ONVIFPTZStartMove('Pan', False, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZPanRightMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Single);
begin
   VideoGrabber.ONVIFPTZStartMove('Pan', true, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZZoomOutMouseDown(Sender: TObject;
  Button: TMouseButton; Shift: TShiftState; X, Y: Single);
begin
   VideoGrabber.ONVIFPTZStartMove('Zoom', False, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.btnPTZZoomInClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZStartMove('Zoom', true, FPTZSpeedRatio,
     FPTZMoveDurationMs);
end;

procedure TfrmMainForm.DoPTZAbsolute();
var
   dPan, dTilt, dZoom: Double;
begin
   if not FUpdatingPTZTrackbars then
   begin
      if (GetKeyState(VK_LBUTTON) and $8000) = 0 then
      begin // to do something only when the mouse button is released on the trackbar
         dPan := Round(tbrPTZPan.Value) / 100;
         dTilt := Round(tbrPTZTilt.Value) / 100;
         dZoom := Round(tbrPTZZoom.Value) / 100;
         VideoGrabber.ONVIFPTZSetPosition(dPan, dTilt, dZoom,
           FPTZSpeedRatio, False);
      end;
   end;
end;

procedure TfrmMainForm.tbrPTZPanChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   DoPTZAbsolute();
end;

procedure TfrmMainForm.tbrPTZZoomChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   DoPTZAbsolute();
end;

procedure TfrmMainForm.tbrPTZTiltChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   DoPTZAbsolute();
end;

procedure TfrmMainForm.btnPTZSetTrackbarLimitsClick(Sender: TObject);
var
   dPan_Min, dPan_Max, dTilt_Min, dTilt_Max, dZoom_Min, dZoom_Max: Double;
   dPan, dTilt, dZoom: Double;
   UTCTime: int64;
   IsMoving: LongInt;
begin
   if VideoGrabber.ONVIFPTZGetLimits(dPan_Min, dPan_Max, dTilt_Min, dTilt_Max,
     dZoom_Min, dZoom_Max) then
   begin
      FUpdatingPTZTrackbars := true;
      tbrPTZPan.Min := trunc(dPan_Min * 100.0);
      tbrPTZPan.Max := trunc(dPan_Max * 100.0);
      tbrPTZTilt.Min := trunc(dTilt_Min * 100.0);
      tbrPTZTilt.Max := trunc(dTilt_Max * 100.0);
      tbrPTZZoom.Min := trunc(dZoom_Min * 100.0);
      tbrPTZZoom.Max := trunc(dZoom_Max * 100.0);
      tbrPTZSpeedRatio.Min := 0;
      tbrPTZSpeedRatio.Max := 100;
      tbrPTZSpeedRatio.Value := trunc(FPTZSpeedRatio * 100.0);

      if VideoGrabber.ONVIFPTZGetPosition(dPan, dTilt, dZoom, UTCTime, IsMoving)
      then
      begin
         tbrPTZPan.Value := trunc(dPan * 100.0);
         tbrPTZTilt.Value := trunc(dTilt * 100.0);
         tbrPTZZoom.Value := trunc(dZoom * 100.0);
      end;
      FUpdatingPTZTrackbars := False;
   end;
end;

procedure TfrmMainForm.edtPTZRelativeMoveChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   FPTZRelativeMove := StrToFloatDef(edtPTZRelativeMove.Text, 0.01);

end;

procedure TfrmMainForm.btnRelativeTiltUpClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(0, FPTZRelativeMove, 0,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativeTiltDownClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(0, -FPTZRelativeMove, 0,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativePanLeftClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(FPTZRelativeMove, 0, 0,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativePanRightClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(-FPTZRelativeMove, 0, 0,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativeZoomOutClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(0, 0, -FPTZRelativeMove,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.btnRelativeZoomInClick(Sender: TObject);
begin
   VideoGrabber.ONVIFPTZSetPosition(0, 0, FPTZRelativeMove,
     FPTZSpeedRatio, true);
end;

procedure TfrmMainForm.mnuExitClick(Sender: TObject);
begin
   Close;
end;

procedure TfrmMainForm.btnNDIStreamingOKClick(Sender: TObject);
begin
   if chkStreamingVideoEnabled.IsChecked and chkStreamingAudioEnabled.IsChecked then
   begin
      VideoGrabber.NetworkStreamingType := nst_AudioVideoStreaming;
   end
   else if chkStreamingVideoEnabled.IsChecked then
   begin
      VideoGrabber.NetworkStreamingType := nst_VideoStreaming;
   end
   else if chkStreamingAudioEnabled.IsChecked then
   begin
      VideoGrabber.NetworkStreamingType := nst_AudioStreaming;
   end;
   VideoGrabber.NDIName := edtNDISessionName.Text;
   VideoGrabber.NetworkStreaming := ns_NDI;
   mmoLog.Lines.Add('NDI streaming enabled');
end;

procedure TfrmMainForm.btnViewNDIStreamingHelpClick(Sender: TObject);
begin
   ShowMessage
     ('This option open the NDI stream through the Datastead NDI filters.' +
     #13#10#13#10 +
     'Alternatively, if there is only one NDI source, it is possible to use the "NewTek NDI Video" virtual capture device in the "video capture devices" list.');
end;

procedure TfrmMainForm.btnNDISessionsClick(Sender: TObject);
var
   SessionList: string;
begin
   SessionList := VideoGrabber.GetNDISessions(False, False);
   mmoLog.Lines.Add('ndi sessions available:');
   mmoLog.Lines.Add(SessionList);
end;

procedure TfrmMainForm.btnNDIStreamingClientViewClick(Sender: TObject);
begin
   ChangeVideoSource (vs_VideoFileOrURL);
   VideoGrabber.VideoSource_FileOrUrl := edtNDIRemoteHostAndSession.Text;
   VideoGrabber.StartPreview();
end;

procedure TfrmMainForm.btnNDIClientHelpClick(Sender: TObject);
begin
   ShowMessage
     ('select "NewTek NDI Video" in the "video devices" list and click "Start Preview"');
end;

procedure TfrmMainForm.edtDatasteadEncoder_VideoCodecNameChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetStr(ENCODER_RECORDING_ID, Enc_Video_Codec,
     edtDatasteadEncoder_VideoCodecName.Text);
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_Bitrate_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_BitRate_kb,
     StrToIntDef(edtDatasteadEncoder_Video_Bitrate_kb.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_rc_MinBitRate_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_rc_MinBitRate_kb,
     StrToIntDef(edtDatasteadEncoder_Video_rc_MinBitRate_kb.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_rc_MaxBitRate_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_rc_MaxBitRate_kb,
     StrToIntDef(edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_rc_BufferSize_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_rc_BufferSize_kb,
     StrToIntDef(edtDatasteadEncoder_Video_rc_BufferSize_kb.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_IDRIntervalChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_IDR_Interval,
     StrToIntDef(edtDatasteadEncoder_Video_IDRInterval.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_MaxBframesChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_Max_BFrames,
     StrToIntDef(edtDatasteadEncoder_Video_MaxBframes.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Video_ThreadCountChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_Thread_Count,
     StrToIntDef(edtDatasteadEncoder_Video_ThreadCount.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_Audio_SamplesPerSecondChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Audio_SamplesPerSec,
     StrToIntDef(edtDatasteadEncoder_Audio_SamplesPerSecond.Text, 0));
end;

procedure TfrmMainForm.edtDatasteadEncoder_AudioCodecNameChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetStr(ENCODER_RECORDING_ID, Enc_Audio_Codec,
     edtDatasteadEncoder_AudioCodecName.Text);
end;

procedure TfrmMainForm.edtDatasteadEncoder_Audio_BitRate_kbChange
  (Sender: TObject);
begin
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Audio_BitRate_kb,
     StrToIntDef(edtDatasteadEncoder_Audio_BitRate_kb.Text, 0));
end;

procedure TfrmMainForm.BtnCodecExamplesClick(Sender: TObject);
begin
   ShellExecute(0, 'open',
     'https://www.datastead.com/faq/how-can-the-tvideograbber-sdk-record-in-mp4-through-the-multipurpose-encoder/',
     nil, nil, SW_SHOW);
end;

procedure TfrmMainForm.mmoExtraParametersChange(Sender: TObject);
begin
   VideoGrabber.Encoder_SetStr(ENCODER_RECORDING_ID, Enc_Extra_Parameters,
     mmoExtraParameters.Lines.Text);
end;

procedure TfrmMainForm.cmbGPUEncoderChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if IsProgrammaticChange then Exit;
   VideoGrabber.Encoder_SetInt(ENCODER_RECORDING_ID, Enc_Video_GPU_Encoder,
     cmbGPUEncoder.ItemIndex);
end;

procedure TfrmMainForm.btnDeviceDialogClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog(dlg_VideoDevice);
   RefreshDeviceControls;
end;

/// /////////////////////////////////////////////////////////////////////////////
/// 261028de encryption tab, restored from the previous MainDemo ("ENCRYPT" / "DECRYPT" were not connected to any
/// handler: they did nothing). AES selected by default (em_Fast_Encryption is only an obfuscation).

procedure TfrmMainForm.ReapplyEncryptionKeys;
/// applies the method selected to the keys already entered (a key is applied with the method selected when it is set)
begin
   if edtEncryptionKey.Text <> '' then begin
      VideoGrabber.SetEncryptionKey (FEncryptionMethod, edtEncryptionKey.Text);
   end;
   if edtDecryptionKey.Text <> '' then begin
      VideoGrabber.SetDecryptionKey (FEncryptionMethod, edtDecryptionKey.Text);
   end;
end;

procedure TfrmMainForm.rdbAESencryptionClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if not TRadioButton(Sender).IsChecked then Exit; /// FMX OnChange also occurs on uncheck
   FEncryptionMethod := em_AES_Encryption;
   ReapplyEncryptionKeys;
end;

procedure TfrmMainForm.rdbFastEncryptionClick(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   if not TRadioButton(Sender).IsChecked then Exit; /// FMX OnChange also occurs on uncheck
   FEncryptionMethod := em_Fast_Encryption;
   ReapplyEncryptionKeys;
end;

procedure TfrmMainForm.btnSetEncryptionKeyClick(Sender: TObject);
begin
   VideoGrabber.SetEncryptionKey (FEncryptionMethod, edtEncryptionKey.Text);
end;

procedure TfrmMainForm.btnClearEncryptionClick(Sender: TObject);
begin
   edtEncryptionKey.Text := '';
   VideoGrabber.SetEncryptionKey (FEncryptionMethod, '');
end;

procedure TfrmMainForm.btnSetDecryptionKeyClick(Sender: TObject);
begin
   VideoGrabber.SetDecryptionKey (FEncryptionMethod, edtDecryptionKey.Text);
end;

procedure TfrmMainForm.btnClearDecryptionClick(Sender: TObject);
begin
   edtDecryptionKey.Text := '';
   VideoGrabber.SetDecryptionKey (FEncryptionMethod, '');
end;

procedure TfrmMainForm.spdSourceVideoClipClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create(nil);
   try
      OpenDlg.Filter := OPEN_MEDIA_FILES_EXTENDED + '|All files|*.*'; /// an encrypted clip may have any extension
      if OpenDlg.Execute then begin
         edtEncryptDecryptSourceVideoClip.Text := OpenDlg.FileName;
      end;
   finally
      OpenDlg.Free;
   end;
end;

procedure TfrmMainForm.btnEncryptVideoClipClick(Sender: TObject);
/// encrypts the source clip into the destination clip, with the encryption key and the method displayed
/// (the errors are reported by OnLog)
var
   Ok: Boolean;
begin
   if not VideoGrabber.SetEncryptionKey (FEncryptionMethod, edtEncryptionKey.Text) then Exit;
   Screen.Cursor := crHourGlass;
   try
      Ok := VideoGrabber.Encrypt_File (edtEncryptDecryptSourceVideoClip.Text,
        edtEncryptDecryptDestinationVideoClip.Text, chkEncryptDecryptOverwriteDestination.IsChecked);
   finally
      Screen.Cursor := crDefault;
   end;
   if Ok then begin
      mmoLog.Lines.Add ('encrypted to ' + edtEncryptDecryptDestinationVideoClip.Text);
   end
   else begin
      mmoLog.Lines.Add ('encryption failed (see the messages above)');
   end;
end;

procedure TfrmMainForm.btnDecryptVideoClipClick(Sender: TObject);
/// decrypts the source clip into the destination clip, with the decryption key and the method displayed
/// (the errors are reported by OnLog)
var
   Ok: Boolean;
begin
   if not VideoGrabber.SetDecryptionKey (FEncryptionMethod, edtDecryptionKey.Text) then Exit;
   Screen.Cursor := crHourGlass;
   try
      Ok := VideoGrabber.Decrypt_File (edtEncryptDecryptSourceVideoClip.Text,
        edtEncryptDecryptDestinationVideoClip.Text, chkEncryptDecryptOverwriteDestination.IsChecked);
   finally
      Screen.Cursor := crDefault;
   end;
   if Ok then begin
      mmoLog.Lines.Add ('decrypted to ' + edtEncryptDecryptDestinationVideoClip.Text);
   end
   else begin
      mmoLog.Lines.Add ('decryption failed (see the messages above)');
   end;
end;

/// /////////////////////////////////////////////////////////////////////////////
// FIREMONKEY SPECIFIC
/// /////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.SetupVideoGrabber;
/// The video is displayed by a TVideoGrabberFMX control created at runtime into the pnlVideo
/// placeholder (no design-time package required). It wraps a hidden VCL TVideoGrabber, assigned to
/// the VideoGrabber field, so that the rest of the code is the same as in the VCL MainDemo.
begin
   FVideoFMX := TVideoGrabberFMX.Create(Self);
   FVideoFMX.Parent := pnlVideo;
   FVideoFMX.Align := TAlignLayout.Client;
   FVideoFMX.OnMouseDown := VideoDisplayMouseDown;
   FVideoFMX.OnMouseMove := VideoDisplayMouseMove;
   FVideoFMX.OnMouseUp := VideoDisplayMouseUp;
   VideoGrabber := FVideoFMX.VideoGrabber;
   FLastVideoClick := Point(-1, -1); /// -1, -1 = no click yet (GetRGBPixelAt)

   CreateFmxHelpers;

   FLeftVUHost := TNativeChildWindow.Create(Self, pnLeftVUMeter);
   FRightVUHost := TNativeChildWindow.Create(Self, pnRightVUMeter);
   FLeftVUHost.OnHandleChanged := VUHostHandleChanged;
   FRightVUHost.OnHandleChanged := VUHostHandleChanged;

   /// properties set at design time on the TVideoGrabber of the VCL MainDemo
   VideoGrabber.AspectRatioToUse := -1.00000000000000000;
   VideoGrabber.AudioCompressor := 0;
   VideoGrabber.AutoFileNameDateTimeFormat := 'yymmdd_hhmmss_zzz';
   VideoGrabber.AutoFilePrefix := 'vg';
   VideoGrabber.Cropping_Zoom := 1.00000000000000000;
   VideoGrabber.ImageOverlayEnabled := False;
   VideoGrabber.ImageOverlay_AlphaBlend := False;
   VideoGrabber.ImageOverlay_AlphaBlendValue := 180;
   VideoGrabber.ImageOverlay_ChromaKey := False;
   VideoGrabber.ImageOverlay_ChromaKeyLeewayPercent := 25;
   VideoGrabber.ImageOverlay_ChromaKeyRGBColor := 0;
   VideoGrabber.ImageOverlay_Height := -1;
   VideoGrabber.ImageOverlay_LeftLocation := 10;
   VideoGrabber.ImageOverlay_VideoAlignment := oa_LeftTop;
   VideoGrabber.ImageOverlay_StretchToVideoSize := False;
   VideoGrabber.ImageOverlay_TopLocation := 10;
   VideoGrabber.ImageOverlay_Transparent := False;
   VideoGrabber.ImageOverlay_TransparentColorValue := 0;
   VideoGrabber.ImageOverlay_UseTransparentColor := False;
   VideoGrabber.ImageOverlay_Width := -1;
   VideoGrabber.ImageOverlay_TargetDisplay := -1;
   VideoGrabber.MotionDetector_Grid :=
      '5555555555 5555555555 5555555555 5555555555 5555555555 555555555' +
      '5 5555555555 5555555555 5555555555 5555555555';
   VideoGrabber.NDIName := 'DATASTEAD_UNNAMED_SOURCE';
   VideoGrabber.PlayerSpeedRatio := 1.00000000000000000;
   VideoGrabber.TextOverlay_Enabled := False;
   VideoGrabber.TextOverlay_Font.Charset := DEFAULT_CHARSET;
   VideoGrabber.TextOverlay_Font.Color := clAqua;
   VideoGrabber.TextOverlay_Font.Height := -20;
   VideoGrabber.TextOverlay_Font.Name := 'Arial';
   VideoGrabber.TextOverlay_Font.Style := [];
   VideoGrabber.TextOverlay_FontColor := clAqua;
   VideoGrabber.TextOverlay_FontSize := 12;
   VideoGrabber.TextOverlay_HighResFont := True;
   VideoGrabber.TextOverlay_Left := 0;
   VideoGrabber.TextOverlay_Top := 0;
   VideoGrabber.TextOverlay_Right := -1;
   VideoGrabber.TextOverlay_Orientation := to_Horizontal;
   VideoGrabber.TextOverlay_Scrolling := False;
   VideoGrabber.TextOverlay_ScrollingSpeed := 1;
   VideoGrabber.TextOverlay_Shadow := True;
   VideoGrabber.TextOverlay_ShadowColor := clBlack;
   VideoGrabber.TextOverlay_ShadowDirection := cd_SouthEast;
   VideoGrabber.TextOverlay_BkColor := clWhite;
   VideoGrabber.TextOverlay_Align := tf_Left;
   VideoGrabber.TextOverlay_AlphaBlend := False;
   VideoGrabber.TextOverlay_AlphaBlendValue := 180;
   VideoGrabber.TextOverlay_GradientMode := gm_Disabled;
   VideoGrabber.TextOverlay_GradientColor := clNavy;
   VideoGrabber.TextOverlay_VideoAlignment := oa_LeftTop;
   VideoGrabber.TextOverlay_String :=
      'TVideoGrabber text overlay'#13#10'(variables: see SetTextOverlay_Strin' +
      'g in the help)';
   VideoGrabber.TextOverlay_TargetDisplay := -1;
   VideoGrabber.TextOverlay_Transparent := True;
   VideoGrabber.v360_AspectRatio := -1.00000000000000000;
   VideoGrabber.VideoCompression_Quality := 1.00000000000000000;
   VideoGrabber.VideoCompressor := 0;
   VideoGrabber.VideoDelay := 0;
   VideoGrabber.VideoFromImages_TemporaryFile := 'SetOfBitmaps01.dat';
   VideoGrabber.VideoProcessing_RotationCustomAngle := 45.50000000000000000;
   VideoGrabber.StreamInterface_Format := 'mpegts';
   VideoGrabber.StreamInterface_IsRealTime := True;

   /// events assigned at design time on the TVideoGrabber of the VCL MainDemo. OnMouseDown,
   /// OnMouseMove and OnMouseUp come from the native video window, hidden here: replaced by the
   /// mouse events of the TVideoGrabberFMX control (VideoDisplayMouse...)
   VideoGrabber.OnAudioDeviceSelected := VideoGrabberAudioDeviceSelected;
   VideoGrabber.OnClientConnection := VideoGrabberClientConnection;
   VideoGrabber.OnDeviceArrivalOrRemoval := VideoGrabberDeviceArrivalOrRemoval;
   VideoGrabber.OnDeviceLost := VideoGrabberDeviceLost;
   VideoGrabber.OnDiskFull := VideoGrabberDiskFull;
   VideoGrabber.OnDVDiscontinuity := VideoGrabberDVDiscontinuity;
   VideoGrabber.OnDVCommandCompleted := VideoGrabberDVCommandCompleted;
   VideoGrabber.OnFrameBitmap := VideoGrabberFrameBitmap;
   VideoGrabber.OnFrameCaptureCompleted := VideoGrabberFrameCaptureCompleted;
   VideoGrabber.OnFrameProgress2 := VideoGrabberFrameProgress2;
   VideoGrabber.OnGraphBuilt := VideoGrabberGraphBuilt;
   VideoGrabber.OnInactive := VideoGrabberInactive;
   VideoGrabber.OnLog := VideoGrabberLog;
   VideoGrabber.OnMotionDetected := VideoGrabberMotionDetected;
   VideoGrabber.OnMotionNotDetected := VideoGrabberMotionNotDetected;
   VideoGrabber.OnONVIFDiscoveryCompleted := VideoGrabberONVIFDiscoveryCompleted;
   VideoGrabber.OnPlayerBufferingData := VideoGrabberPlayerBufferingData;
   VideoGrabber.OnPlayerEndOfPlaylist := VideoGrabberPlayerEndOfPlaylist;
   VideoGrabber.OnPlayerEndOfStream := VideoGrabberPlayerEndOfStream;
   VideoGrabber.OnPlayerOpened := VideoGrabberPlayerOpened;
   VideoGrabber.OnPreviewStarted := VideoGrabberPreviewStarted;
   VideoGrabber.OnRecordingCompleted := VideoGrabberRecordingCompleted;
   VideoGrabber.OnRecordingPaused := VideoGrabberRecordingPaused;
   VideoGrabber.OnRecordingReadyToStart := VideoGrabberRecordingReadyToStart;
   VideoGrabber.OnRecordingStarted := VideoGrabberRecordingStarted;
   VideoGrabber.OnReencodingCompleted := VideoGrabberReencodingCompleted;
   VideoGrabber.OnReencodingProgress := VideoGrabberReencodingProgress;
   VideoGrabber.OnReencodingStarted := VideoGrabberReencodingStarted;
   VideoGrabber.OnReinitializing := VideoGrabberReinitializing;
   VideoGrabber.OnResizeVideo := VideoGrabberResizeVideo;
   VideoGrabber.OnVideoDeviceSelected := VideoGrabberVideoDeviceSelected;
   VideoGrabber.OnVideoFromBitmapsNextFrameNeeded := VideoGrabberVideoFromBitmapsNextFrameNeeded;
end;

procedure TfrmMainForm.CreateFmxHelpers;
/// FireMonkey has no TRadioGroup and no TUpDown: emulated by TFmxRadioGroup (TGroupBox +
/// TRadioButtons) and TFmxUpDown (2 TSpeedButtons), see FmxDemoHelpers
begin
   rdgIRCutFilter := TFmxRadioGroup.Create(Self, rdgIRCutFilter_Box, rdgIRCutFilterClick);
   rdgRecordingMethod := TFmxRadioGroup.Create(Self, rdgRecordingMethod_Box, rdgRecordingMethodClick);
   grbRecordingTimer := TFmxRadioGroup.Create(Self, grbRecordingTimer_Box, grbRecordingTimerClick);
   rdgCompressMode := TFmxRadioGroup.Create(Self, rdgCompressMode_Box, rdgCompressModeClick);
   rgdHwAccel := TFmxRadioGroup.Create(Self, rgdHwAccel_Box, rgdHwAccelClick);
   rgdFrameGrabberFormat := TFmxRadioGroup.Create(Self, rgdFrameGrabberFormat_Box, rgdFrameGrabberFormatClick);
   rgdFrameGrabber := TFmxRadioGroup.Create(Self, rgdFrameGrabber_Box, rgdFrameGrabberClick);
   rdgTextOverlayAlign := TFmxRadioGroup.Create(Self, rdgTextOverlayAlign_Box, rdgTextOverlayAlignClick);
   rdgTextOverlaySelector := TFmxRadioGroup.Create(Self, rdgTextOverlaySelector_Box, rdgTextOverlaySelectorClick);
   chkOverlayOrientation := TFmxRadioGroup.Create(Self, chkOverlayOrientation_Box, chkOverlayOrientationClick);
   rdgImageOverlaySelector := TFmxRadioGroup.Create(Self, rdgImageOverlaySelector_Box, rdgImageOverlaySelectorClick);
   rdgVideoRotation := TFmxRadioGroup.Create(Self, rdgVideoRotation_Box, rdgVideoRotationClick);
   rdgDeinterlacing := TFmxRadioGroup.Create(Self, rdgDeinterlacing_Box, rdgDeinterlacingClick);
   rdgDetectVideoSignal := TFmxRadioGroup.Create(Self, rdgDetectVideoSignal_Box, nil);
   rdgVideoRenderer := TFmxRadioGroup.Create(Self, rdgVideoRenderer_Box, rdgVideoRendererClick);
   rdg1stDisplayedOn := TFmxRadioGroup.Create(Self, rdg1stDisplayedOn_Box, rdg1stDisplayedOnClick);
   rdg1AspectRatio := TFmxRadioGroup.Create(Self, rdg1AspectRatio_Box, rdg1AspectRatioClick);
   rdg2ndDisplayedOn := TFmxRadioGroup.Create(Self, rdg2ndDisplayedOn_Box, rdg2ndDisplayedOnClick);
   rdg2AspectRatio := TFmxRadioGroup.Create(Self, rdg2AspectRatio_Box, rdg2AspectRatioClick);
   updPlayerFastSeekSpeed := TFmxUpDown.Create(Self, lay_updPlayerFastSeekSpeed, updPlayerFastSeekSpeed_Up, updPlayerFastSeekSpeed_Down, nil, 1, 100, 1, updPlayerFastSeekSpeedClick);
   updXCell := TFmxUpDown.Create(Self, lay_updXCell, updXCell_Up, updXCell_Down, edtXCell, 0, 1000, 2, nil);
   updYCell := TFmxUpDown.Create(Self, lay_updYCell, updYCell_Up, updYCell_Down, edtYCell, 0, 1000, 1, nil);
   updCellSensitivity := TFmxUpDown.Create(Self, lay_updCellSensitivity, updCellSensitivity_Up, updCellSensitivity_Down, edtCellSensitivity, 0, 9, 6, nil);
   updGridColCount := TFmxUpDown.Create(Self, lay_updGridColCount, updGridColCount_Up, updGridColCount_Down, edtGridColCount, 0, 100, 10, nil);
   updGridRowCount := TFmxUpDown.Create(Self, lay_updGridRowCount, updGridRowCount_Up, updGridRowCount_Down, edtGridRowCount, 0, 100, 10, nil);
   updGlobalGridSensitivity := TFmxUpDown.Create(Self, lay_updGlobalGridSensitivity, updGlobalGridSensitivity_Up, updGlobalGridSensitivity_Down, nil, 0, 10000, 5000, updGlobalGridSensitivityClick);
   updTextOverlaySize := TFmxUpDown.Create(Self, lay_updTextOverlaySize, updTextOverlaySize_Up, updTextOverlaySize_Down, nil, 0, 100, 0, updTextOverlaySizeClick);
   updPixellization := TFmxUpDown.Create(Self, lay_updPixellization, updPixellization_Up, updPixellization_Down, edtPixellization, 1, 100, 1, updPixellizationClick);
end;

procedure TfrmMainForm.pctMainChange(Sender: TObject);
begin
   if VideoGrabber = nil then Exit; /// FireMonkey: change events may occur while the form is loading
   /// FMX TTabItem has no OnShow event
   if pctMain.ActiveTab = tbsIPCameras then
   begin
      tbsIPCamerasShow(Sender);
   end;
end;

procedure TfrmMainForm.LogFromAnyThread(const Msg: string);
var
   Text: string;
begin
   Text := Msg;
   RunInMainThread(
      procedure
      begin
         mmoLog.Lines.Add(Text);
      end);
end;

procedure TfrmMainForm.UpdatePlayerTrackBar(PositionMs: Single);
/// replaces the VCL VideoGrabber.PlayerTrackBar property
var
   DurationMs: Single;
begin
   /// do not move the thumb while the user drags it
   if tbrPlayerProgress.IsMouseOver and ((GetKeyState(VK_LBUTTON) and $8000) <> 0) then Exit;
   FUpdatingPlayerTrackBar := True;
   try
      DurationMs := VideoGrabber.PlayerDuration / 10000;
      if (DurationMs > 0) and (tbrPlayerProgress.Max <> DurationMs) then
      begin
         tbrPlayerProgress.Max := DurationMs;
      end;
      tbrPlayerProgress.Value := PositionMs;
   finally
      FUpdatingPlayerTrackBar := False;
   end;
end;

procedure TfrmMainForm.VUHostHandleChanged(Sender: TObject);
/// the native VU meter window has been created or recreated
begin
   if VideoGrabber = nil then Exit;
   if VideoGrabber.VUMeter = vu_Disabled then Exit;
   if Sender = FLeftVUHost then
   begin
      VideoGrabber.SetVUMeterSetting(0, vu_Handle, FLeftVUHost.Handle);
   end
   else
   begin
      VideoGrabber.SetVUMeterSetting(1, vu_Handle, FRightVUHost.Handle);
   end;
end;

procedure TfrmMainForm.VideoDisplayMouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Single);
/// replaces VideoGrabber.OnMouseDown of the VCL MainDemo: the coordinates are converted from the
/// TVideoGrabberFMX control to the video frame
var
   VideoPoint: TPoint;
begin
   if not FVideoFMX.LocalToVideo(PointF(X, Y), VideoPoint) then Exit;
   FLastVideoClick := VideoPoint;
   FLastVideoClickLeft := Button = TMouseButton.mbLeft;
   if chkFreeHandEnabled.IsChecked then
   begin
      if FiFreeHandMouseDrawing < FreeHandMouseCoordinatesMax then
      begin
         FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left := VideoPoint.X;
         FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top := VideoPoint.Y;
         FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right := 0;
         // Right is used as boolean to know if it is a MoveTo or a LineTo
         inc(FiFreeHandMouseDrawing);
         FFreeHandMouseDrawingEnabled := true;
         VideoGrabber.RefreshPlayerOverlays;
      end;
   end;
end;

procedure TfrmMainForm.VideoDisplayMouseMove(Sender: TObject; Shift: TShiftState;
  X, Y: Single);
var
   VideoPoint: TPoint;
begin
   if not FFreeHandMouseDrawingEnabled then Exit;
   if not FVideoFMX.LocalToVideo(PointF(X, Y), VideoPoint) then Exit;
   if FiFreeHandMouseDrawing < FreeHandMouseCoordinatesMax then
   begin
      FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left := VideoPoint.X;
      FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top := VideoPoint.Y;
      FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right := 1;
      // Right is used as boolean to know if it is a MoveTo or a LineTo
      inc(FiFreeHandMouseDrawing);
      VideoGrabber.RefreshPlayerOverlays;
   end;
end;

procedure TfrmMainForm.VideoDisplayMouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Single);
begin
   FFreeHandMouseDrawingEnabled := False;
   VideoGrabber.RefreshPlayerOverlays;
end;

end.

