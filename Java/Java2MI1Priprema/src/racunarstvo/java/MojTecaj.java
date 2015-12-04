package racunarstvo.java;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;

public class MojTecaj extends UnicastRemoteObject implements ITecaj {

    public MojTecaj() throws RemoteException {}
    
    public static void main(String[] args) {
        try {
            MojTecaj t = new MojTecaj();
            Registry r = LocateRegistry.createRegistry(10250);
            Naming.rebind("rmi://localhost:10250/tecaj", r);
            System.out.println("Server is up and running!");
        }
        catch(RemoteException | MalformedURLException ex) {
            System.out.println(ex.getMessage());
        }
    }

    @Override
    public Double euroToKuna(double valuta) throws RemoteException {
        return valuta * 7.5;
    }

    @Override
    public Double kunaToEuro(double valuta) throws RemoteException {
        return valuta / 7.5;
    }
    
}
