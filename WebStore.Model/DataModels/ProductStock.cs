namespace Webstore.Model;

public class ProductStock {
    public Product Product {get; set;} = default!;
    public int Quantity {get; set;}
}