namespace WebStore.ViewModels.VM

{
    public class OrderVm
    {
        public DateTime DeliveryDate { get; set; } = default!; 
        public DateTime OrderDate { get; set; } = default!; 
        public long TrackingNumber { get; set; } = default!; 
        public IList<OrderProductVm> OrderProducts { get; set; } = default!;
    }
}