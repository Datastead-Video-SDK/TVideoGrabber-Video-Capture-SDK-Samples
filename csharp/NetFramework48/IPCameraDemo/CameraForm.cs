using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VidGrab;

namespace IPCameraDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int COLUMNS = 4;
        const int LINES = 3;
        const int VGCOUNT = COLUMNS * LINES;
        const int VGSTART = VGCOUNT;

        VideoGrabber[] VideoGrabbers = new VideoGrabber[VGCOUNT];

		//REPLACE THE URLs BELOW BY THE URLs TO TEST
		
        public readonly string[] URLs = {
            "rtmp://stream.smcloud.net/live2/eskatv/eskatv_360p",
            "rtsp://184.72.239.149/vod/mp4:BigBuckBunny_115k.mov",
            "rtsp://91.237.187.3:554/snl/live/1/1",
            "rtsp://50.245.3.117/axis-media/media.amp",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
            "rtsp://192.168.0.25/axis-media/media.amp?videocodec=h264",
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int iCol = 0; iCol < COLUMNS ; iCol++)
            {
                int TopBorder = 40;
                int ColWidth = this.Width / COLUMNS;
                int LineHeight = (this.Height - TopBorder) / LINES;

                for (int iLine = 0; iLine < LINES; iLine++)
                {
                    int vgIndex = (iLine * COLUMNS) + iCol;
                    VideoGrabber vg = new VideoGrabber();
                    vg.Width  = ColWidth - 2;
                    vg.Height = LineHeight - 2;
                    vg.Top = TopBorder + (iLine * LineHeight);
                    vg.Left = iCol * ColWidth;
                    SetupVG(vg, URLs[vgIndex]);

                    this.Controls.Add(vg);
                    VideoGrabbers[vgIndex] = vg;
                }
            }
        }

        private void SetupVG(VideoGrabber vg, string URL)
        {
            vg.VideoSource = TVideoSource.vs_IPCamera;
            vg.IPCameraURL = URL;
            vg.RecordingMethod = TRecordingMethod.rm_MP4;
            vg.FrameGrabber = TFrameGrabber.fg_Disabled; // saves CPU, but disables the overlays and frame capture capabilities
        }

        private void btnStartPreview_Click(object sender, EventArgs e)
        {
            for (int i = 0 ; i < VGSTART ; i ++) {
                VideoGrabbers[i].StartPreview();
            }
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VGSTART; i++)
            {
                VideoGrabbers[i].StartRecording();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VGSTART; i++)
            {
                VideoGrabbers[i].Stop();
            }
        }

    }
}
