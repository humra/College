package racunarstvo.java;

import java.io.IOException;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.io.*;

public class Klijent {
    
    Socket socket;
    DataInputStream input;
    DataOutputStream output;
    String[] polje = new String[10];
    long timeStart;
    long timeFinish;
    
    public static void main(String[] args) {
        try {
            Socket s = new Socket("localhost", 1234);
            Klijent k = new Klijent(s);
            k.run();
        }
        catch (IOException ex) {
            Logger.getLogger(Klijent.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public Klijent(Socket socket) {
        this.socket = socket;
    }
    
    public void run() {
        try {
            input = new DataInputStream(socket.getInputStream());
            output = new DataOutputStream(socket.getOutputStream());
            
            timeStart = System.currentTimeMillis();
            
            for(int i = 0; i < 10; i++) {
                polje[i] = Integer.toString(i + 1);
            }
            
            for(int i = 0; i < 10; i++) {
                output.writeUTF(polje[i]);
            }
            
            for(int i = 0; i < 10; i++) {
                String ulazni = input.readUTF();
                System.out.println("SERVER:" + ulazni);
            }
            
            timeFinish = System.currentTimeMillis();
            
            long timeElapsed = timeFinish - timeStart;
            System.out.println("Time elapsed: " + timeFinish);
            
            input.close();
            output.close();
            socket.close();
        }
        catch (IOException ex) {
            Logger.getLogger(Klijent.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
