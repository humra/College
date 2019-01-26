package chat.server;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;

public class Server {

    private ServerSocket mainSocket = null;
    private Socket socket = null;
    private ArrayList<ServerClientHandler> clientList;
    private static int threadID = 0;

    public Server(ServerSocket s) {
        System.out.println("Starting server... Port:" + s.getLocalPort());
        this.mainSocket = s;
        System.out.println("Server started: " + mainSocket);
    }

    public void Start() {
        clientList= new ArrayList<>();
        
        while (true) {
            System.out.println("Waiting another connection...");
            
            try {
                socket = mainSocket.accept();
                ServerClientHandler client = new ServerClientHandler(socket, ++threadID, this);
                clientList.add(client);
                new Thread(client).start();  
                System.out.println("Client accepted:" + threadID + ", Socket: " + socket);

            } catch (IOException ex) {
                System.out.println("Connection closed.");
            }
        }
    }
    
    public synchronized void broadcast(String msg)
    {
        System.out.println(msg);
        clientList.stream().forEach((c) -> {
            c.SendMessage(msg);
        }); 
    }
    
    public synchronized void privateMessage(String msg, int idSender, int idReceiver, String name)
    {
        System.out.println("M:" + idSender + ":" + name + ":" + msg);
        clientList.stream().filter((c) -> (c.getID() == idReceiver)).forEach((c) -> {
            c.SendMessage("M:" + idSender + ":" + name + ":" + msg);
        });
    }

    public synchronized void removeClient(int ID) {
        for (int i = 0; i < clientList.size(); i++) {
            if(clientList.get(i).getID() == ID)
            {
                clientList.get(i).CloseClient();
                clientList.remove(i);
            }
        }
    }
    
    public void StopServer()
    {
        try {
            mainSocket.close();
            clientList.stream().forEach(ServerClientHandler::CloseClient);
        } catch (IOException ex) {
            System.out.println("Error while stoping the server.");
        }
    }

    public ArrayList<ServerClientHandler> getClientList() {
        return clientList;
    }
}
