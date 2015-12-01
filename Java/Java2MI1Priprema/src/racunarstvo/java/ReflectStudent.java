package racunarstvo.java;

import java.lang.reflect.Constructor;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.lang.reflect.Modifier;
import java.util.Scanner;

public class ReflectStudent {

    public static void main(String[] args) {
        Method[] metodeStudent = Student.class.getDeclaredMethods();

        System.out.println("Privatne metode: ");
        for(Method m : metodeStudent) {
            if(Modifier.isPrivate(m.getModifiers())) {
                System.out.println(m.getName());
            }
        }
        
        Scanner s = new Scanner(System.in);
        System.out.print("Ime: ");
        String ime = s.nextLine();
        System.out.print("Prezime: ");
        String prezime = s.nextLine();
        
        Object objekt = kreirajObjekt(ime, prezime);
        
        System.out.println("Kreirali ste studenta:");
        System.out.println(objekt);
    }

    private static Object kreirajObjekt(String ime, String prezime) {    
        try {
            Class klasaObjekta = Class.forName("racunarstvo.java.Student");

            Constructor c = klasaObjekta.getConstructor(String.class, String.class);

            Object newInstance = c.newInstance(ime, prezime);
            
            return newInstance;
        }
        catch(ClassNotFoundException | NoSuchMethodException | SecurityException | InstantiationException | IllegalAccessException | IllegalArgumentException | InvocationTargetException e) {
            e.printStackTrace();
            System.out.println(e.getMessage());
        }
        return null;
    }
    
}
