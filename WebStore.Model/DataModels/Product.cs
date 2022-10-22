using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels;

public class Product
{
    public Category Category { get; set; }
    public string Description { get; set; }
    public int ProductId { get; set; }
    public byte[] ImageBytes { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Supplier Supplier { get; set; }
    public float Weight { get; set; }
    public virtual IList<ProductStock> ProductStocks { get; set; }
    public virtual IList<OrderProduct> OrderProducts { get; set; }
}
