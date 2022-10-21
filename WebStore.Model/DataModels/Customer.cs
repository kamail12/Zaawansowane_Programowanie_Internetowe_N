using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels;

public class Customer : User
{
    public virtual Address? BillingAddress { get; set; }

    [ForeignKey("BillingAddress")]
    public int? BillingAddressId { get; set; }
    public virtual IList<Order> Orders { get; set; } = default!;
    public virtual Address ShippingAddress { get; set; } = default!;
    [ForeignKey("ShippingAddress")]
    public int? ShippingAddressId { get; set; }

}