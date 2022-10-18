using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class StationaryStore
{
   public virtual Address Address {get; set;} = default!;
   public virtual IList<Order> Orders {get; set;} = default!;
   public StationaryStoreEmployee ArrangementNumber {get; set;} = default!;
   public virtual IList<Address> Addresses {get; set;} = default!;
   public virtual IList<StationaryStoreEmployee> StationaryStoreEmployees {get; set; } = default!;
}