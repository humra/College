package racunarstvo.java;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Skupovi {

    public static void main(String[] args) {
        int[] skupA = new int[5];
        int[] skupB = new int[5];
        
        for(int i = 1; i <= 5; i++) {
            skupA[i - 1] = i;
        }
        
        for(int i = 4; i <= 8; i++) {
            skupB[i - 4] = i;
        }
        
        unija(skupA, skupB);
        presjek(skupA, skupB);
        
        podskup(skupA, skupB);
        int[] skupC = {1, 2};
        int[] skupD = {1, 2, 3};
        podskup(skupC, skupD);
        
        komplement(skupA);
        komplement(skupB);
    }
    
    public static void komplement(int[] skupA) {
        System.out.printf("R \\ {");
        
        for(int i : skupA) {
            System.out.printf(" %d, ", i);
        }
        System.out.println("}");
    }
    
    public static void podskup(int[] skupA, int[] skupB) {
        Boolean podskup = false;
        
        for(int i : skupA) {
            podskup = false;
            
            for(int j : skupB) {
                if(j == i) {
                    podskup = true;
                    break;
                }
            }
            
            if(podskup == false) {
                break;
            }
        }
        
        System.out.println(podskup);
    }
    
    public static void presjek(int[] skupA, int[] skupB) {
        List<Integer> p = new ArrayList<Integer>();
        
        for(int i : skupA) {
            for(int j : skupB) {
                if(j == i && !(p.contains(j))) {
                    p.add(j);
                }
            }
        }
        
        for(int i : p) {
            System.out.println(i);
        }
    }
    
    public static void unija(int[] skupA, int[] skupB) {
        List<Integer> u = new ArrayList<Integer>();
        
        for(int i : skupA) {
            if(!u.contains(i)) {
                u.add(i);
            }
        }
        for(int i : skupB) {
            if(!u.contains(i)) {
                u.add(i);
            }
        }
        
        for(int i : u) {
            System.out.println(i);
        }
    }
}
