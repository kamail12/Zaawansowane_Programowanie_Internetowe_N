using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModel;

public class Invoice
{
    public int Id { get; set; }
    public decimal TotalPrice => Orders == null ? 0 :
                                   Orders.Sum(ord => ord.TotalPrice);
    public DateTime Date { get; set; }
    public virtual IList<Order> Orders { get; set; } = default!;
    public int StationaryStoreId { get; set; }
    public virtual StationaryStore StationaryStore { get; set; } = default!;
}
