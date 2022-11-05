using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        public decimal TotalAmount { get; set; } = default!;

        public Customer Customer { get; set; } = default!;

        public IList<Order> Orders { get; set;} = default!;
    }
}