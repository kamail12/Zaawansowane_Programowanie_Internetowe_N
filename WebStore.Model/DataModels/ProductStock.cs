using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels;

public class ProductStock
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    [ForeignKey("Product")]
    public int ProductId { get; set; }
}
