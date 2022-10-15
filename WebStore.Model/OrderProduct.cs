using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class OrderProduct
{
   public Order Order {get; set;} = default!;
   public Product Product {get; set;} = default!;
   public int Quantity {get; set;} = default!;
}