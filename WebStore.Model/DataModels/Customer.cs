using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels;

public class Customer : User
{
    public virtual Address BillingAddres { get; set; }
    public virtual IList<Order> Orders { get; set; }
    public virtual Address ShippingAddress { get; set; }
    
}
