using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModel
{
    public class StationaryStoreAddress : Address
    {
        public int StationaryStoreId { get; set; }
        public virtual StationaryStore StationaryStore { get; set; } = default!;
    }
}