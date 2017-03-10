 package com.vjezba.todolist.podaci;

public class Kategorija implements Comparable<Kategorija> {
	private Integer id;
	private String naziv;
	private Boolean brisanjeMoguce;
	
	public Kategorija() {
		this.brisanjeMoguce = true;
	}
	
	public Kategorija(Integer id, String naziv) {
		this.id = id;
		this.naziv = naziv;
		this.brisanjeMoguce = true; 
	}
	
	public Kategorija(Integer id, String naziv, Boolean brisanjeMoguce) {
		this.id = id;
		this.naziv = naziv;
		this.brisanjeMoguce = brisanjeMoguce; 
	}

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getNaziv() {
		return naziv;
	}

	public void setNaziv(String naziv) {
		this.naziv = naziv;
	}

	public Boolean getBrisanjeMoguce() {
		return brisanjeMoguce;
	}

	public void setBrisanjeMoguce(Boolean brisanjeMoguce) {
		this.brisanjeMoguce = brisanjeMoguce;
	}
	
	@Override
	public String toString() {
		return this.naziv;
	}

	@Override
	public int compareTo(Kategorija another) {
		return this.id.compareTo(another.id);
	}
	
}
