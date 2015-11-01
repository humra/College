package racunarstvo.java;

import javax.swing.JPanel;
import java.awt.Color;
import java.awt.Graphics;

public class Pravokutnik extends JPanel {
    
    Color color;
    
    public Pravokutnik(Color color) {
        this.color = color;
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g); 
        
        g.setPaintMode();
        g.setColor(color);
        g.fillRect(0, 0, getWidth(), getHeight());
    }

}
