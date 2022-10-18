using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Category
{
   public string Damper {get; set;} = default!;
   public string Tires {get; set;} = default!;
   public string Batteries {get; set;} = default!;
   public string SparkPlugs {get; set;} = default!;

   public IList<Product> Products {get; set; }  = default!;

}