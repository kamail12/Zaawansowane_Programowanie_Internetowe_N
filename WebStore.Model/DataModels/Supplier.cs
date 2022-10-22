using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModels
{
    public class Supplier : User
    {
        public virtual IList<Product> Products { get; set; } = default!;

    }
}