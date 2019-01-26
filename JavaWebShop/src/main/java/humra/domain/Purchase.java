package humra.domain;

import java.util.ArrayList;

public class Purchase {
	private String username;
	private String firstName;
	private String lastName;
	private String address;
	private String time;
	private String total;
	private ArrayList<String> items;
	
	
	
	public Purchase() {
		this.items = new ArrayList<>();
	}

	public Purchase(String username, String firstName, String lastName, String address, String dateTime, String total) {
		this.username = username;
		this.firstName = firstName;
		this.lastName = lastName;
		this.address = address;
		this.time = dateTime;
		this.total = total;
		this.items = new ArrayList<>();
	}
	
	public void addItem(String itemName) {
		items.add(itemName);
	}
	
	public ArrayList<String> getItems() {
		return this.items;
	}
	
	public void setItems(ArrayList<String> items) {
		this.items = items;
	}

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public String getTime() {
		return time;
	}
	public void setTime(String dateTime) {
		this.time = dateTime;
	}

	public String getTotal() {
		return total;
	}

	public void setTotal(String total) {
		this.total = total;
	}

	@Override
	public String toString() {
		return String.format(username, firstName, lastName, time, total, address);
	}
	
	
}
