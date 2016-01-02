package racunarstvo.java;

import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.File;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JMenuItem;
import javax.swing.JPanel;
import javax.swing.JPopupMenu;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import org.w3c.dom.DOMImplementation;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Text;

public class MainFrame extends JFrame {
    
    DocumentBuilderFactory xmlWriter = DocumentBuilderFactory.newInstance();
    TransformerFactory tFactory = TransformerFactory.newInstance();
    
    private int clickedX = 0;
    private int clickedY = 0;
    
    private JPanel zeleni = new JPanel();
    private JPanel plavi = new JPanel();
    private JPanel zuti = new JPanel();
    private JPanel crveni = new JPanel();
    
    private JPopupMenu kontekstni;
    
    public MainFrame(String naziv) {
        super(naziv);
        
        this.setLayout(new GridLayout(2, 2));
        
        this.setBounds(100, 100, 400, 400);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        
        konfigurirajMouseListener();
        konfigurirajPopupove();
        
        zeleni.setBackground(Color.GREEN);
        crveni.setBackground(Color.RED);
        plavi.setBackground(Color.BLUE);
        zuti.setBackground(Color.YELLOW);
        
        this.getContentPane().add(zeleni);
        this.getContentPane().add(plavi);
        this.getContentPane().add(zuti);
        this.getContentPane().add(crveni);
        
        this.setVisible(true);
    }
    
    public static void main(String[] args) {
	MainFrame jpmp = new MainFrame("naziv");
    }

    private void konfigurirajPopupove() {
        JPopupMenu zeleniPopup = new JPopupMenu();
        JMenuItem zeleniMeni = new JMenuItem("spremi", new ImageIcon("green.gif"));
        zeleniPopup.add(zeleniMeni);
        
        zeleniMeni.addActionListener(new ActionListener() {
            
            @Override
            public void actionPerformed(ActionEvent e) {
                spremiPodatke(e);
            }
        });
        
        JPopupMenu crveniPopup = new JPopupMenu();
        JMenuItem crveniMeni = new JMenuItem("spremi", new ImageIcon("red.gif"));
        crveniPopup.add(crveniMeni);
        
        crveniMeni.addActionListener(new ActionListener() {

            @Override
            public void actionPerformed(ActionEvent e) {
                spremiPodatke(e);
            }
            
        });
        
        JPopupMenu plaviPopup = new JPopupMenu();
        JMenuItem plaviMeni = new JMenuItem("spremi", new ImageIcon("blue.gif"));
        plaviPopup.add(plaviMeni);
        
        plaviMeni.addActionListener(new ActionListener() {

            @Override
            public void actionPerformed(ActionEvent e) {
                spremiPodatke(e);
            }
            
        });
        
        JPopupMenu zutiPopup = new JPopupMenu();
        JMenuItem zutiMeni = new JMenuItem("spremi", new ImageIcon("yellow.gif"));
        zutiPopup.add(zutiMeni);
        
        zutiMeni.addActionListener(new ActionListener() {

            @Override
            public void actionPerformed(ActionEvent e) {
                spremiPodatke(e);
            }
            
        });
        
        zeleni.setComponentPopupMenu(zeleniPopup);
        crveni.setComponentPopupMenu(crveniPopup);
        plavi.setComponentPopupMenu(plaviPopup);
        zuti.setComponentPopupMenu(zutiPopup);
    }
    
    public void spremiPodatke(ActionEvent e) {
        try {
            DocumentBuilder xmlGenerator = xmlWriter.newDocumentBuilder();
            DOMImplementation implementacija = xmlGenerator.getDOMImplementation();
            
            String currentTime = new SimpleDateFormat("HHmmss").format(Calendar.getInstance().getTime());
            
            Document dokument = implementacija.createDocument(null, "podaci", null);
            
            Element root = dokument.getDocumentElement();
            
            Element podaci = dokument.createElement("guiVjezbe");
            
            Element vrijeme = dokument.createElement("vrijeme");
            Text vrijemeTekst = dokument.createTextNode(currentTime);
            vrijeme.appendChild(vrijemeTekst);
            podaci.appendChild(vrijeme);
            
            Element xCoord = dokument.createElement("posX");
            Text xTekst = dokument.createTextNode(Integer.toString(clickedX));
            xCoord.appendChild(xTekst);
            podaci.appendChild(xCoord);
            
            Element yCoord = dokument.createElement("posY");
            Text yTekst = dokument.createTextNode(Integer.toString(clickedY));
            yCoord.appendChild(yTekst);
            podaci.appendChild(yCoord);
            
            root.appendChild(podaci);
            
            
            Transformer trans = tFactory.newTransformer();
            DOMSource source = new DOMSource(dokument);
            
            StreamResult result = new StreamResult(new File(currentTime + ".xml"));
            trans.transform(source, result);
        }
        catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
    }

    private void konfigurirajMouseListener() {     
        plavi.addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(MouseEvent e) {
                clickedX = e.getX();
                clickedY = e.getY();
            }
        });
        
        zeleni.addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(MouseEvent e) {
                clickedX = e.getX();
                clickedY = e.getY();
            }
        });
        
        crveni.addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(MouseEvent e) {
                clickedX = e.getX();
                clickedY = e.getY();
            }
        });
        
        zuti.addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(MouseEvent e) {
                clickedX = e.getX();
                clickedY = e.getY();
            }
        });
    }

    private Object DocumentBuilderFactory() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
