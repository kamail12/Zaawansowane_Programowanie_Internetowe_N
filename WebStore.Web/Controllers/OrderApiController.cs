using AutoMapper;
using Microsoft.AspNetCore.Mvc; 
using WebStore.Services.Interface; 
using WebStore.ViewModels.Vm;

namespace WebStore.Web.Controllers
{
    public class OrderApiController : BaseApiController
    {
        private readonly IOrderService _orderService;
        public OrderApiController(ILogger logger, IMapper mapper, IOrderService orderService)
        : base(logger, mapper)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var orders = _orderService.GetOrders();
                return Ok(orders);
            }
            catch(Exception ex)
            {
                Logger.LogError(ex, ex.Message);
                return StatusCode(500, "Error occured");
            }
        }

        [HttpGet("{id:int:min(1)}")]
        public IActionResult Get(int id)
        {
            try
            {
                var order = _orderService.GetOrder(o => o.Id ==id);
                return Ok(order);
            }
            catch(Exception ex)
            {
                Logger.LogError(ex, ex.Message);
                return StatusCode(500, "Error occured");
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] AddOrUpdateOrderVm addOrUpdateOrderVm)
        {
            return PostOrPutHelper(addOrUpdateOrderVm);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AddOrUpdateOrderVm addOrUpdateOrderVm)
        {
            return PostOrPutHelper(addOrUpdateOrderVm);
        }

        private IActionResult PostOrPutHelper(AddOrUpdateOrderVm addOrUpdateOrderVm)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok(_orderService.AddOrUpdateOrder(addOrUpdateOrderVm));
            }
            catch(Exception ex)
            {
                Logger.LogError(ex, ex.Message);
                return StatusCode(500, "Error occured");
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _orderService.DeleteOrder(o => o.Id == id);
                return Ok(result);
            }
            catch(Exception ex)
            {
                Logger.LogError(ex, ex.Message);
                return StatusCode(500, "Error occured");
            }
        }
    }
}