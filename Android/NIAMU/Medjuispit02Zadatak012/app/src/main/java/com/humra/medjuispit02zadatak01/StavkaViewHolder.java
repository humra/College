package com.humra.medjuispit02zadatak01;

import android.support.v7.widget.RecyclerView;
import android.view.View;
import android.widget.TextView;

public class StavkaViewHolder extends RecyclerView.ViewHolder {

    TextView tvStudent, tvPredmet, tvOcjena;

    public StavkaViewHolder(View itemView) {
        super(itemView);

        tvStudent = (TextView)itemView.findViewById(R.id.txtStudent);
        tvPredmet = (TextView)itemView.findViewById(R.id.txtPredmet);
        tvOcjena = (TextView)itemView.findViewById(R.id.txtOcjena);
    }
}
