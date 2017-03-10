package com.vjezba.todolist.podaci;

import java.util.Date;

public class Zadatak {
	private Integer id;
	private String tekst;
	private Boolean zavrsen;
	private Date datum;

	private Integer kategorijaID;
	private Integer prioritetID;
	private Integer podsjetnikID;
	private Integer kontaktID;

	public Zadatak ()
	{
		this.prioritetID = Prioriteti.NIZAK;
		this.kategorijaID = Kategorije.OPCENITO;
		this.podsjetnikID = Podsjetnici.BEZ_PODSJETNIKA;
		this.zavrsen = false;
	}

	public Zadatak (String tekst, Boolean zavrsen)
	{
		this();
		this.tekst = tekst;
		this.zavrsen = zavrsen;
	}

	public Zadatak(Integer id, String tekst, Boolean zavrsen, Date datum,
			Integer kategorijaID, Integer prioritetID, Integer podsjetnikID) {
		this.id = id;
		this.tekst = tekst;
		this.zavrsen = zavrsen;
		this.datum = datum;

		this.kategorijaID = kategorijaID;
		this.prioritetID = prioritetID;
		this.podsjetnikID = podsjetnikID;
	}

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

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

	public Date getDatum() {
		return datum;
	}

	public void setDatum(Date datum) {
		this.datum = datum;
	}

	public Integer getKategorijaID() {
		return kategorijaID;
	}

	public void setKategorijaID(Integer kategorijaID) {
		this.kategorijaID = kategorijaID;
	}

	public Integer getPrioritetID() {
		return prioritetID;
	}

	public void setPrioritetID(Integer prioritetID) {
		this.prioritetID = prioritetID;
	}

	public Integer getPodsjetnikID() {
		return podsjetnikID;
	}

	public void setPodsjetnikID(Integer podsjetnikID) {
		this.podsjetnikID = podsjetnikID;
	}

	public Integer getKontaktID() {
		return kontaktID;
	}

	public void setKontaktID(Integer kontaktID) {
		this.kontaktID = kontaktID;
	}

	public Kategorija getKategorija ()
	{
		if (this.kategorijaID == null)
			return null;
		return Kategorije.Singleton().get(this.kategorijaID);
	}

	public Prioritet getPrioritet ()
	{
		if (this.prioritetID == null)
			return null;
		return Prioriteti.Singleton().get(this.prioritetID);
	}

	public Podsjetnik getPodsjetnik()
	{
		if (this.podsjetnikID == null)
			return null;
		return Podsjetnici.Singleton().get(this.podsjetnikID);
	}
	
	public Kontakt getKontakt ()
	{
		if (this.kontaktID == null)
			return null;
		
		return Kontakti.Singleton().vratiKontakt(this.kontaktID);
	}
}
