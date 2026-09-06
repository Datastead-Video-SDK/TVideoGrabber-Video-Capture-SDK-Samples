using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VidGrab;

namespace RTSPMultiCamDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int COLUMNS = 4;
        const int LINES = 1;
        const int VGCOUNT = COLUMNS * LINES;

        VideoGrabber[] VideoGrabbers = new VideoGrabber[VGCOUNT];

        !!!! REPLACE_THE_SAMPLE_URLS_BELOW_BY_THE_REAL_URLS_TO_USE and remove_this_line !!!!

        public string[] URLs = {
            "rtsp://192.168.5.38/axis-media/media.amp",
            "onvif://192.168.5.22",
            "onvif://user:password@192.168.5.37",
            "rtsp://192.168.5.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.5.38/axis-media/media.amp",
            "rtsp://192.168.5.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.5.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.5.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.5.25/axis-media/media.amp?videocodec=h264"
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int iCol = 0; iCol < COLUMNS ; iCol++)
            {
                int TopBorder = 42;
                int LeftBorder = 4;
                int ColWidth = (this.Width - 22) / COLUMNS;
                int LineHeight = (this.Height - TopBorder) / LINES;

                for (int iLine = 0; iLine < LINES; iLine++)
                {

                    int vgIndex = (iLine * COLUMNS) + iCol;
                    VideoGrabber vg = new VideoGrabber();

                    Point Location = new Point(LeftBorder + (iCol * ColWidth), TopBorder + (iLine * LineHeight));

                    TextBox tb = new TextBox();
                    tb.Text = URLs[vgIndex];
                    tb.Left = Location.X;
                    tb.Top = Location.Y;
                    tb.Width = ColWidth - 2;

                    vg.Width  = ColWidth - 2;
                    vg.Height = LineHeight - tb.Height - 2;
                    vg.Top = Location.Y + tb.Height + 2;
                    vg.Left = Location.X;

                    SetupVG(vg, URLs[vgIndex]);

                    this.Controls.Add(tb);
                    this.Controls.Add(vg);
                    VideoGrabbers[vgIndex] = vg;
                }
            }
        }

        private void SetupVG(VideoGrabber vg, string URL)
        {
            vg.VideoSource = TVideoSource.vs_IPCamera;
            vg.IPCameraURL = URL;
            vg.IPCameraURL = vg.IPCameraURL + ">buffer=0"; // no buffering
            vg.IPCameraURL = vg.IPCameraURL + ">lowdelay=1"; // low latency
            vg.RecordingMethod = TRecordingMethod.rm_MP4;
            vg.FrameGrabber = TFrameGrabber.fg_Disabled; // saves CPU, but disables the overlays and frame capture capabilities
            vg.Display_AspectRatio = TAspectRatio.ar_Box;
        }

        private void btnStartPreview_Click(object sender, EventArgs e)
        {
            for (int i = 0 ; i < VGCOUNT ; i ++) {
                VideoGrabbers[i].Stop();
                VideoGrabbers[i].StartPreview();
            }
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VGCOUNT; i++)
            {
                VideoGrabbers[i].Stop();
                VideoGrabbers[i].StartRecording();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VGCOUNT; i++)
            {
                VideoGrabbers[i].Stop();
            }
        }
    }
}
