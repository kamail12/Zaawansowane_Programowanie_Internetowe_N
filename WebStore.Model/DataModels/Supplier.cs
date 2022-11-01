using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Supplier : User
    {
         virtual public IList<Product> Products { get; set; }
    }
}