package com.humra.vjezbe01zadatak02;

import android.content.Context;
import android.graphics.drawable.Drawable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;

import java.io.InputStream;


public class ImageAdapter extends BaseAdapter {

    private final Context context;
    private final String[] images;

    public ImageAdapter(Context context, String[] images) {
        this.context = context;
        this.images = images;
    }

    @Override
    public int getCount() {
        return images.length;
    }

    @Override
    public Object getItem(int position) {
        return null;
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        final String assetLocation = images[position];

        if(convertView == null) {
            final LayoutInflater layoutInflater = LayoutInflater.from(context);
            convertView = layoutInflater.inflate(R.layout.memory_image_layout, null);
        }

        final ImageView tempImage = (ImageView)convertView.findViewById(R.id.ivImage);

        try {
            InputStream in = context.getAssets().open("img/" + images[position]);
            Drawable tempDrawable = Drawable.createFromStream(in, null);
            tempImage.setImageDrawable(tempDrawable);
        }
        catch(Exception ex) {
            ex.printStackTrace();
        }

        return convertView;
    }
}
