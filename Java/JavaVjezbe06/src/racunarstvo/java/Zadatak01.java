package racunarstvo.java;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Zadatak01 {

    public static void main(String[] args) {
        String filePath = "zadatak.txt";

        BufferedReader br = null;
        int counter = 0;

        try {
            br = new BufferedReader(new FileReader(filePath));

            while (br.readLine() != null) {
                counter++;
            }
        }
        catch (FileNotFoundException ex) {
            ex.printStackTrace();
        }
        catch (IOException ex) {
            ex.printStackTrace();
        }
        finally {
            try {
                br.close();
            }
            catch (IOException ex) {
                ex.printStackTrace();
            }
        }
        
        System.out.printf("Linija: %d\n", counter);
    }

}
