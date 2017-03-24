package test.vjezbe.bmikalkulator;

import android.app.Activity;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.os.Bundle;

import test.vjezbe.bmikalkulator.fragmenti.RezultatFragment;
import test.vjezbe.bmikalkulator.fragmenti.UnosFragment;

public class MainActivity extends Activity implements IRezultat {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        FragmentManager fm = this.getFragmentManager();

        FragmentTransaction transakcija = fm.beginTransaction();
        transakcija.add(R.id.fragmenti, new UnosFragment(), UnosFragment.TAG);

        transakcija.commit();
    }

    public void prikaziRezultat(double rezultat) {

        FragmentManager fm = this.getFragmentManager();
        fm.popBackStack(null, FragmentManager.POP_BACK_STACK_INCLUSIVE);

        FragmentTransaction transakcija = fm.beginTransaction();
        transakcija.replace(R.id.fragmenti, new RezultatFragment(rezultat), RezultatFragment.TAG).addToBackStack("Unos");
        transakcija.commit();
    }
}
