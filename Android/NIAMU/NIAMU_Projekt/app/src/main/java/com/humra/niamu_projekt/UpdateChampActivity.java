package com.humra.niamu_projekt;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import com.humra.niamu_projekt.Champion;
import com.humra.niamu_projekt.ApiClient;
import com.humra.niamu_projekt.ApiInterface;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class UpdateChampActivity extends Activity{

    Button btnPost;
    Button btnBack;
    EditText txtName;
    EditText txtRole;
    EditText txtBio;
    EditText ImageUrl;
    private Integer champId;
    final ApiInterface apiService = ApiClient.getClient().create(ApiInterface.class);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.new_champ);
        btnBack = (Button) findViewById(R.id.btnBack);
        btnPost = (Button) findViewById(R.id.btnSubmit);
        txtName = (EditText) findViewById(R.id.txtName);
        txtRole = (EditText) findViewById(R.id.txtRole);
        txtBio = (EditText) findViewById(R.id.txtBio);
        ImageUrl = (EditText) findViewById(R.id.txtImage);

        Intent intent = getIntent();
        String name = intent.getStringExtra("Name");
        String bio = intent.getStringExtra("Bio");
        String url = intent.getStringExtra("Image");
        Integer role = intent.getIntExtra("Role",1);
        champId = intent.getIntExtra("ID",0);

        btnPost.setText("Update");
        txtName.setText(name);
        txtRole.setText(role.toString());
        txtBio.setText(bio);
        ImageUrl.setText(url);

        btnPost.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                updateChamp(champId.toString());
            }
        });
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(view.getContext(), MainActivity.class);
                view.getContext().startActivity(intent);
            }
        });
    }

    private void updateChamp(String id){
        if(!txtName.getText().toString().isEmpty() && !txtRole.getText().toString().isEmpty() && champId!=0 ){
            Integer roleNumber = Integer.parseInt(txtRole.getText().toString());
            Champion champ = new Champion(txtName.getText().toString(),champId, ImageUrl.getText().toString(),txtBio.getText().toString(), roleNumber);
            Call<Champion> call = apiService.updateChamp(id,champ);
            call.enqueue(new Callback<Champion>() {
                @Override
                public void onResponse(Call<Champion> call, Response<Champion> response) {
                    Toast.makeText(UpdateChampActivity.this,"Champ updated!",Toast.LENGTH_SHORT).show();
                }

                @Override
                public void onFailure(Call<Champion> call, Throwable t) {
                    Toast.makeText(UpdateChampActivity.this,"Error updating champ :(",Toast.LENGTH_SHORT).show();
                }
            });
        }
        else
        {
            Toast.makeText(UpdateChampActivity.this,"Please enter Name and Role.",Toast.LENGTH_SHORT).show();
        }
    }
}
