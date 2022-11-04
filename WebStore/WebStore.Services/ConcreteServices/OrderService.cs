using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebStore.DAL.DatabaseContext;
using WebStore.Model.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices;
public class OrderService : BaseService, IOrderService
{
    public OrderService(WSDbContext context, IMapper mapper, ILogger logger) : base(context, mapper, logger) { }

    public OrderVm AddOrUpdateOrder(AddOrUpdateOrderVm addOrUpdateOrderVm)
    {
        try
        {
            if (addOrUpdateOrderVm == null)
                throw new ArgumentNullException("View model parameter is null");

            var OrderEntity = Mapper.Map<Order>(addOrUpdateOrderVm);

            if (addOrUpdateOrderVm.Id.HasValue || addOrUpdateOrderVm.Id == 0)
                DbContext.Order.Update(OrderEntity);
            else
                DbContext.Order.Add(OrderEntity);

            DbContext.SaveChanges();

            var OrderVm = Mapper.Map<OrderVm>(OrderEntity);

            return OrderVm;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }
    public OrderVm GetOrder(Expression<Func<Order, bool>> filterExpression)
    {
        try
        {
            if (filterExpression == null)
                throw new ArgumentNullException("Filter expression parameter is null");
            var OrderEntity = DbContext.Order.FirstOrDefault(filterExpression);
            var OrderVm = Mapper.Map<OrderVm>(OrderEntity);
            return OrderVm;
        }

        catch (Exception ex)
        {
            {
                Logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
    public IEnumerable<OrderVm> GetOrders(Expression<Func<Order, bool>>? filterExpression = null)
    {
        try
        {
            var OrdersQuery = DbContext.Order.AsQueryable();
            if (filterExpression != null)
                OrdersQuery = OrdersQuery.Where(filterExpression);
            var OrderVms = Mapper.Map<IEnumerable<OrderVm>>(OrdersQuery);

            return OrderVms;
        }

        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }

    public async Task DeleteOrder(int OrderId)
    {
        try
        {
            var OrderEntity = DbContext.Order
                .FirstOrDefault(x => x.Id == OrderId);

            if (OrderEntity == null)
            {
                throw new Exception("Order not found");
            }

            DbContext.Order.Remove(OrderEntity);

            await DbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }
}
