package com.datastead.headless;

import com.datastead.TVideoGrabber;
import java.text.SimpleDateFormat;
import java.util.*;
import java.nio.file.*;
import java.time.Duration;
import java.time.Instant;

public class HeadlessMixer {

    private static final int MIXER_OUT_WIDTH  = 1920;
    private static final int MIXER_OUT_HEIGHT = 1080;

    private static final boolean RECORD_IN_NATIVE = false;
    private static final int VIDEO_BITRATE = 6_000_000;

    private static final long OPEN_URL_TIMEOUT_MS = 20_000;

    // 4 sources
    private final List<GrabberPane> grabbers = new ArrayList<>(4);

    // Mixer
    private final TVideoGrabber midVideoGrabber = new TVideoGrabber();

    private volatile boolean running = true;

    public static void main(String[] args) {
        List<String> urls = parseURLs(args);
        if (urls.size() != 4) {
            System.err.println("Provide 4 RTSP URLs as args or set RTSP_URLS=rtsp1;rtsp2;rtsp3;rtsp4");
            System.exit(2);
        }

        HeadlessMixer app = new HeadlessMixer(urls);
        Runtime.getRuntime().addShutdownHook(new Thread(app::shutdown, "shutdown"));

        app.startAll(true);

        // Start background thread to watch console input
        Thread consoleWatcher = new Thread(() -> {
            System.out.println("Press 'Q' then Enter to quit...");
            try (Scanner sc = new Scanner(System.in)) {
                while (app.running) {
                    if (sc.hasNextLine()) {
                        String line = sc.nextLine().trim();
                        if (line.equalsIgnoreCase("q")) {
                            System.out.println("Exit requested (Q).");
                            app.running = false;
                            app.shutdown();
                            break;
                        }
                    }
                }
            } catch (Throwable ignored) {}
        }, "ConsoleWatcher");
        consoleWatcher.setDaemon(true);
        consoleWatcher.start();

        // Keep alive until Ctrl+C or Q
        try {
            while (app.running) {
                Thread.sleep(500);
            }
        } catch (InterruptedException ignored) {}

        // When loop exits normally (Q pressed)
        app.shutdown();
        System.out.println("Exiting.");
    }

    private static List<String> parseURLs(String[] args) {
        if (args != null && args.length == 4) return Arrays.asList(args);
        String env = System.getenv("RTSP_URLS");
        if (env != null && !env.isBlank()) {
            String[] parts = env.split(";");
            if (parts.length == 4) return Arrays.asList(parts);
        }
        return Collections.emptyList();
    }

    public HeadlessMixer(List<String> urls) {
        for (int i = 0; i < 4; i++) {
            grabbers.add(new GrabberPane(urls.get(i)));
        }

        midVideoGrabber.setVideoSource(TVideoGrabber.TVideoSource.vs_Mixer);
		midVideoGrabber.setVideoRenderer(TVideoGrabber.TVideoRenderer.vr_None);
        midVideoGrabber.setDisplayEmbedded(0, false);
        midVideoGrabber.useNearestVideoSize(1920, 1080, true);
        midVideoGrabber.setMixer_MosaicLines(2);
        midVideoGrabber.setMixer_MosaicColumns(2);

        // Add sources to mixer
        int iColumn = 1;
        int iLine = 1;
        for (GrabberPane gp : grabbers) {
            try {
                int GrabberUniqueID = gp.grabber.getUniqueID();
                midVideoGrabber.mixer_AddToMixer(GrabberUniqueID, 0, iLine, iColumn, 0, 0, true, false);
                iLine++;
                if (iLine == 3) {
                    iLine = 1;
                    iColumn++;
                }
            } catch (Throwable ignored) {}
        }

        // logger
        midVideoGrabber.setOnLog((logType, severity, msg) -> {
            String line = "[" + severity + "] " + msg;
            System.out.println("[MIXER] " + line);
        });
    }

    // ---------- Actions ----------
    private void startAll(boolean recording) {
        System.out.println("Starting " + (recording ? "recording" : "preview") + "...");
        Instant t0 = Instant.now();

        for (GrabberPane gp : grabbers) {
            gp.applyUrl();
            gp.startPreview();
        }

        try {
            if (!grabbers.isEmpty()) {
                String url = grabbers.get(0).getUrl();
                if (url != null && !url.isEmpty()) midVideoGrabber.setIPCameraURL(url);
            }
            if (recording) {
				configureRecordingMixer(midVideoGrabber);
				midVideoGrabber.setRecordingMethod(TVideoGrabber.TRecordingMethod.rm_ASF);
				midVideoGrabber.startRecording(); 
			}
			else {
				midVideoGrabber.startPreview();
			}
        } catch (Throwable ex) {
            System.err.println("MidPreview error: " + ex.getMessage());
        }

        System.out.println("Started in " + Duration.between(t0, Instant.now()).toMillis() + " ms");
    }

    private void stopAll() {
        Instant t0 = Instant.now();
        for (GrabberPane gp : grabbers) gp.stop();
        try { midVideoGrabber.stop(); } catch (Throwable ignore) {}
        System.out.println("Stopped in " + Duration.between(t0, Instant.now()).toMillis() + " ms");
    }

    public void shutdown() {
        if (!running) return;
        running = false;
        System.out.println("\nShutting down...");
        stopAll();
        for (GrabberPane gp : grabbers) try { gp.grabber.dispose(); } catch (Throwable ignored) {}
        try { midVideoGrabber.dispose(); } catch (Throwable ignored) {}
        System.out.println("Shutdown complete.");
    }

    // ---------- one camera handler ----------
    private static final class GrabberPane {
        final TVideoGrabber grabber = new TVideoGrabber();
        final String url;

        GrabberPane(String url) {
            this.url = url != null ? url.trim() : "";
            grabber.setVideoSource(TVideoGrabber.TVideoSource.vs_IPCamera);
			grabber.setVideoRenderer(TVideoGrabber.TVideoRenderer.vr_None);

            grabber.setOnLog((logType, severity, infoMsg) -> {
                String line = "[" + severity + "] " + infoMsg;
                System.out.println("[SRC] " + line);
            });
        }

        String getUrl() { return url; }

        void applyUrl() {
            if (!url.isEmpty()) {
                try { grabber.setIPCameraURL(url); }
                catch (Throwable ex) { System.err.println("Cam URL error: " + ex.getMessage()); }
            }
        }

        void startPreview() {
            try { grabber.startPreview(); }
            catch (Throwable ex) { System.err.println("Preview error: " + ex.getMessage()); }
        }

        void startRecording() {
            try { grabber.startRecording(); }
            catch (Throwable ex) { System.err.println("Recording error: " + ex.getMessage()); }
        }

        void stop() { try { grabber.stop(); } catch (Throwable ignore) {} }
    }

    @SuppressWarnings("unused")
    private static void configureRecordingMixer(TVideoGrabber g) {
        String base = new SimpleDateFormat("yyyyMMdd_HHmmss").format(new Date());
        String file = "mosaic_" + base + ".asf";
        try { Files.createDirectories(Paths.get(".").toAbsolutePath()); } catch (Exception ignored) {}
        try { g.setRecordingFileName(file); } catch (Throwable ignored) {}
        try { g.setRecordingMethod(TVideoGrabber.TRecordingMethod.rm_ASF); } catch (Throwable ignored) {}
    }
}
