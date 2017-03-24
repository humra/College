package com.humra.ishod05part02;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import java.util.Random;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void theThing(View view) {
        Random r = new Random(6427);
        Intent intent = null;
        int random = r.nextInt(3);

        switch(random) {
            case 0:
                intent = new Intent(this, aktivnostA.class);
                break;
            case 1:
                intent = new Intent(this, aktivnostB.class);
                break;
            case 2:
                intent = new Intent(this, aktivnostC.class);
                break;
            default:
                break;
        }

        startActivityForResult(intent, 1);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        if(resultCode == Activity.RESULT_OK) {
            String podaci = data.getStringExtra("PODACI");
            TextView tv = (TextView)findViewById(R.id.pozvana_aktivnost);
            tv.setText(podaci);
        }
    }
}
