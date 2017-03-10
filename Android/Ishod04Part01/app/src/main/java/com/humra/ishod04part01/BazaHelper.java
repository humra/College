package com.humra.ishod04part01;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by Matija on 27/08/2016.
 */
public class BazaHelper extends SQLiteOpenHelper {

    Context context;

    private final String DJELATNIK_TABLE = "Djelatnik";

    private final String _ID = "ID";
    private final String _IME = "Ime";
    private final String _PREZIME = "Prezime";
    private final String _DATUM = "DatumRodjenja";
    private final String _PLACA = "IznosPlace";

    private static final String DATABASE_NAME = "djelatnici.db";

    public BazaHelper(Context context, String name, SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
        this.context = context;
    }

    public BazaHelper(Context context) {
        super(context, DATABASE_NAME, null, 1);
    }

    public void pripremiPodatke() {
        SQLiteDatabase db = this.getWritableDatabase();

        db.execSQL("INSERT INTO Djelatnik (Ime, Prezime, DatumRodjenja, IznosPlace) VALUES ('Pero', 'Peric', '01_02_1990', 3500)");
        db.execSQL("INSERT INTO Djelatnik (Ime, Prezime, DatumRodjenja, IznosPlace) VALUES ('Ana', 'Anic', '02_02_1980', 2500)");
        db.execSQL("INSERT INTO Djelatnik (Ime, Prezime, DatumRodjenja, IznosPlace) VALUES ('Ivo', 'Ivic', '03_03_1995', 4000)");
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(context.getString(R.string.tablica_djelatnik_create));
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS Djelatnik");
    }

    @Override
    public void onConfigure(SQLiteDatabase db) {
        db.setForeignKeyConstraintsEnabled(true);
        super.onConfigure(db);
    }

    public long addNewDjelatnik(ContentValues values) throws SQLException {
        SQLiteDatabase db = this.getWritableDatabase();
        long id = db.insert(DJELATNIK_TABLE, null, values);

        return id;
    }

    public int deleteDjelatnik(String id) {
        if(id == null) {
            return getWritableDatabase().delete(DJELATNIK_TABLE, null, null);
        }
        else {
            return getWritableDatabase().delete(DJELATNIK_TABLE, "ID = ?", new String[] {id});
        }
    }

    public int updateDjelatnik(String id, ContentValues cv) {
        if(id == null) {
            return getWritableDatabase().update(DJELATNIK_TABLE, cv, null, null);
        }
        else {
            return getWritableDatabase().update(DJELATNIK_TABLE, cv, "ID = ?", new String[] {id});
        }
    }

    public void insertDjelatnik(Djelatnik djelatnik) {
        SQLiteDatabase db = this.getWritableDatabase();

        ContentValues cv = new ContentValues();
        cv.put(_IME, djelatnik.getIme());
        cv.put(_PREZIME, djelatnik.getPrezime());
        cv.put(_DATUM, djelatnik.getDatumRodjenja());
        cv.put(_PLACA, djelatnik.getIznosPlace());

        db.insert(DJELATNIK_TABLE, null, cv);
        db.close();
    }

    public Djelatnik getDjelatnik(int id) {
        SQLiteDatabase db = this.getReadableDatabase();

        Cursor cursor = db.query(DJELATNIK_TABLE, new String[] {_ID, _IME, _PREZIME, _DATUM, _PLACA}, _ID + "=?", new String [] {String.valueOf(id)}, null, null, null, null);

        Djelatnik djelatnik = new Djelatnik();

        if(cursor != null) {
            cursor.moveToFirst();

            djelatnik = new Djelatnik(Integer.parseInt(cursor.getString(0)), cursor.getString(1), cursor.getString(2), cursor.getString(3), cursor.getFloat(4));
            return djelatnik;
        }

        return djelatnik;
    }

    public Cursor getDjelatniciCursor(int id, String[] projection, String selection, String[] selectionArgs, String sortOrder) {
        SQLiteDatabase db = this.getReadableDatabase();

        Cursor cursor = db.query(DJELATNIK_TABLE, projection, selection, selectionArgs, null, null, sortOrder);

        return cursor;
    }

    public ArrayList<Djelatnik> getAllDjelatnik() {
        SQLiteDatabase db = this.getReadableDatabase();

        ArrayList<Djelatnik> djelatnici = new ArrayList<>();

        String query = "SELECT * FROM Djelatnik";

        Cursor cursor = db.rawQuery(query, null);

        if(cursor.moveToFirst()) {
            do {
                Djelatnik djelatnik = new Djelatnik();
                djelatnik.setID(Integer.parseInt(cursor.getString(0)));
                djelatnik.setIme(cursor.getString(1));
                djelatnik.setPrezime(cursor.getString(2));
                djelatnik.setDatumRodjenja(cursor.getString(3));
                djelatnik.setIznosPlace(cursor.getFloat(4));

                djelatnici.add(djelatnik);
            }while(cursor.moveToNext());
        }

        return djelatnici;
    }

    public int getCountDjelatnik() {
        SQLiteDatabase db = this.getReadableDatabase();
        String query = "SELECT * FROM Djelatnik";

        Cursor cursor = db.rawQuery(query, null);
        cursor.close();

        return cursor.getCount();
    }

    public int updateDjelatnik(Djelatnik djelatnik) {
        SQLiteDatabase db = this.getWritableDatabase();

        ContentValues cv = new ContentValues();
        cv.put(_ID, djelatnik.getID());
        cv.put(_IME, djelatnik.getIme());
        cv.put(_PREZIME, djelatnik.getPrezime());
        cv.put(_DATUM, djelatnik.getDatumRodjenja());
        cv.put(_PLACA, djelatnik.getIznosPlace());

        return db.update(DJELATNIK_TABLE, cv, _ID + " = ?", new String[] {String.valueOf(djelatnik.getID())});
    }

    public void deleteDjelatnik(Djelatnik djelatnik) {
        SQLiteDatabase db = this.getWritableDatabase();

        db.delete(DJELATNIK_TABLE, _ID + " = ?", new String[] {String.valueOf(djelatnik.getID())});
        db.close();
    }
}
