/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package farmakrava;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import java.sql.*;
import java.util.Scanner;
import javax.sql.DataSource;

/**
 *
 * @author Matija
 */
public class FarmaKrava {
    
    static final String USER = "korisnik";
    static final String PASSWORD = "korisnik";
    
    static final String JDBC_DRIVER = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
    static final String DATABASE = "jdbc:microsoft:sqlserver://Radagast\\SQLEXPRESS;DatabaseName=FarmaKrava";
    
    static Scanner s = new Scanner(System.in);

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        DataSource dataSource = kreirajDataSource();
        
        System.out.println("Unesite godinu: ");
        //String unesenaGodina = s.nextLine();
        //int godina = Integer.parseInt(unesenaGodina);
        
        izracunajUkupno(dataSource, 2016);
    }

    private static DataSource kreirajDataSource() {
        SQLServerDataSource dataSource = new SQLServerDataSource();
        dataSource.setServerName("RADAGAST\\SQLEXPRESS");
        dataSource.setUser(USER);
        dataSource.setPassword(PASSWORD);
        dataSource.setDatabaseName("FarmaKrava");
        
        return dataSource;
    }

    private static void izracunajUkupno(DataSource dataSource, int godina) {
        final String query = "SELECT * FROM ProizvodnaMlijeka WHERE Datum LIKE '" + godina + "%'";
        
        try {
            Connection con = dataSource.getConnection();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(query);
            
            int ukupnoMlijeka = 0;
            int brojDana = 0;
            
            while(rs.next()) {
                ukupnoMlijeka += rs.getInt("KolicinaMlijeka");
                brojDana++;
            }
            
            System.out.printf("Ukupno mlijeka: %d\r\nProsjecno mlijeka po danu: %.2f\r\n", ukupnoMlijeka, ukupnoMlijeka / (float)brojDana);
        }
        catch(Exception ex) {
            ex.printStackTrace();
        }
    }
    
}
