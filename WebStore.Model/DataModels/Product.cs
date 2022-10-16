using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels;

public class Product
{
   public Category Category {get; set;} = default!;
   [ForeignKey("Category")]
   public int CategoryId {get; set; } = default!;
   public string Description {get; set;} = default!;
   public int Id {get; set;} 
   public byte[] ImageBytes {get; set;} = default!;
   public string Name {get; set;} = default!;
   public decimal Price {get; set;} 
   public Supplier Supplier {get; set;} = default!;
   [ForeignKey("Supplier")]
   public int SupplierId {get; set; }
   public float Weight {get; set;} 
   
   
   public IList<ProductStock> ProductStocks {get; set;} = default!; 

   public IList<OrderProduct> OrderProducts {get; set;} = default!;

}