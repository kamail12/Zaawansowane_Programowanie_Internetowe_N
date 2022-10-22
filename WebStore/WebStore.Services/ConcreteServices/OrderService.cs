using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using WebStore.DAL.DatabaseContext;
using WebStore.Model.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices;
public class OrderService : BaseService, IOrderService
{
    private readonly WSDbContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public OrderService(WSDbContext context, IMapper mapper, ILogger logger) : base(context, mapper, logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

    public IEnumerable<OrderVm> GetOrders(Expression<Func<Order, bool>>? filterExpression = null)
    {
        try
        {
            var ordersQuery = _context.Order.AsQueryable();
            if (filterExpression != null)
                ordersQuery = ordersQuery.Where(filterExpression);
            var orderVms = _mapper.Map<IEnumerable<OrderVm>>(ordersQuery);

            return orderVms;
        }

        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }

}
