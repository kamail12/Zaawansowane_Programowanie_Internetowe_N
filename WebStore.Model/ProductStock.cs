using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class ProductStock
{
    public Product Product {get; set;} = default!;
    public int Quantity {get; set;} = default!;
}