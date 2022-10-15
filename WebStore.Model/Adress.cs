using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class Adress
{
   public string NazwaUlicy {get; set;} = default!;
   public string Miasto {get; set;} = default!;
   public string Miejscowosc {get; set;} = default!;
   public string kodPocztowy {get; set;} = default!;

}