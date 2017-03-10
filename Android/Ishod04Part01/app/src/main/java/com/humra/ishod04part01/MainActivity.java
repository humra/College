package com.humra.ishod04part01;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    BazaHelper db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        db = new BazaHelper(this, "djelatnik.db", null, 1);
        db.pripremiPodatke();

        this.povecajPlacu();
    }

    private void povecajPlacu() {
        ArrayList<Djelatnik> djelatnici = db.getAllDjelatnik();

        int count = 0;

        for(Djelatnik d : djelatnici) {
            if(checkForRaise(d.getDatumRodjenja())) {
                d.setIznosPlace(d.getIznosPlace() + 300);
                count++;
            }
        }

        ispisiBrojIzmijena(count);
    }

    private void ispisiBrojIzmijena(int count) {
        TextView view = (TextView)findViewById(R.id.broj_azuriranih);

        view.setText("Broj izmijenjenih unosa: " + Integer.toString(count));
    }

    private boolean checkForRaise(String datumRodjenja) {
        String[] datumDijeovi = datumRodjenja.split("_");

        int dan = Integer.valueOf(datumDijeovi[0]);
        int mjesec = Integer.valueOf(datumDijeovi[1]);
        int godina = Integer.valueOf(datumDijeovi[2]);

        if(godina > 1990) {
            return true;
        }
        if(godina == 1990) {
            if(mjesec > 1) {
                return true;
            }
            if(mjesec == 1 && dan > 1) {
                return true;
            }
        }

        return false;
    }
}
