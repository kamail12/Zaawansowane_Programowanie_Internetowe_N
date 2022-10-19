namespace WebStore.Model.DataModels;

public class Invoice
{
    public DateTime DeliveryDate { get; set; } = default!;
    public DateTime OrderDate { get; set; } = default!;
    public decimal TotalAmount { get; set; } = default!;
    public long TrackingNumber { get; set; } = default!;
    public IList<Order> Orders { get; set; } = default!;
}