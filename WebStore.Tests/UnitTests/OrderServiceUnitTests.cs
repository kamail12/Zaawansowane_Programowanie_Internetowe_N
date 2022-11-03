using System.Data.Common;
using WebStore.DAL.Data;
using WebStore.Model.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Tests.UnitTests
{
    public class OrderServiceUnitTests : BaseUnitTests
    {
        private readonly IOrderService _orderService;
        public OrderServiceUnitTests(ApplicationDbContext context, IOrderService service) : base(context)
        {
            _orderService = service;
        }

        [Fact]
        public void ShouldAddOrder()
        {
            var o1 = new AddOrUpdateOrderVm()
            {
                CustomerId = 1,
                OrderDate = new DateTime(2012, 1, 1),
                DeliveryDate = new DateTime(2012, 1, 1),
                InvoiceId = 1,
                TrackingNumber = 5556,
            };

            var order = _orderService.AddOrUpdateOrder(o1);

            Assert.NotNull(order);
            Assert.Equal(o1.DeliveryDate, order.DeliveryDate);
        }

        [Fact]
        public void ShouldUpdateOrder()
        {
            var o1 = new AddOrUpdateOrderVm()
            {
                Id = 1,
                CustomerId = 1,
                OrderDate = new DateTime(2012, 1, 1),
                DeliveryDate = new DateTime(2012, 1, 1),
                InvoiceId = 1,
            };

            var order = _orderService.AddOrUpdateOrder(o1);

            Assert.NotNull(order);
            Assert.Equal(o1.DeliveryDate, order.DeliveryDate);
        }
    }
}