namespace WebStore.ViewModels.VM;
public class StationaryStoreAddressVm : AddressVm
{
    public int StationaryStoreId { get; set; }
    public virtual StationaryStoreVm StationaryStore { get; set; } = default!;
}
