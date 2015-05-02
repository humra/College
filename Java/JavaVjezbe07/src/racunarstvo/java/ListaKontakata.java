package racunarstvo.java;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ListaKontakata {
    private List<Kontakt> kontakti = new ArrayList<Kontakt>();
    
    public void writeXML() {
        BufferedWriter bw;
        
        try {
            File f = new File("output.xml");
            
            if(!f.exists()) {
                f.createNewFile();
            }
            
            bw = new BufferedWriter(new FileWriter(f.getAbsoluteFile()));
            
            StringBuilder sb = new StringBuilder();
            sb.append("<kontakti>");
            
            for(Kontakt k : kontakti) {
                sb.append("<kontakt>\n");
                sb.append("\t<id>");
                sb.append(k.id);
                sb.append("</id>\n\t<ime>");
                sb.append(k.ime);
                sb.append("</ime>\n\t<prezime>");
                sb.append("</prezime\n\t");
                
                sb.append("<brojevi>\n\t\t");
                for(String broj : k.telefon) {
                    sb.append("<broj>");
                    sb.append(broj);
                    sb.append("</broj>\n\t\t");
                }
                sb.append("</brojevi>\n\t");
                
                sb.append("<protokol>");
                sb.append(k.protokol);
                sb.append("</protokol>\n\t");
                sb.append("<datumRodjenja>");
                sb.append(k.datumRodjenja);
                sb.append("</datumRodjenja>\n\t");
                
                sb.append("<mailovi>\n\t\t");
                for(String mail : k.mail) {
                    sb.append("<mail>");
                    sb.append(mail);
                    sb.append("</mail>\n\t\t");
                }
                sb.append("</mailovi>\n\t<skype>");
                sb.append(k.skypeId);
                sb.append("</skype>\n\t<gTalk>");
                sb.append(k.gTalkId);
                sb.append("</gTalk>\n</kontakt>\n");
            }
            
            sb.append("</kontakti>");
            
            bw.write(sb.toString());
            
            bw.close();
        }
        catch (IOException ex) {
            Logger.getLogger(ListaKontakata.class.getName()).log(Level.SEVERE, null, ex);
        }
        
    }
    
    public void dodajKontakt(Kontakt k) {
        kontakti.add(k);
    }
}
