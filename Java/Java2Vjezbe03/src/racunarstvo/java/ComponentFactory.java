package racunarstvo.java;

import java.awt.Color;
import java.awt.Component;

class ComponentFactory {

    public static Component from(String text) {
        String[] values = text.split(";");
        
        if (values.length != 4) {
            throw new RuntimeException("Krivi unos podataka");
        }
        
        String className = values[0];
        int width = Integer.valueOf(values[1]);
        int height = Integer.valueOf(values[2]);
        String colour = values[3];

        return createComponent(className, width, height, colour);
    }

    private static Component createComponent(String className, int width, int heigth, String colour) {
        try {
            Class klasa = Class.forName(className);
            Color c = (Color) Color.class.getDeclaredField(colour).get(null);
            
            Component komponenta = (Component) klasa.getDeclaredConstructor(Color.class).newInstance(c);
            klasa.getMethod("setBounds", int.class, int.class, int.class, int.class).invoke(komponenta, 0, 0, width, heigth);
            
            return komponenta;
        } 
        catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return null;
    }

}
