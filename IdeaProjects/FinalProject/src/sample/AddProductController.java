package sample;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

public class AddProductController {

    @FXML
    private Button home;

    public void homeButton () throws Exception {
        Parent root = FXMLLoader.load(getClass().getResource("sample.fxml"));

        Stage window = (Stage)home.getScene().getWindow();

        window.setScene(new Scene(root, 750, 500));
        window.show();


    }







}
