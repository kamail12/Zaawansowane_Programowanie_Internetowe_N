using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class Customer
{
   public Adress BillingAddress {get; set;} = default!;
   public IList<Order> Orders {get; set;} = default!;
   public Adress ShippingAddress {get; set;} = default!;

}
