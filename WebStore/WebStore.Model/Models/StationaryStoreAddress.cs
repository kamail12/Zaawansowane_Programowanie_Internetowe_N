namespace WebStore.Model.Models;
public class StationaryStoreAddress : Address
{
    public int StationaryStoreId { get; set; }
    public virtual StationaryStore StationaryStore { get; set; } = default!;
}
