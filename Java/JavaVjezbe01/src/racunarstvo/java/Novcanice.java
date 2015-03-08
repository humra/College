package racunarstvo.java;

import java.util.Scanner;

public class Novcanice {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        System.out.print("Unesite iznos: ");
        double iznos = Double.parseDouble(input.nextLine());

        ispisiPovratNovca(iznos);
    }

    private static void ispisiPovratNovca(double iznos) {
        double[] values = {1000, 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01};
        
        int counter;
        
        for(int i = 0; i < values.length; i++) {
            counter = 0;
            while(iznos - values[i] > 0) {
                counter++;
                iznos -= values[i];
            }
            
            if(counter != 0) {
                System.out.printf("%d * %.2f\n", counter, values[i]);
            }
        }
    }

}