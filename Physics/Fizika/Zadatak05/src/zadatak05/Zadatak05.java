/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zadatak05;

import java.awt.BorderLayout;
import java.awt.Dimension;
import javafx.application.Platform;
import javafx.embed.swing.JFXPanel;
import javafx.event.EventHandler;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.input.MouseEvent;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javax.swing.JApplet;
import javax.swing.JFrame;
import javax.swing.SwingUtilities;
import javax.swing.UIManager;

/**
 *
 * @author Matija
 */
public class Zadatak05 extends JApplet {
    
    private static final int JFXPANEL_WIDTH_INT = 600;
    private static final int JFXPANEL_HEIGHT_INT = 600;
    private static JFXPanel fxContainer;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            
            @Override
            public void run() {
                try {
                    UIManager.setLookAndFeel("com.sun.java.swing.plaf.nimbus.NimbusLookAndFeel");
                } catch (Exception e) {
                }
                
                JFrame frame = new JFrame("JavaFX 2 in Swing");
                frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                
                JApplet applet = new Zadatak05();
                applet.init();
                
                frame.setContentPane(applet.getContentPane());
                
                frame.pack();
                frame.setLocationRelativeTo(null);
                frame.setVisible(true);
                
                applet.start();
            }
        });
    }
    
    @Override
    public void init() {
        fxContainer = new JFXPanel();
        fxContainer.setPreferredSize(new Dimension(JFXPANEL_WIDTH_INT, JFXPANEL_HEIGHT_INT));
        add(fxContainer, BorderLayout.CENTER);
        // create JavaFX scene
        Platform.runLater(new Runnable() {
            
            @Override
            public void run() {
                createScene();
            }
        });
    }
    
    private void createScene() {
        Group root = new Group();

        Rectangle r1 = new Rectangle(10, 100, 150, 150);
        r1.setFill(Color.RED);

        Rectangle r2 = new Rectangle(400, 100, 150, 150);
        r2.setFill(Color.BLUE);
        
        r1.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                r1.setX(r1.getX() + 30);
                CheckForOverlap(r1, r2);
            }
            
        });
        
        r2.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                r2.setX(r2.getX() - 30);
                CheckForOverlap(r1, r2);
            }
            
        });

        root.getChildren().add(r1);
        root.getChildren().add(r2);

        Scene scene = new Scene(root, JFXPANEL_WIDTH_INT, JFXPANEL_HEIGHT_INT, Color.WHITE);

        fxContainer.setScene(scene);
        
        
    }
    


    private void CheckForOverlap(Rectangle r1, Rectangle r2) {
        
        //Get the min and max points of first rectangle
        double r1MinX = r1.getX();
        double r1MinY = r1.getY();
        double r1MaxX = r1MinX + r1.getWidth();
        double r1MaxY = r1MinY + r1.getHeight();
        
        //Get the min and max points of second rectangle
        double r2MinX = r2.getX();
        double r2MinY = r2.getY();
        double r2MaxX = r2MinX + r2.getWidth();
        double r2MaxY = r2MinY + r2.getHeight();
        
        //Check for overlap on X and Y axes        
        Boolean overlapX = ((r2MinX <= r1MaxX) && (r1MinX <= r2MaxX));
        Boolean overlapY = ((r2MinY <= r1MaxY) && (r1MinY <= r2MaxY));
        
        //The rectangles intersect only if both axes overlap
        if(overlapX && overlapY) {
            System.out.println("The rectangles overlap");
        }
        else {
            System.out.println("The rectangles do not overlap");
        }
    }
    
}
