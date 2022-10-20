namespace WebStore.Model;

public class Order
{
    public virtual Customer Customer { get; set; } = default!;
    public DateTime DeliveryDate { get; set; }
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; }
    public long TrackingNumber { get; set; }
    public int InvoiceID { get; set; }
}
