namespace WebStore.Model;

public class Category
{
    public int Id { get; set; }
    public string Type { get; set; } = default!;
    public string Name { get; set; } = default!;
    public virtual IList<Product> Products { get; set; } = default!;
}
