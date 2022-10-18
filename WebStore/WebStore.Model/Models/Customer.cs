namespace WebStore.Model.Models;
public class Customer : User
{
    public int? BillingAddressId { get; set; } = default;
    public virtual BillingAddress BillingAddress { get; set; } = default!;
    public int? ShippingAddressId { get; set; }
    public virtual ShippingAddress ShippingAddress { get; set; } = default!;
    public virtual IList<Order> Orders { get; set; } = default!;
}