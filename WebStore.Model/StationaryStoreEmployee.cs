using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model;

public class StationaryStoreEmployee : User
{
    public decimal Salary { get; set; }
    public DateTime Employment { get; set; }
    public string JobLevel { get; set; } = default!;
    public virtual StationaryStore Store { get; set; } = default!;
    [ForeignKey("Store")]
    public int? StoreId { get; set; }

}
