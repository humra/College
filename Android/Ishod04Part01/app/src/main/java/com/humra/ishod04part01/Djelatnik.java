package com.humra.ishod04part01;

/**
 * Created by Matija on 27/08/2016.
 */
public class Djelatnik {

    private int ID;
    private String ime;
    private String prezime;
    private String datumRodjenja;
    private float iznosPlace;

    public Djelatnik(int ID, String ime, String prezime, String datumRodjenja, float iznosPlace) {
        this.ID = ID;
        this.ime = ime;
        this.prezime = prezime;
        this.datumRodjenja = datumRodjenja;
        this.iznosPlace = iznosPlace;
    }

    public Djelatnik() {}

    public int getID() {
        return ID;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public String getIme() {
        return ime;
    }

    public void setIme(String ime) {
        this.ime = ime;
    }

    public String getPrezime() {
        return prezime;
    }

    public void setPrezime(String prezime) {
        this.prezime = prezime;
    }

    public String getDatumRodjenja() {
        return datumRodjenja;
    }

    public void setDatumRodjenja(String datumRodjenja) {
        this.datumRodjenja = datumRodjenja;
    }

    public float getIznosPlace() {
        return iznosPlace;
    }

    public void setIznosPlace(float iznosPlace) {
        this.iznosPlace = iznosPlace;
    }
}
