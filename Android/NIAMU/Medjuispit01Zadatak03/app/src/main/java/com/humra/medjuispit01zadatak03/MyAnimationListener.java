package com.humra.medjuispit01zadatak03;

import android.view.animation.Animation;
import android.widget.Button;


public class MyAnimationListener implements Animation.AnimationListener {

    Button button;

    @Override
    public void onAnimationStart(Animation animation) {
        button.setEnabled(false);
    }

    @Override
    public void onAnimationEnd(Animation animation) {
        button.setEnabled(true);
    }

    @Override
    public void onAnimationRepeat(Animation animation) {

    }

    public MyAnimationListener(Button button) {
        this.button = button;
    }
}
