package racunarstvo.java;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.util.logging.Level;
import java.util.logging.Logger;

public class CopyFile {

    public static void main(String[] args) {
        InputStream in = null;
        OutputStream out = null;
        
        try {
            File inFile = new File("zadatak.txt");
            File outFile = new File("kopija.txt");
            
            in = new FileInputStream(inFile);
            out = new FileOutputStream(outFile);
            
            byte[] buffer = new byte[1024];
            int length;
            
            while ((length = in.read(buffer)) > 0){
                out.write(buffer);
    	    }
            
            in.close();
            out.close();
        }
        catch (FileNotFoundException ex) {
            Logger.getLogger(CopyFile.class.getName()).log(Level.SEVERE, null, ex);
        }
        catch (IOException ex) {
            Logger.getLogger(CopyFile.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
