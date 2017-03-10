package com.humra.ishod05part01;

import android.content.ContentProviderClient;
import android.database.Cursor;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    private Uri uriRacun = Uri.parse("content://com.ispit.primjer/racun");
    private ContentProviderClient clientRacun = getContentResolver().acquireContentProviderClient(uriRacun);

    private Uri uriStavka = Uri.parse("content:://com.ispit.primjer/stavka");
    private ContentProviderClient clientStavka = getContentResolver().acquireContentProviderClient(uriStavka);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        doTheThing();
    }

    private void doTheThing() {
        try {
            StringBuilder sb = new StringBuilder();

            Cursor cursorRacun = clientRacun.query(uriRacun, new String[] {"ID", "Broj"}, null, null, null);
            Cursor cursorStavka = clientStavka.query(uriStavka, new String[] {"Cijena", "RacunID"}, null, null, null);

            cursorRacun.moveToFirst();

            do {
                sb.append(cursorRacun.getString(1));
                sb.append(" - ");

                cursorStavka.moveToFirst();

                do {
                    String tempId = cursorStavka.getString(1);
                    if(tempId.equals(cursorRacun.getString(1))) {
                        sb.append(cursorStavka.getString(0));
                        sb.append(" ");
                    }
                }while(cursorStavka.moveToNext());

                sb.append("/r/n");

            }while(cursorRacun.moveToNext());

            ispisiPodatke(sb.toString());
        }
        catch(Exception ex) {
            ex.printStackTrace();
        }
    }

    private void ispisiPodatke(String podaci) {
        //TO-DO
    }


}
