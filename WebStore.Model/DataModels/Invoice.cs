using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public virtual IList<Order> Orders { get; set; } = default!;
        [ForeignKey("ShippingAddress")]
        public int? OrderId { get; set; }

    }
}