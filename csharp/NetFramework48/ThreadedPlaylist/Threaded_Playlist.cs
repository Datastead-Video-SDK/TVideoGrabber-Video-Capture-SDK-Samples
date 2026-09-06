#define AUTOPLAYLIST

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using VidGrab;

namespace ThreadedPlaylist
{

    //__________________________________________________________________________________________
    public partial class Threaded_Playlist : Form
    {
        public const string AUDIO_CLIPS = "*.mp3;*.wav;*.wma;*.mid";
        public const string VIDEO_CLIPS = "*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.webm;*.ts;*.m4v;*.mp4v;*.ogg;*.amv;*.rm;*.m2t*";
        public const string IMAGE_FILES = "*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png";
        public const string OPEN_MEDIA_FILES = "All media files|" + VIDEO_CLIPS + AUDIO_CLIPS + IMAGE_FILES
                        + "|Video clips|" + VIDEO_CLIPS
                        + "|Audio clips|" + AUDIO_CLIPS;
        public const string OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES
                        + "|Image files|" + IMAGE_FILES;
        public const string OPEN_PICTURE_FILES = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg";
        public const string OPEN_PROFILES = "WMV9 profiles (*.prx)|*.prx";
        public const string OPEN_COMPRESSOR_SETTINGS = "Compressor saved settings (*.txt)|*.txt";

        double m_SpeedRatio = 1.0;
        int m_PlayerFastSeekSpeedRatio = 1;
        int m_ZoomCoeff = 1000; // zoom = 100% (scale = 1000)
        bool m_FullScreen = false;
        #if !AUTOPLAYLIST
        int m_PreparedClipIndex = 0;
        #endif

        //__________________________________________________________________________________________
        public Threaded_Playlist()
        {
            InitializeComponent();
        }
        //__________________________________________________________________________________________
        private void btnOpenPlayer_Click(object sender, EventArgs e)
        {
            /*
            // to quick test without having to re-select the clips, the playlist can be pre-populated as below:
            lstPlayList.Items.Clear();
            lstPlayList.Items.Add(@"j:\vg000002.asf");
            lstPlayList.Items.Add(@"j:\vg000003.asf");
            lstPlayList.Items.Add(@"j:\vg000004.asf");
            chkLoop.Checked = true;
             */
            

            lstPlayList.SelectedIndex = -1;
            #if AUTOPLAYLIST
            playListControl1.Play(lstPlayList.Items, 0); // PlaylistControl can handle the ListBox items itself
            #else
            m_PreparedClipIndex = 0;
            playListControl1.Play(); // or you can handle your own playlist, each next clip is requested through the playListControl1_OnPrepareNextClip event below
            #endif
        }
        //__________________________________________________________________________________________
        private void btnClosePlaylist_Click(object sender, EventArgs e)
        {
            playListControl1.Close();
        }
        //__________________________________________________________________________________________
        private void UpdateVideoGrabberSettings(VideoGrabber vg)
        {
            if (vg == null) return;
            // update the TVideoGrabber settings here
            vg.PlayerSpeedRatio = m_SpeedRatio;
            vg.ZoomCoeff = m_ZoomCoeff;
            vg.PlayerFastSeekSpeedRatio = m_PlayerFastSeekSpeedRatio;

            if (m_SpeedRatio != 1.0)
            {
                AddLog(txtLog, "speed ratio: " + m_SpeedRatio.ToString());
            }
            if (m_ZoomCoeff != 1000)
            {
                AddLog(txtLog, "zoom coeff: " + (vg.ZoomCoeff / 10).ToString() + " %");
            }
        }
        //__________________________________________________________________________________________
        private void playListControl1_OnConfigureVideoGrabber(object sender, PlayListControl.TOnConfigureVideoGrabberEventArgs e)
        {
            // this event is called for each next clip loaded for playback

            // THE TVIDEOGRABBER INITIALIZATION STATEMENTS CAN BE PLACED HERE (OVERLAYS, ETC...)
            // UNCOMMENT THE LINES BELOW FOR TESTING

            // e.g. to overlay the clip file name
            //e.VideoGrabber.TextOverlay_Enabled = true; 
            //e.VideoGrabber.TextOverlay_String = e.NextClipFileName;

            // to preserve the aspect ratio of the video whatever the size of the control
            //e.VideoGrabber.VideoRenderer = TVideoRenderer.vr_RecordingPriority;

            e.VideoGrabber.Display_AspectRatio = TAspectRatio.ar_Box;
            e.VideoGrabber.MouseWheelEventEnabled = true;

            // !!! warning: the e.VideoGrabber.OnPlayerOpened event occurs when the clip is prepared, and not when it starts playing.
            // Use the playListControl.OnNextClipPlaying event instead, that occurs when the clip is shown in the playListControl.

            e.VideoGrabber.OnMouseUp += new OnMouseUpEventHandler(VideoGrabber_OnMouseUp);
            e.VideoGrabber.OnMouseDown += new OnMouseDownEventHandler(VideoGrabber_OnMouseDown);
            e.VideoGrabber.OnDblClick += new EventHandler(VideoGrabber_OnDblClick);
            e.VideoGrabber.OnMouseWheel += new OnMouseWheelEventHandler(VideoGrabber_OnMouseWheel);
            e.VideoGrabber.OnKeyPress += new OnKeyPressEventHandler(VideoGrabber_OnKeyPress);
            e.VideoGrabber.OnLog += new OnLogEventHandler(VideoGrabber_OnLog);
            e.VideoGrabber.OnPlayerUpdateTrackbarPosition += new OnPlayerUpdateTrackbarPositionEventHandler(VideoGrabber_OnPlayerUpdateTrackbarPosition);

            UpdateVideoGrabberSettings(e.VideoGrabber);

            // if no overlay or capture is needed the frame grabber can be disabled:
            //e.VideoGrabber.FrameGrabber = TFrameGrabber.fg_Disabled; 
            
            // e.g. to start playing at 3 seconds:
            //e.VideoGrabber.OpenPlayerAtTimePositions(30000000, -1, true, true);  
        }

