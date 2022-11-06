namespace Webstore.Model;

public class OrderProduct {
    public Order Order {get; set;} = default!;
    public virtual Product Product {get; set;} = default!;
    public int Quantity  {get; set;}
    public int? OrderId {get; set;}
    public int? ProductId {get; set;}
}