using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; } = default!;
        public string Desription { get; set; } = default!;
        public byte[] ImageBytes { get; set; } = default!;
        public string Name { get; set; } = default!;
        public decimal Price { get; set; } = default!;
        public Supplier Supplier { get; set; } = default!;
        public float Weight { get; set; } = default!;
    }
}