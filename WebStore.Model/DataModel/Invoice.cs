using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModel;

public class Invoice
{
    public int InvoiceId { get; set; }
    
    [NotMapped]
    // Why store total amount on DB level? Let's try to calculate this based on orders.
    public decimal TotalAmount => Orders == null ? 0 :
                                   Orders.Sum(ord => ord.TotalAmount); 
    public DateTime InvoiceDate { get; set; }
    public virtual IList<Order> Orders { get; set; } = default!;
}
