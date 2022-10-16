namespace WebStore.Model;

public class StationaryStore
{
    public virtual Address Address { get; set; }
    public virtual IList<StationaryStoreEmployee> Employees { get; set; }
}
