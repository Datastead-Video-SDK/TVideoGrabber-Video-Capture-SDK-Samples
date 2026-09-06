using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

using VidGrabWPF;

namespace MainDemoWPF
{
    /*
     * Non-modal VU-meter configuration window (WPF port of the WinForms
     * VUMeterConfigForm / Delphi TfrmVUMeterConfig).
     *
     * Lets the user pick and tweak any of the supported VU-meter types and
     * every TVUMeterSetting option. Changes are applied live to both channels
     * (VU_LEFT = 0 and VU_RIGHT = 1) of the VideoGrabberWPF passed in. The TYPE
     * change is routed through the OnApplyType callback, so the host (Audio)
     * handles the WindowsFormsHost resize and the vu_Handle wiring.
     *
     * Color picking reuses System.Windows.Forms.ColorDialog (WPF has no native
     * color dialog). Colors travel as a Win32 COLORREF (0x00BBGGRR).
     */
    public partial class VUMeterConfigWindow : Window
    {
        // Channel indices. SetVUMeterSetting/GetVUMeterSetting take an unsigned
        // int channel index; these const ints convert implicitly.
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

        // Maps cboVUMeter item index -> VidGrab.TVuMeter value.
        private VidGrab.TVuMeter[] _meterTypes;

        // True while LoadFromGrabber repopulates the controls, so the change
        // handlers don't push the freshly-loaded values back to the grabber.
        private bool _loading;

        // The grabber whose VU meters are being configured.
        public VideoGrabberWPF VideoGrabber;

        // Callback used to apply a TYPE change (host resizes the WindowsFormsHost
        // panels and rewires the native handles).
        public Action<VidGrab.TVuMeter> OnApplyType;

        public VUMeterConfigWindow()
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

            Loaded += delegate { RefreshControls(); };
        }

        // ====================================================================
        //  Color helpers (COLORREF 0x00BBGGRR <-> WPF Media.Color)
        // ====================================================================

        private static Color CorefToColor(int coref)
        {
            return Color.FromRgb(
                (byte)(coref & 0xFF),
                (byte)((coref >> 8) & 0xFF),
                (byte)((coref >> 16) & 0xFF));
        }

        private static int ColorToCoref(System.Drawing.Color c)
        {
            return System.Drawing.ColorTranslator.ToWin32(c);
        }

        // ====================================================================
        //  Grabber access
        // ====================================================================

        private void SetBothChannels(VidGrab.TVUMeterSetting setting, int value)
        {
            if (VideoGrabber == null) return;
            VideoGrabber.SetVUMeterSetting(VU_LEFT, setting, (IntPtr)value);
            VideoGrabber.SetVUMeterSetting(VU_RIGHT, setting, (IntPtr)value);
        }

        private int GetLeft(VidGrab.TVUMeterSetting setting)
        {
            if (VideoGrabber == null) return 0;
            return (int)VideoGrabber.GetVUMeterSetting(VU_LEFT, setting);
        }

        private static int Clamp(int v, int lo, int hi)
        {
            if (v < lo) return lo;
            if (v > hi) return hi;
            return v;
        }

