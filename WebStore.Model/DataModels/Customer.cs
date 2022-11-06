namespace Webstore.Model;

public class Customer : User {
    
    public string BillingAddress {get; set;} = default!;
    
    // Relation one to many Customer => Order
    public virtual IList<Order> Orders {get; set;} = default!;    
    
    public string ShippingAdress {get; set;} = default!;
}