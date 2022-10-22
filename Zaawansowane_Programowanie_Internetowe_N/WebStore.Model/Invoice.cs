using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model;

public class Invoice
{
    public int Id { get; set; }
    public DateTime DeliveryDate { get; set; } = default!;
    public DateTime OrderDate { get; set; } = default!;

    [NotMapped]
    public decimal TotalAmount => Orders.SelectMany(o => o.OrderProducts.Select(op => op.Product)).Sum(p => p.Price);

    public virtual IList<Order> Orders { get; set; } = default!;
}
