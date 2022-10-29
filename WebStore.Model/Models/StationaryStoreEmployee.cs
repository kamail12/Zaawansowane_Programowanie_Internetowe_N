using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class StationaryStoreEmployee : User
    {
        [ForeignKey("StationaryStore")]
        public int StoreId { get; set; }
        public virtual StationaryStore Store {get; set;} = default!; 
        public decimal Salary {get; set;}
    }
}