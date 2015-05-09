package racunarstvo.java;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class UniqueWords {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        
        String temp = in.nextLine();
        
        System.out.print("Unesite recenicu: ");
        String[] rijeci = temp.split(" ");
        
        List<String> unikatne = new ArrayList<String>();
        List<String> duplikati = new ArrayList<String>();
        
        for(String s : rijeci) {
            if(!unikatne.contains(s)) {
                unikatne.add(s);
            }
            else if(!duplikati.contains(s)) {
                duplikati.add(s);
            }
        }
        
        System.out.println("Razlicite: ");
        for(String s : unikatne) {
            System.out.println(s);
        }
        
        System.out.println("\nDuplikati: ");
        for(String s : duplikati) {
            System.out.println(s);
        }
    }
    
}
