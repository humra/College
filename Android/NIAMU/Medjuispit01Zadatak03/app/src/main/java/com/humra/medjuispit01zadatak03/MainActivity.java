package com.humra.medjuispit01zadatak03;

import android.media.Image;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.LinearInterpolator;
import android.view.animation.RotateAnimation;
import android.view.animation.TranslateAnimation;
import android.widget.Button;
import android.widget.ImageView;

public class MainActivity extends AppCompatActivity {

    Button myButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        myButton = (Button)findViewById(R.id.btnPokreni);

        myButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                TranslateAnimation anim = new TranslateAnimation(0, 800, 0f, -1300f);
                anim.setDuration(10000);
                anim.setFillAfter(true);
                anim.setAnimationListener(new MyAnimationListener(myButton));

                ImageView image = (ImageView)findViewById(R.id.ivImage);

                image.startAnimation(anim);
            }
        });
    }
}
