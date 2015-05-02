package racunarstvo.java;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

public class TxtToXml {

    public static void main(String[] args) {
        ucitajKontakte("input.txt");
    }
    
    public static void ucitajKontakte(String filePath) {
        List<String> sviKontakti = new ArrayList<String>();
        
        try {
            BufferedReader br = new BufferedReader(new FileReader(filePath));
            
            String temp;
            
            while((temp = br.readLine()) != null) {
                sviKontakti.add(temp);
            }
        }
        catch (FileNotFoundException ex) {
            Logger.getLogger(TxtToXml.class.getName()).log(Level.SEVERE, null, ex);
        }
        catch (IOException ex) {
            Logger.getLogger(TxtToXml.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        kreirajKontakte(sviKontakti);
    }
    
    public static void kreirajKontakte(List<String> kontakti) {
        
        ListaKontakata imenik = new ListaKontakata();
        
        for(String s : kontakti) { 
            Kontakt temp = new Kontakt();
            
            String[] podaci = s.split("\\|");
            
            temp.id = podaci[0];
            
            String[] brojeviTelefona = podaci[1].split(";");
            for(String tel : brojeviTelefona) {
                temp.telefon.add(tel);
            }
            
            temp.ime = podaci[2];
            temp.prezime = podaci[3];
            temp.protokol = podaci[4];
            temp.datumRodjenja = podaci[5];
            
            String[] mailovi = podaci[6].split(";");
            String[] usernameovi = mailovi[0].split(",");
            
            for(String m : usernameovi) {
                temp.mail.add(m);
            }
            temp.skypeId = mailovi[1];
            temp.gTalkId = mailovi[2];
            
            imenik.dodajKontakt(temp);
        }
        
        imenik.writeXML();
    }
}
