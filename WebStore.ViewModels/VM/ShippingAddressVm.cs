using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels.VM
{
    public class ShippingAddressVm : AddressVm
    {
        public int StationaryStoreId { get; set; }
        public virtual StationaryStoreVm StationaryStore { get; set; } = default!;
    }
}