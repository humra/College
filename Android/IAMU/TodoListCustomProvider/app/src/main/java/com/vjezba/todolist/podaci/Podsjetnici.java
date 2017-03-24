package com.vjezba.todolist.podaci;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;

public class Podsjetnici extends HashMap<Integer, Podsjetnik> {
	
	public static final Integer BEZ_PODSJETNIKA = 1;
	public static final Integer OBAVIJEST = 2;
	public static final Integer EMAIL = 3;
	public static final Integer SMS = 4;
	
	private Podsjetnici()
	{
		super();
	}
	
	public void put (Podsjetnik podsjetnik)
	{
		this.put(podsjetnik.getId(), podsjetnik);
	}
	
	public ListPodsjetnik vratiPodsjetnike ()
	{
		ListPodsjetnik rezultat = new ListPodsjetnik();
		rezultat.addAll(this.values());
		
		Collections.sort(rezultat);
		
		return rezultat;
	}
	
	private static Podsjetnici _Singleton;
	public static Podsjetnici Singleton ()
	{
		if (_Singleton == null)
		{
			_Singleton = new Podsjetnici();
//			_Singleton.put(new Podsjetnik(1, "Bez podsjetnika"));
//			_Singleton.put(new Podsjetnik(2, "Obavijest"));
//			_Singleton.put(new Podsjetnik(3, "E-mail"));
//			_Singleton.put(new Podsjetnik(4, "SMS"));
		}
		return _Singleton;
	}
}
