namespace Webstore.Model;

public class Customer : User {
    public string BillingAddress {get; set;} = default!;
    public IList<Order> Orders{get; set;} = default!;
    public string ShippingAdress {get; set;} = default!;
}