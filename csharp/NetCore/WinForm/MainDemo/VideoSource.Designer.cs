using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace MainDemo
{
    /// <summary>
    /// Summary description for VideoSource.
    /// </summary>
    public partial class VideoSource : Form
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Label11 = new System.Windows.Forms.Label();
            this.grbVideoSource = new System.Windows.Forms.GroupBox();
            this.cboVideoSource = new System.Windows.Forms.ComboBox();
            this.grbPreview = new System.Windows.Forms.GroupBox();
            this.btnStartPreview = new System.Windows.Forms.Button();
            this.btnStopPreview = new System.Windows.Forms.Button();
            this.grbFrameRate = new System.Windows.Forms.GroupBox();
            this.btnFrameRateHelp = new System.Windows.Forms.Button();
            this.btnFrameRate = new System.Windows.Forms.Button();
            this.edtFrameRate = new System.Windows.Forms.TextBox();
            this.grbVsVideoCaptureDevice = new System.Windows.Forms.GroupBox();
            this.cboVideoFormats = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboVideoDevices = new System.Windows.Forms.ComboBox();
            this.cboVideoInputs = new System.Windows.Forms.ComboBox();
            this.cboVideoSizes = new System.Windows.Forms.ComboBox();
            this.cboVideoSubtypes = new System.Windows.Forms.ComboBox();
            this.cboAnalogVideoStandard = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.grbVsFileOrUrl = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtSourceFileOrUrlPassword = new System.Windows.Forms.TextBox();
            this.edtSourceFileOrUrlUserName = new System.Windows.Forms.TextBox();
            this.btnSelectFileOrUrl = new System.Windows.Forms.Button();
            this.edtVideoSourceFileOrUrl = new System.Windows.Forms.TextBox();
            this.grbVsScreenRecording = new System.Windows.Forms.GroupBox();
            this.btnScreenRecordingWindow = new System.Windows.Forms.Button();
            this.btnMonitorNumberInfo = new System.Windows.Forms.Button();
            this.edtMonitorNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.edtScreenRecordingWindow = new System.Windows.Forms.TextBox();
            this.chkScreenRecordingWithCursor = new System.Windows.Forms.CheckBox();
            this.chkScreenRecordingWindow = new System.Windows.Forms.CheckBox();
            this.lblEnumerateWindows = new System.Windows.Forms.Label();
            this.grbPreferredVideoSizes = new System.Windows.Forms.GroupBox();
            this.rdgPreferredVideoSize1 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize2 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize3 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize4 = new System.Windows.Forms.RadioButton();
            this.chkStretchPreferredVideoSize = new System.Windows.Forms.CheckBox();
            this.grbVideoDevicesDialogs = new System.Windows.Forms.GroupBox();
            this.btnDeviceDialog = new System.Windows.Forms.Button();
            this.btnCameraControlDialog = new System.Windows.Forms.Button();
            this.btnVideoQualityDialog = new System.Windows.Forms.Button();
            this.btnAutoRefreshPreview = new System.Windows.Forms.CheckBox();
            this.grbVideoSource.SuspendLayout();
            this.grbPreview.SuspendLayout();
            this.grbFrameRate.SuspendLayout();
            this.grbVsVideoCaptureDevice.SuspendLayout();
            this.grbVsFileOrUrl.SuspendLayout();
            this.grbVsScreenRecording.SuspendLayout();
            this.grbPreferredVideoSizes.SuspendLayout();
            this.grbVideoDevicesDialogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.SystemColors.Control;
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label11.Location = new System.Drawing.Point(604, 0);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(446, 16);
            this.Label11.TabIndex = 57;
            this.Label11.Text = "use FindIndexInListByName to programmatically select an item in a list";
            // 
            // grbVideoSource
            // 
            this.grbVideoSource.BackColor = System.Drawing.SystemColors.Control;
            this.grbVideoSource.Controls.Add(this.cboVideoSource);
            this.grbVideoSource.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbVideoSource.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVideoSource.Location = new System.Drawing.Point(6, 0);
            this.grbVideoSource.Name = "grbVideoSource";
            this.grbVideoSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVideoSource.Size = new System.Drawing.Size(225, 71);
            this.grbVideoSource.TabIndex = 56;
            this.grbVideoSource.TabStop = false;
            this.grbVideoSource.Text = "VIDEO SOURCE";
            // 
            // cboVideoSource
            // 
            this.cboVideoSource.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoSource.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoSource.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboVideoSource.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoSource.Location = new System.Drawing.Point(12, 28);
            this.cboVideoSource.Name = "cboVideoSource";
            this.cboVideoSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoSource.Size = new System.Drawing.Size(205, 24);
            this.cboVideoSource.TabIndex = 45;
            this.cboVideoSource.SelectedIndexChanged += new System.EventHandler(this.cboVideoSource_SelectedIndexChanged);
            // 
            // grbPreview
            // 
            this.grbPreview.BackColor = System.Drawing.SystemColors.Control;
            this.grbPreview.Controls.Add(this.btnStartPreview);
            this.grbPreview.Controls.Add(this.btnStopPreview);
            this.grbPreview.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbPreview.Location = new System.Drawing.Point(239, 0);
            this.grbPreview.Name = "grbPreview";
            this.grbPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbPreview.Size = new System.Drawing.Size(193, 71);
            this.grbPreview.TabIndex = 55;
            this.grbPreview.TabStop = false;
            this.grbPreview.Text = "Preview";
            // 
            // btnStartPreview
            // 
            this.btnStartPreview.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartPreview.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartPreview.ForeColor = System.Drawing.Color.Red;
            this.btnStartPreview.Location = new System.Drawing.Point(12, 23);
            this.btnStartPreview.Name = "btnStartPreview";
            this.btnStartPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartPreview.Size = new System.Drawing.Size(79, 37);
            this.btnStartPreview.TabIndex = 43;
            this.btnStartPreview.Text = "Start";
            this.btnStartPreview.UseVisualStyleBackColor = false;
            this.btnStartPreview.Click += new System.EventHandler(this.btnStartPreview_Click);
            // 
            // btnStopPreview
            // 
            this.btnStopPreview.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStopPreview.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStopPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopPreview.Location = new System.Drawing.Point(100, 23);
            this.btnStopPreview.Name = "btnStopPreview";
            this.btnStopPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStopPreview.Size = new System.Drawing.Size(81, 37);
            this.btnStopPreview.TabIndex = 42;
            this.btnStopPreview.Text = "Stop";
            this.btnStopPreview.UseVisualStyleBackColor = false;
            this.btnStopPreview.Click += new System.EventHandler(this.btnStopPreview_Click);
            // 
            // grbFrameRate
            // 
            this.grbFrameRate.BackColor = System.Drawing.SystemColors.Control;
            this.grbFrameRate.Controls.Add(this.btnFrameRateHelp);
            this.grbFrameRate.Controls.Add(this.btnFrameRate);
            this.grbFrameRate.Controls.Add(this.edtFrameRate);
            this.grbFrameRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbFrameRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbFrameRate.Location = new System.Drawing.Point(439, 0);
            this.grbFrameRate.Name = "grbFrameRate";
            this.grbFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbFrameRate.Size = new System.Drawing.Size(147, 71);
            this.grbFrameRate.TabIndex = 54;
            this.grbFrameRate.TabStop = false;
            this.grbFrameRate.Text = "Frame rate";
            // 
            // btnFrameRateHelp
            // 
            this.btnFrameRateHelp.Location = new System.Drawing.Point(105, 28);
            this.btnFrameRateHelp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnFrameRateHelp.Name = "btnFrameRateHelp";
            this.btnFrameRateHelp.Size = new System.Drawing.Size(28, 33);
            this.btnFrameRateHelp.TabIndex = 41;
            this.btnFrameRateHelp.Text = "?";
            this.btnFrameRateHelp.Click += new System.EventHandler(this.btnFrameRateHelp_Click);
            // 
            // btnFrameRate
            // 
            this.btnFrameRate.BackColor = System.Drawing.SystemColors.Control;
            this.btnFrameRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFrameRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFrameRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFrameRate.Location = new System.Drawing.Point(63, 28);
            this.btnFrameRate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnFrameRate.Name = "btnFrameRate";
            this.btnFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFrameRate.Size = new System.Drawing.Size(42, 33);
            this.btnFrameRate.TabIndex = 40;
            this.btnFrameRate.Text = "OK";
            this.btnFrameRate.UseVisualStyleBackColor = false;
            this.btnFrameRate.Click += new System.EventHandler(this.btnFrameRate_Click);
            // 
            // edtFrameRate
            // 
            this.edtFrameRate.AcceptsReturn = true;
            this.edtFrameRate.BackColor = System.Drawing.SystemColors.Window;
            this.edtFrameRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFrameRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtFrameRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFrameRate.Location = new System.Drawing.Point(8, 28);
            this.edtFrameRate.MaxLength = 0;
            this.edtFrameRate.Name = "edtFrameRate";
            this.edtFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFrameRate.Size = new System.Drawing.Size(47, 23);
            this.edtFrameRate.TabIndex = 39;
            this.edtFrameRate.Text = "0";
            // 
            // grbVsVideoCaptureDevice
            // 
            this.grbVsVideoCaptureDevice.BackColor = System.Drawing.SystemColors.Control;
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboVideoFormats);
            this.grbVsVideoCaptureDevice.Controls.Add(this.label9);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboVideoDevices);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboVideoInputs);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboVideoSizes);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboVideoSubtypes);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboAnalogVideoStandard);
            this.grbVsVideoCaptureDevice.Controls.Add(this.Label1);
            this.grbVsVideoCaptureDevice.Controls.Add(this.Label2);
            this.grbVsVideoCaptureDevice.Controls.Add(this.Label3);
            this.grbVsVideoCaptureDevice.Controls.Add(this.Label4);
            this.grbVsVideoCaptureDevice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbVsVideoCaptureDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVsVideoCaptureDevice.Location = new System.Drawing.Point(6, 71);
            this.grbVsVideoCaptureDevice.Name = "grbVsVideoCaptureDevice";
            this.grbVsVideoCaptureDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVsVideoCaptureDevice.Size = new System.Drawing.Size(797, 136);
            this.grbVsVideoCaptureDevice.TabIndex = 53;
            this.grbVsVideoCaptureDevice.TabStop = false;
            this.grbVsVideoCaptureDevice.Text = "video source = video capture device";
            this.grbVsVideoCaptureDevice.Enter += new System.EventHandler(this.grbVsVideoCaptureDevice_Enter);
            // 
            // cboVideoFormats
            // 
            this.cboVideoFormats.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoFormats.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoFormats.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboVideoFormats.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoFormats.Location = new System.Drawing.Point(298, 81);
            this.cboVideoFormats.Name = "cboVideoFormats";
            this.cboVideoFormats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoFormats.Size = new System.Drawing.Size(275, 24);
            this.cboVideoFormats.TabIndex = 38;
            this.cboVideoFormats.SelectedIndexChanged += new System.EventHandler(this.cboVideoFormats_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(298, 56);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "video format";
            // 
            // cboVideoDevices
            // 
            this.cboVideoDevices.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoDevices.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoDevices.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboVideoDevices.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoDevices.Location = new System.Drawing.Point(12, 20);
            this.cboVideoDevices.Name = "cboVideoDevices";
            this.cboVideoDevices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoDevices.Size = new System.Drawing.Size(546, 24);
            this.cboVideoDevices.TabIndex = 33;
            this.cboVideoDevices.Text = "SELECT FIRST A VIDEO CAPTURE DEVICE IN THIS LIST";
            this.cboVideoDevices.SelectedIndexChanged += new System.EventHandler(this.cboVideoDevices_SelectedIndexChanged);
            // 
            // cboVideoInputs
            // 
            this.cboVideoInputs.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoInputs.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoInputs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboVideoInputs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoInputs.Location = new System.Drawing.Point(602, 45);
            this.cboVideoInputs.Name = "cboVideoInputs";
            this.cboVideoInputs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoInputs.Size = new System.Drawing.Size(114, 24);
            this.cboVideoInputs.TabIndex = 32;
            this.cboVideoInputs.SelectedIndexChanged += new System.EventHandler(this.cboVideoInputs_SelectedIndexChanged);
            // 
            // cboVideoSizes
            // 
            this.cboVideoSizes.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoSizes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoSizes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboVideoSizes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoSizes.Location = new System.Drawing.Point(12, 81);
            this.cboVideoSizes.Name = "cboVideoSizes";
            this.cboVideoSizes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoSizes.Size = new System.Drawing.Size(129, 24);
            this.cboVideoSizes.TabIndex = 31;
            this.cboVideoSizes.SelectedIndexChanged += new System.EventHandler(this.cboVideoSizes_SelectedIndexChanged);
            // 
            // cboVideoSubtypes
            // 
            this.cboVideoSubtypes.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoSubtypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoSubtypes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboVideoSubtypes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoSubtypes.Location = new System.Drawing.Point(148, 81);
            this.cboVideoSubtypes.Name = "cboVideoSubtypes";
            this.cboVideoSubtypes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoSubtypes.Size = new System.Drawing.Size(142, 24);
            this.cboVideoSubtypes.TabIndex = 30;
            this.cboVideoSubtypes.SelectedIndexChanged += new System.EventHandler(this.cboVideoSubtypes_SelectedIndexChanged);
            // 
            // cboAnalogVideoStandard
            // 
            this.cboAnalogVideoStandard.BackColor = System.Drawing.SystemColors.Window;
            this.cboAnalogVideoStandard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAnalogVideoStandard.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAnalogVideoStandard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAnalogVideoStandard.Location = new System.Drawing.Point(602, 104);
            this.cboAnalogVideoStandard.Name = "cboAnalogVideoStandard";
            this.cboAnalogVideoStandard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboAnalogVideoStandard.Size = new System.Drawing.Size(163, 24);
            this.cboAnalogVideoStandard.TabIndex = 29;
            this.cboAnalogVideoStandard.SelectedIndexChanged += new System.EventHandler(this.cboAnalogVideoStandard_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(596, 19);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(91, 26);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "video input";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(148, 56);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(95, 16);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "video subtype";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(8, 56);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(69, 16);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "video size";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(598, 80);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(188, 27);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "analog video standard";
            // 
            // grbVsFileOrUrl
            // 
            this.grbVsFileOrUrl.BackColor = System.Drawing.SystemColors.Control;
            this.grbVsFileOrUrl.Controls.Add(this.label8);
            this.grbVsFileOrUrl.Controls.Add(this.label7);
            this.grbVsFileOrUrl.Controls.Add(this.edtSourceFileOrUrlPassword);
            this.grbVsFileOrUrl.Controls.Add(this.edtSourceFileOrUrlUserName);
            this.grbVsFileOrUrl.Controls.Add(this.btnSelectFileOrUrl);
            this.grbVsFileOrUrl.Controls.Add(this.edtVideoSourceFileOrUrl);
            this.grbVsFileOrUrl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbVsFileOrUrl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVsFileOrUrl.Location = new System.Drawing.Point(6, 215);
            this.grbVsFileOrUrl.Name = "grbVsFileOrUrl";
            this.grbVsFileOrUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVsFileOrUrl.Size = new System.Drawing.Size(643, 93);
            this.grbVsFileOrUrl.TabIndex = 52;
            this.grbVsFileOrUrl.TabStop = false;
            this.grbVsFileOrUrl.Text = "video source = file or URL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(533, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "pass:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(533, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "user:";
            // 
            // edtSourceFileOrUrlPassword
            // 
            this.edtSourceFileOrUrlPassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtSourceFileOrUrlPassword.Location = new System.Drawing.Point(582, 56);
            this.edtSourceFileOrUrlPassword.Name = "edtSourceFileOrUrlPassword";
            this.edtSourceFileOrUrlPassword.Size = new System.Drawing.Size(53, 23);
            this.edtSourceFileOrUrlPassword.TabIndex = 35;
            this.edtSourceFileOrUrlPassword.TextChanged += new System.EventHandler(this.edtSourceFileOrUrlPassword_TextChanged);
            // 
            // edtSourceFileOrUrlUserName
            // 
            this.edtSourceFileOrUrlUserName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtSourceFileOrUrlUserName.Location = new System.Drawing.Point(582, 20);
            this.edtSourceFileOrUrlUserName.Name = "edtSourceFileOrUrlUserName";
            this.edtSourceFileOrUrlUserName.Size = new System.Drawing.Size(53, 23);
            this.edtSourceFileOrUrlUserName.TabIndex = 34;
            this.edtSourceFileOrUrlUserName.TextChanged += new System.EventHandler(this.edtSourceFileOrUrlUserName_TextChanged);
            // 
            // btnSelectFileOrUrl
            // 
            this.btnSelectFileOrUrl.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectFileOrUrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectFileOrUrl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectFileOrUrl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectFileOrUrl.Location = new System.Drawing.Point(0, 21);
            this.btnSelectFileOrUrl.Name = "btnSelectFileOrUrl";
            this.btnSelectFileOrUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectFileOrUrl.Size = new System.Drawing.Size(63, 32);
            this.btnSelectFileOrUrl.TabIndex = 26;
            this.btnSelectFileOrUrl.Text = "open";
            this.btnSelectFileOrUrl.UseVisualStyleBackColor = false;
            this.btnSelectFileOrUrl.Click += new System.EventHandler(this.btnSelectFileOrUrl_Click);
            // 
            // edtVideoSourceFileOrUrl
            // 
            this.edtVideoSourceFileOrUrl.AcceptsReturn = true;
            this.edtVideoSourceFileOrUrl.BackColor = System.Drawing.SystemColors.Window;
            this.edtVideoSourceFileOrUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtVideoSourceFileOrUrl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtVideoSourceFileOrUrl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtVideoSourceFileOrUrl.Location = new System.Drawing.Point(70, 21);
            this.edtVideoSourceFileOrUrl.MaxLength = 0;
            this.edtVideoSourceFileOrUrl.Name = "edtVideoSourceFileOrUrl";
            this.edtVideoSourceFileOrUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtVideoSourceFileOrUrl.Size = new System.Drawing.Size(456, 23);
            this.edtVideoSourceFileOrUrl.TabIndex = 25;
            this.edtVideoSourceFileOrUrl.Text = "rtmp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov";
            this.edtVideoSourceFileOrUrl.TextChanged += new System.EventHandler(this.edtVideoSourceFileOrUrl_TextChanged);
            // 
            // grbVsScreenRecording
            // 
            this.grbVsScreenRecording.BackColor = System.Drawing.SystemColors.Control;
            this.grbVsScreenRecording.Controls.Add(this.btnScreenRecordingWindow);
            this.grbVsScreenRecording.Controls.Add(this.btnMonitorNumberInfo);
            this.grbVsScreenRecording.Controls.Add(this.edtMonitorNumber);
            this.grbVsScreenRecording.Controls.Add(this.label6);
            this.grbVsScreenRecording.Controls.Add(this.Label5);
            this.grbVsScreenRecording.Controls.Add(this.edtScreenRecordingWindow);
            this.grbVsScreenRecording.Controls.Add(this.chkScreenRecordingWithCursor);
            this.grbVsScreenRecording.Controls.Add(this.chkScreenRecordingWindow);
            this.grbVsScreenRecording.Controls.Add(this.lblEnumerateWindows);
            this.grbVsScreenRecording.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbVsScreenRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVsScreenRecording.Location = new System.Drawing.Point(652, 215);
            this.grbVsScreenRecording.Name = "grbVsScreenRecording";
            this.grbVsScreenRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVsScreenRecording.Size = new System.Drawing.Size(442, 93);
            this.grbVsScreenRecording.TabIndex = 51;
            this.grbVsScreenRecording.TabStop = false;
            this.grbVsScreenRecording.Text = "video source = screen recording";
            // 
            // btnScreenRecordingWindow
            // 
            this.btnScreenRecordingWindow.BackColor = System.Drawing.SystemColors.Control;
            this.btnScreenRecordingWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnScreenRecordingWindow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScreenRecordingWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScreenRecordingWindow.Location = new System.Drawing.Point(384, 52);
            this.btnScreenRecordingWindow.Name = "btnScreenRecordingWindow";
            this.btnScreenRecordingWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnScreenRecordingWindow.Size = new System.Drawing.Size(38, 32);
            this.btnScreenRecordingWindow.TabIndex = 27;
            this.btnScreenRecordingWindow.Text = "ok";
            this.btnScreenRecordingWindow.UseVisualStyleBackColor = false;
            this.btnScreenRecordingWindow.Click += new System.EventHandler(this.btnScreenRecordingWindow_Click);
            // 
            // btnMonitorNumberInfo
            // 
            this.btnMonitorNumberInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMonitorNumberInfo.Location = new System.Drawing.Point(56, 51);
            this.btnMonitorNumberInfo.Name = "btnMonitorNumberInfo";
            this.btnMonitorNumberInfo.Size = new System.Drawing.Size(61, 30);
            this.btnMonitorNumberInfo.TabIndex = 33;
            this.btnMonitorNumberInfo.Text = "info?";
            this.btnMonitorNumberInfo.Click += new System.EventHandler(this.btnMonitorNumberInfo_Click);
            // 
            // edtMonitorNumber
            // 
            this.edtMonitorNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtMonitorNumber.Location = new System.Drawing.Point(8, 52);
            this.edtMonitorNumber.Name = "edtMonitorNumber";
            this.edtMonitorNumber.Size = new System.Drawing.Size(53, 23);
            this.edtMonitorNumber.TabIndex = 32;
            this.edtMonitorNumber.Text = "0";
            this.edtMonitorNumber.TextChanged += new System.EventHandler(this.edtMonitorNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "monitor num:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(126, 29);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(202, 16);
            this.Label5.TabIndex = 28;
            this.Label5.Text = "use this window (\"\"=full screen)";
            // 
            // edtScreenRecordingWindow
            // 
            this.edtScreenRecordingWindow.AcceptsReturn = true;
            this.edtScreenRecordingWindow.BackColor = System.Drawing.SystemColors.Window;
            this.edtScreenRecordingWindow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtScreenRecordingWindow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtScreenRecordingWindow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtScreenRecordingWindow.Location = new System.Drawing.Point(125, 53);
            this.edtScreenRecordingWindow.MaxLength = 0;
            this.edtScreenRecordingWindow.Name = "edtScreenRecordingWindow";
            this.edtScreenRecordingWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtScreenRecordingWindow.Size = new System.Drawing.Size(183, 23);
            this.edtScreenRecordingWindow.TabIndex = 26;
            this.edtScreenRecordingWindow.Text = "TVideoGrabber demo";
            // 
            // chkScreenRecordingWithCursor
            // 
            this.chkScreenRecordingWithCursor.BackColor = System.Drawing.SystemColors.Control;
            this.chkScreenRecordingWithCursor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkScreenRecordingWithCursor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkScreenRecordingWithCursor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkScreenRecordingWithCursor.Location = new System.Drawing.Point(364, 17);
            this.chkScreenRecordingWithCursor.Name = "chkScreenRecordingWithCursor";
            this.chkScreenRecordingWithCursor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkScreenRecordingWithCursor.Size = new System.Drawing.Size(84, 32);
            this.chkScreenRecordingWithCursor.TabIndex = 23;
            this.chkScreenRecordingWithCursor.Text = "cursor";
            this.chkScreenRecordingWithCursor.UseVisualStyleBackColor = false;
            this.chkScreenRecordingWithCursor.CheckedChanged += new System.EventHandler(this.chkScreenRecordingWithCursor_CheckedChanged);
            // 
            // chkScreenRecordingWindow
            // 
            this.chkScreenRecordingWindow.AutoSize = true;
            this.chkScreenRecordingWindow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkScreenRecordingWindow.Location = new System.Drawing.Point(314, 56);
            this.chkScreenRecordingWindow.Name = "chkScreenRecordingWindow";
            this.chkScreenRecordingWindow.Size = new System.Drawing.Size(62, 20);
            this.chkScreenRecordingWindow.TabIndex = 34;
            this.chkScreenRecordingWindow.Text = "exact";
            // 
            // lblEnumerateWindows
            // 
            this.lblEnumerateWindows.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnumerateWindows.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEnumerateWindows.Location = new System.Drawing.Point(412, 17);
            this.lblEnumerateWindows.Name = "lblEnumerateWindows";
            this.lblEnumerateWindows.Size = new System.Drawing.Size(30, 27);
            this.lblEnumerateWindows.TabIndex = 36;
            this.lblEnumerateWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbPreferredVideoSizes
            // 
            this.grbPreferredVideoSizes.BackColor = System.Drawing.SystemColors.Control;
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize1);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize2);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize3);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize4);
            this.grbPreferredVideoSizes.Controls.Add(this.chkStretchPreferredVideoSize);
            this.grbPreferredVideoSizes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbPreferredVideoSizes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbPreferredVideoSizes.Location = new System.Drawing.Point(812, 24);
            this.grbPreferredVideoSizes.Name = "grbPreferredVideoSizes";
            this.grbPreferredVideoSizes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbPreferredVideoSizes.Size = new System.Drawing.Size(282, 148);
            this.grbPreferredVideoSizes.TabIndex = 50;
            this.grbPreferredVideoSizes.TabStop = false;
            this.grbPreferredVideoSizes.Text = "preferred video sizes (examples)";
            // 
            // rdgPreferredVideoSize1
            // 
            this.rdgPreferredVideoSize1.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize1.Checked = true;
            this.rdgPreferredVideoSize1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgPreferredVideoSize1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize1.Location = new System.Drawing.Point(13, 29);
            this.rdgPreferredVideoSize1.Name = "rdgPreferredVideoSize1";
            this.rdgPreferredVideoSize1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize1.Size = new System.Drawing.Size(249, 26);
            this.rdgPreferredVideoSize1.TabIndex = 21;
            this.rdgPreferredVideoSize1.TabStop = true;
            this.rdgPreferredVideoSize1.Tag = "0";
            this.rdgPreferredVideoSize1.Text = "source size (default)";
            this.rdgPreferredVideoSize1.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize1.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize2
            // 
            this.rdgPreferredVideoSize2.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgPreferredVideoSize2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize2.Location = new System.Drawing.Point(13, 59);
            this.rdgPreferredVideoSize2.Name = "rdgPreferredVideoSize2";
            this.rdgPreferredVideoSize2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize2.Size = new System.Drawing.Size(135, 24);
            this.rdgPreferredVideoSize2.TabIndex = 20;
            this.rdgPreferredVideoSize2.TabStop = true;
            this.rdgPreferredVideoSize2.Tag = "1";
            this.rdgPreferredVideoSize2.Text = "640x360";
            this.rdgPreferredVideoSize2.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize2.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize3
            // 
            this.rdgPreferredVideoSize3.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgPreferredVideoSize3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize3.Location = new System.Drawing.Point(13, 85);
            this.rdgPreferredVideoSize3.Name = "rdgPreferredVideoSize3";
            this.rdgPreferredVideoSize3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize3.Size = new System.Drawing.Size(135, 24);
            this.rdgPreferredVideoSize3.TabIndex = 19;
            this.rdgPreferredVideoSize3.TabStop = true;
            this.rdgPreferredVideoSize3.Tag = "2";
            this.rdgPreferredVideoSize3.Text = "1280x720";
            this.rdgPreferredVideoSize3.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize3.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize4
            // 
            this.rdgPreferredVideoSize4.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize4.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdgPreferredVideoSize4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize4.Location = new System.Drawing.Point(13, 112);
            this.rdgPreferredVideoSize4.Name = "rdgPreferredVideoSize4";
            this.rdgPreferredVideoSize4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize4.Size = new System.Drawing.Size(135, 23);
            this.rdgPreferredVideoSize4.TabIndex = 18;
            this.rdgPreferredVideoSize4.TabStop = true;
            this.rdgPreferredVideoSize4.Tag = "3";
            this.rdgPreferredVideoSize4.Text = "1920x1080";
            this.rdgPreferredVideoSize4.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize4.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // chkStretchPreferredVideoSize
            // 
            this.chkStretchPreferredVideoSize.BackColor = System.Drawing.SystemColors.Control;
            this.chkStretchPreferredVideoSize.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStretchPreferredVideoSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkStretchPreferredVideoSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkStretchPreferredVideoSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkStretchPreferredVideoSize.Location = new System.Drawing.Point(144, 76);
            this.chkStretchPreferredVideoSize.Name = "chkStretchPreferredVideoSize";
            this.chkStretchPreferredVideoSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkStretchPreferredVideoSize.Size = new System.Drawing.Size(103, 28);
            this.chkStretchPreferredVideoSize.TabIndex = 10;
            this.chkStretchPreferredVideoSize.Text = "stretch";
            this.chkStretchPreferredVideoSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStretchPreferredVideoSize.UseVisualStyleBackColor = false;
            this.chkStretchPreferredVideoSize.CheckedChanged += new System.EventHandler(this.chkStretchPreferredVideoSize_CheckedChanged);
            // 
            // grbVideoDevicesDialogs
            // 
            this.grbVideoDevicesDialogs.BackColor = System.Drawing.SystemColors.Control;
            this.grbVideoDevicesDialogs.Controls.Add(this.btnDeviceDialog);
            this.grbVideoDevicesDialogs.Controls.Add(this.btnCameraControlDialog);
            this.grbVideoDevicesDialogs.Controls.Add(this.btnVideoQualityDialog);
            this.grbVideoDevicesDialogs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbVideoDevicesDialogs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVideoDevicesDialogs.Location = new System.Drawing.Point(1101, 35);
            this.grbVideoDevicesDialogs.Name = "grbVideoDevicesDialogs";
            this.grbVideoDevicesDialogs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVideoDevicesDialogs.Size = new System.Drawing.Size(143, 149);
            this.grbVideoDevicesDialogs.TabIndex = 49;
            this.grbVideoDevicesDialogs.TabStop = false;
            this.grbVideoDevicesDialogs.Text = "dialogs";
            // 
            // btnDeviceDialog
            // 
            this.btnDeviceDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeviceDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeviceDialog.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeviceDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeviceDialog.Location = new System.Drawing.Point(7, 27);
            this.btnDeviceDialog.Name = "btnDeviceDialog";
            this.btnDeviceDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeviceDialog.Size = new System.Drawing.Size(124, 30);
            this.btnDeviceDialog.TabIndex = 6;
            this.btnDeviceDialog.Text = "device";
            this.btnDeviceDialog.UseVisualStyleBackColor = false;
            this.btnDeviceDialog.Click += new System.EventHandler(this.btnDeviceDialog_Click);
            // 
            // btnCameraControlDialog
            // 
            this.btnCameraControlDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btnCameraControlDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCameraControlDialog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCameraControlDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCameraControlDialog.Location = new System.Drawing.Point(7, 65);
            this.btnCameraControlDialog.Name = "btnCameraControlDialog";
            this.btnCameraControlDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCameraControlDialog.Size = new System.Drawing.Size(124, 31);
            this.btnCameraControlDialog.TabIndex = 4;
            this.btnCameraControlDialog.Text = "camera control";
            this.btnCameraControlDialog.UseVisualStyleBackColor = false;
            this.btnCameraControlDialog.Click += new System.EventHandler(this.btnCameraControlDialog_Click);
            // 
            // btnVideoQualityDialog
            // 
            this.btnVideoQualityDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btnVideoQualityDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVideoQualityDialog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVideoQualityDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVideoQualityDialog.Location = new System.Drawing.Point(7, 101);
            this.btnVideoQualityDialog.Name = "btnVideoQualityDialog";
            this.btnVideoQualityDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVideoQualityDialog.Size = new System.Drawing.Size(124, 31);
            this.btnVideoQualityDialog.TabIndex = 3;
            this.btnVideoQualityDialog.Text = "video quality";
            this.btnVideoQualityDialog.UseVisualStyleBackColor = false;
            this.btnVideoQualityDialog.Click += new System.EventHandler(this.btnVideoQualityDialog_Click);
            // 
            // btnAutoRefreshPreview
            // 
            this.btnAutoRefreshPreview.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoRefreshPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAutoRefreshPreview.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoRefreshPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAutoRefreshPreview.Location = new System.Drawing.Point(596, 35);
            this.btnAutoRefreshPreview.Name = "btnAutoRefreshPreview";
            this.btnAutoRefreshPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAutoRefreshPreview.Size = new System.Drawing.Size(196, 26);
            this.btnAutoRefreshPreview.TabIndex = 48;
            this.btnAutoRefreshPreview.Text = "Auto refresh preview";
            this.btnAutoRefreshPreview.UseVisualStyleBackColor = false;
            this.btnAutoRefreshPreview.CheckedChanged += new System.EventHandler(this.btnAutoRefreshPreview_CheckedChanged);
            // 
            // VideoSource
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(1272, 328);
            this.ControlBox = false;
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.grbVideoSource);
            this.Controls.Add(this.grbPreview);
            this.Controls.Add(this.grbFrameRate);
            this.Controls.Add(this.grbVsVideoCaptureDevice);
            this.Controls.Add(this.grbVsFileOrUrl);
            this.Controls.Add(this.grbVsScreenRecording);
            this.Controls.Add(this.grbPreferredVideoSizes);
            this.Controls.Add(this.grbVideoDevicesDialogs);
            this.Controls.Add(this.btnAutoRefreshPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoSource";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.VideoSource_VisibleChanged);
            this.grbVideoSource.ResumeLayout(false);
            this.grbPreview.ResumeLayout(false);
            this.grbFrameRate.ResumeLayout(false);
            this.grbFrameRate.PerformLayout();
            this.grbVsVideoCaptureDevice.ResumeLayout(false);
            this.grbVsVideoCaptureDevice.PerformLayout();
            this.grbVsFileOrUrl.ResumeLayout(false);
            this.grbVsFileOrUrl.PerformLayout();
            this.grbVsScreenRecording.ResumeLayout(false);
            this.grbVsScreenRecording.PerformLayout();
            this.grbPreferredVideoSizes.ResumeLayout(false);
            this.grbVideoDevicesDialogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.ToolTip ToolTip1;
        private Label Label11;
        private GroupBox grbVideoSource;
        private ComboBox cboVideoSource;
        private GroupBox grbPreview;
        private Button btnStartPreview;
        private Button btnStopPreview;
        private GroupBox grbFrameRate;
        private  Button btnFrameRateHelp;
        private Button btnFrameRate;
        private TextBox edtFrameRate;
        private GroupBox grbVsVideoCaptureDevice;
        internal ComboBox cboVideoDevices;
        private ComboBox cboVideoInputs;
        private ComboBox cboVideoSizes;
        private ComboBox cboVideoSubtypes;
        private ComboBox cboAnalogVideoStandard;
        private Label Label1;
        private Label Label2;
        private Label Label3;
        private Label Label4;
        private GroupBox grbVsFileOrUrl;
        private  Label label8;
        private  Label label7;
        private  TextBox edtSourceFileOrUrlPassword;
        private  TextBox edtSourceFileOrUrlUserName;
        private Button btnSelectFileOrUrl;
        private TextBox edtVideoSourceFileOrUrl;
        private GroupBox grbVsScreenRecording;
        private  CheckBox chkScreenRecordingWindow;
        private Button btnScreenRecordingWindow;
        private  Button btnMonitorNumberInfo;
        private  TextBox edtMonitorNumber;
        private  Label label6;
        private  Label Label5;
        private TextBox edtScreenRecordingWindow;
        private CheckBox chkScreenRecordingWithCursor;
        private GroupBox grbPreferredVideoSizes;
        private RadioButton rdgPreferredVideoSize1;
        private RadioButton rdgPreferredVideoSize2;
        private RadioButton rdgPreferredVideoSize3;
        private RadioButton rdgPreferredVideoSize4;
        private CheckBox chkStretchPreferredVideoSize;
        private GroupBox grbVideoDevicesDialogs;
        private Button btnDeviceDialog;
        private Button btnCameraControlDialog;
        private Button btnVideoQualityDialog;
        private CheckBox btnAutoRefreshPreview;
        internal Label lblEnumerateWindows;
        private ComboBox cboVideoFormats;
        private Label label9;

    }
}

