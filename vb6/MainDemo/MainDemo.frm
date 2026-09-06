VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{1B6425B1-AEDA-4411-B178-A869A86942EE}#1.0#0"; "vidgrab_VB6.ocx"
Begin VB.Form MainForm 
   AutoRedraw      =   -1  'True
   Caption         =   "DataStead Software - TVideoGrabber Demo - VB6 OCX"
   ClientHeight    =   9744
   ClientLeft      =   168
   ClientTop       =   456
   ClientWidth     =   14004
   Icon            =   "MainDemo.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   ScaleHeight     =   487.2
   ScaleMode       =   2  'Point
   ScaleWidth      =   700.2
   StartUpPosition =   2  'CenterScreen
   Begin Vidgrab_VB6.VideoGrabberVB6 VideoGrabberVB61 
      Height          =   3855
      Left            =   3120
      TabIndex        =   15
      Top             =   3840
      Width           =   4935
      AudioBalance    =   0
      AudioInputBalance=   0
      AudioInputLevel =   65535
      AudioInputMono  =   0   'False
      AudioVolume     =   32767
      BufferCount     =   -1
      HoldRecording   =   0   'False
      ImageOverlaySelector=   0
      MpegStreamType  =   0
      PlaylistIndex   =   0
      PlayerDuration  =   1
      PlayerFramePosition=   1
      PlayerTimePosition=   0
      RecordingBacktimedFramesCount=   0
      RecordingCanPause=   0   'False
      SendToDV_DeviceIndex=   -1
      SpeakerBalance  =   0
      SpeakerVolume   =   65535
      TextOverlay_Selector=   0
      TVChannel       =   0
      TVCountryCode   =   0
      TVTunerInputType=   0
      TunerMode       =   0
      VCRHorizontalLocking=   0   'False
      Alignment       =   2
      Caption         =   ""
      Color           =   14737632
      Enabled         =   -1  'True
      FullRepaint     =   0   'False
      ParentColor     =   0   'False
      Object.Visible         =   -1  'True
      AdjustOverlayAspectRatio=   -1  'True
      AdjustPixelAspectRatio=   -1  'True
      Aero            =   0
      AnalogVideoStandard=   0
      ApplicationPriority=   0
      ASFAudioBitRate =   -1
      ASFAudioChannels=   -1
      ASFBufferWindow =   -1
      ASFDeinterlaceMode=   0
      ASFDirectStreamingKeepClientsConnected=   0   'False
      ASFFixedFrameRate=   0   'False
      ASFMediaServerPublishingPoint=   ""
      ASFMediaServerTemplatePublishingPoint=   ""
      ASFMediaServerRemovePublishingPointAfterDisconnect=   0   'False
      ASFNetworkPort  =   0
      ASFNetworkMaxUsers=   5
      ASFProfile      =   -1
      ASFProfileFromCustomFile=   ""
      ASFProfileVersion=   0
      ASFVideoBitRate =   -1
      ASFVideoFrameRate=   0
      ASFVideoHeight  =   -1
      ASFVideoMaxKeyFrameSpacing=   -1
      ASFVideoQuality =   -1
      ASFVideoWidth   =   -1
      AspectRatioToUse=   -1
      AssociateAudioAndVideoDevices=   0   'False
      AVIDurationUpdated=   -1  'True
      AudioChannelRenderMode=   0
      AudioCompressor =   0
      AudioDevice     =   -1
      AudioDeviceRendering=   0   'False
      AudioFormat     =   0
      AudioInput      =   0
      AudioPeakEvent  =   0   'False
      AudioRecording  =   0   'False
      AudioRenderer   =   -1
      AudioStreamNumber=   -1
      AudioSyncAdjustmentEnabled=   0   'False
      AudioSyncAdjustment=   0
      AudioSource     =   0
      AutoConnectRelatedPins=   -1  'True
      AutoFileName    =   2
      AutoFileNameDateTimeFormat=   "yymmdd_hhmmss_zzz"
      AutoFileNameMinDigits=   6
      AutoFilePrefix  =   "vg"
      AutoFileSuffix  =   ""
      AutoRefreshPreview=   0   'False
      AutoStartPlayer =   -1  'True
      AVIFormatOpenDML=   -1  'True
      AVIFormatOpenDMLCompatibilityIndex=   -1  'True
      BackgroundColor =   14737632
      BorderStyle     =   1
      BurstCount      =   3
      BurstInterval   =   0
      BurstMode       =   0   'False
      BurstType       =   0
      CameraControlSettings=   -1  'True
      CaptureFileExt  =   ""
      ColorKey        =   1048592
      ColorKeyEnabled =   0   'False
      CompressionMode =   0
      CompressionType =   0
      Display_Active  =   -1  'True
      Display_AlphaBlendEnabled=   0   'False
      Display_AlphaBlendValue=   180
      Display_AutoSize=   0   'False
      Display_AspectRatio=   2
      Display_Embedded=   -1  'True
      Display_Embedded_FitParent=   0   'False
      Display_FullScreen=   0   'False
      Display_Height  =   240
      Display_Left    =   10
      Display_Monitor =   0
      Display_MouseMovesWindow=   -1  'True
      Display_PanScanRatio=   50
      Display_StayOnTop=   0   'False
      Display_Top     =   10
      Display_TransparentColorEnabled=   0   'False
      Display_TransparentColorValue=   255
      Display_VideoPortEnabled=   -1  'True
      Display_Visible =   -1  'True
      Display_Width   =   320
      DoubleBuffered  =   0   'False
      DroppedFramesPollingInterval=   -1
      DualDisplay_Active=   0   'False
      DualDisplay_AlphaBlendEnabled=   0   'False
      DualDisplay_AlphaBlendValue=   180
      DualDisplay_AutoSize=   0   'False
      DualDisplay_AspectRatio=   2
      DualDisplay_Embedded=   0   'False
      DualDisplay_Embedded_FitParent=   0   'False
      DualDisplay_FullScreen=   0   'False
      DualDisplay_Height=   240
      DualDisplay_Left=   400
      DualDisplay_Monitor=   0
      DualDisplay_MouseMovesWindow=   -1  'True
      DualDisplay_PanScanRatio=   50
      DualDisplay_StayOnTop=   0   'False
      DualDisplay_Top =   20
      DualDisplay_TransparentColorEnabled=   0   'False
      DualDisplay_TransparentColorValue=   255
      DualDisplay_VideoPortEnabled=   0   'False
      DualDisplay_Visible=   -1  'True
      DualDisplay_Width=   320
      DVDateTimeEnabled=   -1  'True
      DVDTitle        =   0
      DVDiscontinuityMinimumInterval=   3
      DVEncoder_VideoFormat=   1
      DVEncoder_VideoResolution=   0
      DVEncoder_VideoStandard=   0
      DVRgb219        =   0   'False
      DVReduceFrameRate=   0   'False
      DVRecordingInNativeFormatSeparatesStreams=   0   'False
      DVTimeCodeEnabled=   -1  'True
      ExtraDLLPath    =   ""
      EventNotificationSynchrone=   -1  'True
      Cropping_Enabled=   0   'False
      Cropping_Height =   120
      Cropping_Outbounds=   0   'False
      Cropping_Width  =   160
      Cropping_X      =   0
      Cropping_Y      =   0
      Cropping_Zoom   =   1
      FixFlickerOrBlackCapture=   0   'False
      FrameCaptureWithoutOverlay=   0   'False
      FrameCaptureHeight=   -1
      FrameCaptureWidth=   -1
      FrameCaptureZoomSize=   100
      FrameGrabber    =   0
      FrameGrabberRGBFormat=   0
      FrameNumberStartsFromZero=   0   'False
      FrameRate       =   0
      FrameRateDivider=   0
      GetLastFrameWaitTimeoutMs=   0
      ImageOverlayEnabled=   0   'False
      ImageOverlay_AlphaBlend=   0   'False
      ImageOverlay_AlphaBlendValue=   180
      ImageOverlay_ChromaKey=   0   'False
      ImageOverlay_ChromaKeyLeewayPercent=   25
      ImageOverlay_ChromaKeyRGBColor=   0
      ImageOverlay_Height=   -1
      ImageOverlay_LeftLocation=   10
      ImageOverlay_VideoAlignment=   0
      ImageOverlay_RotationAngle=   0
      ImageOverlay_StretchToVideoSize=   0   'False
      ImageOverlay_TopLocation=   10
      ImageOverlay_Transparent=   0   'False
      ImageOverlay_TransparentColorValue=   0
      ImageOverlay_UseTransparentColor=   0   'False
      ImageOverlay_Width=   -1
      ImageOverlay_TargetDisplay=   -1
      IPCameraURL     =   ""
      JPEGPerformance =   0
      JPEGProgressiveDisplay=   0   'False
      JPEGQuality     =   100
      LicenseString   =   "N/A"
      LogoDisplayed   =   0   'False
      LogoLayout      =   1
      MixAudioSamples_CurrentSourceLevel=   100
      MixAudioSamples_ExternalSourceLevel=   100
      Mixer_MosaicColumns=   1
      Mixer_MosaicLines=   1
      MotionDetector_CompareBlue=   -1  'True
      MotionDetector_CompareGreen=   -1  'True
      MotionDetector_GreyScale=   0   'False
      MotionDetector_CompareRed=   -1  'True
      MotionDetector_Enabled=   0   'False
      MotionDetector_Grid=   "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 "
      MotionDetector_MaxDetectionsPerSecond=   0
      MotionDetector_ReduceCPULoad=   1
      MotionDetector_ReduceVideoNoise=   0   'False
      MotionDetector_Triggered=   0   'False
      MouseWheelEventEnabled=   0   'False
      MultiplexedInputEmulation=   -1  'True
      MultiplexedRole =   0
      MultiplexedSwitchDelay=   0
      MultiplexedStabilizationDelay=   30
      Multiplexer     =   0
      MuteAudioRendering=   0   'False
      NDIBandwidthType=   3
      NDIGroups       =   ""
      NDIName         =   "DATASTEAD_UNNAMED_SOURCE"
      NDIReceiveTimeoutMs=   5000
      NetworkStreaming=   0
      NetworkStreamingType=   0
      NotificationMethod=   1
      NotificationSleepTime=   -1
      NotificationPriority=   3
      OnFrameBitmapEventSynchrone=   -1  'True
      OpenURLAsync    =   -1  'True
      OverlayAfterTransform=   0   'False
      OverlayEventCallbackAllowed=   0   'False
      PlayerAudioRendering=   -1  'True
      PlayerDVSize    =   0
      PlayerFastSeekSpeedRatio=   4
      PlayerFileName  =   ""
      PlayerForcedCodec=   ""
      PlayerHwAccel   =   0
      PlayerRefreshPausedDisplay=   0   'False
      PlayerRefreshPausedDisplayFrameRate=   0
      PlayerSpeedRatio=   1
      PlayerSpeedRatioConstantAudioPitch=   -1  'True
      PlayerTrackBarSynchrone=   0   'False
      PreallocCapFileCopiedAfterRecording=   -1  'True
      PreallocCapFileEnabled=   0   'False
      PreallocCapFileName=   ""
      PreallocCapFileSizeInMB=   100
      PreviewZoomSize =   100
      RecordingAudioBitRate=   -1
      RecordingVideoBitRate=   -1
      RecordingFileName=   ""
      RecordingFileSizeMaxInMB=   0
      RecordingInNativeFormat=   -1  'True
      RecordingMethod =   0
      RecordingPauseCreatesNewFile=   0   'False
      RecordingOnMotion_Enabled=   0   'False
      RecordingOnMotion_MotionThreshold=   0
      RecordingTimer  =   0
      RecordingTimerInterval=   60
      RecordingOnMotion_NoMotionPauseDelayMs=   5000
      Reencoding_NewVideoClip=   ""
      Reencoding_SourceVideoClip=   ""
      BusyCursor      =   11
      VideoCursor     =   0
      NormalCursor    =   0
      Reencoding_StartTime=   -1
      Reencoding_StartFrame=   -1
      Reencoding_StopTime=   -1
      Reencoding_StopFrame=   -1
      Reencoding_IncludeAudioStream=   -1  'True
      Reencoding_IncludeVideoStream=   -1  'True
      Reencoding_Method=   0
      Reencoding_UseAudioCompressor=   0   'False
      Reencoding_UseFrameGrabber=   -1  'True
      Reencoding_UseVideoCompressor=   0   'False
      Reencoding_WMVOutput=   -1  'True
      QuickDeviceInitialization=   0   'False
      RawAudioSampleCapture=   0   'False
      RawCaptureAsyncEvent=   -1  'True
      RawSampleCaptureLocation=   0
      RawVideoSampleCapture=   0   'False
      RecordingSize   =   0
      ScreenRecordingSizePercent=   100
      ScreenRecordingLayeredWindows=   0   'False
      ScreenRecordingMonitor=   0
      ScreenRecordingNonVisibleWindows=   0   'False
      ScreenRecordingThroughClipboard=   0   'False
      ScreenRecordingWithCursor=   -1  'True
      ShapeOverlayEnabled=   0   'False
      SpeakerControl  =   0   'False
      StoragePath     =   "C:\Users\Michel_2\AppData\Local\Temp\"
      StoreDeviceSettingsInRegistry=   -1  'True
      SynchronizationRole=   0
      Synchronized    =   0   'False
      SyncCommands    =   -1  'True
      SyncPreview     =   0
      TextOverlay_Enabled=   0   'False
      TextOverlay_FontColor=   16776960
      TextOverlay_FontSize=   12
      TextOverlay_HighResFont=   -1  'True
      TextOverlay_Left=   0
      TextOverlay_Top =   0
      TextOverlay_Right=   320
      TextOverlay_Orientation=   0
      TextOverlay_Scrolling=   0   'False
      TextOverlay_ScrollingSpeed=   0
      TextOverlay_Shadow=   -1  'True
      TextOverlay_ShadowColor=   0
      TextOverlay_ShadowDirection=   7
      TextOverlay_BkColor=   16777215
      TextOverlay_Align=   0
      TextOverlay_AlphaBlend=   0   'False
      TextOverlay_AlphaBlendValue=   180
      TextOverlay_GradientMode=   0
      TextOverlay_GradientColor=   8388608
      TextOverlay_VideoAlignment=   0
      TextOverlay_String=   "Example of static text (TextOverlay_Selector=0). Set TextOverlay_Selector=1 to see a demo with variables."
      TextOverlay_TargetDisplay=   -1
      TextOverlay_Transparent=   -1  'True
      TextOverlay_Font=   -1878389988
      ThirdPartyDeinterlacer=   ""
      TranslateMouseCoordinates=   -1  'True
      TVUseFrequencyOverrides=   0   'False
      TunerFrequency  =   -1
      UseClock        =   -1  'True
      Version         =   "v16.6.2.0 (build 4318.220211) - Copyright (c)2022 Datastead"
      v360_Enabled    =   0   'False
      v360_AspectRatio=   -1
      v360_MouseActionPercent=   10
      v360_MouseAction=   2
      v360_MasterAngle=   1
      VideoDevice     =   -1
      VideoCompression_DataRate=   -1
      VideoCompression_KeyFrameRate=   15
      VideoCompression_PFramesPerKeyFrame=   0
      VideoCompression_Quality=   1
      VideoCompression_WindowSize=   -1
      VideoCompressor =   0
      VideoControlSettings=   -1  'True
      VideoDelay      =   0
      VideoFormat     =   0
      VideoFromImages_BitmapsSortedBy=   0
      VideoFromImages_RepeatIndefinitely=   0   'False
      VideoFromImages_SourceDirectory=   "C:\Users\Michel_2\AppData\Local\Temp\"
      VideoFromImages_TemporaryFile=   "SetOfBitmaps01.dat"
      VideoInput      =   0
      VideoProcessing_Brightness=   0
      VideoProcessing_Contrast=   0
      VideoProcessing_Deinterlacing=   0
      VideoProcessing_FlipHorizontal=   0   'False
      VideoProcessing_FlipVertical=   0   'False
      VideoProcessing_GrayScale=   0   'False
      VideoProcessing_Hue=   0
      VideoProcessing_InvertColors=   0   'False
      VideoProcessing_Pixellization=   1
      VideoProcessing_Saturation=   0
      VideoProcessing_Rotation=   0
      VideoProcessing_RotationCustomAngle=   45.5
      VideoQualitySettings=   -1  'True
      VideoRenderer   =   0
      VideoRendererExternal=   0
      VideoRendererExternalIndex=   -1
      VideoRendererPriority=   2
      VideoSize       =   0
      VideoSource     =   0
      VideoSource_FileOrURL=   ""
      VideoSource_FileOrURL_StartTime=   -1
      VideoSource_FileOrURL_StopTime=   -1
      StreamInterface_Format=   "mpegts"
      StreamInterface_FrameRate=   0
      StreamInterface_IsRealTime=   -1  'True
      VideoStreamNumber=   -1
      VideoSubtype    =   0
      VideoVisibleWhenStopped=   0   'False
      VirtualVideoStreamControl=   -1
      VirtualAudioStreamControl=   -1
      VuMeter         =   0
      WebcamStillCaptureButton=   0
      ZoomCoeff       =   1000
      ZoomXCenter     =   0
      ZoomYCenter     =   0
      ParentBackground=   0   'False
   End
   Begin VB.PictureBox picInsetForm 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   2655
      Left            =   240
      ScaleHeight     =   2652
      ScaleWidth      =   13572
      TabIndex        =   14
      Top             =   360
      Width           =   13575
   End
   Begin MSComctlLib.TabStrip tbsTabs 
      Height          =   3135
      Left            =   120
      TabIndex        =   13
      Top             =   0
      Width           =   13815
      _ExtentX        =   24363
      _ExtentY        =   5525
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   14
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "video source"
            Key             =   "videosource"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab2 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "IP cameras"
            Key             =   "ipcamera"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab3 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "audio"
            Key             =   "audio"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab4 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "recording"
            Key             =   "recording"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab5 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "img>vid"
            Key             =   "videofromjpegsorbitmaps"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab6 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "network streaming && WMV"
            Key             =   "networkstreaming"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab7 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "StreamDemos"
            Key             =   "StreamDemos"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab8 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "player"
            Key             =   "player"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab9 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "frame grabber"
            Key             =   "framegrabber"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab10 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "motion detection"
            Key             =   "motiondetection"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab11 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "overlays"
            Key             =   "overlays"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab12 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "video processing"
            Key             =   "videoprocessing"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab13 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "display"
            Key             =   "display"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab14 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "reencoding"
            Key             =   "reencoding"
            ImageVarType    =   2
         EndProperty
      EndProperty
   End
   Begin VB.Frame framPlayerControl 
      Caption         =   "player control"
      Height          =   615
      Left            =   120
      TabIndex        =   5
      Top             =   3120
      Width           =   13815
      Begin VB.CommandButton btnPlayBackwards 
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   8.4
            Charset         =   0
            Weight          =   900
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   320
         Left            =   120
         Picture         =   "MainDemo.frx":0442
         Style           =   1  'Graphical
         TabIndex        =   12
         Top             =   220
         Width           =   495
      End
      Begin VB.CommandButton btnPause 
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   8.4
            Charset         =   0
            Weight          =   900
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   320
         Left            =   720
         Picture         =   "MainDemo.frx":053C
         Style           =   1  'Graphical
         TabIndex        =   11
         Top             =   220
         Width           =   495
      End
      Begin VB.CommandButton btnStop 
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   8.4
            Charset         =   0
            Weight          =   900
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   320
         Left            =   1320
         Picture         =   "MainDemo.frx":0636
         Style           =   1  'Graphical
         TabIndex        =   10
         Top             =   220
         Width           =   495
      End
      Begin VB.CommandButton btnPlay 
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   8.4
            Charset         =   0
            Weight          =   900
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   320
         Left            =   1920
         Picture         =   "MainDemo.frx":0730
         Style           =   1  'Graphical
         TabIndex        =   9
         Top             =   220
         Width           =   495
      End
      Begin VB.CommandButton btnFastRew 
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   8.4
            Charset         =   0
            Weight          =   900
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   320
         Left            =   2520
         Picture         =   "MainDemo.frx":082A
         Style           =   1  'Graphical
         TabIndex        =   8
         Top             =   220
         Width           =   495
      End
      Begin VB.CommandButton btnFastFwd 
         BeginProperty Font 
            Name            =   "Arial Black"
            Size            =   8.4
            Charset         =   0
            Weight          =   900
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   320
         Left            =   3120
         Picture         =   "MainDemo.frx":0924
         Style           =   1  'Graphical
         TabIndex        =   7
         Top             =   220
         Width           =   495
      End
      Begin MSComctlLib.Slider tbrPlayer 
         Height          =   375
         Left            =   3720
         TabIndex        =   6
         Top             =   140
         Width           =   9975
         _ExtentX        =   17590
         _ExtentY        =   656
         _Version        =   393216
      End
   End
   Begin VB.TextBox mmoLog 
      Height          =   4575
      Left            =   120
      MultiLine       =   -1  'True
      TabIndex        =   4
      Top             =   5040
      Width           =   2895
   End
   Begin VB.TextBox edtDVDateTime 
      BackColor       =   &H00C0C0C0&
      Height          =   285
      Left            =   120
      TabIndex        =   3
      Top             =   4680
      Width           =   2895
   End
   Begin VB.TextBox edtFrameCount 
      BackColor       =   &H00C0C0C0&
      Height          =   285
      Left            =   120
      TabIndex        =   2
      Top             =   4320
      Width           =   2895
   End
   Begin VB.TextBox edtStoragePath 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   3960
      Width           =   2895
   End
   Begin MSComDlg.CommonDialog dlgOpen 
      Left            =   13440
      Top             =   3960
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "storage path:"
      Height          =   195
      Index           =   0
      Left            =   120
      TabIndex        =   1
      Top             =   3740
      Width           =   930
   End
   Begin VB.Menu mnuFile 
      Caption         =   "File"
      Begin VB.Menu mnuExit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu mnuSendDVCommands 
      Caption         =   "Send DV commands"
      Begin VB.Menu mnuDVplay 
         Caption         =   "Play"
      End
      Begin VB.Menu mnuDVstop 
         Caption         =   "Stop"
      End
      Begin VB.Menu mnuDVfreeze 
         Caption         =   "Freeze"
      End
      Begin VB.Menu mnuDVthaw 
         Caption         =   "Thaw"
      End
      Begin VB.Menu mnuDVff 
         Caption         =   "FF"
      End
      Begin VB.Menu mnuDVrew 
         Caption         =   "Rew"
      End
      Begin VB.Menu mnuDVrecord 
         Caption         =   "Record"
      End
      Begin VB.Menu mnuDVrecordFreeze 
         Caption         =   "Record freeze"
      End
      Begin VB.Menu mnuRecordStrobe 
         Caption         =   "Record Strobe"
      End
      Begin VB.Menu mnuDVstepFwd 
         Caption         =   "Step Fwd"
      End
      Begin VB.Menu mnuDVstepRev 
         Caption         =   "Step Rev"
      End
      Begin VB.Menu mnuDVmodeShuttle 
         Caption         =   "Mode Shuttle"
      End
      Begin VB.Menu mnuDVplayFastestFwd 
         Caption         =   "Play Fastest Fwd"
      End
      Begin VB.Menu mnuDVplaySlowestFwd 
         Caption         =   "Play Slowest Fwd"
      End
      Begin VB.Menu mnuDVplayFastestRev 
         Caption         =   "Play Fastest Rev"
      End
      Begin VB.Menu mnuDVplaySlowestRev 
         Caption         =   "Play Slowest Rev"
      End
   End
   Begin VB.Menu mnuPriority 
      Caption         =   "Priority"
      Begin VB.Menu mnuPriorityDefault 
         Caption         =   "Default"
      End
      Begin VB.Menu mnuPriorityIdle 
         Caption         =   "Idle"
      End
      Begin VB.Menu mnuPriorityNormal 
         Caption         =   "Normal"
      End
      Begin VB.Menu mnuPriorityHigh 
         Caption         =   "High"
      End
      Begin VB.Menu mnuPriorityRealTime 
         Caption         =   "Real Time"
      End
   End
   Begin VB.Menu mnuOptions 
      Caption         =   "Options"
      Begin VB.Menu mnuResetVideoDevicesSettings 
         Caption         =   "Reset video capture device settings"
      End
   End
   Begin VB.Menu mnuAbout 
      Caption         =   "About"
   End
