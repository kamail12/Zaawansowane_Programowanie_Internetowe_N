using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels
{
    public class Address
    {
        public Customer Customer { get; set; }
        public StationaryStore StationaryStore { get; set; }
    }
}