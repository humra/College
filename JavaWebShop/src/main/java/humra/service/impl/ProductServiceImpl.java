package humra.service.impl;

import java.io.File;
import java.util.ArrayList;
import java.util.HashSet;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.springframework.core.io.ClassPathResource;
import org.springframework.stereotype.Service;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

import humra.domain.Product;
import humra.service.ProductService;

@Service("productService")
public class ProductServiceImpl implements ProductService {
	
	@Override
	public HashSet<String> getCategories() {
		HashSet<String> categories = new HashSet<String>();
		
		try {
			NodeList nodeList = getProductNodeList();
			
			for(int i = 0; i < nodeList.getLength(); i++) {
				Node node = nodeList.item(i);
				
				if(node.getNodeType() == Node.ELEMENT_NODE) {
					Element element = (Element) node;
					
					categories.add(element.getElementsByTagName("category").item(0).getTextContent());
				}
			}
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
		
		return categories;
	}
	
	@Override
	public ArrayList<Product> getProductsByCategory(String categoryName) {
		ArrayList<Product> parsedProducts = new ArrayList<>();
		
		try {
			NodeList nodeList = getProductNodeList();
			
			for(int i = 0; i < nodeList.getLength(); i++) {
				Node node = nodeList.item(i);
				
				if(node.getNodeType() == Node.ELEMENT_NODE) {
					Element element = (Element) node;
					
					if(element.getElementsByTagName("category").item(0).getTextContent().equals(categoryName)) {
						parsedProducts.add(createProduct(element));
					}
				}
			}
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
		
		return parsedProducts;
	}

	@Override
	public Product getProductById(String id) {
		
		try {
			NodeList nodeList = getProductNodeList();
			
			for(int i = 0; i < nodeList.getLength(); i++) {
				Node node = nodeList.item(i);
				
				if(node.getNodeType() == Node.ELEMENT_NODE) {
					Element element = (Element) node;
					
					if(element.getElementsByTagName("id").item(0).getTextContent().equals(id)) {
						return createProduct(element);
					}
				}
			}
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
		return new Product();
	}
	
	private Product createProduct(Element element) {
		Product tempProduct = new Product();
		tempProduct.setCategory(element.getElementsByTagName("category").item(0).getTextContent());
		tempProduct.setDescription(element.getElementsByTagName("description").item(0).getTextContent());
		tempProduct.setID(Integer.parseInt(element.getElementsByTagName("id").item(0).getTextContent()));
		tempProduct.setImgUrl(element.getElementsByTagName("image_url").item(0).getTextContent());
		tempProduct.setName(element.getElementsByTagName("name").item(0).getTextContent());
		
		String price = element.getElementsByTagName("price").item(0).getTextContent();
		price = price.replace(".", "");
		price = price.replace(",", ".");
		tempProduct.setPrice(Double.parseDouble(price));
		
		return tempProduct;
	}

	private NodeList getProductNodeList() {
		NodeList nodeList;
		
		try {
			File products = new ClassPathResource("/products/products.xml").getFile();
			DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
			DocumentBuilder db = dbFactory.newDocumentBuilder();
			Document doc = db.parse(products);
			
			doc.getDocumentElement().normalize();
			
			nodeList = doc.getElementsByTagName("product");
			return nodeList;
		}
		catch(Exception ex) {
			ex.printStackTrace();
			return null;
		}
	}

}
