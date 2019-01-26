package chat.server;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;

public class ServerClientHandler implements Runnable {

    private DataInputStream reader;
    private DataOutputStream writer;
    private final Socket socket;
    private final Server server;
    private final int id;
    private boolean running;
    private String clientName = "";

    public ServerClientHandler(Socket socket, int id, Server s) {
        this.socket = socket;
        this.id = id;
        this.server = s;
    }

    public int getID() {
        return id;
    }

    @Override
    public void run() {
        try {
            reader = new DataInputStream(socket.getInputStream());
            writer = new DataOutputStream(socket.getOutputStream());
            running = true;
            setUserName();
            initClient();
            joinedChat();
        } catch (IOException ex) {
            System.out.println("Error while starting the client thread.");
        }

        while (running) {
            try {
                String line = reader.readUTF();
                parseMessage(line);
            } catch (IOException ex) {
                CloseClient();
                System.out.println("Client " + Integer.toString(id) + " disconnected.");
                server.removeClient(id);
                if (!(clientName.equals(""))) {
                    server.broadcast("E:" + id + ":" + clientName);
                }
            } catch (NullPointerException e) {
                System.out.println(e.getMessage());
            }
        }
    }

    private void joinedChat() {
        server.broadcast("S:" + id + ":" + clientName);
    }
    
    private void setUserName() throws IOException {
        boolean invalid = true;
        String testName = "";
        
        while (invalid == true) {
            invalid = false;
            testName = reader.readUTF();
            
            for (ServerClientHandler c : server.getClientList()) {
                if (c.getClientName().equals(testName)) {
                    invalid = true;
                    writer.writeUTF("NI:");
                }
            }
        }
        clientName = testName;
    }

    private void initClient() throws IOException {
        writer.writeUTF("NV:" + clientName + ":" + id);
        
        StringBuilder list = new StringBuilder();
        server.getClientList().stream().forEach((c) -> {
            list.append(c.getClientName()).append("*").append(c.getID()).append("|");
        });
        
        writer.writeUTF("CL:" + list.toString());
    }

    public String getClientName() {
        return clientName;
    }

    private void parseMessage(String input) {
        String[] message = input.split(":");
        
        switch (message[0]) {
            case "M":
                int indexM=input.indexOf(":", input.indexOf(":", input.indexOf(":")+1)+1)+1;       
                server.privateMessage(input.substring(indexM), id, Integer.parseInt(message[1]),clientName);
                break;
            case "E":
            case "S":
            case "B":
                server.broadcast(input);
                break;
        }
    }

    public void CloseClient() {
        try {
            writer.close();
            reader.close();
            socket.close();
            running = false;
        } catch (IOException ex) {
            System.out.println("Error while closing connection");
        }
    }

    public void SendMessage(String msg) {
        if (!socket.isClosed()) {
            try {
                writer.writeUTF(msg);
            } catch (IOException ex) {
                System.out.println("Error while sending a message");
            }
        }
    }

}
