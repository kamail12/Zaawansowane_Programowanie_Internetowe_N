using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        public decimal TotalAmount { get; set; }

        public Customer Customer { get; set; }
    }
}