using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Model.DataModels;

public class Invoice
{
    public int invoiceID {get; set;}
    public decimal totalPrice {get; set;} 
    [Column(TypeName = "decimal(18,2)")]
    public DateTime invoiceDate { get; set; } 
    [NotMapped]
    public virtual IList<Order> Orders {get; set;} = default!;
}