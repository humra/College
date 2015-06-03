package racunarstvo.java;

import java.util.Scanner;

public class main {

    public static void main(String[] args) {
        Referada r = new Referada();
        
        meni(r);
    }
    
    public static void meni(Referada r) {
        int opcija;
        Scanner s = new Scanner(System.in);
        
        do {
            System.out.println("1)Unos novog studenta\n2)Izmjena podataka o studentu\n3)Ispis podataka o studentu\n4)Ispis podataka o studentima\n5)Ucitaj podatke\n6)Spremi podatke\n7)Izlaz");
            opcija = Integer.parseInt(s.nextLine());
            
            switch(opcija) {
                case 1: 
                    System.out.println("Unesite maticni broj, ime, prezime i godinu studija studenta: ");
                    String noviStudent = s.nextLine();
                    String[] podaci1 = noviStudent.split(",");
                    r.dodajStudenta(new Student(podaci1[0], podaci1[1], podaci1[2], Integer.parseInt(podaci1[3])));
                    break;
                case 2:
                    System.out.println("Unesite maticni broj studenta za kojeg zelite izmijeniti podatke te njegove podatke: ");
                    String izmjena = s.nextLine();
                    String[] podaci2 = izmjena.split(",");
                    r.izmjeniPodatke(podaci2[0], podaci2[1], podaci2[2], Integer.parseInt(podaci2[3]));
                    break;
                case 3:
                    System.out.println("Unesite maticni broj studenta: ");
                    String maticniBroj = s.nextLine();
                    System.out.println(r.dohvatiPodatkeStudenta(maticniBroj));
                    break;
                case 4:
                    System.out.println(r.podaciZaSveStudente());
                    break;
                case 5:
                    r.ucitajPodatke();
                    break;
                case 6:
                    r.spremiPodatke();
                    break;
            }
        }while(opcija != 7);
    }
}
