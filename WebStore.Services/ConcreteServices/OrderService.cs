using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using WebStore.DAL.EF;
using WebStore.Model.DataModels;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices;

public class OrderService : BaseService, IOrderService
{
    public OrderService(ApplicationDbContext dbContext, IMapper mapper, ILogger logger) : base(dbContext, mapper, logger){ }

    public OrderVm AddOrUpdateOrder(AddOrUpdateOrderVm addOrUpdateOrderVm){
        try {
            if (addOrUpdateOrderVm == null)
                throw new ArgumentNullException ("View model parameter is null");

            var orderEntity = Mapper.Map<Order> (addOrUpdateOrderVm);

            if (addOrUpdateOrderVm.Id.HasValue || addOrUpdateOrderVm.Id == 0)
                DbContext.Orders.Update (orderEntity);
            else
                DbContext.Orders.Add (orderEntity);

            DbContext.SaveChanges ();
            var orderVm = Mapper.Map<OrderVm> (orderEntity);
            return orderVm;
        } catch (Exception ex) {
            Logger.LogError (ex, ex.Message);
            throw;
        }
    }
    public OrderVm DeleteOrder(DeleteOrderVm deleteOrderVm){
        try {
            if (deleteOrderVm == null)
                throw new ArgumentNullException ("View model parameter is null");

            var orderEntity = Mapper.Map<Order> (deleteOrderVm);

            if (deleteOrderVm.Id.HasValue || deleteOrderVm.Id == 0)
                DbContext.Orders.Remove (orderEntity);

            DbContext.SaveChanges ();
            var orderVm = Mapper.Map<OrderVm> (orderEntity);
            return orderVm;
        } catch (Exception ex) {
            Logger.LogError (ex, ex.Message);
            throw;
        }
    }
}
