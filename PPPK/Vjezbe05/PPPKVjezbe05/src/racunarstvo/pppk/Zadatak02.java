package racunarstvo.pppk;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.sql.DataSource;

public class Zadatak02 {

    public static void main(String[] args) {
        DataSource ds = DataSourceCreator.createDataSource();
        
        try(Connection con = ds.getConnection()) {
            con.setAutoCommit(false);
            
            try(PreparedStatement dodajKolegij = con.prepareStatement("INSERT INTO Kolegij (Naziv, Semestar, ECTS) VALUES (?, ?, ?)");
                PreparedStatement postaviEcts = con.prepareStatement("UPDATE Kolegij SET ECTS = ? WHERE IDKolegij = ?");
                PreparedStatement obrisiKolegij = con.prepareStatement("DELETE FROM Kolegij WHERE IDKolegij = ?")) {
                
                List<Kolegij> kolegijiZaDodati = vratiKolegijeZaDodati();
                List<Integer> listaDodanihKolegija = dodajNoveKolegij(kolegijiZaDodati, dodajKolegij);
                
                promijeniECTS(listaDodanihKolegija, 10, postaviEcts);
                
                brisiKolegij(listaDodanihKolegija.get(listaDodanihKolegija.size() - 1), obrisiKolegij);
                
                if(potvrda()) {
                    con.commit();
                }
                else {
                    con.rollback();
                }
            }
        }
        catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }

    private static List<Kolegij> vratiKolegijeZaDodati() {
        List<Kolegij> kolegiji = new ArrayList<>();
        
        for(int i = 1; i <= 5; i++) {
            Kolegij k = new Kolegij("Kolegij" + i, 5, i + 5, i*10);
            kolegiji.add(k);
        }
        
        return kolegiji;
    }

    private static List<Integer> dodajNoveKolegij(List<Kolegij> kolegijiZaDodati, PreparedStatement dodajKolegij) throws SQLException {
        List<Integer> rezultat = new ArrayList<>();
        
        for(Kolegij k : kolegijiZaDodati) {
            dodajKolegij.setString(1, k.naziv);
            dodajKolegij.setInt(2, k.semestar);
            dodajKolegij.setInt(3, k.ECTS);
            
            dodajKolegij.executeUpdate();
            
            ResultSet rs = dodajKolegij.getGeneratedKeys();
            
            if(rs != null && rs.next()) {
                rezultat.add(rs.getInt(1));
            }
        }
        
        return rezultat;
    }

    private static void promijeniECTS(List<Integer> listaDodanihKolegija, int ECTSnovi, PreparedStatement postaviEcts) throws SQLException {
        for(int i : listaDodanihKolegija) {
            postaviEcts.setInt(1, ECTSnovi);
            postaviEcts.setInt(2, i);
            
            postaviEcts.executeUpdate();
        }
    }

    private static void brisiKolegij(Integer idKolegija, PreparedStatement obrisiKolegij) throws SQLException {
        obrisiKolegij.setInt(1, idKolegija);
        obrisiKolegij.executeUpdate();
    }

    private static boolean potvrda() {
        Scanner s = new Scanner(System.in);
        
        System.out.println("Jeste li sigurni da zelite unjeti ove promjene? (Y/N)");
        String potvrda = s.nextLine();
        
        if(potvrda.equals("Y") || potvrda.equals("y")) {
            return true;
        }
        else {
            return false;
        }
    }
    
}
