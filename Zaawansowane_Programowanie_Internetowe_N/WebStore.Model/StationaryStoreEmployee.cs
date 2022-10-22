using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model;

public class StationaryStoreEmployee : User
{
    public virtual StationaryStore StationaryStore { get; set; } = default!;
    [ForeignKey("StationaryStore")]
    public int StationaryStoreId { get; set; }
}
