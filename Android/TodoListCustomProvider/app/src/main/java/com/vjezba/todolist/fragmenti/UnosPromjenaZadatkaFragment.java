package com.vjezba.todolist.fragmenti;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import android.app.Activity;
import android.app.Fragment;
import android.content.Intent;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.vjezba.todolist.IPotvrdiZadatak;
import com.vjezba.todolist.R;
import com.vjezba.todolist.podaci.Kategorija;
import com.vjezba.todolist.podaci.Kategorije;
import com.vjezba.todolist.podaci.Kontakt;
import com.vjezba.todolist.podaci.Podsjetnici;
import com.vjezba.todolist.podaci.Podsjetnik;
import com.vjezba.todolist.podaci.Zadatak;

public class UnosPromjenaZadatkaFragment extends Fragment {

	public static final String TAG = "UnosPromjenaZadatka";
	public static final int REQ_ODABIR_KONTAKTA = 1;

	Zadatak zadatak;
	public UnosPromjenaZadatkaFragment (Zadatak zadatak)
	{
		this.zadatak = zadatak;
	}

	EditText etTekst;
	ImageView ivZavrsen;
	ImageView ivPrioritet;
	EditText etDatum;
	Spinner sKategorije;
	Spinner sPodsjetnici;

	ImageButton btnPotvrdi;

	TextView tvKontakt;
	ImageButton btnPretrazi;