End
Attribute VB_Name = "MainForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public CanUnload As Boolean

Private frmCurrentForm As Form
Private FormTwips As FORM_TWIPS

Public VideoProcessing_DetectNoVideoSignal As Boolean
Public VideoProcessing_DetectConnexantBlueScreen As Boolean

Public OldVideoSignalState As Boolean

Private Const FreeHandMaxCoordinates As Integer = 5000
Public FreeHandMouseDrawingEnabled As Boolean
Public iFreeHandMouseDrawing As Long
Public DrawCenteredCircleDiameter As Long
Public DrawGridOverlayVideoWidthDivisor As Long
Public FreeHandMouseDrawingColor As Long
Public FreeHandMouseDrawingStyle As Long
Public FreeHandMouseDrawingLineWidth As Long
Public DrawCenteredCircleColor As Long
Public DrawCenteredCircleStyle As Long
Public DrawCenteredCircleLineWidth As Long
Public DrawGridOverlayColor As Long
Public DrawGridOverlayStyle As Long
Public DrawGridOverlayLineWidth As Long
Public SearchBmpFilesOpened As Boolean

Public PickupTransparentColor_MustGetRGBPixel As Boolean
Public PickupTransparentColor_LastRGBPixelValueAtMousePosition As Long
Public PickupTransparentColor_MouseXVideoPosition As Long
Public PickupTransparentColor_MouseYVideoPosition As Long

