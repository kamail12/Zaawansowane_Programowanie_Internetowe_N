namespace WebStore.Model.DataModels;

public class Customer
{
    public string BillingAddress { get; set; }
    public IList<Order> Orders { get; set; }
    public string ShippingAddress { get; set; }
}
