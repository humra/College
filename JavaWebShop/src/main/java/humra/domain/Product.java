package humra.domain;

import java.io.Serializable;

public class Product implements Serializable{

	private static final long serialVersionUID = 1L;
	
	private int ID;
	private String name;
	private double price;
	private String category;
	private String description;
	private String imgUrl;
	
	public Product() {}
	
	public Product(int ID, String name, double price, String category, String description, String imgUrl)  {
		this.ID = ID;
		this.name = name;
		this.price = price;
		this.category = category;
		this.description = description;
		this.imgUrl = imgUrl;
	}
	
	public int getID() {
		return ID;
	}
	
	public void setID(int iD) {
		ID = iD;
	}
	
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public double getPrice() {
		return price;
	}
	
	public void setPrice(double price) {
		this.price = price;
	}
	
	public String getCategory() {
		return category;
	}
	
	public void setCategory(String category) {
		this.category = category;
	}
	
	public String getDescription() {
		return description;
	}
	
	public void setDescription(String description) {
		this.description = description;
	}
	
	public String getImgUrl() {
		return imgUrl;
	}
	
	public void setImgUrl(String imgUrl) {
		this.imgUrl = imgUrl;
	}	
}
