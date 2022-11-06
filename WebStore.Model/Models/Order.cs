using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class Order
    {
        public Customer Customer { get; set; } = default!;
        public DataTime DeliveryDate { get; set; } = default!;
        public int Id { get; set; } = default!;
        public DataTime OrderDate { get; set; } = default!;
        public decimal TotalAmount { get; set; } = default!;
        public long TrackingNumber { get; set; } = default!;
    }
}