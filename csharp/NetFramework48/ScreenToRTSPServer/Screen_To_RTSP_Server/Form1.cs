using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VidGrab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Screen_To_RTSP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VideoGrabber vgMPE;

        private void btnPushToRTSPServer_Click(object sender, EventArgs e)
        {
            if (vgMPE == null)
            {
                vgMPE = new VideoGrabber();
                if (chkShowPreview.Checked)
                {
                    vgMPE.Parent = panelPush;
                }
                else
                {
                    vgMPE.VideoRenderer = TVideoRenderer.vr_None;
                }
                vgMPE.VideoSource = TVideoSource.vs_ScreenRecording;
                vgMPE.EnableMultipurposeEncoder(TMultipurposeEncoderInstance.mpe_Streaming, true);
                vgMPE.UseNearestVideoSize(1920, 1080, true);
            }
            else
            {
                vgMPE.Stop();
            }
            vgMPE.Encoder_SetInt(1, TEncoder_int.Enc_IsActive_bool, 1);
            vgMPE.Encoder_SetStr(1, TEncoder_str.Enc_OutputURL, URL.Text);
            vgMPE.Encoder_SetInt(1, TEncoder_int.Enc_Video_Enabled_bool, 1);
            vgMPE.Encoder_SetInt(1, TEncoder_int.Enc_Video_IDR_Interval, 10);
            vgMPE.Encoder_SetStr(1, TEncoder_str.Enc_Video_Codec, "h264");
            vgMPE.Encoder_SetInt(1, TEncoder_int.Enc_Video_GPU_Encoder, (int)TGPUEncoder.Enc_GPU_NVidia_NVENC);
            vgMPE.Encoder_SetInt(1, TEncoder_int.Enc_Video_GPU_Encoder, (int)TGPUEncoder.Enc_GPU_Intel_QSV);
            vgMPE.StartPreview();
        }

        VideoGrabber vgRTSPsrc;
        private void btnPlayFromRTSPServer_Click(object sender, EventArgs e)
        {
            if (vgRTSPsrc == null)
            {
                vgRTSPsrc = new VideoGrabber();
                vgRTSPsrc.Parent = panelReceive;
                vgRTSPsrc.VideoSource = TVideoSource.vs_IPCamera;
                vgRTSPsrc.FrameGrabber = TFrameGrabber.fg_Disabled;
            }
            else
            {
                vgRTSPsrc.Stop();
            }
            vgRTSPsrc.IPCameraURL = URL.Text;
            vgRTSPsrc.StartPreview();
            }
    }
}
