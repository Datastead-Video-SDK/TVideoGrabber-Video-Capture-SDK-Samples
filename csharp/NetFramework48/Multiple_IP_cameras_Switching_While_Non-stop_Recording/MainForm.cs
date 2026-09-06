using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VidGrab;

namespace Record_4_IP_Cameras_To_OneFile
{
    public partial class MainForm : Form
    {
       !!! SPECIFY BELOW YOUR OWN IP CAMERA URLS TO BE SWITCHED, eventually reduce or increase the number of lines
        static string[] cameraURLs = {
            "rtsp://...",
            "rtsp://...",
            "rtsp://...",
            "rtsp://..."
        };

        static int m_cameraCount = cameraURLs.Length;

        private IPCameraForm[] m_camerasForms = new IPCameraForm[m_cameraCount];
        private Button[] m_cameraButtons = new Button[m_cameraCount];

        private const int BUTTON_WIDTH = 60;
        private const int BUTTON_HEIGHT = 25;
        private const int BUTTON_SPACING = 10;
        private const int BUTTON_TOP = 18;
        private const int BUTTON_LEFT_START = 20;

        private void InitializeCameras()
        {
            for (int i = 0; i < m_cameraCount; i++)
            {
                // Create camera form
                m_camerasForms[i] = new IPCameraForm(this, i, cameraURLs[i]);
                m_camerasForms[i].Text = $"IP camera #{i + 1}";

                m_camerasForms[i].vgIPCamera.VideoSource = TVideoSource.vs_IPCamera;
                m_camerasForms[i].vgIPCamera.IPCameraURL = cameraURLs[i];
                m_camerasForms[i].Visible = chkCameraFormsVisible.Checked;
                m_camerasForms[i].vgIPCamera.StartPreview();
                m_camerasForms[i].vgIPCamera.ContinueProcessing();
                m_camerasForms[i].m_mixerId = videoMixer.Mixer_AddToMixer(m_camerasForms[i].vgIPCamera.UniqueID, 0, 0, 0, 0, 0, true, false);

                if (i == 0)
                {
                    videoMixer.Mixer_Activation(m_camerasForms[i].m_mixerId, true);
                }
                else
                {
                    videoMixer.Mixer_Activation(m_camerasForms[i].m_mixerId, false);
                }

                // camera selection button
                Button btn = new Button();
                btn.Parent = SelectCameraGroup;
                btn.Left = BUTTON_LEFT_START + i * (BUTTON_WIDTH + BUTTON_SPACING);
                btn.Top = BUTTON_TOP;
                btn.Width = BUTTON_WIDTH;
                btn.Height = BUTTON_HEIGHT;
                btn.Text = (i + 1).ToString();
                btn.Tag = i;  // Store camera index in Tag
                btn.Click += CameraButton_Click;
                m_cameraButtons[i] = btn;
            }

            SelectCameraGroup.Width = BUTTON_LEFT_START + m_cameraCount * (BUTTON_WIDTH + BUTTON_SPACING) + BUTTON_LEFT_START - BUTTON_SPACING;
        }

        private void CameraButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                chooseActiveCamera((int)btn.Tag);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeCameras();

            videoMixer.VideoSource = TVideoSource.vs_Mixer;
            videoMixer.UseNearestVideoSize(1920, 1080, true);
            videoMixer.OnLog += Mixer_OnLog;

            // set the output folder as default folder for the recordings
            videoMixer.StoragePath = Environment.CurrentDirectory;
            txtStoragePath.Text = videoMixer.StoragePath;

            videoMixer.StartPreview();
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

        public void AddLog(System.Windows.Forms.TextBox TxtBox, string Line)
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

        private void chooseActiveCamera(int index)
        {
            for (int iCam = 0; iCam < m_cameraCount; iCam++)
            {
                videoMixer.Mixer_Activation(m_camerasForms[iCam].m_mixerId, iCam == index);
            }
        }

        private void chkCameraFormsVisible_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < m_cameraCount; i++)
            {
                m_camerasForms[i].Visible = chkCameraFormsVisible.Checked;
            }
        }
    }
}
