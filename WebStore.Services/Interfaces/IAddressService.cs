using System.Linq.Expressions;
using WebStore.Model.Models;
using WebStore.ViewModels.VM;

namespace WebStore.Services.Interfaces
{
    public interface IAddressService
    {
        AddressVm AddOrUpdateAddress(AddOrUpdateAddressVm addOrUpdateAddressVm);
        AddressVm GetAddress(Expression<Func<Address, bool>> filterExpression);
        IEnumerable<AddressVm> GetAddresses(Expression<Func<Address, bool>>? filterExpression = null);
    }
}