package ishod02;

import com.microsoft.sqlserver.jdbc.SQLServerConnection;
import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.sql.DataSource;

public class Ishod02 {

    public static void main(String[] args) {
        DataSource ds = kreirajDataSource();
        
        //prikaziBicikle(ds);
        prikaziOdredjeniProizvod(ds, 316);
    }

    private static DataSource kreirajDataSource() {
        SQLServerDataSource ds = new SQLServerDataSource();
        
        ds.setServerName("MATIJA-LAPTOP\\SQLEXPRESS");
        ds.setUser("Humra");
        ds.setPassword("1234");
        ds.setDatabaseName("AdventureWorksOBP");
        
        return ds;
    }

    private static void prikaziBicikle(DataSource ds) {
        String query = "SELECT * FROM Proizvod INNER JOIN Potkategorija ON "
                + "PotkategorijaID = IDPotkategorija INNER JOIN Kategorija ON "
                + "IDKategorija = KategorijaID WHERE IDKategorija = 1";
        
        try(Connection con = ds.getConnection()) {
            Statement st = con.createStatement();
            
            ResultSet rs = st.executeQuery(query);
            
            while(rs.next()) {
                System.out.println(rs.getString("Naziv"));
            }
        }
        catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
    }

    private static void prikaziOdredjeniProizvod(DataSource ds, int i) {
        String query = "SELECT * FROM Proizvod WHERE IDProizvod = " + i;
        
        try(Connection con = ds.getConnection()) {
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(query);
            
            while(rs.next()) {
                System.out.println(rs.getString("Naziv"));
            }
        }
        catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
    }
    
}
