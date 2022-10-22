using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class Customer : User
    {
        public virtual Address ShippingAdress { get; set; } = default!;
        public virtual Address BillingAddress { get; set; } = default!;
        public virtual IList<Order> Orders { get; set; } = default!;
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
    }
}