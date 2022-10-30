using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.Models;

public class ProductStock
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public virtual Product Product {get; set;} = default!;
    public int StationaryStoreId {get; set;}
    public virtual StationaryStore StationaryStore { get; set; } = default!;
    public int Quantity {get; set;} = default!;
}
