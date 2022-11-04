using Microsoft.EntityFrameworkCore;
using WebStore.DAL.DatabaseContext;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;
using Xunit;

namespace WebStore.Tests.UnitTests;
public class OrderServiceUnitTests : BaseUnitTests
{
    private readonly IOrderService _orderService;
    private readonly WSDbContext _context;
    public OrderServiceUnitTests(WSDbContext dbContext,
        IOrderService orderService) : base(dbContext)
    {
        _orderService = orderService;
        _context = dbContext;
    }

    [Fact]
    public void GetOrderTest()
    {
        var Order = _orderService.GetOrder(p => p.TrackingNumber == 1244);
        Assert.NotNull(Order);
    }

    [Fact]
    public void GetMultipleOrdersTest()
    {
        var Orders = _orderService.GetOrders(p => p.Id >= 1 && p.Id <= 2);
        Assert.NotNull(Orders);
        Assert.NotEmpty(Orders);
        Assert.Equal(2, Orders.Count());
    }

    [Fact]
    public void GetAllOrdersTest()
    {
        var Orders = _orderService.GetOrders();
        Assert.NotNull(Orders);
        Assert.NotEmpty(Orders);
        Assert.Equal(Orders.Count(), Orders.Count());
    }

    [Fact]
    public void AddNewOrderTest()
    {
        var newOrderVm = new AddOrUpdateOrderVm()
        {
            CustomerId = 1,
            DeliveryDate = new DateTime(2020, 10, 10),
            Invoiceid = 1,
            StationaryStoreId = 1
        };

        var createdOrder = _orderService.AddOrUpdateOrder(newOrderVm);
        Assert.NotNull(createdOrder);
        Assert.Equal(createdOrder.DeliveryDate, new DateTime(2020, 10, 10));
    }

    [Fact]
    public void UpdateOrderTest()
    {
        var updateOrderVm = new AddOrUpdateOrderVm()
        {
            CustomerId = 2,
            DeliveryDate = new DateTime(2020, 5, 5),
            Invoiceid = 1,
            StationaryStoreId = 1
        };
        var editedOrderVm = _orderService.AddOrUpdateOrder(updateOrderVm);
        Assert.NotNull(editedOrderVm);
        Assert.Equal(2, editedOrderVm.CustomerId);
        Assert.Equal(new DateTime(2020, 5, 5), editedOrderVm.DeliveryDate);
    }

    [Fact]
    public async Task DeleteOrderTest()
    {
        int OrderId = 3;

        bool doesOrderExistsBefore = await _context.Order.AnyAsync(x => x.Id == OrderId);
        await _orderService.DeleteOrder(OrderId);
        bool doesOrderExistsAfter = await _context.Order.AnyAsync(x => x.Id == OrderId);

        Assert.True(doesOrderExistsBefore);
        Assert.False(doesOrderExistsAfter);
    }
}
