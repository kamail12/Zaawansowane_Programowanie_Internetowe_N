using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Category
    {
        public string Name { get; set; } = default!;
        public int Id { get; set; } = default!;

        public virtual IList<Product> Products { get; set; } = default!;

    }
}