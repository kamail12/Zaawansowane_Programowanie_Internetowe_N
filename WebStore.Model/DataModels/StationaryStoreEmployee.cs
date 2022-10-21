using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels;

public class StationaryStoreEmployee : User
{
    [Column(TypeName = "decimal(18,2)")]
    public decimal Salary { get; set; }
    public DateTime Employment { get; set; }
    public string JobLevel { get; set; } = default!;
    public virtual StationaryStore Store { get; set; } = default!;
    [ForeignKey("Store")]
    public int? StoreId { get; set; }

}
