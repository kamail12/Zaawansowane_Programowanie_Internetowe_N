namespace WebStore.Model.Models;

public class Order
{
    public virtual Customer Customer {get; set;} = default!;
    public DateTime DeliveryDate {get; set;} = default!;
    public int Id {get; set;} = default!;
    public DateTime OrderDate {get; set;} = default!;
    public decimal TotalAmount {get; set;} = default!;
    public long TractingkNumber {get; set;} = default!;  
    public int InvoiceId { get; set; }
    public virtual Invoice Invoice { get; set; } = default!;
    public  virtual IList<OrderProduct> OrderProducts { get; set; } = default!;
}
