namespace WebStore.Model
{
    public class Order
    {
        public Customer Customer { get; set; } = default!;
        public int Id { get; set; } = default!;
        public long TrackingNumber {get; set; } = default!;
        public Invoice Invoice { get; set; } = default!;
    }

}
