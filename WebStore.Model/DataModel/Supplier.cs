namespace WebStore.Model.DataModel;

public class Supplier : User
{
    public virtual IList<Product> Products { get; set; } = default!;
}
