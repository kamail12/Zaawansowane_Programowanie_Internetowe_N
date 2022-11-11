using WebStore.Services.Interface;
using WebStore.DAL.EF;
using WebStore.ViewModels.Vm;

namespace WebStore.Test.UnitTest
{

    public class OrderServiceUnitTest : BaseUnitTest
    {
        private readonly IOrderService _orderService;

        public OrderServiceUnitTest(ApplicationDbContext dbContext, IOrderService orderService)
        :base(dbContext)
        {
            _orderService = orderService;
        } 

        [Fact]
        public void GetOrderTest()
        {
            var order = _orderService.GetOrder(o => o.TrackingNumber == 78654321);
            Assert.NotNull (order); 
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
            Assert.NotNull(orders);
            Assert.NotEmpty(orders);
            Assert.Equal(DbContext.Orders.Count(), orders.Count());
        }

        [Fact]
        public void AddNewOrderTest()
        {
            var newOrderVm = new AddOrUpdateOrderVm
            {
                Id = 1,
                CustomerId = 1,
                InvoiceId = 1,
                DeliveryDate = new DateTime(1999, 1, 1),
                OrderDate = new DateTime(2000, 2, 2),
                TrackingNumber = 999999999
            };
            var createdOrder = _orderService.AddOrUpdateOrder(newOrderVm);
            Assert.NotNull(createdOrder);
            Assert.Equal(999999999, createdOrder.TrackingNumber);
        }

        [Fact]
        public void UpdateOrderTest()
        {
            var updateOrderVm = new AddOrUpdateOrderVm()
            {
                Id = 1,
                CustomerId = 1,
                InvoiceId = 2,
                DeliveryDate = new DateTime(2111, 2, 2),
                OrderDate = new DateTime(2111, 3, 3),
                TrackingNumber = 1010100100101001
            };

            var editedOrderVm = _orderService.AddOrUpdateOrder (updateOrderVm);
            Assert.NotNull(editedOrderVm);
            Assert.Equal(1010100100101001, editedOrderVm.TrackingNumber);
        }
    }

    
}