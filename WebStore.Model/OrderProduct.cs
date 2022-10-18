namespace WebStore.Model;

public class OrderProduct
{
    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
    public int Quantity { get; set; }
}
