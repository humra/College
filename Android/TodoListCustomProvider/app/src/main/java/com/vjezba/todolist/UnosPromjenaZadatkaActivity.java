package com.vjezba.todolist;

import android.app.Activity;
import android.app.FragmentTransaction;
import android.os.Bundle;

import com.vjezba.todolist.baza.Baza;
import com.vjezba.todolist.baza.TablicaZadatak;
import com.vjezba.todolist.fragmenti.UnosPromjenaZadatkaFragment;
import com.vjezba.todolist.podaci.Zadatak;

public class UnosPromjenaZadatkaActivity extends Activity implements IPotvrdiZadatak {
	Zadatak zadatak;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);
		
		FragmentTransaction transakcija = this.getFragmentManager().beginTransaction();
		
		int zadatakID = this.getIntent().getIntExtra("ZadatakID", -1);
		if (zadatakID == -1)
			this.zadatak = new Zadatak();
		else
		{
			TablicaZadatak tablica = new TablicaZadatak(new Baza (this).vratiBazu());
			this.zadatak = tablica.Select(zadatakID);
		}
		
		transakcija.add(R.id.flFramenti, new UnosPromjenaZadatkaFragment(this.zadatak));
		transakcija.commit();
	}

	@Override
	public void potvrdiZadatak(Zadatak zadatak) {
		TablicaZadatak tablicaZadatak = new TablicaZadatak(new Baza(this).vratiBazu());
		
		if (this.zadatak.getId() == null)
			tablicaZadatak.Insert(zadatak);
		else
			tablicaZadatak.Update(zadatak);
		this.setResult(RESULT_OK);
		finish();
	}
}
