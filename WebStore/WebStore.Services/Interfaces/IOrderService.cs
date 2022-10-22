using System.Linq.Expressions;
using WebStore.Model.Models;
using WebStore.ViewModels.VM;

namespace WebStore.Services.Interfaces;
public interface IOrderService
{
    public IEnumerable<OrderVm> GetOrders(Expression<Func<Order, bool>>? filterExpression = null);
    public Task<OrderVm> GetOrderById(int id);
}
