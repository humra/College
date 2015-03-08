package racunarstvo.java;

import java.util.Scanner;

public class BrojacZnakova {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        System.out.println("Unesite tekst: ");
        String s = input.nextLine();
        
        prebrojiZnakove(s);
    }

    private static void prebrojiZnakove(String s) {
        int cntrSlova = 0;
        int cntrZnamenke = 0;
        int cntrOstalo = 0;
        
        for(int i = 0; i < s.length(); i++) {
            if(Character.isDigit(s.charAt(i))) {
                cntrZnamenke++;
            }
            else if(Character.isLetter(s.charAt(i))) {
                cntrSlova++;
            }
            else {
                cntrOstalo++;
            }
        }
        
        System.out.printf("Broj slova: %d\nBroj znamenaka: %d\nOstali znakovi: %d\n", cntrSlova, cntrZnamenke, cntrOstalo);
    }
    
}
