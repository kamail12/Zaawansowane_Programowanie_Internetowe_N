using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using WebStore.DAL.Data;
using WebStore.Model.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices
{
    public class OrderService : BaseService, IOrderService
    {
        public OrderService(ApplicationDbContext dbContext, IMapper mapper, ILogger logger) : base(dbContext, mapper, logger)
        {
        }

        public OrderVm AddOrUpdateOrder(AddOrUpdateOrderVm addOrUpdateOrderVm)
        {
            try
            {
                if (addOrUpdateOrderVm == null)
                    throw new ArgumentNullException("View model parameter is null");
                var orderEntity = Mapper.Map<Order>(addOrUpdateOrderVm);
                if (addOrUpdateOrderVm.Id.HasValue || addOrUpdateOrderVm.Id == 0)
                    DbContext.Orders.Update(orderEntity);
                else
                    DbContext.Orders.Add(orderEntity);
                DbContext.SaveChanges();
                return Mapper.Map<OrderVm>(orderEntity);
            }

            catch (Exception ex)
            {
                Logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}