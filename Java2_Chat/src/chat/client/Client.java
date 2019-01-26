package chat.client;

import chat.GUI.ClientGUI;
import chat.GUI.ClientPrivate;
import chat.GUI.ClientStart;
import java.awt.event.ActionEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.ArrayList;
import javax.swing.AbstractAction;
import javax.swing.Action;

public class Client {

    private final Socket socket;
    private String name;
    private int id;
    private DataOutputStream writer;
    boolean running;
    private final ClientStart guiStart;
    private final ClientGUI guiChat;
    private ArrayList<ClientPrivate> privateList;

    public Client(Socket s, ClientGUI gui, ClientStart start) {
        this.guiChat = gui;
        this.guiStart = start;
        this.socket = s;
        privateList = new ArrayList<>();
    }

    private void initGUI() {
        Action action = new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent e) {
                guiStartSendText();
            }
        };
        Action action2 = new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent e) {
                guiChatSendText();
            }
        };
        guiStart.getTxtName().addActionListener(action);
        guiStart.getBtnSend().addActionListener(action);
        guiChat.getTxtInput().addActionListener(action2);
        guiChat.getBtnSend().addActionListener(action2);
    }

    public void setState(boolean b) {
        running = b;
    }

    public boolean getState() {
        return running;
    }

    public void StartChat() {
        try {
            writer = new DataOutputStream(socket.getOutputStream());
            running = true;
            guiStart.getlblError().setText("Connected.");
            new ClientHandler(socket, this, guiChat, guiStart).start();
            initGUI();
        } catch (IOException ex) {
            guiStart.getlblError().setText("Error while starting client thread.");

        } catch (Exception ex) {
            guiStart.getlblError().setText(ex.getMessage());
        }
    }

    private void guiStartSendText() {
        try {
            String line = guiStart.getTxtName().getText();
            writer.writeUTF(line);
            writer.flush();

        } catch (IOException ex) {
            CloseClient();
            guiStart.getlblError().setText("Disconnected.");
            guiStart.showConnectBtn();
        }
    }

    private void guiChatSendText() {
        try {
            String line = guiChat.getTxtInput().getText();
            
            if (!(line.isEmpty())) {
                writer.writeUTF("B:" + name + ":" + line);
                writer.flush();
                guiChat.getTxtInput().setText("");
            }
        } catch (IOException ex) {
            CloseClient();
            guiChat.getLblError().setText("Disconnected.");
        }
    }

    private void guiPrivateSendText(ClientPrivate nClient) {
        try {
            String line = nClient.getTxtInput().getText();
            
            if (!(line.isEmpty())) {
                writer.writeUTF("M:" + nClient.getP().getId() + ":" + name + ":" + line);
                writer.flush();
                nClient.getChatArea().append("Ja: " + line + "\n");
                nClient.getTxtInput().setText("");
            }
        } catch (IOException ex) {
            CloseClient();
            guiChat.getLblError().setText("Disconnected.");
        }
    }

    public void handlePrivate(int id, String msg, String name) {
        boolean b = false;
        for (ClientPrivate cp : privateList) {
            if (cp.getP().getId() == id) {
                b = true;
                cp.getChatArea().append(cp.getP().getName() + ": " + msg + "\n");
            }
        }
        
        if (b == false) {
            Person p = new Person(name, id);
            initPrivate(p);
            
            for (ClientPrivate cp : privateList) {
                if (cp.getP().getId() == id) {
                    cp.getChatArea().append(cp.getP().getName() + ": " + msg + "\n");
                }
            }
        }
    }

    public void setUsersListener() {
        guiChat.getUserList().addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (e.getClickCount() == 2 && checkSelf() && checkExisting(guiChat.getUserList().getSelectedValue().toString())) {
                    initPrivate((Person) guiChat.getUserList().getModel().getElementAt(guiChat.getUserList().getSelectedIndex()));
                }
            }
        });
    }

    private boolean checkSelf() {
        return !name.equals(guiChat.getUserList().getSelectedValue().toString());
    }

    private boolean checkExisting(String name) {
        return privateList.stream().noneMatch((nc) -> (nc.getP().getName().equals(name)));
    }

    public void removePrivate(int id) {
        for (int i = 0; i < privateList.size(); i++) {
            if (privateList.get(i).getP().getId() == id) {
                privateList.remove(privateList.get(i));
            }
        }
    }

    private void initPrivate(Person p) {

        ClientPrivate nClient = new ClientPrivate(this);
        nClient.setP(p);
        Action action = new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent e) {
                guiPrivateSendText(nClient);
            }
        };
        
        nClient.getBtnSend().addActionListener(action);
        nClient.getTxtInput().addActionListener(action);
        nClient.getLblName().setText(nClient.getP().getName());

        privateList.add(nClient);
        nClient.setVisible(true);
    }

    public void CloseClient() {
        try {
            writer.close();
            running = false;

        } catch (IOException ex) {
            guiStart.getlblError().setText("Error while closing connection.");
        }

    }

    public void setName(String name) {
        this.name = name;
    }

    public void setId(int id) {
        this.id = id;
    }

}
