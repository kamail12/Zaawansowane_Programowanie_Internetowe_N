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
        public int StationaryStoreId { get; set; }
        public virtual StationaryStore StationaryStore { get; set; } = default!;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
    }
}