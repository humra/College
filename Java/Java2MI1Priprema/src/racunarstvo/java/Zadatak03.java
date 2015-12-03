package racunarstvo.java;

import java.io.*;

public class Zadatak03 {

    public static void main(String[] args) {
        Student s = new Student("Matija", "Huremovic");
        
        try {
            FileOutputStream fileOut = new FileOutputStream("student.ser");
            ObjectOutputStream objectOut = new ObjectOutputStream(fileOut);
            objectOut.writeObject(s);
            objectOut.close();
            fileOut.close();
            System.out.println("Serijalizirano!");
        }
        catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        Student ds = null;
        
        try {
            FileInputStream fileIn = new FileInputStream("student.ser");
            ObjectInputStream objectIn = new ObjectInputStream(fileIn);
            ds = (Student)objectIn.readObject();
            objectIn.close();
            fileIn.close();
            
            System.out.printf("Ime: %s\r\nPrezime: %s\r\n", ds.getIme(), ds.getPrezime());
        }
        catch(IOException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
    }
    
}
