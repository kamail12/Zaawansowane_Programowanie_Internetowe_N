using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModel;
public class ShippingAddress : Address
{
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; } = default!;
}