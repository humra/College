package racunarstvo.java;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class ShoppingList {

    public static void main(String[] args) {
        List<String> lista = new ArrayList<String>();
        List<String> duplikati = new ArrayList<String>();
        
        dodajNaPopis("2", lista, duplikati);
        dodajNaPopis("2", lista, duplikati);
        dodajNaPopis("1", lista, duplikati);
        
        dodajNaPopis("5", lista, duplikati);
        dodajNaPopis("2", lista, duplikati);
        dodajNaPopis("4", lista, duplikati);
        
        Collections.sort(lista);
        Collections.sort(duplikati);
        
        dodajNaPopisSortirano("6", lista, duplikati);
        dodajNaPopisSortirano("7", lista, duplikati);
        dodajNaPopisSortirano("8", lista, duplikati);
        dodajNaPopisSortirano("1", lista, duplikati);
        dodajNaPopisSortirano("9", lista, duplikati);
        
        for(String s : lista) {
            System.out.println(s);
        }
        System.out.println("\n");
        for(String s : duplikati) {
            System.out.println(s);
        }
    }
    
    public static void dodajNaPopisSortirano(String predmet, List<String> lista, List<String> duplikati) {
        if(!lista.contains(predmet)) {
            lista.add(predmet);
            Collections.sort(lista);
        }
        else if(!duplikati.contains(predmet)) {
            duplikati.add(predmet);
            Collections.sort(lista);
        }
    }
    
    public static void dodajNaPopis(String predmet, List<String> lista, List<String> duplikati) {
        if(!lista.contains(predmet)) {
            lista.add(predmet);
        }
        else if(!duplikati.contains(predmet)) {
            duplikati.add(predmet);
        }
    }
}
