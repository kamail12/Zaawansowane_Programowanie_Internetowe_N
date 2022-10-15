using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Invoice
{
    public IList<Order> Orders {get; set;}
    
}