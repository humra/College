package racunarstvo.java;

import java.util.Scanner;

public class BrojevniSustavi {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        System.out.print("Unesite dekadski broj: ");
        int broj = Integer.parseInt(s.nextLine());
        
        konvertiraj(broj);
    }
    
    public static void konvertiraj(int broj) {
        String hex = Integer.toHexString(broj);
        String oct = Integer.toOctalString(broj);
        String bin = Integer.toBinaryString(broj);
        
        System.out.printf("Dekadski: %d\nHeksadekadski: %s\nOktalni: %s\nBinarni: %s\n", broj, hex, oct, bin);
    }
}
