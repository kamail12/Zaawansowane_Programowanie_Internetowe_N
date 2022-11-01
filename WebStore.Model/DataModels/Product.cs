using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Product
    {
        public Category Category { get; set; }

        public string Description { get; set; }

         public int Id { get; set; }

         public byte[] ImageBytes { get; set; }

         public string Name { get; set; }

         public decimal Price { get; set; }

         public Supplier Supplier { get; set; }

         public float Weight { get; set; }

         public Product()
         {
            Description = "brak";
            Id = 0;
            Name = "brak";
            Price = 0;
            Weight = 0;
         }
    }
}