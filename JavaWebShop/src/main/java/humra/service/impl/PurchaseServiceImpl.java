package humra.service.impl;

import java.io.File;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.springframework.core.io.ClassPathResource;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.stereotype.Service;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

import humra.domain.BuyerInfo;
import humra.domain.CartItem;
import humra.domain.Purchase;
import humra.domain.ShoppingCart;
import humra.service.PurchaseService;

@Service("purchaseService")
public class PurchaseServiceImpl implements PurchaseService {

	@Override
	public void writePurchase(ShoppingCart cart, BuyerInfo buyerInfo) {
		NodeList nodeList = this.getHistoryNodeList();
		ArrayList<Purchase> purchaseHistory = this.parsePurchases(nodeList);
		
		purchaseHistory.add(this.parseNewPurchase(cart, buyerInfo));
				
		writePurchases(purchaseHistory);
	}

	private void writePurchases(ArrayList<Purchase> purchaseHistory) {
		try {
			DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
			DocumentBuilder builder = factory.newDocumentBuilder();
			
			Document doc = builder.newDocument();
			
			Element root = doc.createElement("History");
			doc.appendChild(root);
			
			for(Purchase p : purchaseHistory) {
				Element purchase = doc.createElement("purchase");
				root.appendChild(purchase);
				
				Element username = doc.createElement("username");
				username.appendChild(doc.createTextNode(p.getUsername()));
				purchase.appendChild(username);
				
				Element firstName = doc.createElement("firstName");
				firstName.appendChild(doc.createTextNode(p.getFirstName()));
				purchase.appendChild(firstName);
				
				Element lastName = doc.createElement("lastName");
				lastName.appendChild(doc.createTextNode(p.getLastName()));
				purchase.appendChild(lastName);
				
				Element address = doc.createElement("address");
				address.appendChild(doc.createTextNode(p.getAddress()));
				purchase.appendChild(address);
				
				Element time = doc.createElement("time");
				time.appendChild(doc.createTextNode(p.getTime()));
				purchase.appendChild(time);
				
				Element total = doc.createElement("total");
				total.appendChild(doc.createTextNode(p.getTotal()));
				purchase.appendChild(total);
				
				Element items = doc.createElement("items");
				purchase.appendChild(items);
				
				for(String s : p.getItems()) {
					Element item = doc.createElement("item");
					item.appendChild(doc.createTextNode(s));
					items.appendChild(item);
				}
			}
			
			TransformerFactory transformerFactory = TransformerFactory.newInstance();
			Transformer transformer = transformerFactory.newTransformer();
			transformer.setOutputProperty(OutputKeys.INDENT, "yes");
			transformer.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "2");
			DOMSource source = new DOMSource(doc);
			
			File history = new ClassPathResource("/history/history.xml").getFile();
			StreamResult result = new StreamResult(history);
			
			transformer.transform(source, result);
			
			System.out.println("File saved!");
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
	}

	private Purchase parseNewPurchase(ShoppingCart cart, BuyerInfo buyerInfo) {
		Purchase purchase = new Purchase();
		
		purchase.setAddress(buyerInfo.getAddress());
		purchase.setFirstName(buyerInfo.getFirstName());
		purchase.setLastName(buyerInfo.getLastName());
		
		DateFormat dateFormat = new SimpleDateFormat("dd/MM/yyyy HH:mm:ss");
		purchase.setTime(dateFormat.format(new Date()));
		
		purchase.setTotal(Double.toString(cart.getTotalPrice()));
		
		Authentication auth = SecurityContextHolder.getContext().getAuthentication();
		String username = auth.getName();
		purchase.setUsername(username);
		
		
		ArrayList<CartItem> cartItems = cart.getProducts();
		for(CartItem cartItem : cartItems) {
			purchase.addItem(cartItem.getProduct().getName());
		}
		
		
		return purchase;
	}

	private ArrayList<Purchase> parsePurchases(NodeList nodeList) {
		ArrayList<Purchase> purchaseHistory = new ArrayList<>();
		
		for(int i = 0; i < nodeList.getLength(); i++) {
			Node node = nodeList.item(i);
			
			if(node.getNodeType() == Node.ELEMENT_NODE) {
				Element element = (Element) node;
				purchaseHistory.add(createPurchase(element));
			}
		}
		
		return purchaseHistory;
	}

	private Purchase createPurchase(Element element) {
		Purchase purchase = new Purchase();
		
		purchase.setAddress(element.getElementsByTagName("address").item(0).getTextContent());
		purchase.setTime(element.getElementsByTagName("time").item(0).getTextContent());
		purchase.setFirstName(element.getElementsByTagName("firstName").item(0).getTextContent());
		purchase.setLastName(element.getElementsByTagName("lastName").item(0).getTextContent());
		purchase.setTotal(element.getElementsByTagName("total").item(0).getTextContent());
		purchase.setUsername(element.getElementsByTagName("username").item(0).getTextContent());
		
		NodeList itemList = element.getElementsByTagName("items");
		
		for(int i = 0; i < itemList.getLength(); i++) {
			Node node = itemList.item(i);
			
			if(node.getNodeType() == Node.ELEMENT_NODE) {
				Element itemElement = (Element) node;
				
				purchase.addItem(itemElement.getElementsByTagName("item").item(0).getTextContent());
			}
		}
		
		return purchase;
	}

	private NodeList getHistoryNodeList() {
		NodeList nodeList;
		
		try {
			File history = new ClassPathResource("/history/history.xml").getFile();
			DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
			DocumentBuilder db = dbFactory.newDocumentBuilder();
			Document doc = db.parse(history);
			
			doc.getDocumentElement().normalize();
			
			nodeList = doc.getElementsByTagName("purchase");

			return nodeList;
		}
		catch(Exception ex) {
			ex.printStackTrace();
			return null;
		}
	}

	@Override
	public ArrayList<Purchase> readPurchases(String username) {		
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public ArrayList<Purchase> readAllPurchases() {
		NodeList nodeList = this.getHistoryNodeList();
		ArrayList<Purchase> purchases = this.parsePurchases(nodeList);
		
		return purchases;
	}


}
