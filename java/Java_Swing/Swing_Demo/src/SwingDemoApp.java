import com.datastead.TVideoGrabber.*;
import com.datastead.swing.TVideoGrabber;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.time.Duration;
import java.time.Instant;
import java.util.ArrayList;
import java.util.List;

public class SwingDemoApp {

    private static final boolean SHOW_LOGS_AND_BORDERS = true;

    private static final java.util.List<JSplitPane> horizontalSplits = new java.util.ArrayList<>();
    private static final java.util.List<JComponent> __urlRows = new java.util.ArrayList<>();

    private static JCheckBox chkUseCameraAudio;
    private static JTextArea memoArea;
    private static TVideoGrabber vgMixer;
    private static List<GrabberPane> grabbers;

    static class GrabberPane {
        Instant startTime;
        final TVideoGrabber vgCamera;
        final TVideoGrabber.VideoPanel view;           // Java-rendered video panel (replaces TVideoGrabberWindow)
        final JList<String> logList;
        final DefaultListModel<String> logModel;
        final JTextField urlField;
        final int deviceIndex;

        GrabberPane(int deviceIndex) {
            this.deviceIndex = deviceIndex;
            this.vgCamera = new TVideoGrabber();
            this.vgCamera.setVideoSource(TVideoSource.vs_IPCamera);
            this.view = new TVideoGrabber.VideoPanel();
            this.view.setBackground(Color.BLACK);
            try { this.view.setOpaque(true); } catch (Throwable ignored) {}
            this.view.setPreferredSize(new Dimension(240, 180));
            this.vgCamera.setPanel(this.view);         // setView(...) was removed in the current SDK
            this.vgCamera.setVideoDevice(deviceIndex);

            this.logModel = new DefaultListModel<>();
            this.logList = new JList<>(logModel);
            this.logList.setBorder(new EmptyBorder(2,2,2,2));

            this.urlField = new JTextField();
            // noinspection SpellCheckingInspection
            urlField.setText("rtsp://user:password@192.168.0.25/axis-media/media.amp?videocodec=h264&audio=1"); // replace by your ip camera url
            this.urlField.setToolTipText("Enter IP camera URL for device " + deviceIndex);

            TOnEventNotification OnFirstFrameReceivedCB = () -> {
                Duration elapsed = Duration.between(startTime, Instant.now());
                long hours   = elapsed.toHours();
                long minutes = elapsed.toMinutesPart();
                long seconds = elapsed.toSecondsPart();
                long millis  = elapsed.toMillisPart();
                GrabberPane.this.appendLog(String.format("%02d:%02d:%02d.%03d", hours, minutes, seconds, millis));
            };


            TOnLog OnLogCB = (logType, severity, msg) -> {
                GrabberPane.this.appendLog("[" + (severity != null ? severity : String.valueOf(logType)) + "] " + msg);
            };
            this.vgCamera.setOnFirstFrameReceived (OnFirstFrameReceivedCB);
            this.vgCamera.setOnLog(OnLogCB);

        }

        private void appendLog(String line) {
            SwingUtilities.invokeLater(() -> {
                final int MAX = 1000;
                if (logModel.getSize() >= MAX) {
                    logModel.remove(0);
                }
                logModel.addElement(line);
                int last = logModel.getSize() - 1;
                if (last >= 0) logList.ensureIndexIsVisible(last);
            });
        }

        void applyUrlToGrabber() {
            String url = urlField.getText() != null ? urlField.getText().trim() : "";
            if (!url.isEmpty()) {
                try {
                    vgCamera.setIPCameraURL(url);
                    appendLog("URL set: " + url);
                } catch (Throwable ex) {
                    appendLog("Failed to set URL: " + ex.getMessage());
                }
            }
        }
    }

