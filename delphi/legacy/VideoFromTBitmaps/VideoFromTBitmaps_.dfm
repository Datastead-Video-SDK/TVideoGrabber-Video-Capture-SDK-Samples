object Form1: TForm1
  Left = 405
  Top = 241
  Caption = 'Video from bitmap handles'
  ClientHeight = 493
  ClientWidth = 1578
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Position = poScreenCenter
  OnCloseQuery = FormCloseQuery
  OnCreate = FormCreate
  TextHeight = 13
  object GroupBox1: TGroupBox
    Left = 648
    Top = 8
    Width = 889
    Height = 449
    Caption = '2. recording of the TBitmaps generated'
    TabOrder = 0
    object Label2: TLabel
      Left = 224
      Top = 31
      Width = 261
      Height = 13
      Caption = 'frame rate of the clip generated from the TBitmaps (fps:)'
    end
    object Label1: TLabel
      Left = 608
      Top = 93
      Width = 267
      Height = 13
      Caption = '(sync. preview disabled = process bitmaps at max speed)'
    end
    object VideoGrabber: TVideoGrabber
      Left = 200
      Top = 96
      Width = 337
      Height = 257
      Color = clBlack
      ASFMediaServerPublishingPoint = 'http://YourWindowsMediaServer/YourPublishingPoint'
      ASFVideoWidth = 320
      AspectRatioToUse = -1.000000000000000000
      AudioCompressor = 0
      AutoFileNameDateTimeFormat = 'yymmdd_hhmmss_zzz'
      AutoFilePrefix = 'vg'
      DroppedFramesPollingInterval = 10
      DualDisplay_Left = 400
      DualDisplay_Top = 10
      DVEncoder_VideoStandard = dvs_PAL
      Cropping_Zoom = 1.000000000000000000
      FrameGrabber = fg_PreviewStream
      ImageOverlayEnabled = False
      ImageOverlay_AlphaBlend = False
      ImageOverlay_AlphaBlendValue = 180
      ImageOverlay_ChromaKey = False
      ImageOverlay_ChromaKeyLeewayPercent = 25
      ImageOverlay_ChromaKeyRGBColor = 0
      ImageOverlay_Height = -1
      ImageOverlay_LeftLocation = 10
      ImageOverlay_VideoAlignment = oa_LeftTop
      ImageOverlay_StretchToVideoSize = False
      ImageOverlay_TopLocation = 10
      ImageOverlay_Transparent = False
      ImageOverlay_TransparentColorValue = 0
      ImageOverlay_UseTransparentColor = False
      ImageOverlay_Width = -1
      ImageOverlay_TargetDisplay = -1
      LicenseString = 'N/A'
      MotionDetector_Grid = 
        '5555555555 5555555555 5555555555 5555555555 5555555555 555555555' +
        '5 5555555555 5555555555 5555555555 5555555555 '
      MultiplexedStabilizationDelay = 30
      NDIName = 'DATASTEAD_UNNAMED_SOURCE'
      PlayerSpeedRatio = 1.000000000000000000
      RecordingOnMotion_MotionThreshold = 0.001000000000000000
      TextOverlay_Enabled = False
      TextOverlay_Font.Charset = DEFAULT_CHARSET
      TextOverlay_Font.Color = clAqua
      TextOverlay_Font.Height = -11
      TextOverlay_Font.Name = 'MS Sans Serif'
      TextOverlay_Font.Style = []
      TextOverlay_FontColor = clAqua
      TextOverlay_FontSize = 7
      TextOverlay_HighResFont = True
      TextOverlay_Left = 0
      TextOverlay_Top = 0
      TextOverlay_Right = -1
      TextOverlay_Orientation = to_Horizontal
      TextOverlay_Scrolling = False
      TextOverlay_ScrollingSpeed = 1
      TextOverlay_Shadow = True
      TextOverlay_ShadowColor = clBlack
      TextOverlay_ShadowDirection = cd_SouthEast
      TextOverlay_BkColor = clWhite
      TextOverlay_Align = tf_Left
      TextOverlay_AlphaBlend = False
      TextOverlay_AlphaBlendValue = 180
      TextOverlay_GradientMode = gm_Disabled
      TextOverlay_GradientColor = clNavy
      TextOverlay_VideoAlignment = oa_LeftTop
      TextOverlay_String = 
        'TVideoGrabber text overlay'#13#10'(variables: see SetTextOverlay_Strin' +
        'g in the help)'
      TextOverlay_TargetDisplay = -1
      TextOverlay_Transparent = True
      TVUseFrequencyOverrides = True
      VideoCompression_Quality = 1.000000000000000000
      VideoCompressor = 0
      VideoDelay = 0
      VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
      VideoProcessing_RotationCustomAngle = 45.500000000000000000
      VideoSource_FileOrURL = 'http://www.datastead.com/demo/demo.wmv'
      StreamInterface_IsRealTime = True
      OnFrameProgress = VideoGrabberFrameProgress
      OnInactive = VideoGrabberInactive
      OnLog = VideoGrabberLog
      OnPlayerOpened = VideoGrabberPlayerOpened
      OnPreviewStarted = VideoGrabberPreviewStarted
      OnRecordingCompleted = VideoGrabberRecordingCompleted
      OnRecordingStarted = VideoGrabberRecordingStarted
    end
    object btnStartPreview: TButton
      Left = 202
      Top = 64
      Width = 80
      Height = 21
      Caption = 'start preview'
      TabOrder = 1
      OnClick = btnStartPreviewClick
    end
    object btnStartRecording: TButton
      Left = 288
      Top = 64
      Width = 80
      Height = 21
      Caption = 'start recording'
      TabOrder = 2
      OnClick = btnStartRecordingClick
    end
    object btnStop: TButton
      Left = 376
      Top = 64
      Width = 80
      Height = 21
      Caption = 'stop'
      TabOrder = 3
      OnClick = btnStopClick
    end
    object mmoLog: TMemo
      Left = 8
      Top = 120
      Width = 185
      Height = 233
      Color = clSilver
      TabOrder = 4
    end
    object btnPlay: TButton
      Left = 464
      Top = 64
      Width = 80
      Height = 21
      Caption = 'play'
      TabOrder = 5
      OnClick = btnPlayClick
    end
    object edtFrameProgress: TEdit
      Left = 8
      Top = 96
      Width = 185
      Height = 21
      Color = clSilver
      TabOrder = 6
    end
    object edtRecordingFrameRate: TEdit
      Left = 502
      Top = 28
      Width = 33
      Height = 21
      TabOrder = 7
      Text = '10'
    end
    object chkUseFrameCallback: TCheckBox
      Left = 608
      Top = 19
      Width = 121
      Height = 25
      Caption = 'use frame callback'
      TabOrder = 8
      OnClick = chkUseFrameCallbackClick
    end
    object chkUseBitmapCopy: TCheckBox
      Left = 608
      Top = 40
      Width = 113
      Height = 25
      Caption = 'use bitmap copy'
      TabOrder = 9
      OnClick = chkUseBitmapCopyClick
    end
    object chkSyncPreview: TCheckBox
      Left = 608
      Top = 62
      Width = 121
      Height = 25
      Caption = 'Sync. Preview'
      Checked = True
      State = cbChecked
      TabOrder = 10
      OnClick = chkSyncPreviewClick
    end
  end
  object GroupBox2: TGroupBox
    Left = 8
    Top = 8
    Width = 625
    Height = 457
    Caption = '1. generation of 4 TBitmap stored in 4 TImage'
    TabOrder = 1
    object Image1: TImage
      Left = 24
      Top = 31
      Width = 260
      Height = 190
      Stretch = True
    end
    object Image2: TImage
      Left = 335
      Top = 27
      Width = 260
      Height = 190
      Stretch = True
    end
    object Image3: TImage
      Left = 24
      Top = 243
      Width = 260
      Height = 190
      Stretch = True
    end
    object Image4: TImage
      Left = 335
      Top = 243
      Width = 260
      Height = 190
      Stretch = True
    end
  end
  object tmr_SendNextBitmap: TTimer
    Enabled = False
    Interval = 10
    OnTimer = tmr_SendNextBitmapTimer
    Left = 1528
    Top = 216
  end
end
