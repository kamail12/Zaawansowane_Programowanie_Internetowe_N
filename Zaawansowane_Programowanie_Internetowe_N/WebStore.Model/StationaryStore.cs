namespace WebStore.Model;

public class StationaryStore
{
    public IList<Customer> Customers { get; set; } = default!;
    public IList<Order> Orders { get; set; } = default!;
    public Address Address { get; set; } = default!;
    public IList<Product> Products { get; set; } = default!;
}
