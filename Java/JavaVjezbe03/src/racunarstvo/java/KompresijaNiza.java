package racunarstvo.java;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class KompresijaNiza {

    public static void main(String[] args) {
        int broj;
        Scanner s = new Scanner(System.in);
        List<Integer> list = new ArrayList<Integer>();

        do {
            System.out.printf("Unesite broj: ");
            broj = Integer.parseInt(s.nextLine());
            System.out.println("");

            if (broj != -1) {
                list.add(broj);
            }
        } while (broj != -1 && list.size() <= 100);

        int[] polje = new int[list.size()];

        for (int i = 0; i < list.size(); i++) {
            polje[i] = list.get(i);
        }

        list.clear();

        list.add(polje[0]);
        int counter = 1;
        for (int i = 1; i < polje.length; i++) {
            if (polje[i - 1] != polje[i]) {
                list.add(counter);
                list.add(polje[i]);
                counter = 1;
            }
            else {
                counter++;
            }
        }
        list.add(counter);
        
        int[] skraceno = new int[list.size()];
        
        for(int i = 0; i < list.size(); i++) {
            skraceno[i] = list.get(i);
        }
        
        for(int i = 0; i < skraceno.length; i++) {
            System.out.printf("%d ", skraceno[i]);
        }
    }
}
