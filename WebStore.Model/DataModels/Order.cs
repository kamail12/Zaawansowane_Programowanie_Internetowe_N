using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class Order
    {
        public DateTime DeliveryDate { get; set; }

         public int Id { get; set; }

         public DateTime OrderDate { get; set; }

         public long TrackingNumber { get; set; }

         
    }
}