using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Customer : User
    {
        public Address BillingAddress { get; set; } = default!;

        public Address ShippingAddress { get; set; } = default!;

        virtual public IList<Order> Orders { get; set; } = default!;

    }
}