package com.humra.medjuispit02zadatak01;

import android.content.Intent;
import android.content.pm.PackageInstaller;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    Button btnDodaj;
    TextView txtStudenti;

    DaoSession session;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        this.btnDodaj = (Button)findViewById(R.id.btnNovi);
        this.txtStudenti = (TextView)findViewById(R.id.txtStudenti);

        session = DaoMaster.newDevSession(this, "baza.db");

        this.btnDodaj.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(MainActivity.this, StudentActivity.class));
            }
        });
    }

    @Override
    protected void onResume() {
        super.onResume();
        prikaziPodatke();
    }

    private void prikaziPodatke() {
        List<Student> studenti = session.getStudentDao().loadAll();

        StringBuilder sb = new StringBuilder();

        for(Student s : studenti) {
            sb.append(s.toString());
            sb.append(" ");
            sb.append(s.getMjesto().getNaziv());
            sb.append("\r\n");
        }

        txtStudenti.setText(sb.toString());
    }
}
