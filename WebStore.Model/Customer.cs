namespace WebStore.Model;

public class Customer : User
{
    public virtual Address BillingAddres { get; set; }
    public virtual IList<Order> Orders { get; set; }
    public virtual Address sShippingAddress { get; set; }
}
