using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Category()
        {
            Name = "brak";
            Id = 0;
        }
    }
}