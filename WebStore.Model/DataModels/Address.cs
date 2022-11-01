 using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Address
    {
        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public string BuildingNumber { get; set; }

        public string ApartmentNumber { get; set; }


        public Address()
        {
            City = "brak";
            ZipCode = "brak";
            Street = "brak";
            StreetNumber = "brak";
            BuildingNumber = "brak";
            ApartmentNumber = "brak";
        }
    }
}