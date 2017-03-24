package com.example.humra.ishod04vjezba;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

/**
 * Created by Matija on 19/08/2016.
 */
public class Baza {

    public static final int CURRENT_VERSION = 1;

    private SQLiteDatabase db;
    MjestoHelper mjestoHelper;

    public Baza(Context context) {
        this.mjestoHelper = new MjestoHelper(context, "baza_mjesto.db", null, CURRENT_VERSION);
    }

    public SQLiteDatabase vratiBazu() {
        return this.mjestoHelper.getWritableDatabase();
    }
}
