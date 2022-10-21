namespace WebStore.Model.DataModels;

public class Customer
{
    public Address BillingAddress { get; set; }
    public IList<Order> Orders { get; set; }
    public Address ShippingAddress { get; set; }
}
