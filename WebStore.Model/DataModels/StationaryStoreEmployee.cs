using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee : User
    {
        public decimal Pay { get; set; }
        public DateTime Employment { get; set; }
        public string Title { get; set; }
        public virtual StationaryStore Store { get; set; }
        [ForeignKey("Store")]
        public int StoreId { get; set; }
    }
}