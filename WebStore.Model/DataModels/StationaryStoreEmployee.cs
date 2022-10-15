using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class StationaryStoreEmployee
{
   public int numerUmowy {get; set;} 
   public DateTime Zatrudnienie {get; set;} 
   public string Stanowisko {get; set;} = default!;
   public string Wynagrodzenie {get; set;} = default!;
   public StationaryStore StationaryStore {get; set;} = default!;
   public int? StationaryStoreId {get; set;} = default!;
    

}