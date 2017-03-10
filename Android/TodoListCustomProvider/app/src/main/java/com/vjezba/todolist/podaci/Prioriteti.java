package com.vjezba.todolist.podaci;

import java.util.Collections;
import java.util.HashMap;

public class Prioriteti extends HashMap<Integer, Prioritet> {
	
	public static final Integer NIZAK=1;
	public static final Integer SREDNJI=2;
	public static final Integer VISOK=3;
	private Prioriteti()
	{
		super();
	}
	
	public void put (Prioritet prioritet)
	{
		this.put(prioritet.getId(), prioritet);
	}
	
	public ListPrioritet vratiPrioritete ()
	{
		ListPrioritet rezultat = new ListPrioritet();
		rezultat.addAll(this.values());
		
		Collections.sort(rezultat);
		
		return rezultat;
	}
	
	private static Prioriteti _Singleton;
	public static Prioriteti Singleton ()
	{
		if (_Singleton == null)
		{
			_Singleton = new Prioriteti();
//			_Singleton.put(new Prioritet(NIZAK, "Nizak"));
//			_Singleton.put(new Prioritet(SREDNJI, "Srednji"));
//			_Singleton.put(new Prioritet(VISOK, "Visok"));
		}
		return _Singleton;
	}
}
