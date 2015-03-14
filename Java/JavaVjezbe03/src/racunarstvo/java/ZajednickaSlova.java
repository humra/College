package racunarstvo.java;

import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;

public class ZajednickaSlova {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.println("Unesite prvi string: ");
        String s1 = s.nextLine();
        System.out.println("Unesite drugi string: ");
        String s2 = s.nextLine();

        Set<Character> jedinstveni = new HashSet<Character>();
        char temp;

        for (int i = 0; i < s1.length(); i++) {
            temp = s1.charAt(i);
            if (s2.indexOf(temp) > -1) {
                jedinstveni.add((Character) temp);
            }
        }

        for (Character c : jedinstveni) {
            System.out.printf("%c ", c);
        }
    }

}
