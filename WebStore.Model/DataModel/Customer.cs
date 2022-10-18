using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModel
{
    public class Customer : User
    {
       
        public Address BillingAddress { get; set; } = default!;
        public virtual IList<Order> Orders { get; set; } = default!;
        public Address ShippingAddress { get; set; } = default!;
        public virtual IList<Address> Addresses { get; set; } = default!;

    }
}