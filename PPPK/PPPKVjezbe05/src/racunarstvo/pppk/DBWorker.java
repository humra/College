package racunarstvo.pppk;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.Types;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.sql.DataSource;

public class DBWorker {

    public static void main(String[] args) {
        DataSource ds = kreirajDataSource();
        
        kreirajProceduruDohvatStudenata(ds);
        dohvatiStudenteZaKolegij(ds, 2);
    }

    private static DataSource kreirajDataSource() {
        SQLServerDataSource ds = new SQLServerDataSource();
        
        ds.setUser("Humra");
        ds.setPassword("1234");
        ds.setDatabaseName("PPPK5");
        ds.setServerName("MATIJA-LAPTOP\\SQLEXPRESS");
        
        return ds;
    }

    private static void kreirajProceduruDohvatStudenata(DataSource ds) {
        String query = "CREATE PROCEDURE DohvatiStudente @IDKolegij int AS "
                + "SELECT * FROM Student INNER JOIN KolegijStudent "
                + "ON KolegijStudent.IDStudent = Student.IDStudent "
                + "WHERE KolegijStudent.IDKolegij = @IDKolegij "
                + "RETURN (SELECT COUNT(*) FROM Student)";
        
        try(Connection con = ds.getConnection()) {
            Statement st = con.createStatement();
            st.executeUpdate(query);
        }
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }

    private static void dohvatiStudenteZaKolegij(DataSource ds, int IDKolegij) {
        try(Connection con = ds.getConnection(); CallableStatement st = con.prepareCall("{? = CALL DohvatiStudente(?)}")) {
            st.registerOutParameter(1, Types.INTEGER);
            st.setInt(2, IDKolegij);
            
            ResultSet rs = st.executeQuery();
            ArrayList<Student> studenti = new ArrayList<Student>();
            
            while(rs.next()) {
                Student temp = new Student();
                temp.IDStudent = rs.getInt("IDStudent");
                temp.Ime = rs.getString("Ime");
                temp.Prezime = rs.getString("Prezime");
                
                studenti.add(temp);
            }
            
            int brojStudenata = st.getInt(1);
            
            ispisiPodatke(brojStudenata, studenti);
        }
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }

    private static void ispisiPodatke(int brojStudenata, ArrayList<Student> studenti) {
        System.out.println("Broj studenata na kolegiju: " + brojStudenata);
        
        for(Student s : studenti) {
            System.out.println(String.format("%d - %s %s", s.IDStudent, s.Ime, s.Prezime));
        }
    }
}
