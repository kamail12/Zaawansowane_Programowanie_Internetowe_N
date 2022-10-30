namespace WebStore.ViewModels.VM;
public class AddOrUpdateStoreAddressVm
{
    public int? Id { get; set; }
    public int StationaryStoreId { get; set; }
    public string City { get; set; } = default!;
    public string StreetName { get; set; } = default!;
    public int StreetNumber { get; set; } = default!;
    public string PostCode { get; set; } = default!;
}
