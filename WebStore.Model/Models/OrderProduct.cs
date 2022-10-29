using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.Models;

public class OrderProduct
{
    [ForeignKey("Order")]
    public int OrderId { get; set; }
    public virtual Order Order {get; set;} = default!;
    
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public virtual Product Product {get; set;} = default!;
    public int Quantity {get; set;} = default!;
}