    private static void __applyShowLogsConstant(JPanel mosaic, JPanel leftColumn) {
        LayoutManager lm = mosaic.getLayout();
        if (SHOW_LOGS_AND_BORDERS) {
            // Restore spacing/borders and show logs + URL rows + memo
            if (lm instanceof java.awt.GridLayout gl) {
                gl.setHgap(12);
                gl.setVgap(12);
            }
            mosaic.setBorder(new EmptyBorder(12,12,12,12));
            mosaic.setBackground(new Color(0x20,0x20,0x20));
            if (leftColumn != null) leftColumn.setVisible(true);
            for (JSplitPane sp : horizontalSplits) {
                if (sp == null) continue;
                try { sp.setDividerSize(6); } catch (Throwable ignored) {}
                try { sp.setDividerLocation(0.25); } catch (Throwable ignored) {}
                java.awt.Component left = sp.getLeftComponent();
                if (left instanceof JComponent jc) jc.setVisible(true);
            }
            for (JComponent urlRow : __urlRows) {
                if (urlRow != null) urlRow.setVisible(true);
            }
            // Reset per-cell borders to a small padding (if any)
            for (java.awt.Component c : mosaic.getComponents()) {
                if (c instanceof JPanel p) {
                    p.setBorder(new EmptyBorder(4,4,4,4));
                }
            }

        } else {
            // Hide all logs (left components of the splits) and memo; remove borders/gaps
            if (lm instanceof java.awt.GridLayout gl) {
                gl.setHgap(0);
                gl.setVgap(0);
            }
            mosaic.setBorder(null); //new EmptyBorder(0,0,0,0));
            mosaic.setBackground(Color.BLACK);
            if (leftColumn != null) leftColumn.setVisible(false);
            for (JSplitPane sp : horizontalSplits) {
                if (sp == null) continue;
                sp.setBorder(null);
                try { sp.setDividerLocation(0.0); } catch (Throwable ignored) {}
                try { sp.setDividerSize(0); } catch (Throwable ignored) {}
                java.awt.Component left = sp.getLeftComponent();
                if (left instanceof JComponent jc) jc.setVisible(false);
                // Make right component (the video view) fully fill
                java.awt.Component right = sp.getRightComponent();
                if (right instanceof JComponent jc) {
                    jc.setOpaque(true);
                    jc.setBackground(Color.BLACK);
                    for (java.awt.Component cc : jc.getComponents()) {
                        if (cc instanceof JComponent jj) {
                            try { jj.setOpaque(true); } catch (Throwable ignored) {}
                            try { jj.setBackground(Color.BLACK); } catch (Throwable ignored) {}
                            try { jj.setBorder(null); } catch (Throwable ignored) {}
                        }
                    }
                }
            }
            for (JComponent urlRow : __urlRows) {
                if (urlRow != null) urlRow.setVisible(false);
            }
            // Remove per-cell borders and force black background so seams disappear
            for (java.awt.Component c : mosaic.getComponents()) {
                if (c instanceof JPanel p) {
                    p.setBorder(new EmptyBorder(0,0,0,0));
                    p.setOpaque(true);
                    p.setBackground(Color.BLACK);
                }
            }
        }

        mosaic.revalidate();
        mosaic.repaint();
    }
    private static void destroyView(TVideoGrabber grabber, TVideoGrabber.VideoPanel view) {
        if (grabber != null) {
            try { grabber.setOnLog(null); } catch (Throwable ignored) {}
            try { grabber.setPanel(null); } catch (Throwable ignored) {}  // detaches view and clears frame buffers
            try { grabber.stop(); }         catch (Throwable ignored) {}
        }
        if (view != null) {
            try {
                // remove from parent so AWT destroys native peer cleanly
                Container parent = view.getParent();
                if (parent != null) {
                    parent.remove(view);
                    parent.revalidate();
                    parent.repaint();
                }
            } catch (Throwable ignored) {}
        }
    }

    public static void ApplyMixerOptions()
    {
        if (chkUseCameraAudio.isSelected()) {
            vgMixer.setAudioRecording(true);
            vgMixer.setAudioSource(TAudioSource.as_IPcamera);
            String AudioSourceURL = grabbers.get(0).vgCamera.getIPCameraURL();
            vgMixer.setIPCameraURL(AudioSourceURL);
        } else
        {
            vgMixer.setAudioRecording(false);
            vgMixer.setAudioSource(TAudioSource.as_Default);
            vgMixer.setAudioDevice(-1);
        }

    }

    public static void main(String[] args) {

        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("TVideoGrabber SDK 2x2 IP cameras layout -> disable SHOW_LOGS_AND_BORDERS to hide the logs");
            frame.getRootPane().setBorder(null);
            //frame.setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
            frame.setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);

            // Create 4 grabbers mapped to devices 0..3
            grabbers = new ArrayList<>();
            for (int i = 0; i < 4; i++) {
                grabbers.add(new GrabberPane(i));
            }

