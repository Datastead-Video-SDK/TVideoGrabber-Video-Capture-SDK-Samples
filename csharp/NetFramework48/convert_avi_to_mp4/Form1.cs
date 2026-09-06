using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using VidGrab;

namespace convert_avi_to_mp4
{
    public partial class Form1 : Form
    {

        private VideoGrabber videoGrabber1 = new VideoGrabber();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoGrabber1.OnLog += VideoGrabber_OnLog;
            videoGrabber1.OnReencodingStarted += VideoGrabber_OnReencodingStarted;
            videoGrabber1.OnReencodingProgress += VideoGrabber_OnReencodingProgress;
            videoGrabber1.OnReencodingCompleted += VideoGrabber_OnReencodingCompleted;
        }
        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            videoGrabber1.FrameGrabber = VidGrab.TFrameGrabber.fg_Disabled;

            videoGrabber1.Reencoding_SourceVideoClip = @"c:\folder\yoursourceclip.avi";
            videoGrabber1.Reencoding_NewVideoClip = @"c:\folder\thetargetclip.mp4";

            if (File.Exists(videoGrabber1.Reencoding_SourceVideoClip))
            {

                string CommandLine = "ffmpegLGPL.exe -i " + videoGrabber1.Reencoding_SourceVideoClip + " -c copy " + videoGrabber1.Reencoding_NewVideoClip;

                videoGrabber1.EnableMultipurposeEncoder(VidGrab.TMultipurposeEncoderInstance.mpe_Reencoding, true);
                videoGrabber1.SetMultipurposeEncoderSettings(VidGrab.TMultipurposeEncoderInstance.mpe_Reencoding, CommandLine);
                videoGrabber1.StartReencoding();
            }
            else {
                AddLog(mmoLog, "!!! first modify these 2 lines of code:\r\n\r\nvideoGrabber1.Reencoding_SourceVideoClip\r\nvideoGrabber1.Reencoding_NewVideoClip\r\n\r\nto specify the .avi source file and the .mp4 target file");
            }

        }
        public static void AddLog(System.Windows.Forms.TextBox TxtBox, string Line)
        {
            TxtBox.AppendText(Environment.NewLine + Line);
        }
        private void VideoGrabber_OnReencodingStarted(object sender, TOnSourceFileToDestFileStartedEventArgs e)
        {
            AddLog(mmoLog, "reencoding " + e.sourceFile + " to " + e.destFile + "...");
        }
        private void VideoGrabber_OnReencodingProgress(object sender, TOnProgressEventArgs e)
        {
            AddLog(mmoLog, e.percent.ToString() + "% completed...");
        }
        private void VideoGrabber_OnReencodingCompleted(object sender, TOnSourceFileToDestFileCompletedEventArgs e)
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

        private void VideoGrabber_OnLog(object sender, TOnLogEventArgs e)
        {
            AddLog(mmoLog, "[" + e.severity + "] " + e.infoMsg);
        }
    }
}
