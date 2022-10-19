using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Address
    {
        public int CustomerId {get; set;}
        public string StreetName {get; set;} = default!;
        public int StreetNumber {get; set;} = default!;
        public string City {get; set;} = default;
        public string PostCode {get; set;} = default;

    }
}