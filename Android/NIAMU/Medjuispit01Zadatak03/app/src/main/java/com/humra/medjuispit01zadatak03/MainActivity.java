package com.humra.medjuispit01zadatak03;

import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.ImageView;

public class MainActivity extends AppCompatActivity {

    Button myButton;
    ImageView myImage;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        myButton = (Button)findViewById(R.id.myButton);
        myImage = (ImageView)findViewById(R.id.myImage);

        myButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Animation anim = AnimationUtils.loadAnimation(MainActivity.this, R.anim.image_animation);
                myImage.startAnimation(anim);
                myButton.setEnabled(false);
                myButton.setVisibility(View.INVISIBLE);

                Handler h = new Handler();
                h.postDelayed(new Runnable() {
                    public void run() {
                        myButton.setEnabled(true);
                        myButton.setVisibility(View.VISIBLE);
                    }
                }, 10000);
            }
        });
    }
}
