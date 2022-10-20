using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Product 
    {
        public virtual IList<Category>? Category { get; set; }
        public string? Description { get; set; }
        public int Id{ get; set; }
        public byte[]? ImageBytes { get; set; }
        public string? Name { get; set; }
        public decimal Price{ get; set; }
        public virtual Supplier? Supplier { get; set; }
        public float Weight { get; set; }
    }
}