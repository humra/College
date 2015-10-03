package racunarstvo.java;

import java.io.File;
import java.io.FilenameFilter;
import javax.swing.JOptionPane;

public class V07Z01 {

    public static void main(String[] args) {
        String folderPath = JOptionPane.showInputDialog("Unesite lokaciju foldera: ");
        
        File[] fajlovi = filter(folderPath);
        
        sortiraj(fajlovi);
        
        for(File f : fajlovi) {
            System.out.println(f + " " + f.length());
        }
    }

    private static File[] filter(String folderPath) {
        File folder = new File(folderPath);
        
        return folder.listFiles(new FilenameFilter() {
            public boolean accept(File folder, String fileName) {
                return fileName.endsWith(".txt");
            }
        });
    }

    private static void sortiraj(File[] files) {
        File temp;
        
        for(int i = 1; i < files.length; i++) {
            temp = files[i];
            
            int j;
            for(j = i - 1; j >= 0 && temp.length() < files[j].length(); j--) {
                files[j + 1] = files[j];
            }
            files[j + 1] = temp;
        }
    }
    
}
