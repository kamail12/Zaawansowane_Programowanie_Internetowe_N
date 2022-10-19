namespace WebStore.Model.Models;
public class ShippingAddress : Address
{
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; } = default!;
}
