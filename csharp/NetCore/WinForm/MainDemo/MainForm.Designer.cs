
namespace MainDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
				this.VideoGrabber1 = new VidGrab.VideoGrabber();
            this.mmoLog = new System.Windows.Forms.TextBox();
            this.edtDVDateTime = new System.Windows.Forms.TextBox();
            this.edtFrameCount = new System.Windows.Forms.TextBox();
            this.edtStoragePath = new System.Windows.Forms.TextBox();
            this.gbPlayerControl = new System.Windows.Forms.GroupBox();
            this.btnFrameStep = new System.Windows.Forms.Button();
            this.btnFastFwd = new System.Windows.Forms.Button();
            this.btnFastRew = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlayBackwards = new System.Windows.Forms.Button();
            this.tbrPlayer = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.chkPlayerTrackBarSynchrone = new System.Windows.Forms.CheckBox();
            this.tbrZoom = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbrZoomX = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpReencoding = new System.Windows.Forms.TabPage();
            this.tbpDisplay = new System.Windows.Forms.TabPage();
            this.tbpVideoProcessing = new System.Windows.Forms.TabPage();
            this.tbpOverlays = new System.Windows.Forms.TabPage();
            this.tbpMotionDetection = new System.Windows.Forms.TabPage();
            this.tbpFrameGrabber = new System.Windows.Forms.TabPage();
            this.tbpPlayer = new System.Windows.Forms.TabPage();
            this.tbpNetworkStreaming = new System.Windows.Forms.TabPage();
            this.tbpMultipurposeEncoder = new System.Windows.Forms.TabPage();
            this.tbpRecording = new System.Windows.Forms.TabPage();
            this.tbpAudio = new System.Windows.Forms.TabPage();
            this.tbpIPCameras = new System.Windows.Forms.TabPage();
            this.tbpVideoSource = new System.Windows.Forms.TabPage();
            this.tbcTabs = new System.Windows.Forms.TabControl();
            this.tbrZoomY = new System.Windows.Forms.TrackBar();
            this.gbPlayerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomX)).BeginInit();
            this.tbcTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomY)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoGrabber1
            // 
            this.VideoGrabber1.Parent = this;
            this.VideoGrabber1.Location = new System.Drawing.Point(356, 542);
            this.VideoGrabber1.Size = new System.Drawing.Size(718, 404);
            this.VideoGrabber1.Name = "VideoGrabber1";
            this.VideoGrabber1.AdjustOverlayAspectRatio = true;
            this.VideoGrabber1.AdjustPixelAspectRatio = true;
            this.VideoGrabber1.OnAudioDeviceSelected += new System.EventHandler(this.VideoGrabber1_OnAudioDeviceSelected);
            this.VideoGrabber1.OnClientConnection += new VidGrab.OnClientConnectionEventHandler(this.VideoGrabber1_OnClientConnection);
            this.VideoGrabber1.OnCopyPreallocDataCompleted += new VidGrab.OnCopyPreallocDataCompletedEventHandler(this.VideoGrabber1_OnCopyPreallocDataCompleted);
            this.VideoGrabber1.OnCopyPreallocDataProgress += new VidGrab.OnCopyPreallocDataProgressEventHandler(this.VideoGrabber1_OnCopyPreallocDataProgress);
            this.VideoGrabber1.OnCopyPreallocDataStarted += new VidGrab.OnCopyPreallocDataStartedEventHandler(this.VideoGrabber1_OnCopyPreallocDataStarted);
            this.VideoGrabber1.OnCreatePreallocFileCompleted += new VidGrab.OnCreatePreallocFileCompletedEventHandler(this.VideoGrabber1_OnCreatePreallocFileCompleted);
            this.VideoGrabber1.OnCreatePreallocFileProgress += new VidGrab.OnCreatePreallocFileProgressEventHandler(this.VideoGrabber1_OnCreatePreallocFileProgress);
            this.VideoGrabber1.OnCreatePreallocFileStarted += new VidGrab.OnCreatePreallocFileStartedEventHandler(this.VideoGrabber1_OnCreatePreallocFileStarted);
            this.VideoGrabber1.OnDeviceArrivalOrRemoval += new VidGrab.OnDeviceArrivalOrRemovalEventHandler(this.VideoGrabber1_OnDeviceArrivalOrRemoval);
            this.VideoGrabber1.OnDeviceLost += new System.EventHandler(this.VideoGrabber1_OnDeviceLost);
            this.VideoGrabber1.OnDirectNetworkStreamingHostUrl += new VidGrab.OnDirectNetworkStreamingHostUrlEventHandler(this.VideoGrabber1_OnDirectNetworkStreamingHostUrl);
            this.VideoGrabber1.OnDiskFull += new System.EventHandler(this.VideoGrabber1_OnDiskFull);
            this.VideoGrabber1.OnDVCommandCompleted += new VidGrab.OnDVCommandCompletedEventHandler(this.VideoGrabber1_OnDVCommandCompleted);
            this.VideoGrabber1.OnDVDiscontinuity += new VidGrab.OnDVDiscontinuityEventHandler(this.VideoGrabber1_OnDVDiscontinuity);
            this.VideoGrabber1.OnEnumerateWindows += new VidGrab.OnEnumerateWindowsEventHandler(this.VideoGrabber1_OnEnumerateWindows);
            this.VideoGrabber1.OnFrameBitmap += new VidGrab.OnFrameBitmapEventHandler(this.VideoGrabber1_OnFrameBitmap);
            this.VideoGrabber1.OnFrameCaptureCompleted += new VidGrab.OnFrameCaptureCompletedEventHandler(this.VideoGrabber1_OnFrameCaptureCompleted);
            this.VideoGrabber1.OnFrameProgress2 += new VidGrab.OnFrameProgress2EventHandler(this.VideoGrabber1_OnFrameProgress2);
            this.VideoGrabber1.OnGraphBuilt += new System.EventHandler(this.VideoGrabber1_OnGraphBuilt);
            this.VideoGrabber1.OnInactive += new System.EventHandler(this.VideoGrabber1_OnInactive);
            this.VideoGrabber1.OnLog += new VidGrab.OnLogEventHandler(this.VideoGrabber1_OnLog);
            this.VideoGrabber1.OnMotionDetected += new VidGrab.OnMotionDetectedEventHandler(this.VideoGrabber1_OnMotionDetected);
            this.VideoGrabber1.OnMotionNotDetected += new VidGrab.OnMotionNotDetectedEventHandler(this.VideoGrabber1_OnMotionNotDetected);
            this.VideoGrabber1.OnMouseDown += new VidGrab.OnMouseDownEventHandler(this.VideoGrabber1_OnMouseDown);
            this.VideoGrabber1.OnMouseMove += new VidGrab.OnMouseMoveEventHandler(this.VideoGrabber1_OnMouseMove);
            this.VideoGrabber1.OnMouseUp += new VidGrab.OnMouseUpEventHandler(this.VideoGrabber1_OnMouseUp);
            this.VideoGrabber1.OnPlayerEndOfStream += new System.EventHandler(this.VideoGrabber1_OnPlayerEndOfStream);
            this.VideoGrabber1.OnPlayerOpened += new System.EventHandler(this.VideoGrabber1_OnPlayerOpened);
            this.VideoGrabber1.OnPlayerUpdateTrackbarPosition += new VidGrab.OnPlayerUpdateTrackbarPositionEventHandler(this.VideoGrabber1_OnPlayerUpdateTrackbarPosition);
            this.VideoGrabber1.OnPreviewStarted += new System.EventHandler(this.VideoGrabber1_OnPreviewStarted);
            this.VideoGrabber1.OnRecordingCompleted += new VidGrab.OnRecordingCompletedEventHandler(this.VideoGrabber1_OnRecordingCompleted);
            this.VideoGrabber1.OnRecordingPaused += new System.EventHandler(this.VideoGrabber1_OnRecordingPaused);
            this.VideoGrabber1.OnRecordingReadyToStart += new System.EventHandler(this.VideoGrabber1_OnRecordingReadyToStart);
            this.VideoGrabber1.OnRecordingStarted += new VidGrab.OnRecordingStartedEventHandler(this.VideoGrabber1_OnRecordingStarted);
            this.VideoGrabber1.OnReencodingCompleted += new VidGrab.OnReencodingCompletedEventHandler(this.VideoGrabber1_OnReencodingCompleted);
            this.VideoGrabber1.OnReencodingProgress += new VidGrab.OnReencodingProgressEventHandler(this.VideoGrabber1_OnReencodingProgress);
            this.VideoGrabber1.OnReencodingStarted += new VidGrab.OnReencodingStartedEventHandler(this.VideoGrabber1_OnReencodingStarted);
            this.VideoGrabber1.OnReinitializing += new System.EventHandler(this.VideoGrabber1_OnReinitializing);
            this.VideoGrabber1.OnResizeVideo += new VidGrab.OnResizeVideoEventHandler(this.VideoGrabber1_OnResizeVideo);
            this.VideoGrabber1.OnVideoDeviceSelected += new System.EventHandler(this.VideoGrabber1_OnVideoDeviceSelected);
            this.VideoGrabber1.OnVideoFromBitmapsNextFrameNeeded += new VidGrab.OnVideoFromBitmapsNextFrameNeededEventHandler(this.VideoGrabber1_OnVideoFromBitmapsNextFrameNeeded);
            this.VideoGrabber1.SizeChanged += new System.EventHandler(this.VideoGrabber1_SizeChanged);
            // 
            // mmoLog
            // 
            this.mmoLog.AcceptsReturn = true;
            this.mmoLog.BackColor = System.Drawing.SystemColors.Window;
            this.mmoLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmoLog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mmoLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmoLog.Location = new System.Drawing.Point(8, 577);
            this.mmoLog.MaxLength = 0;
            this.mmoLog.Multiline = true;
            this.mmoLog.Name = "mmoLog";
            this.mmoLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmoLog.Size = new System.Drawing.Size(292, 502);
            this.mmoLog.TabIndex = 50;
            // 
            // edtDVDateTime
            // 
            this.edtDVDateTime.AcceptsReturn = true;
            this.edtDVDateTime.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtDVDateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDVDateTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtDVDateTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDVDateTime.Location = new System.Drawing.Point(8, 540);
            this.edtDVDateTime.MaxLength = 0;
            this.edtDVDateTime.Name = "edtDVDateTime";
            this.edtDVDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDVDateTime.Size = new System.Drawing.Size(292, 23);
            this.edtDVDateTime.TabIndex = 49;
            // 
            // edtFrameCount
            // 
            this.edtFrameCount.AcceptsReturn = true;
            this.edtFrameCount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtFrameCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFrameCount.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtFrameCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFrameCount.Location = new System.Drawing.Point(8, 503);
            this.edtFrameCount.MaxLength = 0;
            this.edtFrameCount.Name = "edtFrameCount";
            this.edtFrameCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFrameCount.Size = new System.Drawing.Size(292, 23);
            this.edtFrameCount.TabIndex = 48;
            // 
            // edtStoragePath
            // 
            this.edtStoragePath.AcceptsReturn = true;
            this.edtStoragePath.BackColor = System.Drawing.SystemColors.Window;
            this.edtStoragePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStoragePath.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtStoragePath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStoragePath.Location = new System.Drawing.Point(8, 467);
            this.edtStoragePath.MaxLength = 0;
            this.edtStoragePath.Name = "edtStoragePath";
            this.edtStoragePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStoragePath.Size = new System.Drawing.Size(292, 23);
            this.edtStoragePath.TabIndex = 46;
            this.edtStoragePath.TextChanged += new System.EventHandler(this.edtStoragePath_TextChanged);
            // 
            // gbPlayerControl
            // 
            this.gbPlayerControl.Controls.Add(this.btnFrameStep);
            this.gbPlayerControl.Controls.Add(this.btnFastFwd);
            this.gbPlayerControl.Controls.Add(this.btnFastRew);
            this.gbPlayerControl.Controls.Add(this.btnPlay);
            this.gbPlayerControl.Controls.Add(this.btnPause);
            this.gbPlayerControl.Controls.Add(this.btnPlayBackwards);
            this.gbPlayerControl.Controls.Add(this.tbrPlayer);
            this.gbPlayerControl.Controls.Add(this.btnStop);
            this.gbPlayerControl.Location = new System.Drawing.Point(8, 371);
            this.gbPlayerControl.Name = "gbPlayerControl";
            this.gbPlayerControl.Size = new System.Drawing.Size(1300, 68);
            this.gbPlayerControl.TabIndex = 60;
            this.gbPlayerControl.TabStop = false;
            this.gbPlayerControl.Text = "player control";
            // 
            // btnFrameStep
            // 
            this.btnFrameStep.BackColor = System.Drawing.SystemColors.Control;
            this.btnFrameStep.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFrameStep.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFrameStep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFrameStep.ImageIndex = 6;
            this.btnFrameStep.ImageList = this.ImageList1;
            this.btnFrameStep.Location = new System.Drawing.Point(218, 24);
            this.btnFrameStep.Name = "btnFrameStep";
            this.btnFrameStep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFrameStep.Size = new System.Drawing.Size(46, 35);
            this.btnFrameStep.TabIndex = 33;
            this.btnFrameStep.UseVisualStyleBackColor = false;
            this.btnFrameStep.Click += new System.EventHandler(this.btnFrameStep_Click);
            // 
            // btnFastFwd
            // 
            this.btnFastFwd.BackColor = System.Drawing.SystemColors.Control;
            this.btnFastFwd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFastFwd.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFastFwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFastFwd.ImageIndex = 0;
            this.btnFastFwd.ImageList = this.ImageList1;
            this.btnFastFwd.Location = new System.Drawing.Point(324, 23);
            this.btnFastFwd.Name = "btnFastFwd";
            this.btnFastFwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFastFwd.Size = new System.Drawing.Size(46, 34);
            this.btnFastFwd.TabIndex = 32;
            this.btnFastFwd.UseVisualStyleBackColor = false;
            this.btnFastFwd.Click += new System.EventHandler(this.btnFastFwd_Click);
            // 
            // btnFastRew
            // 
            this.btnFastRew.BackColor = System.Drawing.SystemColors.Control;
            this.btnFastRew.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFastRew.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFastRew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFastRew.ImageIndex = 1;
            this.btnFastRew.ImageList = this.ImageList1;
            this.btnFastRew.Location = new System.Drawing.Point(272, 24);
            this.btnFastRew.Name = "btnFastRew";
            this.btnFastRew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFastRew.Size = new System.Drawing.Size(44, 35);
            this.btnFastRew.TabIndex = 31;
            this.btnFastRew.UseVisualStyleBackColor = false;
            this.btnFastRew.Click += new System.EventHandler(this.btnFastRew_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlay.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.ImageIndex = 2;
            this.btnPlay.ImageList = this.ImageList1;
            this.btnPlay.Location = new System.Drawing.Point(166, 24);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlay.Size = new System.Drawing.Size(44, 35);
            this.btnPlay.TabIndex = 30;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPause.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPause.ImageIndex = 4;
            this.btnPause.ImageList = this.ImageList1;
            this.btnPause.Location = new System.Drawing.Point(112, 24);
            this.btnPause.Name = "btnPause";
            this.btnPause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPause.Size = new System.Drawing.Size(44, 35);
            this.btnPause.TabIndex = 28;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlayBackwards
            // 
            this.btnPlayBackwards.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlayBackwards.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayBackwards.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayBackwards.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlayBackwards.ImageIndex = 5;
            this.btnPlayBackwards.ImageList = this.ImageList1;
            this.btnPlayBackwards.Location = new System.Drawing.Point(8, 24);
            this.btnPlayBackwards.Name = "btnPlayBackwards";
            this.btnPlayBackwards.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlayBackwards.Size = new System.Drawing.Size(46, 35);
            this.btnPlayBackwards.TabIndex = 27;
            this.btnPlayBackwards.UseVisualStyleBackColor = false;
            this.btnPlayBackwards.Click += new System.EventHandler(this.btnPlayBackwards_Click);
            // 
            // tbrPlayer
            // 
            this.tbrPlayer.AutoSize = false;
            this.tbrPlayer.Location = new System.Drawing.Point(378, 23);
            this.tbrPlayer.Name = "tbrPlayer";
            this.tbrPlayer.Size = new System.Drawing.Size(911, 34);
            this.tbrPlayer.TabIndex = 20;
            this.tbrPlayer.Scroll += new System.EventHandler(this.tbrPlayer_Scroll);
            this.tbrPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbrPlayer_KeyDown);
            this.tbrPlayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbrPlayer_KeyUp);
            this.tbrPlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbrPlayer_MouseDown);
            this.tbrPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbrPlayer_MouseUp);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.ImageIndex = 3;
            this.btnStop.ImageList = this.ImageList1;
            this.btnStop.Location = new System.Drawing.Point(61, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStop.Size = new System.Drawing.Size(44, 35);
            this.btnStop.TabIndex = 29;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Silver;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            this.ImageList1.Images.SetKeyName(3, "");
            this.ImageList1.Images.SetKeyName(4, "");
            this.ImageList1.Images.SetKeyName(5, "");
            this.ImageList1.Images.SetKeyName(6, "");
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(8, 441);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(91, 16);
            this.Label1.TabIndex = 61;
            this.Label1.Text = "storage path:";
            // 
            // chkPlayerTrackBarSynchrone
            // 
            this.chkPlayerTrackBarSynchrone.Location = new System.Drawing.Point(1115, 456);
            this.chkPlayerTrackBarSynchrone.Name = "chkPlayerTrackBarSynchrone";
            this.chkPlayerTrackBarSynchrone.Size = new System.Drawing.Size(238, 27);
            this.chkPlayerTrackBarSynchrone.TabIndex = 62;
            this.chkPlayerTrackBarSynchrone.Text = "player trackbar synchrone";
            this.chkPlayerTrackBarSynchrone.CheckedChanged += new System.EventHandler(this.chkPlayerTrackBarSynchrone_CheckedChanged);
            // 
            // tbrZoom
            // 
            this.tbrZoom.AutoSize = false;
            this.tbrZoom.Location = new System.Drawing.Point(356, 441);
            this.tbrZoom.Maximum = 20000;
            this.tbrZoom.Minimum = 1000;
            this.tbrZoom.Name = "tbrZoom";
            this.tbrZoom.Size = new System.Drawing.Size(751, 32);
            this.tbrZoom.TabIndex = 63;
            this.tbrZoom.Value = 1000;
            this.tbrZoom.Scroll += new System.EventHandler(this.tbrZoom_Scroll);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(308, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 42);
            this.label2.TabIndex = 64;
            this.label2.Text = "ZOOM:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbrZoomX
            // 
            this.tbrZoomX.AutoSize = false;
            this.tbrZoomX.Location = new System.Drawing.Point(440, 488);
            this.tbrZoomX.Maximum = 20000;
            this.tbrZoomX.Minimum = 1000;
            this.tbrZoomX.Name = "tbrZoomX";
            this.tbrZoomX.Size = new System.Drawing.Size(676, 31);
            this.tbrZoomX.TabIndex = 65;
            this.tbrZoomX.Value = 1000;
            this.tbrZoomX.Scroll += new System.EventHandler(this.tbrZoomX_Scroll);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(310, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 42);
            this.label3.TabIndex = 66;
            this.label3.Text = "zoom center X:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Y:";
            // 
            // tbpReencoding
            // 
            this.tbpReencoding.Location = new System.Drawing.Point(4, 25);
            this.tbpReencoding.Name = "tbpReencoding";
            this.tbpReencoding.Size = new System.Drawing.Size(1623, 334);
            this.tbpReencoding.TabIndex = 11;
            this.tbpReencoding.Text = "reencoding";
            // 
            // tbpDisplay
            // 
            this.tbpDisplay.Location = new System.Drawing.Point(4, 25);
            this.tbpDisplay.Name = "tbpDisplay";
            this.tbpDisplay.Size = new System.Drawing.Size(1623, 334);
            this.tbpDisplay.TabIndex = 10;
            this.tbpDisplay.Text = "display";
            // 
            // tbpVideoProcessing
            // 
            this.tbpVideoProcessing.Location = new System.Drawing.Point(4, 25);
            this.tbpVideoProcessing.Name = "tbpVideoProcessing";
            this.tbpVideoProcessing.Size = new System.Drawing.Size(1623, 334);
            this.tbpVideoProcessing.TabIndex = 9;
            this.tbpVideoProcessing.Text = "video processing";
            // 
            // tbpOverlays
            // 
            this.tbpOverlays.Location = new System.Drawing.Point(4, 25);
            this.tbpOverlays.Name = "tbpOverlays";
            this.tbpOverlays.Size = new System.Drawing.Size(1623, 334);
            this.tbpOverlays.TabIndex = 8;
            this.tbpOverlays.Text = "overlays";
            // 
            // tbpMotionDetection
            // 
            this.tbpMotionDetection.Location = new System.Drawing.Point(4, 25);
            this.tbpMotionDetection.Name = "tbpMotionDetection";
            this.tbpMotionDetection.Size = new System.Drawing.Size(1623, 334);
            this.tbpMotionDetection.TabIndex = 7;
            this.tbpMotionDetection.Text = "motion detection";
            // 
            // tbpFrameGrabber
            // 
            this.tbpFrameGrabber.Location = new System.Drawing.Point(4, 25);
            this.tbpFrameGrabber.Name = "tbpFrameGrabber";
            this.tbpFrameGrabber.Size = new System.Drawing.Size(1623, 334);
            this.tbpFrameGrabber.TabIndex = 6;
            this.tbpFrameGrabber.Text = "frame grabber";
            // 
            // tbpPlayer
            // 
            this.tbpPlayer.Location = new System.Drawing.Point(4, 25);
            this.tbpPlayer.Name = "tbpPlayer";
            this.tbpPlayer.Size = new System.Drawing.Size(1623, 334);
            this.tbpPlayer.TabIndex = 5;
            this.tbpPlayer.Text = "player";
            // 
            // tbpNetworkStreaming
            // 
            this.tbpNetworkStreaming.Location = new System.Drawing.Point(4, 25);
            this.tbpNetworkStreaming.Name = "tbpNetworkStreaming";
            this.tbpNetworkStreaming.Size = new System.Drawing.Size(1623, 334);
            this.tbpNetworkStreaming.TabIndex = 4;
            this.tbpNetworkStreaming.Text = "streaming";
            // 
            // tbpMultipurposeEncoder
            // 
            this.tbpMultipurposeEncoder.Location = new System.Drawing.Point(4, 25);
            this.tbpMultipurposeEncoder.Name = "tbpMultipurposeEncoder";
            this.tbpMultipurposeEncoder.Size = new System.Drawing.Size(1623, 334);
            this.tbpMultipurposeEncoder.TabIndex = 13;
            this.tbpMultipurposeEncoder.Text = "Multipurpose Encoder";
            // 
            // tbpRecording
            // 
            this.tbpRecording.Location = new System.Drawing.Point(4, 25);
            this.tbpRecording.Name = "tbpRecording";
            this.tbpRecording.Size = new System.Drawing.Size(1623, 334);
            this.tbpRecording.TabIndex = 3;
            this.tbpRecording.Text = "recording";
            // 
            // tbpAudio
            // 
            this.tbpAudio.Location = new System.Drawing.Point(4, 25);
            this.tbpAudio.Name = "tbpAudio";
            this.tbpAudio.Size = new System.Drawing.Size(1623, 334);
            this.tbpAudio.TabIndex = 2;
            this.tbpAudio.Text = "audio";
            // 
            // tbpIPCameras
            // 
            this.tbpIPCameras.Location = new System.Drawing.Point(4, 25);
            this.tbpIPCameras.Name = "tbpIPCameras";
            this.tbpIPCameras.Size = new System.Drawing.Size(1623, 334);
            this.tbpIPCameras.TabIndex = 1;
            this.tbpIPCameras.Text = "IP cameras";
            // 
            // tbpVideoSource
            // 
            this.tbpVideoSource.Location = new System.Drawing.Point(4, 25);
            this.tbpVideoSource.Name = "tbpVideoSource";
            this.tbpVideoSource.Size = new System.Drawing.Size(1453, 334);
            this.tbpVideoSource.TabIndex = 0;
            this.tbpVideoSource.Text = "video source";
            // 
            // tbcTabs
            // 
            this.tbcTabs.Controls.Add(this.tbpVideoSource);
            this.tbcTabs.Controls.Add(this.tbpIPCameras);
            this.tbcTabs.Controls.Add(this.tbpAudio);
            this.tbcTabs.Controls.Add(this.tbpRecording);
            this.tbcTabs.Controls.Add(this.tbpMultipurposeEncoder);
            this.tbcTabs.Controls.Add(this.tbpNetworkStreaming);
            this.tbcTabs.Controls.Add(this.tbpPlayer);
            this.tbcTabs.Controls.Add(this.tbpFrameGrabber);
            this.tbcTabs.Controls.Add(this.tbpMotionDetection);
            this.tbcTabs.Controls.Add(this.tbpOverlays);
            this.tbcTabs.Controls.Add(this.tbpVideoProcessing);
            this.tbcTabs.Controls.Add(this.tbpDisplay);
            this.tbcTabs.Controls.Add(this.tbpReencoding);
            this.tbcTabs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbcTabs.Location = new System.Drawing.Point(8, 0);
            this.tbcTabs.Name = "tbcTabs";
            this.tbcTabs.Padding = new System.Drawing.Point(5, 3);
            this.tbcTabs.SelectedIndex = 0;
            this.tbcTabs.Size = new System.Drawing.Size(1461, 363);
            this.tbcTabs.TabIndex = 59;
            this.tbcTabs.SelectedIndexChanged += new System.EventHandler(this.tbcTabs_SelectedIndexChanged);
            // 
            // tbrZoomY
            // 
            this.tbrZoomY.AutoSize = false;
            this.tbrZoomY.Location = new System.Drawing.Point(309, 537);
            this.tbrZoomY.Maximum = 20000;
            this.tbrZoomY.Minimum = 1000;
            this.tbrZoomY.Name = "tbrZoomY";
            this.tbrZoomY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrZoomY.Size = new System.Drawing.Size(26, 542);
            this.tbrZoomY.TabIndex = 68;
            this.tbrZoomY.Value = 1000;
            this.tbrZoomY.Scroll += new System.EventHandler(this.tbrZoomY_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 971);
            this.Controls.Add(this.tbrZoomY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbrZoomX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbrZoom);
            this.Controls.Add(this.chkPlayerTrackBarSynchrone);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.gbPlayerControl);
            this.Controls.Add(this.tbcTabs);
            this.Controls.Add(this.mmoLog);
            this.Controls.Add(this.edtDVDateTime);
            this.Controls.Add(this.edtFrameCount);
            this.Controls.Add(this.edtStoragePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datastead Software - TVideoGrabber demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbPlayerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomX)).EndInit();
            this.tbcTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public VidGrab.VideoGrabber VideoGrabber1;
        public System.Windows.Forms.TextBox mmoLog;
        public System.Windows.Forms.TextBox edtDVDateTime;
        public System.Windows.Forms.TextBox edtFrameCount;
        public System.Windows.Forms.TextBox edtStoragePath;
        internal System.Windows.Forms.GroupBox gbPlayerControl;
        public System.Windows.Forms.Button btnFrameStep;
        internal System.Windows.Forms.ImageList ImageList1;
        public System.Windows.Forms.Button btnFastFwd;
        public System.Windows.Forms.Button btnFastRew;
        public System.Windows.Forms.Button btnPlay;
        public System.Windows.Forms.Button btnPause;
        public System.Windows.Forms.Button btnPlayBackwards;
        internal System.Windows.Forms.TrackBar tbrPlayer;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox chkPlayerTrackBarSynchrone;
        internal System.Windows.Forms.TrackBar tbrZoom;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TrackBar tbrZoomX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TabPage tbpReencoding;
        internal System.Windows.Forms.TabPage tbpDisplay;
        internal System.Windows.Forms.TabPage tbpVideoProcessing;
        internal System.Windows.Forms.TabPage tbpOverlays;
        internal System.Windows.Forms.TabPage tbpMotionDetection;
        internal System.Windows.Forms.TabPage tbpFrameGrabber;
        internal System.Windows.Forms.TabPage tbpPlayer;
        internal System.Windows.Forms.TabPage tbpNetworkStreaming;
        internal System.Windows.Forms.TabPage tbpMultipurposeEncoder;
        internal System.Windows.Forms.TabPage tbpRecording;
        internal System.Windows.Forms.TabPage tbpAudio;
        internal System.Windows.Forms.TabPage tbpIPCameras;
        internal System.Windows.Forms.TabPage tbpVideoSource;
        public System.Windows.Forms.TabControl tbcTabs;
        internal System.Windows.Forms.TrackBar tbrZoomY;
    }
}

