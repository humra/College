/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zadatak05;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.util.ArrayList;
import java.util.Random;
import javafx.application.Platform;
import javafx.embed.swing.JFXPanel;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.StackPane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javafx.scene.transform.Rotate;
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
        Random rand = new Random();

        Rectangle r1 = new Rectangle();
        Rectangle r2 = new Rectangle();
        
        for(int i = 0; i < 2; i++) 
        {
           float x = (float)rand.nextInt(400 - 150) + 150;
           float y = (float)rand.nextInt(400 - 150) + 150; 
           int width = rand.nextInt((200 - 150) + 1) + 150;
           int height = rand.nextInt((200 - 150) + 1) + 150;

           Rectangle r = new Rectangle(x, y, width, height);
           
           root.getChildren().add(r);
           
           if(i == 0) {
               r.setFill(Color.RED);
               r1 = r;
           }
           else {
               r.setFill(Color.BLUE);
//               Rotate rotate = new Rotate(45, width / 2, height / 2);
//               r.getTransforms().add(rotate);
               r2 = r;
           }
           
           rand.setSeed((long) x);
        }

        Scene scene = new Scene(root, JFXPANEL_WIDTH_INT, JFXPANEL_HEIGHT_INT, Color.WHITE);

        fxContainer.setScene(scene);
        
        CheckForOverlap(r1, r2);
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
