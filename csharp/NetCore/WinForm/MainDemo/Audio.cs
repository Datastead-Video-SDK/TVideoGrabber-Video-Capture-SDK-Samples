using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	public partial class Audio : Form
    {
		private const int VU_LEFT = 0;
		private const int VU_RIGHT = 1;

		// Design-time reference sizes of the VU host panels. Type changes ALWAYS
		// resize from these (never from the current sizes), so chaining several
		// type changes does not shrink the panels progressively.
		private int _initLeftWidth;
		private int _initLeftHeight;
		private int _initRightWidth;
		private int _initRightHeight;

		// Non-modal VU-meter configuration dialog (created on first open,
		// reset to null when closed).
		private VUMeterConfigForm _vuConfigForm;

		public Audio()
		{
            //
            // Required for Windows Form Designer support
            //

            InitializeComponent();

			// Capture the design-time panel sizes used as the resize reference.
			_initLeftWidth = pnlVUMeterLeft.Width;
			_initLeftHeight = pnlVUMeterLeft.Height;
			_initRightWidth = pnlVUMeterRight.Width;
			_initRightHeight = pnlVUMeterRight.Height;

			ApplyVUMeterType(VidGrab.TVuMeter.vu_Spectrum);
		}
        public void RefreshDisplayOptions()
        {
            Helpers.AssignListToComboBox(cboAudioDevices, MainForm.cMainForm.VideoGrabber1.AudioDevices, MainForm.cMainForm.VideoGrabber1.AudioDevice);

            if (MainForm.cMainForm.VideoGrabber1.AudioDevice >= 0) { // if an audio capture device has been selected
                Helpers.AssignListToComboBox(cboAudioInputs, MainForm.cMainForm.VideoGrabber1.AudioInputs, MainForm.cMainForm.VideoGrabber1.AudioInput);
            }

            tbrAudioInputLevel.Value = MainForm.cMainForm.VideoGrabber1.AudioInputLevel;
            tbrAudioInputBalance.Value = MainForm.cMainForm.VideoGrabber1.AudioInputBalance;
            
			Helpers.AssignListToComboBox(cboAudioRenderers, MainForm.cMainForm.VideoGrabber1.AudioRenderers, MainForm.cMainForm.VideoGrabber1.AudioRenderer);

			chkRenderAudioDevice.Checked = MainForm.cMainForm.VideoGrabber1.AudioDeviceRendering;
			chkMuteAudioRendering.Checked = MainForm.cMainForm.VideoGrabber1.MuteAudioRendering;

			if (MainForm.cMainForm.VideoGrabber1.AudioDevice == -1)
			{
				cboAudioDevices.Text = "SELECT AN AUDIO CAPTURE DEVICE IN THIS LIST";
			}
			if (MainForm.cMainForm.VideoGrabber1.AudioRenderer == -1) {
				cboAudioRenderers.Text = "default (AudioRenderer = -1)";
			}
		}

		private void cboAudioDevices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioDevice = cboAudioDevices.SelectedIndex;
		}

		private void cboAudioInputs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioInput = cboAudioInputs.SelectedIndex;
		}

		private void chkRenderAudioDevice_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioDeviceRendering = chkRenderAudioDevice.Checked;
		}

		private void chkMuteAudioRendering_CheckedChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.MuteAudioRendering = chkMuteAudioRendering.Checked;
		}

		private void cboAudioRenderers_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioRenderer = cboAudioRenderers.SelectedIndex;
		}

		private void tbrAudioVolume_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioVolume = tbrAudioVolume.Value;
		}

		private void tbrAudioInputLevel_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioInputLevel = tbrAudioInputLevel.Value;
		}

		private void tbrAudioInputBalance_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioInputBalance = tbrAudioInputBalance.Value;
		}

		private void tbrAudioBalance_Scroll(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.AudioBalance = tbrAudioBalance.Value;
		}

		private void rdgVUMeter_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				switch (Convert.ToInt32((sender as RadioButton).Tag))
				{
					case 0:
						ApplyVUMeterType(VidGrab.TVuMeter.vu_Disabled);
						break;
					case 1:
						ApplyVUMeterType(VidGrab.TVuMeter.vu_Analog);
						break;
					case 2:
						ApplyVUMeterType(VidGrab.TVuMeter.vu_Bargraph);
						break;
				}
			}
		}

		// Applies the selected VU-meter type: sets it on the grabber, resizes the
		// host panels (pnlVUMeterLeft / pnlVUMeterRight) according to the type and
		// attaches (or detaches) the native window handles.
		//
		// Resizes ALWAYS start from the captured initial sizes, never from the
		// current sizes, so chaining several type changes does not shrink the
		// panels progressively.
		//
		// Called either directly by the radio buttons or through the
		// VUMeterConfigForm dialog (OnApplyType callback).
		public void ApplyVUMeterType(VidGrab.TVuMeter meter)
		{
			VidGrab.VideoGrabber vg = MainForm.cMainForm.VideoGrabber1;
			vg.VuMeter = meter;

			switch (meter)
			{
				case VidGrab.TVuMeter.vu_Analog:
					// 4:3 aspect for the analog galvanometer.
					pnlVUMeterLeft.Width = (_initLeftHeight * 4) / 3;
					pnlVUMeterLeft.Height = _initLeftHeight;
					pnlVUMeterRight.Width = (_initRightHeight * 4) / 3;
					pnlVUMeterRight.Height = _initRightHeight;
					vg.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0);
					vg.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0);
					break;

				case VidGrab.TVuMeter.vu_AnalogVintage:
				case VidGrab.TVuMeter.vu_Spectrum:
					// 2:1 horizontal aspect.
					pnlVUMeterLeft.Width = _initLeftWidth;
					pnlVUMeterLeft.Height = (_initLeftWidth * 2) / 4;
					pnlVUMeterRight.Width = _initRightWidth;
					pnlVUMeterRight.Height = (_initRightWidth * 2) / 4;
					vg.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0);
					vg.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0);
					break;

				case VidGrab.TVuMeter.vu_Bargraph:
				case VidGrab.TVuMeter.vu_SegmentLed:
				case VidGrab.TVuMeter.vu_SmoothBar:
				case VidGrab.TVuMeter.vu_MixingTable:
					// Thin vertical column.
					pnlVUMeterLeft.Width = (_initLeftHeight * 2) / 10;
					pnlVUMeterLeft.Height = _initLeftHeight;
					pnlVUMeterRight.Width = (_initRightHeight * 2) / 10;
					pnlVUMeterRight.Height = _initRightHeight;
					vg.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0x404040);
					vg.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr)0x404040);
					break;

				default: // vu_Disabled (and any legacy overlay type)
					// Restore the exact design-time sizes.
					pnlVUMeterLeft.Width = _initLeftWidth;
					pnlVUMeterLeft.Height = _initLeftHeight;
					pnlVUMeterRight.Width = _initRightWidth;
					pnlVUMeterRight.Height = _initRightHeight;
					break;
			}

			if (meter != VidGrab.TVuMeter.vu_Disabled)
			{
				// Use the panels as containers: the SDK paints onto their HWND.
				vg.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterLeft.Handle);
				vg.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, pnlVUMeterRight.Handle);
			}
			else
			{
				// Detach: passing 0 as the handle releases the panel.
				vg.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, (IntPtr)0);
				vg.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, (IntPtr)0);
			}
		}

		// Opens the VU-meter configuration window (non-modal). The form is
		// instantiated on first open and reset to null on close.
		private void btnConfigureVUMeters_Click(object sender, EventArgs e)
		{
			if (_vuConfigForm == null || _vuConfigForm.IsDisposed)
			{
				_vuConfigForm = new VUMeterConfigForm();
				_vuConfigForm.VideoGrabber = MainForm.cMainForm.VideoGrabber1;
				_vuConfigForm.OnApplyType = ApplyVUMeterType;
				_vuConfigForm.FormClosed += delegate { _vuConfigForm = null; };
			}
			_vuConfigForm.Show();
			_vuConfigForm.BringToFront();
		}

        private void btnBargraphOverlay_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(2, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr) 10);
            MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(3, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr) 140);
            for (uint i = 2; i <= 3; i++)
            {
                MainForm.cMainForm.VideoGrabber1.SetVuMeter_Enabled(Convert.ToInt32(i), VidGrab.TVuMeter.vu_BargraphOverlay);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_Transparent, (IntPtr) 1);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayTop, (IntPtr) 10);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayWidth, (IntPtr) 100);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayHeight, (IntPtr) 60);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_BkgndColor, (IntPtr) 0x800000);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_NormalColor, (IntPtr) 0x000080);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_WarningColor, (IntPtr) 0x00A5FF);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_PeakColor, (IntPtr) 0x00FFFF);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_WarningPercent, (IntPtr) 20);
                MainForm.cMainForm.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_PeakPercent, (IntPtr) 40);
            }
        }

		private void btnStartAudioRendering_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.StartAudioRendering();
			if (! MainForm.cMainForm.VideoGrabber1.AudioDeviceRendering) {
				if (btnStartAudioRendering.Tag == null) 
				{
					btnStartAudioRendering.Tag = 1; //' to show the popup only one time
					MessageBox.Show ("StartAudioRendering acts as 'preview', e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers",
                                "DataStead TVideoGrabber C#.NET OCX Demo",MessageBoxButtons.OK);
				}
            }
		}

		private void btnStartWavRecording_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression;
			MainForm.cMainForm.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;
			MainForm.cMainForm.VideoGrabber1.StartAudioRecording();
		}

		private void btnSartMP3Recording_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly;
			MainForm.cMainForm.VideoGrabber1.CompressionType = VidGrab.TCompressionType.ct_Audio;
			MainForm.cMainForm.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI;
			
			MainForm.cMainForm.VideoGrabber1.AudioCompressor = MainForm.cMainForm.VideoGrabber1.FindIndexInListByName (MainForm.cMainForm.VideoGrabber1.AudioCompressors, "MP3 (Microsoft)", false, true);
			if (MainForm.cMainForm.VideoGrabber1.AudioCompressor == -1) 
			{
				MessageBox.Show ("MP3 (Microsoft) audio compressor not found, please contact support@datastead.com",
                            "DataStead TVideoGrabber C#.NET OCX Demo",MessageBoxButtons.OK);
			}
			else {
				MainForm.cMainForm.VideoGrabber1.StartAudioRecording();
			}
		}

		private void btnStartWMVRecording_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression;
			MainForm.cMainForm.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_ASF;
			MainForm.cMainForm.VideoGrabber1.StartAudioRecording();
		}

		private void btnStopAudio_Click(object sender, System.EventArgs e)
		{
			MainForm.cMainForm.VideoGrabber1.Stop();
		}

		private void chkUseAudioOfVideoCaptureDevice_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkUseAudioOfVideoCaptureDevice.Checked)
			{
				MainForm.cMainForm.VideoGrabber1.VideoDevice = 0; // in this demo, by default we choose the 1st
			}
			else {
				MainForm.cMainForm.VideoGrabber1.VideoDevice = -1; // this deactivates the video capture device
			}
		}

		private void Audio_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshDisplayOptions();
			}
		}

        private void btnAudioDeviceDialog_Click(object sender, EventArgs e)
        {
            MainForm.cMainForm.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_AudioDevice);
        }

        private void rdgAudioSourceDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgAudioSourceDefault.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_Default;
            }
        }

        private void rdgAudioSourceExternal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgAudioSourceExternal.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_UseExternalAudio;
            }
        }

        private void rdgAudioSourceSpeakerOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgAudioSourceSpeakerOutput.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_SpeakerOutput;
            }
        }

        private void rdgAudioSourceDefaultSpeakerRecording_CheckedChanged(object sender, EventArgs e)
        {
            if (rdgAudioSourceDefaultSpeakerRecording.Checked)
            {
                MainForm.cMainForm.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_DefaultWithSpeakerRecording;
            }
        }

	}
}
