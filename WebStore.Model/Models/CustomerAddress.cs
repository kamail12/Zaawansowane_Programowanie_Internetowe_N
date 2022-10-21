namespace WebStore.Model.Models

{
    public class CustomerAddress : Address
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } = default!;
    }
}