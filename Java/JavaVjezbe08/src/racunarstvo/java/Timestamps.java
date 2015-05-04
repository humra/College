package racunarstvo.java;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.attribute.BasicFileAttributes;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Timestamps {

    public static void main(String[] args) {
        try {
            Path p = Paths.get("zadatak.txt");
            BasicFileAttributes attr = Files.readAttributes(p, BasicFileAttributes.class);
            
            System.out.println(attr.creationTime());
            System.out.println(attr.lastModifiedTime());
        }
        catch (IOException ex) {
            Logger.getLogger(Timestamps.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
