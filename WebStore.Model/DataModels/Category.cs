using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModels;

public class Category
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = default!;
}
