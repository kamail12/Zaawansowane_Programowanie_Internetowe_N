using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class ProductStock
{
    public int? ProductId {get; set; }
    public Product Product {get; set;} = default!;
    public int Quantity {get; set;} 
}