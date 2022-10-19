using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Customer
{
   public Address BillingAddress {get; set;} = default!;
   public IList<Order> Orders {get; set;} = default!;
   public Address ShippingAddress {get; set;} = default!;
}