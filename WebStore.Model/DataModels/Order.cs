using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Order
{
   public Customer Customer {get; set;} = default!;
   public int Id {get; set;}
   public decimal TotalAmount {get; set;} 
   public Invoice Invoice { get; set; } = default!;

}