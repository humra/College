package racunarstvo.java;

public class Student {
    private String ime;
    private String prezime;
    private int id;
    
    public String getIme() {
        return this.ime;
    }
    
    public String getPrezime() {
        return this.prezime;
    }
    
    public Student(String ime, String prezime) {
        this.ime = ime;
        this.prezime = prezime;
    }
    
    private String createPin() {
        return "";
    }
    
    private int addToStudentServis(int ssId) {
        return 0;
    }
    
    @Override
    public String toString() {
        return String.format("[%s, %s]", ime, prezime);
    }
}
