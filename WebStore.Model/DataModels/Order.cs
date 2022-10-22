using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels;

public class Order
{
    public Customer Customer { get; set; }
    public DateTime DeliveryDate { get; set; }
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; }
    public long TrackingNumber { get; set; }
    public Invoice Invoice { get; set; }
    public virtual IList<OrderProduct> OrderProducts { get; set; }

}
