namespace WebStore.Model;

public class StationaryStore
{
    public virtual Address Address { get; set; } = default!;
    public virtual IList<StationaryStoreEmployee> Employees { get; set; } = default!;
}
