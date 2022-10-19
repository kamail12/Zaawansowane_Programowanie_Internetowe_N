using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class OrderProduct : Order
    {
        public int ProductId { get; set; }
        public virtual Order Order { get; set; } = default!;
        public virtual Product Product { get; set; } = default!;
        public int Quantity { get; set; }
    }
}