package com.vjezba.todolist.podaci;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;

public class Kategorije extends HashMap<Integer, Kategorija> {

	public static final Integer OPCENITO = 1;
	public static final Integer RODENDAN = 2;
	public static final Integer SASTANAK = 3;

	private Kategorije() {
		super();
	}

	public void put(Kategorija kategorija) {
		this.put(kategorija.getId(), kategorija);
	}

	public ListKategorija vratiKategorije() {
		ListKategorija rezultat = new ListKategorija();
		rezultat.addAll(this.values());

		Collections.sort(rezultat);

		return rezultat;
	}

	private static Kategorije _Singleton;

	public static Kategorije Singleton() {
		if (_Singleton == null) {
			_Singleton = new Kategorije();
		}
		return _Singleton;
	}
}
