package racunarstvo.java;

import java.util.ArrayList;
import java.util.Collections;

public class VelikiBroj {

    public String broj;

    public VelikiBroj(String broj) {
        this.broj = broj;
    }

    public String add(VelikiBroj drugiBroj) {
        String a = broj;
        String b = drugiBroj.broj;
        StringBuilder sb = new StringBuilder();

        int tempA;
        int tempB;
        int tempC;
        int carry = 0;
        
        while(a.length() > 0 && b.length() > 0) {
            tempA = Character.getNumericValue(a.charAt(a.length() - 1));
            tempB = Character.getNumericValue(b.charAt(b.length() - 1));
            
            tempC = tempA + tempB + carry;
            
            if(tempC >= 10) {
                carry = tempC / 10;
                tempC = tempC - (carry * 10);
            }
            else {
                carry = 0;
            }
            
            sb.append(Integer.toString(tempC));
            
            a = a.substring(0, a.length() - 1);
            b = b.substring(0, b.length() - 1);
        }
        
        while(a.length() > 0) {
            tempA = Character.getNumericValue(a.charAt(a.length() - 1));
            sb.append(Integer.toString(tempA));
            a = a.substring(0, a.length() - 1);
        }
        
        while(b.length() > 0) {
            tempB = Character.getNumericValue(b.charAt(b.length() - 1));
            sb.append(Integer.toString(tempB));
            b = b.substring(0, b.length() - 1);
        }
        
        return sb.reverse().toString();
    }
}
