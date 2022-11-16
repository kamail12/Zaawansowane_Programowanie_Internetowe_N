using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebStore.Services.Interface;
using WebStore.ViewModels.Vm;

namespace WebStore.Web.Controllers
{
    public class StationaryStoreApiController : BaseApiController
    {
        private readonly IStationaryStoreService _stationaryStoreService;

        public StationaryStoreApiController(ILogger logger, IMapper mapper, IStationaryStoreService stationaryStoreService)
        :base(logger, mapper)
        {
            _stationaryStoreService = stationaryStoreService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var stationaryStores = _stationaryStoreService.GetStationaryStores();
                return Ok(stationaryStores);
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
                var stationaryStore = _stationaryStoreService.GetStationaryStores(s => s.Id == id);
                return Ok(stationaryStore);
            }
            catch(Exception ex)
            {
                Logger.LogError(ex, ex.Message);
                return StatusCode(500, "Error occured");
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] AddOrUpdateStationaryStoreVm addOrUpdatestationaryStoreVm)
        {
            return PostOrPutHelper(addOrUpdatestationaryStoreVm);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AddOrUpdateStationaryStoreVm addOrUpdatestationaryStoreVm)
        {
            return PostOrPutHelper(addOrUpdatestationaryStoreVm);
        }

        private IActionResult PostOrPutHelper(AddOrUpdateStationaryStoreVm addOrUpdatestationaryStoreVm)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok(_stationaryStoreService.AddOrUpdateStationaryStore(addOrUpdatestationaryStoreVm));
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
                var result = _stationaryStoreService.DeleteStationaryStore(p => p.Id == id);
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