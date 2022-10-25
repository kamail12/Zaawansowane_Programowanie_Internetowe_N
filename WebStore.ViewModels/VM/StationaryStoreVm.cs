namespace WebStore.ViewModels.VM;
public class StationaryStoreVm
{
    public int AddressId { get; set; }
    public AddressVm Address { get; set; } = default!;
    public IList<OrderVm> Orders { get; set; } = default!;
    public long ArrangementNumber {get; set;} = default!;
    public IList<StationaryStoreEmployeeVm> StationaryStoreEmployees { get; set; } = default!;
}