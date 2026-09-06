namespace Record_4_IP_Cameras_To_OneFile
{
    partial class IPCameraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPCameraForm));
            this.vgIPCamera = new VidGrab.VideoGrabber();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vgIPCamera
            // 
            this.vgIPCamera.AdjustOverlayAspectRatio = true;
            this.vgIPCamera.AdjustPixelAspectRatio = true;
            this.vgIPCamera.Aero = VidGrab.TAero.ae_Default;
            this.vgIPCamera.AnalogVideoStandard = -1;
            this.vgIPCamera.ApplicationPriority = VidGrab.TApplicationPriority.ap_default;
            this.vgIPCamera.ASFAudioBitRate = -1;
            this.vgIPCamera.ASFAudioChannels = -1;
            this.vgIPCamera.ASFBufferWindow = -1;
            this.vgIPCamera.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced;
            this.vgIPCamera.ASFDirectStreamingKeepClientsConnected = false;
            this.vgIPCamera.ASFFixedFrameRate = true;
            this.vgIPCamera.ASFMediaServerPublishingPoint = "";
            this.vgIPCamera.ASFMediaServerRemovePublishingPointAfterDisconnect = false;
            this.vgIPCamera.ASFMediaServerTemplatePublishingPoint = "";
            this.vgIPCamera.ASFNetworkMaxUsers = 5;
            this.vgIPCamera.ASFNetworkPort = 0;
            this.vgIPCamera.ASFProfile = -1;
            this.vgIPCamera.ASFProfileFromCustomFile = "";
            this.vgIPCamera.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8;
            this.vgIPCamera.ASFVideoBitRate = -1;
            this.vgIPCamera.ASFVideoFrameRate = 0D;
            this.vgIPCamera.ASFVideoHeight = -1;
            this.vgIPCamera.ASFVideoMaxKeyFrameSpacing = -1;
            this.vgIPCamera.ASFVideoQuality = -1;
            this.vgIPCamera.ASFVideoWidth = -1;
            this.vgIPCamera.AspectRatioToUse = -1D;
            this.vgIPCamera.AssociateAudioAndVideoDevices = false;
            this.vgIPCamera.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_PassThru;
            this.vgIPCamera.AudioCompressor = 0;
            this.vgIPCamera.AudioDevice = -1;
            this.vgIPCamera.AudioDeviceRendering = false;
            this.vgIPCamera.AudioFormat = VidGrab.TAudioFormat.af_default;
            this.vgIPCamera.AudioInput = -1;
            this.vgIPCamera.AudioPeakEvent = true;
            this.vgIPCamera.AudioRecording = false;
            this.vgIPCamera.AudioRenderer = -1;
            this.vgIPCamera.AudioSource = VidGrab.TAudioSource.as_Default;
            this.vgIPCamera.AudioStreamNumber = -1;
            this.vgIPCamera.AudioSyncAdjustment = 0;
            this.vgIPCamera.AudioSyncAdjustmentEnabled = false;
            this.vgIPCamera.AutoConnectRelatedPins = true;
            this.vgIPCamera.AutoFileName = VidGrab.TAutoFileName.fn_Sequential;
            this.vgIPCamera.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz";
            this.vgIPCamera.AutoFileNameMinDigits = 6;
            this.vgIPCamera.AutoFilePrefix = "vg";
            this.vgIPCamera.AutoFileSuffix = "";
            this.vgIPCamera.AutoRefreshPreview = false;
            this.vgIPCamera.AutoStartPlayer = true;
            this.vgIPCamera.AVIDurationUpdated = true;
            this.vgIPCamera.AVIFormatOpenDML = true;
            this.vgIPCamera.AVIFormatOpenDMLCompatibilityIndex = true;
            this.vgIPCamera.BackgroundColor = 0;
            this.vgIPCamera.BurstCount = 3;
            this.vgIPCamera.BurstInterval = 0;
            this.vgIPCamera.BurstMode = false;
            this.vgIPCamera.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap;
            this.vgIPCamera.BusyCursor = VidGrab.TCursors.cr_HourGlass;
            this.vgIPCamera.CameraControlSettings = true;
            this.vgIPCamera.CaptureFileExt = "";
            this.vgIPCamera.ColorKey = 1048592;
            this.vgIPCamera.ColorKeyEnabled = false;
            this.vgIPCamera.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression;
            this.vgIPCamera.CompressionType = VidGrab.TCompressionType.ct_Video;
            this.vgIPCamera.Cropping_Enabled = false;
            this.vgIPCamera.Cropping_Height = 120;
            this.vgIPCamera.Cropping_Outbounds = true;
            this.vgIPCamera.Cropping_Width = 160;
            this.vgIPCamera.Cropping_X = 0;
            this.vgIPCamera.Cropping_Y = 0;
            this.vgIPCamera.Cropping_Zoom = 1D;
            this.vgIPCamera.Display_Active = true;
            this.vgIPCamera.Display_AlphaBlendEnabled = false;
            this.vgIPCamera.Display_AlphaBlendValue = 180;
            this.vgIPCamera.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.vgIPCamera.Display_AutoSize = false;
            this.vgIPCamera.Display_Embedded = true;
            this.vgIPCamera.Display_Embedded_FitParent = false;
            this.vgIPCamera.Display_FullScreen = false;
            this.vgIPCamera.Display_Height = 240;
            this.vgIPCamera.Display_Left = 10;
            this.vgIPCamera.Display_Monitor = 0;
            this.vgIPCamera.Display_MouseMovesWindow = true;
            this.vgIPCamera.Display_PanScanRatio = 50;
            this.vgIPCamera.Display_StayOnTop = false;
            this.vgIPCamera.Display_Top = 10;
            this.vgIPCamera.Display_TransparentColorEnabled = false;
            this.vgIPCamera.Display_TransparentColorValue = 255;
            this.vgIPCamera.Display_VideoPortEnabled = true;
            this.vgIPCamera.Display_Visible = true;
            this.vgIPCamera.Display_Width = 320;
            this.vgIPCamera.DoubleBuffered = false;
            this.vgIPCamera.DroppedFramesPollingInterval = -1;
            this.vgIPCamera.DualDisplay_Active = false;
            this.vgIPCamera.DualDisplay_AlphaBlendEnabled = false;
            this.vgIPCamera.DualDisplay_AlphaBlendValue = 180;
            this.vgIPCamera.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.vgIPCamera.DualDisplay_AutoSize = false;
            this.vgIPCamera.DualDisplay_Embedded = false;
            this.vgIPCamera.DualDisplay_Embedded_FitParent = false;
            this.vgIPCamera.DualDisplay_FullScreen = false;
            this.vgIPCamera.DualDisplay_Height = 240;
            this.vgIPCamera.DualDisplay_Left = 20;
            this.vgIPCamera.DualDisplay_Monitor = 0;
            this.vgIPCamera.DualDisplay_MouseMovesWindow = true;
            this.vgIPCamera.DualDisplay_PanScanRatio = 50;
            this.vgIPCamera.DualDisplay_StayOnTop = false;
            this.vgIPCamera.DualDisplay_Top = 400;
            this.vgIPCamera.DualDisplay_TransparentColorEnabled = false;
            this.vgIPCamera.DualDisplay_TransparentColorValue = 255;
            this.vgIPCamera.DualDisplay_VideoPortEnabled = false;
            this.vgIPCamera.DualDisplay_Visible = true;
            this.vgIPCamera.DualDisplay_Width = 320;
            this.vgIPCamera.DVDateTimeEnabled = true;
            this.vgIPCamera.DVDiscontinuityMinimumInterval = 3;
            this.vgIPCamera.DVDTitle = 0;
            this.vgIPCamera.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD;
            this.vgIPCamera.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full;
            this.vgIPCamera.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default;
            this.vgIPCamera.DVRecordingInNativeFormatSeparatesStreams = false;
            this.vgIPCamera.DVReduceFrameRate = false;
            this.vgIPCamera.DVRgb219 = false;
            this.vgIPCamera.DVTimeCodeEnabled = false;
            this.vgIPCamera.EventNotificationSynchrone = true;
            this.vgIPCamera.ExtraDLLPath = "";
            this.vgIPCamera.FixFlickerOrBlackCapture = false;
            this.vgIPCamera.FrameCaptureHeight = -1;
            this.vgIPCamera.FrameCaptureWidth = -1;
            this.vgIPCamera.FrameCaptureWithoutOverlay = false;
            this.vgIPCamera.FrameCaptureZoomSize = 100;
            this.vgIPCamera.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams;
            this.vgIPCamera.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default;
            this.vgIPCamera.FrameNumberStartsFromZero = false;
            this.vgIPCamera.FrameRate = 0D;
            this.vgIPCamera.FrameRateDivider = 0;
            this.vgIPCamera.GeneratePts = false;
            this.vgIPCamera.GetLastFrameWaitTimeoutMs = 0;
            this.vgIPCamera.ImageOverlay_AlphaBlend = false;
            this.vgIPCamera.ImageOverlay_AlphaBlendValue = 180;
            this.vgIPCamera.ImageOverlay_ChromaKey = false;
            this.vgIPCamera.ImageOverlay_ChromaKeyLeewayPercent = 25;
            this.vgIPCamera.ImageOverlay_ChromaKeyRGBColor = 0;
            this.vgIPCamera.ImageOverlay_Height = -1;
            this.vgIPCamera.ImageOverlay_LeftLocation = 10;
            this.vgIPCamera.ImageOverlay_RotationAngle = 0D;
            this.vgIPCamera.ImageOverlay_StretchToVideoSize = false;
            this.vgIPCamera.ImageOverlay_TargetDisplay = -1;
            this.vgIPCamera.ImageOverlay_TopLocation = 10;
            this.vgIPCamera.ImageOverlay_Transparent = false;
            this.vgIPCamera.ImageOverlay_TransparentColorValue = 0;
            this.vgIPCamera.ImageOverlay_UseTransparentColor = false;
            this.vgIPCamera.ImageOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.vgIPCamera.ImageOverlay_Width = -1;
            this.vgIPCamera.ImageOverlayEnabled = false;
            this.vgIPCamera.IPCameraURL = "";
            this.vgIPCamera.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality;
            this.vgIPCamera.JPEGProgressiveDisplay = false;
            this.vgIPCamera.JPEGQuality = 100;
            this.vgIPCamera.LicenseString = "N/A";
            this.vgIPCamera.Location = new System.Drawing.Point(242, 81);
            this.vgIPCamera.LogoDisplayed = false;
            this.vgIPCamera.LogoLayout = VidGrab.TLogoLayout.lg_Stretched;
            this.vgIPCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vgIPCamera.MixAudioSamples_CurrentSourceLevel = 100;
            this.vgIPCamera.MixAudioSamples_ExternalSourceLevel = 100;
            this.vgIPCamera.Mixer_MosaicColumns = 1;
            this.vgIPCamera.Mixer_MosaicLines = 1;
            this.vgIPCamera.MotionDetector_CompareBlue = true;
            this.vgIPCamera.MotionDetector_CompareGreen = true;
            this.vgIPCamera.MotionDetector_CompareRed = true;
            this.vgIPCamera.MotionDetector_Enabled = false;
            this.vgIPCamera.MotionDetector_GreyScale = false;
            this.vgIPCamera.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" +
    "555555 5555555555 5555555555";
            this.vgIPCamera.MotionDetector_MaxDetectionsPerSecond = 0D;
            this.vgIPCamera.MotionDetector_MotionResetMs = 0;
            this.vgIPCamera.MotionDetector_ReduceCPULoad = 1;
            this.vgIPCamera.MotionDetector_ReduceVideoNoise = false;
            this.vgIPCamera.MotionDetector_Triggered = false;
            this.vgIPCamera.MouseWheelControlsZoomAtCursor = false;
            this.vgIPCamera.MouseWheelEventEnabled = true;
            this.vgIPCamera.MultiplexedInputEmulation = true;
            this.vgIPCamera.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed;
            this.vgIPCamera.MultiplexedStabilizationDelay = 100;
            this.vgIPCamera.MultiplexedSwitchDelay = 0;
            this.vgIPCamera.Multiplexer = -1;
            this.vgIPCamera.MuteAudioRendering = false;
            this.vgIPCamera.Name = "vgIPCamera";
            this.vgIPCamera.NDIBandwidthType = VidGrab.TNDIBandwidthType.nbt_HighestBandwidth;
            this.vgIPCamera.NDIFormatType = VidGrab.TNDIFormatType.nft_progressive;
            this.vgIPCamera.NDIGroups = "";
            this.vgIPCamera.NDIName = "DATASTEAD_UNNAMED_SOURCE";
            this.vgIPCamera.NDIReceiveTimeoutMs = 5000;
            this.vgIPCamera.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled;
            this.vgIPCamera.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming;
            this.vgIPCamera.NormalCursor = VidGrab.TCursors.cr_Default;
            this.vgIPCamera.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread;
            this.vgIPCamera.NotificationPriority = VidGrab.TThreadPriority.tpNormal;
            this.vgIPCamera.NotificationSleepTime = -1;
            this.vgIPCamera.OnFrameBitmapEventSynchrone = false;
            this.vgIPCamera.OpenURLAsync = true;
            this.vgIPCamera.OverlayAfterTransform = false;
            this.vgIPCamera.PlayerAudioRendering = true;
            this.vgIPCamera.PlayerDVSize = VidGrab.TDVSize.dv_Full;
            this.vgIPCamera.PlayerFastSeekSpeedRatio = 4;
            this.vgIPCamera.PlayerFileName = "";
            this.vgIPCamera.PlayerForcedCodec = "";
            this.vgIPCamera.PlayerHwAccel = VidGrab.THwAccel.hw_None;
            this.vgIPCamera.PlayerRefreshPausedDisplay = false;
            this.vgIPCamera.PlayerRefreshPausedDisplayFrameRate = 0D;
            this.vgIPCamera.PlayerSpeedRatio = 1D;
            this.vgIPCamera.PlayerSpeedRatioConstantAudioPitch = true;
            this.vgIPCamera.PlayerTrackBarSynchrone = false;
            this.vgIPCamera.PreallocCapFileCopiedAfterRecording = true;
            this.vgIPCamera.PreallocCapFileEnabled = false;
            this.vgIPCamera.PreallocCapFileName = "";
            this.vgIPCamera.PreallocCapFileSizeInMB = 100;
            this.vgIPCamera.PreviewZoomSize = 100;
            this.vgIPCamera.QuickDeviceInitialization = false;
            this.vgIPCamera.RawAudioSampleCapture = false;
            this.vgIPCamera.RawCaptureAsyncEvent = true;
            this.vgIPCamera.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat;
            this.vgIPCamera.RawVideoSampleCapture = false;
            this.vgIPCamera.RecordingAudioBitRate = -1;
            this.vgIPCamera.RecordingFileName = "";
            this.vgIPCamera.RecordingFileSizeMaxInMB = 0;
            this.vgIPCamera.RecordingInNativeFormat = true;
            this.vgIPCamera.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;
            this.vgIPCamera.RecordingOnMotion_Enabled = false;
            this.vgIPCamera.RecordingOnMotion_MotionThreshold = 0D;
            this.vgIPCamera.RecordingOnMotion_NoMotionPauseDelayMs = 5000;
            this.vgIPCamera.RecordingPauseCreatesNewFile = false;
            this.vgIPCamera.RecordingSize = VidGrab.TRecordingSize.rs_Default;
            this.vgIPCamera.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled;
            this.vgIPCamera.RecordingTimerInterval = 60;
            this.vgIPCamera.RecordingVideoBitRate = -1;
            this.vgIPCamera.Reencoding_IncludeAudioStream = true;
            this.vgIPCamera.Reencoding_IncludeVideoStream = true;
            this.vgIPCamera.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF;
            this.vgIPCamera.Reencoding_NewVideoClip = "";
            this.vgIPCamera.Reencoding_SourceVideoClip = "";
            this.vgIPCamera.Reencoding_StartFrame = ((long)(-1));
            this.vgIPCamera.Reencoding_StartTime = ((long)(-1));
            this.vgIPCamera.Reencoding_StopFrame = ((long)(-1));
            this.vgIPCamera.Reencoding_StopTime = ((long)(-1));
            this.vgIPCamera.Reencoding_UseAudioCompressor = false;
            this.vgIPCamera.Reencoding_UseFrameGrabber = true;
            this.vgIPCamera.Reencoding_UseVideoCompressor = false;
            this.vgIPCamera.Reencoding_WMVOutput = false;
            this.vgIPCamera.ScreenRecordingLayeredWindows = false;
            this.vgIPCamera.ScreenRecordingMonitor = 0;
            this.vgIPCamera.ScreenRecordingNonVisibleWindows = false;
            this.vgIPCamera.ScreenRecordingSizePercent = 100;
            this.vgIPCamera.ScreenRecordingThroughClipboard = false;
            this.vgIPCamera.ScreenRecordingWithCursor = true;
            this.vgIPCamera.Size = new System.Drawing.Size(652, 452);
            this.vgIPCamera.SpeakerControl = false;
            this.vgIPCamera.StoragePath = "";
            this.vgIPCamera.StoragePathMode = VidGrab.TStoragePathMode.spm_AutoFileNameOnly;
            this.vgIPCamera.StoreDeviceSettingsInRegistry = true;
            this.vgIPCamera.StreamInterface_Format = "";
            this.vgIPCamera.StreamInterface_FrameRate = 0D;
            this.vgIPCamera.StreamInterface_IsRealTime = true;
            this.vgIPCamera.SyncCommands = true;
            this.vgIPCamera.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master;
            this.vgIPCamera.Synchronized = false;
            this.vgIPCamera.SyncPreview = VidGrab.TSyncPreview.sp_Auto;
            this.vgIPCamera.TabIndex = 15;
            this.vgIPCamera.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left;
            this.vgIPCamera.TextOverlay_AlphaBlend = false;
            this.vgIPCamera.TextOverlay_AlphaBlendValue = 180;
            this.vgIPCamera.TextOverlay_BkColor = 16777215;
            this.vgIPCamera.TextOverlay_Enabled = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.vgIPCamera.TextOverlay_FontColor = 16776960;
            this.vgIPCamera.TextOverlay_FontSize = 12;
            this.vgIPCamera.TextOverlay_GradientColor = 8388608;
            this.vgIPCamera.TextOverlay_GradientMode = VidGrab.TTextOverlayGradientMode.gm_Disabled;
            this.vgIPCamera.TextOverlay_HighResFont = true;
            this.vgIPCamera.TextOverlay_Left = 0;
            this.vgIPCamera.TextOverlay_Orientation = VidGrab.TTextOrientation.to_Horizontal;
            this.vgIPCamera.TextOverlay_Right = -1;
            this.vgIPCamera.TextOverlay_Scrolling = false;
            this.vgIPCamera.TextOverlay_ScrollingSpeed = 1;
            this.vgIPCamera.TextOverlay_Shadow = true;
            this.vgIPCamera.TextOverlay_ShadowColor = 0;
            this.vgIPCamera.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_SouthEast;
            this.vgIPCamera.TextOverlay_String = resources.GetString("vgIPCamera.TextOverlay_String");
            this.vgIPCamera.TextOverlay_TargetDisplay = -1;
            this.vgIPCamera.TextOverlay_Top = 0;
            this.vgIPCamera.TextOverlay_Transparent = true;
            this.vgIPCamera.TextOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.vgIPCamera.ThirdPartyDeinterlacer = "";
            this.vgIPCamera.TranslateMouseCoordinates = true;
            this.vgIPCamera.TunerFrequency = -1;
            this.vgIPCamera.TVUseFrequencyOverrides = false;
            this.vgIPCamera.UseClock = true;
            this.vgIPCamera.v360_AspectRatio = 0D;
            this.vgIPCamera.v360_Enabled = false;
            this.vgIPCamera.v360_MasterAngle = VidGrab.Tv360_Angle.v360_fov_Horizontal;
            this.vgIPCamera.v360_MouseAction = VidGrab.TV360_MouseAction.ma_MouseMove;
            this.vgIPCamera.v360_MouseActionPercent = 10;
            this.vgIPCamera.Version = "v16.4.1.2 (build 5401.260121) - Copyright © 2026 Datastead";
            this.vgIPCamera.VideoCompression_DataRate = -1;
            this.vgIPCamera.VideoCompression_KeyFrameRate = 15;
            this.vgIPCamera.VideoCompression_PFramesPerKeyFrame = 0;
            this.vgIPCamera.VideoCompression_Quality = 1D;
            this.vgIPCamera.VideoCompression_WindowSize = -1;
            this.vgIPCamera.VideoCompressor = 0;
            this.vgIPCamera.VideoControlSettings = true;
            this.vgIPCamera.VideoCursor = VidGrab.TCursors.cr_Default;
            this.vgIPCamera.VideoDelay = ((long)(0));
            this.vgIPCamera.VideoDevice = -1;
            this.vgIPCamera.VideoFormat = -1;
            this.vgIPCamera.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc;
            this.vgIPCamera.VideoFromImages_RepeatIndefinitely = false;
            this.vgIPCamera.VideoFromImages_SourceDirectory = "";
            this.vgIPCamera.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat";
            this.vgIPCamera.VideoInput = -1;
            this.vgIPCamera.VideoPlayableWhileRecording = false;
            this.vgIPCamera.VideoProcessing_Brightness = 0;
            this.vgIPCamera.VideoProcessing_Contrast = 0;
            this.vgIPCamera.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled;
            this.vgIPCamera.VideoProcessing_FlipHorizontal = false;
            this.vgIPCamera.VideoProcessing_FlipVertical = false;
            this.vgIPCamera.VideoProcessing_GrayScale = false;
            this.vgIPCamera.VideoProcessing_Hue = 0;
            this.vgIPCamera.VideoProcessing_InvertColors = false;
            this.vgIPCamera.VideoProcessing_Pixellization = 1;
            this.vgIPCamera.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg;
            this.vgIPCamera.VideoProcessing_RotationCustomAngle = 45.5D;
            this.vgIPCamera.VideoProcessing_Saturation = 0;
            this.vgIPCamera.VideoQualitySettings = true;
            this.vgIPCamera.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect;
            this.vgIPCamera.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None;
            this.vgIPCamera.VideoRendererExternalIndex = -1;
            this.vgIPCamera.VideoRendererPriority = VidGrab.TVideoRendererPriority.vrp_Auto;
            this.vgIPCamera.VideoSize = -1;
            this.vgIPCamera.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            this.vgIPCamera.VideoSource_FileOrURL = "";
            this.vgIPCamera.VideoSource_FileOrURL_StartTime = ((long)(-1));
            this.vgIPCamera.VideoSource_FileOrURL_StopTime = ((long)(-1));
            this.vgIPCamera.VideoStreamNumber = -1;
            this.vgIPCamera.VideoSubtype = -1;
            this.vgIPCamera.VideoVisibleWhenStopped = false;
            this.vgIPCamera.VirtualAudioStreamControl = -1;
            this.vgIPCamera.VirtualVideoStreamControl = -1;
            this.vgIPCamera.VuMeter = VidGrab.TVuMeter.vu_Disabled;
            this.vgIPCamera.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled;
            this.vgIPCamera.ZoomCoeff = 1000;
            this.vgIPCamera.ZoomXCenter = 0;
            this.vgIPCamera.ZoomYCenter = 0;
            this.vgIPCamera.OnLog += new VidGrab.OnLogEventHandler(this.vgIPCamera_OnLog);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(52, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 24);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start preview";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(189, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(122, 24);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Stop preview";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(11, 81);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(224, 451);
            this.txtLog.TabIndex = 19;
            this.txtLog.Text = "log:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(52, 52);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(814, 22);
            this.txtURL.TabIndex = 20;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "URL:";
            // 
            // IPCameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.vgIPCamera);
            this.Name = "IPCameraForm";
            this.Text = "IPCameraForm";
            this.Load += new System.EventHandler(this.IPCameraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public VidGrab.VideoGrabber vgIPCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
    }
}