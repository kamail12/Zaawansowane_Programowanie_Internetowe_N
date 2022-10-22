namespace WebStore.Model.Models;
public class BillingAddress : Address
{
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; } = default!;
}
