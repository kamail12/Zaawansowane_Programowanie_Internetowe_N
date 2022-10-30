using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.Models

{
    public class BillingAddress
    {
        [ForeignKey("Customer")]
        public int Id { get; set; }
        public virtual Customer Customer { get; set; } = default!;
        public int CustomerId { get; set; }
    }
}