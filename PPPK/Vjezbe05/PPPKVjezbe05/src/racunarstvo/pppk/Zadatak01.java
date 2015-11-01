package racunarstvo.pppk;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.Types;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.sql.DataSource;

public class Zadatak01 {

    public static void main(String[] args) {
        DataSource ds = DataSourceCreator.createDataSource();
        
        createProcedure(ds);
        
        try {
            Scanner s = new Scanner(System.in);
            System.out.println("Unesite ID kolegija: ");
            int kolegijID = Integer.parseInt(s.nextLine());
            
            DohvatStudenata dst = dohvatiStudente(ds, kolegijID);
            
            ispisiRezultat(dst);
        }
        catch(Exception e) {
            System.out.println(e.getMessage());
        }
    }

    private static void createProcedure(DataSource ds) {
        String procedura = "CREATE PROCEDURE StudentiNaKolegiju \n @IDKolegij int \n" +
            "AS \n BEGIN \n SELECT * FROM Student \n" + 
            "INNER JOIN KolegijStudent ON KolegijStudent.IDStudent = Student.IDStudent " + 
            "AND KolegijStudent.IDKolegij = @IDKolegij \n" +
            "RETURN (SELECT COUNT(*) FROM Student) \n END";
        
        try(Connection con = ds.getConnection()) {
            Statement st = con.createStatement();
            st.executeUpdate(procedura);
        }
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }

    private static DohvatStudenata dohvatiStudente(DataSource ds, int kolegijID) {
        try(Connection con = ds.getConnection()) {
            CallableStatement statement = con.prepareCall("{? = CALL StudentiNaKolegiju(?)}");
            
            statement.registerOutParameter(1, Types.INTEGER);
            statement.setInt(2, kolegijID);
            
            ResultSet rs = statement.executeQuery();
            List<Student> studenti = new ArrayList<>();
            
            while(rs.next()) {
                Student s = new Student();
                s.ID = rs.getInt("IDStudent");
                s.ime = rs.getString("Ime");
                s.prezime = rs.getString("Prezime");
                
                studenti.add(s);
            }
            
            int brojStudenata = rs.getInt(1);
            
            DohvatStudenata dst = new DohvatStudenata(brojStudenata, studenti);
            return dst;
        }
        catch (SQLException e) {
            System.out.println(e.getMessage());
        }
        catch(Exception e) {
            System.out.println(e.getMessage());
        }
        
        return null;
    }

    private static void ispisiRezultat(DohvatStudenata dst) {
        System.out.println("Ukupno studenata: " + dst.brojStudenata);
        
        for(Student s : dst.studenti) {
            System.out.println(s.ime + " " + s.prezime + "\n");
        }
    }
    
}
