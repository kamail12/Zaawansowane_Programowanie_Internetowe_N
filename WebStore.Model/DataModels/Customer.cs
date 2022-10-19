using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class Customer : User
    {
        public virtual Address BillingAddress { get; set; } = default!;
        [ForeignKey("BillingAdress")]
        public int? BillingAddressId { get; set; }
        public virtual IList<Order> Orders { get; set; } = default!;

        public int? OrderId { get; set; }
        public virtual Address ShippingAddress { get; set; } = default!;
        [ForeignKey("ShippingAddress")]
        public int? ShippingAddressId { get; set; }
    }
}