Private VideoFromBitmapSearch As TFileSearch
Public VideoFromBitmapSourceFolder As String
Public VideoFromBitmapSourceLoop As Boolean
Public VideoFromJPEG As Boolean
Public VideoFromBitmapUsePictureBox As Boolean
Public VideoFromBitmapUsePictureBoxCt As Long

Private FreeHandMouseDrawing(0 To FreeHandMaxCoordinates) As RECT

Public Overlays_chkLinesOverlayEnabled As Long
Public Overlays_chkModifyPixelsEnabled As Boolean

Private StartupWidth, StartupHeight As Long
Private StartupVGWidth As Single, StartupVGHeight As Single


Public Sub RefreshVideoDeviceControls()
   
   Dim CanUseCompression As Boolean
   
   VideoSource.chkReduceDVFrameRate.Value = -VideoGrabberVB61.DVReduceFrameRate
   VideoSource.chkReduceDVFrameRate.Enabled = -VideoGrabberVB61.IsDigitalVideoIn

   Recording.btnPauseRecording.Enabled = VideoGrabberVB61.RecordingCanPause
   Recording.btnResumeRecording.Enabled = VideoGrabberVB61.RecordingCanPause

   VideoSource.btnStreamDialog.Enabled = Not VideoGrabberVB61.IsDigitalVideoIn
   VideoSource.btnCameraControlDialog.Enabled = VideoGrabberVB61.IsCameraControlAvailable
   VideoSource.btnVideoQualityDialog.Enabled = VideoGrabberVB61.IsVideoQualityAvailable
   VideoSource.btnVideoControlDialog.Enabled = VideoGrabberVB61.IsVideoControlAvailable

   VideoSource.cboAnalogVideoStandard.Enabled = VideoGrabberVB61.IsAnalogVideoDecoderAvailable
   VideoSource.cboVideoInputs.Enabled = VideoGrabberVB61.IsVideoCrossbarAvailable

   VideoSource.edtFrameRate.Text = Format(VideoGrabberVB61.FrameRate, "0.00")
   
   Recording.rdgCompressMode.Enabled = True
   Recording.rdgCompressType.Enabled = True
   If Not VideoGrabberVB61.AudioRecording Then
      'Recording.rdgCompressType.ItemIndex = 0
      Recording.rdgCompressType.Enabled = False
   End If
   
   Overlays.lblFrameOverlayRequiresFrameGrabber.Visible = IIf(VideoGrabberVB61.FrameGrabber = fg_Disabled, True, False)
   MotionDetection.lblMotionDetectorRequiresFrameGrabber.Visible = IIf(VideoGrabberVB61.FrameGrabber = fg_Disabled, True, False)
   VideoProcessing.lblSWVideoProcessingRequiresFrameGrabber.Visible = IIf(VideoGrabberVB61.FrameGrabber = fg_Disabled, True, False)
   
   Recording.chkOpenDML.Enabled = IIf(VideoGrabberVB61.RecordingMethod = rm_AVI, True, False)
   
   CanUseCompression = IIf((VideoGrabberVB61.RecordingMethod = rm_AVI) Or (VideoGrabberVB61.RecordingMethod = rm_MKV) Or (VideoGrabberVB61.RecordingMethod = rm_MP4), True, False)
   
   Recording.rdgCompressMode.Enabled = CanUseCompression
   Recording.rdgCompressType.Enabled = CanUseCompression
   Recording.cboVideoCompressors.Enabled = CanUseCompression
   Recording.btnVideoCompressorSettings.Enabled = CanUseCompression
   Recording.cboAudioCompressors.Enabled = CanUseCompression
   Recording.btnAudioCompressorSettings.Enabled = CanUseCompression
   Recording.chkPreallocFile.Enabled = CanUseCompression
   Recording.RefreshRecordingControls

End Sub

Private Sub edtStoragePath_Change()
   VideoGrabberVB61.StoragePath = edtStoragePath.Text
End Sub

