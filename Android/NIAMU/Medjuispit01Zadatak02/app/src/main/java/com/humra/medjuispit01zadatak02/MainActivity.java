package com.humra.medjuispit01zadatak02;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements IView {

    private Button myButton;
    private EditText myEditText;
    private TextView myTextView;
    Prezenter p;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        myButton = (Button)findViewById(R.id.button);
        myEditText = (EditText)findViewById(R.id.editText);
        myTextView = (TextView)findViewById(R.id.textView);

        p = new Prezenter(this);

        this.myButton.setOnClickListener(
                new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        p.processMessage(myEditText.getText().toString());
                    }
                }
        );
    }

    @Override
    public void showMessage(String message) {
        this.myTextView.setText(message);
    }

    @Override
    public void showError() {
        Toast.makeText(this, "The input is not a valid number", Toast.LENGTH_SHORT).show();
    }
}
