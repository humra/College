package humra.domain;

import java.util.ArrayList;

import org.springframework.stereotype.Component;

@Component
public class ShoppingCart {
	private ArrayList<CartItem> products;
	private double totalPrice;
	
	public ShoppingCart() {
		this.products = new ArrayList<>();
		this.totalPrice = 0;
	}
	
	public void addProduct(Product product, int quantity) {
		products.add(new CartItem(product, quantity));
		this.calculateTotalPrice();
	}
	
	private void calculateTotalPrice() {
		double total = 0;
		
		for(CartItem item : products) {
			total += item.getTotalPrice();
		}
		
		totalPrice = total;
	}
	
	public double getTotalPrice() {
		return this.totalPrice;
	}
	
	public ArrayList<CartItem> getProducts() {
		return this.products;
	}
	
	/*
	 * Iterate the list in reverse to avoid null pointer exceptions
	 */
	public void removeAllProducts(int productId) {
		for(int i = products.size() - 1; i >= 0; i--) {
			if(products.get(i).getCartItemId() == productId) {
				products.remove(i);
			}
		}
		
		this.calculateTotalPrice();
	}
	
	public void clearCart() {
		this.products.clear();
		this.calculateTotalPrice();
	}
	
	public void removeXProducts(int cartItemId, int quantity) {
		for(int i = this.products.size() - 1; i >= 0; i--) {
			if(products.get(i).getCartItemId() == cartItemId) {
				if(quantity >= products.get(i).getQuantity()) {
					this.removeAllProducts(cartItemId);
				}
				else {
					products.get(i).removeMore(quantity);
				}
			}
		}
		this.calculateTotalPrice();
	}
}
