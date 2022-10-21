using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModels;

public class Invoice
{
    [Key]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public virtual IList<Order> Orders { get; set; } = default!;
    public virtual Customer IssuedFor { get; set; } = default!;
}
