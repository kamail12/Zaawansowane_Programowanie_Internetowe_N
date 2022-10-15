namespace WebStore.Model;

public class Customer : User
{
    public string BillingAddres { get; set; }
    public IList<Order> Orders { get; set; }
    public string ShippingAddress { get; set; }
}
