package com.vjezba.todolist.baza;

import com.vjezba.todolist.podaci.*;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

public class TablicaPodsjetnik {

	public static final String NAZIV_TABLICE = "Podsjetnik";
	public static final String ID = "ID";
	public static final String NAZIV = "Naziv";

	SQLiteDatabase db;
	public TablicaPodsjetnik (SQLiteDatabase db)
	{
		this.db = db;
	}

	public void Insert (Podsjetnik podsjetnik)
	{
		ContentValues cv = new ContentValues();
		cv.put(NAZIV, podsjetnik.getNaziv());

		int id = (int)this.db.insertOrThrow(NAZIV_TABLICE, null, cv);
		podsjetnik.setId(id);
	}

	public void Update (Podsjetnik podsjetnik)
	{
		ContentValues cv = new ContentValues();
		cv.put(NAZIV, podsjetnik.getNaziv());

		this.db.update(NAZIV_TABLICE, cv, ID + "=?", new String[]{podsjetnik.getId().toString()});
	}

	public void Delete (Podsjetnik podsjetnik)
	{
		this.db.delete(NAZIV_TABLICE, ID + "=?", new String[]{podsjetnik.getId().toString()});
	}

	private ListPodsjetnik select (String id)
	{
		String[] kolone = new String[]{ID, NAZIV}; 
		String where = null;
		String[] whereArgs = null;
		if (id != null)
		{
			where = ID + "=?";
			whereArgs = new String[] {id};
		}
		Cursor cursor = this.db.query(NAZIV_TABLICE, kolone, where, whereArgs, null, null, null);

		ListPodsjetnik lista = new ListPodsjetnik();

		while (cursor.moveToNext())
		{
			Podsjetnik podsjetnik = new Podsjetnik();

			podsjetnik.setId(cursor.getInt(cursor.getColumnIndex(ID)));
			podsjetnik.setNaziv(cursor.getString(cursor.getColumnIndex(NAZIV)));

			lista.add(podsjetnik);
		}

		return lista;
	}

	public ListPodsjetnik SelectAll ()
	{
		return this.select(null);
	}

	public Podsjetnik Select (int id)
	{
		Podsjetnik podsjetnik = null;

		ListPodsjetnik podsjetniki = this.select(String.valueOf(id));
		if (podsjetniki.size() == 1)
			podsjetnik = podsjetniki.get(0);

		return podsjetnik;
	}
}
