package racunarstvo.pppk;

class Kolegij {
    public int IDKolegij;
    public String Naziv;
    public int Semestar;
    public int ECTS;
    
    public Kolegij() {}
    
    public Kolegij(int IDKolegij, String Naziv, int Semestar, int ECTS) {
        this.IDKolegij = IDKolegij;
        this.Naziv = Naziv;
        this.Semestar = Semestar;
        this.ECTS = ECTS;
    }
}
