package racunarstvo.java;

public class VelikiBrojeviCalc {

    public static void main(String[] args) {
       VelikiBroj prvi = new VelikiBroj("6763535634554");
       VelikiBroj drugi = new VelikiBroj("455235353");
       
       String rezultat = prvi.add(drugi);
       System.out.println(rezultat);
    }
    
}
