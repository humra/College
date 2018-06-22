package com.humra.medjuispit02zadatak01;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import java.util.List;


public class StavkaAdapter extends RecyclerView.Adapter<StavkaViewHolder> {

    private final List<Stavka> stavke;

    public StavkaAdapter(List<Stavka> stavke) {
        this.stavke = stavke;
    }

    @Override
    public StavkaViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View root = LayoutInflater.from(parent.getContext()).inflate(R.layout.stavka_layout, parent, false);

        return new StavkaViewHolder(root);
    }

    @Override
    public void onBindViewHolder(StavkaViewHolder holder, int position) {
        Stavka stavka = stavke.get(position);

        holder.tvStudent.setText(stavka.getPrezimeStudenta() + ", " + stavka.getImeStudenta());
        holder.tvOcjena.setText(stavka.getOcjenaNaIspitu());
        holder.tvPredmet.setText(stavka.getNazivPredmeta());
    }

    @Override
    public int getItemCount() {
        return stavke.size();
    }
}
