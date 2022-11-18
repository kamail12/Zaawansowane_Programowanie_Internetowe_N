using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        public int Id { get; set; } = default!;
        
        public decimal TotalAmount { get; set; } = default!;

        public virtual Customer Customer { get; set; } = default!;

        public virtual IList<Order> Orders { get; set;} = default!;
    }
}