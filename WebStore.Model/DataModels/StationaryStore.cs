using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        [Key]
        public int Id { get; set; }
        public virtual Address Address { get; set; }
        public virtual IList<StationaryStoreEmployee> Employees { get; set; }
        public virtual IList<Invoice> Invoices { get; set;}
    }
}
