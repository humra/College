package test.vjezbe.bmikalkulator.fragmenti;

/**
 * Created by Matija on 18/04/2016.
 */

import android.app.Activity;
import android.app.Fragment;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;

import test.vjezbe.bmikalkulator.IRezultat;
import test.vjezbe.bmikalkulator.R;

public class UnosFragment extends Fragment {
    public static final String TAG = "Unos";

    EditText etTezina;
    EditText etVisina;
    Button btnIzracunaj;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

    }

    IRezultat iRezultat;
    @Override
    public void onAttach(Activity activity) {
        super.onAttach(activity);
        this.iRezultat = (IRezultat) activity;
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState)
    {
        View view = inflater.inflate(R.layout.unos, container, false);

        this.etTezina = (EditText) view.findViewById(R.id.etTezina);
        this.etVisina = (EditText) view.findViewById(R.id.etVisina);
        this.btnIzracunaj = (Button) view.findViewById(R.id.btnIzracunaj);


        this.btnIzracunaj.setOnClickListener(new OnClickListener() {

            @Override
            public void onClick(View v) {

                double tezina = -1;
                double visina = -1;
                try
                {
                    tezina = Double.parseDouble(etTezina.getText().toString());
                }
                catch (Exception ex) {}

                try
                {
                    visina = Double.parseDouble(etVisina.getText().toString());
                }
                catch (Exception ex) {}

                double bmi = izracunajBMI(tezina, visina);
                iRezultat.prikaziRezultat(bmi);
            }

        });



        return view;
    }

    private double izracunajBMI (double tezina, double visina)
    {
        if (tezina <= 0 || visina <= 0)
            return -1;

        // visina je unesena u centimetrima, pretvorba u metre
        if (visina >= 3)
            visina = visina / 100;

        return tezina / (visina * visina);
    }


}
