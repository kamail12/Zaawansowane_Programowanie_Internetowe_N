using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModels
{
    public class StationeryStoreEmployee : User
    {
        public DateTime EmploymentDate { get; set; }
        public string Position { get; set; } = default!;
        public virtual StationaryStore StationaryStore { get; set; } = default!;
        [ForeignKey("StationaryStoreEmployee")]
        public int StationaryStoreEmployeeId { get; set; }


    }
}