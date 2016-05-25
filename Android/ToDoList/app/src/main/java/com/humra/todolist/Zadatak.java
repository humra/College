package com.humra.todolist;

/**
 * Created by Matija on 25.5.2016..
 */
public class Zadatak {
    private String tekst;
    private Boolean zavrsen;

    public Zadatak(String tekst, Boolean zavrsen) {
        this.tekst = tekst;
        this.zavrsen = zavrsen;
    }

    public Zadatak() {}

    public String getTekst() {
        return tekst;
    }

    public void setTekst(String tekst) {
        this.tekst = tekst;
    }

    public Boolean getZavrsen() {
        return zavrsen;
    }

    public void setZavrsen(Boolean zavrsen) {
        this.zavrsen = zavrsen;
    }
}
