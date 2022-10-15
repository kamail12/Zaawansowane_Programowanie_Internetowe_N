using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Address
{
    public Customer Customer {get; set;} = default!;
    public int CustomerId {get; set;}
   public string NazwaUlicy {get; set;} = default!;
   public string Miasto {get; set;} = default!;
   public string Miejscowosc {get; set;} = default!;
   public string kodPocztowy {get; set;} = default!;

    public StationaryStore StationaryStore {get; set;} = default!;
    public int StationaryStoreId {get; set; } 

}