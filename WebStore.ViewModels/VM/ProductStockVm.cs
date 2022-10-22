using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModel;

public class ProductStockVm
{

    public int Id { get; set; }
    public int Quantity { get; set; }
    public int ProductId { get; set; }
    public virtual Product Product { get; set; } = default!;
}