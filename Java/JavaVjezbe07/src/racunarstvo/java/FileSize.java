package racunarstvo.java;

import java.io.File;
import java.io.FilenameFilter;
import java.util.Arrays;
import javax.swing.JOptionPane;

public class FileSize {

    public static void main(String[] args) {
        String folderPath = JOptionPane.showInputDialog("Unesite lokaciju mape: ");
        
        File[] listOfFiles = filter(folderPath);
        
        sort(listOfFiles);
        
        for(int i = 0; i < listOfFiles.length; i++) {
            if(listOfFiles[i].isFile()) {
                System.out.println(listOfFiles[i] + "\t" + listOfFiles[i].length());
            }
        }
    }
    
    public static void sort(File[] files) {
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
    
    public static File[] filter(String folderPath) {
        File folder = new File(folderPath);
        
        return folder.listFiles(new FilenameFilter() {
            public boolean accept(File folder, String fileName) {
                return fileName.endsWith(".pdf");
            }
        });
    }
    
}
