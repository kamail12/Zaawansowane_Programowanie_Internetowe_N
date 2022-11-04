using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee : User
    {
        public string Title { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Pay { get; set; }
        public virtual StationaryStore Store { get; set; }
        [ForeignKey("Store")]
        public int StoreId { get; set; }
    }
}