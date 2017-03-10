package com.vjezba.todolist;

import com.vjezba.todolist.fragmenti.PregledKategorijaFragment;
import com.vjezba.todolist.podaci.Kategorija;
import com.vjezba.todolist.podaci.Kategorije;

import android.app.Activity;
import android.app.FragmentTransaction;
import android.os.Bundle;
import android.widget.ArrayAdapter;

public class KategorijeActivity extends Activity implements IKategorija {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);
		
		FragmentTransaction transakcija = this.getFragmentManager().beginTransaction();
		ArrayAdapter<Kategorija> adapter = new ArrayAdapter<Kategorija>(this, R.layout.kategorija_stavka_liste, R.id.tvNaziv, Kategorije.Singleton().vratiKategorije());
		transakcija.add(R.id.flFramenti, new PregledKategorijaFragment(adapter));
		transakcija.commit();
	}

	@Override
	public void obrisiKategoriju(Kategorija odabranaKategorija) {
		this.setResult(RESULT_OK);
	}
}
