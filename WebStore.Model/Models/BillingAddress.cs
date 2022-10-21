namespace WebStore.Model.Models
{
    public class BillingAddress
    {
        public int Id { get; set; }
        public virtual Customer Customer { get; set; } = default!;
        public int CustomerId { get; set; }
    }
}