        private static int ParseIntDef(string s, int def)
        {
            int v;
            if (int.TryParse(s, out v)) return v;
            return def;
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

        // Pulls every setting from the LEFT channel.
        private void LoadFromGrabber()
        {
            VidGrab.TVuMeter current = VideoGrabber.VuMeter;
            for (int i = 0; i < _meterTypes.Length; i++)
            {
                if (_meterTypes[i] == current)
                {
                    cboVUMeter.SelectedIndex = i;
                    break;
                }
            }

            chkOverlayOverVideo.IsChecked = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayOverVideo) != 0;
            chkTransparent.IsChecked = GetLeft(VidGrab.TVUMeterSetting.vu_Transparent) != 0;
            chkFlipVert.IsChecked = GetLeft(VidGrab.TVUMeterSetting.vu_FlipVert) != 0;
            chkFlipHorz.IsChecked = GetLeft(VidGrab.TVUMeterSetting.vu_FlipHorz) != 0;
            chkLogarithmic.IsChecked = GetLeft(VidGrab.TVUMeterSetting.vu_LogarithmicScale) != 0;

            edtOverlayLeft.Text = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayLeft).ToString();
            edtOverlayTop.Text = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayTop).ToString();
            edtOverlayWidth.Text = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayWidth).ToString();
            edtOverlayHeight.Text = GetLeft(VidGrab.TVUMeterSetting.vu_OverlayHeight).ToString();

            tbrWarningPercent.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_WarningPercent), 0, 100);
            lblWarningPercentValue.Text = ((int)tbrWarningPercent.Value) + " %";
            tbrPeakPercent.Value = Clamp(GetLeft(VidGrab.TVUMeterSetting.vu_PeakPercent), 0, 100);
            lblPeakPercentValue.Text = ((int)tbrPeakPercent.Value) + " %";

            pnBkgndColor.Background = new SolidColorBrush(CorefToColor(GetLeft(VidGrab.TVUMeterSetting.vu_BkgndColor)));
            pnNormalColor.Background = new SolidColorBrush(CorefToColor(GetLeft(VidGrab.TVUMeterSetting.vu_NormalColor)));
            pnWarningColor.Background = new SolidColorBrush(CorefToColor(GetLeft(VidGrab.TVUMeterSetting.vu_WarningColor)));
            pnPeakColor.Background = new SolidColorBrush(CorefToColor(GetLeft(VidGrab.TVUMeterSetting.vu_PeakColor)));

            edtTickSize.Text = GetLeft(VidGrab.TVUMeterSetting.vu_TickSize).ToString();
            edtTickInterval.Text = GetLeft(VidGrab.TVUMeterSetting.vu_TickInterval).ToString();
            edtNeedleThickness.Text = GetLeft(VidGrab.TVUMeterSetting.vu_NeedleThickness).ToString();

            edtAttackMs.Text = GetLeft(VidGrab.TVUMeterSetting.vu_AttackMs).ToString();
            edtReleaseMs.Text = GetLeft(VidGrab.TVUMeterSetting.vu_ReleaseMs).ToString();
            edtPeakHoldMs.Text = GetLeft(VidGrab.TVUMeterSetting.vu_PeakHoldMs).ToString();
            cboBallisticProfile.SelectedIndex = PROFILE_CUSTOM;
        }

        // ====================================================================
        //  Type
        // ====================================================================

        private void cboVUMeter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_loading) return;
            if (cboVUMeter.SelectedIndex < 0) return;
            VidGrab.TVuMeter m = _meterTypes[cboVUMeter.SelectedIndex];
            if (OnApplyType != null)
                OnApplyType(m);
            else if (VideoGrabber != null)
                VideoGrabber.VuMeter = m;
            RefreshControls();
        }

        // ====================================================================
        //  Display options
        // ====================================================================

        private void chkOverlayOverVideo_Changed(object sender, RoutedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_OverlayOverVideo, chkOverlayOverVideo.IsChecked == true ? 1 : 0);
        }

        private void chkTransparent_Changed(object sender, RoutedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_Transparent, chkTransparent.IsChecked == true ? 1 : 0);
        }

        private void chkFlipVert_Changed(object sender, RoutedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_FlipVert, chkFlipVert.IsChecked == true ? 1 : 0);
        }

        private void chkFlipHorz_Changed(object sender, RoutedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_FlipHorz, chkFlipHorz.IsChecked == true ? 1 : 0);
        }

        private void chkLogarithmic_Changed(object sender, RoutedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_LogarithmicScale, chkLogarithmic.IsChecked == true ? 1 : 0);
        }

        // ====================================================================
        //  Overlay rect
        // ====================================================================

        private void edtOverlayLeft_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            if (VideoGrabber == null) return;
            // Per-channel horizontal offset so the two meters don't overlap.
            int left = ParseIntDef(edtOverlayLeft.Text, 0);
            int width = ParseIntDef(edtOverlayWidth.Text, 0);
            VideoGrabber.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr)left);
            VideoGrabber.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_OverlayLeft, (IntPtr)(left + width + 10));
        }

        private void edtOverlayTop_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_OverlayTop, ParseIntDef(edtOverlayTop.Text, 0));
        }

        private void edtOverlayWidth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_OverlayWidth, ParseIntDef(edtOverlayWidth.Text, 0));
            edtOverlayLeft_TextChanged(null, null);
        }

        private void edtOverlayHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_OverlayHeight, ParseIntDef(edtOverlayHeight.Text, 0));
        }

        // ====================================================================
        //  Levels
        // ====================================================================

        private void tbrWarningPercent_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Slider.ValueChanged fires while InitializeComponent parses Value="70",
            // before lblWarningPercentValue (declared later in XAML) exists.
            if (lblWarningPercentValue != null)
                lblWarningPercentValue.Text = ((int)tbrWarningPercent.Value) + " %";
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_WarningPercent, (int)tbrWarningPercent.Value);
        }

        private void tbrPeakPercent_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lblPeakPercentValue != null)
                lblPeakPercentValue.Text = ((int)tbrPeakPercent.Value) + " %";
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_PeakPercent, (int)tbrPeakPercent.Value);
        }

        // ====================================================================
        //  Colors (shared handler dispatched via Tag)
        // ====================================================================

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;
            Border panel;
            VidGrab.TVUMeterSetting setting;
            switch (Convert.ToInt32(btn.Tag))
            {
                case 0: panel = pnBkgndColor; setting = VidGrab.TVUMeterSetting.vu_BkgndColor; break;
                case 1: panel = pnNormalColor; setting = VidGrab.TVUMeterSetting.vu_NormalColor; break;
                case 2: panel = pnWarningColor; setting = VidGrab.TVUMeterSetting.vu_WarningColor; break;
                case 3: panel = pnPeakColor; setting = VidGrab.TVUMeterSetting.vu_PeakColor; break;
                default: return;
            }

            System.Windows.Forms.ColorDialog dlg = new System.Windows.Forms.ColorDialog();
            SolidColorBrush brush = panel.Background as SolidColorBrush;
            if (brush != null)
                dlg.Color = System.Drawing.Color.FromArgb(brush.Color.R, brush.Color.G, brush.Color.B);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int coref = ColorToCoref(dlg.Color);
                panel.Background = new SolidColorBrush(CorefToColor(coref));
                SetBothChannels(setting, coref);
            }
        }

        private void btnDisablePeak_Click(object sender, RoutedEventArgs e)
        {
            SetBothChannels(VidGrab.TVUMeterSetting.vu_PeakHoldMs, 0);
            RefreshControls();
        }

        // ====================================================================
        //  Drawing
        // ====================================================================

        private void edtTickSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_TickSize, ParseIntDef(edtTickSize.Text, 0));
        }

        private void edtTickInterval_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_TickInterval, ParseIntDef(edtTickInterval.Text, 0));
        }

        private void edtNeedleThickness_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_NeedleThickness, ParseIntDef(edtNeedleThickness.Text, 1));
        }

        // ====================================================================
        //  Ballistics
        // ====================================================================

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
            _loading = true;
            try
            {
                edtAttackMs.Text = a.ToString();
                edtReleaseMs.Text = r.ToString();
                edtPeakHoldMs.Text = h.ToString();
            }
            finally
            {
                _loading = false;
            }
        }

        private void cboBallisticProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_loading) return;
            if (cboBallisticProfile.SelectedIndex <= PROFILE_CUSTOM) return;
            ApplyBallisticProfilePreset(cboBallisticProfile.SelectedIndex);
        }

        private void edtAttackMs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_AttackMs, ParseIntDef(edtAttackMs.Text, 0));
            cboBallisticProfile.SelectedIndex = PROFILE_CUSTOM;
        }

        private void edtReleaseMs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_ReleaseMs, ParseIntDef(edtReleaseMs.Text, 0));
            cboBallisticProfile.SelectedIndex = PROFILE_CUSTOM;
        }

        private void edtPeakHoldMs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_loading) return;
            SetBothChannels(VidGrab.TVUMeterSetting.vu_PeakHoldMs, ParseIntDef(edtPeakHoldMs.Text, 0));
            cboBallisticProfile.SelectedIndex = PROFILE_CUSTOM;
        }

        // ====================================================================
        //  Footer
        // ====================================================================

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshControls();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
