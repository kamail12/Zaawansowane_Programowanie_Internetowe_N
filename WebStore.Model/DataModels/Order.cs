using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModels;


public class Order
{

    public virtual Customer Customer { get; set; } = default!;
    [ForeignKey("Customer")]
    public int? CustomerId { get; set; }
    public DateTime DeliveryDate { get; set; }
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }

    [NotMapped]
    public decimal TotalAmount => OrderProducts == null ? 0 :
                                   OrderProducts.Sum(op => op.Product != null ? op.Product.Price : 0);
    public long TrackingNumber { get; set; }
    public virtual Invoice Invoice { get; set; } = default!;
    [ForeignKey("Invoice")]
    public int? Invoiceid { get; set; } = default!;
    public virtual IList<OrderProduct> OrderProducts { get; set; } = default!;

}
