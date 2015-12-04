package racunarstvo.java;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface ITecaj extends Remote {
    Double euroToKuna(double valuta) throws RemoteException;
    Double kunaToEuro(double valuta) throws RemoteException;
}
