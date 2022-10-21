namespace WebStore.ViewModels.VM
{
    public class InvoiceVm
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual IList<OrderVm> Orders { get; set; } = default!;
        public virtual CustomerVm IssuedFor { get; set; } = default!;
        public virtual StationaryStoreVm StationaryStore { get; set; } = default!;
        public int? StationaryStoreId { get; set; }
    }
}