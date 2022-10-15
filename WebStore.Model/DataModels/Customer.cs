using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Customer : User
    {
        public string BillingAddress { get; set; }
        public IList<Order> Orders { get; set; }
        public string ShippingAddress { get; set; }
    }
}