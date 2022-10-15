using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Address
{
   public string NazwaUlicy {get; set;} 
   public string Miasto {get; set;} 
   public string Miejscowosc {get; set;} 
   public string kodPocztowy {get; set;} 

}