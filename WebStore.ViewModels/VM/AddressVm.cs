using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels.VM
{
    public class AddressVm
    {
        public string Country { get; set; } = default!;
        public string City { get; set; } = default!;
        public int BuildingNumber { get; set; }
        public string PostalCode { get; set; } = default!;
    }
}