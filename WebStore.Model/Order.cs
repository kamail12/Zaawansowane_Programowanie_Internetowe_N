using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class Order
{
   public Customer Customer {get; set;} = default!;
   public DateTime DeliveryDate {get; set;} = default!;
   public int Id {get; set;} = default!;
   public DateTime OrdareDate {get; set;} = default!;
   public decimal TotalAmount {get; set;} = default!;
   public Invoice Invoice {get; set;} = default!;

}