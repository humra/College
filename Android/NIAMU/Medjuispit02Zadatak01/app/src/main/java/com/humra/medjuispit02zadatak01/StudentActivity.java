package com.humra.medjuispit02zadatak01;

import android.os.Bundle;

import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;

public class StudentActivity extends AppCompatActivity{

    EditText txtIme;
    EditText txtPrezime;
    Spinner spnMjesta;
    Button btnDodaj;

    DaoSession session;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_student);

        this.txtIme = (EditText)findViewById(R.id.txtIme);
        this.txtPrezime = (EditText)findViewById(R.id.txtPrezime);
        this.spnMjesta = (Spinner)findViewById(R.id.spnMjesto);
        this.btnDodaj = (Button)findViewById(R.id.btnDodaj);

        session = DaoMaster.newDevSession(this, "baza.db");

        prikaziMjesta();

        btnDodaj.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Student s = new Student();
                s.setIme(txtIme.getText().toString());
                s.setPrezime(txtPrezime.getText().toString());
                s.setMjesto((Mjesto)spnMjesta.getSelectedItem());
                session.getStudentDao().insert(s);
                finish();
            }
        });
    }

    private void prikaziMjesta() {
        MjestoDao mjestoDao = session.getMjestoDao();

        if(mjestoDao.count() == 0) {
            mjestoDao.insert(new Mjesto(1l, "Zagreb"));
            mjestoDao.insert(new Mjesto(2l, "Rijeka"));
            mjestoDao.insert(new Mjesto(3l, "Split"));
        }

        spnMjesta.setAdapter(new ArrayAdapter(this, android.R.layout.simple_spinner_item, mjestoDao.loadAll()));
    }
}