Private Sub Form_Load()
   CanUnload = False
   
   Set frmCurrentForm = Nothing
   
   
   With FormTwips
      .CaptionY = Me.ScaleY(GetSystemMetrics(SM_CYCAPTION), vbPixels, vbTwips)
      .FrameX = Me.ScaleX(GetSystemMetrics(SM_CXFRAME), vbPixels, vbTwips)
      .FrameY = Me.ScaleY(GetSystemMetrics(SM_CYFRAME), vbPixels, vbTwips)
   End With
   
   
   tbsTabs_Click

   ' used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
   PickupTransparentColor_MustGetRGBPixel = False
   PickupTransparentColor_LastRGBPixelValueAtMousePosition = -1
   PickupTransparentColor_MouseXVideoPosition = 0
   PickupTransparentColor_MouseYVideoPosition = 0

   
   StartupWidth = Width
   StartupHeight = Height
   StartupVGWidth = VideoGrabberVB61.Width
   StartupVGHeight = VideoGrabberVB61.Height
   

   VideoProcessing_DetectNoVideoSignal = False
   VideoProcessing_DetectConnexantBlueScreen = False
    
   edtStoragePath.Text = VideoGrabberVB61.StoragePath
   
   VideoGrabberVB61.Display_AutoSize = True 'this resizes automatically the component
   
   VideoGrabberVB61.AutoRefreshPreview = True 'this refreshes automatically the preview when changing e.g. the video size, etc...

   ' Video Source
   AssignListToComboBox VideoSource.cboVideoDevices, VideoGrabberVB61.VideoDevices, VideoGrabberVB61.VideoDevice ' this will raise the OnVideoDeviceSelected event that will update the VB controls that depends of the video capture device (like VideoInputs list, the VideoSizes list, etc...)
   AssignListToComboBox VideoSource.cboVideoSource, VideoGrabberVB61.VideoSources, VideoGrabberVB61.VideoSource, 5
   VideoSource.chkAutoRefreshPreview.Value = -VideoGrabberVB61.AutoRefreshPreview
   VideoSource.cboVideoSource.ListIndex = VideoGrabberVB61.VideoSource
   VideoSource.chkScreenRecordingWithCursor.Value = -VideoGrabberVB61.ScreenRecordingWithCursor
   VideoSource.chkMultiplexedInputEmulation.Value = -VideoGrabberVB61.MultiplexedInputEmulation
  
   ' Audio
   AssignListToComboBox Audio.cboAudioDevices, VideoGrabberVB61.AudioDevices, VideoGrabberVB61.AudioDevice       ' this will raise the OnAudioDeviceSelected event that will update the VB controls that depends of the audio capture device (like the AudioInputs list)
   AssignListToComboBox Audio.cboAudioRenderers, VideoGrabberVB61.AudioRenderers, VideoGrabberVB61.AudioRenderer
   Audio.chkRenderAudioDevice = VideoGrabberVB61.AudioDeviceRendering
   Audio.chkMuteAudioRendering = VideoGrabberVB61.MuteAudioRendering

   ' Recording
   SetOptionButtonByIndex Recording.rdgRecordingMethod, VideoGrabberVB61.RecordingMethod
   SetOptionButtonByIndex Recording.rdgRecordingSize, VideoGrabberVB61.RecordingSize
   SetOptionButtonByIndex Recording.rdgCompressMode, VideoGrabberVB61.CompressionMode
   SetOptionButtonByIndex Recording.rdgCompressType, VideoGrabberVB61.CompressionType
   SetOptionButtonByIndex Recording.rdgRecordingTimer, VideoGrabberVB61.RecordingTimer
   
   AssignListToComboBox Recording.cboAudioFormats, VideoGrabberVB61.AudioFormats, VideoGrabberVB61.AudioFormat
   
   Recording.edtPreallocSize.Text = VideoGrabberVB61.PreallocCapFileSizeInMB
   Recording.chkRecordingCanPause.Value = VideoGrabberVB61.RecordingCanPause
   Recording.chkRecordingPauseCreatesNewFile.Value = VideoGrabberVB61.RecordingPauseCreatesNewFile
   
   Recording.chkPreallocFile.Value = VideoGrabberVB61.PreallocCapFileEnabled
   Recording.chkOpenDML.Value = -VideoGrabberVB61.AVIFormatOpenDML
   Recording.chkPreserveNativeFormat.Value = -VideoGrabberVB61.RecordingInNativeFormat

   Recording.chkAudioRecording.Value = VideoGrabberVB61.AudioRecording
   AssignListToComboBox Recording.cboVideoCompressors, VideoGrabberVB61.VideoCompressors, VideoGrabberVB61.VideoCompressor
   AssignListToComboBox Recording.cboAudioCompressors, VideoGrabberVB61.AudioCompressors, VideoGrabberVB61.AudioCompressor

   ' Video From JPEGs Or Bitmaps
   VideoFromJPEGsorBitmaps.chkLoopIndefinitely.Value = 1
   VideoFromJPEGsorBitmaps.rbFromPictureBox.Value = True
   
   ' Network Streaming
   SetOptionButtonByIndex NetworkStreaming.rdgNetworkStreaming, VideoGrabberVB61.NetworkStreaming
   SetOptionButtonByIndex NetworkStreaming.rdgNetworkStreamingType, VideoGrabberVB61.NetworkStreamingType
    
   NetworkStreaming.edtPublishingPoint.Text = VideoGrabberVB61.ASFMediaServerPublishingPoint
   NetworkStreaming.edtNetworkPort.Text = VideoGrabberVB61.ASFNetworkPort
   NetworkStreaming.edtNetworkMaxUsers.Text = VideoGrabberVB61.ASFNetworkMaxUsers

   
   NetworkStreaming.optWMV9profile.Value = True
   ' replace intrinsic control defaults with "-1" defer to profile
   NetworkStreaming.edtASFVideoWidth.Text = -1 ' VideoGrabberVB61.ASFVideoWidth
   NetworkStreaming.edtASFVideoHeight.Text = -1 ' VideoGrabberVB61.ASFVideoHeight
   NetworkStreaming.edtASFVideoBitRate.Text = -1 'VideoGrabberVB61.ASFVideoBitRate
   NetworkStreaming.edtASFVideoMaxKeyFrameSpacing.Text = -1 'VideoGrabberVB61.ASFVideoMaxKeyFrameSpacing
   NetworkStreaming.edtASFVideoQuality.Text = -1 'VideoGrabberVB61.ASFVideoQuality
   NetworkStreaming.edtASFAudioChannels.Text = -1 'VideoGrabberVB61.ASFAudioChannels
   NetworkStreaming.chkASFFixedFrameRate.Value = -VideoGrabberVB61.ASFFixedFrameRate
   NetworkStreaming.cmbASFDeinterlaceMode.ListIndex = VideoGrabberVB61.ASFDeinterlaceMode
   
   
   NetworkStreaming.edtProfileIndex.Text = VideoGrabberVB61.ASFProfile

   ' Player
   Player.edtPlayerSpeedRatio.Text = Format(VideoGrabberVB61.PlayerSpeedRatio, "0.00")

   Player.edtPlayerFastSeekSpeed.Text = VideoGrabberVB61.PlayerFastSeekSpeedRatio

   Player.edtPlayerFastSeekSpeed.Text = VideoGrabberVB61.PlayerFastSeekSpeedRatio

   Player.btnAutoPlay.Value = -VideoGrabberVB61.AutoStartPlayer
   Player.chkPlayerAudioRendering.Value = -VideoGrabberVB61.PlayerAudioRendering
   Player.chkRefreshPausedDisplay.Value = -VideoGrabberVB61.PlayerRefreshPausedDisplay

   ' Frame Grabber
   SetOptionButtonByIndex FrameGrabber.rgdFrameGrabber, VideoGrabberVB61.FrameGrabber
   SetOptionButtonByIndex FrameGrabber.rgdFrameGrabberFormat, VideoGrabberVB61.FrameGrabberRGBFormat
   SetOptionButtonByIndex FrameGrabber.rdgAutoFileName, VideoGrabberVB61.AutoFileName
   
   FrameGrabber.chkUseThisFileName.Value = 0
   FrameGrabber.edtAVIAutoFilePrefix.Text = VideoGrabberVB61.AutoFilePrefix

   FrameGrabber.edtFrameGrabberCaptureWidth.Text = -1
   FrameGrabber.edtFrameGrabberCaptureHeight.Text = -1
   FrameGrabber.edtAVIAutoFilePrefix.Text = "vg"

   FrameGrabber.edtBurstCount.Text = VideoGrabberVB61.BurstCount
   FrameGrabber.edtBurstInterval.Text = VideoGrabberVB61.BurstInterval
   FrameGrabber.tbrCaptureZoomSize.Value = VideoGrabberVB61.FrameCaptureZoomSize

   ' Motion Detection

   MotionDetection.chkMotionDetectionEnabled.Value = -VideoGrabberVB61.MotionDetector_Enabled
   MotionDetection.chkCompareRed.Value = -VideoGrabberVB61.MotionDetector_CompareRed
   MotionDetection.chkCompareGreen.Value = -VideoGrabberVB61.MotionDetector_CompareGreen
   MotionDetection.chkCompareBlue.Value = -VideoGrabberVB61.MotionDetector_CompareBlue
   MotionDetection.chk_GreyScale.Value = -VideoGrabberVB61.MotionDetector_GreyScale
   MotionDetection.chkReduceVideoNoise.Value = -VideoGrabberVB61.MotionDetector_ReduceVideoNoise
   MotionDetection.edtGrid.Text = VideoGrabberVB61.MotionDetector_Grid
   MotionDetection.mmoSensitivityGrid.Text = VideoGrabberVB61.MotionDetector_Get2DTextGrid
   MotionDetection.edtGridColCount.Text = VideoGrabberVB61.MotionDetector_GridXCount
   MotionDetection.edtGridRowCount.Text = VideoGrabberVB61.MotionDetector_GridYCount

   ' Frame Overlay
   Overlays_chkModifyPixelsEnabled = False  ' enabled/disabled by chkModifyPixels, tested in the OnFrameBitmap event
   DrawCenteredCircleDiameter = 0           ' set from the Overlay tab to enable drawing a circle if > 0
   DrawGridOverlayVideoWidthDivisor = 0     ' set from the Overlay tab chkDrawGridOverlay to enable drawing a grid if > 1
   FreeHandMouseDrawingEnabled = False      ' used for free-hand mouse drawing
   iFreeHandMouseDrawing = 0                ' used for free-hand mouse drawing
   FreeHandMouseDrawingColor = vbRed        ' set from the Overlay tab
   Overlays.btnFreeHandMouseDrawingColor.BackColor = vbRed
   FreeHandMouseDrawingStyle = PS_SOLID     ' set from the Overlay tab
   FreeHandMouseDrawingLineWidth = 1        ' set from the Overlay tab
   DrawCenteredCircleColor = vbGreen        ' set from the Overlay tab
   Overlays.btnDrawCenteredCircleColor.BackColor = vbGreen
   DrawCenteredCircleStyle = PS_SOLID       ' set from the Overlay tab
   DrawCenteredCircleLineWidth = 1          ' set from the Overlay tab
   DrawGridOverlayColor = vbBlue            ' set from the Overlay tab
   Overlays.btnDrawGridOverlayColor.BackColor = vbBlue
   DrawGridOverlayStyle = PS_SOLID          ' set from the Overlay tab
   DrawGridOverlayLineWidth = 1             ' set from the Overlay tab
   SearchBmpFilesOpened = False             ' used for the "video from bitmaps" in the VideoGrabberVideoFromBitmaps_NextFrameNeeded event

   Overlays.mmoTextOverlayString.Text = VideoGrabberVB61.TextOverlay_String
   Overlays.chkTextOverlayEnabled.Value = VideoGrabberVB61.TextOverlay_Enabled
   Overlays.chkTextOverlayTransparent.Value = -VideoGrabberVB61.TextOverlay_Transparent

   ' Video Processing
   SetOptionButtonByIndex VideoProcessing.rdgVideoRotation, VideoGrabberVB61.VideoProcessing_Rotation
   SetOptionButtonByIndex VideoProcessing.rdgDeinterlacing, VideoGrabberVB61.VideoProcessing_Deinterlacing
   
   VideoProcessing.edtVideoRotation.Text = VideoGrabberVB61.VideoProcessing_RotationCustomAngle
   
   VideoProcessing.edtVideoPixelization.Text = VideoGrabberVB61.VideoProcessing_Pixellization
   
   VideoProcessing.tbrBrightness.Value = VideoGrabberVB61.VideoProcessing_Brightness
   VideoProcessing.tbrContrast.Value = VideoGrabberVB61.VideoProcessing_Contrast
   VideoProcessing.tbrSaturation.Value = VideoGrabberVB61.VideoProcessing_Saturation
   VideoProcessing.tbrHue.Value = VideoGrabberVB61.VideoProcessing_Hue

   VideoProcessing.chkGreyScale.Value = VideoGrabberVB61.VideoProcessing_GrayScale
   VideoProcessing.chkInvertColors.Value = VideoGrabberVB61.VideoProcessing_InvertColors
   VideoProcessing.chkFlipVertical.Value = VideoGrabberVB61.VideoProcessing_FlipVertical
   VideoProcessing.chkFlipHorizontal.Value = VideoGrabberVB61.VideoProcessing_FlipHorizontal

   VideoProcessing.chkCroppingEnabled.Value = VideoGrabberVB61.Cropping_Enabled
   VideoProcessing.chkCroppingOutbounds.Value = VideoGrabberVB61.Cropping_Outbounds
   VideoProcessing.edtCroppingWidth.Text = VideoGrabberVB61.Cropping_Width
   VideoProcessing.edtCroppingHeight.Text = VideoGrabberVB61.Cropping_Height
   VideoProcessing.trkCroppingZoom.Value = VideoGrabberVB61.Cropping_Zoom * 100

   ' trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event
   VideoProcessing.trkCroppingY.Value = VideoGrabberVB61.Cropping_Y
   VideoProcessing.trkCroppingX.Value = VideoGrabberVB61.Cropping_X
   
   VideoProcessing.RefreshVMR9Processing

   ' Display
   SetOptionButtonByIndex Display.rdgVideoRenderer, VideoGrabberVB61.VideoRenderer
   Display.chkBorder.Value = IIf(VideoGrabberVB61.BorderStyle = bsSingle, Checked, Unchecked)
   Display.chkVideoVisibleWhenStopped.Value = -VideoGrabberVB61.VideoVisibleWhenStopped
   Display.chkAdjustPixelAspectRatio.Value = -VideoGrabberVB61.AdjustPixelAspectRatio
   Display.RefreshDisplayOptions

   ' Reencoding
   SetOptionButtonByIndex Reencoding.rdgReencodingMethod, VideoGrabberVB61.Reencoding_Method
   Reencoding.chkWMVOutput.Value = -VideoGrabberVB61.Reencoding_WMVOutput
   Reencoding.chkIncludeVideoStream.Value = -VideoGrabberVB61.Reencoding_IncludeVideoStream
   Reencoding.chkIncludeAudioStream.Value = -VideoGrabberVB61.Reencoding_IncludeAudioStream
   Reencoding.chkUseFrameGrabber.Value = -VideoGrabberVB61.Reencoding_UseFrameGrabber
   Reencoding.chkUseCurrentVideoCompressor.Value = -VideoGrabberVB61.Reencoding_UseVideoCompressor
   Reencoding.chkUseCurrentAudioCompressor.Value = -VideoGrabberVB61.Reencoding_UseAudioCompressor
   Reencoding.edtStartTime.Text = VideoGrabberVB61.Reencoding_StartTime
   Reencoding.edtStopTime.Text = VideoGrabberVB61.Reencoding_StopTime
   Reencoding.edtStartTime.Text = VideoGrabberVB61.Reencoding_StartFrame
   Reencoding.edtStopTime.Text = VideoGrabberVB61.Reencoding_StopFrame
   
'   VideoGrabberVB61.VideoDevice = VideoGrabberVB61.VideoDeviceIndex("JVC GR-DVL357EG (WDM)")
 
End Sub

Private Sub mnuPriorityDefault_Click()
    VideoGrabberVB61.ApplicationPriority = ap_default
End Sub

Private Sub mnuPriorityHigh_Click()
    VideoGrabberVB61.ApplicationPriority = ap_high
