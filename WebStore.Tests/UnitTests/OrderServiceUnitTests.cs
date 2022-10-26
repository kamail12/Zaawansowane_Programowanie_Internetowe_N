using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.DAL.EF;
using WebStore.Model.DataModels;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;
using Xunit;

namespace WebStore.Tests.UnitTests
{
    public class OrderServiceUnitTests : BaseUnitTests
    {
        private readonly IOrderService _orderService;
        public OrderServiceUnitTests(ApplicationDbContext dbContext, IOrderService orderService) : base(dbContext)
        {
            _orderService = orderService;
        }
        [Fact]
        public void GetOrderTest()
        {
            var order = _orderService.GetOrder(o => o.TrackingNumber == 334222);
            Assert.NotNull(order);
        }
        [Fact]
        public void GetMultipleOrdersTest()
        {
            var orders = _orderService.GetOrders(o => o.Id >= 1 && o.Id <= 2);
            Assert.NotNull(orders);
            Assert.NotEmpty(orders);
            Assert.Equal(2, orders.Count());
        }
        [Fact]
        public void GetAllOrdersTest()
        {
            var orders = _orderService.GetOrders();
            Assert.NotEmpty(orders);
            Assert.NotNull(orders);
            Assert.Equal(orders.Count(), orders.Count());
        }
        [Fact]
        public void AddNewOrderTest()
        {
            var newOrderVm = new AddOrUpdateOrderVm()
            {
                OrderDate = new DateTime(2022, 9, 13, 3, 32, 0),
                TotalAmount = 1997.99m,
                TrackingNumber = 987654321,
                InvoiceId = 1,
                CustomerId = 1
            };
            var createOrder = _orderService.AddOrUpdateOrder(newOrderVm);
            Assert.NotNull(createOrder);
            Assert.Equal(987654321, createOrder.TrackingNumber);
        }
        [Fact]
        public void UpdateOrderTest()
        {
            var newOrderVm = new AddOrUpdateOrderVm()
            {
                Id = 2,
                OrderDate = new DateTime(2022, 8, 1, 3, 22, 0),
                TotalAmount = 1997.99m,
                TrackingNumber = 8333,
                InvoiceId = 1,
                CustomerId = 1
            };
            var updateOrder = _orderService.AddOrUpdateOrder(newOrderVm);
            Assert.NotNull(updateOrder);
            Assert.Equal(8333, updateOrder.TrackingNumber);
        }
    }
}