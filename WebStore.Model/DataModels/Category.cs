using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModels
{
    public class Category
    {
        //Properties fo relation 'One-to-Many' - 'Category-to-Product'
        public virtual IList<Product>Products {get; set;} = default!;

        //Model properties
        [Key]
        public int? Id {get; set;}
        public string Name {get; set;} = default!;
        
    }
}