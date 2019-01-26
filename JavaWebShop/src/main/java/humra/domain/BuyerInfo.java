package humra.domain;

public class BuyerInfo {
	private String firstName;
	private String lastName;
	private String address;
	private String username;
	
	public BuyerInfo() {}
	
	public BuyerInfo(String firstName, String lastName, String address, String username) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.address = address;
		this.username = username;
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
	
	
}
