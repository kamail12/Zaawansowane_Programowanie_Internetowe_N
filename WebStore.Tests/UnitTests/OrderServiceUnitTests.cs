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

namespace WebStore.Tests.UnitTests { 
    public class OrderServiceUnitTests : BaseUnitTests { 
        private readonly IOrderService _orderService; 
        public OrderServiceUnitTests (ApplicationDbContext dbContext, 
        IOrderService orderService) : base (dbContext) { 
            _orderService = orderService; 
        } 
        
        [Fact]
        public void addOrderTest () {
            var newOrderVm = new AddOrUpdateOrderVm () { 
                CustomerId = 1,
                DeliveryDate = new DateTime(),
                OrderDate = new DateTime(),
                TotalAmount = 100.00M,
            }; 
            var createdOrder = _orderService.AddOrUpdateOrder (newOrderVm); 
            Assert.NotNull (createdOrder); 
        }
    }
}