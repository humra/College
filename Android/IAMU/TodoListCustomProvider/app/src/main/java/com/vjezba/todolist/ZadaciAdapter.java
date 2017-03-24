package com.vjezba.todolist;

import java.text.SimpleDateFormat;

import android.content.Context;
import android.graphics.drawable.Drawable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.vjezba.todolist.baza.Baza;
import com.vjezba.todolist.baza.TablicaZadatak;
import com.vjezba.todolist.podaci.Kategorije;
import com.vjezba.todolist.podaci.ListZadatak;
import com.vjezba.todolist.podaci.Zadatak;

public class ZadaciAdapter extends ArrayAdapter<Zadatak> {

	LayoutInflater inflater;

	public ZadaciAdapter(Context context, int textViewResourceId,
			ListZadatak objects) {
		super(context, textViewResourceId, objects);
		this.inflater = LayoutInflater.from(context);
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent) {

		final Zadatak zadatak = this.getItem(position);

		if (convertView == null)
			convertView = this.inflater.inflate(R.layout.zadatak_stavka_liste, null);

		final Context context = this.inflater.getContext();

		ImageView ivPrioritet = (ImageView) convertView.findViewById(R.id.ivPrioritet);
		switch (zadatak.getPrioritetID())
		{
			case 1:
				ivPrioritet.setImageResource(R.drawable.prioritet1);
				break;
			case 2:
				ivPrioritet.setImageResource(R.drawable.prioritet2);
				break;
			case 3:
				ivPrioritet.setImageResource(R.drawable.prioritet3);
				break;
		}
		ivPrioritet.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				zadatak.setPrioritetID(zadatak.getPrioritetID() % 3 + 1);
				TablicaZadatak tablicaZadatak = new TablicaZadatak(new Baza(context).vratiBazu());
				tablicaZadatak.Update(zadatak);
				notifyDataSetChanged();
			}
		});

		ImageView ivZavrsen = (ImageView) convertView.findViewById(R.id.ivZavrsen);
		TextView tvTekst = (TextView) convertView.findViewById(R.id.tvTekst);

		tvTekst.setText(zadatak.getTekst());

		Drawable slika = context.getResources().getDrawable(R.drawable.nezavrsen);
		if (zadatak.getZavrsen())
			slika = context.getResources().getDrawable(R.drawable.zavrsen);

		ivZavrsen.setImageDrawable(slika);
		ivZavrsen.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				zadatak.setZavrsen(!zadatak.getZavrsen());
				TablicaZadatak tablicaZadatak = new TablicaZadatak(new Baza(context).vratiBazu());
				tablicaZadatak.Update(zadatak);
				notifyDataSetChanged();
			}
		});

		if (zadatak.getDatum() != null)
		{
			TextView tvDatum = (TextView) convertView.findViewById(R.id.tvDatum);
			SimpleDateFormat df = null;
			if (zadatak.getKategorijaID() != null && zadatak.getKategorijaID() == Kategorije.RODENDAN)
				df = new SimpleDateFormat("dd.MM.yyyy.");
			else
				df = new SimpleDateFormat("dd.MM.yyyy. HH:mm");
			tvDatum.setText(df.format(zadatak.getDatum()));
		}
		if (zadatak.getKategorijaID() != null && zadatak.getKategorija() != null)
		{
			TextView tvKategorija = (TextView) convertView.findViewById(R.id.tvKategorija);
			tvKategorija.setText(zadatak.getKategorija().getNaziv());
		}

		return convertView;
	}

}

