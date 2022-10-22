using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model
{
    public class Order
    {
        public virtual Customer Customer { get; set; } = default!;
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public int Id { get; set; }
        public long TrackingNumber {get; set; } = default!;
        public virtual Invoice Invoice { get; set; } = default!;
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public virtual IList<OrderProduct> OrderProducts { get; set; } = default!;
    }

}
