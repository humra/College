package racunarstvo.pppk;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.sql.DataSource;

public class DataBaseReader {

    public static void main(String[] args) {
        DataSource ds = kreirajDataSource();
        
        ispisiPodatkeOStudentima(ds);
        ispisiKolegije(ds);
        povecajECTS(ds);
    }

    private static DataSource kreirajDataSource() {
        SQLServerDataSource ds = new SQLServerDataSource();
        
        ds.setDatabaseName("PPPK4");
        ds.setUser("Humra");
        ds.setPassword("1234");
        ds.setServerName("MATIJA-LAPTOP\\SQLEXPRESS");
        
        return ds;
    }

    private static void ispisiPodatkeOStudentima(DataSource ds) {
        String query = "SELECT * FROM Student";
        
        try(Connection con = ds.getConnection()) {
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(query);
            
            while(rs.next()) {
                System.out.println(String.format("%s %s %d", rs.getString("Ime"), rs.getString("Prezime"), rs.getInt("IDStudent")));
            }
        }
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }

    private static void ispisiKolegije(DataSource ds) {
        String query = "SELECT * FROM KolegijNastavnik INNER JOIN Nastavnik ON " + 
                "KolegijNastavnik.IDNastavnik = Nastavnik.IDNastavnik " + 
                "INNER JOIN Kolegij ON KolegijNastavnik.IDKolegij = Kolegij.IDKolegij";
        
        try(Connection con = ds.getConnection()) {
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(query);
            
            while(rs.next()) {
                System.out.println(String.format("%s - %s %s", rs.getString("Naziv"), rs.getString("Ime"), rs.getString("Prezime")));
            }
        }
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }

    private static void povecajECTS(DataSource ds) {
        String query = "UPDATE Kolegij SET ECTS = ECTS + 1 WHERE Semestar = 2";
        
        try(Connection con = ds.getConnection()) {
            Statement st = con.createStatement();
            int updateanihRedova = st.executeUpdate(query);
            
            System.out.println("Updateano " + updateanihRedova + " kolegija");
        }
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }
    
}
