using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels
{
    public class Category
    {
        public virtual IList<Product> Products {get;set;}
    }
}