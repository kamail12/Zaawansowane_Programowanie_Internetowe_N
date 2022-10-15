using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModels
{
    public class ProductStock
    {
        public Product Product { get; set; } = default!;
        public int Quantity { get; set; }
    }
}