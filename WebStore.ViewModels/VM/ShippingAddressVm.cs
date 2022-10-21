using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels.VM
{
    public class ShippingAddressVm : AddressVm
    {
        public int CustomerId { get; set; }
        public virtual CustomerVm Customer { get; set; } = default!;
    }
}