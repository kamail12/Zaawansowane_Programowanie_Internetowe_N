using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebStore.Model.Models;
using WebStore.ViewModels.VM;
namespace WebStore.Services.Interfaces
{
    public interface IStoreService
    {
        StationaryStoreVm AddOrUpdateStore(AddOrUpdateStoreVm addOrUpdateStoreVm);
        StationaryStoreVm GetStore(Expression<Func<StationaryStore, bool>> filterExpression);
        IEnumerable<StationaryStoreVm> GetStores(Expression<Func<StationaryStore, bool>>? filterExpression = null);
        bool DeleteStore(Expression<Func<StationaryStore, bool>> filterExpression);
    }
}