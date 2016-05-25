package com.humra.todolist;

import android.content.Context;
import android.content.res.Resources;
import android.graphics.drawable.Drawable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.List;

/**
 * Created by Matija on 25.5.2016..
 */
public class ZadaciAdapter extends ArrayAdapter<Zadatak> {
    private LayoutInflater inflater;

    public ZadaciAdapter(Context context, int textViewResourceId, ListZadatak objects) {
        super(context, textViewResourceId, objects);
        this.inflater = LayoutInflater.from(context);
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        final Zadatak zadatak = this.getItem(position);

        if(convertView == null) {
            convertView = this.inflater.inflate(R.layout.zadatak, null);
        }

        Context context = this.inflater.getContext();

        TextView tvTekst = (TextView) convertView.findViewById(R.id.tvTekst);
        ImageView ivZavrsen = (ImageView) convertView.findViewById(R.id.ivZavrsen);

        tvTekst.setText(zadatak.getTekst());

        Drawable slika = context.getResources().getDrawable(R.drawable.nezavrsen);
        if(zadatak.getZavrsen()) {
            slika = context.getResources().getDrawable(R.drawable.zavrsen);
        }

        ivZavrsen.setImageDrawable(slika);

        ivZavrsen.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                zadatak.setZavrsen(!zadatak.getZavrsen());
                notifyDataSetChanged();
            }
        });

        return convertView;
    }
}
