package com.humra.niamu_projekt;

import android.content.Context;
import android.content.Intent;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import java.util.List;
import java.util.Map;

import com.humra.niamu_projekt.CreateActivity;
import com.humra.niamu_projekt.MainActivity;
import com.humra.niamu_projekt.R;
import com.humra.niamu_projekt.UpdateChampActivity;
import com.humra.niamu_projekt.DownloadImageTask;
import com.humra.niamu_projekt.Champion;
import com.humra.niamu_projekt.ApiClient;
import com.humra.niamu_projekt.ApiInterface;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;


public class ChampsAdapter extends RecyclerView.Adapter<ChampsAdapter.ChampsViewHolder> {

    private List<Champion> champions;
    private int rowLayout;
    private Context context;
    private Map<Integer,String> roleMap;

    public static class ChampsViewHolder extends RecyclerView.ViewHolder {
        LinearLayout champsLayout;
        TextView champName;
        TextView champBio;
        TextView champRole;
        ImageView champImage;
        Button btnUpdate;
        Button btnDelete;

        public ChampsViewHolder(View v) {
            super(v);
            champsLayout = (LinearLayout) v.findViewById(R.id.champions_layout);
            champName = (TextView) v.findViewById(R.id.champ_name);
            champBio = (TextView) v.findViewById(R.id.champ_bio);
            champRole = (TextView) v.findViewById(R.id.champ_role);
            champImage = (ImageView) v.findViewById(R.id.champ_image);
            btnUpdate = (Button) v.findViewById(R.id.btnUpdate);
            btnDelete = (Button)v.findViewById(R.id.btnDelete);
        }
    }
    public ChampsAdapter(List<Champion> champions, int rowLayout, Context context, Map<Integer,String> roleMap) {
        this.champions = champions;
        this.rowLayout = rowLayout;
        this.context = context;
        this.roleMap= roleMap;
    }

    @Override
    public ChampsAdapter.ChampsViewHolder onCreateViewHolder(ViewGroup parent,
                                                             int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(rowLayout, parent, false);
        return new ChampsViewHolder(view);
    }


    @Override
    public void onBindViewHolder(final ChampsViewHolder holder, final int position) {
        holder.champName.setText(champions.get(position).getName());
        holder.champBio.setText(champions.get(position).getBio());
        holder.champRole.setText(roleMap.get(champions.get(position).getRole()));
        new DownloadImageTask(holder.champImage).execute(champions.get(position).getImageUrl());
        holder.btnUpdate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(view.getContext(), UpdateChampActivity.class);
                intent.putExtra("Name",holder.champName.getText().toString());
                intent.putExtra("Bio",holder.champBio.getText().toString());
                intent.putExtra("Image",champions.get(position).getImageUrl());
                intent.putExtra("Role",champions.get(position).getRole());
                intent.putExtra("ID",champions.get(position).getId());
                view.getContext().startActivity(intent);
            }
        });
        holder.btnDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                deleteChamp(view.getContext(),champions.get(position).getId().toString());
            }
        });
    }
    private void deleteChamp(final Context ctx, String id) {
        ApiInterface apiService = ApiClient.getClient().create(ApiInterface.class);
        Call<Champion> call = apiService.deleteChamp(id);
        call.enqueue(new Callback<Champion>() {
            @Override
            public void onResponse(Call<Champion> call, Response<Champion> response) {
                Intent intent = new Intent(ctx, MainActivity.class);
                ctx.startActivity(intent);
            }
            @Override
            public void onFailure(Call<Champion> call, Throwable t) {
                Toast.makeText(ctx,"Error",Toast.LENGTH_SHORT).show();
            }
        });
    }
    @Override
    public int getItemCount() {
        return champions.size();
    }
}
