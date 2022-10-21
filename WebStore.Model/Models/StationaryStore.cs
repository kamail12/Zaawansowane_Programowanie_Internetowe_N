using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class StationaryStore
    {
        public int Id { get; set; }
        public virtual IList<Order> Orders { get; set; } = default!;
        public virtual IList<ProductStock> ProductStocks { get; set; } = default!;
        public virtual IList<StationaryStoreEmployee> StationaryStoreEmployees { get; set; } = default!;
        public virtual IList<StationaryStoreAddress> StationaryStoreAddresses { get; set; } = default!; 
    }
}