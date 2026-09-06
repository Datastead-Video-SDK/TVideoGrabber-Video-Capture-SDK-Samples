using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VidGrab;

namespace ScreenWithWebcamPIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VideoGrabber videoGrabber1 = new VideoGrabber();
        VideoGrabber videoGrabber2 = new VideoGrabber();
        VideoGrabber videoGrabber3 = new VideoGrabber();

        private void button1_Click(object sender, EventArgs e)
        {
            if (videoGrabber1.Parent == null) 
            {
                videoGrabber1.Parent = panel1; // to make the capture visible for debugging, if needed
            }
            videoGrabber2.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            videoGrabber2.VideoDevice = 0;
            videoGrabber2.Visible = false;
            videoGrabber2.StartPreview();

            videoGrabber3.VideoSource = VidGrab.TVideoSource.vs_ScreenRecording;
            videoGrabber3.UseNearestVideoSize (800, 600, true);
            videoGrabber3.Visible = false;
            videoGrabber3.StartPreview();

            videoGrabber1.VideoSource = VidGrab.TVideoSource.vs_Mixer;
            videoGrabber1.UseNearestVideoSize(1120, 600, true);
            videoGrabber1.Display_AutoSize = false;
            videoGrabber1.BackgroundColor = 0x000044;
            videoGrabber1.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            videoGrabber1.AudioDevice = 0;
            videoGrabber1.AudioRecording = true;
            videoGrabber1.Mixer_SetupPIPFromSource (videoGrabber2.UniqueID, 0, 0, 0, 0, true, 800, 0, 320, 240, true);
            videoGrabber1.Mixer_SetupPIPFromSource (videoGrabber3.UniqueID, 0, 0, 0, 0, true, 0, 0, 800, 600, true);
            videoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_ASF;
            videoGrabber1.StartRecording();
        }

    }
}
