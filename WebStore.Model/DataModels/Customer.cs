using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels;

public class Customer : User
{
    public virtual Address BillingAddres { get; set; } = default!;
    [ForeignKey("BillingAddress")]
    public int? BillingAddressId { get; set; }
    public virtual IList<Order> Orders { get; set; } = default!;
    public virtual Address sShippingAddress { get; set; } = default!;
    public virtual Address ShippingAddress { get; set; } = default!;
    [ForeignKey("ShippingAddress")]
    public int? ShippingAddressId { get; set; }
}
