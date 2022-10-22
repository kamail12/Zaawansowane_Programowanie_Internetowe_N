using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels.VM
{
    public class BillingAddressVm : AddressVm
    {
        public int CustomerId { get; set; }
        public CustomerVm Customer { get; set; } = default!;
    }
}