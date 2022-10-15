using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModels
{
    public class Customer : User
    {
        public Address BillingAddress { get; set; } = default!;
        public IList<Order> Orders { get; set; } = default!;
        public Address ShippingAddress { get; set; } = default!;

    }
}