package com.humra.justjava;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TextView;

import java.text.NumberFormat;

public class MainActivity extends AppCompatActivity {

    private int quantity = 2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void submitOrder(View view) {
        String priceMessage = "";

        //priceMessage += "Hello, " + ((EditText)findViewById(R.id.name)).getText().toString();
        priceMessage += ((EditText)findViewById(R.id.name)).getText().toString();

        boolean whippedCream = ((CheckBox)findViewById(R.id.whippedCream)).isChecked();
        boolean chocolate = ((CheckBox)findViewById(R.id.chocolate)).isChecked();

        priceMessage += "\nTotal: $" + Integer.toString(calculatePrice(whippedCream, chocolate));

        if(whippedCream) {
            priceMessage += "\nWith whipped cream.";
        }
        if(chocolate) {
            priceMessage += "\nWith chocolate.";
        }

        priceMessage += "\nThank you!";

        sendEmail(priceMessage);
    }

    private void sendEmail(String priceMessage) {
        Intent mail = new Intent(Intent.ACTION_SEND);
        mail.setType("*/*");
        mail.putExtra(Intent.EXTRA_SUBJECT, "Coffee order");
        mail.putExtra(Intent.EXTRA_TEXT, priceMessage);

        if(mail.resolveActivity(getPackageManager()) != null) {
            startActivity(mail);
        }
    }

    private int calculatePrice(boolean whippedCreamSelected, boolean chocolateSelected) {
        int price = 0;
        int pricePerCup = 5;
        int whippedCream = 1;
        int chocolate = 2;

        price += quantity * pricePerCup;

        if(whippedCreamSelected) {
            price += whippedCream * quantity;
        }
        if(chocolateSelected) {
            price += chocolate * quantity;
        }

        return price;
    }

    private void display(int number) {
        TextView quantityTextView = (TextView) findViewById(R.id.quantity_text_view);
        quantityTextView.setText("" + number);
    }

    public void increment(View view) {
        if(quantity <= 100) {
            quantity++;
        }
        display(quantity);
    }

    public void decrement(View view) {
        if(quantity > 1) {
            quantity--;
        }
        display(quantity);
    }
}
