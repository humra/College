package racunarstvo.java;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

public class V06Z02 {

    public static void main(String[] args) {
        BufferedReader br = null;
        BufferedWriter bw = null;
        String datoteka = "";
        
        try {
            br = new BufferedReader(new FileReader("test.txt"));
            
            String temp = null;
            
            while((temp = br.readLine()) != null) {
                datoteka += temp;
            }
        }
        catch (FileNotFoundException ex) {
            Logger.getLogger(V06Z02.class.getName()).log(Level.SEVERE, null, ex);
        }
        catch (IOException ex) {
            Logger.getLogger(V06Z02.class.getName()).log(Level.SEVERE, null, ex);
        }
        finally {
            try {
                br.close();
            }
            catch (IOException ex) {
                Logger.getLogger(V06Z02.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < datoteka.length(); i++) {
            if(Character.isLowerCase(datoteka.charAt(i))) {
                sb.append(Character.toUpperCase(datoteka.charAt(i)));
            }
            else {
                sb.append(datoteka.charAt(i));
            }
        }
        
        try {
            bw = new BufferedWriter(new FileWriter("v06z02.txt"));
            
            bw.write(sb.toString());
        }
        catch (IOException ex) {
            Logger.getLogger(V06Z02.class.getName()).log(Level.SEVERE, null, ex);
        }
        finally {
            try {
                bw.close();
            }
            catch (IOException ex) {
                Logger.getLogger(V06Z02.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
    
}
