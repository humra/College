package racunarstvo.java;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class ObrnutiNiz {

    public static void main(String[] args) {
        List<Integer> list = new ArrayList<Integer>();
        int broj;
        Scanner s = new Scanner(System.in);
        
        do {
            broj = Integer.parseInt(s.nextLine());
            if(broj != -1) {
                list.add(broj);
            }
        }while(broj != -1);
        
        int[] polje = new int[list.size()];
        
        for(int i = 0; i < polje.length; i++) {
            polje[i] = list.get(i);
        }
        
        int temp;
        for(int i = 0; i < polje.length / 2; i++) {
            temp = polje[i];
            polje[i] = polje[polje.length - i - 1];
            polje[polje.length - 1 - i] = temp;
        }
        
        for(int i = 0; i < polje.length; i++) {
            System.out.printf("%d ", polje[i]);
        }
    }
    
}
