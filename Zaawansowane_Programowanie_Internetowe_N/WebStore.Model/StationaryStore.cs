namespace WebStore.Model;

public class StationaryStore
{
    public int Id { get; set; }
    public virtual IList<Customer> Customers { get; set; } = default!;
    public virtual IList<Order> Orders { get; set; } = default!;
    public virtual IList<Address> Addresses { get; set; } = default!;
    public virtual IList<Product> Products { get; set; } = default!;
    public virtual IList<StationaryStoreEmployee> StationaryStoreEmployees { get; set; } = default!;
}
