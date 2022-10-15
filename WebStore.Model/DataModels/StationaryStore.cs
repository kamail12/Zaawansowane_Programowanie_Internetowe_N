using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class StationaryStore
{
   public Address Address {get; set;} 
   public IList<Order> Orders {get; set;} 
   public StationaryStoreEmployee numerUmowy {get; set;} 
}