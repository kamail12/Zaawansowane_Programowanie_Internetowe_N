namespace WebStore.Model;

public class Customer : User
{
    public string BillingAddres { get; set; } = default!;  
    public virtual IList<Order> Orders { get; set; } = default!;  
    public string sShippingAddress { get; set; } = default!;  
}