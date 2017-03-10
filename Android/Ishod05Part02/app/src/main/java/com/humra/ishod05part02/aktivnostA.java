package com.humra.ishod05part02;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class aktivnostA extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_aktivnost);
    }

    public void natrag(View view) {
        Intent resultIntent = new Intent();
        resultIntent.putExtra("PODACI", "aktivnostA");
        setResult(Activity.RESULT_OK, resultIntent);
        finish();
    }
}
