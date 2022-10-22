namespace WebStore.ViewModels.VM;
public class OrderVm
{
    public int Id { get; set; }
    public decimal TotalAmount { get; set; }
    public long TrackingNumber { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime OrderDate { get; set; }
    public int StationaryStoreId { get; set; }
    public virtual StationaryStoreVm StationaryStore { get; set; } = default!;
    public int CustomerId { get; set; }
    public virtual CustomerVm Customer { get; set; } = default!;
    public int Invoiceid { get; set; } = default!;
    public virtual InvoiceVm Invoice { get; set; } = default!;
    public virtual IList<ProductVm> Products { get; set; } = default!;
}