namespace WebStore.Model.DataModels;
public class Customer : User
{
    public string BillingAddress { get; set; } = default!;
    public virtual IList<Order> Orders { get; set; } = default!;
    public string ShippingAddress { get; set; } = default!;
}