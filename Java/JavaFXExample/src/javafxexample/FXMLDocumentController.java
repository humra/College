/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javafxexample;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.ColorPicker;
import javafx.scene.control.Label;
import javafx.scene.control.TextArea;

/**
 * FXML Controller class
 *
 * @author Matija
 */
public class FXMLDocumentController implements Initializable {
    @FXML
    private Label label;
    @FXML
    private TextArea txtArea;
    @FXML
    private ColorPicker colorPicker;

    /**
     * Initializes the controller class.
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    

    @FXML
    private void handleButtonAction(ActionEvent event) {
        txtArea.setStyle("-fx-background-color:" + colorPicker.getValue());
    }

    @FXML
    private void setTextBackground(ActionEvent event) {
        txtArea.setStyle("-fx-background-color:" + colorPicker.getValue());
    }
    
}
