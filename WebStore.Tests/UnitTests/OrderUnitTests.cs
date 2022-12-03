using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using WebStore.DAL.DatabaseContext; 
using WebStore.Model.DataModels; 
using WebStore.Services.Interfaces; 
using WebStore.ViewModels.VM; 
using Xunit; 
namespace WebStore.Tests.UnitTests { 
    public class OrderServiceUnitTests : BaseUnitTests { 
        private readonly IOrderService _orderService; 
        public OrderServiceUnitTests (ApplicationDbContext dbContext, 
        IOrderService orderService) : base (dbContext) { 
            _orderService = orderService; 
        }
        
        // [Fact] 
        public void GetOrderTest () { 
            var order = _orderService.GetOrder (o => o.Invoiceid == 234); 
            Assert.NotNull (order); 
        } 
        
        // [Fact] 
        public void GetMultipleOrdersTest () { 
            var orders = _orderService.GetOrders (o => o.Id >= 1 && o.Id <= 2); 
            Assert.NotNull (orders); 
            Assert.NotEmpty (orders); 
            Assert.Equal (2, orders.Count ()); 
        } 

        // [Fact] 
        
        public void GetAllProductsTest () { 
            var orders = _orderService.GetOrders (); 
            Assert.NotNull (orders); 
            Assert.NotEmpty (orders); 
            Assert.Equal (orders.Count (), orders.Count ()); 
        } 
        
        [Fact] 
        
        public void AddNewOrderTest () { 
            var newOrderVm = new AddOrUpdateOrderVm () { 
                DeliveryDate = new DateTime(),
                OrderDate = new DateTime(),
                TotalAmount = 34563.89m,
                TrackingNumber = 322323,
                
            }; 
                var createdOrder = _orderService.AddOrUpdateOrder (newOrderVm); 
                Assert.NotNull (createdOrder); 
                Assert.Equal (34563.89m, createdOrder.TotalAmount); 
                
        }

        [Fact]

        public void UpdateOrderTest () { 
            var updateOrderVm = new AddOrUpdateOrderVm () { 
                DeliveryDate = new DateTime(),
                OrderDate = new DateTime(),
                TotalAmount = 1987.89m,
                TrackingNumber = 876677,
            }; 
            var editedOrderVm = _orderService.AddOrUpdateOrder (updateOrderVm); 
            Assert.NotNull (editedOrderVm); 
            Assert.Equal (876677, editedOrderVm.TrackingNumber); 
            Assert.Equal (1987.89m, editedOrderVm.TotalAmount); 
        } 
    }
}