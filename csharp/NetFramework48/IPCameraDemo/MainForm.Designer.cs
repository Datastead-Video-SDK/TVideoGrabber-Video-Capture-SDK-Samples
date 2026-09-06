namespace IPCameraDemo
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
            this.btnStartMP4Recording = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.videoGrabber1 = new VidGrab.VideoGrabber();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecordingTimerInterval = new System.Windows.Forms.TextBox();
            this.rdbRecordingTimerNewFileEvery = new System.Windows.Forms.RadioButton();
            this.rdbRecordingTimerStopAfter = new System.Windows.Forms.RadioButton();
            this.rdbRecordingTimerNone = new System.Windows.Forms.RadioButton();
            this.txtRecordingFileName = new System.Windows.Forms.TextBox();
            this.chkAutoSize = new System.Windows.Forms.CheckBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.chkAutoReconnect = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConnectionTimeout = new System.Windows.Forms.TextBox();
            this.txtJpegSnapshotFileName = new System.Windows.Forms.TextBox();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.chkDoNotRecordImmediately = new System.Windows.Forms.CheckBox();
            this.grbBacktimedRecordingStart = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBacktimedRecordingStartSeconds = new System.Windows.Forms.TextBox();
            this.chkIncludeBacktimedRecordingStart = new System.Windows.Forms.CheckBox();
            this.chkUseRecordingFileName = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnResumeRecording = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbBacktimedRecordingStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartPreview
            // 
            this.btnStartPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPreview.Location = new System.Drawing.Point(13, 102);
            this.btnStartPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartPreview.Name = "btnStartPreview";
            this.btnStartPreview.Size = new System.Drawing.Size(124, 26);
            this.btnStartPreview.TabIndex = 0;
            this.btnStartPreview.Text = "Start Preview";
            this.btnStartPreview.UseVisualStyleBackColor = true;
            this.btnStartPreview.Click += new System.EventHandler(this.btnStartPreview_Click);
            // 
            // btnStartMP4Recording
            // 
            this.btnStartMP4Recording.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMP4Recording.Location = new System.Drawing.Point(145, 102);
            this.btnStartMP4Recording.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartMP4Recording.Name = "btnStartMP4Recording";
            this.btnStartMP4Recording.Size = new System.Drawing.Size(214, 26);
            this.btnStartMP4Recording.TabIndex = 2;
            this.btnStartMP4Recording.Text = "Start MP4 recording";
            this.btnStartMP4Recording.UseVisualStyleBackColor = true;
            this.btnStartMP4Recording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(366, 102);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(71, 26);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // videoGrabber1
            // 
            this.videoGrabber1.AdjustOverlayAspectRatio = true;
            this.videoGrabber1.AdjustPixelAspectRatio = true;
            this.videoGrabber1.Aero = VidGrab.TAero.ae_Default;
            this.videoGrabber1.AnalogVideoStandard = -1;
            this.videoGrabber1.ApplicationPriority = VidGrab.TApplicationPriority.ap_default;
            this.videoGrabber1.ASFAudioBitRate = -1;
            this.videoGrabber1.ASFAudioChannels = -1;
            this.videoGrabber1.ASFBufferWindow = -1;
            this.videoGrabber1.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced;
            this.videoGrabber1.ASFDirectStreamingKeepClientsConnected = false;
            this.videoGrabber1.ASFFixedFrameRate = true;
            this.videoGrabber1.ASFMediaServerPublishingPoint = "";
            this.videoGrabber1.ASFMediaServerRemovePublishingPointAfterDisconnect = false;
            this.videoGrabber1.ASFMediaServerTemplatePublishingPoint = "";
            this.videoGrabber1.ASFNetworkMaxUsers = 5;
            this.videoGrabber1.ASFNetworkPort = 0;
            this.videoGrabber1.ASFProfile = -1;
            this.videoGrabber1.ASFProfileFromCustomFile = "";
            this.videoGrabber1.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8;
            this.videoGrabber1.ASFVideoBitRate = -1;
            this.videoGrabber1.ASFVideoFrameRate = 0;
            this.videoGrabber1.ASFVideoHeight = -1;
            this.videoGrabber1.ASFVideoMaxKeyFrameSpacing = -1;
            this.videoGrabber1.ASFVideoQuality = -1;
            this.videoGrabber1.ASFVideoWidth = -1;
            this.videoGrabber1.AspectRatioToUse = -1;
            this.videoGrabber1.AssociateAudioAndVideoDevices = false;
            this.videoGrabber1.AudioBalance = 0;
            this.videoGrabber1.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_Normal;
            this.videoGrabber1.AudioCompressor = 0;
            this.videoGrabber1.AudioDevice = -1;
            this.videoGrabber1.AudioDeviceRendering = false;
            this.videoGrabber1.AudioFormat = VidGrab.TAudioFormat.af_default;
            this.videoGrabber1.AudioInput = -1;
            this.videoGrabber1.AudioInputBalance = 0;
            this.videoGrabber1.AudioInputLevel = 65535;
            this.videoGrabber1.AudioInputMono = false;
            this.videoGrabber1.AudioPeakEvent = false;
            this.videoGrabber1.AudioRecording = false;
            this.videoGrabber1.AudioRenderer = -1;
            this.videoGrabber1.AudioSource = VidGrab.TAudioSource.as_Default;
            this.videoGrabber1.AudioStreamNumber = -1;
            this.videoGrabber1.AudioSyncAdjustment = 0;
            this.videoGrabber1.AudioSyncAdjustmentEnabled = false;
            this.videoGrabber1.AudioVolume = 32767;
            this.videoGrabber1.AutoConnectRelatedPins = true;
            this.videoGrabber1.AutoFileName = VidGrab.TAutoFileName.fn_Sequential;
            this.videoGrabber1.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz";
            this.videoGrabber1.AutoFileNameMinDigits = 6;
            this.videoGrabber1.AutoFilePrefix = "vg";
            this.videoGrabber1.AutoFileSuffix = "";
            this.videoGrabber1.AutoRefreshPreview = false;
            this.videoGrabber1.AutoStartPlayer = true;
            this.videoGrabber1.AVIDurationUpdated = true;
            this.videoGrabber1.AVIFormatOpenDML = true;
            this.videoGrabber1.AVIFormatOpenDMLCompatibilityIndex = true;
            this.videoGrabber1.BackColor = System.Drawing.Color.DarkGray;
            this.videoGrabber1.BackgroundColor = 0;
            this.videoGrabber1.BufferCount = -1;
            this.videoGrabber1.BurstCount = 3;
            this.videoGrabber1.BurstInterval = 0;
            this.videoGrabber1.BurstMode = false;
            this.videoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap;
            this.videoGrabber1.BusyCursor = VidGrab.TCursors.cr_HourGlass;
            this.videoGrabber1.CameraControlSettings = true;
            this.videoGrabber1.CaptureFileExt = "";
            this.videoGrabber1.ColorKey = 1048592;
            this.videoGrabber1.ColorKeyEnabled = false;
            this.videoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression;
            this.videoGrabber1.CompressionType = VidGrab.TCompressionType.ct_Video;
            this.videoGrabber1.Cropping_Enabled = false;
            this.videoGrabber1.Cropping_Height = 120;
            this.videoGrabber1.Cropping_Outbounds = true;
            this.videoGrabber1.Cropping_Width = 160;
            this.videoGrabber1.Cropping_X = 0;
            this.videoGrabber1.Cropping_Y = 0;
            this.videoGrabber1.Cropping_Zoom = 1;
            this.videoGrabber1.Display_Active = true;
            this.videoGrabber1.Display_AlphaBlendEnabled = false;
            this.videoGrabber1.Display_AlphaBlendValue = 180;
            this.videoGrabber1.Display_AspectRatio = VidGrab.TAspectRatio.ar_Stretch;
            this.videoGrabber1.Display_AutoSize = false;
            this.videoGrabber1.Display_Embedded = true;
            this.videoGrabber1.Display_FullScreen = false;
            this.videoGrabber1.Display_Height = 240;
            this.videoGrabber1.Display_Left = 10;
            this.videoGrabber1.Display_Monitor = 0;
            this.videoGrabber1.Display_MouseMovesWindow = true;
            this.videoGrabber1.Display_PanScanRatio = 50;
            this.videoGrabber1.Display_StayOnTop = false;
            this.videoGrabber1.Display_Top = 10;
            this.videoGrabber1.Display_TransparentColorEnabled = false;
            this.videoGrabber1.Display_TransparentColorValue = 255;
            this.videoGrabber1.Display_VideoPortEnabled = true;
            this.videoGrabber1.Display_Visible = true;
            this.videoGrabber1.Display_Width = 320;
            this.videoGrabber1.DoubleBuffered = false;
            this.videoGrabber1.DroppedFramesPollingInterval = -1;
            this.videoGrabber1.DualDisplay_Active = false;
            this.videoGrabber1.DualDisplay_AlphaBlendEnabled = false;
            this.videoGrabber1.DualDisplay_AlphaBlendValue = 180;
            this.videoGrabber1.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Stretch;
            this.videoGrabber1.DualDisplay_AutoSize = false;
            this.videoGrabber1.DualDisplay_Embedded = false;
            this.videoGrabber1.DualDisplay_FullScreen = false;
            this.videoGrabber1.DualDisplay_Height = 240;
            this.videoGrabber1.DualDisplay_Left = 20;
            this.videoGrabber1.DualDisplay_Monitor = 0;
            this.videoGrabber1.DualDisplay_MouseMovesWindow = true;
            this.videoGrabber1.DualDisplay_PanScanRatio = 50;
            this.videoGrabber1.DualDisplay_StayOnTop = false;
            this.videoGrabber1.DualDisplay_Top = 400;
            this.videoGrabber1.DualDisplay_TransparentColorEnabled = false;
            this.videoGrabber1.DualDisplay_TransparentColorValue = 255;
            this.videoGrabber1.DualDisplay_VideoPortEnabled = false;
            this.videoGrabber1.DualDisplay_Visible = true;
            this.videoGrabber1.DualDisplay_Width = 320;
            this.videoGrabber1.DVDateTimeEnabled = true;
            this.videoGrabber1.DVDiscontinuityMinimumInterval = 3;
            this.videoGrabber1.DVDTitle = 0;
            this.videoGrabber1.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD;
            this.videoGrabber1.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full;
            this.videoGrabber1.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default;
            this.videoGrabber1.DVRecordingInNativeFormatSeparatesStreams = false;
            this.videoGrabber1.DVReduceFrameRate = false;
            this.videoGrabber1.DVRgb219 = false;
            this.videoGrabber1.DVTimeCodeEnabled = false;
            this.videoGrabber1.EventNotificationSynchrone = true;
            this.videoGrabber1.FixFlickerOrBlackCapture = false;
            this.videoGrabber1.FrameCaptureHeight = -1;
            this.videoGrabber1.FrameCaptureWidth = -1;
            this.videoGrabber1.FrameCaptureWithoutOverlay = false;
            this.videoGrabber1.FrameCaptureZoomSize = 100;
            this.videoGrabber1.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams;
            this.videoGrabber1.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default;
            this.videoGrabber1.FrameNumberStartsFromZero = false;
            this.videoGrabber1.FrameRate = 0;
            this.videoGrabber1.FrameRateDivider = 0;
            this.videoGrabber1.HoldRecording = false;
            this.videoGrabber1.ImageOverlay_AlphaBlend = false;
            this.videoGrabber1.ImageOverlay_AlphaBlendValue = 180;
            this.videoGrabber1.ImageOverlay_ChromaKey = false;
            this.videoGrabber1.ImageOverlay_ChromaKeyLeewayPercent = 25;
            this.videoGrabber1.ImageOverlay_ChromaKeyRGBColor = 0;
            this.videoGrabber1.ImageOverlay_Height = -1;
            this.videoGrabber1.ImageOverlay_LeftLocation = 10;
            this.videoGrabber1.ImageOverlay_RotationAngle = 0;
            this.videoGrabber1.ImageOverlay_StretchToVideoSize = false;
            this.videoGrabber1.ImageOverlay_TargetDisplay = -1;
            this.videoGrabber1.ImageOverlay_TopLocation = 10;
            this.videoGrabber1.ImageOverlay_Transparent = false;
            this.videoGrabber1.ImageOverlay_TransparentColorValue = 0;
            this.videoGrabber1.ImageOverlay_UseTransparentColor = false;
            this.videoGrabber1.ImageOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoGrabber1.ImageOverlay_Width = -1;
            this.videoGrabber1.ImageOverlayEnabled = false;
            this.videoGrabber1.ImageOverlaySelector = 0;
            this.videoGrabber1.IPCameraURL = "";
            this.videoGrabber1.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality;
            this.videoGrabber1.JPEGProgressiveDisplay = false;
            this.videoGrabber1.JPEGQuality = 100;
            this.videoGrabber1.LicenseString = "N/A";
            this.videoGrabber1.Location = new System.Drawing.Point(456, 111);
            this.videoGrabber1.LogoDisplayed = false;
            this.videoGrabber1.LogoLayout = VidGrab.TLogoLayout.lg_Stretched;
            this.videoGrabber1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videoGrabber1.MixAudioSamples_CurrentSourceLevel = 100;
            this.videoGrabber1.MixAudioSamples_ExternalSourceLevel = 100;
            this.videoGrabber1.Mixer_MosaicColumns = 1;
            this.videoGrabber1.Mixer_MosaicLines = 1;
            this.videoGrabber1.MotionDetector_CompareBlue = true;
            this.videoGrabber1.MotionDetector_CompareGreen = true;
            this.videoGrabber1.MotionDetector_CompareRed = true;
            this.videoGrabber1.MotionDetector_Enabled = false;
            this.videoGrabber1.MotionDetector_GreyScale = false;
            this.videoGrabber1.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" +
                "555555 5555555555 5555555555";
            this.videoGrabber1.MotionDetector_MaxDetectionsPerSecond = 0;
            this.videoGrabber1.MotionDetector_ReduceCPULoad = 1;
            this.videoGrabber1.MotionDetector_ReduceVideoNoise = false;
            this.videoGrabber1.MotionDetector_Triggered = false;
            this.videoGrabber1.MouseWheelEventEnabled = true;
            this.videoGrabber1.MpegStreamType = VidGrab.TMpegStreamType.mpst_Default;
            this.videoGrabber1.MultiplexedInputEmulation = true;
            this.videoGrabber1.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed;
            this.videoGrabber1.MultiplexedStabilizationDelay = 100;
            this.videoGrabber1.MultiplexedSwitchDelay = 0;
            this.videoGrabber1.Multiplexer = -1;
            this.videoGrabber1.MuteAudioRendering = false;
            this.videoGrabber1.Name = "videoGrabber1";
            this.videoGrabber1.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled;
            this.videoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming;
            this.videoGrabber1.NormalCursor = VidGrab.TCursors.cr_Default;
            this.videoGrabber1.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread;
            this.videoGrabber1.NotificationPriority = VidGrab.TThreadPriority.tpNormal;
            this.videoGrabber1.NotificationSleepTime = -1;
            this.videoGrabber1.OnFrameBitmapEventSynchrone = false;
            this.videoGrabber1.OpenURLAsync = true;
            this.videoGrabber1.OverlayAfterTransform = false;
            this.videoGrabber1.OwnerObject = null;
            this.videoGrabber1.PlayerAudioRendering = true;
            this.videoGrabber1.PlayerDuration = ((long)(1));
            this.videoGrabber1.PlayerDVSize = VidGrab.TDVSize.dv_Full;
            this.videoGrabber1.PlayerFastSeekSpeedRatio = 4;
            this.videoGrabber1.PlayerFileName = "";
            this.videoGrabber1.PlayerForcedCodec = "";
            this.videoGrabber1.PlayerFramePosition = ((long)(1));
            this.videoGrabber1.PlayerRefreshPausedDisplay = false;
            this.videoGrabber1.PlayerRefreshPausedDisplayFrameRate = 0;
            this.videoGrabber1.PlayerSpeedRatio = 1;
            this.videoGrabber1.PlayerTimePosition = ((long)(0));
            this.videoGrabber1.PlayerTrackBarSynchrone = false;
            this.videoGrabber1.PlaylistIndex = 0;
            this.videoGrabber1.PreallocCapFileCopiedAfterRecording = true;
            this.videoGrabber1.PreallocCapFileEnabled = false;
            this.videoGrabber1.PreallocCapFileName = "";
            this.videoGrabber1.PreallocCapFileSizeInMB = 100;
            this.videoGrabber1.PreviewZoomSize = 100;
            this.videoGrabber1.QuickDeviceInitialization = false;
            this.videoGrabber1.RawAudioSampleCapture = false;
            this.videoGrabber1.RawCaptureAsyncEvent = true;
            this.videoGrabber1.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat;
            this.videoGrabber1.RawVideoSampleCapture = false;
            this.videoGrabber1.RecordingAudioBitRate = -1;
            this.videoGrabber1.RecordingBacktimedFramesCount = 0;
            this.videoGrabber1.RecordingCanPause = false;
            this.videoGrabber1.RecordingFileName = "";
            this.videoGrabber1.RecordingInNativeFormat = true;
            this.videoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;
            this.videoGrabber1.RecordingOnMotion_Enabled = false;
            this.videoGrabber1.RecordingOnMotion_MotionThreshold = 0;
            this.videoGrabber1.RecordingOnMotion_NoMotionPauseDelayMs = 5000;
            this.videoGrabber1.RecordingPauseCreatesNewFile = false;
            this.videoGrabber1.RecordingSize = VidGrab.TRecordingSize.rs_Default;
            this.videoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled;
            this.videoGrabber1.RecordingTimerInterval = 0;
            this.videoGrabber1.RecordingVideoBitRate = -1;
            this.videoGrabber1.Reencoding_IncludeAudioStream = true;
            this.videoGrabber1.Reencoding_IncludeVideoStream = true;
            this.videoGrabber1.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF;
            this.videoGrabber1.Reencoding_NewVideoClip = "";
            this.videoGrabber1.Reencoding_SourceVideoClip = "";
            this.videoGrabber1.Reencoding_StartFrame = ((long)(-1));
            this.videoGrabber1.Reencoding_StartTime = ((long)(-1));
            this.videoGrabber1.Reencoding_StopFrame = ((long)(-1));
            this.videoGrabber1.Reencoding_StopTime = ((long)(-1));
            this.videoGrabber1.Reencoding_UseAudioCompressor = false;
            this.videoGrabber1.Reencoding_UseFrameGrabber = true;
            this.videoGrabber1.Reencoding_UseVideoCompressor = false;
            this.videoGrabber1.Reencoding_WMVOutput = false;
            this.videoGrabber1.ScreenRecordingLayeredWindows = false;
            this.videoGrabber1.ScreenRecordingMonitor = 0;
            this.videoGrabber1.ScreenRecordingNonVisibleWindows = false;
            this.videoGrabber1.ScreenRecordingThroughClipboard = false;
            this.videoGrabber1.ScreenRecordingWithCursor = true;
            this.videoGrabber1.SendToDV_DeviceIndex = -1;
            this.videoGrabber1.Size = new System.Drawing.Size(789, 528);
            this.videoGrabber1.SpeakerBalance = 0;
            this.videoGrabber1.SpeakerControl = false;
            this.videoGrabber1.SpeakerVolume = 65535;
            this.videoGrabber1.StoragePath = "H:\\TVideoGrabber\\Shareware\\CSharp_VB.NET\\DEMOS\\C#\\IPCameraDemo";
            this.videoGrabber1.StoreDeviceSettingsInRegistry = true;
            this.videoGrabber1.SyncCommands = true;
            this.videoGrabber1.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master;
            this.videoGrabber1.Synchronized = false;
            this.videoGrabber1.SyncPreview = VidGrab.TSyncPreview.sp_Auto;
            this.videoGrabber1.TabIndex = 4;
            this.videoGrabber1.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left;
            this.videoGrabber1.TextOverlay_AlphaBlend = false;
            this.videoGrabber1.TextOverlay_AlphaBlendValue = 180;
            this.videoGrabber1.TextOverlay_BkColor = 16777215;
            this.videoGrabber1.TextOverlay_Enabled = false;
            // TODO: Code generation for 'this.videoGrabber1.TextOverlay_Font' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.videoGrabber1.TextOverlay_FontColor = 16776960;
            this.videoGrabber1.TextOverlay_FontSize = 12;
            this.videoGrabber1.TextOverlay_GradientColor = 8388608;
            this.videoGrabber1.TextOverlay_GradientMode = VidGrab.TTextOverlayGradientMode.gm_Disabled;
            this.videoGrabber1.TextOverlay_HighResFont = true;
            this.videoGrabber1.TextOverlay_Left = 0;
            this.videoGrabber1.TextOverlay_Orientation = VidGrab.TTextOrientation.to_Horizontal;
            this.videoGrabber1.TextOverlay_Right = -1;
            this.videoGrabber1.TextOverlay_Scrolling = false;
            this.videoGrabber1.TextOverlay_ScrollingSpeed = 1;
            this.videoGrabber1.TextOverlay_Selector = 0;
            this.videoGrabber1.TextOverlay_Shadow = true;
            this.videoGrabber1.TextOverlay_ShadowColor = 0;
            this.videoGrabber1.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_SouthEast;
            this.videoGrabber1.TextOverlay_String = resources.GetString("videoGrabber1.TextOverlay_String");
            this.videoGrabber1.TextOverlay_TargetDisplay = -1;
            this.videoGrabber1.TextOverlay_Top = 0;
            this.videoGrabber1.TextOverlay_Transparent = true;
            this.videoGrabber1.TextOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoGrabber1.ThirdPartyDeinterlacer = "";
            this.videoGrabber1.TranslateMouseCoordinates = true;
            this.videoGrabber1.TunerFrequency = -1;
            this.videoGrabber1.TunerMode = VidGrab.TTunerMode.tm_TVTuner;
            this.videoGrabber1.TVChannel = 0;
            this.videoGrabber1.TVCountryCode = 0;
            this.videoGrabber1.TVTunerInputType = VidGrab.TTunerInputType.TunerInputCable;
            this.videoGrabber1.TVUseFrequencyOverrides = false;
            this.videoGrabber1.UseClock = true;
            this.videoGrabber1.VCRHorizontalLocking = false;
            this.videoGrabber1.Version = "v10.5.1.4 (build 161115) - Copyright ©2016 Datastead";
            this.videoGrabber1.VideoCompression_DataRate = -1;
            this.videoGrabber1.VideoCompression_KeyFrameRate = 15;
            this.videoGrabber1.VideoCompression_PFramesPerKeyFrame = 0;
            this.videoGrabber1.VideoCompression_Quality = 1;
            this.videoGrabber1.VideoCompression_WindowSize = -1;
            this.videoGrabber1.VideoCompressor = 0;
            this.videoGrabber1.VideoControlSettings = true;
            this.videoGrabber1.VideoCursor = VidGrab.TCursors.cr_Default;
            this.videoGrabber1.VideoDelay = ((long)(0));
            this.videoGrabber1.VideoDevice = -1;
            this.videoGrabber1.VideoFormat = -1;
            this.videoGrabber1.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc;
            this.videoGrabber1.VideoFromImages_RepeatIndefinitely = false;
            this.videoGrabber1.VideoFromImages_SourceDirectory = "H:\\TVideoGrabber\\Shareware\\CSharp_VB.NET\\DEMOS\\C#\\IPCameraDemo";
            this.videoGrabber1.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat";
            this.videoGrabber1.VideoInput = -1;
            this.videoGrabber1.VideoProcessing_Brightness = 0;
            this.videoGrabber1.VideoProcessing_Contrast = 0;
            this.videoGrabber1.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled;
            this.videoGrabber1.VideoProcessing_FlipHorizontal = false;
            this.videoGrabber1.VideoProcessing_FlipVertical = false;
            this.videoGrabber1.VideoProcessing_GrayScale = false;
            this.videoGrabber1.VideoProcessing_Hue = 0;
            this.videoGrabber1.VideoProcessing_InvertColors = false;
            this.videoGrabber1.VideoProcessing_Pixellization = 1;
            this.videoGrabber1.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg;
            this.videoGrabber1.VideoProcessing_RotationCustomAngle = 45.5;
            this.videoGrabber1.VideoProcessing_Saturation = 0;
            this.videoGrabber1.VideoQualitySettings = true;
            this.videoGrabber1.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect;
            this.videoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None;
            this.videoGrabber1.VideoRendererExternalIndex = -1;
            this.videoGrabber1.VideoRendererPriority = VidGrab.TVideoRendererPriority.vrp_Auto;
            this.videoGrabber1.VideoSize = -1;
            this.videoGrabber1.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            this.videoGrabber1.VideoSource_FileOrURL = "";
            this.videoGrabber1.VideoSource_FileOrURL_StartTime = ((long)(-1));
            this.videoGrabber1.VideoSource_FileOrURL_StopTime = ((long)(-1));
            this.videoGrabber1.VideoSubtype = -1;
            this.videoGrabber1.VideoVisibleWhenStopped = false;
            this.videoGrabber1.VirtualAudioStreamControl = -1;
            this.videoGrabber1.VirtualVideoStreamControl = -1;
            this.videoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Disabled;
            this.videoGrabber1.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled;
            this.videoGrabber1.ZoomCoeff = 1000;
            this.videoGrabber1.ZoomXCenter = 0;
            this.videoGrabber1.ZoomYCenter = 0;
            this.videoGrabber1.OnFrameProgress += new VidGrab.OnFrameProgressEventHandler(this.videoGrabber1_OnFrameProgress);
            this.videoGrabber1.OnRecordingReadyToStart += new System.EventHandler(this.videoGrabber1_OnRecordingReadyToStart);
            this.videoGrabber1.OnDeviceLost += new System.EventHandler(this.videoGrabber1_OnDeviceLost);
            this.videoGrabber1.OnDeviceReconnected += new System.EventHandler(this.videoGrabber1_OnDeviceReconnected);
            this.videoGrabber1.OnDeviceReconnecting += new System.EventHandler(this.videoGrabber1_OnDeviceReconnecting);
            this.videoGrabber1.OnRecordingCompleted += new VidGrab.OnRecordingCompletedEventHandler(this.videoGrabber1_OnRecordingCompleted);
            this.videoGrabber1.OnLog += new VidGrab.OnLogEventHandler(this.videoGrabber1_OnLog);
            this.videoGrabber1.OnFrameCaptureCompleted += new VidGrab.OnFrameCaptureCompletedEventHandler(this.videoGrabber1_OnFrameCaptureCompleted);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(62, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(743, 22);
            this.txtURL.TabIndex = 5;
            this.txtURL.Text = "rtsp://192.168.5.25/axis-media/media.amp?videocodec=h264";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "E.g.:  onvif://...   rtsp://...   rtmp://...   udp://...    http://...";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(484, 40);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(99, 22);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "root";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(695, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(110, 22);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "user:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "password:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRecordingTimerInterval);
            this.groupBox1.Controls.Add(this.rdbRecordingTimerNewFileEvery);
            this.groupBox1.Controls.Add(this.rdbRecordingTimerStopAfter);
            this.groupBox1.Controls.Add(this.rdbRecordingTimerNone);
            this.groupBox1.Location = new System.Drawing.Point(16, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 85);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "recording timer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "seconds";
            // 
            // txtRecordingTimerInterval
            // 
            this.txtRecordingTimerInterval.Location = new System.Drawing.Point(259, 43);
            this.txtRecordingTimerInterval.Name = "txtRecordingTimerInterval";
            this.txtRecordingTimerInterval.Size = new System.Drawing.Size(55, 22);
            this.txtRecordingTimerInterval.TabIndex = 3;
            this.txtRecordingTimerInterval.Text = "30";
            this.txtRecordingTimerInterval.TextChanged += new System.EventHandler(this.txtRecordingTimerInterval_TextChanged);
            // 
            // rdbRecordingTimerNewFileEvery
            // 
            this.rdbRecordingTimerNewFileEvery.AutoSize = true;
            this.rdbRecordingTimerNewFileEvery.Location = new System.Drawing.Point(81, 57);
            this.rdbRecordingTimerNewFileEvery.Name = "rdbRecordingTimerNewFileEvery";
            this.rdbRecordingTimerNewFileEvery.Size = new System.Drawing.Size(180, 21);
            this.rdbRecordingTimerNewFileEvery.TabIndex = 2;
            this.rdbRecordingTimerNewFileEvery.Text = "record to new file every:";
            this.rdbRecordingTimerNewFileEvery.UseVisualStyleBackColor = true;
            this.rdbRecordingTimerNewFileEvery.CheckedChanged += new System.EventHandler(this.rdbRecordingTimerNewFileEvery_CheckedChanged);
            // 
            // rdbRecordingTimerStopAfter
            // 
            this.rdbRecordingTimerStopAfter.AutoSize = true;
            this.rdbRecordingTimerStopAfter.Location = new System.Drawing.Point(81, 30);
            this.rdbRecordingTimerStopAfter.Name = "rdbRecordingTimerStopAfter";
            this.rdbRecordingTimerStopAfter.Size = new System.Drawing.Size(157, 21);
            this.rdbRecordingTimerStopAfter.TabIndex = 1;
            this.rdbRecordingTimerStopAfter.Text = "stop recording after:";
            this.rdbRecordingTimerStopAfter.UseVisualStyleBackColor = true;
            this.rdbRecordingTimerStopAfter.CheckedChanged += new System.EventHandler(this.rdbRecordingTimerStopAfter_CheckedChanged);
            // 
            // rdbRecordingTimerNone
            // 
            this.rdbRecordingTimerNone.AutoSize = true;
            this.rdbRecordingTimerNone.Checked = true;
            this.rdbRecordingTimerNone.Location = new System.Drawing.Point(18, 30);
            this.rdbRecordingTimerNone.Name = "rdbRecordingTimerNone";
            this.rdbRecordingTimerNone.Size = new System.Drawing.Size(45, 21);
            this.rdbRecordingTimerNone.TabIndex = 0;
            this.rdbRecordingTimerNone.TabStop = true;
            this.rdbRecordingTimerNone.Text = "no";
            this.rdbRecordingTimerNone.UseVisualStyleBackColor = true;
            this.rdbRecordingTimerNone.CheckedChanged += new System.EventHandler(this.rdbRecordingTimerNone_CheckedChanged);
            // 
            // txtRecordingFileName
            // 
            this.txtRecordingFileName.Location = new System.Drawing.Point(16, 328);
            this.txtRecordingFileName.Name = "txtRecordingFileName";
            this.txtRecordingFileName.Size = new System.Drawing.Size(419, 22);
            this.txtRecordingFileName.TabIndex = 14;
            // 
            // chkAutoSize
            // 
            this.chkAutoSize.AutoSize = true;
            this.chkAutoSize.Location = new System.Drawing.Point(1098, 83);
            this.chkAutoSize.Name = "chkAutoSize";
            this.chkAutoSize.Size = new System.Drawing.Size(147, 21);
            this.chkAutoSize.TabIndex = 16;
            this.chkAutoSize.Text = "auto resize control";
            this.chkAutoSize.UseVisualStyleBackColor = true;
            this.chkAutoSize.CheckedChanged += new System.EventHandler(this.chkAutoSize_CheckedChanged);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(16, 538);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(427, 189);
            this.txtInfo.TabIndex = 17;
            this.txtInfo.Text = "Info:";
            // 
            // chkAutoReconnect
            // 
            this.chkAutoReconnect.AutoSize = true;
            this.chkAutoReconnect.Checked = true;
            this.chkAutoReconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoReconnect.Location = new System.Drawing.Point(12, 74);
            this.chkAutoReconnect.Name = "chkAutoReconnect";
            this.chkAutoReconnect.Size = new System.Drawing.Size(125, 21);
            this.chkAutoReconnect.TabIndex = 18;
            this.chkAutoReconnect.Text = "auto reconnect";
            this.chkAutoReconnect.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "connection timeout (ms):";
            // 
            // txtConnectionTimeout
            // 
            this.txtConnectionTimeout.Location = new System.Drawing.Point(329, 72);
            this.txtConnectionTimeout.Name = "txtConnectionTimeout";
            this.txtConnectionTimeout.Size = new System.Drawing.Size(99, 22);
            this.txtConnectionTimeout.TabIndex = 20;
            this.txtConnectionTimeout.Text = "10000";
            // 
            // txtJpegSnapshotFileName
            // 
            this.txtJpegSnapshotFileName.Location = new System.Drawing.Point(16, 399);
            this.txtJpegSnapshotFileName.Name = "txtJpegSnapshotFileName";
            this.txtJpegSnapshotFileName.Size = new System.Drawing.Size(419, 22);
            this.txtJpegSnapshotFileName.TabIndex = 22;
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.Location = new System.Drawing.Point(16, 366);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(390, 27);
            this.btnSnapshot.TabIndex = 23;
            this.btnSnapshot.Text = "make a JPEG capture 5 seconds after the start to this file:";
            this.btnSnapshot.UseVisualStyleBackColor = true;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // chkDoNotRecordImmediately
            // 
            this.chkDoNotRecordImmediately.AutoSize = true;
            this.chkDoNotRecordImmediately.Location = new System.Drawing.Point(19, 145);
            this.chkDoNotRecordImmediately.Name = "chkDoNotRecordImmediately";
            this.chkDoNotRecordImmediately.Size = new System.Drawing.Size(300, 21);
            this.chkDoNotRecordImmediately.TabIndex = 24;
            this.chkDoNotRecordImmediately.Text = "Hold recording (do not record immediately)";
            this.chkDoNotRecordImmediately.UseVisualStyleBackColor = true;
            this.chkDoNotRecordImmediately.CheckedChanged += new System.EventHandler(this.chkDoNotRecordImmediately_CheckedChanged);
            // 
            // grbBacktimedRecordingStart
            // 
            this.grbBacktimedRecordingStart.Controls.Add(this.label7);
            this.grbBacktimedRecordingStart.Controls.Add(this.txtBacktimedRecordingStartSeconds);
            this.grbBacktimedRecordingStart.Controls.Add(this.chkIncludeBacktimedRecordingStart);
            this.grbBacktimedRecordingStart.Enabled = false;
            this.grbBacktimedRecordingStart.Location = new System.Drawing.Point(19, 209);
            this.grbBacktimedRecordingStart.Name = "grbBacktimedRecordingStart";
            this.grbBacktimedRecordingStart.Size = new System.Drawing.Size(424, 58);
            this.grbBacktimedRecordingStart.TabIndex = 28;
            this.grbBacktimedRecordingStart.TabStop = false;
            this.grbBacktimedRecordingStart.Text = "backtimed recording start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "seconds";
            // 
            // txtBacktimedRecordingStartSeconds
            // 
            this.txtBacktimedRecordingStartSeconds.Location = new System.Drawing.Point(274, 29);
            this.txtBacktimedRecordingStartSeconds.Name = "txtBacktimedRecordingStartSeconds";
            this.txtBacktimedRecordingStartSeconds.Size = new System.Drawing.Size(36, 22);
            this.txtBacktimedRecordingStartSeconds.TabIndex = 30;
            this.txtBacktimedRecordingStartSeconds.Text = "5";
            // 
            // chkIncludeBacktimedRecordingStart
            // 
            this.chkIncludeBacktimedRecordingStart.AutoSize = true;
            this.chkIncludeBacktimedRecordingStart.Location = new System.Drawing.Point(6, 31);
            this.chkIncludeBacktimedRecordingStart.Name = "chkIncludeBacktimedRecordingStart";
            this.chkIncludeBacktimedRecordingStart.Size = new System.Drawing.Size(271, 21);
            this.chkIncludeBacktimedRecordingStart.TabIndex = 29;
            this.chkIncludeBacktimedRecordingStart.Text = "include a backtimed recording start of:";
            this.chkIncludeBacktimedRecordingStart.UseVisualStyleBackColor = true;
            // 
            // chkUseRecordingFileName
            // 
            this.chkUseRecordingFileName.AutoSize = true;
            this.chkUseRecordingFileName.Location = new System.Drawing.Point(16, 301);
            this.chkUseRecordingFileName.Name = "chkUseRecordingFileName";
            this.chkUseRecordingFileName.Size = new System.Drawing.Size(419, 21);
            this.chkUseRecordingFileName.TabIndex = 29;
            this.chkUseRecordingFileName.Text = "do not generate the file name automatically, record to this file:";
            this.chkUseRecordingFileName.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 733);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(430, 189);
            this.txtLog.TabIndex = 30;
            this.txtLog.Text = "Log:";
            // 
            // btnResumeRecording
            // 
            this.btnResumeRecording.Enabled = false;
            this.btnResumeRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumeRecording.Location = new System.Drawing.Point(19, 172);
            this.btnResumeRecording.Name = "btnResumeRecording";
            this.btnResumeRecording.Size = new System.Drawing.Size(190, 25);
            this.btnResumeRecording.TabIndex = 31;
            this.btnResumeRecording.Text = "resume recording";
            this.btnResumeRecording.UseVisualStyleBackColor = true;
            this.btnResumeRecording.Click += new System.EventHandler(this.btnResumeRecording_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(325, 139);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(33, 31);
            this.btnHelp.TabIndex = 32;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 944);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnResumeRecording);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.chkUseRecordingFileName);
            this.Controls.Add(this.grbBacktimedRecordingStart);
            this.Controls.Add(this.chkDoNotRecordImmediately);
            this.Controls.Add(this.btnSnapshot);
            this.Controls.Add(this.txtJpegSnapshotFileName);
            this.Controls.Add(this.txtConnectionTimeout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkAutoReconnect);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.chkAutoSize);
            this.Controls.Add(this.txtRecordingFileName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.videoGrabber1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStartMP4Recording);
            this.Controls.Add(this.btnStartPreview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbBacktimedRecordingStart.ResumeLayout(false);
            this.grbBacktimedRecordingStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartPreview;
        private System.Windows.Forms.Button btnStartMP4Recording;
        private System.Windows.Forms.Button btnStop;
        private VidGrab.VideoGrabber videoGrabber1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecordingTimerInterval;
        private System.Windows.Forms.RadioButton rdbRecordingTimerNewFileEvery;
        private System.Windows.Forms.RadioButton rdbRecordingTimerStopAfter;
        private System.Windows.Forms.RadioButton rdbRecordingTimerNone;
        private System.Windows.Forms.TextBox txtRecordingFileName;
        private System.Windows.Forms.CheckBox chkAutoSize;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.CheckBox chkAutoReconnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConnectionTimeout;
        private System.Windows.Forms.TextBox txtJpegSnapshotFileName;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.CheckBox chkDoNotRecordImmediately;
        private System.Windows.Forms.GroupBox grbBacktimedRecordingStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBacktimedRecordingStartSeconds;
        private System.Windows.Forms.CheckBox chkIncludeBacktimedRecordingStart;
        private System.Windows.Forms.CheckBox chkUseRecordingFileName;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnResumeRecording;
        private System.Windows.Forms.Button btnHelp;
    }
}

