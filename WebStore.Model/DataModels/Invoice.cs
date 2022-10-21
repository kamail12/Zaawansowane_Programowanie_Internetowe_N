using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels;

public class Invoice
{
    public int InvoiceId { get; set; }
    
    [NotMapped]
    public decimal TotalAmount => Orders == null ? 0 : Orders.Sum(ord => ord.TotalAmount); 
    public DateTime InvoiceDate { get; set; }
    public virtual IList<Order> Orders { get; set; } = default!;
}