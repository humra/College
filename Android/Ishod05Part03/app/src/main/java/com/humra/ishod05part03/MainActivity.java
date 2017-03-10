package com.humra.ishod05part03;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void izracunaj(View view) {
        Intent serviceIntent = new Intent(this, FibonacciService.class);
        EditText et = (EditText)findViewById(R.id.unos);
        int broj = Integer.parseInt(et.getText().toString());
        serviceIntent.putExtra("BROJ", broj);

        startService(serviceIntent);
    }
}
