namespace Webstore.Model;

public class Customer : User {
    public string BillingAddress {get; set;}
    public IList<Order> Orders{get; set;}
    public string ShippingAdress {get; set;}
}