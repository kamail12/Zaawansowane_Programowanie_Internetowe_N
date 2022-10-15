using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class User
{
   public String FirstName {get; set;} = default!;
   public String LastName {get; set;} = default!;
   public DateTime RegistrationDate {get; set;} = default!;
}