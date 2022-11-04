using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using WebStore.DAL.DatabaseContext;
using WebStore.Model.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices;
public class AddressService : BaseService, IAddressService
{
    public AddressService(WSDbContext context, IMapper mapper, ILogger logger) : base(context, mapper, logger) { }

    public AddressVm AddOrUpdateAddress(AddOrUpdateAddressVm addOrUpdateAddressVm)
    {
        try
        {
            if (addOrUpdateAddressVm == null)
                throw new ArgumentNullException("View model parameter is null");

            var AddressEntity = Mapper.Map<Address>(addOrUpdateAddressVm);

            if (addOrUpdateAddressVm.Id.HasValue || addOrUpdateAddressVm.Id == 0)
                DbContext.Address.Update(AddressEntity);
            else
                DbContext.Address.Add(AddressEntity);

            DbContext.SaveChanges();

            var AddressVm = Mapper.Map<AddressVm>(AddressEntity);

            return AddressVm;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }
    public AddressVm GetAddress(Expression<Func<Address, bool>> filterExpression)
    {
        try
        {
            if (filterExpression == null)
                throw new ArgumentNullException("Filter expression parameter is null");
            var AddressEntity = DbContext.Address.FirstOrDefault(filterExpression);
            var AddressVm = Mapper.Map<AddressVm>(AddressEntity);
            return AddressVm;
        }

        catch (Exception ex)
        {
            {
                Logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
    public IEnumerable<AddressVm> GetAddresss(Expression<Func<Address, bool>>? filterExpression = null)
    {
        try
        {
            var AddresssQuery = DbContext.Address.AsQueryable();
            if (filterExpression != null)
                AddresssQuery = AddresssQuery.Where(filterExpression);
            var AddressVms = Mapper.Map<IEnumerable<AddressVm>>(AddresssQuery);

            return AddressVms;
        }

        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }

    public async Task DeleteAddress(int AddressId)
    {
        try
        {
            var AddressEntity = DbContext.Address
                .FirstOrDefault(x => x.Id == AddressId);

            if (AddressEntity == null)
            {
                throw new Exception("Address not found");
            }

            DbContext.Address.Remove(AddressEntity);

            await DbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }
}
