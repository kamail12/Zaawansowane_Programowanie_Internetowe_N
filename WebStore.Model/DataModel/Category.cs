using System.ComponentModel.DataAnnotations;

namespace WebStore.Model.DataModel;

public class Category
{

    public int CategoryId { get; set; }
    public string CategoryType { get; set; } = default!;
    public string CategoryName { get; set; } = default!;
    public virtual IList<Product> Products { get; set; } = default!;

}