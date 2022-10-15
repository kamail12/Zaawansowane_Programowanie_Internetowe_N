using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class Invoice
{
    public IList<Order> Orders {get; set;} = default!;
    
}