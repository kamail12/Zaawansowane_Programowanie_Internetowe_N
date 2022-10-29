using WebStore.ViewModels.VM;

namespace WebStore.Services.Interfaces;
public interface IStoreService
{
    public Task<StationaryStoreVm> GetStationaryStoreById(int id);
}
