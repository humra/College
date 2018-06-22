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


public class CreateActivity extends Activity{

    Button btnPost;
    Button btnBack;
    EditText txtName;
    EditText txtRole;
    EditText txtBio;
    EditText ImageUrl;
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
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(view.getContext(),MainActivity.class);
                view.getContext().startActivity(intent);
            }
        });
        btnPost.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                createNewChamp();
            }
        });
    }

    private void createNewChamp(){
        if(!txtName.getText().toString().isEmpty() && !txtRole.getText().toString().isEmpty()){
            Integer roleNumber = Integer.parseInt(txtRole.getText().toString());
            String imgUrl ="http://jps.sugarmapleinteractive.com/wp-content/themes/jps/img/no_image.png";
            if(ImageUrl.getText().length()!=0) {
                imgUrl=ImageUrl.getText().toString();
            }
            Champion champ = new Champion(txtName.getText().toString(),imgUrl,txtBio.getText().toString(), roleNumber);
            Call<Champion> call = apiService.createChamp(champ);
            call.enqueue(new Callback<Champion>() {
                @Override
                public void onResponse(Call<Champion> call, Response<Champion> response) {
                    Toast.makeText(CreateActivity.this,"New champ created!",Toast.LENGTH_SHORT).show();
                }

                @Override
                public void onFailure(Call<Champion> call, Throwable t) {
                    Toast.makeText(CreateActivity.this,"Error creating new champ :(",Toast.LENGTH_SHORT).show();
                }
            });
        }
        else
        {
            Toast.makeText(CreateActivity.this,"Please enter Name and Role.",Toast.LENGTH_SHORT).show();
        }
    }
}
