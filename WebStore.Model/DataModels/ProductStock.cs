using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class ProductStock
{
    public Product Product {get; set;}
    public int Quantity {get; set;} 
}