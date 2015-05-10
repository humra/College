package racunarstvo.java;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Rijeci {

    public static void main(String[] args) {
        List<String> rijeci = new ArrayList<String>();
        String temp = "";
        Scanner in = new Scanner(System.in);

        do {
            temp = in.nextLine();
            if (!temp.equals("kraj")) {
                rijeci.add(temp);
            }
        } while (!(temp.equals("kraj")));

        replaceWords("prva", "zamjena", rijeci);
        reverseList(rijeci);
        switchAtPositions(3, 5, rijeci);
        
        List<String> prazna = new ArrayList<String>();
        copyLists(rijeci, prazna);
        
        binarySearch("druga", rijeci);
        replaceAll("zamjena", rijeci);
    }
    
    public static void replaceAll(String replacement, List<String> list) {
        Collections.fill(list, replacement);
    }
    
    public static void binarySearch(String word, List<String> list) {
        System.out.printf("The element you are looking for is at: %d", Collections.binarySearch(list, word));
    }
    
    public static void copyLists(List<String> first, List<String> second) {
        Collections.copy(first, second);
    }
    
    public static void switchAtPositions(int first, int second, List<String> list) {
        Collections.swap(list, first, second);
    }

    public static void reverseList(List<String> list) {
        Collections.reverse(list);
    }
    
    public static void replaceWords(String original, String zamjena, List<String> list) {
        Collections.replaceAll(list, original, zamjena);
    }

}
