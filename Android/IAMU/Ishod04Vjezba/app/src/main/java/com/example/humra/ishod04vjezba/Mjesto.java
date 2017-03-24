package com.example.humra.ishod04vjezba;

/**
 * Created by Matija on 19/08/2016.
 */
public class Mjesto {
    private int ID;
    private String naziv;
    private int brojStanovnika;
    private int zupanijaID;

    public Mjesto() {}

    public Mjesto(int ID, String naziv, int brojStanovnika, int zupanijaID) {
        this.ID = ID;
        this.naziv = naziv;
        this.brojStanovnika = brojStanovnika;
        this.zupanijaID = zupanijaID;
    }

    public int getID() {
        return ID;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public String getNaziv() {
        return naziv;
    }

    public void setNaziv(String naziv) {
        this.naziv = naziv;
    }

    public int getBrojStanovnika() {
        return brojStanovnika;
    }

    public void setBrojStanovnika(int brojStanovnika) {
        this.brojStanovnika = brojStanovnika;
    }

    public int getZupanijaID() {
        return zupanijaID;
    }

    public void setZupanijaID(int zupanijaID) {
        this.zupanijaID = zupanijaID;
    }

    @Override
    public String toString() {
        return String.format(getID() + " " + getNaziv() + " " + getBrojStanovnika() + " " + getZupanijaID());
    }
}
