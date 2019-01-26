package chat.server;

import java.io.IOException;
import java.net.ServerSocket;

public class ServerMain {

 public static void main(String[] args) {
        try {
            ServerSocket s = new ServerSocket(10008);
            Server server = new Server(s);
            server.Start();
        } catch (IOException ex) {
            System.out.println("Error while starting the Server.");
        }
    }
}
