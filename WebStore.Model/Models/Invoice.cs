using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public virtual IList<Order> Orders { get; set; } = default!;
    }
}