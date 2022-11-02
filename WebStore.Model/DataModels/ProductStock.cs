 using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class ProductStock
    {
        public Product Product { get; set; } = default!;

        public int Quantity { get; set; } = default!;
    }
}