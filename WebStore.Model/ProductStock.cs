namespace WebStore.Model;

public class ProductStock
{
    public virtual Product Product { get; set; }
    public int Quantity { get; set; }
}