            // --- Mosaic panel (2x2) ---
            JPanel mosaic = new JPanel(new GridLayout(2, 2, 12, 12));
            mosaic.setBorder(new EmptyBorder(12, 12, 12, 12));
            mosaic.setBackground(new Color(0x20,0x20,0x20));

            for (GrabberPane gp : grabbers) {
                JPanel cell = new JPanel(new BorderLayout(6, 6));
                cell.setBackground(Color.BLACK);
                cell.setBorder(new EmptyBorder(4,4,4,4));

                // URL field at the top
                JPanel urlRow = new JPanel(new BorderLayout(6, 0));
                JLabel urlLbl = new JLabel("URL:");
                urlRow.add(urlLbl, BorderLayout.WEST);
                urlRow.add(gp.urlField, BorderLayout.CENTER);
                cell.add(urlRow, BorderLayout.NORTH);
                __urlRows.add(urlRow);

                // Center area: log list (left) + video window (right)
                JSplitPane horizontalSplit = new JSplitPane(JSplitPane.HORIZONTAL_SPLIT,
                        new JScrollPane(gp.logList), gp.view);
                horizontalSplits.add(horizontalSplit);
                horizontalSplit.setResizeWeight(0.25); // ~1/4 for logs, 3/4 for video
                horizontalSplit.setContinuousLayout(true);
                horizontalSplit.setDividerSize(6);
                cell.add(horizontalSplit, BorderLayout.CENTER);

                mosaic.add(cell);
            }

            // --- Bottom left: memo ---
            JPanel leftColumn = new JPanel(new BorderLayout(10, 10));
            leftColumn.setBorder(new EmptyBorder(10, 10, 10, 10));

            memoArea = new JTextArea();
            memoArea.setLineWrap(true);
            memoArea.setWrapStyleWord(true);
            memoArea.setFont(new Font(Font.MONOSPACED, Font.PLAIN, 12));
            memoArea.setBorder(BorderFactory.createCompoundBorder(
                    BorderFactory.createLineBorder(new Color(0x88,0x88,0x88)),
                    new EmptyBorder(6,6,6,6)
            ));
            memoArea.setColumns(20);
            memoArea.setRows(10);

