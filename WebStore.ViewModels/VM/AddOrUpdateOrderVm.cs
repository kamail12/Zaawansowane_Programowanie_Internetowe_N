namespace WebStore.ViewModels.VM
{
    public class AddOrUpdateOrderVm
    {
        public int? Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime OrderDate { get; set; }
        public long TrackingNumber { get; set; }
        public virtual InvoiceVm Invoice { get; set; } = default!;
        public int? InvoiceId { get; set; }
        public virtual CustomerVm Customer { get; set; } = default!;
        public int? CustomerId { get; set; }
        public virtual StationaryStoreVm StationaryStore { get; set; } = default!;
        public int? StationaryStoreId { get; set; }
        public virtual IList<ProductVm> Products { get; set; } = default!;
    }
}