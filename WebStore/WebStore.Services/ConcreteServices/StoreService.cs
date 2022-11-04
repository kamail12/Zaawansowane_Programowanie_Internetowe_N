using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using WebStore.DAL.DatabaseContext;
using WebStore.Model.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices;
public class StoreService : BaseService, IStoreService
{
    public StoreService(WSDbContext dbContext, IMapper mapper, ILogger logger)
        : base(dbContext, mapper, logger) { }

    public StationaryStoreVm AddOrUpdateStationaryStore(AddOrUpdateStationaryStoreVm addOrUpdateStationaryStoreVm)
    {
        try
        {
            if (addOrUpdateStationaryStoreVm == null)
                throw new ArgumentNullException("View model parameter is null");

            var StationaryStoreEntity = Mapper.Map<StationaryStore>(addOrUpdateStationaryStoreVm);

            if (addOrUpdateStationaryStoreVm.Id.HasValue || addOrUpdateStationaryStoreVm.Id == 0)
                DbContext.StationaryStore.Update(StationaryStoreEntity);
            else
                DbContext.StationaryStore.Add(StationaryStoreEntity);

            DbContext.SaveChanges();

            var StationaryStoreVm = Mapper.Map<StationaryStoreVm>(StationaryStoreEntity);

            return StationaryStoreVm;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }
    public StationaryStoreVm GetStationaryStore(Expression<Func<StationaryStore, bool>> filterExpression)
    {
        try
        {
            if (filterExpression == null)
                throw new ArgumentNullException("Filter expression parameter is null");
            var StationaryStoreEntity = DbContext.StationaryStore.FirstOrDefault(filterExpression);
            var StationaryStoreVm = Mapper.Map<StationaryStoreVm>(StationaryStoreEntity);
            return StationaryStoreVm;
        }

        catch (Exception ex)
        {
            {
                Logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
    public IEnumerable<StationaryStoreVm> GetStationaryStores(Expression<Func<StationaryStore, bool>>? filterExpression = null)
    {
        try
        {
            var StationaryStoresQuery = DbContext.StationaryStore.AsQueryable();
            if (filterExpression != null)
                StationaryStoresQuery = StationaryStoresQuery.Where(filterExpression);
            var StationaryStoreVms = Mapper.Map<IEnumerable<StationaryStoreVm>>(StationaryStoresQuery);

            return StationaryStoreVms;
        }

        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }

    public async Task DeleteStationaryStore(int StationaryStoreId)
    {
        try
        {
            var StationaryStoreEntity = DbContext.StationaryStore
                .FirstOrDefault(x => x.Id == StationaryStoreId);

            if (StationaryStoreEntity == null)
            {
                throw new Exception("StationaryStore not found");
            }

            DbContext.StationaryStore.Remove(StationaryStoreEntity);

            await DbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }
}
