package com.humra.vjezba01zadatak01;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private String expression;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        expression = "";
    }

    public void performAction(View view) {
        switch(view.getId()) {
            case R.id.btn0:
                expression += " 0";
                break;
            case R.id.btn1:
                expression += " 1";
                break;
            case R.id.btn2:
                expression += " 2";
                break;
            case R.id.btn3:
                expression += " 3";
                break;
            case R.id.btn4:
                expression += " 4";
                break;
            case R.id.btn5:
                expression += " 5";
                break;
            case R.id.btn6:
                expression += " 6";
                break;
            case R.id.btn7:
                expression += " 7";
                break;
            case R.id.btn8:
                expression += " 8";
                break;
            case R.id.btn9:
                expression += " 9";
                break;
            case R.id.btnAdd:
                expression += " +";
                break;
            case R.id.btnDiv:
                expression += " /";
                break;
            case R.id.btnSub:
                expression += " -";
                break;
            case R.id.btnMul:
                expression += " *";
                break;
            case R.id.btnEq:
                calculateResult();
                break;
        }

        updateExpressionField();
    }

    private void calculateResult() {
        expression = expression.replace(" ", "");

        float result = 0.0f;

        for(int i = 0; i < expression.length(); i++) {
            if(Character.isDigit(expression.charAt(i)) && i == 0) {
                result += Character.getNumericValue(expression.charAt(i));
            }

            if(!Character.isDigit(expression.charAt(i))) {
                switch (expression.charAt(i)) {
                    case '+':
                        result += Character.getNumericValue(expression.charAt(i + 1));
                        break;
                    case '-':
                        result -= Character.getNumericValue(expression.charAt(i + 1));
                        break;
                    case '*':
                        result *= Character.getNumericValue(expression.charAt(i + 1));
                        break;
                    case '/':
                        result /= Character.getNumericValue(expression.charAt(i + 1));
                        break;
                }
            }

            updateResultField(result);
        }
    }

    private void updateResultField(float result) {
        TextView resultView = (TextView)findViewById(R.id.txtResult);
        resultView.setText(Float.toString(result));
    }

    private void updateExpressionField() {
        TextView expressionView = (TextView)findViewById(R.id.txtInput);
        expressionView.setText(expression);
    }


}
