package racunarstvo.java;

import java.util.Scanner;

public class Calc {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        System.out.println("Prvi: ");
        int prvi = Integer.parseInt(input.nextLine());
        
        System.out.println("Drugi: ");
        int drugi = Integer.parseInt(input.nextLine());
        
        System.out.printf("%d + %d = %d", prvi, drugi, prvi + drugi);
    }

}
