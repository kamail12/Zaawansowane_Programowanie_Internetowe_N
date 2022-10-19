using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class StationaryStore
{
   public Address StoreAddress {get; set;} = default!;
}