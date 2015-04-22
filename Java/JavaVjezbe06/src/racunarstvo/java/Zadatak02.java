package racunarstvo.java;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Zadatak02 {

    public static void main(String[] args) {
        String filePath = "zadatak.txt";

        BufferedReader br = null;
        List<String> lines = new ArrayList<String>();

        try {
            br = new BufferedReader(new FileReader(filePath));

            String tempLine;

            while ((tempLine = br.readLine()) != null) {
                lines.add(tempLine);
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
                if (br != null) {
                    br.close();
                }
            }
            catch (IOException ex) {
                ex.printStackTrace();
            }
        }

        BufferedWriter bw = null;

        try {
            File f = new File("output.txt");

            if (!f.exists()) {
                f.createNewFile();
            }

            FileWriter fw = new FileWriter(f.getAbsoluteFile());
            bw = new BufferedWriter(fw);

            StringBuilder sb = new StringBuilder();

            for (String s : lines) {
                for (int i = 0; i < s.length(); i++) {
                    if (Character.isLowerCase(s.charAt(i))) {
                        sb.append(Character.toUpperCase(s.charAt(i)));
                    }
                    else {
                        sb.append(s.charAt(i));
                    }
                }
            }

            bw.write(sb.toString());
        }
        catch (FileNotFoundException ex) {
            ex.printStackTrace();
        }
        catch (IOException ex) {
            ex.printStackTrace();
        }
        finally {

            try {
                if (bw != null) {
                    bw.close();
                }
            }
            catch (IOException ex) {
                ex.printStackTrace();
            }

        }
    }

}
