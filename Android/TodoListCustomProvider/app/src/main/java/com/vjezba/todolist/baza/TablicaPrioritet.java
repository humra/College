package com.vjezba.todolist.baza;

import com.vjezba.todolist.podaci.*;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

public class TablicaPrioritet {

	public static final String NAZIV_TABLICE = "Prioritet";
	public static final String ID = "ID";
	public static final String NAZIV = "Naziv";

	SQLiteDatabase db;
	public TablicaPrioritet (SQLiteDatabase db)
	{
		this.db = db;
	}

	public void Insert (Prioritet prioritet)
	{
		ContentValues cv = new ContentValues();
		cv.put(NAZIV, prioritet.getNaziv());

		int id = (int)this.db.insertOrThrow(NAZIV_TABLICE, null, cv);
		prioritet.setId(id);
	}

	public void Update (Prioritet prioritet)
	{
		ContentValues cv = new ContentValues();
		cv.put(NAZIV, prioritet.getNaziv());

		this.db.update(NAZIV_TABLICE, cv, ID + "=?", new String[]{prioritet.getId().toString()});
	}

	public void Delete (Prioritet prioritet)
	{
		this.db.delete(NAZIV_TABLICE, ID + "=?", new String[]{prioritet.getId().toString()});
	}

	private ListPrioritet select (String id)
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

		ListPrioritet lista = new ListPrioritet();

		while (cursor.moveToNext())
		{
			Prioritet prioritet = new Prioritet();

			prioritet.setId(cursor.getInt(cursor.getColumnIndex(ID)));
			prioritet.setNaziv(cursor.getString(cursor.getColumnIndex(NAZIV)));

			lista.add(prioritet);
		}

		return lista;
	}

	public ListPrioritet SelectAll ()
	{
		return this.select(null);
	}

	public Prioritet Select (int id)
	{
		Prioritet prioritet = null;

		ListPrioritet prioriteti = this.select(String.valueOf(id));
		if (prioriteti.size() == 1)
			prioritet = prioriteti.get(0);

		return prioritet;
	}
}
