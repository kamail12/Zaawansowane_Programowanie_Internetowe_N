namespace WebStore.Model;

public class Customer : User
{
    public virtual Address BillingAddres { get; set; } = default!;
    public virtual IList<Order> Orders { get; set; } = default!;
    public virtual Address sShippingAddress { get; set; } = default!;
}
