/** Description of Student class
 * @author Matija Huremovic
 * @version 1.0
 */

package racunarstvo.java;

public class Student {
    public String ime;
    public String prezime;
    public String maticniBroj;
    public int godinaStudija;
    
    public Student(String ime, String prezime, String maticniBroj, int godinaStudija) {
        this.ime = ime;
        this.prezime = prezime;
        this.maticniBroj = maticniBroj;
        this.godinaStudija = godinaStudija;
    }
    
    @Override public String toString() {
        return String.format("Maticni broj: %s\r\nIme: %s\r\nPrezime: %s\r\nGodina studija: %d\r\n\r\n", maticniBroj, ime, prezime, godinaStudija);
    }
}