End Sub

Private Sub mnuPriorityIdle_Click()
    VideoGrabberVB61.ApplicationPriority = ap_idle
End Sub

Private Sub mnuPriorityNormal_Click()
    VideoGrabberVB61.ApplicationPriority = ap_normal
End Sub

Private Sub mnuPriorityRealTime_Click()
    VideoGrabberVB61.ApplicationPriority = ap_realtime
End Sub

Private Sub mnuResetVideoDevicesSettings_Click()
   VideoGrabberVB61.ResetVideoDeviceSettings
End Sub

Private Sub tbsTabs_Click()
    
    
    If Not frmCurrentForm Is Nothing Then
        ' hide, rather than unload, to maintain settings
        frmCurrentForm.Hide
    End If
    
    Select Case tbsTabs.SelectedItem.Key
    Case "videosource"
        Set frmCurrentForm = VideoSource
        
    Case "ipcamera"
        Set frmCurrentForm = IPCamera
    
    Case "audio"
        Set frmCurrentForm = Audio
        
    Case "recording"
        Set frmCurrentForm = Recording
        
    Case "videofromjpegsorbitmaps"
        Set frmCurrentForm = VideoFromJPEGsorBitmaps
    
    Case "networkstreaming"
        Set frmCurrentForm = NetworkStreaming
    
    Case "player"
        Set frmCurrentForm = Player
    
    Case "framegrabber"
        Set frmCurrentForm = FrameGrabber
    
    Case "motiondetection"
        Set frmCurrentForm = MotionDetection
    
    Case "overlays"
        Set frmCurrentForm = Overlays
    
    Case "videoprocessing"
        Set frmCurrentForm = VideoProcessing
    
    Case "display"
        Set frmCurrentForm = Display
    
    Case "reencoding"
        Set frmCurrentForm = Reencoding
    
        Case "StreamDemos"
        Set frmCurrentForm = StreamDemos

    End Select
    
    If Not frmCurrentForm Is Nothing Then
        InsetForm frmCurrentForm, picInsetForm.hwnd
    End If
    
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    FileSearch_Close VideoFromBitmapSearch
    CanUnload = True
    End
End Sub

Private Sub mnuAbout_Click()
   VideoGrabberVB61.About
   End Sub

Private Sub SendDVCommand(DvCommand As TxDVCommand)
   If VideoGrabberVB61.SendDVCommand(DvCommand) Then
      AddLog mmoLog, "DV command sent..."
   Else
      If (VideoGrabberVB61.CurrentState <> cs_Preview) And (VideoGrabberVB61.CurrentState <> cs_Recording) Then
         AddLog mmoLog, "DV command failed. Preview must be running!"
      Else
         AddLog mmoLog, "DV command failed."
      End If
   End If
End Sub

Private Sub mnuDVff_Click()
    SendDVCommand (dv_Ff)
End Sub

Private Sub mnuDVfreeze_Click()
    SendDVCommand (dv_Freeze)
End Sub

Private Sub mnuDVmodeShuttle_Click()
    SendDVCommand (dv_ModeShuttle)
End Sub

Private Sub mnuDVplay_Click()
    SendDVCommand (dv_Play)
End Sub

Private Sub mnuDVplayFastestFwd_Click()
    SendDVCommand (dv_PlayFastestFwd)
End Sub

Private Sub mnuDVplayFastestRev_Click()
    SendDVCommand (dv_PlayFastestRev)
End Sub

Private Sub mnuDVplaySlowestFwd_Click()
    SendDVCommand (dv_PlaySlowestFwd)
End Sub

Private Sub mnuDVplaySlowestRev_Click()
    SendDVCommand (dv_PlaySlowestRev)
End Sub

Private Sub mnuDVrecord_Click()
    SendDVCommand (dv_Record)
End Sub

Private Sub mnuDVrecordFreeze_Click()
    SendDVCommand (dv_RecordFreeze)
End Sub

Private Sub mnuDVrew_Click()
    SendDVCommand (dv_Rew)
End Sub

Private Sub mnuDVstepFwd_Click()
    SendDVCommand (dv_StepFwd)
End Sub

Private Sub mnuDVstepRev_Click()
    SendDVCommand (dv_StepRev)
End Sub

Private Sub mnuDVstop_Click()
    SendDVCommand (dv_Stop)
End Sub

Private Sub mnuDVthaw_Click()
    SendDVCommand (dv_Thaw)
End Sub

Private Sub mnuExit_Click()
   Unload Me
End Sub

Private Sub mnuRecordStrobe_Click()
    SendDVCommand (dv_RecordStrobe)
End Sub

Private Sub btnPlayBackwards_Click()
    Me.VideoGrabberVB61.RunPlayerBackwards
End Sub

Private Sub btnPause_Click()
    Me.VideoGrabberVB61.PausePlayer
End Sub

Private Sub btnStop_Click()
    Me.VideoGrabberVB61.StopPlayer
End Sub

Private Sub btnPlay_Click()
    Me.VideoGrabberVB61.RunPlayer
End Sub

Private Sub btnFastRew_Click()
    Me.VideoGrabberVB61.RewindPlayer
End Sub

Private Sub btnFastFwd_Click()
    Me.VideoGrabberVB61.FastForwardPlayer
End Sub

Private Sub tbrPlayer_Change()
    VideoGrabberVB61.PlayerFramePosition = tbrPlayer.Value
End Sub

Private Sub tbrPlayer_KeyDown(KeyCode As Integer, Shift As Integer)
    VideoGrabberVB61.NotifyPlayerTrackbarAction (tba_KeyDown)
End Sub

Private Sub tbrPlayer_KeyUp(KeyCode As Integer, Shift As Integer)
    VideoGrabberVB61.NotifyPlayerTrackbarAction (tba_KeyUp)
End Sub

Private Sub tbrPlayer_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    VideoGrabberVB61.NotifyPlayerTrackbarAction (tba_MouseDown)
End Sub

Private Sub tbrPlayer_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    VideoGrabberVB61.NotifyPlayerTrackbarAction (tba_MouseUp)
End Sub

Private Sub tbrPlayer_Scroll()
    VideoGrabberVB61.PlayerFramePosition = tbrPlayer.Value
End Sub

Private Sub VideoGrabberVB61_OnAudioDeviceSelected()
   ' from this event set the parameters that change when the current audio capture device change
   Audio.cboAudioDevices.Text = VideoGrabberVB61.AudioDeviceName
   Audio.cboAudioDevices.ListIndex = VideoGrabberVB61.AudioDevice ' be sure the listbox index matches the current index value

   AssignListToComboBox Audio.cboAudioInputs, VideoGrabberVB61.AudioInputs, VideoGrabberVB61.AudioInput
   
   Audio.tbrAudioInputLevel.Value = VideoGrabberVB61.AudioInputLevel
   Audio.tbrAudioInputBalance.Value = VideoGrabberVB61.AudioInputBalance
   Audio.chkAudioInputMono.Value = IIf(VideoGrabberVB61.AudioInputMono, Checked, Unchecked)

End Sub

Private Sub VideoGrabberVB61_OnClientConnection(ByVal Connected As Boolean, ByVal ClientInfo As String)
   If Connected Then
      AddLog mmoLog, "client connected: " + ClientInfo
   Else
      AddLog mmoLog, "client disconnected: " + ClientInfo
   End If
End Sub

Private Sub VideoGrabberVB61_OnCopyPreallocDataCompleted(ByVal SourceFile As String, ByVal DestFile As String, ByVal Success As Boolean)
   If Success Then
      AddLog mmoLog, " successfully copied to " + DestFile + "."
   Else
      AddLog mmoLog, "ERROR: Failed to copy " + SourceFile + " to " + DestFile + "!"
   End If
End Sub

Private Sub VideoGrabberVB61_OnCopyPreallocDataProgress(ByVal Percent As Long, ByVal Position As Double, ByVal Duration As Double)
   AddLog mmoLog, "copying data: " + Str(Percent) + "% completed."
End Sub

Private Sub VideoGrabberVB61_OnCopyPreallocDataStarted(ByVal SourceFile As String, ByVal DestFile As String)
   AddLog mmoLog, "copying data from " + SourceFile + " to " + DestFile + "..."
End Sub

Private Sub VideoGrabberVB61_OnCreatePreallocFileCompleted(ByVal FileName As String, ByVal Success As Boolean)
    If Success Then
        AddLog mmoLog, "preallocated file " + FileName + " successfully created."
    Else
        AddLog mmoLog, "ERROR: Failed to preallocate " + FileName
    End If
End Sub

Private Sub VideoGrabberVB61_OnCreatePreallocFileProgress(ByVal Percent As Long, ByVal Position As Double, ByVal Duration As Double)
   AddLog mmoLog, Str(Percent) + "% of preallocated file completed"
End Sub

Private Sub VideoGrabberVB61_OnCreatePreallocFileStarted(ByVal FileName As String)
   AddLog mmoLog, "preallocating file " + FileName + "..."
End Sub

Private Sub VideoGrabberVB61_OnDeviceArrivalOrRemoval(ByVal IsDeviceArrival As Boolean, ByVal IsVideoDevice As Boolean, ByVal DeviceName As String, ByVal DeviceIndex As Long)

   Dim AudioOrVideoDevice As String

   If IsVideoDevice Then
      AudioOrVideoDevice = "video device "
   Else
      AudioOrVideoDevice = "audio device "
   End If
   If IsDeviceArrival Then
      AddLog mmoLog, AudioOrVideoDevice + " arrival:"
   Else
      AddLog mmoLog, AudioOrVideoDevice + " removal:"
   End If
   AddLog mmoLog, DeviceName
   If IsVideoDevice Then
        AssignListToComboBox VideoSource.cboVideoDevices, VideoGrabberVB61.VideoDevices, VideoGrabberVB61.VideoDevice
   Else
        AssignListToComboBox Audio.cboAudioDevices, VideoGrabberVB61.AudioDevices, VideoGrabberVB61.AudioDevice
   End If
End Sub

Private Sub VideoGrabberVB61_OnDeviceLost()
    AddLog mmoLog, "DEVICE LOST!"
    AssignListToComboBox VideoSource.cboVideoDevices, VideoGrabberVB61.VideoDevices, VideoGrabberVB61.VideoDevice
    AssignListToComboBox Audio.cboAudioDevices, VideoGrabberVB61.AudioDevices, VideoGrabberVB61.AudioDevice
End Sub

Private Sub VideoGrabberVB61_OnDirectNetworkStreamingHostUrl(ByVal HostUrl As String, ByVal HostName As String, ByVal HostPort As Long)
   AddLog mmoLog, "streaming URL: " + HostUrl
   AddLog mmoLog, "streaming host: " + HostName
   AddLog mmoLog, "streaming port: " + Str(HostPort)
End Sub

Private Sub VideoGrabberVB61_OnDiskFull()
    AddLog mmoLog, "DISK FULL!"
End Sub

Private Sub VideoGrabberVB61_OnDVCommandCompleted(ByVal NewStateValue As Long, ByVal NewStateLabel As String)
   AddLog mmoLog, "camcorder state: " + NewStateLabel
End Sub

Private Sub VideoGrabberVB61_OnDVDiscontinuity(DeliverNewFrame As Variant)
   ' SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncomment the 2 lines below)
   ' DeliverNewFrame = False
   ' VideoGrabberVB61.RecordToNewFileNow

   ' SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncomment the 2 lines below)
   ' DeliverNewFrame = False
   ' VideoGrabberVB61.StopRecording
   
   ' Important: from this event you should not perform any actions with the potential to block, such as
   ' holding a critical section or waiting on another thread. Also, do not call any GDI or USER32.DLL APIs.
