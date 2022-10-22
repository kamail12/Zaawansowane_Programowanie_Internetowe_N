using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual IList<Order> Orders { get; set; } = default!;
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        [ForeignKey("StoreId")]
        public int StoreId { get; set; }
    }
}