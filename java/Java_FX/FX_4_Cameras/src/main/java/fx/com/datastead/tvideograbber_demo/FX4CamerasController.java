package fx.com.datastead.tvideograbber_demo;

import com.datastead.fx.TVideoGrabber;
import javafx.application.Platform;
import javafx.beans.property.SimpleStringProperty;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Node;
import javafx.scene.control.*;
import javafx.scene.image.ImageView;
import javafx.scene.layout.*;
import javafx.scene.text.Font;

import java.time.Duration;
import java.time.Instant;
import java.util.ArrayList;
import java.util.List;

public class FX4CamerasController {

    public Pane getRoot() { return root; }

    // ---------- Root ----------
    private final BorderPane root = new BorderPane();

    // ---------- Top mosaic (2×2) ----------
    private final GridPane mosaic = new GridPane();
    private final List<GrabberPane> grabbers = new ArrayList<>(4);

    // ---------- Bottom mixer preview ----------
    private final TVideoGrabber midVideoGrabber = new TVideoGrabber();
    private final ImageView videoImageView = new ImageView();
    private final ObservableList<String> midLogItems = FXCollections.observableArrayList();
    private final ListView<String> midLogList = new ListView<>(midLogItems);

    // ---------- Bottom controls ----------
    private final TextArea memoArea = new TextArea();
    private final SimpleStringProperty statusText = new SimpleStringProperty("Ready");
    private final Label statusLabel = new Label();
    private final Button btnStartPreview = new Button("Start Preview");
    private final Button btnStartRecording = new Button("Start Recording");
    private final Button btnStopAll = new Button("Stop All");
    private final ToggleGroup scaleGroup = new ToggleGroup();
    private final RadioButton rbFit = new RadioButton("Fit");
    private final RadioButton rbFill = new RadioButton("Fill");
    private final RadioButton rbStretch = new RadioButton("Stretch");

    // ---------- Constructor ----------
    public FX4CamerasController() {
        buildUI();
        wireEvents();
    }

    public void shutdown() {
        stopAll();
        for (GrabberPane gp : grabbers) gp.grabber.dispose();
        midVideoGrabber.dispose();
    }

