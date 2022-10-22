using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels;

public class OrderProduct
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public Order Order { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}
