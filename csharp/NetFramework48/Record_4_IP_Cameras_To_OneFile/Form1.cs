using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VidGrab;

namespace Record_4_IP_Cameras_To_OneFile
{
    public partial class Form1 : Form
    {
        const int NB_COLUMNS = 3;
        const int NB_LINES = 2;
        // NB_COLUMNS and NB_LINES determine the number of IP cameras (3x2 = 6) and their layout on the grid (2 lines of 3 cameras)

        const int VGCOUNT = NB_COLUMNS * NB_LINES;
        const int VGSTART = VGCOUNT;

        VideoGrabber[] Cameras = new VideoGrabber[VGCOUNT];

        //!!!! REPLACE_THE_SAMPLE_URLS_BELOW_BY_THE_URLS_TO_TEST

        public string[] URLs = {
            SPECIFY YOUR IP CAMERA URLS HERE
            "onvif://admin:root@192.168.0.148",
            "onvif://admin:root@192.168.0.148",
            "onvif://admin:root@192.168.0.148",
            "onvif://admin:root@192.168.0.148",
            "onvif://admin:root@192.168.0.148",
            "onvif://admin:root@192.168.0.148",
        };

        public Form1()
        {
            InitializeComponent();

            videoMixer.VideoSource = TVideoSource.vs_Mixer;
            videoMixer.UseNearestVideoSize(1280, 640, true); // fixes the size of the mixer window that will display the 2x3 cameras
            videoMixer.Mixer_MosaicLines = NB_LINES;
            videoMixer.Mixer_MosaicColumns = NB_COLUMNS;
            videoMixer.OnLog += Mixer_OnLog;

            /* set the output folder as default folder for the recordings */
            videoMixer.StoragePath = Environment.CurrentDirectory;
            txtStoragePath.Text = videoMixer.StoragePath;

            videoMixer.StartPreview();


            int iCam = 0;
            for (int iLine = 0; iLine < NB_LINES; iLine++)
            {
                for (int iColumn = 0; iColumn < NB_COLUMNS; iColumn++) 
                {
                    Cameras[iCam] = new VideoGrabber();

                    /* says the mixer to put Cameras[iCam] source to its respective iLine / iColumn in the 2 x 2 layout */
                    videoMixer.Mixer_AddToMixer(Cameras[iCam].UniqueID, 0, iLine + 1, iColumn + 1, 0, 0, true, false);

                    /* start the IP camera */
                    Cameras[iCam].VideoSource = TVideoSource.vs_IPCamera;
                    Cameras[iCam].IPCameraURL = URLs[iCam];
                    Cameras[iCam].VideoRenderer = TVideoRenderer.vr_None; // in this demo no need to display each source out of the mixer
                    Cameras[iCam].StartPreview();

                    iCam ++;
                }
            }

            Cameras[0].OnLog += Cam1_OnLog;
            Cameras[1].OnLog += Cam2_OnLog;
            Cameras[2].OnLog += Cam3_OnLog;
            Cameras[3].OnLog += Cam4_OnLog;
        }

        private void btnStartPreview_Click(object sender, EventArgs e)
        {
            videoMixer.StartPreview();
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            videoMixer.RecordingMethod = TRecordingMethod.rm_ASF;
            videoMixer.ASFVideoBitRate = 20000000;
                videoMixer.StartRecording();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            videoMixer.Stop();
        }

        private void Mixer_OnLog(object sender, TOnLogEventArgs e)
        {
            AddLog(MixerLog, e.infoMsg);
        }
        private void Cam1_OnLog(object sender, TOnLogEventArgs e)
        {
            AddLog(txBoxCam1Log, e.infoMsg);
        }
        private void Cam2_OnLog(object sender, TOnLogEventArgs e)
        {
            AddLog(txBoxCam2Log, e.infoMsg);
        }

        private void Cam3_OnLog(object sender, TOnLogEventArgs e)
        {
            AddLog(txBoxCam3Log, e.infoMsg);
        }
        private void Cam4_OnLog(object sender, TOnLogEventArgs e)
        {
            AddLog(txBoxCam4Log, e.infoMsg);
        }

        private void AddLog(System.Windows.Forms.TextBox TxtBox, string Line)
        {
            TxtBox.Text += "\r\n" + Line;
            TxtBox.Select(TxtBox.Text.Length - 1, 0);
            TxtBox.ScrollToCaret();
        }

        private void txtStoragePath_TextChanged(object sender, EventArgs e)
        {
            videoMixer.StoragePath = txtStoragePath.Text;
        }

        private void btnPlayLastRecording_Click(object sender, EventArgs e)
        {
            videoMixer.Stop();
            videoMixer.PlayerFileName = videoMixer.Last_Recording_FileName;
            videoMixer.OpenPlayer();
        }
    }
}
