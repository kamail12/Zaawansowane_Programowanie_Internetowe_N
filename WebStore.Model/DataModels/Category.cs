using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Category
{
   public string Amortyzatory {get; set;} = default!;
   public string Opony {get; set;} = default!;
   public string Akumulatory {get; set;} = default!;
   public string swieceZaplonowe {get; set;} = default!;

   public IList<Product> Products {get; set; }  = default!;

}