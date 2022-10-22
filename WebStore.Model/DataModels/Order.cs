using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class Order
    {
        public DateTime DeliveryDate { get; set; }
        [Key]
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        public int CusustomerId { get; set; }
        public virtual Customer Customer { get; set; } = default!;
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public long TrackingNumber { get; set; }
        public virtual Invoice Invoice { get; set; } = default!;
        [ForeignKey("InvoiceId")]
        public int InvoiceId { get; set; }
        public virtual IList<OrderProduct> OrderProducts { get; set; } = default!;

    }
}