    private void buildUI() {
        // ===== Mosaic (2 columns, equal width) =====
        mosaic.setHgap(6);
        mosaic.setVgap(6);
        mosaic.setPadding(new Insets(6));

        ColumnConstraints c = new ColumnConstraints();
        c.setHgrow(Priority.ALWAYS);
        c.setPercentWidth(50);
        mosaic.getColumnConstraints().addAll(c, c);

        // Rows do not force-grow; height driven by children (16:9 binding)
        RowConstraints r = new RowConstraints();
        r.setVgrow(Priority.NEVER);
        r.setFillHeight(true);
        mosaic.getRowConstraints().addAll(r, r);

        for (int i = 0; i < 4; i++) {
            GrabberPane gp = new GrabberPane(i);
            grabbers.add(gp);
            mosaic.add(gp.container, i % 2, i / 2);
        }

        // ===== Bottom: mixer [log | 16:9 video] + controls; memo below =====

        // Mixer video view (center-left, 16:9)
        videoImageView.setPreserveRatio(true);
        videoImageView.setFitWidth(640);
        videoImageView.setFitHeight(360);

        StackPane midWrapper = new StackPane(videoImageView);
        midWrapper.setStyle("-fx-background-color: black; -fx-border-color: red; -fx-border-width: 1;"); // remove border later
        midWrapper.setPrefSize(640, 360);
        midWrapper.prefHeightProperty().bind(midWrapper.widthProperty().multiply(9.0 / 16.0));
        HBox.setHgrow(midWrapper, Priority.ALWAYS);

        // Mixer log (left of video)
        midLogList.setFocusTraversable(false);
        midLogList.setPrefWidth(260);
        midLogList.setMinWidth(180);
        midLogList.setMaxWidth(360);
        midLogList.prefHeightProperty().bind(midWrapper.heightProperty());

        // Link mixer grabber to the ImageView + logs
        midVideoGrabber.setVideoSource(TVideoGrabber.TVideoSource.vs_Mixer);
        midVideoGrabber.useNearestVideoSize(1920, 1080, true);
        midVideoGrabber.setMixer_MosaicLines(2);
        midVideoGrabber.setMixer_MosaicColumns(2);

        int iColumn = 1;
        int iLine = 1;
        for (GrabberPane gp : grabbers) {
            try {
                int GrabberUniqueID = gp.grabber.getUniqueID();
                midVideoGrabber.mixer_AddToMixer(GrabberUniqueID, 0, iLine, iColumn, 0, 0, true, false);
                iLine ++;
                if (iLine == 3) {
                    iLine = 1;
                    iColumn ++;
                }
            } catch (Throwable ignored) {}
        }

        midVideoGrabber.setView(videoImageView);
        midVideoGrabber.setOnLog((logType, severity, msg) -> {
            String line = "[" + severity + "] " + msg;
            Platform.runLater(() -> {
                if (midLogItems.size() > 5000) midLogItems.remove(0, 1000);
                midLogItems.add(line);
                midLogList.scrollTo(midLogItems.size() - 1);
            });
        });

        // Left composite of the bottom row: [log | video]
        HBox mixerLeft = new HBox(6, midLogList, midWrapper);
        mixerLeft.setFillHeight(true);
        HBox.setHgrow(mixerLeft, Priority.ALWAYS);

        // Controls (right)
        HBox buttons = new HBox(8, btnStartPreview, btnStartRecording, btnStopAll);
        buttons.setAlignment(Pos.CENTER_LEFT);

        rbFit.setToggleGroup(scaleGroup);
        rbFill.setToggleGroup(scaleGroup);
        rbStretch.setToggleGroup(scaleGroup);
        rbFit.setSelected(true);

        HBox radios = new HBox(12, new Label("Scaling:"), rbFit, rbFill, rbStretch);
        radios.setAlignment(Pos.CENTER_LEFT);

        VBox controls = new VBox(10, buttons, radios);
        controls.setPadding(new Insets(6));
        controls.setMinWidth(260);

        // Bottom top row: [ mixerLeft | controls ]
        HBox bottomTopRow = new HBox(12, mixerLeft, controls);
        bottomTopRow.setPadding(new Insets(6));
        HBox.setHgrow(mixerLeft, Priority.ALWAYS);

        // Memo below
        memoArea.setPromptText("Memo / output...");
        memoArea.setFont(Font.font("Consolas", 12));
        memoArea.setPrefRowCount(4);

        // Status bar
        statusLabel.textProperty().bind(statusText);

        // Assemble bottom
        VBox bottomBox = new VBox(6, bottomTopRow, memoArea, statusLabel);

        // ===== Root =====
        root.setTop(mosaic);
        root.setCenter(null);          // center unused now; everything is top/bottom
        root.setBottom(bottomBox);
    }

    private void wireEvents() {
        btnStartPreview.setOnAction(e -> startAll(false));
        btnStartRecording.setOnAction(e -> startAll(true));
        btnStopAll.setOnAction(e -> stopAll());
    }

    // ---------- Actions ----------
    private void startAll(boolean recording) {
        statusText.set("Starting " + (recording ? "recording" : "preview") + "...");
        Instant t0 = Instant.now();

        for (GrabberPane gp : grabbers) {
            gp.applyUrl();
            if (recording) gp.startRecording(); else gp.startPreview();
        }

        try {
            if (!grabbers.isEmpty()) {
                String url = grabbers.get(0).urlField.getText().trim();
                if (!url.isEmpty()) midVideoGrabber.setIPCameraURL(url);
            }
            if (recording) midVideoGrabber.startRecording(); else midVideoGrabber.startPreview();
        } catch (Throwable ex) {
            appendMemo("MidPreview error: " + ex.getMessage());
        }

        statusText.set("Started in " + Duration.between(t0, Instant.now()).toMillis() + " ms");
    }

