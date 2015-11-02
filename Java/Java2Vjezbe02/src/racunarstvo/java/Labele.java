package racunarstvo.java;

import java.awt.Color;
import java.awt.GridLayout;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.WindowConstants;

public class Labele extends JFrame {
    private static int N = 5;
    private final JLabel[] labele = new JLabel[N];
    
    public Labele() {
        setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        setSize(300, 300);
        setLocation(300, 300);
        
        setLayout(new GridLayout(5, 1));
        
        for(int i = 0; i < N; i++) {
            JLabel l = new JLabel();
            l.setOpaque(true);
            l.setBackground(Color.RED);
            labele[i] = l;
            
            getContentPane().add(l);
        }
    }
    
    public static void main(String[] args) {
        Labele labele = new Labele();
        labele.setVisible(true);
        
        new MijenjacBoje(labele, 0).start();
        new MijenjacBoje(labele, 1).start();
        new MijenjacBoje(labele, 2).start();
        new MijenjacBoje(labele, 3).start();
        new MijenjacBoje(labele, 4).start();
    }

    int broji(Color c) {
        int counter = 0;
        
        for(int i = 0; i < 5; i++) {
            if(c.equals(labele[i].getBackground())) {
                counter++;
            }
        }
        
        return counter;
    }

    void postaviBoju(Color c, int index) {
        labele[index].setBackground(c);
        
        int counter = broji(c);
        if(counter > 1) {
            throw new IllegalStateException("Krivi broj boja: " + counter);
        }
    }
}
