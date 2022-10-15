using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModels
{
    public class Product
    {
        public Category Category { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int Id { get; set; }
        public byte[] ImageBytes { get; set; } = default!;
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public Supplier Supplier { get; set; } = default!;
        public float Weight { get; set; }
    }
}