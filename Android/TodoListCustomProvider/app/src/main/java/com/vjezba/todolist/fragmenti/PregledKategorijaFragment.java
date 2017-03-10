package com.vjezba.todolist.fragmenti;

import android.app.Activity;
import android.app.Fragment;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnKeyListener;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.Toast;

import com.vjezba.todolist.IKategorija;
import com.vjezba.todolist.R;
import com.vjezba.todolist.baza.Baza;
import com.vjezba.todolist.baza.TablicaKategorija;
import com.vjezba.todolist.podaci.Kategorija;
import com.vjezba.todolist.podaci.Kategorije;

public class PregledKategorijaFragment extends Fragment {

	public static final String TAG = "PregledKategorija";

	EditText etNaziv;
	LinearLayout llPregled;
	LinearLayout llPotvrdiOdbaci;
	ImageButton ibDodaj;
	ImageButton ibPromijeni;
	ImageButton ibObrisi;
	ImageButton ibPotvrdi;
	ImageButton ibOdbaci;
	ListView lvKategorije;
	ArrayAdapter<Kategorija> adapter;
	int nacin = 1; // 1 za pregled, 2 za promjenu

	IKategorija iKategorija;

	public PregledKategorijaFragment (ArrayAdapter<Kategorija> adapter)
	{
		this.adapter = adapter;
	}

	@Override
	public void onAttach(Activity activity) {
		// TODO Auto-generated method stub
		super.onAttach(activity);
		this.iKategorija = (IKategorija) activity;
	}

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {

		View view = inflater.inflate(R.layout.kategorija_pregled, container, false);

		this.etNaziv = (EditText) view.findViewById(R.id.etNaziv);
		this.llPregled =(LinearLayout) view.findViewById(R.id.llPregled);
		this.llPotvrdiOdbaci =(LinearLayout) view.findViewById(R.id.llPotvrdiOdbaci);

		this.ibDodaj = (ImageButton) view.findViewById(R.id.ibDodaj);
		this.ibPromijeni = (ImageButton) view.findViewById(R.id.ibPromijeni);
		this.ibObrisi = (ImageButton) view.findViewById(R.id.ibObrisi);
		this.ibPotvrdi = (ImageButton) view.findViewById(R.id.ibPotvrdi);
		this.ibOdbaci = (ImageButton) view.findViewById(R.id.ibOdbaci);
		this.lvKategorije = (ListView) view.findViewById(R.id.lvKategorija);

		this.lvKategorije.setAdapter(this.adapter);

		this.etNaziv.setOnKeyListener(new OnKeyListener() {

			@Override
			public boolean onKey(View v, int keyCode, KeyEvent event) {
				if (event.getAction() == KeyEvent.ACTION_DOWN && keyCode == KeyEvent.KEYCODE_ENTER)
				{
					if (nacin == 1)
					{
						dodajKategoriju();
						return true;
					}
				}
				return false;
			}
		});

		this.ibDodaj.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				dodajKategoriju();
			}
		});

		this.ibPromijeni.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				if (lvKategorije.getCheckedItemPosition() == AdapterView.INVALID_POSITION)
					return;
				Kategorija odabranaKategorija = adapter.getItem(lvKategorije.getCheckedItemPosition());
				etNaziv.setText(odabranaKategorija.getNaziv());
				promijeniNacin(2);
			}
		});

		this.ibObrisi.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				if (lvKategorije.getCheckedItemPosition() == AdapterView.INVALID_POSITION)
					return;
				Kategorija odabranaKategorija = adapter.getItem(lvKategorije.getCheckedItemPosition());
				if (odabranaKategorija.getBrisanjeMoguce())
				{
					Kategorije.Singleton().remove(odabranaKategorija.getId());
					TablicaKategorija tablicaKategorija = new TablicaKategorija(new Baza (getActivity()).vratiBazu());
					tablicaKategorija.Delete(odabranaKategorija);
					adapter.remove(odabranaKategorija);
					iKategorija.obrisiKategoriju(odabranaKategorija);
				}
				else
					Toast.makeText(getActivity(), "Kategorija se ne može obrisati", Toast.LENGTH_LONG).show();
			}
		});

		this.ibPotvrdi.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				if (etNaziv.getText().length() == 0)
				{
					Toast.makeText(getActivity(), "Naziv nije unesen", Toast.LENGTH_LONG).show();
					return;
				}

				Kategorija odabranaKategorija = adapter.getItem(lvKategorije.getCheckedItemPosition());
				odabranaKategorija.setNaziv(etNaziv.getText().toString());
				TablicaKategorija tablicaKategorija = new TablicaKategorija(new Baza (getActivity()).vratiBazu());
				tablicaKategorija.Update(odabranaKategorija);
				adapter.notifyDataSetChanged();
				promijeniNacin(1);
			}
		});

		this.ibOdbaci.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				promijeniNacin(1);
			}
		});

		return view;
	}

	private void dodajKategoriju ()
	{
		if (this.etNaziv.getText().length() == 0)
		{
			Toast.makeText(this.getActivity(), "Naziv nije unesen", Toast.LENGTH_LONG).show();
			return;
		}
		Kategorija kategorija = new Kategorija(Kategorije.Singleton().size() + 1, this.etNaziv.getText().toString());
		this.etNaziv.setText("");
		
		TablicaKategorija tablicaKategorija = new TablicaKategorija(new Baza (this.getActivity()).vratiBazu());
		tablicaKategorija.Insert(kategorija);
		
		this.adapter.add(kategorija);
		Kategorije.Singleton().put(kategorija);
	}

	private void promijeniNacin (int nacin)
	{
		this.nacin = nacin;
		if (this.nacin == 1)
		{
			this.etNaziv.setText("");
			this.llPregled.setVisibility(View.VISIBLE);
			this.llPotvrdiOdbaci.setVisibility (View.GONE);
			this.lvKategorije.clearChoices();
		}
		else
		{
			this.llPregled.setVisibility(View.GONE);
			this.llPotvrdiOdbaci.setVisibility (View.VISIBLE);
		}
	}
}
