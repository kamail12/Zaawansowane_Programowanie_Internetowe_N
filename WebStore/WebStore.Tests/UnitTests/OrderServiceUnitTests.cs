using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.DatabaseContext;
using WebStore.Services.Interfaces;
using Xunit;

namespace WebStore.Tests.UnitTests;
public class OrderServiceUnitTests : BaseUnitTests
{
    private readonly IOrderService _orderService;
    public OrderServiceUnitTests(WSDbContext dbContext,
        IOrderService orderService) : base(dbContext)
    {
        _orderService = orderService;
    }

    [Fact]
    public void GetAllOrdersTest()
    {
        var orders = _orderService.GetOrders();
        Assert.NotNull(orders);
        Assert.NotEmpty(orders);
        Assert.Equal(orders.Count(), orders.Count());
    }
}
