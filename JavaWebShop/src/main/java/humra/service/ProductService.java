package humra.service;

import java.util.ArrayList;
import java.util.HashSet;

import humra.domain.Product;

public interface ProductService {
	public HashSet<String> getCategories();
	public ArrayList<Product> getProductsByCategory(String categoryName);
	public Product getProductById(String id);
}
