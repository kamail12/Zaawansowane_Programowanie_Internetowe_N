using System.ComponentModel.DataAnnotations;

namespace WebStore.Model.DataModels;

public class OrderProduct
{
    [Key]
    public int Id { get; set; }
    public virtual Order Order { get; set; } = default!;
    public virtual Product Product { get; set; } = default!;
    public int Quantity { get; set; }
    public int OrderId { get; set; }
}
