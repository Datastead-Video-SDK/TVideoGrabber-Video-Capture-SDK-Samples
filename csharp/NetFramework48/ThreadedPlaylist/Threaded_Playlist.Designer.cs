

namespace ThreadedPlaylist
{
    partial class Threaded_Playlist
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClosePlaylist = new System.Windows.Forms.Button();
            this.btnCaptureToControl = new System.Windows.Forms.Button();
            this.btnCaptureToPng = new System.Windows.Forms.Button();
            this.imgCapturedFrame = new System.Windows.Forms.PictureBox();
            this.lstPlayList = new System.Windows.Forms.ListBox();
            this.btnAddClip = new System.Windows.Forms.Button();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableFullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullScreenEnableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullScreenDisableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedAdd05toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedSub05toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fastForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FFx2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FFx4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastRewindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.REWx2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.REWx4ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playBackwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.playListControl1 = new VidGrab.PlayListControl();
            this.tbrPlayer = new System.Windows.Forms.TrackBar();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapturedFrame)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(139, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 22);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start playlist";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnOpenPlayer_Click);
            // 
            // btnClosePlaylist
            // 
            this.btnClosePlaylist.Location = new System.Drawing.Point(873, 11);
            this.btnClosePlaylist.Name = "btnClosePlaylist";
            this.btnClosePlaylist.Size = new System.Drawing.Size(81, 22);
            this.btnClosePlaylist.TabIndex = 3;
            this.btnClosePlaylist.Text = "Close playlist";
            this.btnClosePlaylist.UseVisualStyleBackColor = true;
            this.btnClosePlaylist.Click += new System.EventHandler(this.btnClosePlaylist_Click);
            // 
            // btnCaptureToControl
            // 
            this.btnCaptureToControl.Location = new System.Drawing.Point(702, 199);
            this.btnCaptureToControl.Name = "btnCaptureToControl";
            this.btnCaptureToControl.Size = new System.Drawing.Size(104, 22);
            this.btnCaptureToControl.TabIndex = 4;
            this.btnCaptureToControl.Text = "Capture frame";
            this.btnCaptureToControl.UseVisualStyleBackColor = true;
            this.btnCaptureToControl.Click += new System.EventHandler(this.btnCaptureToControl_Click);
            // 
            // btnCaptureToPng
            // 
            this.btnCaptureToPng.Location = new System.Drawing.Point(824, 199);
            this.btnCaptureToPng.Name = "btnCaptureToPng";
            this.btnCaptureToPng.Size = new System.Drawing.Size(133, 22);
            this.btnCaptureToPng.TabIndex = 5;
            this.btnCaptureToPng.Text = "Capture frame to png file";
            this.btnCaptureToPng.UseVisualStyleBackColor = true;
            this.btnCaptureToPng.Click += new System.EventHandler(this.btnCaptureToPng_Click);
            // 
            // imgCapturedFrame
            // 
            this.imgCapturedFrame.BackColor = System.Drawing.SystemColors.Control;
            this.imgCapturedFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgCapturedFrame.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgCapturedFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgCapturedFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imgCapturedFrame.Location = new System.Drawing.Point(702, 227);
            this.imgCapturedFrame.Name = "imgCapturedFrame";
            this.imgCapturedFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.imgCapturedFrame.Size = new System.Drawing.Size(255, 171);
            this.imgCapturedFrame.TabIndex = 59;
            this.imgCapturedFrame.TabStop = false;
            // 
            // lstPlayList
            // 
            this.lstPlayList.FormattingEnabled = true;
            this.lstPlayList.Location = new System.Drawing.Point(12, 43);
            this.lstPlayList.Name = "lstPlayList";
            this.lstPlayList.Size = new System.Drawing.Size(243, 485);
            this.lstPlayList.TabIndex = 60;
            this.lstPlayList.Click += new System.EventHandler(this.lstPlayList_Click);
            // 
            // btnAddClip
            // 
            this.btnAddClip.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClip.Location = new System.Drawing.Point(51, 11);
            this.btnAddClip.Name = "btnAddClip";
            this.btnAddClip.Size = new System.Drawing.Size(81, 23);
            this.btnAddClip.TabIndex = 61;
            this.btnAddClip.Text = "Add clip...";
            this.btnAddClip.Click += new System.EventHandler(this.btnPlaylistAdd_Click);
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.Location = new System.Drawing.Point(226, 14);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(102, 17);
            this.chkLoop.TabIndex = 62;
            this.chkLoop.Text = "Loop indefinitely";
            this.chkLoop.UseVisualStyleBackColor = true;
            this.chkLoop.CheckedChanged += new System.EventHandler(this.chkLoop_CheckedChanged);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(702, 43);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(255, 150);
            this.txtLog.TabIndex = 65;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(702, 11);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(81, 22);
            this.btnPause.TabIndex = 66;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(789, 11);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(81, 22);
            this.btnResume.TabIndex = 67;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableFullScreenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fastForwardToolStripMenuItem,
            this.fastRewindToolStripMenuItem,
            this.playNormalToolStripMenuItem,
            this.playBackwardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 136);
            // 
            // enableFullScreenToolStripMenuItem
            // 
            this.enableFullScreenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullScreenEnableToolStripMenuItem,
            this.FullScreenDisableToolStripMenuItem});
            this.enableFullScreenToolStripMenuItem.Name = "enableFullScreenToolStripMenuItem";
            this.enableFullScreenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.enableFullScreenToolStripMenuItem.Text = "Full screen";
            // 
            // FullScreenEnableToolStripMenuItem
            // 
            this.FullScreenEnableToolStripMenuItem.Name = "FullScreenEnableToolStripMenuItem";
            this.FullScreenEnableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.FullScreenEnableToolStripMenuItem.Text = "Enable";
            this.FullScreenEnableToolStripMenuItem.Click += new System.EventHandler(this.FullScreenEnableToolStripMenuItem_Click);
            // 
            // FullScreenDisableToolStripMenuItem
            // 
            this.FullScreenDisableToolStripMenuItem.Name = "FullScreenDisableToolStripMenuItem";
            this.FullScreenDisableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.FullScreenDisableToolStripMenuItem.Text = "Disable";
            this.FullScreenDisableToolStripMenuItem.Click += new System.EventHandler(this.FullScreenDisableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpeedAdd05toolStripMenuItem3,
            this.SpeedSub05toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem1.Text = "Speed";
            // 
            // SpeedAdd05toolStripMenuItem3
            // 
            this.SpeedAdd05toolStripMenuItem3.Name = "SpeedAdd05toolStripMenuItem3";
            this.SpeedAdd05toolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.SpeedAdd05toolStripMenuItem3.Text = "+ 0.5";
            this.SpeedAdd05toolStripMenuItem3.Click += new System.EventHandler(this.SpeedAdd05toolStripMenuItem3_Click);
            // 
            // SpeedSub05toolStripMenuItem4
            // 
            this.SpeedSub05toolStripMenuItem4.Name = "SpeedSub05toolStripMenuItem4";
            this.SpeedSub05toolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
            this.SpeedSub05toolStripMenuItem4.Text = "- 0.5";
            this.SpeedSub05toolStripMenuItem4.Click += new System.EventHandler(this.SpeedSub05toolStripMenuItem4_Click);
            // 
            // fastForwardToolStripMenuItem
            // 
            this.fastForwardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FFx2ToolStripMenuItem,
            this.FFx4ToolStripMenuItem});
            this.fastForwardToolStripMenuItem.Name = "fastForwardToolStripMenuItem";
            this.fastForwardToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.fastForwardToolStripMenuItem.Text = "Fast Forward";
            // 
            // FFx2ToolStripMenuItem
            // 
            this.FFx2ToolStripMenuItem.Name = "FFx2ToolStripMenuItem";
            this.FFx2ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.FFx2ToolStripMenuItem.Text = "x 2";
            this.FFx2ToolStripMenuItem.Click += new System.EventHandler(this.FFx2ToolStripMenuItem_Click);
            // 
            // FFx4ToolStripMenuItem
            // 
            this.FFx4ToolStripMenuItem.Name = "FFx4ToolStripMenuItem";
            this.FFx4ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.FFx4ToolStripMenuItem.Text = "x 4";
            this.FFx4ToolStripMenuItem.Click += new System.EventHandler(this.FFx4ToolStripMenuItem_Click);
            // 
            // fastRewindToolStripMenuItem
            // 
            this.fastRewindToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.REWx2ToolStripMenuItem1,
            this.REWx4ToolStripMenuItem1});
            this.fastRewindToolStripMenuItem.Name = "fastRewindToolStripMenuItem";
            this.fastRewindToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.fastRewindToolStripMenuItem.Text = "Fast Rewind";
            // 
            // REWx2ToolStripMenuItem1
            // 
            this.REWx2ToolStripMenuItem1.Name = "REWx2ToolStripMenuItem1";
            this.REWx2ToolStripMenuItem1.Size = new System.Drawing.Size(88, 22);
            this.REWx2ToolStripMenuItem1.Text = "x 2";
            this.REWx2ToolStripMenuItem1.Click += new System.EventHandler(this.REWx2ToolStripMenuItem1_Click);
            // 
            // REWx4ToolStripMenuItem1
            // 
            this.REWx4ToolStripMenuItem1.Name = "REWx4ToolStripMenuItem1";
            this.REWx4ToolStripMenuItem1.Size = new System.Drawing.Size(88, 22);
            this.REWx4ToolStripMenuItem1.Text = "x 4";
            this.REWx4ToolStripMenuItem1.Click += new System.EventHandler(this.REWx4ToolStripMenuItem1_Click);
            // 
            // playNormalToolStripMenuItem
            // 
            this.playNormalToolStripMenuItem.Name = "playNormalToolStripMenuItem";
            this.playNormalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.playNormalToolStripMenuItem.Text = "Play normal";
            this.playNormalToolStripMenuItem.Click += new System.EventHandler(this.playNormalToolStripMenuItem_Click);
            // 
            // playBackwardToolStripMenuItem
            // 
            this.playBackwardToolStripMenuItem.Name = "playBackwardToolStripMenuItem";
            this.playBackwardToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.playBackwardToolStripMenuItem.Text = "Play backward";
            this.playBackwardToolStripMenuItem.Click += new System.EventHandler(this.playBackwardToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(348, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "the control supports the contextMenuStrip (right-click for demo)";
            // 
            // playListControl1
            // 
            this.playListControl1.BackColor = System.Drawing.Color.Gray;
            this.playListControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.playListControl1.Location = new System.Drawing.Point(261, 43);
            this.playListControl1.Name = "playListControl1";
            this.playListControl1.Size = new System.Drawing.Size(435, 355);
            this.playListControl1.TabIndex = 63;
            this.playListControl1.OnPrepareNextClip += new VidGrab.PlayListControl.OnNextClipHandler(this.playListControl1_OnPrepareNextClip);
            this.playListControl1.OnNextClipPlaying += new VidGrab.PlayListControl.OnNextClipHandler(this.playListControl1_OnNextClipPlaying);
            this.playListControl1.OnConfigureVideoGrabber += new VidGrab.PlayListControl.OnConfigureVideoGrabberHandler(this.playListControl1_OnConfigureVideoGrabber);
            // 
            // tbrPlayer
            // 
            this.tbrPlayer.Location = new System.Drawing.Point(261, 404);
            this.tbrPlayer.Name = "tbrPlayer";
            this.tbrPlayer.Size = new System.Drawing.Size(435, 45);
            this.tbrPlayer.TabIndex = 69;
            this.tbrPlayer.Scroll += new System.EventHandler(this.tbrPlayer_Scroll);
            this.tbrPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbrPlayer_KeyDown);
            this.tbrPlayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbrPlayer_KeyUp);
            this.tbrPlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbrPlayer_MouseDown);
            this.tbrPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbrPlayer_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(42, 24);
            this.btnClear.TabIndex = 70;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Threaded_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 533);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbrPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.playListControl1);
            this.Controls.Add(this.chkLoop);
            this.Controls.Add(this.btnAddClip);
            this.Controls.Add(this.lstPlayList);
            this.Controls.Add(this.imgCapturedFrame);
            this.Controls.Add(this.btnCaptureToPng);
            this.Controls.Add(this.btnCaptureToControl);
            this.Controls.Add(this.btnClosePlaylist);
            this.Controls.Add(this.btnStart);
            this.Name = "Threaded_Playlist";
            this.Text = "Threaded_Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.imgCapturedFrame)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClosePlaylist;
        private System.Windows.Forms.Button btnCaptureToControl;
        private System.Windows.Forms.Button btnCaptureToPng;
        public System.Windows.Forms.PictureBox imgCapturedFrame;
        private System.Windows.Forms.ListBox lstPlayList;
        internal System.Windows.Forms.Button btnAddClip;
        private System.Windows.Forms.CheckBox chkLoop;
        private VidGrab.PlayListControl playListControl1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enableFullScreenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem FullScreenEnableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullScreenDisableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SpeedAdd05toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem SpeedSub05toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem fastForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FFx2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FFx4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastRewindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem REWx2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem REWx4ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playBackwardToolStripMenuItem;
        private System.Windows.Forms.TrackBar tbrPlayer;
        private System.Windows.Forms.Button btnClear;
    }
}

