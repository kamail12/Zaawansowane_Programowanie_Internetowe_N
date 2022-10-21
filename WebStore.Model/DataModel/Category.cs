using System.ComponentModel.DataAnnotations;

namespace WebStore.Model.DataModel;

public class Category
{

    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Tag { get; set; } = default!;
    public virtual IList<Product> Products { get; set; } = default!;

}
