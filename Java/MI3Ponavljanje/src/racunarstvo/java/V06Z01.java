package racunarstvo.java;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

public class V06Z01 {

    public static void main(String[] args) {
        int brojLinija = 0;
        BufferedReader br = null;
        
        try {
            br = new BufferedReader(new FileReader("test.txt"));
            
            String temp;
            
            while((temp = br.readLine()) != null) {
                brojLinija++;
            }
        }
        catch (FileNotFoundException ex) {
            Logger.getLogger(V06Z01.class.getName()).log(Level.SEVERE, null, ex);
        }
        catch (IOException ex) {
            Logger.getLogger(V06Z01.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        System.out.println(brojLinija);
    }
    
}
