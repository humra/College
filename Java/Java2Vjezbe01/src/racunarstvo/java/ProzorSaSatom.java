package racunarstvo.java;

import java.awt.Dimension;
import java.awt.Font;
import java.awt.Toolkit;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.SwingConstants;

public class ProzorSaSatom extends JFrame implements Runnable {
    public static final String dateFormat = "HH:mm:ss";
    private JLabel lblSat;  
    
    public ProzorSaSatom(String naziv) {
        super(naziv);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(300, 300);
        Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
        this.setLocation((screenSize.height - getHeight()) / 3, (screenSize.width - getWidth()) / 3);
        
        lblSat = new JLabel();
        lblSat.setFont(new Font("Verdana", Font.BOLD, 24));
        lblSat.setHorizontalAlignment(SwingConstants.CENTER);
        
        refreshClock(lblSat);
        getContentPane().add(lblSat);
        
        setVisible(true);
    }
    
    public static void main(String[] args) {
        ProzorSaSatom mojSat = new ProzorSaSatom("Sat");
        Thread threadSata = new Thread(mojSat);
        threadSata.setDaemon(true);
        threadSata.start();
    }

    @Override
    public void run() {
        try {
            while(true) {
                Thread.sleep(1000);
                refreshClock(lblSat);
            }
        }
        catch(InterruptedException e) {
            e.printStackTrace();
        }
    }

    private void refreshClock(JLabel lblSat) {
        Calendar tempCalendar = Calendar.getInstance();
        SimpleDateFormat sdf = new SimpleDateFormat(dateFormat);
        lblSat.setText(sdf.format(tempCalendar.getTime()));
    }
    
}
