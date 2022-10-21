namespace WebStore.Model;
public class Order
{
    public virtual Customer Customer {get; set;} = default!;
    public DateTime DeliveryDate {get; set;} = default!;
    public int Id {get; set;} = default!;
    public DateTime OrderDate {get; set;} = default!;
    public decimal TotalAmount {get; set;} = default!;
    public long TractingkNumber {get; set;} = default!;  
}
