namespace Webstore.Model;

public class Supplier : User {
    public IList<Product> Products {get; set;} = default!;
}