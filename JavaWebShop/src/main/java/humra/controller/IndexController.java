package humra.controller;

import java.util.ArrayList;
import java.util.HashSet;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.web.authentication.logout.SecurityContextLogoutHandler;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.SessionAttributes;

import humra.domain.BuyerInfo;
import humra.domain.Product;
import humra.domain.Purchase;
import humra.domain.ShoppingCart;
import humra.service.ProductService;
import humra.service.PurchaseService;

@Controller
@SessionAttributes({"cart"})
public class IndexController {

	@Autowired
	private ProductService productService;
	
	@Autowired
	private PurchaseService purchaseService;
	
	
    @RequestMapping("/index")
    public String showIndex(Model model, HttpSession session) {  
    	session.setAttribute("cart", new ShoppingCart());
    	
        HashSet<String> categories = productService.getCategories();
        model.addAttribute("categories", categories);
        
        return "index";
    }
    
    @RequestMapping(value="/category/{categoryName}") 
    public String showCategory(@PathVariable("categoryName") String categoryName, Model model) {
    	
    	model.addAttribute("categoryName", categoryName);
    	
    	ArrayList<Product> products = productService.getProductsByCategory(categoryName);
    	model.addAttribute("numberOfProducts", products.size());
    	model.addAttribute("products", products);
    	
    	return "categoryBrowse";
    }
    
    @RequestMapping(value="/products/{productId}", method=RequestMethod.GET) 
    public String showProductDetails(@PathVariable("productId") String productId, Model model) {
    	Product product = productService.getProductById(productId);
    	model.addAttribute("product", product);
    	
    	return "productDetails";
    }

    @RequestMapping(value="/products/{productId}", method=RequestMethod.POST) 
    public String addToCart(@PathVariable("productId") String productId, Model model, HttpSession session, @ModelAttribute("qty") String qty) {
    	Product product = productService.getProductById(productId);
    	ShoppingCart cart = (ShoppingCart) session.getAttribute("cart");
    	
    	cart.addProduct(product, Integer.parseInt(qty));
    	
    	model.addAttribute("product", product);
    	session.setAttribute("cart", cart);
    	
    	return "productDetails";
    }
    
    @RequestMapping(value="/cart/removeAll/{productId}")
    public String removeAllFromCart(Model model, HttpSession session, @PathVariable("productId") String productId) {
    	ShoppingCart cart = (ShoppingCart)session.getAttribute("cart");
    	cart.removeAllProducts(Integer.parseInt(productId));
    	
    	model.addAttribute("totalPrice", cart.getTotalPrice());
    	model.addAttribute("products", cart.getProducts());
    	
    	session.setAttribute("cart", cart);
    	
    	return "cartSummary";
    }
    
    @RequestMapping(value="/cart/clearCart")
    public String clearCart(Model model, HttpSession session) {
    	ShoppingCart cart = (ShoppingCart)session.getAttribute("cart");
    	
    	cart.clearCart();
    	
    	model.addAttribute("totalPrice", cart.getTotalPrice());
    	model.addAttribute("products", cart.getProducts());
    	
    	session.setAttribute("cart", cart);
    	
    	return "cartSummary";
    }
    
    @RequestMapping(value="/cart") 
    public String showCart(Model model, HttpSession session) {
    	try {
    	ShoppingCart cart = (ShoppingCart)session.getAttribute("cart");
    	
    	model.addAttribute("totalPrice", cart.getTotalPrice());
    	model.addAttribute("products", cart.getProducts());
    	}
    	catch(Exception ex) {
    		ex.printStackTrace();
    	}
    	return "cartSummary";
    }
    
    @RequestMapping(value="/cart/remove/{productId}")
    public String removeXItems(Model model, HttpSession session, @PathVariable("productId") String productId, 
    		@ModelAttribute("qty")String qty) {
    	ShoppingCart cart = (ShoppingCart) session.getAttribute("cart");
    	
    	cart.removeXProducts(Integer.parseInt(productId), Integer.parseInt(qty));
    	
    	model.addAttribute("products", cart.getProducts());
    	model.addAttribute("totalPrice", cart.getTotalPrice());
    	
    	return "cartSummary";
    }
    
    @RequestMapping(value="/checkout", method=RequestMethod.GET) 
    public String checkout(Model model, HttpSession session) {
    	
    	return "checkout";
    }
    
    @RequestMapping(value="/checkout", method=RequestMethod.POST)
    public String submitCheckout(Model model, HttpSession session, @ModelAttribute("firstName")String firstName, 
    		@ModelAttribute("lastName")String lastName, @ModelAttribute("address")String address) {
    	
    	Authentication auth = SecurityContextHolder.getContext().getAuthentication();
    	String username = auth.getName();
    	
    	BuyerInfo buyerInfo = new BuyerInfo(firstName, lastName, address, username);
    	
    	purchaseService.writePurchase((ShoppingCart)session.getAttribute("cart"), buyerInfo);
    	
    	ShoppingCart cart = (ShoppingCart)session.getAttribute("cart");
    	cart.clearCart();
    	
    	return this.showIndex(model, session);
    }
    
    @RequestMapping(value="/logout", method=RequestMethod.GET)
    public String logoutFromPage(HttpServletRequest request, HttpServletResponse response, Model model, HttpSession session) {
    	
    	Authentication auth = SecurityContextHolder.getContext().getAuthentication();
    	if(auth != null) {
    		new SecurityContextLogoutHandler().logout(request, response, auth);
    	}
    	
    	return "redirect:/index";
    }
    
    @RequestMapping(value="/history", method=RequestMethod.GET)
    public String viewHistory(Model model) {
    	
    	ArrayList<Purchase> purchases = purchaseService.readAllPurchases();
    	
    	model.addAttribute("purchases", purchases);
    	
    	return "history";
    }
}
