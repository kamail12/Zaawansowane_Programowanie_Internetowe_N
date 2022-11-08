using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using WebStore.DAL.EF;
using WebStore.Model.DataModels;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices;

public class StoreService : BaseService, IStoreService
{
    public StoreService(ApplicationDbContext dbContext, IMapper mapper, ILogger logger) : base(dbContext, mapper, logger){ }

    
    public StoreVm AddOrUpdateStore(AddOrUpdateStoreVm addOrUpdateStoreVm)
    {
        try {
            if (addOrUpdateStoreVm == null)
                throw new ArgumentNullException ("View model parameter is null");
            var productEntity = Mapper.Map<StationaryStore> (addOrUpdateStoreVm);
            if (addOrUpdateStoreVm.Id.HasValue || addOrUpdateStoreVm.Id == 0)
                DbContext.StationaryStores.Update (productEntity);
            else
                DbContext.StationaryStores.Add (productEntity);
            DbContext.SaveChanges ();
            var storeVm = Mapper.Map<StoreVm> (productEntity);
            return storeVm;
        } catch (Exception ex) {
            Logger.LogError (ex, ex.Message);
            throw;
        }
    }

    public StoreVm GetStore(Expression<Func<StationaryStore, bool>> ? filterExpression = null)
    {
        try {
            if (filterExpression == null)
                throw new ArgumentNullException ("Filter expression parameter is null");
            var productEntity = DbContext.StationaryStores.FirstOrDefault (filterExpression);
            var storeVm = Mapper.Map<StoreVm> (productEntity);
            return storeVm;
        } catch (Exception ex) {
            {
                Logger.LogError (ex, ex.Message);
                throw;
            }
        }
    }
    
}
