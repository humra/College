package com.example.humra.ishod04vjezba;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by Matija on 19/08/2016.
 */
public class MjestoHelper extends SQLiteOpenHelper {

    private Context context;

    public MjestoHelper(Context context, String name, SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
        this.context = context;
    }

    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase) {
        sqLiteDatabase.execSQL(context.getString(R.string.MJESTO_CREATE));

        this.pripremiPodatke(sqLiteDatabase);
    }

    private void pripremiPodatke(SQLiteDatabase db) {
        db.execSQL("INSERT INTO Mjesto (Naziv, BrojStanovnika, ZupanijaID) VALUES ('Velika Gorica', 25000, 1)");
        db.execSQL("INSERT INTO Mjesto (Naziv, BrojStanovnika, ZupanijaID) VALUES ('Rijeka', 25000, 2)");
        db.execSQL("INSERT INTO Mjesto (Naziv, BrojStanovnika, ZupanijaID) VALUES ('Osijek', 25000, 3)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {
        sqLiteDatabase.execSQL("DROP TABLE IF EXISTS Mjesto");
    }

    @Override
    public void onConfigure(SQLiteDatabase db) {
        db.setForeignKeyConstraintsEnabled(true);
        super.onConfigure(db);
    }
}
