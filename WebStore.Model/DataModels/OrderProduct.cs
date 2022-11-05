namespace Webstore.Model;

public class OrderProduct {
    public Order Order {get; set;} = default!;
    public Product Product {get; set;} = default!;
    public int Quantity  {get; set;}
}