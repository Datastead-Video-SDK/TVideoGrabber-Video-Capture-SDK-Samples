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
        private System.Windows.Forms.Button btnCreateComponent;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Button btnDestroyComponent;
        private System.Windows.Forms.Button btnStartPreview;
        private System.Windows.Forms.Button btnStopPreview;
        private Button btnStartScreenCapture;
        private VidGrab.VideoGrabber VideoGrabber;

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
            this.btnCreateComponent = new System.Windows.Forms.Button();
            this.btnDestroyComponent = new System.Windows.Forms.Button();
            this.btnStartPreview = new System.Windows.Forms.Button();
            this.btnStopPreview = new System.Windows.Forms.Button();
            this.btnStartScreenCapture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateComponent
            // 
            this.btnCreateComponent.Location = new System.Drawing.Point(14, 14);
            this.btnCreateComponent.Name = "btnCreateComponent";
            this.btnCreateComponent.Size = new System.Drawing.Size(134, 28);
            this.btnCreateComponent.TabIndex = 0;
            this.btnCreateComponent.Text = "Create component";
            this.btnCreateComponent.Click += new System.EventHandler(this.btnCreateComponent_Click);
            // 
            // btnDestroyComponent
            // 
            this.btnDestroyComponent.Location = new System.Drawing.Point(735, 14);
            this.btnDestroyComponent.Name = "btnDestroyComponent";
            this.btnDestroyComponent.Size = new System.Drawing.Size(206, 28);
            this.btnDestroyComponent.TabIndex = 1;
            this.btnDestroyComponent.Text = "4. Destroy component";
            this.btnDestroyComponent.Click += new System.EventHandler(this.btnDestroyComponent_Click);
            // 
            // btnStartPreview
            // 
            this.btnStartPreview.Location = new System.Drawing.Point(155, 14);
            this.btnStartPreview.Name = "btnStartPreview";
            this.btnStartPreview.Size = new System.Drawing.Size(219, 28);
            this.btnStartPreview.TabIndex = 2;
            this.btnStartPreview.Text = "2. Start preview of webcam if avail";
            this.btnStartPreview.Click += new System.EventHandler(this.btnStartPreview_Click);
            // 
            // btnStopPreview
            // 
            this.btnStopPreview.Location = new System.Drawing.Point(605, 14);
            this.btnStopPreview.Name = "btnStopPreview";
            this.btnStopPreview.Size = new System.Drawing.Size(123, 28);
            this.btnStopPreview.TabIndex = 3;
            this.btnStopPreview.Text = "3. Stop Preview";
            this.btnStopPreview.Click += new System.EventHandler(this.btnStopPreview_Click);
            // 
            // btnStartScreenCapture
            // 
            this.btnStartScreenCapture.Location = new System.Drawing.Point(380, 14);
            this.btnStartScreenCapture.Name = "btnStartScreenCapture";
            this.btnStartScreenCapture.Size = new System.Drawing.Size(219, 28);
            this.btnStartScreenCapture.TabIndex = 4;
            this.btnStartScreenCapture.Text = "2. Start screen capture";
            this.btnStartScreenCapture.Click += new System.EventHandler(this.btnStartScreenCapture_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1000, 684);
            this.Controls.Add(this.btnStartScreenCapture);
            this.Controls.Add(this.btnStopPreview);
            this.Controls.Add(this.btnStartPreview);
            this.Controls.Add(this.btnDestroyComponent);
            this.Controls.Add(this.btnCreateComponent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

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
            if (VideoGrabber == null) {
                VideoGrabber = new VidGrab.VideoGrabber();

                VideoGrabber.Parent = this;
                VideoGrabber.Left = 10;
                VideoGrabber.Top = 50;

                VideoGrabber.OnPreviewStarted += new System.EventHandler(this.OnPreviewStarted);
                VideoGrabber.OnInactive += new System.EventHandler(this.OnInactive);
            }
            else {
                MessageBox.Show("already created");
            }
       }

        private void btnStartPreview_Click(object sender, EventArgs e)
            {
            if (VideoGrabber != null) {
                VideoGrabber.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
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

        private void btnStartScreenCapture_Click(object sender, EventArgs e)
        {
            if (VideoGrabber != null)
            {
                VideoGrabber.VideoSource = VidGrab.TVideoSource.vs_ScreenRecording;
                VideoGrabber.StartPreview();
            }
            else
            {
                MessageBox.Show("first create the component");
            }

        }
    }
    }


