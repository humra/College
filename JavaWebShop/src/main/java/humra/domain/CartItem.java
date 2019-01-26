package humra.domain;

public class CartItem {
	private Product product;
	private int quantity;
	private static int globalId = 0;
	private int cartItemId;
	
	public CartItem(Product product, int quantity) {
		this.product = product;
		this.quantity = quantity;
		globalId++;
		this.cartItemId = globalId;
	}
	
	public int getProductId() {
		return this.product.getID();
	}

	public Product getProduct() {
		return product;
	}

	public void setProduct(Product product) {
		this.product = product;
	}

	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
		this.validateQuantity();
	}
	
	public void addOneMore() {
		this.quantity++;
	}
	
	public void addMore(int added) {
		quantity += added;
	}
	
	public void removeOne() {
		this.quantity--;
		this.validateQuantity();
	}
	
	public void removeMore(int removed) {
		quantity -= removed;
		this.validateQuantity();
	}
	
	public double getTotalPrice() {
		return this.getQuantity() * this.getProduct().getPrice();
	}
	
	public void validateQuantity() {
		if(this.quantity < 0) {
			this.quantity = 0;
		}
	}

	public int getCartItemId() {
		return cartItemId;
	}

	public void setCartItemId(int cartItemId) {
		this.cartItemId = cartItemId;
	}
	
	
}
