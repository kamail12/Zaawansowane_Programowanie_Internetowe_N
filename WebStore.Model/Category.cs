using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class Category
{
    public Order Order {get; set;} = default!;

    public OrderProduct OrderProduct {get; set;} = default!;

    public Product Product {get; set;} = default!;
}
