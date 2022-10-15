namespace WebStore.Model.DataModel;

public class StationaryStore
{
    public IList<Customer> Customers { get; set; } = default!;

    public IList<Address> Address { get; set; } = default!;

}
