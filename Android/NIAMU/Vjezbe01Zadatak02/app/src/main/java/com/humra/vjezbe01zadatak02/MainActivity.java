package com.humra.vjezbe01zadatak02;

import android.content.res.AssetManager;
import android.content.res.Resources;
import android.graphics.drawable.Drawable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.GridView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        GridView gridView = (GridView)findViewById(R.id.gvMainView);
        ImageAdapter imageAdapter = new ImageAdapter(this, findImages());
        gridView.setAdapter(imageAdapter);

        gridView.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                flipCard();
            }
        });
    }

    private void flipCard() {

    }

    private String[] findImages() {
        try {
            AssetManager manager = getApplicationContext().getAssets();
            String[] images = manager.list("img");
            return images;
        }
        catch(Exception ex) {
            ex.printStackTrace();
        }

        return null;
    }


}
