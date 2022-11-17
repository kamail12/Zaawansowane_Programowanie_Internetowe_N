using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels.VM
{
    public class AddressVm
    {
        public string City { get; set; } = default!;

        public string ZipCode { get; set; } = default!;

        public string Street { get; set; } = default!;

        public string StreetNumber { get; set; } = default!;

        public string BuildingNumber { get; set; }= default!;

        public string ApartmentNumber { get; set; }= default!;

    }
}