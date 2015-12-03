package racunarstvo.java;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Date;

public class Server {

    public static void main(String[] args) {
        String[] polje = new String[10];
        DataOutputStream output;
        DataInputStream input;
        String ulazni;
        
        try {
            Socket socket;
            ServerSocket serverSocket = new ServerSocket(1234);
            System.out.println("Server is running");
            
            while(true) {
                socket = serverSocket.accept();
                input = new DataInputStream(socket.getInputStream());
                output = new DataOutputStream(socket.getOutputStream());
                
                String time = new Date().toString();
                System.out.println("Connection established at: " + time);
                
                for(int i = 0; i < 10; i++) {
                    ulazni = input.readUTF();
                    polje[i] = ulazni;
                    System.out.println("KLIJENT:" + polje[i]);
                }
                
                for(int i = 0; i < 10; i++) {
                    output.writeUTF("SERVER:" + polje[i]);
                }
                input.close();
                output.close();
                socket.close();
                System.out.println("Waiting for another client...");
            }
        }
        catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
    }
}