	IPotvrdiZadatak iPotvrdiZadatak;
	@Override
	public void onAttach(Activity activity) {
		// TODO Auto-generated method stub
		super.onAttach(activity);
		this.iPotvrdiZadatak = (IPotvrdiZadatak) activity;
	}

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {

		View view = inflater.inflate(R.layout.zadatak_unos_promjena, container, false);

		this.etTekst = (EditText) view.findViewById(R.id.etTekst);
		this.ivZavrsen = (ImageView) view.findViewById(R.id.ivZavrsen);
		this.ivPrioritet = (ImageView) view.findViewById(R.id.ivPrioritet);
		this.etDatum = (EditText) view.findViewById(R.id.etDatum);
		this.sKategorije = (Spinner) view.findViewById(R.id.sKategorije);
		this.sPodsjetnici = (Spinner) view.findViewById(R.id.sPodsjetnici);
		this.btnPotvrdi = (ImageButton) view.findViewById(R.id.btnPotvrdi);
		this.btnPretrazi = (ImageButton) view.findViewById(R.id.btnPretrazi);
		this.tvKontakt = (TextView) view.findViewById(R.id.tvKontakt);

		if (this.zadatak.getTekst() != null)
			this.etTekst.setText(this.zadatak.getTekst().toString());

		this.osvjeziZavrsen();
		this.osvjeziPrioritet();

		if (this.zadatak.getDatum() != null)
		{
			SimpleDateFormat df = null;
			if (this.zadatak.getKategorijaID() != null && this.zadatak.getKategorijaID() == Kategorije.RODENDAN)
				df = new SimpleDateFormat("dd.MM.yyyy.");
			else
				df = new SimpleDateFormat("dd.MM.yyyy. HH:mm");
			this.etDatum.setText(df.format(zadatak.getDatum()));
		}

		ArrayAdapter<Kategorija> kategorijaAdapter = new ArrayAdapter<Kategorija>(this.getActivity(),
				android.R.layout.simple_spinner_item, 
				Kategorije.Singleton().vratiKategorije());
		kategorijaAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		this.sKategorije.setAdapter(kategorijaAdapter);

		if (this.zadatak.getKategorija() != null)
			this.sKategorije.setSelection(kategorijaAdapter.getPosition(this.zadatak.getKategorija()));

		ArrayAdapter<Podsjetnik> podsjetnikAdapter = new ArrayAdapter<Podsjetnik>(this.getActivity(),
				android.R.layout.simple_spinner_item, 
				Podsjetnici.Singleton().vratiPodsjetnike());
		podsjetnikAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		this.sPodsjetnici.setAdapter(podsjetnikAdapter);

		if (this.zadatak.getPodsjetnikID() != null)
			this.sPodsjetnici.setSelection(podsjetnikAdapter.getPosition(this.zadatak.getPodsjetnik()));

		if (this.zadatak.getKontaktID() != null)
		{
			Kontakt kontakt = this.zadatak.getKontakt();
			this.tvKontakt.setText(kontakt.toString());
		}

		ivZavrsen.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				zadatak.setZavrsen(!zadatak.getZavrsen());
				osvjeziZavrsen();
			}
		});

		ivPrioritet.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				zadatak.setPrioritetID(zadatak.getPrioritetID() % 3 + 1);
				osvjeziPrioritet();
			}
		});

		this.btnPotvrdi.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				if (potvrdi())
					iPotvrdiZadatak.potvrdiZadatak(zadatak);
			}
		});

		this.btnPretrazi.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				Intent intent = new Intent (Intent.ACTION_PICK, 
						ContactsContract.Contacts.CONTENT_URI);
				startActivityForResult(intent, REQ_ODABIR_KONTAKTA);

			}
		});


		return view;
	}

	private void osvjeziZavrsen ()
	{
		if (this.zadatak.getZavrsen())
			this.ivZavrsen.setImageResource(R.drawable.zavrsen);
		else
			this.ivZavrsen.setImageResource(R.drawable.nezavrsen);
	}

	private void osvjeziPrioritet ()
	{
		switch (zadatak.getPrioritetID())
		{
		case 1:
			this.ivPrioritet.setImageResource(R.drawable.prioritet1);
			break;
		case 2:
			this.ivPrioritet.setImageResource(R.drawable.prioritet2);
			break;
		case 3:
			this.ivPrioritet.setImageResource(R.drawable.prioritet3);
			break;
		}
	}

	private boolean potvrdi ()
	{
		if (this.etTekst.getText().length() == 0)
		{
			Toast.makeText(getActivity(), "Tekst nije unesen", Toast.LENGTH_LONG).show();
			return false;
		}
		SimpleDateFormat sdf = new SimpleDateFormat("dd.MM.yyyy. HH:mm");

		boolean pogresanFormat = false;
		Date date = null;
		try {
			if(this.etDatum.getText().length()>0)
				date = sdf.parse(this.etDatum.getText().toString());
		} catch (ParseException e) {
			pogresanFormat = true;
		}

		sdf = new SimpleDateFormat("dd.MM.yyyy.");
		try
		{
			if(pogresanFormat && this.etDatum.getText().length()>0)
				date = sdf.parse(this.etDatum.getText().toString());
		}
		catch (ParseException e)
		{
			Toast.makeText(getActivity(), "Datum ima neispravan format", Toast.LENGTH_LONG).show();
			return false;
		}

		this.zadatak.setTekst(this.etTekst.getText().toString());
		this.zadatak.setDatum(date);
		this.zadatak.setKategorijaID(((Kategorija)this.sKategorije.getSelectedItem()).getId());
		this.zadatak.setPodsjetnikID(((Podsjetnik)this.sPodsjetnici.getSelectedItem()).getId());

		return true;
	}
	
	@Override
	public void onActivityResult(int requestCode, int resultCode, Intent data) {

		if (requestCode == REQ_ODABIR_KONTAKTA && resultCode == Activity.RESULT_OK)
		{
			Integer kontaktID = Integer.valueOf(data.getData().getLastPathSegment());
			
			if (kontaktID >= 0)
			{
				this.zadatak.setKontaktID(kontaktID);
				Kontakt kontakt = this.zadatak.getKontakt();
				this.tvKontakt.setText(kontakt.toString());
				if (((Kategorija)this.sKategorije.getSelectedItem()).getId() == (Kategorije.RODENDAN))
				{
					this.zadatak.setTekst(kontakt.toString()); 
					this.etTekst.setText(this.zadatak.getTekst());
				}
			}
		}

		super.onActivityResult(requestCode, resultCode, data);
	}
}