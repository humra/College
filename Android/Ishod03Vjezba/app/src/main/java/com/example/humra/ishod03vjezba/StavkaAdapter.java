package com.example.humra.ishod03vjezba;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

public class StavkaAdapter extends ArrayAdapter<Stavka> {

    int layoutResourceId;
    Context mContext;
    Stavka data[] = null;

    public StavkaAdapter(Context context, int resource, Stavka[] objects) {
        super(context, resource, objects);

        this.layoutResourceId = resource;
        this.mContext = context;
        this.data = objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        if(convertView == null) {
            LayoutInflater layoutInflater = ((Activity) mContext).getLayoutInflater();
            convertView = layoutInflater.inflate(layoutResourceId, parent, false);
        }

        Stavka stavka = data[position];

        TextView imePrezime = (TextView)convertView.findViewById(R.id.ime_prezime);
        imePrezime.setText(stavka.getImeStudenta() + " " + stavka.getPrezimeStudenta());

        TextView predmet = (TextView)convertView.findViewById(R.id.naziv_premeta);
        predmet.setText(stavka.getNazivPredmeta());

        TextView ocjena = (TextView)convertView.findViewById(R.id.ocjena);
        ocjena.setText(Integer.toString(stavka.getOcjenaNaIspitu()));

        return convertView;
    }
}
