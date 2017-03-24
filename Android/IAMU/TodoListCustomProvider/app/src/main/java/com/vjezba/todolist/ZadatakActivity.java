package com.vjezba.todolist;

import android.app.Activity;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

import com.vjezba.todolist.baza.Baza;
import com.vjezba.todolist.baza.TablicaKategorija;
import com.vjezba.todolist.baza.TablicaPodsjetnik;
import com.vjezba.todolist.baza.TablicaPrioritet;
import com.vjezba.todolist.baza.TablicaZadatak;
import com.vjezba.todolist.fragmenti.PregledZadatakaFragment;
import com.vjezba.todolist.fragmenti.UnosPromjenaZadatkaFragment;
import com.vjezba.todolist.podaci.Kategorija;
import com.vjezba.todolist.podaci.Kategorije;
import com.vjezba.todolist.podaci.Kontakti;
import com.vjezba.todolist.podaci.ListZadatak;
import com.vjezba.todolist.podaci.Podsjetnici;
import com.vjezba.todolist.podaci.Podsjetnik;
import com.vjezba.todolist.podaci.Prioritet;
import com.vjezba.todolist.podaci.Prioriteti;
import com.vjezba.todolist.podaci.Zadatak;

public class ZadatakActivity extends Activity implements IZadatak{

	ZadaciAdapter zadatakAdapter;
	ListZadatak zadaci;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);

		Kontakti.Inicijaliziraj(this.getContentResolver());
		
		Baza baza = new Baza (this);

		// kategorije
		TablicaKategorija tablicaKategorija = new TablicaKategorija(baza.vratiBazu());
		for (Kategorija kategorija : tablicaKategorija.SelectAll())
			Kategorije.Singleton().put(kategorija);

		// prioriteti
		TablicaPrioritet tablicaPrioritet = new TablicaPrioritet(baza.vratiBazu());
		for (Prioritet prioritet : tablicaPrioritet.SelectAll())
			Prioriteti.Singleton().put(prioritet);

		// podsjetnici
		TablicaPodsjetnik tablicaPodsjetnik = new TablicaPodsjetnik(baza.vratiBazu());
		for (Podsjetnik podsjetnik : tablicaPodsjetnik.SelectAll())
			Podsjetnici.Singleton().put(podsjetnik);

		// zadaci
		this.zadaci = new TablicaZadatak(baza.vratiBazu()).SelectAll();
		this.zadatakAdapter = new ZadaciAdapter(this, R.layout.zadatak_stavka_liste, this.zadaci);

		FragmentManager fm = this.getFragmentManager();

		FragmentTransaction transakcija = fm.beginTransaction();
		transakcija.add(R.id.flFramenti, new PregledZadatakaFragment(this.zadatakAdapter), PregledZadatakaFragment.TAG);
		transakcija.commit();
	}

	static int MENI_KATEGORIJA = Menu.FIRST;
	static int KATEGORIJE_ACTIVITY = 1;
	static int UNOS_PROMJENA_ZADATKA_ACTIVITY = 2;

	@Override
	public boolean onMenuItemSelected(int featureId, MenuItem item) {

		if (item.getItemId() == MENI_KATEGORIJA)
		{
			Intent intent = new Intent (this, KategorijeActivity.class);
			this.startActivityForResult(intent, KATEGORIJE_ACTIVITY);
		}

		return super.onMenuItemSelected(featureId, item);
	}

	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {

		boolean potrebnoUcitavanje = false;
		boolean potrebnoOsvjezavanje = false;
		
		if (requestCode == KATEGORIJE_ACTIVITY)
		{
			if (resultCode == RESULT_OK)
				potrebnoUcitavanje = true;
			else
				potrebnoOsvjezavanje = true;
		}
		else if (requestCode == UNOS_PROMJENA_ZADATKA_ACTIVITY)
		{
			if (resultCode == RESULT_OK)
				potrebnoUcitavanje = true;
		}
		
		if (potrebnoUcitavanje)
		{
			Baza baza = new Baza(this);
			this.zadaci = new TablicaZadatak(baza.vratiBazu()).SelectAll();
			this.zadatakAdapter.clear();
			this.zadatakAdapter.addAll(this.zadaci);
		}
		else if (potrebnoOsvjezavanje)
			this.zadatakAdapter.notifyDataSetChanged();

		super.onActivityResult(requestCode, resultCode, data);
	}

	@Override
	public void prikaziZadatak(Zadatak zadatak) {
		Intent intent = new Intent(this, UnosPromjenaZadatkaActivity.class);
		intent.putExtra("ZadatakID", zadatak.getId());
		this.startActivityForResult(intent, UNOS_PROMJENA_ZADATKA_ACTIVITY);
	}

	@Override
	public void obrisiZadatak(Zadatak zadatak) {
		TablicaZadatak tablicaZadatak = new TablicaZadatak(new Baza(this).vratiBazu());
		tablicaZadatak.Delete(zadatak);
		this.zadatakAdapter.remove(zadatak);
	}
}
