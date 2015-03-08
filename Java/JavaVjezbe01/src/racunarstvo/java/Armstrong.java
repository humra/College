package racunarstvo.java;

public class Armstrong {

    public static void main(String[] args) {
        
        for (int i = 1; i < 10000; i++) {
            if(isArmstrong(i)) {
                System.out.println(i);
            }
        }
    }

    private static boolean isArmstrong(int i) {
        
        int suma = 0;
        int temp = i;
        
        while(i > 0) {
            int zZnam = i % 10;
            suma += Math.pow(zZnam, 3);
            i = i / 10;
        }
        
        return suma == temp;
    }
}
