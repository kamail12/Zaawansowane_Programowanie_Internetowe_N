namespace WebStore.Model;

public class OrderProduct
{
    public virtual Order Order { get; set; } = default!; 
    public int OrderId { get; set; }
    public virtual Product Product { get; set; } = default!;
    public int ProductId { get; set; }
    public int Quantity { get; set; } = default!;
}
