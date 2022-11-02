 using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Address
    {
        public virtual Customer Customer { get; set; } = default!;

        public string City { get; set; } = default!;

        public string ZipCode { get; set; } = default!;

        public string Street { get; set; } = default!;

        public string StreetNumber { get; set; } = default!;

        public string BuildingNumber { get; set; }= default!;

        public string ApartmentNumber { get; set; }= default!;


        /* public Address()
        {
            City = "brak";
            ZipCode = "brak";
            Street = "brak";
            StreetNumber = "brak";
            BuildingNumber = "brak";
            ApartmentNumber = "brak";
        } */
    }
}