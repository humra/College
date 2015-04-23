package racunarstvo.java;

import java.util.Scanner;

public class Zadatak05 {

    public static void main(String[] args) {
        
        int brojPredmeta = 5;
        int suma = 0;
        int temp;
        
        Scanner s = new Scanner(System.in);
        
        for(int i = 0; i < brojPredmeta; i++) {
            try {
                temp = s.nextInt();
                
                if(temp < 1 || temp > 5) {
                    throw new NoSuchMarkException("Must be between 1 and 5!");
                }
                else {
                    suma += temp;
                }
            }
            catch(NoSuchMarkException ex) {
                ex.printStackTrace();
            }
        }
        
        System.out.printf("Prosjecna ocjena je: %.2f", (float)suma / brojPredmeta);
    }
    
}
