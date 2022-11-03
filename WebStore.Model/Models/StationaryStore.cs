using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Model.Models
{
    public class StationaryStore
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public virtual IList<Order> Orders { get; set; } = default!;
        public virtual IList<ProductStock> ProductStocks { get; set; } = default!;
        public virtual IList<StationaryStoreEmployee> StationaryStoreEmployees { get; set; } = default!;
        public virtual IList<StationaryStoreAddress> StationaryStoreAddresses { get; set; } = default!;
    }
}