End Sub

Public Sub SetEnumerateWindows(WindowName As String, ExactMatch As Boolean)
    ReDim wenScreenRecordingWindow(0)
    lngScreenRecordingWindow = 0
    strScreenRecordingWindow = WindowName
    boolScreenRecordingWindow = ExactMatch
    VideoSource.lblEnumerateWindows.Caption = IIf(strScreenRecordingWindow = "", "", CStr(lngScreenRecordingWindow))
End Sub

Private Sub VideoGrabberVB61_OnEnumerateWindows(ByVal WindowHandle As Long, ByVal WindowName As String, ByVal WindowClass As String)
    
    ' EnumerateWindows begins gathering of visible windows
    ' Demo proc SetEnumerateWindows initializes array wenScreenRecordingWindow(),
    '  called in OnRecordingReadyToStart event, which is instigated by
    '  enabling HoldRecording before calling StartRecording
    '  (see btnStartRecordingControlled in Recording form)
    Dim b As Boolean
    If (LCase(strScreenRecordingWindow) = LCase(WindowName)) Then
        b = True
    ElseIf (Not boolScreenRecordingWindow) And InStr(1, LCase(WindowName), LCase(strScreenRecordingWindow)) > 0 Then
        b = True
    Else
        b = False
    End If
    If b Then
        ReDim Preserve wenScreenRecordingWindow(lngScreenRecordingWindow)
        With wenScreenRecordingWindow(lngScreenRecordingWindow)
            .WindowHandle = WindowHandle
            .WindowClass = WindowClass
            .WindowName = WindowName
        End With
        lngScreenRecordingWindow = lngScreenRecordingWindow + 1
        
        VideoSource.lblEnumerateWindows.Caption = CStr(lngScreenRecordingWindow)
        
    End If
    
End Sub

Private Sub VideoGrabberVB61_OnFrameBitmap(ByVal FrameInfo As Long, ByVal BITMAPINFO As Long)

   Dim NewFrameInfo As TFrameInfo
   Dim NewFrameBitmap As TFrameBitmapInfo
   
   CopyMemory VarPtr(NewFrameInfo), FrameInfo, LenB(NewFrameInfo)
   CopyMemory VarPtr(NewFrameBitmap), BITMAPINFO, LenB(NewFrameBitmap)
   
    ' read the (1) comment at the bottom of this unit
    
    
    Dim i, j As Long
    Dim Point As POINTAPI
    Dim OldPen, NewPen As Long
    Dim NewVideoSignalState As Boolean
    Dim OldBrush, NewBrush As Long
    Dim XStep As Long, YStep As Long, XLength As Long, YLength As Long, XDraw As Long, YDraw As Long
    Dim iGrid As Long
    Dim CircleLeft, CircleTop As Long
    Dim BitmapLinePtr As Long
    Dim PixelSize As Long
    Dim PixelPtr As Long
    Dim PixelColor As Byte
    Dim ColorIndex As Long
    
    Const REDINDEX = 0
    Const GREENINDEX = 1
    Const BLUEINDEX = 2
    
    
    '    From this event you should not perform any actions with the potential to block:
    '    1. do not hold a critical section or wait on another thread,
    '    2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
    '    3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
    '       of a ListBox component. If you need to read a such property, set an intermediary variable when
    '       the property changes, and then read the intermediary variable from this event.
        
    ' e.g. you must NOT test directly "Overlays.chkBitmapOverlayEnabled.value = Checked" from this event.
    ' Use an intermediary boolean like "Overlays_BitmapOverlayEnabled" below (look at the "Overlays" form)
    
    ' DIRECT ACCESS TO THE PIXELS (in this example we set a RGB color to 0, depending on the RGB24 or RGB32 format (you can choose it in the "Frame Grabber tab)
    If Overlays_chkModifyPixelsEnabled Then
        PixelColor = 0
        BitmapLinePtr = NewFrameBitmap.BitmapDataPtr
        If NewFrameBitmap.BitmapBitsPerPixel = 32 Then
            PixelSize = 4
            ColorIndex = GREENINDEX ' in RGB32 this demo removes the green
        ElseIf NewFrameBitmap.BitmapBitsPerPixel = 24 Then
            PixelSize = 3
            ColorIndex = BLUEINDEX  ' in RGB24 this demo removes the green
        Else
            PixelSize = 0
        End If
        If PixelSize <> 0 Then
            PixelPtr = BitmapLinePtr
            For i = 0 To NewFrameBitmap.BitmapHeight - 1
                For j = 0 To NewFrameBitmap.BitmapWidth - 1
                   CopyMemory PixelPtr + ColorIndex, VarPtr(PixelColor), 1
                   PixelPtr = PixelPtr + PixelSize
                Next
                BitmapLinePtr = BitmapLinePtr + NewFrameBitmap.BitmapLineSize
            Next
        End If
    End If
    
    
    ' GRID DRAWING, Size = NewFrameBitmap.BitmapWidth / DrawGridOverlayVideoWidthDivisor
    If DrawGridOverlayVideoWidthDivisor > 1 Then
        NewPen = CreatePen(DrawGridOverlayStyle, DrawGridOverlayLineWidth, DrawGridOverlayColor)
        NewBrush = GetStockObject(NULL_BRUSH)
        OldPen = SelectObject(NewFrameBitmap.BitmapDC, NewPen)
        OldBrush = SelectObject(NewFrameBitmap.BitmapDC, NewBrush)

        XStep = NewFrameBitmap.BitmapWidth / DrawGridOverlayVideoWidthDivisor
        YStep = XStep
        XLength = NewFrameBitmap.BitmapWidth
        YLength = NewFrameBitmap.BitmapHeight
        XDraw = XStep
        YDraw = 0
        
        Do
            MoveToEx NewFrameBitmap.BitmapDC, XDraw, YDraw, Point
            LineTo NewFrameBitmap.BitmapDC, XDraw, YLength
            XDraw = XDraw + XStep
        Loop While XDraw < XLength
        XDraw = 0
        If YLength Mod YStep = 0 Then
            iGrid = (YLength / YStep) - 1
            YDraw = YStep
        Else
            iGrid = Int(YLength / YStep) + 1
            YDraw = (YLength - (YStep * iGrid)) \ 2
        End If
        Do
            MoveToEx NewFrameBitmap.BitmapDC, XDraw, YDraw, Point
            LineTo NewFrameBitmap.BitmapDC, XLength, YDraw
            YDraw = YDraw + YStep
        Loop While YDraw < YLength
        
        SelectObject NewFrameBitmap.BitmapDC, OldBrush
        DeleteObject NewBrush
        SelectObject NewFrameBitmap.BitmapDC, OldPen
        DeleteObject NewPen
    End If
    
    ' DRAWING A CENTERED CIRCLE, DIAMETER = DrawCenteredCircleDiameter
    If DrawCenteredCircleDiameter > 0 Then
        NewPen = CreatePen(DrawCenteredCircleStyle, DrawCenteredCircleLineWidth, DrawCenteredCircleColor)
        NewBrush = GetStockObject(NULL_BRUSH)
        OldPen = SelectObject(NewFrameBitmap.BitmapDC, NewPen)
        OldBrush = SelectObject(NewFrameBitmap.BitmapDC, NewBrush)

        CircleTop = (NewFrameBitmap.BitmapHeight - DrawCenteredCircleDiameter) / 2
        CircleLeft = (NewFrameBitmap.BitmapWidth - DrawCenteredCircleDiameter) / 2
        
        Ellipse NewFrameBitmap.BitmapDC, CircleLeft, CircleTop, CircleLeft + DrawCenteredCircleDiameter, CircleTop + DrawCenteredCircleDiameter
        
        SelectObject NewFrameBitmap.BitmapDC, OldBrush
        DeleteObject NewBrush
        SelectObject NewFrameBitmap.BitmapDC, OldPen
        DeleteObject NewPen
    End If
   
    ' FREE HAND DRAWING
    If iFreeHandMouseDrawing > 0 Then ' see the VideoGrabberMouse... events
       NewPen = CreatePen(FreeHandMouseDrawingStyle, FreeHandMouseDrawingLineWidth, FreeHandMouseDrawingColor)
       OldPen = SelectObject(NewFrameBitmap.BitmapDC, NewPen)
       For i = 0 To iFreeHandMouseDrawing - 1
         If FreeHandMouseDrawing(i).Right = 0 Then '// Right is used as boolean to know if it is a MoveTo or a LineTo
            MoveToEx NewFrameBitmap.BitmapDC, FreeHandMouseDrawing(i).Left, FreeHandMouseDrawing(i).Top, Point
            SetPixel NewFrameBitmap.BitmapDC, FreeHandMouseDrawing(i).Left, FreeHandMouseDrawing(i).Top, vbRed
         Else
            LineTo NewFrameBitmap.BitmapDC, FreeHandMouseDrawing(i).Left, FreeHandMouseDrawing(i).Top
         End If
       Next
       SelectObject NewFrameBitmap.BitmapDC, OldPen
       DeleteObject NewPen
   End If
   
   
   ' VIDEO SIGNAL DETECTION
   NewVideoSignalState = OldVideoSignalState
   
   If VideoProcessing_DetectNoVideoSignal Then
        NewVideoSignalState = VideoGrabberVB61.IsVideoSignalDetected(False, True, 30, 30, 30, True)
   ElseIf VideoProcessing_DetectConnexantBlueScreen Then
        NewVideoSignalState = VideoGrabberVB61.IsVideoSignalDetected(True, False, 0, 0, 0, False)
   End If
   
   If NewVideoSignalState <> OldVideoSignalState Then
        OldVideoSignalState = NewVideoSignalState
        If NewVideoSignalState Then
            AddLog mmoLog, "Video signal is back"
        Else
            AddLog mmoLog, "VIDEO SIGNAL LOST"
        End If
   End If
    
   ' used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
   If PickupTransparentColor_MustGetRGBPixel Then
      PickupTransparentColor_MustGetRGBPixel = False
      PickupTransparentColor_LastRGBPixelValueAtMousePosition = VideoGrabberVB61.GetRGBPixelAt(PickupTransparentColor_MouseXVideoPosition, PickupTransparentColor_MouseYVideoPosition)
   End If
   
End Sub

Private Sub VideoGrabberVB61_OnFrameProgress2(ByVal FrameInfo As Long)
    
    Dim NewFrame As TFrameInfo ' TFrameInfo is declared in VidGrabUtil.pas
    Dim DVTimeCode As String
    Dim DVDateTime As String
    Dim DroppedFrames As String
    
    CopyMemory VarPtr(NewFrame), FrameInfo, LenB(NewFrame)
   
    If NewFrame.CurrentState = cs_Playback Then
        DroppedFrames = ""
    Else
        DroppedFrames = " dropped:" + Str(NewFrame.DroppedFrameCount)
    End If
    
   
    edtFrameCount.Text = "frame:" + Str(NewFrame.FrameNumber) _
               + DroppedFrames _
               + " time:" + Format(NewFrame.FrameTime_Hour, "00:") _
                          + Format(NewFrame.FrameTime_Min, "00:") _
                          + Format(NewFrame.FrameTime_Sec, "00:") _
                          + Format(NewFrame.FrameTime_Hs, "00")
    
    If NewFrame.DVTimeCode_IsAvailable > 0 Then  ' not available if 0
       DVTimeCode = "tc: " + Format(NewFrame.DVTimeCode_Hour, "00:") _
                           + Format(NewFrame.DVTimeCode_Min, "00:") _
                           + Format(NewFrame.DVTimeCode_Sec, "00:") _
                           + Format(NewFrame.DVTimeCode_Ff, "00")
    Else
       DVTimeCode = " "
    End If
    If NewFrame.DVDateTime_IsAvailable > 0 Then  ' not available if 0
        DVDateTime = "dv date: " + Format(NewFrame.DVDateTime_Day, "00/") _
                                + Format(NewFrame.DVDateTime_Month, "00/") _
                                + Format(NewFrame.DVDateTime_Year, "00 ") _
                                + Format(NewFrame.DVDateTime_Hour, "00:") _
                                + Format(NewFrame.DVDateTime_Min, "00:") _
                                + Format(NewFrame.DVDateTime_Sec, "00")
    Else
       DVDateTime = " "
    End If
    edtDVDateTime.Text = DVTimeCode + " " + DVDateTime
