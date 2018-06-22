package com.humra.niamu_projekt;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import com.humra.niamu_projekt.ChampsAdapter;
import com.humra.niamu_projekt.Champion;
import com.humra.niamu_projekt.Role;
import com.humra.niamu_projekt.ApiClient;
import com.humra.niamu_projekt.ApiInterface;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MainActivity extends AppCompatActivity {

    Button btnPost;
    RecyclerView recyclerView;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnPost = (Button) findViewById(R.id.btnPost);
        btnPost.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(view.getContext(), CreateActivity.class);
                view.getContext().startActivity(intent);
            }
        });


        recyclerView = (RecyclerView) findViewById(R.id.recylcler_champs);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        getChamps();


    }
    private void getChamps(){
        final ApiInterface apiService = ApiClient.getClient().create(ApiInterface.class);
        Call<List<Champion>> call = apiService.getChampions();
        call.enqueue(new Callback<List<Champion>>() {
            @Override
            public void onResponse(Call<List<Champion>> call, Response<List<Champion>> response) {
                List<Champion> champList = response.body();
                getRoles(champList,recyclerView,apiService);
            }

            @Override
            public void onFailure(Call<List<Champion>> call, Throwable t) {
                Toast.makeText(MainActivity.this,"Error",Toast.LENGTH_SHORT).show();
            }
        });
    }
    private void getRoles(final List<Champion> champList, final RecyclerView recyclerView, ApiInterface apiService){
        Call<List<Role>> roleList = apiService.getRoles();
        roleList.enqueue(new Callback<List<Role>>() {
            @Override
            public void onResponse(Call<List<Role>> call, Response<List<Role>> response) {
                List<Role> roles = response.body();
                Map<Integer,String> roleMap = new HashMap<Integer, String>();
                for (Role r:roles) {
                    roleMap.put(r.getId(),r.getName());
                }
                recyclerView.setAdapter(new ChampsAdapter(champList,R.layout.champs_layout,getApplicationContext(),roleMap));
            }

            @Override
            public void onFailure(Call<List<Role>> call, Throwable t) {
                Toast.makeText(MainActivity.this,"Error",Toast.LENGTH_SHORT).show();
            }
        });
    }
}
