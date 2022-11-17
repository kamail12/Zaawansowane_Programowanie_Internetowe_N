using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels;

public class Customer : User
{
    public virtual IList<Order> Orders { get; set; }
    public virtual IList<CustomerAddress> CustomerAddresses { get; set; }
    
    
}
