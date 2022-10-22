using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        public Order Order { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}