package racunarstvo.java;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JRadioButton;
import javax.swing.JTextField;

public class Form extends JFrame {
    
    JTextField txtUsername;
    JTextField txtYears;
    JTextField txtHobby;
    JRadioButton rbGender;
    JRadioButton cbEmployment;
    JButton btnSubmit;
    
    int height =  30;
    int width = 80;
    int leftMargine = 10;
    
    public Form(String title) {
        super(title);    
        
        setLayout(null);
        setSize(350, 350);
        setLocation(10, 10);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        txtUsername = new JTextField();
        txtUsername.setBounds(10, 10, width, height);
        getContentPane().add(txtUsername);
        
        txtYears = new JTextField();
        txtYears.setBounds(10, 50, width, height);
        getContentPane().add(txtYears);
        
        setVisible(true);
    }
}
