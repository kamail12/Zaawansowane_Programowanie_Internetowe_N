using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels;

public class StationaryStore : Order
{

    public virtual Address Address { get; set; } = default!;
    public virtual IList<Order> Orders { get; set; } = default!;

    public virtual StationaryStoreEmployee agreementNumber { get; set; } = default!;

    public virtual IList<Address> Addresses { get; set; } = default!;
    [NotMapped]
    public virtual IList<StationaryStoreEmployee> StationaryStoreEmployees { get; set; } = default!;

}