        //__________________________________________________________________________________________
        void VideoGrabber_OnPlayerUpdateTrackbarPosition(object sender, TOnFrameProgressEventArgs e)
        {

            int FrameNumber = (int)e.frameNumber;
            if ((FrameNumber >= tbrPlayer.Minimum) && (FrameNumber <= tbrPlayer.Maximum)) {
                tbrPlayer.Value = (int)e.frameNumber;
            }
        }
        //__________________________________________________________________________________________
        void VideoGrabber_OnLog(object sender, TOnLogEventArgs e)
        {
            AddLog(txtLog, e.infoMsg);
        }
        //__________________________________________________________________________________________
        void VideoGrabber_OnKeyPress(object sender, TOnVideoKeyPressEventArgs e)
        {
            PlayListControl PlayListOwner = (PlayListControl)((VideoGrabber)sender).OwnerObject; // this is a TVideoGrabber event callback, the PlayListControl is available through the OwnerObject property

            if (e.key == (char) Keys.Escape)
            {
                m_FullScreen = PlayListOwner.FullScreen(false);
               
            }
            else if (e.key == (char)Keys.Space)
            {
                if (PlayListOwner.CurrentVideoGrabberPlaying() != null)
                {
                    if (PlayListOwner.CurrentVideoGrabberPlaying().PlayerState == TPlayerState.ps_Playing)
                    {
                        PlayListOwner.CurrentVideoGrabberPlaying().PausePlayer();
                    }
                    else if (PlayListOwner.CurrentVideoGrabberPlaying().PlayerState == TPlayerState.ps_Paused)
                    {
                        PlayListOwner.CurrentVideoGrabberPlaying().RunPlayer();
                    }
                }
            }
        }
        //__________________________________________________________________________________________
        void VideoGrabber_OnMouseWheel(object sender, TOnMouseWheelEventArgs e)
        {
            PlayListControl PlayListOwner = (PlayListControl)((VideoGrabber)sender).OwnerObject; // this is a TVideoGrabber event callback, the PlayListControl is available through the OwnerObject property

            if (e.directionUp)
            {
                if (m_ZoomCoeff < 20000)
                {
                    m_ZoomCoeff += 100;
                }
            }
            else
            {
                if (m_ZoomCoeff > 1000)
                {
                    m_ZoomCoeff -= 100;
                }
            }
            UpdateVideoGrabberSettings(PlayListOwner.CurrentVideoGrabberPlaying());
        }
        //__________________________________________________________________________________________
        void VideoGrabber_OnDblClick(object sender, EventArgs e)
        {
            PlayListControl PlayListOwner = (PlayListControl)((VideoGrabber)sender).OwnerObject; // this is a TVideoGrabber event callback, the PlayListControl is available through the OwnerObject property

            if (!m_FullScreen)
            {
                m_FullScreen = PlayListOwner.FullScreen(true);
            }
            else
            {
                m_FullScreen = PlayListOwner.FullScreen(false);
            }
        }
        //__________________________________________________________________________________________
        public void AddLog(System.Windows.Forms.TextBox TxtBox, string Line)
        {
            TxtBox.Text += "\r\n" + Line;
            TxtBox.Select(TxtBox.Text.Length - 1, 0);
            TxtBox.ScrollToCaret();
        }
        //__________________________________________________________________________________________
        void VideoGrabber_OnMouseUp(object sender, TOnVideoMouseUpDownEventArgs e)
        {
            PlayListControl PlayListOwner = (PlayListControl)((VideoGrabber)sender).OwnerObject; // this is a TVideoGrabber event callback, the PlayListControl is available through the OwnerObject property

            AddLog (txtLog, PlayListOwner.Name + " mouse up clicked at " + e.x.ToString() + ", " + e.y.ToString());
        }
        //__________________________________________________________________________________________
        void VideoGrabber_OnMouseDown(object sender, TOnVideoMouseUpDownEventArgs e)
        {
            PlayListControl PlayListOwner = (PlayListControl)((VideoGrabber)sender).OwnerObject; // this is a TVideoGrabber event callback, the PlayListControl is available through the OwnerObject property

            AddLog (txtLog, PlayListOwner.Name + " mouse down clicked at " + e.x.ToString() + ", " + e.y.ToString());
        }
        //__________________________________________________________________________________________
        private void playListControl1_OnNextClipPlaying(object sender, PlayListControl.TOnNextClipEventArgs e)
        {
            PlayListControl SenderPlaylistControl = (PlayListControl)sender; // this is a PlayListControl direct callback, so sender is the PlayListControl itself

            if ((e.NextClipIndex >= 0) && (e.NextClipIndex < lstPlayList.Items.Count))
            {
                lstPlayList.SelectedIndex = e.NextClipIndex;
                tbrPlayer.Minimum = 1;
                tbrPlayer.TickFrequency = 1;

                SenderPlaylistControl.CurrentVideoGrabberPlaying().SetFocus(); /// this gives the focus to the video window so the OnMouseWheel event can raise without clicking in the video window

                tbrPlayer.Maximum = (int)SenderPlaylistControl.CurrentVideoGrabberPlaying().PlayerFrameCount;
                UpdateVideoGrabberSettings(SenderPlaylistControl.CurrentVideoGrabberPlaying());

            }
        }
        //__________________________________________________________________________________________
        private void btnPlaylistAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = OPEN_MEDIA_FILES_EXTENDED;
            fd.Multiselect = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < fd.FileNames.Length; i++)
                {
                    lstPlayList.Items.Add(fd.FileNames.GetValue(i));
                    lstPlayList.SelectedIndex = 0;
                }
            }
        }
        //__________________________________________________________________________________________
        private void btnCaptureToControl_Click(object sender, EventArgs e)
        {
            if (playListControl1.CurrentVideoGrabberPlaying() != null)
            {

                // adjusts the PictureBox aspect ratio to the aspect ratio of the native TVideoGrabber video source size
                imgCapturedFrame.Height = imgCapturedFrame.Width * playListControl1.CurrentVideoGrabberPlaying().VideoHeight / playListControl1.CurrentVideoGrabberPlaying().VideoWidth;

                System.IntPtr FrameBitmap = playListControl1.CurrentVideoGrabberPlaying().GetLastFrameAsHBITMAP(0, false, 0, 0, 0, 0, imgCapturedFrame.Width, imgCapturedFrame.Height, 32);
                if (!FrameBitmap.Equals(System.IntPtr.Zero))
                {
                    imgCapturedFrame.Image = Image.FromHbitmap(FrameBitmap);
                    WinUtil.DeleteObject(FrameBitmap);
                    //imgCapturedFrame
                }
            }
        }
        //__________________________________________________________________________________________
        private void btnCaptureToPng_Click(object sender, EventArgs e)
        {
            VideoGrabber CurrentVideoGrabberPlaying = playListControl1.CurrentVideoGrabberPlaying();
            if (CurrentVideoGrabberPlaying != null)
            {
                System.IntPtr FrameBitmap = CurrentVideoGrabberPlaying.GetLastFrameAsHBITMAP(0, false, 0, 0, 0, 0, 0, 0, 32);
                if (!FrameBitmap.Equals(System.IntPtr.Zero))
                {
                    Image img = Image.FromHbitmap(FrameBitmap);
                    img.Save("CapturedFrame.png", System.Drawing.Imaging.ImageFormat.Png);
                    WinUtil.DeleteObject(FrameBitmap);
                }
            }
        }
        //__________________________________________________________________________________________
        private void btnPause_Click(object sender, EventArgs e)
        {
            playListControl1.Pause();
        }
        //__________________________________________________________________________________________
        private void btnResume_Click(object sender, EventArgs e)
        {
            playListControl1.Resume();
        }
        //__________________________________________________________________________________________
        private void chkLoop_CheckedChanged(object sender, EventArgs e)
        {
            playListControl1.Loop = chkLoop.Checked;
        }
        //__________________________________________________________________________________________
        private void playListControl1_OnPrepareNextClip(object sender, PlayListControl.TOnNextClipEventArgs e)
        {
            #if ! AUTOPLAYLIST
            if (m_PreparedClipIndex < lstPlayList.Items.Count)
            {
                e.NextClipFileName = lstPlayList.Items[m_PreparedClipIndex].ToString();
                e.NextClipIndex = m_PreparedClipIndex;

                if (m_PreparedClipIndex < lstPlayList.Items.Count - 1)
                {
                    m_PreparedClipIndex++;
                }
                else
                {
                    if (chkLoop.Checked)
                    {
                        m_PreparedClipIndex = 0; // loop
                    }
                    else
                    {
                        e.EndOfPlaylist = true;
                    }
                }
            }
            #endif

        }
        //__________________________________________________________________________________________
        private void FullScreenEnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_FullScreen = playListControl1.FullScreen(true);
        }
        //__________________________________________________________________________________________
        private void disableFullScreenembedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_FullScreen = playListControl1.FullScreen(false);
        }
        //__________________________________________________________________________________________
        private void FullScreenDisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playListControl1.FullScreen(false);
        }
        //__________________________________________________________________________________________
        private void SpeedAdd05toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (m_SpeedRatio < 4)
            {
                m_SpeedRatio = m_SpeedRatio + 0.5;
                UpdateVideoGrabberSettings(playListControl1.CurrentVideoGrabberPlaying());
            }
        }
        //__________________________________________________________________________________________
        private void SpeedSub05toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (m_SpeedRatio > 0.5)
            {
                m_SpeedRatio = m_SpeedRatio - 0.5;
                UpdateVideoGrabberSettings(playListControl1.CurrentVideoGrabberPlaying());
            }
        }
        //__________________________________________________________________________________________
        private void FFx2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_PlayerFastSeekSpeedRatio = 2;
            UpdateVideoGrabberSettings(playListControl1.CurrentVideoGrabberPlaying());
            playListControl1.CurrentVideoGrabberPlaying().FastForwardPlayer();
        }
        //__________________________________________________________________________________________
        private void FFx4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_PlayerFastSeekSpeedRatio = 4;
            UpdateVideoGrabberSettings(playListControl1.CurrentVideoGrabberPlaying());
            playListControl1.CurrentVideoGrabberPlaying().FastForwardPlayer();
        }
        //__________________________________________________________________________________________
        private void REWx2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_PlayerFastSeekSpeedRatio = 2;
            UpdateVideoGrabberSettings(playListControl1.CurrentVideoGrabberPlaying());
            playListControl1.CurrentVideoGrabberPlaying().RewindPlayer();
        }
        //__________________________________________________________________________________________
        private void REWx4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_PlayerFastSeekSpeedRatio = 4;
            UpdateVideoGrabberSettings(playListControl1.CurrentVideoGrabberPlaying());
            playListControl1.CurrentVideoGrabberPlaying().RewindPlayer();
        }
        //__________________________________________________________________________________________
        private void playNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_PlayerFastSeekSpeedRatio = 1;
            m_SpeedRatio = 1.0;
            UpdateVideoGrabberSettings(playListControl1.CurrentVideoGrabberPlaying());
            playListControl1.CurrentVideoGrabberPlaying().RunPlayer();
        }
        //__________________________________________________________________________________________
        private void playBackwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_PlayerFastSeekSpeedRatio = 1;
            m_SpeedRatio = 1.0;
            UpdateVideoGrabberSettings(playListControl1.CurrentVideoGrabberPlaying());
            playListControl1.CurrentVideoGrabberPlaying().RunPlayerBackwards();
        }
        //__________________________________________________________________________________________
        private void tbrPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            playListControl1.CurrentVideoGrabberPlaying().NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_MouseDown);
        }
        //__________________________________________________________________________________________
        private void tbrPlayer_MouseUp(object sender, MouseEventArgs e)
        {
            playListControl1.CurrentVideoGrabberPlaying().NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_MouseUp);

        }
        //__________________________________________________________________________________________
        private void tbrPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            playListControl1.CurrentVideoGrabberPlaying().NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_KeyDown);

        }
        //__________________________________________________________________________________________
        private void tbrPlayer_KeyUp(object sender, KeyEventArgs e)
        {
            playListControl1.CurrentVideoGrabberPlaying().NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_KeyDown);
        }
        //__________________________________________________________________________________________
        private void tbrPlayer_Scroll(object sender, EventArgs e)
        {
            playListControl1.CurrentVideoGrabberPlaying().PlayerFramePosition = tbrPlayer.Value;
        }
        //__________________________________________________________________________________________
        private void lstPlayList_Click(object sender, EventArgs e)
        {
            playListControl1.Play(lstPlayList.Items, lstPlayList.SelectedIndex);
        }
        //__________________________________________________________________________________________
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstPlayList.Items.Clear();
        }
    }
}


