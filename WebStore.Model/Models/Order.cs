using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.Models;

public class Order
{
    [ForeignKey("Customer")]
    public int? CustomerId { get; set; }
    public virtual Customer Customer {get; set;} = default!;
    public DateTime DeliveryDate {get; set;} = default!;
    [Key]
    public int Id {get; set;} = default!;
    public DateTime OrderDate {get; set;} = default!;
    [NotMapped]
    public decimal TotalAmount {get; set;} = default!;
    public long TractingkNumber {get; set;} = default!;  
    [ForeignKey("Invoice")]
    public int InvoiceId { get; set; }
    public virtual Invoice Invoice { get; set; } = default!;
    public  virtual IList<OrderProduct> OrderProducts { get; set; } = default!;
}
