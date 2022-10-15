namespace WebStore.Model;
public class User
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateTime RegistrationDate { get; set; } = default!;

}


public class Order {
    Customer: Customer { get; set; }
    public DateTime DeliveryDate { get; set; }
    public int id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public long TrackingNumber { get; set; }
}
