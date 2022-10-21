using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace WebStore.Model.DataModels;

public class User : IdentityUser<int>
{
    public override int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    // Register with current timeStamp
    public DateTime RegistrationDate { get; set; } = DateTime.Now;


}
