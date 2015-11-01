package racunarstvo.pppk;

public class Kolegij {
    public String naziv;
    public int semestar;
    public int ECTS;
    public int ID;
    
    public Kolegij() {}
    
    public Kolegij(String naziv, int semestar, int ECTS, int ID) {
        this.naziv = naziv;
        this.semestar = semestar;
        this.ECTS = ECTS;
        this.ID = ID;
    }
}
