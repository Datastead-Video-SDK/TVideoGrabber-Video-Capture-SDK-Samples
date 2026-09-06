namespace MainDemo
{
    partial class VUMeterConfigForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.TabControl pcMain;

        // Type & Display
        private System.Windows.Forms.TabPage tsType;
        private System.Windows.Forms.Label lblVUMeter;
        private System.Windows.Forms.ComboBox cboVUMeter;
        private System.Windows.Forms.GroupBox grbDisplayOptions;
        private System.Windows.Forms.CheckBox chkOverlayOverVideo;
        private System.Windows.Forms.CheckBox chkTransparent;
        private System.Windows.Forms.CheckBox chkFlipVert;
        private System.Windows.Forms.CheckBox chkFlipHorz;
        private System.Windows.Forms.CheckBox chkLogarithmic;
        private System.Windows.Forms.Button btnDisablePeak;
        private System.Windows.Forms.GroupBox grbOverlayRect;
        private System.Windows.Forms.Label lblOverlayLeft;
        private System.Windows.Forms.Label lblOverlayTop;
        private System.Windows.Forms.Label lblOverlayWidth;
        private System.Windows.Forms.Label lblOverlayHeight;
        private System.Windows.Forms.TextBox edtOverlayLeft;
        private System.Windows.Forms.TextBox edtOverlayTop;
        private System.Windows.Forms.TextBox edtOverlayWidth;
        private System.Windows.Forms.TextBox edtOverlayHeight;

        // Levels & Colors
        private System.Windows.Forms.TabPage tsLevelsColors;
        private System.Windows.Forms.GroupBox grbWarningPercent;
        private System.Windows.Forms.TrackBar tbrWarningPercent;
        private System.Windows.Forms.Label lblWarningPercentValue;
        private System.Windows.Forms.GroupBox grbPeakPercent;
        private System.Windows.Forms.TrackBar tbrPeakPercent;
        private System.Windows.Forms.Label lblPeakPercentValue;
        private System.Windows.Forms.GroupBox grbColors;
        private System.Windows.Forms.Label lblBkgndColor;
        private System.Windows.Forms.Panel pnBkgndColor;
        private System.Windows.Forms.Button btnBkgndColor;
        private System.Windows.Forms.Label lblNormalColor;
        private System.Windows.Forms.Panel pnNormalColor;
        private System.Windows.Forms.Button btnNormalColor;
        private System.Windows.Forms.Label lblWarningColor;
        private System.Windows.Forms.Panel pnWarningColor;
        private System.Windows.Forms.Button btnWarningColor;
        private System.Windows.Forms.Label lblPeakColor;
        private System.Windows.Forms.Panel pnPeakColor;
        private System.Windows.Forms.Button btnPeakColor;

        // Drawing
        private System.Windows.Forms.TabPage tsDrawing;
        private System.Windows.Forms.Label lblTickSize;
        private System.Windows.Forms.Label lblTickInterval;
        private System.Windows.Forms.Label lblNeedleThickness;
        private System.Windows.Forms.Label lblDrawingHint;
        private System.Windows.Forms.NumericUpDown updTickSize;
        private System.Windows.Forms.NumericUpDown updTickInterval;
        private System.Windows.Forms.NumericUpDown updNeedleThickness;

        // Ballistics
        private System.Windows.Forms.TabPage tsBallistics;
        private System.Windows.Forms.Label lblBallisticProfile;
        private System.Windows.Forms.ComboBox cboBallisticProfile;
        private System.Windows.Forms.Label lblAttackMs;
        private System.Windows.Forms.NumericUpDown updAttackMs;
        private System.Windows.Forms.Label lblReleaseMs;
        private System.Windows.Forms.NumericUpDown updReleaseMs;
        private System.Windows.Forms.Label lblPeakHoldMs;
        private System.Windows.Forms.NumericUpDown updPeakHoldMs;
        private System.Windows.Forms.Label lblBallisticHint;

        // Footer
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColorDialog ColorDialog1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcMain = new System.Windows.Forms.TabControl();
            this.tsType = new System.Windows.Forms.TabPage();
            this.lblVUMeter = new System.Windows.Forms.Label();
            this.cboVUMeter = new System.Windows.Forms.ComboBox();
            this.grbDisplayOptions = new System.Windows.Forms.GroupBox();
            this.chkOverlayOverVideo = new System.Windows.Forms.CheckBox();
            this.chkTransparent = new System.Windows.Forms.CheckBox();
            this.chkFlipVert = new System.Windows.Forms.CheckBox();
            this.chkFlipHorz = new System.Windows.Forms.CheckBox();
            this.chkLogarithmic = new System.Windows.Forms.CheckBox();
            this.btnDisablePeak = new System.Windows.Forms.Button();
            this.grbOverlayRect = new System.Windows.Forms.GroupBox();
            this.lblOverlayLeft = new System.Windows.Forms.Label();
            this.lblOverlayTop = new System.Windows.Forms.Label();
            this.lblOverlayWidth = new System.Windows.Forms.Label();
            this.lblOverlayHeight = new System.Windows.Forms.Label();
            this.edtOverlayLeft = new System.Windows.Forms.TextBox();
            this.edtOverlayTop = new System.Windows.Forms.TextBox();
            this.edtOverlayWidth = new System.Windows.Forms.TextBox();
            this.edtOverlayHeight = new System.Windows.Forms.TextBox();
            this.tsLevelsColors = new System.Windows.Forms.TabPage();
            this.grbWarningPercent = new System.Windows.Forms.GroupBox();
            this.tbrWarningPercent = new System.Windows.Forms.TrackBar();
            this.lblWarningPercentValue = new System.Windows.Forms.Label();
            this.grbPeakPercent = new System.Windows.Forms.GroupBox();
            this.tbrPeakPercent = new System.Windows.Forms.TrackBar();
            this.lblPeakPercentValue = new System.Windows.Forms.Label();
            this.grbColors = new System.Windows.Forms.GroupBox();
            this.lblBkgndColor = new System.Windows.Forms.Label();
            this.pnBkgndColor = new System.Windows.Forms.Panel();
            this.btnBkgndColor = new System.Windows.Forms.Button();
            this.lblNormalColor = new System.Windows.Forms.Label();
            this.pnNormalColor = new System.Windows.Forms.Panel();
            this.btnNormalColor = new System.Windows.Forms.Button();
            this.lblWarningColor = new System.Windows.Forms.Label();
            this.pnWarningColor = new System.Windows.Forms.Panel();
            this.btnWarningColor = new System.Windows.Forms.Button();
            this.lblPeakColor = new System.Windows.Forms.Label();
            this.pnPeakColor = new System.Windows.Forms.Panel();
            this.btnPeakColor = new System.Windows.Forms.Button();
            this.tsDrawing = new System.Windows.Forms.TabPage();
            this.lblTickSize = new System.Windows.Forms.Label();
            this.lblTickInterval = new System.Windows.Forms.Label();
            this.lblNeedleThickness = new System.Windows.Forms.Label();
            this.lblDrawingHint = new System.Windows.Forms.Label();
            this.updTickSize = new System.Windows.Forms.NumericUpDown();
            this.updTickInterval = new System.Windows.Forms.NumericUpDown();
            this.updNeedleThickness = new System.Windows.Forms.NumericUpDown();
            this.tsBallistics = new System.Windows.Forms.TabPage();
            this.lblBallisticProfile = new System.Windows.Forms.Label();
            this.cboBallisticProfile = new System.Windows.Forms.ComboBox();
            this.lblAttackMs = new System.Windows.Forms.Label();
            this.updAttackMs = new System.Windows.Forms.NumericUpDown();
            this.lblReleaseMs = new System.Windows.Forms.Label();
            this.updReleaseMs = new System.Windows.Forms.NumericUpDown();
            this.lblPeakHoldMs = new System.Windows.Forms.Label();
            this.updPeakHoldMs = new System.Windows.Forms.NumericUpDown();
            this.lblBallisticHint = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pcMain.SuspendLayout();
            this.tsType.SuspendLayout();
            this.grbDisplayOptions.SuspendLayout();
            this.grbOverlayRect.SuspendLayout();
            this.tsLevelsColors.SuspendLayout();
            this.grbWarningPercent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrWarningPercent)).BeginInit();
            this.grbPeakPercent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPeakPercent)).BeginInit();
            this.grbColors.SuspendLayout();
            this.tsDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTickSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updTickInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updNeedleThickness)).BeginInit();
            this.tsBallistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updAttackMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updReleaseMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPeakHoldMs)).BeginInit();
            this.SuspendLayout();
            //
            // pcMain
            //
            this.pcMain.Controls.Add(this.tsType);
            this.pcMain.Controls.Add(this.tsLevelsColors);
            this.pcMain.Controls.Add(this.tsDrawing);
            this.pcMain.Controls.Add(this.tsBallistics);
            this.pcMain.Location = new System.Drawing.Point(8, 8);
            this.pcMain.Name = "pcMain";
            this.pcMain.SelectedIndex = 0;
            this.pcMain.Size = new System.Drawing.Size(454, 488);
            this.pcMain.TabIndex = 0;
            //
            // tsType
            //
            this.tsType.Controls.Add(this.lblVUMeter);
            this.tsType.Controls.Add(this.cboVUMeter);
            this.tsType.Controls.Add(this.grbDisplayOptions);
            this.tsType.Controls.Add(this.grbOverlayRect);
            this.tsType.Location = new System.Drawing.Point(4, 22);
            this.tsType.Name = "tsType";
            this.tsType.Size = new System.Drawing.Size(446, 462);
            this.tsType.Text = "Type && Display";
            this.tsType.UseVisualStyleBackColor = true;
            //
            // lblVUMeter
            //
            this.lblVUMeter.AutoSize = true;
            this.lblVUMeter.Location = new System.Drawing.Point(12, 14);
            this.lblVUMeter.Name = "lblVUMeter";
            this.lblVUMeter.Size = new System.Drawing.Size(80, 13);
            this.lblVUMeter.Text = "VU Meter type:";
            //
            // cboVUMeter
            //
            this.cboVUMeter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVUMeter.Location = new System.Drawing.Point(100, 11);
            this.cboVUMeter.Name = "cboVUMeter";
            this.cboVUMeter.Size = new System.Drawing.Size(230, 21);
            this.cboVUMeter.TabIndex = 0;
            this.cboVUMeter.SelectedIndexChanged += new System.EventHandler(this.cboVUMeter_SelectedIndexChanged);
            //
            // grbDisplayOptions
            //
            this.grbDisplayOptions.Controls.Add(this.chkOverlayOverVideo);
            this.grbDisplayOptions.Controls.Add(this.chkTransparent);
            this.grbDisplayOptions.Controls.Add(this.chkFlipVert);
            this.grbDisplayOptions.Controls.Add(this.chkFlipHorz);
            this.grbDisplayOptions.Controls.Add(this.chkLogarithmic);
            this.grbDisplayOptions.Controls.Add(this.btnDisablePeak);
            this.grbDisplayOptions.Location = new System.Drawing.Point(12, 48);
            this.grbDisplayOptions.Name = "grbDisplayOptions";
            this.grbDisplayOptions.Size = new System.Drawing.Size(426, 165);
            this.grbDisplayOptions.TabIndex = 1;
            this.grbDisplayOptions.TabStop = false;
            this.grbDisplayOptions.Text = "Display options";
            //
            // chkOverlayOverVideo
            //
            this.chkOverlayOverVideo.Location = new System.Drawing.Point(16, 24);
            this.chkOverlayOverVideo.Name = "chkOverlayOverVideo";
            this.chkOverlayOverVideo.Size = new System.Drawing.Size(330, 17);
            this.chkOverlayOverVideo.TabIndex = 0;
            this.chkOverlayOverVideo.Text = "Draw VU meter as overlay over the video frame";
            this.chkOverlayOverVideo.UseVisualStyleBackColor = true;
            this.chkOverlayOverVideo.CheckedChanged += new System.EventHandler(this.chkOverlayOverVideo_CheckedChanged);
            //
            // chkTransparent
            //
            this.chkTransparent.Location = new System.Drawing.Point(16, 50);
            this.chkTransparent.Name = "chkTransparent";
            this.chkTransparent.Size = new System.Drawing.Size(330, 17);
            this.chkTransparent.TabIndex = 1;
            this.chkTransparent.Text = "Transparent background (overlay mode)";
            this.chkTransparent.UseVisualStyleBackColor = true;
            this.chkTransparent.CheckedChanged += new System.EventHandler(this.chkTransparent_CheckedChanged);
            //
            // chkFlipVert
            //
            this.chkFlipVert.Location = new System.Drawing.Point(16, 76);
            this.chkFlipVert.Name = "chkFlipVert";
            this.chkFlipVert.Size = new System.Drawing.Size(200, 17);
            this.chkFlipVert.TabIndex = 2;
            this.chkFlipVert.Text = "Flip vertically";
            this.chkFlipVert.UseVisualStyleBackColor = true;
            this.chkFlipVert.CheckedChanged += new System.EventHandler(this.chkFlipVert_CheckedChanged);
            //
            // chkFlipHorz
            //
            this.chkFlipHorz.Location = new System.Drawing.Point(220, 76);
            this.chkFlipHorz.Name = "chkFlipHorz";
            this.chkFlipHorz.Size = new System.Drawing.Size(200, 17);
            this.chkFlipHorz.TabIndex = 3;
            this.chkFlipHorz.Text = "Flip horizontally";
            this.chkFlipHorz.UseVisualStyleBackColor = true;
            this.chkFlipHorz.CheckedChanged += new System.EventHandler(this.chkFlipHorz_CheckedChanged);
            //
            // chkLogarithmic
            //
            this.chkLogarithmic.Location = new System.Drawing.Point(16, 102);
            this.chkLogarithmic.Name = "chkLogarithmic";
            this.chkLogarithmic.Size = new System.Drawing.Size(380, 17);
            this.chkLogarithmic.TabIndex = 4;
            this.chkLogarithmic.Text = "Logarithmic scale (PPM-style)";
            this.chkLogarithmic.UseVisualStyleBackColor = true;
            this.chkLogarithmic.CheckedChanged += new System.EventHandler(this.chkLogarithmic_CheckedChanged);
            //
            // btnDisablePeak
            //
            this.btnDisablePeak.Location = new System.Drawing.Point(16, 128);
            this.btnDisablePeak.Name = "btnDisablePeak";
            this.btnDisablePeak.Size = new System.Drawing.Size(380, 25);
            this.btnDisablePeak.TabIndex = 5;
            this.btnDisablePeak.Text = "Disable peak indicator (sets vu_PeakHoldMs to 0 in the \"Ballistics\" tab)";
            this.btnDisablePeak.UseVisualStyleBackColor = true;
            this.btnDisablePeak.Click += new System.EventHandler(this.btnDisablePeak_Click);
            //
            // grbOverlayRect
            //
            this.grbOverlayRect.Controls.Add(this.lblOverlayLeft);
            this.grbOverlayRect.Controls.Add(this.lblOverlayTop);
            this.grbOverlayRect.Controls.Add(this.lblOverlayWidth);
            this.grbOverlayRect.Controls.Add(this.lblOverlayHeight);
            this.grbOverlayRect.Controls.Add(this.edtOverlayLeft);
            this.grbOverlayRect.Controls.Add(this.edtOverlayTop);
            this.grbOverlayRect.Controls.Add(this.edtOverlayWidth);
            this.grbOverlayRect.Controls.Add(this.edtOverlayHeight);
            this.grbOverlayRect.Location = new System.Drawing.Point(12, 224);
            this.grbOverlayRect.Name = "grbOverlayRect";
            this.grbOverlayRect.Size = new System.Drawing.Size(426, 100);
            this.grbOverlayRect.TabIndex = 2;
            this.grbOverlayRect.TabStop = false;
            this.grbOverlayRect.Text = "Overlay rect (used when \"draw as overlay\" is enabled)";
            //
            // lblOverlayLeft
            //
            this.lblOverlayLeft.AutoSize = true;
            this.lblOverlayLeft.Location = new System.Drawing.Point(16, 28);
            this.lblOverlayLeft.Name = "lblOverlayLeft";
            this.lblOverlayLeft.Size = new System.Drawing.Size(28, 13);
            this.lblOverlayLeft.Text = "Left:";
            //
            // lblOverlayTop
            //
            this.lblOverlayTop.AutoSize = true;
            this.lblOverlayTop.Location = new System.Drawing.Point(220, 28);
            this.lblOverlayTop.Name = "lblOverlayTop";
            this.lblOverlayTop.Size = new System.Drawing.Size(29, 13);
            this.lblOverlayTop.Text = "Top:";
            //
            // lblOverlayWidth
            //
            this.lblOverlayWidth.AutoSize = true;
            this.lblOverlayWidth.Location = new System.Drawing.Point(16, 62);
            this.lblOverlayWidth.Name = "lblOverlayWidth";
            this.lblOverlayWidth.Size = new System.Drawing.Size(38, 13);
            this.lblOverlayWidth.Text = "Width:";
            //
            // lblOverlayHeight
            //
            this.lblOverlayHeight.AutoSize = true;
            this.lblOverlayHeight.Location = new System.Drawing.Point(220, 62);
            this.lblOverlayHeight.Name = "lblOverlayHeight";
            this.lblOverlayHeight.Size = new System.Drawing.Size(41, 13);
            this.lblOverlayHeight.Text = "Height:";
            //
            // edtOverlayLeft
            //
            this.edtOverlayLeft.Location = new System.Drawing.Point(80, 24);
            this.edtOverlayLeft.Name = "edtOverlayLeft";
            this.edtOverlayLeft.Size = new System.Drawing.Size(80, 20);
            this.edtOverlayLeft.TabIndex = 0;
            this.edtOverlayLeft.Text = "10";
            this.edtOverlayLeft.TextChanged += new System.EventHandler(this.edtOverlayLeft_TextChanged);
            //
            // edtOverlayTop
            //
            this.edtOverlayTop.Location = new System.Drawing.Point(290, 24);
            this.edtOverlayTop.Name = "edtOverlayTop";
            this.edtOverlayTop.Size = new System.Drawing.Size(80, 20);
            this.edtOverlayTop.TabIndex = 1;
            this.edtOverlayTop.Text = "10";
            this.edtOverlayTop.TextChanged += new System.EventHandler(this.edtOverlayTop_TextChanged);
            //
            // edtOverlayWidth
            //
            this.edtOverlayWidth.Location = new System.Drawing.Point(80, 58);
            this.edtOverlayWidth.Name = "edtOverlayWidth";
            this.edtOverlayWidth.Size = new System.Drawing.Size(80, 20);
            this.edtOverlayWidth.TabIndex = 2;
            this.edtOverlayWidth.Text = "120";
            this.edtOverlayWidth.TextChanged += new System.EventHandler(this.edtOverlayWidth_TextChanged);
            //
            // edtOverlayHeight
            //
            this.edtOverlayHeight.Location = new System.Drawing.Point(290, 58);
            this.edtOverlayHeight.Name = "edtOverlayHeight";
            this.edtOverlayHeight.Size = new System.Drawing.Size(80, 20);
            this.edtOverlayHeight.TabIndex = 3;
            this.edtOverlayHeight.Text = "70";
            this.edtOverlayHeight.TextChanged += new System.EventHandler(this.edtOverlayHeight_TextChanged);
            //
            // tsLevelsColors
            //
            this.tsLevelsColors.Controls.Add(this.grbWarningPercent);
            this.tsLevelsColors.Controls.Add(this.grbPeakPercent);
            this.tsLevelsColors.Controls.Add(this.grbColors);
            this.tsLevelsColors.Location = new System.Drawing.Point(4, 22);
            this.tsLevelsColors.Name = "tsLevelsColors";
            this.tsLevelsColors.Size = new System.Drawing.Size(446, 462);
            this.tsLevelsColors.Text = "Levels && Colors";
            this.tsLevelsColors.UseVisualStyleBackColor = true;
            //
            // grbWarningPercent
            //
            this.grbWarningPercent.Controls.Add(this.tbrWarningPercent);
            this.grbWarningPercent.Controls.Add(this.lblWarningPercentValue);
            this.grbWarningPercent.Location = new System.Drawing.Point(12, 8);
            this.grbWarningPercent.Name = "grbWarningPercent";
            this.grbWarningPercent.Size = new System.Drawing.Size(426, 65);
            this.grbWarningPercent.TabIndex = 0;
            this.grbWarningPercent.TabStop = false;
            this.grbWarningPercent.Text = "Warning threshold (vu_WarningPercent)";
            //
            // tbrWarningPercent
            //
            this.tbrWarningPercent.Location = new System.Drawing.Point(12, 20);
            this.tbrWarningPercent.Maximum = 100;
            this.tbrWarningPercent.TickFrequency = 10;
            this.tbrWarningPercent.Name = "tbrWarningPercent";
            this.tbrWarningPercent.Size = new System.Drawing.Size(360, 45);
            this.tbrWarningPercent.TabIndex = 0;
            this.tbrWarningPercent.Value = 70;
            this.tbrWarningPercent.Scroll += new System.EventHandler(this.tbrWarningPercent_Scroll);
            //
            // lblWarningPercentValue
            //
            this.lblWarningPercentValue.Location = new System.Drawing.Point(360, 28);
            this.lblWarningPercentValue.Name = "lblWarningPercentValue";
            this.lblWarningPercentValue.Size = new System.Drawing.Size(56, 13);
            this.lblWarningPercentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWarningPercentValue.Text = "70 %";
            //
            // grbPeakPercent
            //
            this.grbPeakPercent.Controls.Add(this.tbrPeakPercent);
            this.grbPeakPercent.Controls.Add(this.lblPeakPercentValue);
            this.grbPeakPercent.Location = new System.Drawing.Point(12, 80);
            this.grbPeakPercent.Name = "grbPeakPercent";
            this.grbPeakPercent.Size = new System.Drawing.Size(426, 65);
            this.grbPeakPercent.TabIndex = 1;
            this.grbPeakPercent.TabStop = false;
            this.grbPeakPercent.Text = "Peak threshold (vu_PeakPercent)";
            //
            // tbrPeakPercent
            //
            this.tbrPeakPercent.Location = new System.Drawing.Point(12, 20);
            this.tbrPeakPercent.Maximum = 100;
            this.tbrPeakPercent.TickFrequency = 10;
            this.tbrPeakPercent.Name = "tbrPeakPercent";
            this.tbrPeakPercent.Size = new System.Drawing.Size(360, 45);
            this.tbrPeakPercent.TabIndex = 0;
            this.tbrPeakPercent.Value = 90;
            this.tbrPeakPercent.Scroll += new System.EventHandler(this.tbrPeakPercent_Scroll);
            //
            // lblPeakPercentValue
            //
            this.lblPeakPercentValue.Location = new System.Drawing.Point(360, 28);
            this.lblPeakPercentValue.Name = "lblPeakPercentValue";
            this.lblPeakPercentValue.Size = new System.Drawing.Size(56, 13);
            this.lblPeakPercentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPeakPercentValue.Text = "90 %";
            //
            // grbColors
            //
            this.grbColors.Controls.Add(this.lblBkgndColor);
            this.grbColors.Controls.Add(this.pnBkgndColor);
            this.grbColors.Controls.Add(this.btnBkgndColor);
            this.grbColors.Controls.Add(this.lblNormalColor);
            this.grbColors.Controls.Add(this.pnNormalColor);
            this.grbColors.Controls.Add(this.btnNormalColor);
            this.grbColors.Controls.Add(this.lblWarningColor);
            this.grbColors.Controls.Add(this.pnWarningColor);
            this.grbColors.Controls.Add(this.btnWarningColor);
            this.grbColors.Controls.Add(this.lblPeakColor);
            this.grbColors.Controls.Add(this.pnPeakColor);
            this.grbColors.Controls.Add(this.btnPeakColor);
            this.grbColors.Location = new System.Drawing.Point(12, 152);
            this.grbColors.Name = "grbColors";
            this.grbColors.Size = new System.Drawing.Size(426, 200);
            this.grbColors.TabIndex = 2;
            this.grbColors.TabStop = false;
            this.grbColors.Text = "Colors";
            //
            // lblBkgndColor
            //
            this.lblBkgndColor.AutoSize = true;
            this.lblBkgndColor.Location = new System.Drawing.Point(16, 28);
            this.lblBkgndColor.Name = "lblBkgndColor";
            this.lblBkgndColor.Size = new System.Drawing.Size(68, 13);
            this.lblBkgndColor.Text = "Background:";
            //
            // pnBkgndColor
            //
            this.pnBkgndColor.BackColor = System.Drawing.Color.Black;
            this.pnBkgndColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBkgndColor.Location = new System.Drawing.Point(100, 22);
            this.pnBkgndColor.Name = "pnBkgndColor";
            this.pnBkgndColor.Size = new System.Drawing.Size(200, 24);
            //
            // btnBkgndColor
            //
            this.btnBkgndColor.Location = new System.Drawing.Point(312, 22);
            this.btnBkgndColor.Name = "btnBkgndColor";
            this.btnBkgndColor.Size = new System.Drawing.Size(90, 25);
            this.btnBkgndColor.TabIndex = 0;
            this.btnBkgndColor.Tag = "0";
            this.btnBkgndColor.Text = "Choose...";
            this.btnBkgndColor.UseVisualStyleBackColor = true;
            this.btnBkgndColor.Click += new System.EventHandler(this.btnColor_Click);
            //
            // lblNormalColor
            //
            this.lblNormalColor.AutoSize = true;
            this.lblNormalColor.Location = new System.Drawing.Point(16, 68);
            this.lblNormalColor.Name = "lblNormalColor";
            this.lblNormalColor.Size = new System.Drawing.Size(44, 13);
            this.lblNormalColor.Text = "Normal:";
            //
            // pnNormalColor
            //
            this.pnNormalColor.BackColor = System.Drawing.Color.Lime;
            this.pnNormalColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnNormalColor.Location = new System.Drawing.Point(100, 62);
            this.pnNormalColor.Name = "pnNormalColor";
            this.pnNormalColor.Size = new System.Drawing.Size(200, 24);
            //
            // btnNormalColor
            //
            this.btnNormalColor.Location = new System.Drawing.Point(312, 62);
            this.btnNormalColor.Name = "btnNormalColor";
            this.btnNormalColor.Size = new System.Drawing.Size(90, 25);
            this.btnNormalColor.TabIndex = 1;
            this.btnNormalColor.Tag = "1";
            this.btnNormalColor.Text = "Choose...";
            this.btnNormalColor.UseVisualStyleBackColor = true;
            this.btnNormalColor.Click += new System.EventHandler(this.btnColor_Click);
            //
            // lblWarningColor
            //
            this.lblWarningColor.AutoSize = true;
            this.lblWarningColor.Location = new System.Drawing.Point(16, 108);
            this.lblWarningColor.Name = "lblWarningColor";
            this.lblWarningColor.Size = new System.Drawing.Size(50, 13);
            this.lblWarningColor.Text = "Warning:";
            //
            // pnWarningColor
            //
            this.pnWarningColor.BackColor = System.Drawing.Color.Yellow;
            this.pnWarningColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnWarningColor.Location = new System.Drawing.Point(100, 102);
            this.pnWarningColor.Name = "pnWarningColor";
            this.pnWarningColor.Size = new System.Drawing.Size(200, 24);
            //
            // btnWarningColor
            //
            this.btnWarningColor.Location = new System.Drawing.Point(312, 102);
            this.btnWarningColor.Name = "btnWarningColor";
            this.btnWarningColor.Size = new System.Drawing.Size(90, 25);
            this.btnWarningColor.TabIndex = 2;
            this.btnWarningColor.Tag = "2";
            this.btnWarningColor.Text = "Choose...";
            this.btnWarningColor.UseVisualStyleBackColor = true;
            this.btnWarningColor.Click += new System.EventHandler(this.btnColor_Click);
            //
            // lblPeakColor
            //
            this.lblPeakColor.AutoSize = true;
            this.lblPeakColor.Location = new System.Drawing.Point(16, 148);
            this.lblPeakColor.Name = "lblPeakColor";
            this.lblPeakColor.Size = new System.Drawing.Size(34, 13);
            this.lblPeakColor.Text = "Peak:";
            //
            // pnPeakColor
            //
            this.pnPeakColor.BackColor = System.Drawing.Color.Red;
            this.pnPeakColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnPeakColor.Location = new System.Drawing.Point(100, 142);
            this.pnPeakColor.Name = "pnPeakColor";
            this.pnPeakColor.Size = new System.Drawing.Size(200, 24);
            //
            // btnPeakColor
            //
            this.btnPeakColor.Location = new System.Drawing.Point(312, 142);
            this.btnPeakColor.Name = "btnPeakColor";
            this.btnPeakColor.Size = new System.Drawing.Size(90, 25);
            this.btnPeakColor.TabIndex = 3;
            this.btnPeakColor.Tag = "3";
            this.btnPeakColor.Text = "Choose...";
            this.btnPeakColor.UseVisualStyleBackColor = true;
            this.btnPeakColor.Click += new System.EventHandler(this.btnColor_Click);
            //
            // tsDrawing
            //
            this.tsDrawing.Controls.Add(this.lblTickSize);
            this.tsDrawing.Controls.Add(this.lblTickInterval);
            this.tsDrawing.Controls.Add(this.lblNeedleThickness);
            this.tsDrawing.Controls.Add(this.lblDrawingHint);
            this.tsDrawing.Controls.Add(this.updTickSize);
            this.tsDrawing.Controls.Add(this.updTickInterval);
            this.tsDrawing.Controls.Add(this.updNeedleThickness);
            this.tsDrawing.Location = new System.Drawing.Point(4, 22);
            this.tsDrawing.Name = "tsDrawing";
            this.tsDrawing.Size = new System.Drawing.Size(446, 462);
            this.tsDrawing.Text = "Drawing";
            this.tsDrawing.UseVisualStyleBackColor = true;
            //
            // lblTickSize
            //
            this.lblTickSize.AutoSize = true;
            this.lblTickSize.Location = new System.Drawing.Point(16, 22);
            this.lblTickSize.Name = "lblTickSize";
            this.lblTickSize.Size = new System.Drawing.Size(50, 13);
            this.lblTickSize.Text = "Tick size:";
            //
            // lblTickInterval
            //
            this.lblTickInterval.AutoSize = true;
            this.lblTickInterval.Location = new System.Drawing.Point(16, 62);
            this.lblTickInterval.Name = "lblTickInterval";
            this.lblTickInterval.Size = new System.Drawing.Size(64, 13);
            this.lblTickInterval.Text = "Tick interval:";
            //
            // lblNeedleThickness
            //
            this.lblNeedleThickness.AutoSize = true;
            this.lblNeedleThickness.Location = new System.Drawing.Point(16, 102);
            this.lblNeedleThickness.Name = "lblNeedleThickness";
            this.lblNeedleThickness.Size = new System.Drawing.Size(112, 13);
            this.lblNeedleThickness.Text = "Needle thickness (px):";
            //
            // lblDrawingHint
            //
            this.lblDrawingHint.Location = new System.Drawing.Point(16, 160);
            this.lblDrawingHint.Name = "lblDrawingHint";
            this.lblDrawingHint.Size = new System.Drawing.Size(410, 60);
            this.lblDrawingHint.Text = "Tick size and tick interval affect mainly the Analog and Analog Vintage meters (l" +
                "ength and spacing of the ticks on the arc).\r\nNeedle thickness controls the analog" +
                " meter needle width in pixels.";
            //
            // updTickSize
            //
            this.updTickSize.Location = new System.Drawing.Point(200, 18);
            this.updTickSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.updTickSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.updTickSize.Name = "updTickSize";
            this.updTickSize.Size = new System.Drawing.Size(76, 20);
            this.updTickSize.TabIndex = 0;
            this.updTickSize.Value = new decimal(new int[] { 6, 0, 0, 0 });
            this.updTickSize.ValueChanged += new System.EventHandler(this.updTickSize_ValueChanged);
            //
            // updTickInterval
            //
            this.updTickInterval.Location = new System.Drawing.Point(200, 58);
            this.updTickInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.updTickInterval.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.updTickInterval.Name = "updTickInterval";
            this.updTickInterval.Size = new System.Drawing.Size(76, 20);
            this.updTickInterval.TabIndex = 1;
            this.updTickInterval.Value = new decimal(new int[] { 10, 0, 0, 0 });
            this.updTickInterval.ValueChanged += new System.EventHandler(this.updTickInterval_ValueChanged);
            //
            // updNeedleThickness
            //
            this.updNeedleThickness.Location = new System.Drawing.Point(200, 98);
            this.updNeedleThickness.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.updNeedleThickness.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.updNeedleThickness.Name = "updNeedleThickness";
            this.updNeedleThickness.Size = new System.Drawing.Size(76, 20);
            this.updNeedleThickness.TabIndex = 2;
            this.updNeedleThickness.Value = new decimal(new int[] { 2, 0, 0, 0 });
            this.updNeedleThickness.ValueChanged += new System.EventHandler(this.updNeedleThickness_ValueChanged);
            //
            // tsBallistics
            //
            this.tsBallistics.Controls.Add(this.lblBallisticProfile);
            this.tsBallistics.Controls.Add(this.cboBallisticProfile);
            this.tsBallistics.Controls.Add(this.lblAttackMs);
            this.tsBallistics.Controls.Add(this.updAttackMs);
            this.tsBallistics.Controls.Add(this.lblReleaseMs);
            this.tsBallistics.Controls.Add(this.updReleaseMs);
            this.tsBallistics.Controls.Add(this.lblPeakHoldMs);
            this.tsBallistics.Controls.Add(this.updPeakHoldMs);
            this.tsBallistics.Controls.Add(this.lblBallisticHint);
            this.tsBallistics.Location = new System.Drawing.Point(4, 22);
            this.tsBallistics.Name = "tsBallistics";
            this.tsBallistics.Size = new System.Drawing.Size(446, 462);
            this.tsBallistics.Text = "Ballistics";
            this.tsBallistics.UseVisualStyleBackColor = true;
            //
            // lblBallisticProfile
            //
            this.lblBallisticProfile.AutoSize = true;
            this.lblBallisticProfile.Location = new System.Drawing.Point(16, 22);
            this.lblBallisticProfile.Name = "lblBallisticProfile";
            this.lblBallisticProfile.Size = new System.Drawing.Size(68, 13);
            this.lblBallisticProfile.Text = "Quick preset:";
            //
            // cboBallisticProfile
            //
            this.cboBallisticProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBallisticProfile.Location = new System.Drawing.Point(120, 18);
            this.cboBallisticProfile.Name = "cboBallisticProfile";
            this.cboBallisticProfile.Size = new System.Drawing.Size(280, 21);
            this.cboBallisticProfile.TabIndex = 0;
            this.cboBallisticProfile.SelectedIndexChanged += new System.EventHandler(this.cboBallisticProfile_SelectedIndexChanged);
            //
            // lblAttackMs
            //
            this.lblAttackMs.AutoSize = true;
            this.lblAttackMs.Location = new System.Drawing.Point(16, 70);
            this.lblAttackMs.Name = "lblAttackMs";
            this.lblAttackMs.Size = new System.Drawing.Size(64, 13);
            this.lblAttackMs.Text = "Attack (ms):";
            //
            // updAttackMs
            //
            this.updAttackMs.Location = new System.Drawing.Point(200, 66);
            this.updAttackMs.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.updAttackMs.Name = "updAttackMs";
            this.updAttackMs.Size = new System.Drawing.Size(96, 20);
            this.updAttackMs.TabIndex = 1;
            this.updAttackMs.Value = new decimal(new int[] { 10, 0, 0, 0 });
            this.updAttackMs.ValueChanged += new System.EventHandler(this.updAttackMs_ValueChanged);
            //
            // lblReleaseMs
            //
            this.lblReleaseMs.AutoSize = true;
            this.lblReleaseMs.Location = new System.Drawing.Point(16, 110);
            this.lblReleaseMs.Name = "lblReleaseMs";
            this.lblReleaseMs.Size = new System.Drawing.Size(70, 13);
            this.lblReleaseMs.Text = "Release (ms):";
            //
            // updReleaseMs
            //
            this.updReleaseMs.Location = new System.Drawing.Point(200, 106);
            this.updReleaseMs.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.updReleaseMs.Name = "updReleaseMs";
            this.updReleaseMs.Size = new System.Drawing.Size(96, 20);
            this.updReleaseMs.TabIndex = 2;
            this.updReleaseMs.Value = new decimal(new int[] { 300, 0, 0, 0 });
            this.updReleaseMs.ValueChanged += new System.EventHandler(this.updReleaseMs_ValueChanged);
            //
            // lblPeakHoldMs
            //
            this.lblPeakHoldMs.AutoSize = true;
            this.lblPeakHoldMs.Location = new System.Drawing.Point(16, 150);
            this.lblPeakHoldMs.Name = "lblPeakHoldMs";
            this.lblPeakHoldMs.Size = new System.Drawing.Size(80, 13);
            this.lblPeakHoldMs.Text = "Peak hold (ms):";
            //
            // updPeakHoldMs
            //
            this.updPeakHoldMs.Location = new System.Drawing.Point(200, 146);
            this.updPeakHoldMs.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.updPeakHoldMs.Name = "updPeakHoldMs";
            this.updPeakHoldMs.Size = new System.Drawing.Size(96, 20);
            this.updPeakHoldMs.TabIndex = 3;
            this.updPeakHoldMs.Value = new decimal(new int[] { 800, 0, 0, 0 });
            this.updPeakHoldMs.ValueChanged += new System.EventHandler(this.updPeakHoldMs_ValueChanged);
            //
            // lblBallisticHint
            //
            this.lblBallisticHint.Location = new System.Drawing.Point(16, 210);
            this.lblBallisticHint.Name = "lblBallisticHint";
            this.lblBallisticHint.Size = new System.Drawing.Size(410, 130);
            this.lblBallisticHint.Text = "Pick a preset to fill the three values at once, or tweak them manually.\r\n\r\n* Attac" +
                "k: time constant for level rises (lower = peakier).\r\n* Release: time constant for" +
                " level falls (lower = bouncier).\r\n* Peak hold: time the peak LED stays lit after " +
                "a peak (0 disables it).\r\n\r\nDefaults: 10 / 300 / 800 ms (dynamic, snappy look).";
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(8, 506);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(169, 25);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh from TVideoGrabber";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // btnClose
            //
            this.btnClose.Location = new System.Drawing.Point(376, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // VUMeterConfigForm
            //
            this.ClientSize = new System.Drawing.Size(470, 540);
            this.Controls.Add(this.pcMain);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VUMeterConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure VU-Meters";
            this.pcMain.ResumeLayout(false);
            this.tsType.ResumeLayout(false);
            this.tsType.PerformLayout();
            this.grbDisplayOptions.ResumeLayout(false);
            this.grbOverlayRect.ResumeLayout(false);
            this.grbOverlayRect.PerformLayout();
            this.tsLevelsColors.ResumeLayout(false);
            this.grbWarningPercent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrWarningPercent)).EndInit();
            this.grbPeakPercent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrPeakPercent)).EndInit();
            this.grbColors.ResumeLayout(false);
            this.grbColors.PerformLayout();
            this.tsDrawing.ResumeLayout(false);
            this.tsDrawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTickSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updTickInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updNeedleThickness)).EndInit();
            this.tsBallistics.ResumeLayout(false);
            this.tsBallistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updAttackMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updReleaseMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPeakHoldMs)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
