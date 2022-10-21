namespace WebStore.Model.Models
{
    public class ShippingAddress
    {
        public int Id { get; set; }
        public virtual Customer Customer { get; set; } = default!;
        public int CustomerId { get; set; }
    }
}