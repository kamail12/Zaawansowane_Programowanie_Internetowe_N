namespace WebStore.Model.DataModels
{
    public class Order
    {
        public virtual Customer Customer { get; set; } = default!;
        public DateTime DeliveryDate { get; set; }
        public int Id { get; set; }
        public int CusustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public long TrackingNumber { get; set; }
        public virtual Invoice Invoice { get; set; } = default!;

    }
}