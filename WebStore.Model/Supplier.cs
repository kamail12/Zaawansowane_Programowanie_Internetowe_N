using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class Supplier
{
   public IList<Product> Products {get; set;} = default!;
}