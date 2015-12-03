package racunarstvo.java;

public class Student implements java.io.Serializable {
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
    
    //Don't know what this method is supposed to do
    private String createPin() {
        return "";
    }
    
    //Don't know about this one either
    private int addToStudentServis(int ssId) {
        return 0;
    }
    
    @Override
    public String toString() {
        return String.format("[%s, %s]", ime, prezime);
    }
}
