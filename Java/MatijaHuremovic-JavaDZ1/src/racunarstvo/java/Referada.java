/** Description of Referada class
 * @author Matija Huremovic
 * @version 1.0
 */

package racunarstvo.java;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Referada {
    private List<Student> listaStudenata;
    
    /** Ucitava podatke o studentima koji su prethodno
     * spremljeni u studenti.txt datoteci. Poziva se
     * od strane korisnika.
     * 
     * @throws FileNotFoundException    Ako navedeni file ne postoji
     * @throws IOException  Ako se desi greska prilikom citanja
     */
    public void ucitajPodatke() {
        try {
            BufferedReader br = new BufferedReader(new FileReader("studenti.txt"));
            
            String temp;
            while((temp = br.readLine()) != null) {
                String[] podaci = temp.split("\\|");
                dodajStudenta(new Student(podaci[0], podaci[1], podaci[2], Integer.parseInt(podaci[3])));
            }
            
            br.close();
        }
        catch (FileNotFoundException ex) {
            Logger.getLogger(Referada.class.getName()).log(Level.SEVERE, null, ex);
        }
        catch (IOException ex) {
            Logger.getLogger(Referada.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    /** Ucitava podatke iz defaultne studenti.txt datoteke i sprema ih u listu.
     * 
     * @throws IOException  Ako dodje do greske prilikom citanja.
     */
    public void spremiPodatke() {
        try {
            BufferedWriter bw = new BufferedWriter(new FileWriter("studenti.txt"));
            
            for(Student s : listaStudenata) {
                bw.write(s.maticniBroj);
                bw.write("|");
                bw.write(s.ime);
                bw.write("|");
                bw.write(s.prezime);
                bw.write("|");
                bw.write(String.valueOf(s.godinaStudija));
                bw.write("\r\n");
            }
            
            bw.close();
        }
        catch (IOException ex) {
            Logger.getLogger(Referada.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public Referada() {
        this.listaStudenata = new ArrayList<Student>();
    }
    
    /** Dodaje novog studenta u listu ako vec ne postoji student sa zadanim
     * maticnim brojem.
     * 
     * @param s Student
     *      */
    public void dodajStudenta(Student s) {
        if(!provjeriMaticniBroj(s.maticniBroj)) {
            listaStudenata.add(s);
        }
        else {
            System.out.println("Student sa tim maticnim brojem vec postoji!");
        }
    }
    
    /** Provjerava postojanje studenta u listi.
     * 
     * @param maticniBroj
     * @return true Ako pornadje studenta sa zadanim maticnim brojem.
     */
    private boolean provjeriMaticniBroj(String maticniBroj) {
        for(Student s : listaStudenata) {
            if(s.maticniBroj.equals(maticniBroj)) {
                return true;
            }
        }
        
        return false;
    }
    
    /** Za studenta zadanog po maticnom broju mijenja ime, prezime i godinu studija.
     * 
     * @param maticniBroj
     * @param ime
     * @param prezime
     * @param godinaStudija 
     */
    public void izmjeniPodatke(String maticniBroj, String ime, String prezime, int godinaStudija) {
        Student temp;
        
        for(Student s : listaStudenata) {
            if(s.maticniBroj.equals(maticniBroj)) {
                s.ime = ime;
                s.prezime = prezime;
                s.godinaStudija = godinaStudija;
                break;
            }
        }
    }
    
    /** Vraca podatke o svim studentima na zadanoj godini studija.
     * 
     * @param godinaStudija
     * @return  String sa podacima o studentima.
     */
    public String podaciZaGodinu(int godinaStudija) {
        StringBuilder sb = new StringBuilder();
        
        for(Student s : listaStudenata) {
            if(s.godinaStudija == godinaStudija) {
                sb.append(s.toString());
            }
        }
        
        return sb.toString();
    }
    
    /** Vraca podatke o svim studentima u listi.
     * 
     * @return  String sa podacima o svim studentima.
     */
    public String podaciZaSveStudente() {
        StringBuilder sb = new StringBuilder();
        
        for(Student s : listaStudenata) {
            sb.append(s.toString());
        }
        
        return sb.toString();
    }
    
    /** Vraca podatke o studentu zadanom maticnim brojem.
     * 
     * @param maticniBroj
     * @return  String sa podacima o trazenom studentu.
     */
    public String dohvatiPodatkeStudenta(String maticniBroj) {
        for(Student s : listaStudenata) {
            if(s.maticniBroj.equals(maticniBroj)) {
                return s.toString();
            }
        }
        
        return "Nije pronadjen student";
    }
}
