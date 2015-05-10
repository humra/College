package racunarstvo.java;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;

public class GradoviZupanije {

    public static void main(String[] args) {
        Map<String, String> gradovi = new HashMap<String, String>();

        Scanner in = new Scanner(System.in);
        String temp;

        do {
            temp = in.nextLine();
            if (!temp.equals("kraj")) {
                String[] gradZupanija = temp.split(", ");
                gradovi.put(gradZupanija[0], gradZupanija[1]);
            }
        } while (!temp.equals("kraj"));

        System.out.print("\nUnesite trazenu zupaniju: ");
        String trazenaZupanija = in.nextLine();
        
        List<String> tempList = new ArrayList<String>();
        
        for(String key : gradovi.keySet()) {
            if(key.equals(trazenaZupanija)) {
                tempList.add(gradovi.get(key));
            }
        }
        
        Collections.sort(tempList);
        for(String s : tempList) {
            System.out.println(s);
        }
    }

}
