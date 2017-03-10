package com.vjezba.todolist.baza;

import java.text.ParseException;
import java.text.SimpleDateFormat;

import com.vjezba.todolist.podaci.*;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

public class TablicaZadatak {

	public static final String NAZIV_TABLICE = "Zadatak";
	public static final String ID = "ID";
	public static final String TEKST = "Tekst";
	public static final String ZAVRSEN = "Zavrsen";
	public static final String DATUM = "Datum";
	public static final String KATEGORIJA_ID = "KategorijaID";
	public static final String PRIORITET_ID = "PrioritetID";
	public static final String PODSJETNIK_ID = "PodsjetnikID";
	public static final String KONTAKT_ID = "KontaktID";

	SQLiteDatabase db;
	public TablicaZadatak (SQLiteDatabase db)
	{
		this.db = db;
	}

	public void Insert (Zadatak zadatak)
	{
		ContentValues cv = new ContentValues();
		cv.put(TEKST, zadatak.getTekst());
		cv.put(ZAVRSEN, zadatak.getZavrsen() == true ? 1 : 0);
		if (zadatak.getDatum() != null)
		{
			SimpleDateFormat sdf = new SimpleDateFormat("dd.MM.yyyy. HH:mm");
			cv.put(DATUM, sdf.format(zadatak.getDatum()));
		}
		cv.put(KATEGORIJA_ID, zadatak.getKategorijaID());
		cv.put(PRIORITET_ID, zadatak.getPrioritetID());
		cv.put(PODSJETNIK_ID, zadatak.getPodsjetnikID());
		cv.put(KONTAKT_ID, zadatak.getKontaktID());

		int id = (int)this.db.insertOrThrow(NAZIV_TABLICE, null, cv);
		zadatak.setId(id);
	}

	public void Update (Zadatak zadatak)
	{
		ContentValues cv = new ContentValues();
		cv.put(TEKST, zadatak.getTekst());
		cv.put(ZAVRSEN, zadatak.getZavrsen() == true ? 1 : 0);
		if (zadatak.getDatum() != null)
		{
			SimpleDateFormat sdf = new SimpleDateFormat("dd.MM.yyyy. HH:mm");
			cv.put(DATUM, sdf.format(zadatak.getDatum()));
		}
		cv.put(KATEGORIJA_ID, zadatak.getKategorijaID());
		cv.put(PRIORITET_ID, zadatak.getPrioritetID());
		cv.put(PODSJETNIK_ID, zadatak.getPodsjetnikID());
		cv.put(KONTAKT_ID, zadatak.getKontaktID());
		
		this.db.update(NAZIV_TABLICE, cv, ID + "=?", new String[]{zadatak.getId().toString()});
	}

	public void Delete (Zadatak zadatak)
	{
		this.db.delete(NAZIV_TABLICE, ID + "=?", new String[]{zadatak.getId().toString()});
	}

	private ListZadatak select (String id)
	{
		String[] kolone = new String[]{ID, TEKST, ZAVRSEN, DATUM,KATEGORIJA_ID, PRIORITET_ID, PODSJETNIK_ID, KONTAKT_ID}; 
		String where = null;
		String[] whereArgs = null;
		if (id != null)
		{
			where = ID + "=?";
			whereArgs = new String[] {id};
		}
			Cursor cursor = this.db.query(NAZIV_TABLICE, kolone, where, whereArgs, null, null, null);

			ListZadatak lista = new ListZadatak();

		while (cursor.moveToNext())
		{
			Zadatak zadatak = new Zadatak();

			zadatak.setId(cursor.getInt(cursor.getColumnIndex(ID)));
			zadatak.setTekst(cursor.getString(cursor.getColumnIndex(TEKST)));
			zadatak.setZavrsen(cursor.getInt(cursor.getColumnIndex(ZAVRSEN)) == 1 ? true : false);
			
			if (!cursor.isNull(cursor.getColumnIndex(DATUM)))
			{
				SimpleDateFormat sdf = new SimpleDateFormat("dd.MM.yyyy. HH:mm");
				try {
					zadatak.setDatum(sdf.parse(cursor.getString(cursor.getColumnIndex(DATUM))));
				} catch (ParseException e) {
					e.printStackTrace();
				}
			}
			
			zadatak.setKategorijaID(cursor.getInt(cursor.getColumnIndex(KATEGORIJA_ID)));
			
			if (!cursor.isNull(cursor.getColumnIndex(PRIORITET_ID)))
				zadatak.setPrioritetID(cursor.getInt(cursor.getColumnIndex(PRIORITET_ID)));
			
			if (!cursor.isNull(cursor.getColumnIndex(PODSJETNIK_ID)))
				zadatak.setPodsjetnikID(cursor.getInt(cursor.getColumnIndex(PODSJETNIK_ID)));

			if (!cursor.isNull(cursor.getColumnIndex(KONTAKT_ID)))
				zadatak.setKontaktID(cursor.getInt(cursor.getColumnIndex(KONTAKT_ID)));
			
			lista.add(zadatak);
		}

		return lista;
	}

	public ListZadatak SelectAll ()
	{
		return this.select(null);
	}

	public Zadatak Select (int id)
	{
		Zadatak zadatak = null;

		ListZadatak zadaci = this.select(String.valueOf(id));
		if (zadaci.size() == 1)
			zadatak = zadaci.get(0);

		return zadatak;
	}
}
