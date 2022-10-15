using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class StationaryStore
{
   public Address Address {get; set;} = default!;
   public IList<Order> Orders {get; set;} = default!;
   public StationaryStoreEmployee numerUmowy {get; set;} = default!;
   public IList<Address> Addresses {get; set;} = default!;
   public IList<StationaryStoreEmployee> StationaryStoreEmployees {get; set; } = default!;
}