using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class Supplier : User
    {
        public IList<Product> Products { get; set; } = default!;
    }
}