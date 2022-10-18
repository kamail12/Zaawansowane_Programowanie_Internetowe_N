using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModel;

public class StationaryStoreEmployee : Supplier
{
    public int agreementNumber { get; set; }
    public DateTime Employment { get; set; }
    public string JobLevel { get; set; } = default!;
    public string Salary { get; set; } = default!;
    public virtual StationaryStore StationaryStore { get; set; } = default!;
    [ForeignKey("StationaryStoreId")]
    public int StationaryStoreId { get; set; } = default!;
}
