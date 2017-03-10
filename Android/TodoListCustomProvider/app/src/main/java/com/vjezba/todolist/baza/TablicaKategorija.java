package com.vjezba.todolist.baza;

import com.vjezba.todolist.podaci.*;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

public class TablicaKategorija {

	public static final String NAZIV_TABLICE = "Kategorija";
	public static final String ID = "ID";
	public static final String NAZIV = "Naziv";
	public static final String BRISANJE_MOGUCE = "BrisanjeMoguce";

	SQLiteDatabase db;
	public TablicaKategorija (SQLiteDatabase db)
	{
		this.db = db;
	}

	public void Insert (Kategorija kategorija)
	{
		ContentValues cv = new ContentValues();
		cv.put(NAZIV, kategorija.getNaziv());
		cv.put(BRISANJE_MOGUCE, kategorija.getBrisanjeMoguce());

		int id = (int)this.db.insertOrThrow(NAZIV_TABLICE, null, cv);
		kategorija.setId(id);
	}

	public void Update (Kategorija kategorija)
	{
		ContentValues cv = new ContentValues();
		cv.put(NAZIV, kategorija.getNaziv());
		cv.put(BRISANJE_MOGUCE, kategorija.getBrisanjeMoguce());

		this.db.update(NAZIV_TABLICE, cv, ID + "=?", new String[]{kategorija.getId().toString()});
	}

	public void Delete (Kategorija kategorija)
	{
		this.db.delete(NAZIV_TABLICE, ID + "=?", new String[]{kategorija.getId().toString()});
	}

	private ListKategorija select (String id)
	{
		String[] kolone = new String[]{ID, NAZIV, BRISANJE_MOGUCE}; 
		String where = null;
		String[] whereArgs = null;
		if (id != null)
		{
			where = ID + "=?";
			whereArgs = new String[] {id};
		}
		Cursor cursor = this.db.query(NAZIV_TABLICE, kolone, where, whereArgs, null, null, null);

		ListKategorija lista = new ListKategorija();

		while (cursor.moveToNext())
		{
			Kategorija kategorija = new Kategorija();

			kategorija.setId(cursor.getInt(cursor.getColumnIndex(ID)));
			kategorija.setNaziv(cursor.getString(cursor.getColumnIndex(NAZIV)));
			kategorija.setBrisanjeMoguce(cursor.getInt(cursor.getColumnIndex(BRISANJE_MOGUCE)) == 1 ? true : false);

			lista.add(kategorija);
		}

		return lista;
	}

	public ListKategorija SelectAll ()
	{
		return this.select(null);
	}

	public Kategorija Select (int id)
	{
		Kategorija kategorija = null;

		ListKategorija kategorije = this.select(String.valueOf(id));
		if (kategorije.size() == 1)
			kategorija = kategorije.get(0);

		return kategorija;
	}
}
