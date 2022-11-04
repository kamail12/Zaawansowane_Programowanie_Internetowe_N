using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebStore.Model.Models;
using WebStore.ViewModels.VM;

namespace WebStore.Services.Interfaces;
public interface IOrderService
{
    public OrderVm AddOrUpdateOrder(AddOrUpdateOrderVm addOrUpdateOrderVm);
    public OrderVm GetOrder(Expression<Func<Order, bool>> filterExpression);
    public IEnumerable<OrderVm> GetOrders(Expression<Func<Order, bool>>? filterExpression = null);
    public Task DeleteOrder(int OrderId);
}
