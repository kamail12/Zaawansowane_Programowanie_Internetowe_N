using WebStore.ViewModels.VM;

namespace WebStore.Services.Interfaces;
public interface IAddressService
{
    public Task<StationaryStoreAddressVm> AddOrUpdateStoreAdress(AddOrUpdateStoreAddressVm request);
    public Task<ShippingAddressVm> AddOrUpdateShippingAdress(AddOrUpdateShippingAddressVm request);
    public Task<BillingAddressVm> AddOrUpdateBillingAddress(AddOrUpdateBillingAddressVm request);
}
