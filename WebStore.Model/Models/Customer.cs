using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class Customer : User
    {
     public string BilingAddress { get; set; } = default!;
     public IList<Order> Orders { get; set; } = default!;
     public string ShippingAddress { get; set; } = default!;
    }
}