End Sub

Private Sub VideoGrabberVB61_OnFrameCaptureCompleted(ByVal FrameBitmapHandle As Long, ByVal BitmapWidth As Long, ByVal BitmapHeight As Long, ByVal FrameNumber As Long, ByVal FrameTime As Double, ByVal DestType As Vidgrab_VB6.TxFrameCaptureDest, ByVal FileName As String, ByVal Success As Boolean, ByVal FrameId As Long)
  
    Dim nDC As Long
    Dim OldBitmap As Long
   
   If Success Then
      AddLog FrameGrabber.mmoFrameCaptureLog, "frame #" + Str(FrameNumber) + " captured"
   End If
   
   Select Case DestType
       '______ bmp or jpeg file
       Case fc_BmpFile, fc_JpegFile
         If Success Then
             AddLog FrameGrabber.mmoFrameCaptureLog, FileName
          Else
             AddLog FrameGrabber.mmoFrameCaptureLog, "error: failed to create " + FileName
          End If
          
       '______ memory bitmap
       Case fc_TBitmap
          
        SnapForm.SnapImage.Width = Screen.TwipsPerPixelX * BitmapWidth
        SnapForm.SnapImage.Height = Screen.TwipsPerPixelY * BitmapHeight
        
        SnapForm.Width = SnapForm.SnapImage.Width + SnapForm.Width - SnapForm.ScaleWidth
        SnapForm.Height = SnapForm.SnapImage.Height + SnapForm.Height - SnapForm.ScaleHeight
        
        nDC = CreateCompatibleDC(0&)
        OldBitmap = SelectObject(nDC, FrameBitmapHandle)
        Call BitBlt(SnapForm.SnapImage.hdc, 0, 0, BitmapWidth, BitmapHeight, nDC, 0, 0, vbSrcCopy)
        Call SelectObject(nDC, OldBitmap)
        Call DeleteDC(nDC)
        
        SnapForm.SnapImage.Refresh
        
        If Not SnapForm.Visible Then
           SnapForm.Show
        End If
        
    End Select
End Sub


Private Sub VideoGrabberVB61_OnInactive()
    AddLog mmoLog, "(done.)"
End Sub

Private Sub VideoGrabberVB61_OnLog(ByVal LogType As Vidgrab_VB6.TxLogType, ByVal Severity As String, ByVal InfoMsg As String)
    AddLog mmoLog, "[" + Severity + "] " + InfoMsg
End Sub

Private Sub VideoGrabberVB61_OnMotionDetected(ByVal GlobalMotionRatio As Double, ByVal MaxMotionCellX As Long, ByVal MaxMotionCellY As Long, ByVal FrameBitmapHandle As Long, ByVal FrameNumber As Long, ByVal FrameTime As Double, ByVal FrameId As Long, CaptureFrame As Variant)
    Dim MaxMotionXLocation As Long
    Dim MaxMotionYLocation As Long
    Dim nDC As Long
    Dim OldBitmap As Long
    Dim FrameBitmap As Long

    MotionDetection.edtMotionRatio.Text = Format(VideoGrabberVB61.MotionDetector_GlobalMotionRatio, "0.000")
    
    MotionDetection.shpMotionRatio.BackColor = RGB(0, 192, 0)

    MotionDetection.edtMaxMotionXY.Text = "x:" + Str(MaxMotionCellX) + " y:" + Str(MaxMotionCellY)
    
    If VideoGrabberVB61.MotionDetector_GetCellLocation(MaxMotionCellX, MaxMotionCellY, MaxMotionXLocation, MaxMotionYLocation) Then      ' the 2 last parameters are passed by ref
        MotionDetection.edtMaxMotionCoord.Text = "x: " + Str(MaxMotionXLocation) + "  y: " + Str(MaxMotionYLocation)
    End If
   
    MotionDetection.mmoMotionGrid.Text = VideoGrabberVB61.MotionDetector_Get2DTextMotion
    
    FrameBitmap = VideoGrabberVB61.GetLastFrameAsHBITMAP(0, False, 0, 0, 0, 0, MotionDetection.imgMotionDetected.ScaleWidth, MotionDetection.imgMotionDetected.ScaleHeight, 24)
    If FrameBitmap <> 0 Then
        nDC = CreateCompatibleDC(0&)
        OldBitmap = SelectObject(nDC, FrameBitmap)
        Call BitBlt(MotionDetection.imgMotionDetected.hdc, 0, 0, MotionDetection.imgMotionDetected.ScaleWidth, MotionDetection.imgMotionDetected.ScaleHeight, nDC, 0, 0, vbSrcCopy)
        Call SelectObject(nDC, OldBitmap)
        Call DeleteDC(nDC)
        DeleteObject (FrameBitmap)
    End If
   
End Sub

Private Sub VideoGrabberVB61_OnMotionNotDetected(ByVal FrameBitmapHandle As Long, ByVal FrameNumber As Long, ByVal FrameTime As Double, ByVal FrameId As Long, CaptureFrame As Variant)
    MotionDetection.edtMotionRatio.Text = ""
    MotionDetection.shpMotionRatio.BackColor = RGB(0, 64, 0)
    MotionDetection.mmoMotionGrid.Text = VideoGrabberVB61.MotionDetector_Get2DTextMotion
End Sub

Private Sub VideoGrabberVB61_OnMouseDown(ByVal VideoWindow As Long, ByVal Button As Vidgrab_VB6.TxMouseButton, ByVal X As Long, ByVal Y As Long)
   If VideoWindow <> -1 Then ' if the video is displayed
      If Overlays.chkFreeHandEnabled.Value = Checked Then
         If iFreeHandMouseDrawing < FreeHandMaxCoordinates Then
            FreeHandMouseDrawing(iFreeHandMouseDrawing).Left = X
            FreeHandMouseDrawing(iFreeHandMouseDrawing).Top = Y
            FreeHandMouseDrawing(iFreeHandMouseDrawing).Right = 0 ' Right is used as boolean to know if it is a MoveTo or a LineTo
            iFreeHandMouseDrawing = iFreeHandMouseDrawing + 1
            FreeHandMouseDrawingEnabled = True
            VideoGrabberVB61.RefreshPlayerOverlays
        End If
     End If
   End If
End Sub

Private Sub VideoGrabberVB61_OnMouseMove(ByVal VideoWindow As Long, ByVal X As Long, ByVal Y As Long)
   If VideoWindow <> -1 Then ' if the video is displayed
      If FreeHandMouseDrawingEnabled Then
         If iFreeHandMouseDrawing < FreeHandMaxCoordinates Then
            FreeHandMouseDrawing(iFreeHandMouseDrawing).Left = X
            FreeHandMouseDrawing(iFreeHandMouseDrawing).Top = Y
            FreeHandMouseDrawing(iFreeHandMouseDrawing).Right = 1 ' Right is used as boolean to know if it is a MoveTo or a LineTo
            iFreeHandMouseDrawing = iFreeHandMouseDrawing + 1
            VideoGrabberVB61.RefreshPlayerOverlays
         End If
      End If
   End If
End Sub

Private Sub VideoGrabberVB61_OnMouseUp(ByVal VideoWindow As Long, ByVal Button As Vidgrab_VB6.TxMouseButton, ByVal X As Long, ByVal Y As Long)
   FreeHandMouseDrawingEnabled = False
   
   ' used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
   PickupTransparentColor_LastRGBPixelValueAtMousePosition = 0
   PickupTransparentColor_MouseXVideoPosition = X
   PickupTransparentColor_MouseYVideoPosition = Y
   PickupTransparentColor_MustGetRGBPixel = True
   VideoGrabberVB61.RefreshPlayerOverlays
End Sub

Private Sub VideoGrabberVB61_OnPlayerBufferingData(ByVal StartingToBuffer As Boolean)
   If StartingToBuffer Then
      AddLog mmoLog, "buffering data..."
   Else
      AddLog mmoLog, "buffering completed."
   End If
End Sub

Private Sub VideoGrabberVB61_OnPlayerEndOfPlaylist()
      AddLog mmoLog, "END OF PLAYLIST."
End Sub

Private Sub VideoGrabberVB61_OnPlayerEndOfStream()
      AddLog mmoLog, "end of stream."
End Sub

Private Sub VideoGrabberVB61_OnPlayerOpened()
   tbrPlayer.Min = 1
   tbrPlayer.TickFrequency = 1
   If VideoGrabberVB61.PlayerFrameCount > 1 Then
      tbrPlayer.Max = VideoGrabberVB61.PlayerFrameCount
   Else
      tbrPlayer.Max = 2
   End If
   
   AddLog mmoLog, ""
   AddLog mmoLog, "playing " + VideoGrabberVB61.PlayerFileName
   If VideoGrabberVB61.IsPlayerAudioStreamAvailable = ts_True Then
      AddLog mmoLog, "this video clip has an audio stream"
   ElseIf VideoGrabberVB61.IsPlayerAudioStreamAvailable = ts_False Then
      AddLog mmoLog, "this video clip does not have audio"
   End If
   AddLog mmoLog, ""
   AddLog mmoLog, "video codec: " + VideoGrabberVB61.PlayerVideoCodec
   AddLog mmoLog, "audio codec: " + VideoGrabberVB61.PlayerAudioCodec
   AddLog mmoLog, ""
   AddLog mmoLog, "Duration: " + Format$(VideoGrabberVB61.PlayerDuration / 10000000, "0.00")
   AddLog mmoLog, "Frame count: " + Str(VideoGrabberVB61.PlayerFrameCount)
   AddLog mmoLog, "Frame rate: " + Format$(VideoGrabberVB61.PlayerFrameRate, "0.00")
   AddLog mmoLog, "size:" + Str(VideoGrabberVB61.VideoWidth) + "x" + Str(VideoGrabberVB61.VideoHeight)
   If VideoGrabberVB61.IsPlaylistActive Then
      Player.lstPlaylist.ListIndex = VideoGrabberVB61.PlaylistIndex
   End If
End Sub

Private Sub VideoGrabberVB61_OnPlayerUpdateTrackbarPosition(ByVal FrameNumber As Long, ByVal FrameTime As Double, ByVal FrameId As Long)
    tbrPlayer.Value = FrameNumber
End Sub

Private Sub VideoGrabberVB61_OnPreviewStarted()

   AddLog mmoLog, ""
   AddLog mmoLog, "video size: " + Str(VideoGrabberVB61.VideoWidth) + " x" + Str(VideoGrabberVB61.VideoHeight)
   AddLog mmoLog, "display size: " + Str(VideoGrabberVB61.Display_VideoWidth) + " x" + Str(VideoGrabberVB61.Display_VideoHeight)
   AddLog mmoLog, "current frame rate: " + Format(VideoGrabberVB61.CurrentFrameRate, "0.00") + " fps."
   AddLog mmoLog, ""
   
   VideoSource.edtFrameRate.Text = Format(VideoGrabberVB61.CurrentFrameRate, "0.00")
   VideoProcessing.RefreshVMR9Processing
   
