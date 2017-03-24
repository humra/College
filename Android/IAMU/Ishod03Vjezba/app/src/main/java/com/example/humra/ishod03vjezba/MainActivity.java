package com.example.humra.ishod03vjezba;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ListView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Stavka[] data = new Stavka[5];

        data[0] = new Stavka("Pero", "Peric", "Predmet1", 4);
        data[1] = new Stavka("Ivo", "Ivic", "Predmet2", 3);
        data[2] = new Stavka("Ana", "Anic", "Predmet3", 5);
        data[3] = new Stavka("Maja", "Majic", "Predmet4", 4);
        data[4] = new Stavka("Jura", "Juric", "Predmet5", 2);

        StavkaAdapter adapter = new StavkaAdapter(this, R.layout.student_layout, data);

        ListView lista = (ListView)findViewById(R.id.lista);
        lista.setAdapter(adapter);

    }
}
