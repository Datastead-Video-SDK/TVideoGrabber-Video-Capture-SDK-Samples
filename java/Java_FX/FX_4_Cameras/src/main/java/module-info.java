module fx.com.datastead.tvideograbber_demo {
    requires javafx.controls;
    requires javafx.fxml;

    requires org.controlsfx.controls;
    requires com.dlsc.formsfx;

    requires tvideograbber;

    opens fx.com.datastead.tvideograbber_demo to javafx.fxml;
    exports fx.com.datastead.tvideograbber_demo;
}