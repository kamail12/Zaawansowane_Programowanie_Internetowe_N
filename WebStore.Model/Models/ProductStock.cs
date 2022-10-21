namespace WebStore.Model.Models;

public class ProductStock
{
    public int ProductId { get; set; }
    public virtual Product Product {get; set;} = default!;
    public int StationaryStoreId {get; set;}
    public virtual StationaryStore StationaryStore { get; set; } = default!;
    public int Quantity {get; set;} = default!;
}
