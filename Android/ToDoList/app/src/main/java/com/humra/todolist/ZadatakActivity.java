package com.humra.todolist;

import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.view.KeyEvent;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import java.util.List;

/**
 * Created by Matija on 25.5.2016..
 */
public class ZadatakActivity extends android.support.v7.app.AppCompatActivity {

    private EditText etTekst;
    private Button btnDodaj;
    private ListView lvZadaci;
    private ZadaciAdapter adapter;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.main);

        etTekst = (EditText) findViewById(R.id.etTekst);
        btnDodaj = (Button) findViewById(R.id.btnDodaj);
        lvZadaci = (ListView) findViewById(R.id.lvZadaci);
        adapter = new ZadaciAdapter(this, R.layout.zadatak, new ListZadatak());
        this.lvZadaci.setAdapter(adapter);

        btnDodaj.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                dodajZadatak();
            }
        });

        etTekst.setOnKeyListener(new View.OnKeyListener() {
            @Override
            public boolean onKey(View v, int keyCode, KeyEvent event) {
                if(event.getAction() == KeyEvent.ACTION_DOWN && keyCode == KeyEvent.KEYCODE_ENTER) {
                    dodajZadatak();
                    return true;
                }
                else {
                    return false;
                }
            }
        });
    }

    private Boolean dodajZadatak() {
        if(etTekst.getText().length() <= 0) {
            return false;
        }
        else {
            this.adapter.add(new Zadatak(etTekst.getText().toString(), false));
            this.etTekst.setText("");
            return true;
        }
    }
}