            JScrollPane memoScroll = new JScrollPane(memoArea,
                    ScrollPaneConstants.VERTICAL_SCROLLBAR_AS_NEEDED,
                    ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
            leftColumn.add(memoScroll, BorderLayout.CENTER);

            // --- Bottom middle: a TVideoGrabber view (control/monitor) ---
            vgMixer = new TVideoGrabber();
            vgMixer.setVideoSource(TVideoSource.vs_Mixer);
            vgMixer.useNearestVideoSize(1920, 1080, true);
            vgMixer.setMixer_MosaicLines(2);
            vgMixer.setMixer_MosaicColumns(2);

            int iColumn = 1;
            int iLine = 1;
            for (GrabberPane gp : grabbers) {
                try {
                    int GrabberUniqueID = gp.vgCamera.getUniqueID();
                    vgMixer.mixer_AddToMixer(GrabberUniqueID, 0, iLine, iColumn, 0, 0, true, false);
                    iLine ++;
                    if (iLine == 3) {
                        iLine = 1;
                        iColumn ++;
                    }
                } catch (Throwable ignored) {}
            }

            TVideoGrabber.VideoPanel controlView = new TVideoGrabber.VideoPanel();
            controlView.setBackground(Color.BLACK);
            try { controlView.setOpaque(true); } catch (Throwable ignored) {}
            controlView.setPreferredSize(new Dimension(400, 240));
            vgMixer.setPanel(controlView);
            // Optionally: vgMixer.setVideoDevice(0);

            JPanel midVideoPanel = new JPanel(new BorderLayout());
            midVideoPanel.setBorder(new EmptyBorder(10, 0, 10, 0));
            midVideoPanel.add(controlView, BorderLayout.CENTER);
            // Log vgMixer messages into the left memo (text log)
            TVideoGrabber.TOnLog controlLog = (logType, severity, msg) -> {
                String sev = (severity != null ? severity : String.valueOf(logType));
                SwingUtilities.invokeLater(() -> memoArea.append("[" + sev + "] " + msg + "\n"));
            };
            try { vgMixer.setOnLog(controlLog); } catch (Throwable ignored) {}


            // --- Bottom right: buttons + recording method radios (non-stretching) ---
            JPanel rightControls = new JPanel();
            rightControls.setLayout(new BoxLayout(rightControls, BoxLayout.Y_AXIS));
            rightControls.setBorder(new EmptyBorder(0, 10, 0, 10));

            // Buttons row (top)
            JPanel buttonRow = new JPanel(new FlowLayout(FlowLayout.LEFT, 10, 10));
            JButton btnPreview = new JButton("mixer preview");
            JButton btnRecord  = new JButton("mixer recording");
            JButton btnStop    = new JButton("mixer stop");
            buttonRow.add(btnPreview);
            buttonRow.add(btnRecord);
            buttonRow.add(btnStop);
            buttonRow.setAlignmentX(Component.LEFT_ALIGNMENT);
            buttonRow.setMaximumSize(new Dimension(Integer.MAX_VALUE, buttonRow.getPreferredSize().height));


            // Cameras row (above): start/stop only the 4 mosaic cameras (not the control grabber)
            JPanel camsRow = new JPanel(new FlowLayout(FlowLayout.LEFT, 10, 10));
            JButton btnStartCams = new JButton("Start cameras");
            JButton btnStopCams  = new JButton("Stop cameras");
            JCheckBox chkOpenURLAsync = new JCheckBox("open URL asynchronously", null, true);
            camsRow.add(btnStartCams);
            camsRow.add(btnStopCams);
            camsRow.add(chkOpenURLAsync);
            camsRow.setAlignmentX(Component.LEFT_ALIGNMENT);
            camsRow.setMaximumSize(new Dimension(Integer.MAX_VALUE, camsRow.getPreferredSize().height));
            // Radio group (below buttons)
            JPanel radioPanel = new JPanel();
            radioPanel.setLayout(new BoxLayout(radioPanel, BoxLayout.Y_AXIS));
            radioPanel.setBorder(BorderFactory.createTitledBorder("Rec. Method"));
            radioPanel.setAlignmentX(Component.LEFT_ALIGNMENT);
            radioPanel.setMaximumSize(new Dimension(Integer.MAX_VALUE, radioPanel.getPreferredSize().height));

            ButtonGroup recGroup = new ButtonGroup();

            // Track current recording method (also applied to vgMixer)
            final TVideoGrabber.TRecordingMethod[] currentMethod = {
                    TVideoGrabber.TRecordingMethod.rm_ASF
            };

            JRadioButton rbAsf = new JRadioButton("ASF (WMV)");
            rbAsf.addActionListener(e -> {
                currentMethod[0] = TVideoGrabber.TRecordingMethod.rm_ASF;
                vgMixer.setRecordingMethod(currentMethod[0]);
            });
            recGroup.add(rbAsf);
            radioPanel.add(rbAsf);

            JRadioButton rbAvi = new JRadioButton("AVI");
            rbAvi.addActionListener(e -> {
                currentMethod[0] = TVideoGrabber.TRecordingMethod.rm_AVI;
                vgMixer.setRecordingMethod(currentMethod[0]);
            });
            recGroup.add(rbAvi);
            radioPanel.add(rbAvi);

            JRadioButton rbMp4 = new JRadioButton("MP4");
            rbMp4.addActionListener(e -> {
                currentMethod[0] = TVideoGrabber.TRecordingMethod.rm_MP4;
                vgMixer.setRecordingMethod(currentMethod[0]);
            });
            recGroup.add(rbMp4);
            radioPanel.add(rbMp4);

            JRadioButton rbMkv = new JRadioButton("MKV");
            rbMkv.addActionListener(e -> {
                currentMethod[0] = TVideoGrabber.TRecordingMethod.rm_MKV;
                vgMixer.setRecordingMethod(currentMethod[0]);
            });
            recGroup.add(rbMkv);
            radioPanel.add(rbMkv);

            rbAsf.setSelected(true);
            vgMixer.setRecordingMethod(currentMethod[0]);

            buttonRow.setMaximumSize(buttonRow.getPreferredSize());
            radioPanel.setMaximumSize(radioPanel.getPreferredSize());

            rightControls.add(camsRow);
            rightControls.add(buttonRow);

            JPanel recMethodRow = new JPanel(new FlowLayout(FlowLayout.LEFT, 10, 0));
            recMethodRow.add(radioPanel);

            chkUseCameraAudio = new JCheckBox("use camera 1 audio", null, true);
            chkUseCameraAudio.setToolTipText("If enabled, use audio from camera #1 in the mixer");
            recMethodRow.add(chkUseCameraAudio);

            recMethodRow.setAlignmentX(Component.LEFT_ALIGNMENT);
            recMethodRow.setMaximumSize(new Dimension(Integer.MAX_VALUE, recMethodRow.getPreferredSize().height));

            rightControls.add(recMethodRow);

            rightControls.add(Box.createVerticalGlue());

            JSplitPane bottomLeftMid = new JSplitPane(
                    JSplitPane.HORIZONTAL_SPLIT, true, leftColumn, midVideoPanel);
            bottomLeftMid.setContinuousLayout(true);
            bottomLeftMid.setDividerSize(6);

            JSplitPane bottomSplit = new JSplitPane(
                    JSplitPane.HORIZONTAL_SPLIT, true, bottomLeftMid, rightControls);

            __applyShowLogsConstant(mosaic, leftColumn);
            bottomSplit.setContinuousLayout(true);
            bottomSplit.setDividerSize(6);


            // Start/Stop cameras (4 mosaic grabbers only)
            btnStartCams.addActionListener(e -> {
                for (GrabberPane gp : grabbers) {
                    try {
                        gp.logModel.clear();
                        gp.applyUrlToGrabber();
                        gp.startTime = Instant.now();
                        gp.vgCamera.setOpenURLAsync(chkOpenURLAsync.isSelected());
                        gp.vgCamera.setVideoSource(TVideoSource.vs_VideoCaptureDevice);
                        gp.vgCamera.setVideoDevice(4);
                        gp.vgCamera.startPreview();
                        break;
                    } catch (Throwable ex) {
                        gp.appendLog("Start camera failed: " + ex.getMessage());
                    }
                }
            });
            btnStopCams.addActionListener(e -> {
                for (GrabberPane gp : grabbers) {
                    try {
                        gp.logModel.clear();
                        gp.vgCamera.stop();
                    } catch (Throwable ex) {
                        gp.appendLog("Stop camera failed: " + ex.getMessage());
                    }
                }
            });

            btnPreview.addActionListener(e -> {
                memoArea.setText("");
                ApplyMixerOptions();
                vgMixer.startPreview();
            });

            btnRecord.addActionListener(e -> {
                memoArea.setText("");
                vgMixer.stopPreview();
                ApplyMixerOptions();
                if (!vgMixer.startRecording()) {
                    //memoArea.appendLog("StartRecording failed");
                }
            });

            btnStop.addActionListener(e -> {
                // Control-only stop
                memoArea.setText("");
                vgMixer.stop();
            });

            // --- Main split: top mosaic + bottom controls ---
            // noinspection SuspiciousNameCombination
            JSplitPane split = new JSplitPane(JSplitPane.VERTICAL_SPLIT, true, mosaic, bottomSplit);
            split.setResizeWeight(0.66);
            split.setDividerSize(6);
            split.setContinuousLayout(true);

            frame.getContentPane().setLayout(new BorderLayout());
            frame.getContentPane().add(split, BorderLayout.CENTER);

            frame.addWindowListener(new WindowAdapter() {
                @Override public void windowClosing(WindowEvent e) {
                    frame.setEnabled(false);

                    // 1) Mosaic grabbers: detach & remove their views
                    for (GrabberPane gp : grabbers) {
                        destroyView(gp.vgCamera, gp.view);
                    }

                    // 2) Middle control grabber: detach & remove its view
                    destroyView(vgMixer, controlView);

                    // 3) Dispose the window (destroys all remaining peers)
                    frame.dispose();
                    System.exit(0);
                }
            });

            frame.setSize(1400, 800);
            frame.setLocationRelativeTo(null);
            frame.setVisible(true);

            // --- Set divider locations as proportions of TOTAL width (after visible) ---
            int totalW = frame.getWidth();
            // memo = 20% of total width
            bottomLeftMid.setDividerLocation((int)(0.20 * totalW));
            // (memo + mid) = 60% of total width -> buttons = 40%
            bottomSplit.setDividerLocation((int)(0.60 * totalW));

            // Optional minimum sizes so dividers don't collapse completely
            leftColumn.setMinimumSize(new Dimension(160, 0));
            midVideoPanel.setMinimumSize(new Dimension(160, 0));
            rightControls.setMinimumSize(new Dimension(160, 0));
        });
    }
}
