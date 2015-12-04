package racunarstvo.java;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;

public class KlijentTecaj {

    public static void main(String[] args) {
        try {
            MojTecaj tecaj = (MojTecaj) Naming.lookup("rmi://localhost:10250/tecaj");
            double broj1 = tecaj.euroToKuna(100);
            System.out.println(broj1);
            double broj2 = tecaj.kunaToEuro(100);
            System.out.println(broj2);
        }
        catch(NotBoundException | MalformedURLException | RemoteException ex) {
            System.out.println(ex.getMessage());
        }
    }
    
}
