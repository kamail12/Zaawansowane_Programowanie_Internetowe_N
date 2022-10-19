using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace WebStore.Model.DataModel
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        // Register with current timeStamp
        public DateTime RegistrationDate { get; set; } = DateTime.Now;


    }
}