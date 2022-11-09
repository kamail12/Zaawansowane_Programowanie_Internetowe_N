namespace Webstore.Model;

public class Supplier : User {
   //Relation One to many Supplier => Product
    public virtual IList<Product> Products {get; set;} = default!;
}