package com.vjezba.todolist.provideri;

import android.content.ContentProvider;
import android.content.ContentUris;
import android.content.ContentValues;
import android.content.UriMatcher;
import android.content.res.TypedArray;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteQueryBuilder;
import android.net.Uri;
import android.widget.Switch;

import com.vjezba.todolist.baza.Baza;
import com.vjezba.todolist.baza.TablicaZadatak;

/**
 * Created by Matija on 19/08/2016.
 */
public class ZadaciProvider extends ContentProvider {

    public static final String AUTHORITY = "com.humra.zadaciprovider";
    public static final Uri CONTENT_URI = Uri.parse("content://" + AUTHORITY + "/zadaci");

    public static final String ID = TablicaZadatak.ID;
    public static final String TEKST = TablicaZadatak.TEKST;
    public static final String DATUM = TablicaZadatak.DATUM;
    public static final String ZAVRSEN = TablicaZadatak.ZAVRSEN;
    public static final String KATEGORIJA_ID = TablicaZadatak.KATEGORIJA_ID;
    public static final String KONTAKT_ID = TablicaZadatak.KONTAKT_ID;
    public static final String PODSJETNIK_ID = TablicaZadatak.PODSJETNIK_ID;
    public static final String PRIORITET_ID = TablicaZadatak.PRIORITET_ID;

    private Baza baza;

    private UriMatcher uriMatcher;
    private static final int ZADACI = 1;
    private static final int ZADACI_ID = 2;

    @Override
    public boolean onCreate() {
        this.baza = new Baza(this.getContext());
        this.uriMatcher = new UriMatcher(UriMatcher.NO_MATCH);
        this.uriMatcher.addURI(AUTHORITY, "zadaci", ZADACI);
        this.uriMatcher.addURI(AUTHORITY, "zadaci/#", ZADACI_ID);
        return true;
    }

    @Override
    public Cursor query(Uri uri, String[] strings, String s, String[] strings1, String s1) {

        SQLiteQueryBuilder builder = new SQLiteQueryBuilder();
        builder.setTables(TablicaZadatak.NAZIV_TABLICE);

        if(this.uriMatcher.match(uri) == ZADACI_ID) {
            String id = uri.getLastPathSegment();
            builder.appendWhere(TablicaZadatak.ID + " = " + id);
        }

        return builder.query(this.baza.vratiBazu(), strings, s, strings1, null, null, s1);
    }

    @Override
    public String getType(Uri uri) {
        switch(this.uriMatcher.match(uri)) {
            case ZADACI:
                return "vnd.android.cursor.dir/vnd.todolist.zadatak";
            case ZADACI_ID:
                return "vnd.android.curor.item/vnd.todolist.zadatak";
        }

        return null;
    }

    @Override
    public Uri insert(Uri uri, ContentValues contentValues) {
        SQLiteDatabase baza = this.baza.vratiBazu();

        long id = baza.insertOrThrow(TablicaZadatak.NAZIV_TABLICE, null, contentValues);

        if(id > 0) {
            return ContentUris.withAppendedId(CONTENT_URI, id);
        }

        return null;
    }

    @Override
    public int delete(Uri uri, String s, String[] strings) {

        SQLiteDatabase db = this.baza.vratiBazu();

        if(this.uriMatcher.match(uri) == ZADACI_ID) {
            String id = uri.getLastPathSegment();
            String where = TablicaZadatak.ID + " = " + id;

            if(s == null) {
                s = where;
            }
            else {
                s = s + " AND (" + where + ")";
            }
        }

        return db.delete(TablicaZadatak.NAZIV_TABLICE, s, strings);
    }

    @Override
    public int update(Uri uri, ContentValues contentValues, String s, String[] strings) {
        SQLiteDatabase db = this.baza.vratiBazu();

        if(this.uriMatcher.match(uri) == ZADACI_ID) {
            String id = uri.getLastPathSegment();
            String where = TablicaZadatak.ID + " = " + id;

            if(s == null) {
                s = where;
            }
            else {
                s = s + " AND (" + where + ")";
            }
        }

        return db.update(TablicaZadatak.NAZIV_TABLICE, contentValues, s, strings);
    }
}
