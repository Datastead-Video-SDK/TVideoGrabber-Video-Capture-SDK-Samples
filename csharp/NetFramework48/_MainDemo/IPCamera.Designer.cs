using System.Windows.Forms;

namespace MainDemo
{
    partial class IPCamera : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPCamera));
            this.edtIPCamReceiveTimeout = new System.Windows.Forms.TextBox();
            this.edtIPCamConnectionTimeout = new System.Windows.Forms.TextBox();
            this.edtIPCameraURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIPCamStartPreview = new System.Windows.Forms.Button();
            this.lblFirstSelectIPCamera = new System.Windows.Forms.Label();
            this.chkOpenURLAsync = new System.Windows.Forms.CheckBox();
            this.btnIPCamStop = new System.Windows.Forms.Button();
            this.btnIPCamStartMP4Recording = new System.Windows.Forms.Button();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chkBacktimedRecording = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtIPCamUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtIPCamPassword = new System.Windows.Forms.TextBox();
            this.txtBacktimedRecordingSeconds = new System.Windows.Forms.TextBox();
            this.chkUseExternalAudioforRTSP = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.chkStopOnRelease = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edtPTZDurationMs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnContinousPtzZoomOut = new System.Windows.Forms.Button();
            this.btnContinousPtzZoomIn = new System.Windows.Forms.Button();
            this.btnContinousPtzPanLeft = new System.Windows.Forms.Button();
            this.btnContinousPtzPanRight = new System.Windows.Forms.Button();
            this.btnContinousPtzTiltDown = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnContinousPtzTiltUp = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPTZActualiseTrackbars = new System.Windows.Forms.Button();
            this.tbrAbsolutePTZTilt = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbrAbsolutePTZZoom = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.tbrAbsolutePTZPan = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPTZRelativeMove = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRelativeZoomOut = new System.Windows.Forms.Button();
            this.btnRelativeZoomIn = new System.Windows.Forms.Button();
            this.btnRelativePanLeft = new System.Windows.Forms.Button();
            this.btnRelativePanRight = new System.Windows.Forms.Button();
            this.btnRelativeTiltDown = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRelativeTiltUp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbrPTZSpeedRatio = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.btnContinousPTZStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbIrCutFilterDisabled = new System.Windows.Forms.RadioButton();
            this.rdbIrCutFilterEnabled = new System.Windows.Forms.RadioButton();
            this.rdbIrCutFilterAuto = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIPCamStartAsyncPreviewAndWait = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAbsolutePTZTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAbsolutePTZZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAbsolutePTZPan)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPTZSpeedRatio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtIPCamReceiveTimeout
            // 
            this.edtIPCamReceiveTimeout.Location = new System.Drawing.Point(615, 112);
            this.edtIPCamReceiveTimeout.Name = "edtIPCamReceiveTimeout";
            this.edtIPCamReceiveTimeout.Size = new System.Drawing.Size(80, 22);
            this.edtIPCamReceiveTimeout.TabIndex = 33;
            this.edtIPCamReceiveTimeout.Text = "5000";
            this.edtIPCamReceiveTimeout.TextChanged += new System.EventHandler(this.edtIPCamReceiveTimeout_TextChanged);
            // 
            // edtIPCamConnectionTimeout
            // 
            this.edtIPCamConnectionTimeout.Location = new System.Drawing.Point(484, 112);
            this.edtIPCamConnectionTimeout.Name = "edtIPCamConnectionTimeout";
            this.edtIPCamConnectionTimeout.Size = new System.Drawing.Size(98, 22);
            this.edtIPCamConnectionTimeout.TabIndex = 32;
            this.edtIPCamConnectionTimeout.Text = "10000";
            this.edtIPCamConnectionTimeout.TextChanged += new System.EventHandler(this.edtIPCamConnectionTimeout_TextChanged);
            // 
            // edtIPCameraURL
            // 
            this.edtIPCameraURL.Location = new System.Drawing.Point(73, 44);
            this.edtIPCameraURL.Name = "edtIPCameraURL";
            this.edtIPCameraURL.Size = new System.Drawing.Size(687, 22);
            this.edtIPCameraURL.TabIndex = 31;
            this.edtIPCameraURL.Text = "onvif://...  rtsp://...  http://....  rtmp://...   udp://...   rtp://...   mms://" +
    "...   mmsh://...";
            this.edtIPCameraURL.TextChanged += new System.EventHandler(this.edtIPCameraURL_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(612, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "receive timeout (ms):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(484, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "conn. timeout (ms):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "URL:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnIPCamStartPreview
            // 
            this.btnIPCamStartPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnIPCamStartPreview.Location = new System.Drawing.Point(9, 72);
            this.btnIPCamStartPreview.Name = "btnIPCamStartPreview";
            this.btnIPCamStartPreview.Size = new System.Drawing.Size(111, 25);
            this.btnIPCamStartPreview.TabIndex = 34;
            this.btnIPCamStartPreview.Text = "Start preview";
            this.btnIPCamStartPreview.Click += new System.EventHandler(this.btnIPCamStartPreview_Click);
            // 
            // lblFirstSelectIPCamera
            // 
            this.lblFirstSelectIPCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFirstSelectIPCamera.ForeColor = System.Drawing.Color.Red;
            this.lblFirstSelectIPCamera.Location = new System.Drawing.Point(5, 0);
            this.lblFirstSelectIPCamera.Name = "lblFirstSelectIPCamera";
            this.lblFirstSelectIPCamera.Size = new System.Drawing.Size(654, 16);
            this.lblFirstSelectIPCamera.TabIndex = 29;
            this.lblFirstSelectIPCamera.Text = "first select VideoSource = vs_IPCamera in the Video Sources list of the  \"video s" +
    "ource\" tab";
            // 
            // chkOpenURLAsync
            // 
            this.chkOpenURLAsync.AutoSize = true;
            this.chkOpenURLAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.chkOpenURLAsync.Location = new System.Drawing.Point(8, 19);
            this.chkOpenURLAsync.Name = "chkOpenURLAsync";
            this.chkOpenURLAsync.Size = new System.Drawing.Size(235, 20);
            this.chkOpenURLAsync.TabIndex = 45;
            this.chkOpenURLAsync.Text = "open the URL asynchronously";
            this.chkOpenURLAsync.UseVisualStyleBackColor = true;
            this.chkOpenURLAsync.CheckedChanged += new System.EventHandler(this.chkOpenURLAsync_CheckedChanged);
            // 
            // btnIPCamStop
            // 
            this.btnIPCamStop.Location = new System.Drawing.Point(126, 72);
            this.btnIPCamStop.Name = "btnIPCamStop";
            this.btnIPCamStop.Size = new System.Drawing.Size(66, 25);
            this.btnIPCamStop.TabIndex = 46;
            this.btnIPCamStop.Text = "Stop";
            this.btnIPCamStop.Click += new System.EventHandler(this.btnIPCamStop_Click);
            // 
            // btnIPCamStartMP4Recording
            // 
            this.btnIPCamStartMP4Recording.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnIPCamStartMP4Recording.Location = new System.Drawing.Point(198, 72);
            this.btnIPCamStartMP4Recording.Name = "btnIPCamStartMP4Recording";
            this.btnIPCamStartMP4Recording.Size = new System.Drawing.Size(186, 25);
            this.btnIPCamStartMP4Recording.TabIndex = 47;
            this.btnIPCamStartMP4Recording.Text = "Start MP4 recording";
            this.btnIPCamStartMP4Recording.Click += new System.EventHandler(this.btnIPCamStartMP4Recording_Click);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F);
            this.RichTextBox1.Location = new System.Drawing.Point(12, 140);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(723, 77);
            this.RichTextBox1.TabIndex = 55;
            this.RichTextBox1.Text = resources.GetString("RichTextBox1.Text");
            // 
            // chkBacktimedRecording
            // 
            this.chkBacktimedRecording.AutoSize = true;
            this.chkBacktimedRecording.Location = new System.Drawing.Point(396, 74);
            this.chkBacktimedRecording.Name = "chkBacktimedRecording";
            this.chkBacktimedRecording.Size = new System.Drawing.Size(330, 20);
            this.chkBacktimedRecording.TabIndex = 56;
            this.chkBacktimedRecording.Text = "backtimed recording duration (pre-roll), in seconds:";
            this.chkBacktimedRecording.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(336, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "user:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtIPCamUserName
            // 
            this.edtIPCamUserName.Location = new System.Drawing.Point(338, 112);
            this.edtIPCamUserName.Name = "edtIPCamUserName";
            this.edtIPCamUserName.Size = new System.Drawing.Size(65, 22);
            this.edtIPCamUserName.TabIndex = 57;
            this.edtIPCamUserName.TextChanged += new System.EventHandler(this.edtIPCamUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(406, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 60;
            this.label2.Text = "password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtIPCamPassword
            // 
            this.edtIPCamPassword.Location = new System.Drawing.Point(409, 112);
            this.edtIPCamPassword.Name = "edtIPCamPassword";
            this.edtIPCamPassword.Size = new System.Drawing.Size(69, 22);
            this.edtIPCamPassword.TabIndex = 59;
            this.edtIPCamPassword.TextChanged += new System.EventHandler(this.edtIPCamPassword_TextChanged);
            // 
            // txtBacktimedRecordingSeconds
            // 
            this.txtBacktimedRecordingSeconds.Location = new System.Drawing.Point(743, 72);
            this.txtBacktimedRecordingSeconds.Name = "txtBacktimedRecordingSeconds";
            this.txtBacktimedRecordingSeconds.Size = new System.Drawing.Size(31, 22);
            this.txtBacktimedRecordingSeconds.TabIndex = 61;
            // 
            // chkUseExternalAudioforRTSP
            // 
            this.chkUseExternalAudioforRTSP.AutoSize = true;
            this.chkUseExternalAudioforRTSP.Location = new System.Drawing.Point(255, 18);
            this.chkUseExternalAudioforRTSP.Name = "chkUseExternalAudioforRTSP";
            this.chkUseExternalAudioforRTSP.Size = new System.Drawing.Size(307, 20);
            this.chkUseExternalAudioforRTSP.TabIndex = 94;
            this.chkUseExternalAudioforRTSP.Text = "use the selected audio device as audio source";
            this.chkUseExternalAudioforRTSP.UseVisualStyleBackColor = true;
            this.chkUseExternalAudioforRTSP.CheckedChanged += new System.EventHandler(this.chkUseExternalAudioforRTSP_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.tbrPTZSpeedRatio);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.btnContinousPTZStop);
            this.groupBox4.Location = new System.Drawing.Point(780, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 174);
            this.groupBox4.TabIndex = 95;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PTZ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(45, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(235, 159);
            this.tabControl1.TabIndex = 93;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.chkStopOnRelease);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.edtPTZDurationMs);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnContinousPtzZoomOut);
            this.tabPage1.Controls.Add(this.btnContinousPtzZoomIn);
            this.tabPage1.Controls.Add(this.btnContinousPtzPanLeft);
            this.tabPage1.Controls.Add(this.btnContinousPtzPanRight);
            this.tabPage1.Controls.Add(this.btnContinousPtzTiltDown);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnContinousPtzTiltUp);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(227, 130);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Continuous";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(23, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "(0 = continuous move)";
            // 
            // chkStopOnRelease
            // 
            this.chkStopOnRelease.AutoSize = true;
            this.chkStopOnRelease.Checked = true;
            this.chkStopOnRelease.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStopOnRelease.Location = new System.Drawing.Point(15, 97);
            this.chkStopOnRelease.Name = "chkStopOnRelease";
            this.chkStopOnRelease.Size = new System.Drawing.Size(127, 20);
            this.chkStopOnRelease.TabIndex = 27;
            this.chkStopOnRelease.Text = "mouse up = stop";
            this.chkStopOnRelease.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtPTZDurationMs
            // 
            this.edtPTZDurationMs.Location = new System.Drawing.Point(117, 53);
            this.edtPTZDurationMs.Name = "edtPTZDurationMs";
            this.edtPTZDurationMs.Size = new System.Drawing.Size(39, 22);
            this.edtPTZDurationMs.TabIndex = 24;
            this.edtPTZDurationMs.Text = "0";
            this.edtPTZDurationMs.TextChanged += new System.EventHandler(this.edtPTZDurationMs_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "duration(ms):";
            // 
            // btnContinousPtzZoomOut
            // 
            this.btnContinousPtzZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnContinousPtzZoomOut.Location = new System.Drawing.Point(159, 27);
            this.btnContinousPtzZoomOut.Name = "btnContinousPtzZoomOut";
            this.btnContinousPtzZoomOut.Size = new System.Drawing.Size(22, 22);
            this.btnContinousPtzZoomOut.TabIndex = 22;
            this.btnContinousPtzZoomOut.Text = "<";
            this.btnContinousPtzZoomOut.UseVisualStyleBackColor = true;
            this.btnContinousPtzZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContinuousPtzZoomOut_MouseDown);
            this.btnContinousPtzZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContinuousPTZButtons_MouseUp);
            // 
            // btnContinousPtzZoomIn
            // 
            this.btnContinousPtzZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnContinousPtzZoomIn.Location = new System.Drawing.Point(180, 27);
            this.btnContinousPtzZoomIn.Name = "btnContinousPtzZoomIn";
            this.btnContinousPtzZoomIn.Size = new System.Drawing.Size(22, 22);
            this.btnContinousPtzZoomIn.TabIndex = 21;
            this.btnContinousPtzZoomIn.Text = ">";
            this.btnContinousPtzZoomIn.UseVisualStyleBackColor = true;
            this.btnContinousPtzZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContinuousPtzZoomIn_MouseDown);
            this.btnContinousPtzZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContinuousPTZButtons_MouseUp);
            // 
            // btnContinousPtzPanLeft
            // 
            this.btnContinousPtzPanLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnContinousPtzPanLeft.Location = new System.Drawing.Point(67, 15);
            this.btnContinousPtzPanLeft.Name = "btnContinousPtzPanLeft";
            this.btnContinousPtzPanLeft.Size = new System.Drawing.Size(22, 22);
            this.btnContinousPtzPanLeft.TabIndex = 20;
            this.btnContinousPtzPanLeft.Text = "<";
            this.btnContinousPtzPanLeft.UseVisualStyleBackColor = true;
            this.btnContinousPtzPanLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContinuousPtzPanLeft_MouseDown);
            this.btnContinousPtzPanLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContinuousPTZButtons_MouseUp);
            // 
            // btnContinousPtzPanRight
            // 
            this.btnContinousPtzPanRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnContinousPtzPanRight.Location = new System.Drawing.Point(110, 15);
            this.btnContinousPtzPanRight.Name = "btnContinousPtzPanRight";
            this.btnContinousPtzPanRight.Size = new System.Drawing.Size(22, 22);
            this.btnContinousPtzPanRight.TabIndex = 19;
            this.btnContinousPtzPanRight.Text = ">";
            this.btnContinousPtzPanRight.UseVisualStyleBackColor = true;
            this.btnContinousPtzPanRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContinuousPtzPanRight_MouseDown);
            this.btnContinousPtzPanRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContinuousPTZButtons_MouseUp);
            // 
            // btnContinousPtzTiltDown
            // 
            this.btnContinousPtzTiltDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnContinousPtzTiltDown.Location = new System.Drawing.Point(88, 27);
            this.btnContinousPtzTiltDown.Name = "btnContinousPtzTiltDown";
            this.btnContinousPtzTiltDown.Size = new System.Drawing.Size(22, 22);
            this.btnContinousPtzTiltDown.TabIndex = 18;
            this.btnContinousPtzTiltDown.Text = "v";
            this.btnContinousPtzTiltDown.UseVisualStyleBackColor = true;
            this.btnContinousPtzTiltDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContinuousPtzTiltDown_MouseDown);
            this.btnContinousPtzTiltDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContinuousPTZButtons_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Zoom:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pan/Tilt:";
            // 
            // btnContinousPtzTiltUp
            // 
            this.btnContinousPtzTiltUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnContinousPtzTiltUp.Location = new System.Drawing.Point(88, 4);
            this.btnContinousPtzTiltUp.Name = "btnContinousPtzTiltUp";
            this.btnContinousPtzTiltUp.Size = new System.Drawing.Size(22, 22);
            this.btnContinousPtzTiltUp.TabIndex = 14;
            this.btnContinousPtzTiltUp.Text = "^";
            this.btnContinousPtzTiltUp.UseVisualStyleBackColor = true;
            this.btnContinousPtzTiltUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContinuousPtzTiltUp_MouseDown);
            this.btnContinousPtzTiltUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContinuousPTZButtons_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnPTZActualiseTrackbars);
            this.tabPage2.Controls.Add(this.tbrAbsolutePTZTilt);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbrAbsolutePTZZoom);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbrAbsolutePTZPan);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(227, 130);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Absolute";
            // 
            // btnPTZActualiseTrackbars
            // 
            this.btnPTZActualiseTrackbars.Location = new System.Drawing.Point(8, 15);
            this.btnPTZActualiseTrackbars.Name = "btnPTZActualiseTrackbars";
            this.btnPTZActualiseTrackbars.Size = new System.Drawing.Size(144, 26);
            this.btnPTZActualiseTrackbars.TabIndex = 53;
            this.btnPTZActualiseTrackbars.Text = "actualise trackbars";
            this.btnPTZActualiseTrackbars.UseVisualStyleBackColor = true;
            this.btnPTZActualiseTrackbars.Click += new System.EventHandler(this.btnPTZActualiseTrackbars_Click);
            // 
            // tbrAbsolutePTZTilt
            // 
            this.tbrAbsolutePTZTilt.AutoSize = false;
            this.tbrAbsolutePTZTilt.Location = new System.Drawing.Point(162, 6);
            this.tbrAbsolutePTZTilt.Maximum = 100;
            this.tbrAbsolutePTZTilt.Minimum = -100;
            this.tbrAbsolutePTZTilt.Name = "tbrAbsolutePTZTilt";
            this.tbrAbsolutePTZTilt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrAbsolutePTZTilt.Size = new System.Drawing.Size(23, 98);
            this.tbrAbsolutePTZTilt.TabIndex = 52;
            this.tbrAbsolutePTZTilt.TickFrequency = 26;
            this.tbrAbsolutePTZTilt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbrAbsolutePTZ_MouseUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "tilt:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "zoom:";
            // 
            // tbrAbsolutePTZZoom
            // 
            this.tbrAbsolutePTZZoom.AutoSize = false;
            this.tbrAbsolutePTZZoom.Location = new System.Drawing.Point(64, 100);
            this.tbrAbsolutePTZZoom.Maximum = 50;
            this.tbrAbsolutePTZZoom.Name = "tbrAbsolutePTZZoom";
            this.tbrAbsolutePTZZoom.Size = new System.Drawing.Size(157, 25);
            this.tbrAbsolutePTZZoom.TabIndex = 49;
            this.tbrAbsolutePTZZoom.TickFrequency = 26;
            this.tbrAbsolutePTZZoom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbrAbsolutePTZ_MouseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "pan:";
            // 
            // tbrAbsolutePTZPan
            // 
            this.tbrAbsolutePTZPan.AutoSize = false;
            this.tbrAbsolutePTZPan.Location = new System.Drawing.Point(9, 63);
            this.tbrAbsolutePTZPan.Maximum = 100;
            this.tbrAbsolutePTZPan.Minimum = -100;
            this.tbrAbsolutePTZPan.Name = "tbrAbsolutePTZPan";
            this.tbrAbsolutePTZPan.Size = new System.Drawing.Size(140, 23);
            this.tbrAbsolutePTZPan.TabIndex = 47;
            this.tbrAbsolutePTZPan.TickFrequency = 26;
            this.tbrAbsolutePTZPan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbrAbsolutePTZ_MouseUp);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.txtPTZRelativeMove);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.btnRelativeZoomOut);
            this.tabPage3.Controls.Add(this.btnRelativeZoomIn);
            this.tabPage3.Controls.Add(this.btnRelativePanLeft);
            this.tabPage3.Controls.Add(this.btnRelativePanRight);
            this.tabPage3.Controls.Add(this.btnRelativeTiltDown);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.btnRelativeTiltUp);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(227, 130);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Relative";
            // 
            // txtPTZRelativeMove
            // 
            this.txtPTZRelativeMove.Location = new System.Drawing.Point(126, 6);
            this.txtPTZRelativeMove.Name = "txtPTZRelativeMove";
            this.txtPTZRelativeMove.Size = new System.Drawing.Size(39, 22);
            this.txtPTZRelativeMove.TabIndex = 32;
            this.txtPTZRelativeMove.Text = "0,01";
            this.txtPTZRelativeMove.TextChanged += new System.EventHandler(this.txtPTZRelativeMove_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "relative move:";
            // 
            // btnRelativeZoomOut
            // 
            this.btnRelativeZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnRelativeZoomOut.Location = new System.Drawing.Point(165, 57);
            this.btnRelativeZoomOut.Name = "btnRelativeZoomOut";
            this.btnRelativeZoomOut.Size = new System.Drawing.Size(22, 22);
            this.btnRelativeZoomOut.TabIndex = 30;
            this.btnRelativeZoomOut.Text = "<";
            this.btnRelativeZoomOut.UseVisualStyleBackColor = true;
            this.btnRelativeZoomOut.Click += new System.EventHandler(this.btnRelativePTZZoomOut_Click);
            // 
            // btnRelativeZoomIn
            // 
            this.btnRelativeZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnRelativeZoomIn.Location = new System.Drawing.Point(186, 57);
            this.btnRelativeZoomIn.Name = "btnRelativeZoomIn";
            this.btnRelativeZoomIn.Size = new System.Drawing.Size(22, 22);
            this.btnRelativeZoomIn.TabIndex = 29;
            this.btnRelativeZoomIn.Text = ">";
            this.btnRelativeZoomIn.UseVisualStyleBackColor = true;
            this.btnRelativeZoomIn.Click += new System.EventHandler(this.btnRelativePTZZoomIn_Click);
            // 
            // btnRelativePanLeft
            // 
            this.btnRelativePanLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnRelativePanLeft.Location = new System.Drawing.Point(72, 51);
            this.btnRelativePanLeft.Name = "btnRelativePanLeft";
            this.btnRelativePanLeft.Size = new System.Drawing.Size(22, 22);
            this.btnRelativePanLeft.TabIndex = 28;
            this.btnRelativePanLeft.Text = "<";
            this.btnRelativePanLeft.UseVisualStyleBackColor = true;
            this.btnRelativePanLeft.Click += new System.EventHandler(this.btnRelativePTZPanLeft_Click);
            // 
            // btnRelativePanRight
            // 
            this.btnRelativePanRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnRelativePanRight.Location = new System.Drawing.Point(115, 51);
            this.btnRelativePanRight.Name = "btnRelativePanRight";
            this.btnRelativePanRight.Size = new System.Drawing.Size(22, 22);
            this.btnRelativePanRight.TabIndex = 27;
            this.btnRelativePanRight.Text = ">";
            this.btnRelativePanRight.UseVisualStyleBackColor = true;
            this.btnRelativePanRight.Click += new System.EventHandler(this.btnRelativePTZPanRight_Click);
            // 
            // btnRelativeTiltDown
            // 
            this.btnRelativeTiltDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnRelativeTiltDown.Location = new System.Drawing.Point(93, 63);
            this.btnRelativeTiltDown.Name = "btnRelativeTiltDown";
            this.btnRelativeTiltDown.Size = new System.Drawing.Size(22, 22);
            this.btnRelativeTiltDown.TabIndex = 26;
            this.btnRelativeTiltDown.Text = "v";
            this.btnRelativeTiltDown.UseVisualStyleBackColor = true;
            this.btnRelativeTiltDown.Click += new System.EventHandler(this.btnRelativePTZTiltDown_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(162, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Zoom:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "Pan/Tilt:";
            // 
            // btnRelativeTiltUp
            // 
            this.btnRelativeTiltUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnRelativeTiltUp.Location = new System.Drawing.Point(93, 40);
            this.btnRelativeTiltUp.Name = "btnRelativeTiltUp";
            this.btnRelativeTiltUp.Size = new System.Drawing.Size(22, 22);
            this.btnRelativeTiltUp.TabIndex = 23;
            this.btnRelativeTiltUp.Text = "^";
            this.btnRelativeTiltUp.UseVisualStyleBackColor = true;
            this.btnRelativeTiltUp.Click += new System.EventHandler(this.btnRelativePTZTiltUp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 89;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbrPTZSpeedRatio
            // 
            this.tbrPTZSpeedRatio.AutoSize = false;
            this.tbrPTZSpeedRatio.Location = new System.Drawing.Point(296, 63);
            this.tbrPTZSpeedRatio.Maximum = 100;
            this.tbrPTZSpeedRatio.Name = "tbrPTZSpeedRatio";
            this.tbrPTZSpeedRatio.Size = new System.Drawing.Size(115, 24);
            this.tbrPTZSpeedRatio.TabIndex = 91;
            this.tbrPTZSpeedRatio.TickFrequency = 26;
            this.tbrPTZSpeedRatio.Value = 100;
            this.tbrPTZSpeedRatio.Scroll += new System.EventHandler(this.tbrPTZSpeedRatio_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(293, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 16);
            this.label14.TabIndex = 90;
            this.label14.Text = "speed:";
            // 
            // btnContinousPTZStop
            // 
            this.btnContinousPTZStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnContinousPTZStop.Location = new System.Drawing.Point(286, 99);
            this.btnContinousPTZStop.Name = "btnContinousPTZStop";
            this.btnContinousPTZStop.Size = new System.Drawing.Size(116, 69);
            this.btnContinousPTZStop.TabIndex = 26;
            this.btnContinousPTZStop.Text = "STOP";
            this.btnContinousPTZStop.UseVisualStyleBackColor = true;
            this.btnContinousPTZStop.Click += new System.EventHandler(this.btnPTZStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbIrCutFilterDisabled);
            this.groupBox1.Controls.Add(this.rdbIrCutFilterEnabled);
            this.groupBox1.Controls.Add(this.rdbIrCutFilterAuto);
            this.groupBox1.Location = new System.Drawing.Point(812, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 40);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IR Cut filter of Axis cameras";
            // 
            // rdbIrCutFilterDisabled
            // 
            this.rdbIrCutFilterDisabled.AutoSize = true;
            this.rdbIrCutFilterDisabled.Location = new System.Drawing.Point(299, 14);
            this.rdbIrCutFilterDisabled.Name = "rdbIrCutFilterDisabled";
            this.rdbIrCutFilterDisabled.Size = new System.Drawing.Size(81, 20);
            this.rdbIrCutFilterDisabled.TabIndex = 2;
            this.rdbIrCutFilterDisabled.TabStop = true;
            this.rdbIrCutFilterDisabled.Text = "disabled";
            this.rdbIrCutFilterDisabled.UseVisualStyleBackColor = true;
            this.rdbIrCutFilterDisabled.CheckedChanged += new System.EventHandler(this.rdbIrCutFilterDisabled_CheckedChanged);
            // 
            // rdbIrCutFilterEnabled
            // 
            this.rdbIrCutFilterEnabled.AutoSize = true;
            this.rdbIrCutFilterEnabled.Location = new System.Drawing.Point(213, 14);
            this.rdbIrCutFilterEnabled.Name = "rdbIrCutFilterEnabled";
            this.rdbIrCutFilterEnabled.Size = new System.Drawing.Size(78, 20);
            this.rdbIrCutFilterEnabled.TabIndex = 1;
            this.rdbIrCutFilterEnabled.TabStop = true;
            this.rdbIrCutFilterEnabled.Text = "enabled";
            this.rdbIrCutFilterEnabled.UseVisualStyleBackColor = true;
            this.rdbIrCutFilterEnabled.CheckedChanged += new System.EventHandler(this.rdbIrCutFilterEnabled_CheckedChanged);
            // 
            // rdbIrCutFilterAuto
            // 
            this.rdbIrCutFilterAuto.AutoSize = true;
            this.rdbIrCutFilterAuto.Location = new System.Drawing.Point(150, 14);
            this.rdbIrCutFilterAuto.Name = "rdbIrCutFilterAuto";
            this.rdbIrCutFilterAuto.Size = new System.Drawing.Size(54, 20);
            this.rdbIrCutFilterAuto.TabIndex = 0;
            this.rdbIrCutFilterAuto.TabStop = true;
            this.rdbIrCutFilterAuto.Text = "auto";
            this.rdbIrCutFilterAuto.UseVisualStyleBackColor = true;
            this.rdbIrCutFilterAuto.CheckedChanged += new System.EventHandler(this.rdbIrCutFilterAuto_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(46, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 16);
            this.label6.TabIndex = 97;
            this.label6.Text = "(other recording settings in the \"Recording\" tab)";
            // 
            // btnIPCamStartAsyncPreviewAndWait
            // 
            this.btnIPCamStartAsyncPreviewAndWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnIPCamStartAsyncPreviewAndWait.Location = new System.Drawing.Point(12, 99);
            this.btnIPCamStartAsyncPreviewAndWait.Name = "btnIPCamStartAsyncPreviewAndWait";
            this.btnIPCamStartAsyncPreviewAndWait.Size = new System.Drawing.Size(211, 25);
            this.btnIPCamStartAsyncPreviewAndWait.TabIndex = 98;
            this.btnIPCamStartAsyncPreviewAndWait.Text = "Start async preview and wait";
            this.btnIPCamStartAsyncPreviewAndWait.Click += new System.EventHandler(this.btnIPCamStartAsyncPreviewAndWait_Click);
            // 
            // IPCamera
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1423, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btnIPCamStartAsyncPreviewAndWait);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chkUseExternalAudioforRTSP);
            this.Controls.Add(this.txtBacktimedRecordingSeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtIPCamPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtIPCamUserName);
            this.Controls.Add(this.chkBacktimedRecording);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.btnIPCamStartMP4Recording);
            this.Controls.Add(this.btnIPCamStop);
            this.Controls.Add(this.chkOpenURLAsync);
            this.Controls.Add(this.edtIPCamReceiveTimeout);
            this.Controls.Add(this.edtIPCamConnectionTimeout);
            this.Controls.Add(this.edtIPCameraURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIPCamStartPreview);
            this.Controls.Add(this.lblFirstSelectIPCamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPCamera";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.IPCamera_VisibleChanged);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAbsolutePTZTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAbsolutePTZZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAbsolutePTZPan)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPTZSpeedRatio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private TextBox edtIPCamReceiveTimeout;
        private TextBox edtIPCamConnectionTimeout;
        private TextBox edtIPCameraURL;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnIPCamStartPreview;
        private Label lblFirstSelectIPCamera;
        private CheckBox chkOpenURLAsync;
        private Button btnIPCamStop;
        private Button btnIPCamStartMP4Recording;
        private RichTextBox RichTextBox1;
        private CheckBox chkBacktimedRecording;
        private Label label1;
        private TextBox edtIPCamUserName;
        private Label label2;
        private TextBox edtIPCamPassword;
        private TextBox txtBacktimedRecordingSeconds;
        private CheckBox chkUseExternalAudioforRTSP;
        private GroupBox groupBox4;
        private Button button2;
        private TrackBar tbrPTZSpeedRatio;
        private Label label14;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label15;
        private CheckBox chkStopOnRelease;
        private Button btnContinousPTZStop;
        private Button button1;
        private TextBox edtPTZDurationMs;
        private Label label10;
        private Button btnContinousPtzZoomOut;
        private Button btnContinousPtzZoomIn;
        private Button btnContinousPtzPanLeft;
        private Button btnContinousPtzPanRight;
        private Button btnContinousPtzTiltDown;
        private Label label7;
        private Label label8;
        private Button btnContinousPtzTiltUp;
        private TabPage tabPage2;
        private Button btnPTZActualiseTrackbars;
        private TrackBar tbrAbsolutePTZTilt;
        private Label label13;
        private Label label12;
        private TrackBar tbrAbsolutePTZZoom;
        private Label label11;
        private TrackBar tbrAbsolutePTZPan;
        private TabPage tabPage3;
        private TextBox txtPTZRelativeMove;
        private Label label18;
        private Button btnRelativeZoomOut;
        private Button btnRelativeZoomIn;
        private Button btnRelativePanLeft;
        private Button btnRelativePanRight;
        private Button btnRelativeTiltDown;
        private Label label16;
        private Label label17;
        private Button btnRelativeTiltUp;
        private GroupBox groupBox1;
        private RadioButton rdbIrCutFilterDisabled;
        private RadioButton rdbIrCutFilterEnabled;
        private RadioButton rdbIrCutFilterAuto;
        private Label label6;
        private Button btnIPCamStartAsyncPreviewAndWait;
    }
}

