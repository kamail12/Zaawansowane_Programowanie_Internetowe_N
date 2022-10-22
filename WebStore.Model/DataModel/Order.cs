using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModel;


public class Order
{
    public int Id { get; set; }
    public decimal TotalPrice => OrderProducts == null ? 0 : OrderProducts.Sum(op => op.Product != null ? op.Product.Price : 0);
    public long TrackingNumber { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime OrderDate { get; set; }
    public int StationaryStoreId { get; set; }
    public virtual StationaryStore StationaryStore { get; set; } = default!;
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; } = default!;
    public int Invoiceid { get; set; } = default!;
    public virtual Invoice Invoice { get; set; } = default!;
    public virtual IList<OrderProduct> OrderProducts { get; set; } = default!;

}
