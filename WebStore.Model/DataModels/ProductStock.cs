using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class ProductStock
    {
        public virtual Product? Product { get; set; }
        public int Quantity { get; set; }
    }
}