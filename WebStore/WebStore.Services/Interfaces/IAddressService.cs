using WebStore.ViewModels.VM;

namespace WebStore.Services.Interfaces;
public interface IAddressService
{
    public Task<AddressVm> AddOrUpdateAddress(AddOrUpdateAddressVm request);
}
