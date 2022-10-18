using System.ComponentModel.DataAnnotations;

namespace WebStore.Model.DataModel;

public class OrderProduct : Order
{
    public virtual Order Order { get; set; } = default!;
    public virtual Product Product { get; set; } = default!;
    public int Quantity { get; set; }
}
