using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels;

public class Customer : User
{
    public Address BillingAddress { get; set; }
    public virtual IList<Order> Orders { get; set; }
    public Address ShippingAddress { get; set; }
    public virtual IList<Address> Addresses { get; set; }
    
}
