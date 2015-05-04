package racunarstvo.java;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Uncomment {

    public static void main(String[] args) {
        BufferedReader br = null;
        StringBuilder kod = new StringBuilder();
        
        try {
            br = new BufferedReader(new FileReader("input.class"));
            String temp;
            Boolean multiLine = false;
            
            while((temp = br.readLine()) != null) {
                if(!temp.startsWith("//") || multiLine){
                    kod.append(temp);
                }
                if(temp.startsWith("/*")) {
                    multiLine = true;
                }
                if(temp.endsWith("*/")) {
                    multiLine = false;
                }
            }
            
            System.out.println(kod.toString());
        }
        catch (FileNotFoundException ex) {
            Logger.getLogger(Uncomment.class.getName()).log(Level.SEVERE, null, ex);
        }
        catch (IOException ex) {
            Logger.getLogger(Uncomment.class.getName()).log(Level.SEVERE, null, ex);
        }
        finally {
            try {
                br.close();
            }
            catch (IOException ex) {
                Logger.getLogger(Uncomment.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
    
}