End Sub

Private Sub VideoGrabberVB61_OnRawVideoSample(ByVal pSampleBuffer As Long, ByVal SampleBufferSize As Long, ByVal SampleDataLength As Long, ByVal FormatType As Vidgrab_VB6.TxFormatType, ByVal pFormat As Long, ByVal pBitmapInfoHeader As Long, ByVal SampleStartTime As Double, ByVal SampleStopTime As Double)
    If FormatType = ft_Unknown Then ' jpeg snapshot
        Dim JpgImg() As Byte
        ReDim JpgImg(SampleDataLength)
        CopyMemory VarPtr(JpgImg(0)), pSampleBuffer, SampleDataLength
    
        Dim FF As Integer
        Dim OutputFileName As String
        OutputFileName = "the_snapshot.jpg"
        FF = FreeFile
        Open OutputFileName For Binary Access Write Lock Read Write As #FF
        Put #FF, , JpgImg
        Close #FF
    End If

End Sub

Private Sub VideoGrabberVB61_OnRecordingPaused()
      AddLog mmoLog, "recording paused..."
End Sub


Private Sub VideoGrabberVB61_OnRecordingCompleted(ByVal FileName As String, ByVal Success As Boolean)
   If Success Then
      AddLog mmoLog, FileName + " successfully created."
   Else
      AddLog mmoLog, FileName + " recording failed."
   End If
End Sub

Private Sub VideoGrabberVB61_OnRecordingReadyToStart()
   
   ' Enabling HoldRecording before calling StartRecording prevents the recording
   '  to start (when the recording graph is built) until the
   '  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
   '  to commence recording, or StopRecording to cancel recording
   ' EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
   '  after RecordingTimerInterval regardless of HoldRecording setting,
   '  and OnRecordingReadyToStart event is not fired
   If MsgBox("""StartRecording"" was initiated with ""HoldRecording"" enabled," & vbCrLf & _
            "firing the ""OnRecordingReadyToStart"" event." & vbCrLf & vbCrLf & _
            "Ready to start recording!", _
            vbOKCancel, _
            "DataStead TVideoGrabber VB 6 OCX Demo") = vbOK Then
        If (VideoGrabberVB61.VideoSource = vs_ScreenRecording) And (Recording.chkScreenRecordWindow.Value = vbChecked) And (lngScreenRecordingWindow > 0) Then
           ' for screen recording of a window, this code will make it the top window before recording start;
           '  window handle was gathered by EnumerateWindows in OnEnumerateWindows
           ' (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
           SetWindowPos wenScreenRecordingWindow(lngScreenRecordingWindow - 1).WindowHandle, HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE
        End If
        VideoGrabberVB61.ResumeRecording
    Else
        VideoGrabberVB61.StopRecording
    End If
    
End Sub

Private Sub VideoGrabberVB61_OnRecordingStarted(ByVal FileName As String)
   AddLog mmoLog, "recording to " + FileName + ":"
   AddLog mmoLog, Str(VideoGrabberVB61.RecordingWidth) + " x" + Str(VideoGrabberVB61.RecordingHeight)
   AddLog mmoLog, "current frame rate: " + Format(VideoGrabberVB61.CurrentFrameRate, "0.0") + " fps."
   VideoSource.edtFrameRate.Text = Format(VideoGrabberVB61.CurrentFrameRate, "0.00")

End Sub

Private Sub VideoGrabberVB61_OnReencodingCompleted(ByVal SourceFile As String, ByVal DestFile As String, ByVal Success As Boolean)
   If Success Then
      AddLog mmoLog, " successfully reencoded to " + DestFile
   Else
      AddLog mmoLog, "Failed to reencode " + SourceFile + " to " + DestFile
   End If
End Sub

Private Sub VideoGrabberVB61_OnReencodingProgress(ByVal Percent As Long, ByVal Position As Double, ByVal Duration As Double)
   AddLog mmoLog, Str(Percent) + "% completed..."
End Sub

Private Sub VideoGrabberVB61_OnReencodingStarted(ByVal SourceFile As String, ByVal DestFile As String)
   AddLog mmoLog, "reencoding " + SourceFile + " to " + DestFile + "..."
End Sub

Private Sub VideoGrabberVB61_OnReinitializing()
   mmoLog.Text = ""
   OldVideoSignalState = False
End Sub

Private Sub VideoGrabberVB61_OnResize()
   Dim NewWidth As Long
   Dim NewHeight As Long
   Dim VGWidth As Single, VGHeight As Single
   Dim VGLeft As Single, VGTop As Single

   
   ' establish control size in Twips, to match scale of Form Width and Height
   If VideoGrabberVB61.Display_AutoSize And VideoGrabberVB61.Width = StartupVGWidth And VideoGrabberVB61.Height = StartupVGHeight Then
       ' when Display_AutoSize is enabled and control Width and Height are unchanged at OnResize,
       '  derive new control metrics from Display_VideoWidth and Display_VideoHeight (pixels)
       VGWidth = Me.ScaleX(VideoGrabberVB61.Display_VideoWidth, vbPixels, vbTwips)
       VGHeight = Me.ScaleY(VideoGrabberVB61.Display_VideoHeight, vbPixels, vbTwips)
    Else
       ' derive new size using Form's ScaleMode
       VGWidth = Me.ScaleX(VideoGrabberVB61.Width, Me.ScaleMode, vbTwips)
       VGHeight = Me.ScaleY(VideoGrabberVB61.Height, Me.ScaleMode, vbTwips)
       ' refresh StartupVGWidth and StartupVGHeight
       StartupVGWidth = VideoGrabberVB61.Width
       StartupVGHeight = VideoGrabberVB61.Height
   End If
   VGLeft = Me.ScaleX(VideoGrabberVB61.Left, Me.ScaleMode, vbTwips)
   VGTop = Me.ScaleY(VideoGrabberVB61.Top, Me.ScaleMode, vbTwips)
   
   NewWidth = VGLeft + VGWidth + Me.ScaleX(32, vbPixels, vbTwips) + FormTwips.FrameX
   NewHeight = VGTop + VGHeight + Me.ScaleY(32, vbPixels, vbTwips) + FormTwips.FrameY + FormTwips.CaptionY
   If NewWidth < StartupWidth Then
      NewWidth = StartupWidth
   End If
   If NewHeight < StartupHeight Then
      NewHeight = StartupHeight
   End If
   If (NewWidth > Width) Or (NewHeight > Height) Then
      Width = NewWidth
      Height = NewHeight
   End If
   
   
End Sub

Private Sub VideoGrabberVB61_OnResizeVideo(ByVal SourceWidth As Long, ByVal SourceHeight As Long)
   VideoGrabberVB61.TextOverlay_Right = SourceWidth
   VideoProcessing.trkCroppingX.Max = VideoGrabberVB61.Cropping_XMax
   VideoProcessing.trkCroppingY.Max = VideoGrabberVB61.Cropping_YMax
End Sub

Public Sub VideoGrabberVB61_OnVideoDeviceSelected()
   VideoSource.cboVideoDevices.Text = VideoGrabberVB61.VideoDeviceName
   AssignListToComboBox VideoSource.cboAnalogVideoStandard, VideoGrabberVB61.AnalogVideoStandards, VideoGrabberVB61.AnalogVideoStandard
   AssignListToComboBox VideoSource.cboVideoSizes, VideoGrabberVB61.VideoSizes, VideoGrabberVB61.VideoSize
   AssignListToComboBox VideoSource.cboVideoSubtypes, VideoGrabberVB61.VideoSubtypes, VideoGrabberVB61.VideoSubtype
   AssignListToComboBox VideoSource.cboVideoInputs, VideoGrabberVB61.VideoInputs, VideoGrabberVB61.VideoInput

   RefreshVideoDeviceControls
   Display.RefreshDisplayOptions
   
End Sub

Private Sub VideoGrabberVB61_OnVideoFromBitmapsNextFrameNeeded(ByVal FirstSample As Boolean)
    ' read the (1) comment at the bottom of this unit
    
    ' you can pass to this event:
    ' - either a the HBITMAP handle of a bitmap
    ' - or the path to a BMP file or a JPEG file
    
    ' also see help "Video clip built from a fixed set of BMP files or JPEG files"
    

    Dim EndOfData As Boolean
    Dim BMPorJPEGFile As String
    
    ' FirstSample is true the first time the event occurs (useful to know e.g. when a file search must be restarted from the beginning)
    ' EndOfData signals SendImageToVideoFromBitmaps end of animation
    
    If VideoFromBitmapUsePictureBox Then
    
        ' next frame from HBITMAP handle of a bitmap
    
        Dim BitmapHandle As Long
        Dim CanFreeBitmapHandle As Boolean

        EndOfData = False
        CanFreeBitmapHandle = False

        BitmapHandle = VideoFromBitmapUsePictureBoxHandle(VideoFromBitmapUsePictureBoxCt)
        VideoGrabberVB61.SendImageToVideoFromBitmaps "", BitmapHandle, CanFreeBitmapHandle, EndOfData

        VideoFromBitmapUsePictureBoxCt = VideoFromBitmapUsePictureBoxCt + 1
'        If VideoFromBitmapUsePictureBoxCt > UBound(VideoFromBitmapUsePictureBoxHandle, 1) Then
        If VideoFromBitmapUsePictureBoxCt > 3 Then
            ' we loop indefinitely
            VideoFromBitmapUsePictureBoxCt = 0
        End If
    
    Else
    
        ' next frame from path to a BMP file or a JPEG file
    
        EndOfData = False
    
        If FirstSample Then
            VideoFromJPEG = False
            BMPorJPEGFile = FileSearch_FirstFile(VideoFromBitmapSourceFolder, "*.bmp", VideoFromBitmapSearch)
            If BMPorJPEGFile = "" Then ' if no BMP files, let's try JPEG files
                BMPorJPEGFile = FileSearch_FirstFile(VideoFromBitmapSourceFolder, "*.jpg", VideoFromBitmapSearch)
                VideoFromJPEG = True
            End If
            If BMPorJPEGFile = "" Then
               AddLog mmoLog, ""
               AddLog mmoLog, "no bitmap files found in the StoragePath directory! Capture frames to BMP files first by using the frame grabber."
               EndOfData = True
            End If
        Else
            BMPorJPEGFile = FileSearch_NextFile(VideoFromBitmapSearch)
            If VideoFromBitmapSourceLoop And (BMPorJPEGFile = "") Then
                If VideoFromJPEG Then
                    BMPorJPEGFile = FileSearch_FirstFile(MainForm.VideoFromBitmapSourceFolder, "*.jpg", VideoFromBitmapSearch)
                Else
                    BMPorJPEGFile = FileSearch_FirstFile(MainForm.VideoFromBitmapSourceFolder, "*.bmp", VideoFromBitmapSearch)
                End If
            End If
        End If
        VideoGrabberVB61.SendImageToVideoFromBitmaps BMPorJPEGFile, 0, False, EndOfData
    End If
    
End Sub

' (1)
'
'  from this event you should not perform any actions with the potential to block,
'  such as holding a critical section or waiting on another thread.
'  Also, do not call any GDI or USER32.DLL APIs that might cause a window to move.
'  Invoking methods and/or properties of VCL components can perform indirectly such actions.

'  Any debugging breakpoint or compilation error in this event at runtime will freeze the application,
'  therefore be sure to save the changes before running the app when programming these events.

