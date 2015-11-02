package racunarstvo.java;

import java.awt.Color;
import java.util.Random;

public class MijenjacBoje extends Thread{
    private final Random r = new Random();
    private final Labele labele;
    private final int index;
    private static final Object monitor = new Object();
    
    public MijenjacBoje(Labele labele, int index) {
        this.labele = labele;
        this.index = index;
    }
    
    public void run() {
        while(true) {
            Color c = r.nextBoolean() ? Color.RED : Color.GREEN;
            
            synchronized(monitor) {
                if(c == Color.GREEN && labele.broji(Color.GREEN) >= 1) {
                    c = Color.RED;
                }
                
                try {
                    labele.postaviBoju(c, index);
                }
                catch(Exception e) {
                    System.out.println(e.getMessage());
                }
            }
        }
    }
}
