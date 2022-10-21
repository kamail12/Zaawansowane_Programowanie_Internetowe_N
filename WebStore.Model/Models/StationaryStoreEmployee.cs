using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class StationaryStoreEmployee : User
    {
        public int StoreId { get; set; }
        public virtual StationaryStore Store {get; set;} = default!;
        public decimal Salary {get; set;}
    }
}