namespace Record_4_IP_Cameras_To_OneFile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartPreview = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MixerLog = new System.Windows.Forms.TextBox();
            this.txBoxCam1Log = new System.Windows.Forms.TextBox();
            this.txBoxCam2Log = new System.Windows.Forms.TextBox();
            this.txBoxCam3Log = new System.Windows.Forms.TextBox();
            this.txBoxCam4Log = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStoragePath = new System.Windows.Forms.TextBox();
            this.btnPlayLastRecording = new System.Windows.Forms.Button();
            this.videoMixer = new VidGrab.VideoGrabber();
            this.SuspendLayout();
            // 
            // btnStartPreview
            // 
            this.btnStartPreview.Location = new System.Drawing.Point(82, 6);
            this.btnStartPreview.Name = "btnStartPreview";
            this.btnStartPreview.Size = new System.Drawing.Size(200, 29);
            this.btnStartPreview.TabIndex = 1;
            this.btnStartPreview.Text = "Start Mixer Preview";
            this.btnStartPreview.UseVisualStyleBackColor = true;
            this.btnStartPreview.Click += new System.EventHandler(this.btnStartPreview_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(576, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(200, 29);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop Mixer";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(315, 6);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(200, 29);
            this.btnStartRecording.TabIndex = 3;
            this.btnStartRecording.Text = "Start Mixer Recording";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "or";
            // 
            // MixerLog
            // 
            this.MixerLog.Location = new System.Drawing.Point(1092, 101);
            this.MixerLog.Multiline = true;
            this.MixerLog.Name = "MixerLog";
            this.MixerLog.Size = new System.Drawing.Size(311, 645);
            this.MixerLog.TabIndex = 5;
            this.MixerLog.Text = "Mixer log:";
            // 
            // txBoxCam1Log
            // 
            this.txBoxCam1Log.Location = new System.Drawing.Point(84, 774);
            this.txBoxCam1Log.Multiline = true;
            this.txBoxCam1Log.Name = "txBoxCam1Log";
            this.txBoxCam1Log.Size = new System.Drawing.Size(311, 288);
            this.txBoxCam1Log.TabIndex = 6;
            this.txBoxCam1Log.Text = "Camera1 log:";
            // 
            // txBoxCam2Log
            // 
            this.txBoxCam2Log.Location = new System.Drawing.Point(416, 774);
            this.txBoxCam2Log.Multiline = true;
            this.txBoxCam2Log.Name = "txBoxCam2Log";
            this.txBoxCam2Log.Size = new System.Drawing.Size(311, 288);
            this.txBoxCam2Log.TabIndex = 7;
            this.txBoxCam2Log.Text = "Camera2 log:";
            // 
            // txBoxCam3Log
            // 
            this.txBoxCam3Log.Location = new System.Drawing.Point(757, 774);
            this.txBoxCam3Log.Multiline = true;
            this.txBoxCam3Log.Name = "txBoxCam3Log";
            this.txBoxCam3Log.Size = new System.Drawing.Size(311, 288);
            this.txBoxCam3Log.TabIndex = 8;
            this.txBoxCam3Log.Text = "Camera3 log:";
            // 
            // txBoxCam4Log
            // 
            this.txBoxCam4Log.Location = new System.Drawing.Point(1092, 774);
            this.txBoxCam4Log.Multiline = true;
            this.txBoxCam4Log.Name = "txBoxCam4Log";
            this.txBoxCam4Log.Size = new System.Drawing.Size(311, 288);
            this.txBoxCam4Log.TabIndex = 9;
            this.txBoxCam4Log.Text = "Camera4 log:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Storage path:";
            // 
            // txtStoragePath
            // 
            this.txtStoragePath.Location = new System.Drawing.Point(181, 58);
            this.txtStoragePath.Name = "txtStoragePath";
            this.txtStoragePath.Size = new System.Drawing.Size(1218, 22);
            this.txtStoragePath.TabIndex = 11;
            this.txtStoragePath.TextChanged += new System.EventHandler(this.txtStoragePath_TextChanged);
            // 
            // btnPlayLastRecording
            // 
            this.btnPlayLastRecording.Location = new System.Drawing.Point(822, 6);
            this.btnPlayLastRecording.Name = "btnPlayLastRecording";
            this.btnPlayLastRecording.Size = new System.Drawing.Size(162, 29);
            this.btnPlayLastRecording.TabIndex = 12;
            this.btnPlayLastRecording.Text = "Replay last recording";
            this.btnPlayLastRecording.UseVisualStyleBackColor = true;
            this.btnPlayLastRecording.Click += new System.EventHandler(this.btnPlayLastRecording_Click);
            // 
            // videoMixer
            // 
            this.videoMixer.AdjustOverlayAspectRatio = true;
            this.videoMixer.AdjustPixelAspectRatio = true;
            this.videoMixer.Aero = VidGrab.TAero.ae_Default;
            this.videoMixer.AnalogVideoStandard = -1;
            this.videoMixer.ApplicationPriority = VidGrab.TApplicationPriority.ap_default;
            this.videoMixer.ASFAudioBitRate = -1;
            this.videoMixer.ASFAudioChannels = -1;
            this.videoMixer.ASFBufferWindow = -1;
            this.videoMixer.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced;
            this.videoMixer.ASFDirectStreamingKeepClientsConnected = false;
            this.videoMixer.ASFFixedFrameRate = true;
            this.videoMixer.ASFMediaServerPublishingPoint = "";
            this.videoMixer.ASFMediaServerRemovePublishingPointAfterDisconnect = false;
            this.videoMixer.ASFMediaServerTemplatePublishingPoint = "";
            this.videoMixer.ASFNetworkMaxUsers = 5;
            this.videoMixer.ASFNetworkPort = 0;
            this.videoMixer.ASFProfile = -1;
            this.videoMixer.ASFProfileFromCustomFile = "";
            this.videoMixer.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8;
            this.videoMixer.ASFVideoBitRate = -1;
            this.videoMixer.ASFVideoFrameRate = 0D;
            this.videoMixer.ASFVideoHeight = -1;
            this.videoMixer.ASFVideoMaxKeyFrameSpacing = -1;
            this.videoMixer.ASFVideoQuality = -1;
            this.videoMixer.ASFVideoWidth = -1;
            this.videoMixer.AspectRatioToUse = -1D;
            this.videoMixer.AssociateAudioAndVideoDevices = false;
            this.videoMixer.AudioBalance = 0;
            this.videoMixer.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_PassThru;
            this.videoMixer.AudioCompressor = 0;
            this.videoMixer.AudioDevice = -1;
            this.videoMixer.AudioDeviceRendering = false;
            this.videoMixer.AudioFormat = VidGrab.TAudioFormat.af_default;
            this.videoMixer.AudioInput = -1;
            this.videoMixer.AudioInputBalance = 0;
            this.videoMixer.AudioInputLevel = 65535;
            this.videoMixer.AudioInputMono = false;
            this.videoMixer.AudioPeakEvent = true;
            this.videoMixer.AudioRecording = false;
            this.videoMixer.AudioRenderer = -1;
            this.videoMixer.AudioSource = VidGrab.TAudioSource.as_Default;
            this.videoMixer.AudioStreamNumber = -1;
            this.videoMixer.AudioSyncAdjustment = 0;
            this.videoMixer.AudioSyncAdjustmentEnabled = false;
            this.videoMixer.AudioVolume = 32767;
            this.videoMixer.AutoConnectRelatedPins = true;
            this.videoMixer.AutoFileName = VidGrab.TAutoFileName.fn_Sequential;
            this.videoMixer.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz";
            this.videoMixer.AutoFileNameMinDigits = 6;
            this.videoMixer.AutoFilePrefix = "vg";
            this.videoMixer.AutoFileSuffix = "";
            this.videoMixer.AutoRefreshPreview = false;
            this.videoMixer.AutoStartPlayer = true;
            this.videoMixer.AVIDurationUpdated = true;
            this.videoMixer.AVIFormatOpenDML = true;
            this.videoMixer.AVIFormatOpenDMLCompatibilityIndex = true;
            this.videoMixer.BackColor = System.Drawing.Color.DarkGray;
            this.videoMixer.BackgroundColor = 0;
            this.videoMixer.BufferCount = -1;
            this.videoMixer.BurstCount = 3;
            this.videoMixer.BurstInterval = 0;
            this.videoMixer.BurstMode = false;
            this.videoMixer.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap;
            this.videoMixer.BusyCursor = VidGrab.TCursors.cr_HourGlass;
            this.videoMixer.CameraControlSettings = true;
            this.videoMixer.CaptureFileExt = "";
            this.videoMixer.ColorKey = 1048592;
            this.videoMixer.ColorKeyEnabled = false;
            this.videoMixer.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression;
            this.videoMixer.CompressionType = VidGrab.TCompressionType.ct_Video;
            this.videoMixer.Cropping_Enabled = false;
            this.videoMixer.Cropping_Height = 120;
            this.videoMixer.Cropping_Outbounds = true;
            this.videoMixer.Cropping_Width = 160;
            this.videoMixer.Cropping_X = 0;
            this.videoMixer.Cropping_Y = 0;
            this.videoMixer.Cropping_Zoom = 1D;
            this.videoMixer.Display_Active = true;
            this.videoMixer.Display_AlphaBlendEnabled = false;
            this.videoMixer.Display_AlphaBlendValue = 180;
            this.videoMixer.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.videoMixer.Display_AutoSize = false;
            this.videoMixer.Display_Embedded = true;
            this.videoMixer.Display_Embedded_FitParent = false;
            this.videoMixer.Display_FullScreen = false;
            this.videoMixer.Display_Height = 240;
            this.videoMixer.Display_Left = 10;
            this.videoMixer.Display_Monitor = 0;
            this.videoMixer.Display_MouseMovesWindow = true;
            this.videoMixer.Display_PanScanRatio = 50;
            this.videoMixer.Display_StayOnTop = false;
            this.videoMixer.Display_Top = 10;
            this.videoMixer.Display_TransparentColorEnabled = false;
            this.videoMixer.Display_TransparentColorValue = 255;
            this.videoMixer.Display_VideoPortEnabled = true;
            this.videoMixer.Display_Visible = true;
            this.videoMixer.Display_Width = 320;
            this.videoMixer.DoubleBuffered = false;
            this.videoMixer.DroppedFramesPollingInterval = -1;
            this.videoMixer.DualDisplay_Active = false;
            this.videoMixer.DualDisplay_AlphaBlendEnabled = false;
            this.videoMixer.DualDisplay_AlphaBlendValue = 180;
            this.videoMixer.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.videoMixer.DualDisplay_AutoSize = false;
            this.videoMixer.DualDisplay_Embedded = false;
            this.videoMixer.DualDisplay_Embedded_FitParent = false;
            this.videoMixer.DualDisplay_FullScreen = false;
            this.videoMixer.DualDisplay_Height = 240;
            this.videoMixer.DualDisplay_Left = 20;
            this.videoMixer.DualDisplay_Monitor = 0;
            this.videoMixer.DualDisplay_MouseMovesWindow = true;
            this.videoMixer.DualDisplay_PanScanRatio = 50;
            this.videoMixer.DualDisplay_StayOnTop = false;
            this.videoMixer.DualDisplay_Top = 400;
            this.videoMixer.DualDisplay_TransparentColorEnabled = false;
            this.videoMixer.DualDisplay_TransparentColorValue = 255;
            this.videoMixer.DualDisplay_VideoPortEnabled = false;
            this.videoMixer.DualDisplay_Visible = true;
            this.videoMixer.DualDisplay_Width = 320;
            this.videoMixer.DVDateTimeEnabled = true;
            this.videoMixer.DVDiscontinuityMinimumInterval = 3;
            this.videoMixer.DVDTitle = 0;
            this.videoMixer.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD;
            this.videoMixer.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full;
            this.videoMixer.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default;
            this.videoMixer.DVRecordingInNativeFormatSeparatesStreams = false;
            this.videoMixer.DVReduceFrameRate = false;
            this.videoMixer.DVRgb219 = false;
            this.videoMixer.DVTimeCodeEnabled = false;
            this.videoMixer.EventNotificationSynchrone = true;
            this.videoMixer.ExtraDLLPath = "";
            this.videoMixer.FixFlickerOrBlackCapture = false;
            this.videoMixer.FrameCaptureHeight = -1;
            this.videoMixer.FrameCaptureWidth = -1;
            this.videoMixer.FrameCaptureWithoutOverlay = false;
            this.videoMixer.FrameCaptureZoomSize = 100;
            this.videoMixer.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams;
            this.videoMixer.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default;
            this.videoMixer.FrameNumberStartsFromZero = false;
            this.videoMixer.FrameRate = 0D;
            this.videoMixer.FrameRateDivider = 0;
            this.videoMixer.HoldRecording = false;
            this.videoMixer.ImageOverlay_AlphaBlend = false;
            this.videoMixer.ImageOverlay_AlphaBlendValue = 180;
            this.videoMixer.ImageOverlay_ChromaKey = false;
            this.videoMixer.ImageOverlay_ChromaKeyLeewayPercent = 25;
            this.videoMixer.ImageOverlay_ChromaKeyRGBColor = 0;
            this.videoMixer.ImageOverlay_Height = -1;
            this.videoMixer.ImageOverlay_LeftLocation = 10;
            this.videoMixer.ImageOverlay_RotationAngle = 0D;
            this.videoMixer.ImageOverlay_StretchToVideoSize = false;
            this.videoMixer.ImageOverlay_TargetDisplay = -1;
            this.videoMixer.ImageOverlay_TopLocation = 10;
            this.videoMixer.ImageOverlay_Transparent = false;
            this.videoMixer.ImageOverlay_TransparentColorValue = 0;
            this.videoMixer.ImageOverlay_UseTransparentColor = false;
            this.videoMixer.ImageOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoMixer.ImageOverlay_Width = -1;
            this.videoMixer.ImageOverlayEnabled = false;
            this.videoMixer.ImageOverlaySelector = 0;
            this.videoMixer.IPCameraURL = "";
            this.videoMixer.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality;
            this.videoMixer.JPEGProgressiveDisplay = false;
            this.videoMixer.JPEGQuality = 100;
            this.videoMixer.LicenseString = "N/A";
            this.videoMixer.Location = new System.Drawing.Point(84, 101);
            this.videoMixer.LogoDisplayed = false;
            this.videoMixer.LogoLayout = VidGrab.TLogoLayout.lg_Stretched;
            this.videoMixer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videoMixer.MixAudioSamples_CurrentSourceLevel = 100;
            this.videoMixer.MixAudioSamples_ExternalSourceLevel = 100;
            this.videoMixer.Mixer_MosaicColumns = 1;
            this.videoMixer.Mixer_MosaicLines = 1;
            this.videoMixer.MotionDetector_CompareBlue = true;
            this.videoMixer.MotionDetector_CompareGreen = true;
            this.videoMixer.MotionDetector_CompareRed = true;
            this.videoMixer.MotionDetector_Enabled = false;
            this.videoMixer.MotionDetector_GreyScale = false;
            this.videoMixer.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" +
    "555555 5555555555 5555555555";
            this.videoMixer.MotionDetector_MaxDetectionsPerSecond = 0D;
            this.videoMixer.MotionDetector_ReduceCPULoad = 1;
            this.videoMixer.MotionDetector_ReduceVideoNoise = false;
            this.videoMixer.MotionDetector_Triggered = false;
            this.videoMixer.MouseWheelEventEnabled = true;
            this.videoMixer.MpegStreamType = VidGrab.TMpegStreamType.mpst_Default;
            this.videoMixer.MultiplexedInputEmulation = true;
            this.videoMixer.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed;
            this.videoMixer.MultiplexedStabilizationDelay = 100;
            this.videoMixer.MultiplexedSwitchDelay = 0;
            this.videoMixer.Multiplexer = -1;
            this.videoMixer.MuteAudioRendering = false;
            this.videoMixer.Name = "videoMixer";
            this.videoMixer.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled;
            this.videoMixer.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming;
            this.videoMixer.NormalCursor = VidGrab.TCursors.cr_Default;
            this.videoMixer.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread;
            this.videoMixer.NotificationPriority = VidGrab.TThreadPriority.tpNormal;
            this.videoMixer.NotificationSleepTime = -1;
            this.videoMixer.OnFrameBitmapEventSynchrone = false;
            this.videoMixer.OpenURLAsync = true;
            this.videoMixer.OverlayAfterTransform = false;
            this.videoMixer.OwnerObject = null;
            this.videoMixer.PlayerAudioRendering = true;
            this.videoMixer.PlayerDuration = ((long)(1));
            this.videoMixer.PlayerDVSize = VidGrab.TDVSize.dv_Full;
            this.videoMixer.PlayerFastSeekSpeedRatio = 4;
            this.videoMixer.PlayerFileName = "";
            this.videoMixer.PlayerForcedCodec = "";
            this.videoMixer.PlayerFramePosition = ((long)(1));
            this.videoMixer.PlayerRefreshPausedDisplay = false;
            this.videoMixer.PlayerRefreshPausedDisplayFrameRate = 0D;
            this.videoMixer.PlayerSpeedRatio = 1D;
            this.videoMixer.PlayerTimePosition = ((long)(0));
            this.videoMixer.PlayerTrackBarSynchrone = false;
            this.videoMixer.PlaylistIndex = 0;
            this.videoMixer.PreallocCapFileCopiedAfterRecording = true;
            this.videoMixer.PreallocCapFileEnabled = false;
            this.videoMixer.PreallocCapFileName = "";
            this.videoMixer.PreallocCapFileSizeInMB = 100;
            this.videoMixer.PreviewZoomSize = 100;
            this.videoMixer.QuickDeviceInitialization = false;
            this.videoMixer.RawAudioSampleCapture = false;
            this.videoMixer.RawCaptureAsyncEvent = true;
            this.videoMixer.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat;
            this.videoMixer.RawVideoSampleCapture = false;
            this.videoMixer.RecordingAudioBitRate = -1;
            this.videoMixer.RecordingBacktimedFramesCount = 0;
            this.videoMixer.RecordingCanPause = false;
            this.videoMixer.RecordingFileName = "";
            this.videoMixer.RecordingInNativeFormat = true;
            this.videoMixer.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;
            this.videoMixer.RecordingOnMotion_Enabled = false;
            this.videoMixer.RecordingOnMotion_MotionThreshold = 0D;
            this.videoMixer.RecordingOnMotion_NoMotionPauseDelayMs = 5000;
            this.videoMixer.RecordingPauseCreatesNewFile = false;
            this.videoMixer.RecordingSize = VidGrab.TRecordingSize.rs_Default;
            this.videoMixer.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled;
            this.videoMixer.RecordingTimerInterval = 0;
            this.videoMixer.RecordingVideoBitRate = -1;
            this.videoMixer.Reencoding_IncludeAudioStream = true;
            this.videoMixer.Reencoding_IncludeVideoStream = true;
            this.videoMixer.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF;
            this.videoMixer.Reencoding_NewVideoClip = "";
            this.videoMixer.Reencoding_SourceVideoClip = "";
            this.videoMixer.Reencoding_StartFrame = ((long)(-1));
            this.videoMixer.Reencoding_StartTime = ((long)(-1));
            this.videoMixer.Reencoding_StopFrame = ((long)(-1));
            this.videoMixer.Reencoding_StopTime = ((long)(-1));
            this.videoMixer.Reencoding_UseAudioCompressor = false;
            this.videoMixer.Reencoding_UseFrameGrabber = true;
            this.videoMixer.Reencoding_UseVideoCompressor = false;
            this.videoMixer.Reencoding_WMVOutput = false;
            this.videoMixer.ScreenRecordingLayeredWindows = false;
            this.videoMixer.ScreenRecordingMonitor = 0;
            this.videoMixer.ScreenRecordingNonVisibleWindows = false;
            this.videoMixer.ScreenRecordingThroughClipboard = false;
            this.videoMixer.ScreenRecordingWithCursor = true;
            this.videoMixer.SendToDV_DeviceIndex = -1;
            this.videoMixer.Size = new System.Drawing.Size(984, 645);
            this.videoMixer.SpeakerBalance = 0;
            this.videoMixer.SpeakerControl = false;
            this.videoMixer.SpeakerVolume = 65535;
            this.videoMixer.StoragePath = "";
            this.videoMixer.StoreDeviceSettingsInRegistry = true;
            this.videoMixer.SyncCommands = true;
            this.videoMixer.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master;
            this.videoMixer.Synchronized = false;
            this.videoMixer.SyncPreview = VidGrab.TSyncPreview.sp_Auto;
            this.videoMixer.TabIndex = 13;
            this.videoMixer.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left;
            this.videoMixer.TextOverlay_AlphaBlend = false;
            this.videoMixer.TextOverlay_AlphaBlendValue = 180;
            this.videoMixer.TextOverlay_BkColor = 16777215;
            this.videoMixer.TextOverlay_Enabled = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.videoMixer.TextOverlay_FontColor = 16776960;
            this.videoMixer.TextOverlay_FontSize = 12;
            this.videoMixer.TextOverlay_GradientColor = 8388608;
            this.videoMixer.TextOverlay_GradientMode = VidGrab.TTextOverlayGradientMode.gm_Disabled;
            this.videoMixer.TextOverlay_HighResFont = true;
            this.videoMixer.TextOverlay_Left = 0;
            this.videoMixer.TextOverlay_Orientation = VidGrab.TTextOrientation.to_Horizontal;
            this.videoMixer.TextOverlay_Right = -1;
            this.videoMixer.TextOverlay_Scrolling = false;
            this.videoMixer.TextOverlay_ScrollingSpeed = 1;
            this.videoMixer.TextOverlay_Selector = 0;
            this.videoMixer.TextOverlay_Shadow = true;
            this.videoMixer.TextOverlay_ShadowColor = 0;
            this.videoMixer.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_SouthEast;
            this.videoMixer.TextOverlay_String = resources.GetString("videoMixer.TextOverlay_String");
            this.videoMixer.TextOverlay_TargetDisplay = -1;
            this.videoMixer.TextOverlay_Top = 0;
            this.videoMixer.TextOverlay_Transparent = true;
            this.videoMixer.TextOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoMixer.ThirdPartyDeinterlacer = "";
            this.videoMixer.TranslateMouseCoordinates = true;
            this.videoMixer.TunerFrequency = -1;
            this.videoMixer.TunerMode = VidGrab.TTunerMode.tm_TVTuner;
            this.videoMixer.TVChannel = 0;
            this.videoMixer.TVCountryCode = 0;
            this.videoMixer.TVTunerInputType = VidGrab.TTunerInputType.TunerInputCable;
            this.videoMixer.TVUseFrequencyOverrides = false;
            this.videoMixer.UseClock = true;
            this.videoMixer.VCRHorizontalLocking = false;
            this.videoMixer.Version = "v10.8.4.4 (build 3342.180924) - Copyright (c)2018 Datastead";
            this.videoMixer.VideoCompression_DataRate = -1;
            this.videoMixer.VideoCompression_KeyFrameRate = 15;
            this.videoMixer.VideoCompression_PFramesPerKeyFrame = 0;
            this.videoMixer.VideoCompression_Quality = 1D;
            this.videoMixer.VideoCompression_WindowSize = -1;
            this.videoMixer.VideoCompressor = 0;
            this.videoMixer.VideoControlSettings = true;
            this.videoMixer.VideoCursor = VidGrab.TCursors.cr_Default;
            this.videoMixer.VideoDelay = ((long)(0));
            this.videoMixer.VideoDevice = -1;
            this.videoMixer.VideoFormat = -1;
            this.videoMixer.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc;
            this.videoMixer.VideoFromImages_RepeatIndefinitely = false;
            this.videoMixer.VideoFromImages_SourceDirectory = "";
            this.videoMixer.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat";
            this.videoMixer.VideoInput = -1;
            this.videoMixer.VideoProcessing_Brightness = 0;
            this.videoMixer.VideoProcessing_Contrast = 0;
            this.videoMixer.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled;
            this.videoMixer.VideoProcessing_FlipHorizontal = false;
            this.videoMixer.VideoProcessing_FlipVertical = false;
            this.videoMixer.VideoProcessing_GrayScale = false;
            this.videoMixer.VideoProcessing_Hue = 0;
            this.videoMixer.VideoProcessing_InvertColors = false;
            this.videoMixer.VideoProcessing_Pixellization = 1;
            this.videoMixer.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg;
            this.videoMixer.VideoProcessing_RotationCustomAngle = 45.5D;
            this.videoMixer.VideoProcessing_Saturation = 0;
            this.videoMixer.VideoQualitySettings = true;
            this.videoMixer.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect;
            this.videoMixer.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None;
            this.videoMixer.VideoRendererExternalIndex = -1;
            this.videoMixer.VideoRendererPriority = VidGrab.TVideoRendererPriority.vrp_Auto;
            this.videoMixer.VideoSize = -1;
            this.videoMixer.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            this.videoMixer.VideoSource_FileOrURL = "";
            this.videoMixer.VideoSource_FileOrURL_StartTime = ((long)(-1));
            this.videoMixer.VideoSource_FileOrURL_StopTime = ((long)(-1));
            this.videoMixer.VideoStreamNumber = -1;
            this.videoMixer.VideoSubtype = -1;
            this.videoMixer.VideoVisibleWhenStopped = false;
            this.videoMixer.VirtualAudioStreamControl = -1;
            this.videoMixer.VirtualVideoStreamControl = -1;
            this.videoMixer.VuMeter = VidGrab.TVuMeter.vu_Disabled;
            this.videoMixer.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled;
            this.videoMixer.ZoomCoeff = 1000;
            this.videoMixer.ZoomXCenter = 0;
            this.videoMixer.ZoomYCenter = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 1060);
            this.Controls.Add(this.videoMixer);
            this.Controls.Add(this.btnPlayLastRecording);
            this.Controls.Add(this.txtStoragePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txBoxCam4Log);
            this.Controls.Add(this.txBoxCam3Log);
            this.Controls.Add(this.txBoxCam2Log);
            this.Controls.Add(this.txBoxCam1Log);
            this.Controls.Add(this.MixerLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartRecording);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStartPreview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartPreview;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MixerLog;
        private System.Windows.Forms.TextBox txBoxCam1Log;
        private System.Windows.Forms.TextBox txBoxCam2Log;
        private System.Windows.Forms.TextBox txBoxCam3Log;
        private System.Windows.Forms.TextBox txBoxCam4Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStoragePath;
        private System.Windows.Forms.Button btnPlayLastRecording;
        private VidGrab.VideoGrabber videoMixer;
    }
}

