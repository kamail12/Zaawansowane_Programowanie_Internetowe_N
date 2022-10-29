using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebStore.DAL.DatabaseContext;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices
{
    public class StoreService : BaseService, IStoreService
    {
        private readonly WSDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public StoreService(WSDbContext context, IMapper mapper, ILogger logger) : base(context, mapper, logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<StationaryStoreVm> GetStationaryStoreById(int id)
        {
            try
            {
                var stationaryStore = await _context.StationaryStore
                    .Include(x => x.Addresses)
                    .Include(x => x.StationaryStoreEmployees)
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (stationaryStore == null)
                {
                    throw new Exception(message: "Stationary store not found");
                }

                return _mapper.Map<StationaryStoreVm>(stationaryStore);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}