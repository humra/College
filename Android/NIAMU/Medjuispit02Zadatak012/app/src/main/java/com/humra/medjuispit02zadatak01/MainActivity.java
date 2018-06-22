package com.humra.medjuispit02zadatak01;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    RecyclerView rvStavka;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        rvStavka = (RecyclerView)findViewById(R.id.rvStavke);

        rvStavka.setLayoutManager(new LinearLayoutManager(this));

        List<Stavka> stavke = new ArrayList<>();
        stavke.add(new Stavka("Miro", "Miric", "Programiranje", 4));
        stavke.add(new Stavka("Ana", "Anic", "Baze podatka", 4));
        stavke.add(new Stavka("Pero", "Pero", "Android", 4));

        rvStavka.setAdapter(new StavkaAdapter(stavke));
    }
}