    private void stopAll() {
        Instant t0 = Instant.now();
        for (GrabberPane gp : grabbers) gp.stop();
        try { midVideoGrabber.stop(); } catch (Throwable ignore) {}
        statusText.set("Stopped in " + Duration.between(t0, Instant.now()).toMillis() + " ms");
    }

    private void appendMemo(String s) {
        Platform.runLater(() -> {
            if (memoArea.getText().length() > 200_000) memoArea.clear();
            memoArea.appendText(s + System.lineSeparator());
        });
    }

    // ---------- Helpers ----------
    private Node grow(Node n) {
        VBox.setVgrow(n, Priority.ALWAYS);
        HBox.setHgrow(n, Priority.ALWAYS);
        return n;
    }

    // ---------- One cell in the 2×2 mosaic ----------
    private final class GrabberPane {
        final TVideoGrabber grabber = new TVideoGrabber();
        final ImageView videoImageView = new ImageView();
        final TextField urlField = new TextField();
        final ObservableList<String> logItems = FXCollections.observableArrayList();
        final ListView<String> logList = new ListView<>(logItems);

        final VBox container = new VBox(4);

        GrabberPane(int index) {
            urlField.setText("rtsp://user:password@192.168.5.32/axis-media/media.amp?videocodec=h264&audio=1");
            urlField.setPrefColumnCount(24);

            grabber.setVideoSource(com.datastead.TVideoGrabber.TVideoSource.vs_IPCamera);
            grabber.setView(videoImageView);

            // Video view (16:9)
            videoImageView.setPreserveRatio(true);
            videoImageView.setFitWidth(320);
            videoImageView.setFitHeight(180);

            StackPane videoWrapper = new StackPane(videoImageView);
            videoWrapper.setStyle("-fx-background-color: black; -fx-border-color: red; -fx-border-width: 1;"); // remove border later
            videoWrapper.setPrefSize(480, 270);
            videoWrapper.prefHeightProperty().bind(videoWrapper.widthProperty().multiply(9.0 / 16.0));
            HBox.setHgrow(videoWrapper, Priority.ALWAYS);

            // Log (left of video)
            logList.setFocusTraversable(false);
            logList.setPrefWidth(220);
            logList.setMinWidth(160);
            logList.setMaxWidth(320);
            logList.prefHeightProperty().bind(videoWrapper.heightProperty());

            grabber.setOnLog((logType, severity, infoMsg) -> {
                final String line = "[" + severity + "] " + infoMsg;
                Platform.runLater(() -> {
                    if (logItems.size() > 5000) logItems.remove(0, 1000);
                    logItems.add(line);
                    logList.scrollTo(logItems.size() - 1);
                });
            });

            // Row = [ log | video ]
            HBox row = new HBox(6, logList, videoWrapper);
            row.setFillHeight(true);

            // Container = URL on top + row
            container.getChildren().setAll(urlField, row);
            container.setFillWidth(true);
        }

        void applyUrl() {
            String url = urlField.getText().trim();
            if (!url.isEmpty()) {
                try { grabber.setIPCameraURL(url); }
                catch (Throwable ex) { appendMemo("Cam URL error: " + ex.getMessage()); }
            }
        }

        void startPreview() {
            try { grabber.startPreview(); logItems.clear(); }
            catch (Throwable ex) { appendMemo("Preview error: " + ex.getMessage()); }
        }

        void startRecording() {
            try { grabber.startRecording(); logItems.clear(); }
            catch (Throwable ex) { appendMemo("Recording error: " + ex.getMessage()); }
        }

        void stop() { try { grabber.stop(); } catch (Throwable ignore) {} }
    }
}
