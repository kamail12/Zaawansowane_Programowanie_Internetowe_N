using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee : User
    {
        public string Position { get; set; } = default!;

        public virtual StationaryStore StationaryStore { get; set; } = default!;
        [ForeignKey("StationaryStore")]
        public int? StationaryStoreId { get; set; }

        public float Salary { get; set; } = default!;
    }
}