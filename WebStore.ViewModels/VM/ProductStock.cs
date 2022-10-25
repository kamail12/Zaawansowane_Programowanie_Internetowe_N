namespace WebStore.ViewModels.VM;
public class ProductStockVm
{
    public virtual OrderVm Order {get; set;} = default!;
    public int OrderId {get; set; } = default!;
    public int Quantity { get; set; }
    public int ProductId { get; set; }
    public ProductVm Product { get; set; } = default!;
}