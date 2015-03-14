package racunarstvo.java;

import java.util.Scanner;

public class Matrica {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int rang = Integer.parseInt(s.nextLine());

        int[][] matrica = new int[rang][rang];
        int temp;
        for (int i = 0; i < rang; i++) {
            for (int j = 0; j < rang; j++) {
                System.out.printf("Unesite broj: ");
                temp = Integer.parseInt(s.nextLine());
                System.out.println("");

                matrica[i][j] = temp;
            }
        }

        int[][] transponirana = new int[rang][rang];
        
        for (int i = 0; i < rang; i++) {
            for (int j = 0; j < rang; j++) {
                transponirana[j][i] = matrica [i][j];
            }
        }

        for (int i = 0; i < rang; i++) {
            for (int j = 0; j < rang; j++) {
                System.out.printf("%d ", transponirana[i][j]);
            }
            System.out.println("");
        }
    }

}
