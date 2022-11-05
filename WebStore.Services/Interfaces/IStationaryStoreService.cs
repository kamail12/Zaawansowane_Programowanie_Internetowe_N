using WebStore.Model.DataModels;
using WebStore.ViewModels.Vm;
using System.Linq.Expressions;

namespace WebStore.Services.Interface
{
    public interface IStationaryStoreService
    {
        StationaryStoreVm AddOrUpdateStationaryStore(AddOrUpdateStationaryStoreVm addOrUpdateStationaryStoreVm);
        StationaryStoreVm GetStationaryStore(Expression<Func<StationaryStore,bool>> filterExpression);
        IEnumerable<StationaryStoreVm> GetStationaryStores (Expression<Func<StationaryStore,bool>>? filterExpression = null);
    }
}