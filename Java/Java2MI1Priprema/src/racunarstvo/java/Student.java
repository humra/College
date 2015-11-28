package racunarstvo.java;

public class Student {
    private String ime;
    private String prezime;
    private int id;
    
    private String getIme() {
        return this.ime;
    }
    
    private String getPrezime() {
        return this.prezime;
    }
    
    public Student(String ime, String prezime, int id) {
        this.ime = ime;
        this.prezime = prezime;
        this.id = id;
    }
}
