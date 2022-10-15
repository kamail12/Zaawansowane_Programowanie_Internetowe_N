namespace WebStore.Model.DataModel;

public class Supplier : User
{
    public IList<Product> Products { get; set; } = default!;
}
