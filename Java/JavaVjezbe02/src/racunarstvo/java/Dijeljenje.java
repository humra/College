package racunarstvo.java;

public class Dijeljenje {

    public static void main(String[] args) {
        long pocetak = System.currentTimeMillis();
        for(int i = 0; i < 100000; i++) {
            podijeli(24, 7);
        }
        pocetak = System.currentTimeMillis() - pocetak;
        System.out.println(pocetak);
    }

    public static void podijeli(int prvi, int drugi) {
        int brojac = 0;
        int temp = prvi;
        String s;

        while (temp >= drugi) {
            brojac++;
            temp -= drugi;
        }

        if (prvi == 0) {
            System.out.printf("%d / %d = %d", prvi, drugi, brojac);
        } 
        else {
            s = Integer.toString(brojac);
            s += ".";
            for (int i = 0; i < 3; i++) {
                brojac = 0;
                temp = pomnozi(temp);
                
                while(temp >= drugi) {
                    brojac++;
                    temp -= drugi;
                }
                
                s += Integer.toString(brojac);
                
                if(temp == 0) {
                    break;
                }
            }
            
            System.out.printf("%d / %d = %s\n", prvi, drugi, s);
        }
    }

    public static int pomnozi(int broj) {
        int temp = 0;

        for (int i = 1; i <= 10; i++) {
            temp += broj;
        }

        return temp;
    }
}
