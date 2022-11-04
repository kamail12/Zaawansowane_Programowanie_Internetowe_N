using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.Models;


public class Customer : User
{
    public virtual Address? BillingAddresses { get; set; } = default!;
    [ForeignKey("BillingAddress")]
    public int? BillingAddress { get; set; }
    public virtual IList<Order> Orders { get; set; } = default!;
    public virtual IList<Address> Addresses { get; set; } = default!;
    public virtual Address? ShippingAddresses { get; set; } = default!;
    [ForeignKey("ShippingAddress")]
    public int? ShippingAddress { get; set; }
}