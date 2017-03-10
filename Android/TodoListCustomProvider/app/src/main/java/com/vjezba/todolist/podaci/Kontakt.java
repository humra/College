package com.vjezba.todolist.podaci;

public class Kontakt {
	private Integer id;
	private String naziv;
	private String mobitel;
	private String email;
	
	public Kontakt()
	{
		
	}
	
	public Kontakt(Integer id, String naziv, String mobitel,
			String email) {
		super();
		this.id = id;
		this.naziv = naziv;
		this.mobitel = mobitel;
		this.email = email;
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

	public String getMobitel() {
		return mobitel;
	}

	public void setMobitel(String mobitel) {
		this.mobitel = mobitel;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}
	
	@Override
	public String toString() {
		return this.naziv;
	}
}
