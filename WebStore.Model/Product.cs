namespace WebStore.Model;

public class Product
{
    public virtual Category Category { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int Id { get; set; }
    public byte[] ImageBytes { get; set; } = default!;
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public virtual Supplier Supplier { get; set; } = default!;
    public float Weight { get; set; }


}
