using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestAppUsingVideoGrabber
    {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
        {
        private System.Windows.Forms.Button btnStartProcess;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private TextBox mmoLog;
        private Label label1;
        private VidGrab.VideoGrabber VideoGrabber = new VidGrab.VideoGrabber();

        public Form1()
            {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
            {
            if (disposing)
                {
                if (components != null)
                    {
                    components.Dispose();
                    }
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
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.mmoLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(14, 14);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(134, 28);
            this.btnStartProcess.TabIndex = 0;
            this.btnStartProcess.Text = "Start process";
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // mmoLog
            // 
            this.mmoLog.Location = new System.Drawing.Point(14, 96);
            this.mmoLog.Multiline = true;
            this.mmoLog.Name = "mmoLog";
            this.mmoLog.Size = new System.Drawing.Size(597, 415);
            this.mmoLog.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "log:";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1000, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mmoLog);
            this.Controls.Add(this.btnStartProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
            {
            Application.Run(new Form1());
            }

        private void OnPreviewStarted(object sender, System.EventArgs e)
            {
            MessageBox.Show("preview started");
            }

        private void OnInactive(object sender, System.EventArgs e)
            {
            MessageBox.Show("done");
            }

        private void btnCreateComponent_Click(object sender, EventArgs e)
            {

        }

        private void btnStartPreview_Click(object sender, EventArgs e)
            {
            if (VideoGrabber != null) {
                VideoGrabber.StartPreview();
            }
            else {
                MessageBox.Show ("first create the component");
            }
        }

        private void btnStopPreview_Click(object sender, EventArgs e)
            {
                if (VideoGrabber != null) {
                    VideoGrabber.Stop();
                }
                else {
                    MessageBox.Show ("first create the component");
                }
            }

        private void btnDestroyComponent_Click(object sender, EventArgs e)
            {
            if (VideoGrabber != null)
                {
                VideoGrabber.Dispose();
                VideoGrabber = null;
                }
            else
                {
                MessageBox.Show("component not yet created");
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            VideoGrabber.OnLog += VideoGrabber_OnLog;
            VideoGrabber.OnReencodingStarted += VideoGrabber_OnReencodingStarted;
            VideoGrabber.OnReencodingProgress += VideoGrabber_OnReencodingProgress;
            VideoGrabber.OnReencodingCompleted += VideoGrabber_OnReencodingCompleted;
        }

        private void VideoGrabber_OnLog(object sender, VidGrab.TOnLogEventArgs e)
        {
            AddLog(mmoLog, "[" + e.severity + "] " + e.infoMsg);
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            VideoGrabber.FrameGrabber = VidGrab.TFrameGrabber.fg_Disabled;
            VideoGrabber.Reencoding_SourceVideoClip = @"J:\_videos\mike_obrien_pb_fr_9.1.1.2_VGS_161013_125100_999990.avi";
            VideoGrabber.Reencoding_NewVideoClip = @"k:\temp\result.mp4";
            string CommandLine = "ffmpegLGPL.exe -i " + VideoGrabber.Reencoding_SourceVideoClip + " -c copy " + VideoGrabber.Reencoding_NewVideoClip;

            VideoGrabber.EnableMultipurposeEncoder(VidGrab.TMultipurposeEncoderInstance.mpe_Reencoding, true);
            VideoGrabber.SetMultipurposeEncoderSettings(VidGrab.TMultipurposeEncoderInstance.mpe_Reencoding, CommandLine);
            MessageBox.Show(CommandLine);
            VideoGrabber.StartReencoding();

        }

        public static void AddLog(System.Windows.Forms.TextBox TxtBox, string Line)
        {
            TxtBox.AppendText(Environment.NewLine + Line);
        }

        private void VideoGrabber_OnReencodingCompleted(object sender, VidGrab.TOnSourceFileToDestFileCompletedEventArgs e)
        {
            if (e.success)
            {
                AddLog(mmoLog, " successfully reencoded to " + e.destFile);
            }
            else
            {
                AddLog(mmoLog, "Failed to reencode " + e.sourceFile + " to " + e.destFile);
            }
        }

        private void VideoGrabber_OnReencodingProgress(object sender, VidGrab.TOnProgressEventArgs e)
        {
            AddLog(mmoLog, e.percent.ToString() + "% completed...");
        }

        private void VideoGrabber_OnReencodingStarted(object sender, VidGrab.TOnSourceFileToDestFileStartedEventArgs e)
        {
            AddLog(mmoLog, "reencoding " + e.sourceFile + " to " + e.destFile + "...");
        }
    }
    }


