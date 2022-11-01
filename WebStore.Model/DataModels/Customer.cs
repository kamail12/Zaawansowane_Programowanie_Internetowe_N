using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Customer : User
    {
        public Address BillingAddress { get; set; }

        public Address ShippingAddress { get; set; }

        virtual public IList<Order> Orders { get; set; }

    }
}