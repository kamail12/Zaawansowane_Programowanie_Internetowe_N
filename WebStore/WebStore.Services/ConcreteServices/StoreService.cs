using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebStore.DAL.DatabaseContext;
using WebStore.Model.Models;
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
                    .Include(x => x.Invoices)
                    .Include(x => x.Orders)
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

        public async Task<IEnumerable<StationaryStoreVm>> GetStationaryStores()
        {
            try
            {
                var stationaryStores = await _context.StationaryStore
                    .Include(x => x.Addresses)
                    .Include(x => x.Invoices)
                    .Include(x => x.StationaryStoreEmployees)
                    .ToListAsync();

                if (stationaryStores == null || stationaryStores.Count() == 0)
                {
                    throw new Exception(message: "Not found");
                }

                return _mapper.Map<IEnumerable<StationaryStoreVm>>(stationaryStores);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public async Task<StationaryStoreVm> AddStationaryStore(AddStationaryStoreVm request)
        {
            try
            {
                StationaryStore store = _mapper.Map<StationaryStore>(request);

                await _context.AddAsync(store);
                return _mapper.Map<StationaryStoreVm>(store);
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}