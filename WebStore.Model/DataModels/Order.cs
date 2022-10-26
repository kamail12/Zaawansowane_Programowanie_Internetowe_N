using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels;

public class Order
{
    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    public DateTime DeliveryDate { get; set; }
    [Key]
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; }
    public long TrackingNumber { get; set; }
    public int InvoiceID { get; set;}
    [ForeignKey("Invoice")]
    public int InvoiceId { get; set; }
    public virtual IList<OrderProduct> OrderProducts { get; set; }
}
