package fx.com.datastead.tvideograbber_demo;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.stage.Stage;

public class FX4CamerasApplication extends Application {

    @Override
    public void start(Stage stage) {
        FX4CamerasController controller = new FX4CamerasController(); // builds UI in constructor
        Scene scene = new Scene(controller.getRoot(), 1400, 1100);

        stage.setTitle("TVideoGrabber FX Demo");
        stage.setScene(scene);
        stage.show();

        stage.setOnCloseRequest(e -> controller.shutdown());
    }

    public static void main(String[] args) {
        launch();
    }
}
