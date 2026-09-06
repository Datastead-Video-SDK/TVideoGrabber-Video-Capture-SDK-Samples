using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainDemo
{
    /*
     * Non-modal VU-meter configuration dialog (C# port of the Delphi
     * TfrmVUMeterConfig).
     *
     * Lets the user pick and tweak any of the supported VU-meter types
     * (vu_Disabled, vu_Analog, vu_AnalogVintage, vu_Bargraph, vu_SegmentLed,
     * vu_SmoothBar, vu_Spectrum, vu_MixingTable) and every TVUMeterSetting
     * option.
     *
     * The legacy "Overlay" variants (vu_AnalogOverlay, vu_BargraphOverlay)
     * are NOT exposed here: the overlay-over-video mode is now toggled with
     * vu_OverlayOverVideo on any display type.
     *
     * Changes are applied live to both channels (VU_LEFT = 0 and VU_RIGHT = 1)
     * of the VideoGrabber instance passed in. The actual TYPE change is routed
     * through the OnApplyType callback, so the host form (Audio) can take care
     * of the panel resize and the vu_Handle wiring.
     */
    public partial class VUMeterConfigForm : Form
    {
        // Channel indices. SetVUMeterSetting/GetVUMeterSetting take an
        // unsigned int channel index; these const ints convert implicitly.
        private const int VU_LEFT = 0;
        private const int VU_RIGHT = 1;

        // Indices in cboBallisticProfile (kept in sync with the ctor)
        private const int PROFILE_CUSTOM = 0;
        private const int PROFILE_DEFAULT = 1;
        private const int PROFILE_VU_CLASSIC = 2;
        private const int PROFILE_PPM = 3;
        private const int PROFILE_FAST_PEAK = 4;
        private const int PROFILE_SLOW_RMS = 5;
        private const int PROFILE_INSTANT = 6;

        // Maps cboVUMeter item index -> VidGrab.TVuMeter value (the combo only
        // holds display strings, so we keep the matching enum values here).
        private VidGrab.TVuMeter[] _meterTypes;

        // True while LoadFromGrabber repopulates the controls, so the change
        // handlers don't push the freshly-loaded values back to the grabber.
        private bool _loading;

        // The grabber whose VU meters are being configured.
        public VidGrab.VideoGrabber VideoGrabber;

        // Callback used to apply a TYPE change. The host form resizes the VU
        // panels and (re)wires the native handles. If left null, the type is
        // applied directly to the grabber.
        public Action<VidGrab.TVuMeter> OnApplyType;

        public VUMeterConfigForm()
        {
            _loading = true;

            InitializeComponent();

            // VU-meter type list (the legacy "*Overlay" variants are
            // intentionally not exposed - use vu_OverlayOverVideo instead).
            cboVUMeter.Items.Clear();
            cboVUMeter.Items.Add("Disabled");
            cboVUMeter.Items.Add("Analog");
            cboVUMeter.Items.Add("Analog Vintage");
            cboVUMeter.Items.Add("Bargraph");
            cboVUMeter.Items.Add("Segment LED");
            cboVUMeter.Items.Add("Smooth Bar");
            cboVUMeter.Items.Add("Spectrum");
            cboVUMeter.Items.Add("Mixing Table");
            _meterTypes = new VidGrab.TVuMeter[]
            {
                VidGrab.TVuMeter.vu_Disabled,
                VidGrab.TVuMeter.vu_Analog,
                VidGrab.TVuMeter.vu_AnalogVintage,
                VidGrab.TVuMeter.vu_Bargraph,
                VidGrab.TVuMeter.vu_SegmentLed,
                VidGrab.TVuMeter.vu_SmoothBar,
                VidGrab.TVuMeter.vu_Spectrum,
                VidGrab.TVuMeter.vu_MixingTable
            };

            // Ballistic presets (shortcuts that fill AttackMs/ReleaseMs/PeakHoldMs)
            cboBallisticProfile.Items.Clear();
            cboBallisticProfile.Items.Add("(custom)");
            cboBallisticProfile.Items.Add("Default (10 / 300 / 800 ms)");
            cboBallisticProfile.Items.Add("VU Classic IEC (300 / 300 / 0 ms)");
            cboBallisticProfile.Items.Add("PPM Broadcast (10 / 600 / 1500 ms)");
            cboBallisticProfile.Items.Add("Fast Peak (1 / 1500 / 2000 ms)");
            cboBallisticProfile.Items.Add("Slow RMS (200 / 2000 / 3000 ms)");
            cboBallisticProfile.Items.Add("Instant (1 / 100 / 0 ms)");
            cboBallisticProfile.SelectedIndex = PROFILE_CUSTOM;

            pcMain.SelectedIndex = 0;
            _loading = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            RefreshControls();
        }

        // Pushes a setting to both channels. Value is passed as a native int
        // (IntPtr), matching SetVUMeterSetting's signature.
        private void SetBothChannels(VidGrab.TVUMeterSetting setting, int value)
        {
            if (VideoGrabber == null) return;
            VideoGrabber.SetVUMeterSetting(VU_LEFT, setting, (IntPtr)value);
            VideoGrabber.SetVUMeterSetting(VU_RIGHT, setting, (IntPtr)value);
        }

        // Reads one int setting from the LEFT channel.
        private int GetLeft(VidGrab.TVUMeterSetting setting)
        {
            if (VideoGrabber == null) return 0;
            return (int)VideoGrabber.GetVUMeterSetting(VU_LEFT, setting);
        }

        // Color settings travel as a Win32 COLORREF (0x00BBGGRR). ColorTranslator
        // converts to/from that exact format.
        private Color GetLeftColor(VidGrab.TVUMeterSetting setting)
        {
            return ColorTranslator.FromWin32(GetLeft(setting));
        }

        private static int Clamp(int v, int lo, int hi)
        {
            if (v < lo) return lo;
            if (v > hi) return hi;
            return v;
        }

        public void RefreshControls()
        {
            if (VideoGrabber == null) return;
            _loading = true;
            try
            {
                LoadFromGrabber();
            }
            finally
            {
                _loading = false;
            }
        }

        // Pulls every setting from the LEFT channel. Both channels are expected
        // to stay in sync - if they don't, the next SetBothChannels call will
        // realign the right channel.
        private void LoadFromGrabber()
        {
            // Current type
            VidGrab.TVuMeter current = VideoGrabber.VuMeter;
            for (int i = 0; i < _meterTypes.Length; i++)
            {
                if (_meterTypes[i] == current)
                {
                    cboVUMeter.SelectedIndex = i;
                    break;
                }
            }

            // Display options
            chkOverlayOverVideo.Checked = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayOverVideo) != 0;
            chkTransparent.Checked = GetLeft(VidGrab.TVUMeterSetting.vu_Transparent) != 0;
            chkFlipVert.Checked = GetLeft(VidGrab.TVUMeterSetting.vu_FlipVert) != 0;
            chkFlipHorz.Checked = GetLeft(VidGrab.TVUMeterSetting.vu_FlipHorz) != 0;
            chkLogarithmic.Checked = GetLeft(VidGrab.TVUMeterSetting.vu_LogarithmicScale) != 0;

            // Overlay rect
            edtOverlayLeft.Text = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayLeft).ToString();
            edtOverlayTop.Text = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayTop).ToString();
            edtOverlayWidth.Text = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayWidth).ToString();
            edtOverlayHeight.Text = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayHeight).ToString();

            // Levels (0..100 TrackBars)
            tbrWarningPercent.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_WarningPercent), 0, 100);
            lblWarningPercentValue.Text = tbrWarningPercent.Value + " %";
            tbrPeakPercent.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_PeakPercent), 0, 100);
            lblPeakPercentValue.Text = tbrPeakPercent.Value + " %";

            // Colors
            pnBkgndColor.BackColor = GetLeftColor(VidGrab.TVUMeterSetting.vu_BkgndColor);
            pnNormalColor.BackColor = GetLeftColor(VidGrab.TVUMeterSetting.vu_NormalColor);
            pnWarningColor.BackColor = GetLeftColor(VidGrab.TVUMeterSetting.vu_WarningColor);
            pnPeakColor.BackColor = GetLeftColor(VidGrab.TVUMeterSetting.vu_PeakColor);

            // Drawing
            updTickSize.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_TickSize), (int)updTickSize.Minimum, (int)updTickSize.Maximum);
            updTickInterval.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_TickInterval), (int)updTickInterval.Minimum, (int)updTickInterval.Maximum);
            updNeedleThickness.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_NeedleThickness), (int)updNeedleThickness.Minimum, (int)updNeedleThickness.Maximum);

            // Ballistics
            updAttackMs.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_AttackMs), (int)updAttackMs.Minimum, (int)updAttackMs.Maximum);
            updReleaseMs.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_ReleaseMs), (int)updReleaseMs.Minimum, (int)updReleaseMs.Maximum);
            updPeakHoldMs.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_PeakHoldMs), (int)updPeakHoldMs.Minimum, (int)updPeakHoldMs.Maximum);
            // No attempt at guessing which preset matches the current values:
            // stay on (custom).
            cboBallisticProfile.SelectedIndex = PROFILE_CUSTOM;
        }

        private void cboVUMeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            if (cboVUMeter.SelectedIndex < 0) return;
            VidGrab.TVuMeter m = _meterTypes[cboVUMeter.SelectedIndex];
            // The host form knows how to handle the panels (resize, vu_Handle),
            // so delegate to it via the callback. If no callback is set, just
            // apply the change directly to the grabber.
            if (OnApplyType != null)
                OnApplyType(m);
            else if (VideoGrabber != null)
                VideoGrabber.VuMeter = m;
            RefreshControls();
        }

        // ====================================================================
        //  Display options
        // ====================================================================

        private void chkOverlayOverVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_OverlayOverVideo, chkOverlayOverVideo.Checked ? 1 : 0);
        }

        private void chkTransparent_CheckedChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_Transparent, chkTransparent.Checked ? 1 : 0);
        }

        private void chkFlipVert_CheckedChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_FlipVert, chkFlipVert.Checked ? 1 : 0);
        }

        private void chkFlipHorz_CheckedChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_FlipHorz, chkFlipHorz.Checked ? 1 : 0);
        }

        private void chkLogarithmic_CheckedChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_LogarithmicScale, chkLogarithmic.Checked ? 1 : 0);
        }

        // ====================================================================
        //  Overlay rect
        // ====================================================================

        private static int ParseIntDef(string s, int def)
        {
            int v;
            if (int.TryParse(s, out v)) return v;
            return def;
        }

        private void edtOverlayLeft_TextChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            if (VideoGrabber == null) return;
            // Per-channel horizontal offset so the two meters don't overlap:
            // the left channel keeps the entered Left value, the right channel
            // is shifted by Width + 10 px.
            int left = ParseIntDef(edtOverlayLeft.Text, 0);
            int width = ParseIntDef(edtOverlayWidth.Text, 0);
            VideoGrabber.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr)left);
            VideoGrabber.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr)(left + width + 10));
        }

        private void edtOverlayTop_TextChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_OverlayTop, ParseIntDef(edtOverlayTop.Text, 0));
        }

        private void edtOverlayWidth_TextChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_OverlayWidth, ParseIntDef(edtOverlayWidth.Text, 0));
            // Also re-trigger the right channel offset recompute
            edtOverlayLeft_TextChanged(null, EventArgs.Empty);
        }

        private void edtOverlayHeight_TextChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_OverlayHeight, ParseIntDef(edtOverlayHeight.Text, 0));
        }

        // ====================================================================
        //  Levels (warning / peak percent)
        // ====================================================================

        private void tbrWarningPercent_Scroll(object sender, EventArgs e)
        {
            lblWarningPercentValue.Text = tbrWarningPercent.Value + " %";
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_WarningPercent, tbrWarningPercent.Value);
        }

        private void tbrPeakPercent_Scroll(object sender, EventArgs e)
        {
            lblPeakPercentValue.Text = tbrPeakPercent.Value + " %";
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_PeakPercent, tbrPeakPercent.Value);
        }

        // ====================================================================
        //  Colors (one shared handler for the 4 buttons, dispatched via Tag)
        // ====================================================================

        private void btnColor_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;
            Panel panel;
            VidGrab.TVUMeterSetting setting;
            switch (Convert.ToInt32(btn.Tag))
            {
                case 0: panel = pnBkgndColor; setting = VidGrab.TVUMeterSetting.vu_BkgndColor; break;
                case 1: panel = pnNormalColor; setting = VidGrab.TVUMeterSetting.vu_NormalColor; break;
                case 2: panel = pnWarningColor; setting = VidGrab.TVUMeterSetting.vu_WarningColor; break;
                case 3: panel = pnPeakColor; setting = VidGrab.TVUMeterSetting.vu_PeakColor; break;
                default: return;
            }
            ColorDialog1.Color = panel.BackColor;
            if (ColorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                panel.BackColor = ColorDialog1.Color;
                SetBothChannels(setting, ColorTranslator.ToWin32(ColorDialog1.Color));
            }
        }

        private void btnDisablePeak_Click(object sender, EventArgs e)
        {
            SetBothChannels(VidGrab.TVUMeterSetting.vu_PeakHoldMs, 0);
            RefreshControls();
        }

        // ====================================================================
        //  Drawing (tick size, tick interval, needle thickness)
        // ====================================================================

        private void updTickSize_ValueChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_TickSize, (int)updTickSize.Value);
        }

        private void updTickInterval_ValueChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_TickInterval, (int)updTickInterval.Value);
        }

        private void updNeedleThickness_ValueChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_NeedleThickness, (int)updNeedleThickness.Value);
        }

        // ====================================================================
        //  Ballistics
        // ====================================================================

        // Fills the three values (Attack/Release/PeakHold) corresponding to the
        // chosen preset.
        private void ApplyBallisticProfilePreset(int profileIdx)
        {
            int a, r, h;
            switch (profileIdx)
            {
                case PROFILE_DEFAULT: a = 10; r = 300; h = 800; break;
                case PROFILE_VU_CLASSIC: a = 300; r = 300; h = 0; break;
                case PROFILE_PPM: a = 10; r = 600; h = 1500; break;
                case PROFILE_FAST_PEAK: a = 1; r = 1500; h = 2000; break;
                case PROFILE_SLOW_RMS: a = 200; r = 2000; h = 3000; break;
                case PROFILE_INSTANT: a = 1; r = 100; h = 0; break;
                default: return;
            }
            SetBothChannels(VidGrab.TVUMeterSetting.vu_AttackMs, a);
            SetBothChannels(VidGrab.TVUMeterSetting.vu_ReleaseMs, r);
            SetBothChannels(VidGrab.TVUMeterSetting.vu_PeakHoldMs, h);
            // Reflect the new values in the UI without re-triggering the
            // per-control handlers.
            _loading = true;
            try
            {
                updAttackMs.Value = Clamp(a, (int)updAttackMs.Minimum, (int)updAttackMs.Maximum);
                updReleaseMs.Value = Clamp(r, (int)updReleaseMs.Minimum, (int)updReleaseMs.Maximum);
                updPeakHoldMs.Value = Clamp(h, (int)updPeakHoldMs.Minimum, (int)updPeakHoldMs.Maximum);
            }
            finally
            {
                _loading = false;
            }
        }

        private void cboBallisticProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            if (cboBallisticProfile.SelectedIndex <= PROFILE_CUSTOM) return;
            ApplyBallisticProfilePreset(cboBallisticProfile.SelectedIndex);
        }

        private void updAttackMs_ValueChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_AttackMs, (int)updAttackMs.Value);
            cboBallisticProfile.SelectedIndex = PROFILE_CUSTOM;
        }

        private void updReleaseMs_ValueChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_ReleaseMs, (int)updReleaseMs.Value);
            cboBallisticProfile.SelectedIndex = PROFILE_CUSTOM;
        }

        private void updPeakHoldMs_ValueChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_PeakHoldMs, (int)updPeakHoldMs.Value);
            cboBallisticProfile.SelectedIndex = PROFILE_CUSTOM;
        }

        // ====================================================================
        //  Footer
        // ====================================================================

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
