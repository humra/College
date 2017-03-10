package com.example.humra.ishod02vjezba;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        CustomView customView = new CustomView(this);
        customView.setValues(2, 1.0f);
        setContentView(customView);
    }
}
