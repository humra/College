package racunarstvo.pppk;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.sql.DataSource;

public class DataBaseReader {

    public static void main(String[] args) {
        DataSource ds = kreirajDataSource();
        
        ispisiPodatkeOStudentima(ds);
    }

    private static DataSource kreirajDataSource() {
        SQLServerDataSource ds = new SQLServerDataSource();
        
        ds.setDatabaseName("PPPK4");
        ds.setUser("Humra");
        ds.setPassword("1234");
        //ds.setIntegratedSecurity(true);
        ds.setServerName("MATIJA-LAPTOP\\SQLEXPRESS");
        
        return ds;
    }

    private static void ispisiPodatkeOStudentima(DataSource ds) {
        String query = "SELECT * FROM Student";
        
        String cs = "jdbc:sqlserver://MATIJA-LAPTOP\\SQLEXPRESS;databaseName=PPPK;integratedSecurity=true";
        
        try(Connection con = ds.getConnection()) {
            System.out.println("weeeeeeeee");
        }
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }
    
}
