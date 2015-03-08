package racunarstvo.java;

public class SavrseniBrojevi {

    public static void main(String[] args) {
        
        for(int i = 1; i < 10000; i++) {
            if(savrsen(i)) {
                System.out.println(i);
            }
        }
    }

    private static boolean savrsen(int broj) {
        int suma = 0;
        
        for(int i = 1; i < broj; i++) {
            if(broj % i == 0) {
                suma += i;
            }
        }
        
        return suma == broj;
    }
    
}
