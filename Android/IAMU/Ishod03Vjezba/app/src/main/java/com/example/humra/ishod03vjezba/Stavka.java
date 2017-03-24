package com.example.humra.ishod03vjezba;


public class Stavka {
    private String imeStudenta;
    private String prezimeStudenta;
    private String nazivPredmeta;
    private int ocjenaNaIspitu;

    public Stavka() {
    }

    public Stavka(String imeStudenta, String prezimeStudenta, String nazivPredmeta, int ocjenaNaIspitu) {
        this.imeStudenta = imeStudenta;
        this.prezimeStudenta = prezimeStudenta;
        this.nazivPredmeta = nazivPredmeta;
        this.ocjenaNaIspitu = ocjenaNaIspitu;
    }

    public String getImeStudenta() {
        return imeStudenta;
    }

    public void setImeStudenta(String imeStudenta) {
        this.imeStudenta = imeStudenta;
    }

    public String getPrezimeStudenta() {
        return prezimeStudenta;
    }

    public void setPrezimeStudenta(String prezimeStudenta) {
        this.prezimeStudenta = prezimeStudenta;
    }

    public String getNazivPredmeta() {
        return nazivPredmeta;
    }

    public void setNazivPredmeta(String nazivPredmeta) {
        this.nazivPredmeta = nazivPredmeta;
    }

    public int getOcjenaNaIspitu() {
        return ocjenaNaIspitu;
    }

    public void setOcjenaNaIspitu(int ocjenaNaIspitu) {
        this.ocjenaNaIspitu = ocjenaNaIspitu;
    }
}
