using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Invoice
{
    public int invoiceID {get; set;}
    public IList<Order> Orders {get; set;}
    public decimal totalPrice {get; set;} 
    public DateTime invoiceDate { get; set; }
}