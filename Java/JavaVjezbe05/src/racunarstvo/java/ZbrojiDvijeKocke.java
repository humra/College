package racunarstvo.java;

import java.util.Random;

public class ZbrojiDvijeKocke {

    public static void main(String[] args) {
        int trazeniZbroj = 4;
        System.out.printf("Trazeni zbroj: %d\nProsjecan broj bacanja: %.2f", trazeniZbroj, prosjekZaZbroj(trazeniZbroj));
    }
    
    public static double prosjekZaZbroj(int trazeniZbroj) {
        long ukupnoBacanja = 0;
        
        for(int i = 0; i < 1000; i++) {
            ukupnoBacanja += baciZaZbroj(trazeniZbroj);
        }
        
        return ukupnoBacanja / 1000.0;
    }
    
    public static int baciZaZbroj(int trazeniZbroj) {
        int counter = 0;
        Random r = new Random();
        int broj1;
        int broj2;
        
        do {
            broj1 = r.nextInt(6) + 1;
            broj2 = r.nextInt(6) + 1;
            counter++;
        }while(broj1 + broj2 != trazeniZbroj);
        
        return counter;
    }
}
