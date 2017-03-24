package com.humra.ruler;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.util.AttributeSet;
import android.util.DisplayMetrics;
import android.view.View;

/**
 * Created by Matija on 1.4.2016..
 */
public class RavnaloKontrola extends View {

    int width;
    float duljinaMilimetra;
    int duljinaMilimetraInt;

    Paint paint = new Paint();

    public RavnaloKontrola(Context context) {
        super(context);
        paint.setColor(Color.BLACK);
    }

    public RavnaloKontrola(Context context, AttributeSet aSet) {
        super(context, aSet);
    }

    @Override
    public void onSizeChanged(int w, int h, int oldW, int oldH) {
        width = w;

        DisplayMetrics dm = getResources().getDisplayMetrics();
        duljinaMilimetra = (float) (1.0f * dm.xdpi / 25.4);
        duljinaMilimetraInt = Math.round(duljinaMilimetra);

        if (duljinaMilimetraInt == 0) {
            duljinaMilimetraInt = 1;
        }
    }

    @Override
    public void onDraw(Canvas canvas) {
        super.onDraw(canvas);

        int duljinaCentimetraInt = duljinaMilimetraInt * 10;

        canvas.drawLine(0, 40, width, 40, paint);
        int broj = 0;

        for (int i = 0; i <= width; i++) {
            if (i % duljinaMilimetraInt == 0) {
                canvas.drawLine(i, 37, i, 43, paint);
            }
            if (i % (duljinaMilimetraInt * 5) == 0) {
                canvas.drawLine(i, 34, i, 46, paint);
            }
            if (i % duljinaCentimetraInt == 0) {
                canvas.drawLine(i, 30, i, 50, paint);
                canvas.drawText(Integer.toString(broj), i - 2, 62, paint);
                broj++;
            }
        }

    }
}
