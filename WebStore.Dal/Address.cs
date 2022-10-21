using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Dal
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; } = default!;
        public string City { get; set; } = default!;

    }
}