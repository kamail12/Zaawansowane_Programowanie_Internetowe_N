namespace WebStore.Model;

public class ProductStock
{
    public virtual Product Product { get; set; } = default!;
    public int Id { get; set; }
    public int Quantity { get; set; } = default!;
}
