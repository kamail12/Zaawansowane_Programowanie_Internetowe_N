using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Order
{
   public Customer Customer {get; set;} = default!;
   public int? CustomerId { get; set; }
   public DateTime DeliveryDate {get; set;}  
   public DateTime OrderDate {get; set;}
   public decimal TotalAmount {get; set;} 
   public Invoice Invoice {get; set; } = default!;
   public int? Invoiceid {get; set;} = default!;

}