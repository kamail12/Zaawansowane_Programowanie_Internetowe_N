namespace WebStore.Model.Models;

public class Product
{
    public string Description {get; set;} = default!;
    public int Id {get; set; } = default!;
    public byte[] ImageBytes {get; set;} = default!;
    public string Name {get; set;} = default!;
    public decimal Price {get; set;} = default!;
    public virtual Supplier Supplier {get; set;} = default!;
    public int SupplierId { get; set; }
    public float Weight {get; set;} = default!;

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = default!;

    public virtual IList<ProductStock> ProductStocks { get; set; } = default!;
}
