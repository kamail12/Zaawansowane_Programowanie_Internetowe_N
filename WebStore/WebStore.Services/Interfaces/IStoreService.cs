using WebStore.ViewModels.VM;

namespace WebStore.Services.Interfaces;
public interface IStoreService
{
    public Task<StationaryStoreVm> GetStationaryStoreById(int id);
    public Task<IEnumerable<StationaryStoreVm>> GetStationaryStores();
    public Task<StationaryStoreVm> AddStationaryStore(AddStationaryStoreVm request);
}
