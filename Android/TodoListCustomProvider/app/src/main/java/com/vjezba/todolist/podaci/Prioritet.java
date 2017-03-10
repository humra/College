 package com.vjezba.todolist.podaci;

public class Prioritet implements Comparable<Prioritet> {
	private Integer id;
	private String naziv;
	
	public Prioritet() {
		
	}
	
	public Prioritet(Integer id, String naziv) {
		this.id = id;
		this.naziv = naziv;
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
	
	@Override
	public String toString() {
		return this.naziv;
	}

	@Override
	public int compareTo(Prioritet another) {
		return this.id.compareTo(another.id);
	}
}
