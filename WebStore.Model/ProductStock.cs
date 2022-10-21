namespace WebStore.Model;
public class ProductStock
{
    virtual public Product Product {get; set;} = default!;
    public int Quantity {get; set;} = default!;
}
