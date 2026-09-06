using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Record_4_IP_Cameras_To_OneFile
{
    public partial class IPCameraForm : Form
    {

        private MainForm m_mainForm;  // Store reference to Form1
        private int m_index;
        public int m_mixerId = -1;

        public IPCameraForm(MainForm mainForm, int index, string defaultUrl)
        {
            InitializeComponent();
            this.m_mainForm = mainForm;
            m_index = index;
            txtURL.Text = defaultUrl;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            vgIPCamera.VideoSource = VidGrab.TVideoSource.vs_IPCamera;
            vgIPCamera.IPCameraURL = txtURL.Text;
            vgIPCamera.StartPreview();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            vgIPCamera.StopPreview();
        }

        private void IPCameraForm_Load(object sender, EventArgs e)
        {

        }

        private void vgIPCamera_OnLog(object sender, VidGrab.TOnLogEventArgs e)
        {
            txtLog.Text += "\r\n" + e.infoMsg;
            txtLog.Select(txtLog.Text.Length - 1, 0);
            txtLog.ScrollToCaret();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            vgIPCamera.IPCameraURL = txtURL.Text;
        }
    }
}
