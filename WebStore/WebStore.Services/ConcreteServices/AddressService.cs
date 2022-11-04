using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebStore.DAL.DatabaseContext;
using WebStore.Model.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices;
public class AddressService : BaseService, IAddressService
{
    private readonly WSDbContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;
    public AddressService(WSDbContext context, IMapper mapper, ILogger logger) : base(context, mapper, logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<AddressVm> AddOrUpdateAddress(AddOrUpdateAddressVm request)
    {
        try
        {
            if (request.Id != null && request.Id > 0)
            {
                var addressEntity = await _context.Address
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == request.Id);

                if (addressEntity == null)
                {
                    throw new Exception(message: "Address not found");
                }

                if (request.StationaryStoreId != null && addressEntity.StationaryStoreId != request.StationaryStoreId)
                {
                    throw new Exception(message: "Invalid store Id");
                }

                if (request.CustomerId != null && addressEntity.CustomerId != request.CustomerId)
                {
                    throw new Exception(message: "Invalid customer Id");
                }

                var newAddress = _mapper.Map<Address>(request);
                _context.Address.Update(newAddress);

                return _mapper.Map<AddressVm>(newAddress);
            }
            else
            {
                if (request.StationaryStoreId != null)
                {
                    var storeEntity = await _context.StationaryStore
                        .FirstOrDefaultAsync(x => x.Id == request.StationaryStoreId);

                    if (storeEntity == null)
                    {
                        throw new Exception(message: "Invalid store Id");
                    }
                }

                if (request.CustomerId != null)
                {
                    var storeEntity = await _context.User.OfType<Customer>()
                        .FirstOrDefaultAsync(x => x.Id == request.StationaryStoreId);

                    if (storeEntity == null)
                    {
                        throw new Exception(message: "Invalid customer Id");
                    }
                }

                var newAddress = _mapper.Map<Address>(request);
                _context.Address.Add(newAddress);
                _context.SaveChanges();

                return _mapper.Map<AddressVm>(newAddress);
            }

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }


}
