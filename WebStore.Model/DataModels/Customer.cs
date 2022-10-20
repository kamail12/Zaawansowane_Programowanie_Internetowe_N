using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Customer : User
    {
        public virtual Address? ShippingAdress { get; set; }
        public virtual Address? BillingAddress { get; set; }
        public virtual IList<Order>? Orders { get; set; }
    }
}