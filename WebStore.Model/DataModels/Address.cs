using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModels
{
    public class Address
    {
        public string Country { get; set; } = default!;
        public string City { get; set; } = default!;
        public int BuildingNumber { get; set; }
        public string PostalCode { get; set; } = default!;
    }
}