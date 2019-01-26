package humra.service;

import java.util.ArrayList;

import humra.domain.BuyerInfo;
import humra.domain.Purchase;
import humra.domain.ShoppingCart;

public interface PurchaseService {
	public void writePurchase(ShoppingCart cart, BuyerInfo buyerInfo);
	public ArrayList<Purchase> readPurchases(String username);
	public ArrayList<Purchase> readAllPurchases();
}
