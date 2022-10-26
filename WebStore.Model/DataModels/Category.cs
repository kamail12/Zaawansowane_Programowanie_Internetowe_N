using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}