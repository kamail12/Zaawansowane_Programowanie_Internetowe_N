using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Supplier : User
{
   public IList<Product> Products {get; set;} = default!;
}