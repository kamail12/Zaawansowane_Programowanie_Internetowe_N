namespace WebStore.Model.DataModels;
public class Product
{
    public int Id { get; set; }
    public string Category { get; set; } = default!;
    public string Description { get; set; } = default!;
    public byte[] ImageBytes { get; set; } = default!;
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public virtual Supplier Supplier { get; set; } = default!;
    public float Weight { get; set; } = default!;
}