/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package racunarstvo.java;

/**
 *
 * @author Matija
 */
public class Student {

    private String ime;
    private String prezime;
    
    public Student(String ime, String prezime) {
        this.ime = ime;
        this.prezime = prezime;
    }
    
    public void setIme(String ime) {
        this.ime = ime;
    }
    
    public void setPrezime(String prezime) {
        this.prezime = prezime;
    }
    
    public String getIme() {
        return this.ime;
    }
    
    public String getPrezime() {
        return this.prezime;
    }
}
