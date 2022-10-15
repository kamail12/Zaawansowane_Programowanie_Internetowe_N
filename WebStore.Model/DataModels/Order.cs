using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Order
{
   public Customer Customer {get; set;} 
   public DateTime DeliveryDate {get; set;} 
   public int itd {get; set;} 
   public DateTime OrdareDate {get; set;}
   public decimal TotalAmount {get; set;} 

}