using Microsoft.AspNetCore.Identity;
using System;


namespace WebStore.Model.DataModels
{
    public class Customer : User
    {
        public virtual Address BillingAddress { get; set; } = default!;

        public virtual Address ShippingAddress { get; set; } = default!;

        public virtual IList<Order> Orders { get; set; } = default!;

    }
}