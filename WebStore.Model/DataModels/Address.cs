using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Address
    {
        public string? Conutry { get; set; }
        public string? City { get; set; }
        public int PostCode { get; set; }
        public string? Street { get; set; }
        public int BuildingNumber { get; set; }
    }

}