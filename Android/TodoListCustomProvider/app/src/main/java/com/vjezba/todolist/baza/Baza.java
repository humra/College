package com.vjezba.todolist.baza;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

public class Baza {
	public static final int TRENUTNA_VERZIJA = 2;
	ZadaciOpenHelper openHelper;
	
	public Baza (Context context)
	{
		this.openHelper = new ZadaciOpenHelper(context, "zadaci.db", null, TRENUTNA_VERZIJA);
	}
	
	public SQLiteDatabase vratiBazu ()
	{
		return this.openHelper.getWritableDatabase();
	}
}
