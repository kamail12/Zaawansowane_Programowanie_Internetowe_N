using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee : User
    {
        [ForeignKey("StationaryStore")]
        public int StationaryStoreId { get; set; }
        public virtual StationaryStore StationaryStore { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Pay { get; set; }
        
    }
}