package chat.client;

import chat.GUI.ClientGUI;
import chat.GUI.ClientStart;
import java.io.DataInputStream;
import java.io.IOException;
import java.net.Socket;
import javax.swing.DefaultListModel;

public class ClientHandler extends Thread {

    private final ClientGUI gui;
    private final ClientStart start;
    private DataInputStream reader;
    private final Socket socket;
    private final Client c;
    private String clientName;
    private int clientId;
    private DefaultListModel<Person> userModel;

    public ClientHandler(Socket s, Client c, ClientGUI gui, ClientStart start) {
        this.userModel = new DefaultListModel<>();
        this.start = start;
        this.gui = gui;
        this.socket = s;
        this.c = c;
    }

    @Override
    public void run() {
        try {
            reader = new DataInputStream(socket.getInputStream());

            while (c.getState()) {
                String line = reader.readUTF();
                parseMessage(line);
            }
        } catch (IOException ex) {
            c.setState(false);
        }
    }

    private void removeClient(int id) {
        for (int i = 0; i < userModel.size(); i++) {
            if (userModel.get(i).getId() == id) {
                userModel.remove(i);
            }
        }
    }

    private void initClientList(String list) {
        String[] groups = list.split("\\|", -1);
        userModel = new DefaultListModel<Person>();
        for (int i = 0; i < groups.length - 1; i++) {
            String[] person = groups[i].split("\\*");
            userModel.addElement(new Person(person[0], Integer.parseInt(person[1])));
        }
        gui.getUserList().setModel(userModel);
    }

    private void parseMessage(String input) {
        String[] message = input.split(":");
        switch (message[0]) {
            case "M":
                int indexM = input.indexOf(":", input.indexOf(":", input.indexOf(":") + 1) + 1) + 1;             
                c.handlePrivate(Integer.parseInt(message[1]), input.substring(indexM), message[2]);
                break;
            case "E":
                gui.getTxtAreaChat().append(message[2] + " je napustio chat.\n");
                int id = Integer.parseInt(message[1]);
                removeClient(id);
                for (int i = 0; i < userModel.size(); i++) {
                    if (userModel.get(i).getId() == id) {
                        userModel.removeElement(userModel.get(i));
                    }
                }
                c.removePrivate(id);
                break;
            case "S":
                gui.getTxtAreaChat().append(message[2] + " se spojio na chat.\n");
                if (Integer.parseInt(message[1]) != clientId) {
                    userModel.addElement(new Person(message[2], Integer.parseInt(message[1])));
                }
                break;
            case "B":
                int indexB=input.indexOf(":", input.indexOf(":") + 1) + 1;
                gui.getTxtAreaChat().append(message[1] + ": " + input.substring(indexB) + "\n"); 
                break;
            case "NI":
                start.getlblError().setText("Izaberite drugo ime.");
                break;
            case "NV":
                start.dispose();
                gui.setVisible(true);
                clientName = message[1];
                c.setName(clientName);
                c.setId(clientId);
                clientId = Integer.parseInt(message[2]);
                c.setUsersListener();
                break;
            case "CL":
                initClientList(message[1]);
                break;
        }
    }
}
