namespace WebStore.Model.DataModel;

public class StationaryStoreEmployee : Supplier
{
    public IList<Address> Address { get; set; } = default!;
}
