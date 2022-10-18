using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModel {
    public class Customer : User {

        public virtual Address? BillingAddress { get; set; }

        [ForeignKey ("BillingAddress")]
        public int? BillingAddressId { get; set; }
        public virtual IList<Order> Orders { get; set; } = default !;

        public virtual Address ShippingAddress { get; set; } = default !;
        [ForeignKey ("ShippingAddress")]
        public int ShippingAddressId { get; set; }

    }
}