package com.vjezba.todolist.baza;

import com.vjezba.todolist.R;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteDatabase.CursorFactory;
import android.database.sqlite.SQLiteOpenHelper;

public class ZadaciOpenHelper extends SQLiteOpenHelper {

	Context context;
	public ZadaciOpenHelper(Context context, String name,
			CursorFactory factory, int version) {
		super(context, name, factory, version);
		this.context = context;
	}

	@Override
	public void onCreate(SQLiteDatabase db) {
		db.execSQL(this.context.getResources().getString(R.string.kreiranje_prioritet));
		db.execSQL(this.context.getResources().getString(R.string.kreiranje_podsjetnik));
		db.execSQL(this.context.getResources().getString(R.string.kreiranje_kategorija));
		db.execSQL(this.context.getResources().getString(R.string.kreiranje_zadatak));
		
		this.pripremiPodatke(db);
	}
	
	@Override
	public void onConfigure(SQLiteDatabase db) {
		db.setForeignKeyConstraintsEnabled(true);
		super.onConfigure(db);
		
	}
	
	private void pripremiPodatke (SQLiteDatabase db)
	{
		db.execSQL("INSERT INTO Prioritet (ID, Naziv) VALUES (1, 'Nizak')");
		db.execSQL("INSERT INTO Prioritet (ID, Naziv) VALUES (2, 'Srednji')");
		db.execSQL("INSERT INTO Prioritet (ID, Naziv) VALUES (3, 'Visok')");
		
		db.execSQL("INSERT INTO Podsjetnik (ID, Naziv) VALUES (1, 'Bez podsjetnika')");
		db.execSQL("INSERT INTO Podsjetnik (ID, Naziv) VALUES (2, 'Obavijest')");
		db.execSQL("INSERT INTO Podsjetnik (ID, Naziv) VALUES (3, 'E-mail')");
		db.execSQL("INSERT INTO Podsjetnik (ID, Naziv) VALUES (4, 'SMS')");
		
		db.execSQL("INSERT INTO Kategorija (Naziv, BrisanjeMoguce) VALUES ('Općenito', 0)");
		db.execSQL("INSERT INTO Kategorija (Naziv, BrisanjeMoguce) VALUES ('Rođendan', 0)");
		db.execSQL("INSERT INTO Kategorija (Naziv, BrisanjeMoguce) VALUES ('Sastanak', 0)");
	}

	@Override
	public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
		db.execSQL("DROP TABLE IF EXISTS Zadatak");
		db.execSQL("DROP TABLE IF EXISTS Kategorija");
		db.execSQL("DROP TABLE IF EXISTS Podsjetnik");
		db.execSQL("DROP TABLE IF EXISTS Prioritet");
		this.onCreate(db);
	}

}
