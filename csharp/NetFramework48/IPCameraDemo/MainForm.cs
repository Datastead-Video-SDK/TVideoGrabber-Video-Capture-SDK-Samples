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

        private bool m_JpegSnapshotRequest = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRecordingFileName.Text = System.IO.Path.GetTempPath() + "record.mp4";
            txtJpegSnapshotFileName.Text = System.IO.Path.GetTempPath() + "snapshot.jpg";
        }

        private void SetVideoGrabberCameraSettings(VideoGrabber vg)
        {
            vg.VideoSource = TVideoSource.vs_IPCamera;
            vg.IPCameraURL = txtURL.Text;
            vg.SetAuthentication(TAuthenticationType.at_IPCamera, txtUser.Text, txtPassword.Text);
            vg.SetIPCameraSetting(TIPCameraSetting.ips_ConnectionTimeout, Convert.ToInt32(txtConnectionTimeout.Text));
            if (!chkAutoReconnect.Checked)
            {
                vg.IPCameraURL = vg.IPCameraURL + ">autoreconnect=0"; // the optinal filter parameters are listed in the "Parameters identifiers" section of this document: http://www.datastead.com/_releases/rtspdssrc/Datastead_RTSP_DirectShow_Source_Filter.pdf
            }
        }

        private void btnStartPreview_Click(object sender, EventArgs e)
        {
            SetVideoGrabberCameraSettings(videoGrabber1);
            videoGrabber1.StartPreview();
        }

        private void SetVideoGrabberRecordingSettings(VideoGrabber vg)
        {
            if (chkUseRecordingFileName.Checked)
            {
                videoGrabber1.RecordingFileName = txtRecordingFileName.Text;
            }
            else
            {
                videoGrabber1.RecordingFileName = "";
                videoGrabber1.AutoFileName = TAutoFileName.fn_DateTime; // generate a file name automatically based on the date/time
                videoGrabber1.AutoFilePrefix = "Camera01_";
                videoGrabber1.AutoFileNameDateTimeFormat = "yyyyMMddHHmmss";
                videoGrabber1.AutoFileSuffix = "_rec";
            }
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            SetVideoGrabberCameraSettings(videoGrabber1);
            SetVideoGrabberRecordingSettings(videoGrabber1);
            videoGrabber1.RecordingMethod = TRecordingMethod.rm_MP4;
            videoGrabber1.RecordingInNativeFormat = true; // do not decompress/recompress the H264 samples
            if (chkDoNotRecordImmediately.Checked)
            {
                videoGrabber1.HoldRecording = true;
                if (chkIncludeBacktimedRecordingStart.Checked)
                {
                    videoGrabber1.IPCameraURL = videoGrabber1.IPCameraURL + ">backtimedstart=" + Convert.ToInt32(txtBacktimedRecordingStartSeconds.Text);
                }
            }
            videoGrabber1.StartRecording();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            videoGrabber1.Stop();
        }

        private void videoGrabber1_OnDeviceLost(object sender, EventArgs e)
        {
            AddLog(txtInfo, "connection lost!");
        }

        private void videoGrabber1_OnDeviceReconnected(object sender, EventArgs e)
        {
            AddLog(txtInfo, "reconnected.");
        }

        private void videoGrabber1_OnDeviceReconnecting(object sender, EventArgs e)
        {
            AddLog(txtInfo, "reconnecting...");
        }

        public void AddLog(System.Windows.Forms.TextBox TxtBox, string Line)
        {
            TxtBox.Text += "\r\n" + Line;
            TxtBox.Select(TxtBox.Text.Length - 1, 0);
            TxtBox.ScrollToCaret();
        }

        private void chkAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            videoGrabber1.Display_AutoSize = chkAutoSize.Checked;
        }


        private void videoGrabber1_OnLog(object sender, TOnLogEventArgs e)
        {
            AddLog(txtLog, "[" + e.severity + "] " + e.infoMsg);
        }

        private void rdbRecordingTimerNone_CheckedChanged(object sender, EventArgs e)
        {
            videoGrabber1.RecordingTimer = TRecordingTimer.rt_Disabled;
        }

        private void rdbRecordingTimerStopAfter_CheckedChanged(object sender, EventArgs e)
        {
            videoGrabber1.RecordingTimer = TRecordingTimer.rt_StopRecording;
        }

        private void rdbRecordingTimerNewFileEvery_CheckedChanged(object sender, EventArgs e)
        {
            videoGrabber1.RecordingTimer = TRecordingTimer.rt_RecordToNewFile;
        }

        private void txtRecordingTimerInterval_TextChanged(object sender, EventArgs e)
        {
            videoGrabber1.RecordingTimerInterval = Convert.ToInt32(txtRecordingTimerInterval.Text);
        }

        private void videoGrabber1_OnFrameProgress(object sender, TOnFrameProgressEventArgs e)
        {
            if (m_JpegSnapshotRequest)
            {
                if (e.frameTime >= 50000000)
                {
                    m_JpegSnapshotRequest = false;
                    videoGrabber1.CaptureFrameTo(TFrameCaptureDest.fc_JpegFile, txtJpegSnapshotFileName.Text);
                }
            }
        }

        private void videoGrabber1_OnFrameCaptureCompleted(object sender, TOnFrameCaptureCompletedEventArgs e)
        {
            AddLog(txtInfo, "frame capture completed to " + e.fileName);
        }

        private void btnSnapshot_Click(object sender, EventArgs e)
        {
            m_JpegSnapshotRequest = true;
        }

        private void chkDoNotRecordImmediately_CheckedChanged(object sender, EventArgs e)
        {
            videoGrabber1.HoldRecording = chkDoNotRecordImmediately.Checked;
            grbBacktimedRecordingStart.Enabled = chkDoNotRecordImmediately.Checked;
        }

        private void videoGrabber1_OnRecordingReadyToStart(object sender, EventArgs e)
        {
            if (videoGrabber1.IsRecordingPaused) {
                btnResumeRecording.Enabled = true;
            }
        }

        private void videoGrabber1_OnRecordingCompleted(object sender, TOnRecordingCompletedEventArgs e)
        {
            AddLog(txtInfo, "Recording to " + e.fileName + " completed.");
            AddLog(txtInfo, "Rename the recorded file from the OnRecordingCompleted event if needed.");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("to start the video in recording mode without writing to the file immediately, set HoldRecording=true before invoking StartRecording, then invoke ResumeRecording() to begin writing to the file.\n\nIn this demo project the ResumeRecording button is enabled by the OnRecordingReadyToStart event if HoldRecording has been set to \"true\".");
        }

        private void btnResumeRecording_Click(object sender, EventArgs e)
        {
            videoGrabber1.ResumeRecording();
        }


    }
}
