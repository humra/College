package com.vjezba.todolist.fragmenti;

import android.app.Activity;
import android.app.Fragment;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnKeyListener;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ListView;

import com.vjezba.todolist.IZadatak;
import com.vjezba.todolist.R;
import com.vjezba.todolist.ZadaciAdapter;
import com.vjezba.todolist.baza.*;
import com.vjezba.todolist.podaci.Zadatak;

public class PregledZadatakaFragment extends Fragment{

	public static final String TAG = "PregledZadataka";
	EditText etTekst;
	ImageButton ibDodaj;
	ImageButton ibPromijeni;
	ImageButton ibObrisi;
	ListView lvZadaci;
	ZadaciAdapter adapter;
	IZadatak iZadatak;
	public PregledZadatakaFragment (ZadaciAdapter adapter)
	{
		this.adapter = adapter;
	}
	
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		this.setHasOptionsMenu(true);
	}
	static int MENI_KATEGORIJA = Menu.FIRST;
	@Override
	public void onCreateOptionsMenu(Menu menu, MenuInflater inflater) {
		menu.add(Menu.NONE, MENI_KATEGORIJA, Menu.NONE, "Kategorije");
		super.onCreateOptionsMenu(menu, inflater);
	}


	@Override
	public void onAttach(Activity activity) {
		// TODO Auto-generated method stub
		super.onAttach(activity);
		this.iZadatak = (IZadatak) activity;
	}

	private boolean dodajZadatak ()
	{
		String tekst = this.etTekst.getText().toString();
		if (tekst.trim().length() == 0)
			return false;

		Zadatak zadatak = new Zadatak (tekst, false);
		TablicaZadatak tablicaZadatak = new TablicaZadatak(new Baza(this.getActivity()).vratiBazu());
		tablicaZadatak.Insert(zadatak);
			
		this.adapter.add(zadatak);
		this.etTekst.setText("");
		return true;
	}


	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
				Bundle savedInstanceState) 
	{
		View view = inflater.inflate(R.layout.zadatak_pregled, container, false);

		this.etTekst = (EditText) view.findViewById(R.id.etTekst);
		this.ibDodaj = (ImageButton) view.findViewById(R.id.ibDodaj);
		this.ibPromijeni = (ImageButton) view.findViewById(R.id.ibPromijeni);
		this.ibObrisi = (ImageButton) view.findViewById(R.id.ibObrisi);
		this.lvZadaci = (ListView) view.findViewById(R.id.lvZadaci);

		this.lvZadaci.setAdapter(this.adapter);

		this.etTekst.setOnKeyListener(new OnKeyListener() {

			@Override
			public boolean onKey(View v, int keyCode, KeyEvent event) {
				if (event.getAction() == KeyEvent.ACTION_DOWN && keyCode == 
		                   KeyEvent.KEYCODE_ENTER)
				{
					dodajZadatak();
					return true;
				}
				return false;
			}
		});

		this.ibDodaj.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				iZadatak.prikaziZadatak(new Zadatak());
			}
		});

		this.ibPromijeni.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				if (lvZadaci.getCheckedItemPosition() == AdapterView.INVALID_POSITION)
				return;
						iZadatak.prikaziZadatak(adapter.getItem(lvZadaci.getCheckedItemPosition()));
			}
		});

		this.ibObrisi.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				if (lvZadaci.getCheckedItemPosition() == AdapterView.INVALID_POSITION)
				return;
						iZadatak.obrisiZadatak(adapter.getItem(lvZadaci.getCheckedItemPosition()));
			}
		});

		return view;
	}

}
