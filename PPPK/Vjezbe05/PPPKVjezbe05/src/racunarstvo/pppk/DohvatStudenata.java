package racunarstvo.pppk;

import java.util.List;

public class DohvatStudenata {
    public int brojStudenata;
    public List<Student> studenti;
    
    public DohvatStudenata(int brojStudenata, List<Student> studenti) {
        this.brojStudenata = brojStudenata;
        this.studenti = studenti;
    }
}
