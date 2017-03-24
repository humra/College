package com.example.humra.ishod02vjezba;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.view.View;

/**
 * Created by Matija on 14/06/2016.
 */
public class CustomView extends View {

    private Paint paint;
    private int filledCircles;
    private float transparency;

    public CustomView(Context context) {
        super(context);

        paint = new Paint();
        paint.setColor(Color.BLUE);
    }

    public void setValues(int numberOfFullCircles, float transparancy) {
        this.filledCircles = numberOfFullCircles;
        this.transparency = transparancy;
    }

    @Override
    protected void onDraw(Canvas canvas) {
        this.setAlpha(transparency);

        canvas.drawColor(Color.WHITE);

        if(filledCircles == 0) {
            paint.setStyle(Paint.Style.STROKE);
        }
        canvas.drawCircle(200, 200, 100, paint);

        if(filledCircles == 1) {
            paint.setStyle(Paint.Style.STROKE);
        }
        canvas.drawCircle(375, 200, 75, paint);

        if(filledCircles == 2) {
            paint.setStyle(Paint.Style.STROKE);
        }
        canvas.drawCircle(500, 200, 50, paint);
    }
}
