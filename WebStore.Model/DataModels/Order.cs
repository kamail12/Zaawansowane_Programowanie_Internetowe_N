using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class Order
    {
        public virtual Customer Customer { get; set; } = default!;
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }

        public virtual Invoice Invoice { get; set; } = default!;
        [ForeignKey("Invoice")]
        public int? InvoiceId { get; set; }

        public DateTime DeliveryDate { get; set; } = default!;

         public int Id { get; set; } = default!;

         public DateTime OrderDate { get; set; } = default!;

         public long TrackingNumber { get; set; } = default!;

         
    }
}