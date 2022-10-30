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

    public async Task<StationaryStoreAddressVm> AddOrUpdateStoreAdress(AddOrUpdateStoreAddressVm request)
    {
        try
        {
            if (request.Id != null && request.Id > 0)
            {
                var addressEntity = await _context.StationaryStoreAddress
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == request.Id);

                if (addressEntity == null)
                {
                    throw new Exception(message: "Address not found");
                }

                if (addressEntity.StationaryStoreId != request.StationaryStoreId)
                {
                    throw new Exception(message: "Invalid store Id");
                }

                var newAddress = _mapper.Map<StationaryStoreAddress>(request);
                _context.StationaryStoreAddress.Update(newAddress);

                return _mapper.Map<StationaryStoreAddressVm>(newAddress);
            }
            else
            {
                var storeEntity = await _context.StationaryStore
                    .FirstOrDefaultAsync(x => x.Id == request.StationaryStoreId);

                if (storeEntity == null)
                {
                    throw new Exception(message: "Invalid store Id");
                }
                var newAddress = _mapper.Map<StationaryStoreAddress>(request);
                _context.StationaryStoreAddress.Add(newAddress);
                _context.SaveChanges();

                return _mapper.Map<StationaryStoreAddressVm>(newAddress);
            }

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }

    public async Task<ShippingAddressVm> AddOrUpdateShippingAdress(AddOrUpdateShippingAddressVm request)
    {
        try
        {
            if (request.Id != null && request.Id > 0)
            {
                var addressEntity = await _context.ShippingAddress
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == request.Id);

                if (addressEntity == null)
                {
                    throw new Exception(message: "Address not found");
                }

                if (addressEntity.CustomerId != request.CustomerId)
                {
                    throw new Exception(message: "Invalid customer Id");
                }

                var newAddress = _mapper.Map<ShippingAddress>(request);
                _context.ShippingAddress.Update(newAddress);
                _context.SaveChanges();

                return _mapper.Map<ShippingAddressVm>(newAddress);
            }
            else
            {
                var storeEntity = await _context.User
                    .FirstOrDefaultAsync(x => x.Id == request.CustomerId);

                if (storeEntity == null)
                {
                    throw new Exception(message: "Invalid customer Id");
                }
                var newAddress = _mapper.Map<ShippingAddress>(request);
                _context.ShippingAddress.Add(newAddress);

                return _mapper.Map<ShippingAddressVm>(newAddress);
            }

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }

    public async Task<BillingAddressVm> AddOrUpdateBillingAddress(AddOrUpdateBillingAddressVm request)
    {
        try
        {
            if (request.Id != null && request.Id > 0)
            {
                var addressEntity = await _context.BillingAddress
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == request.Id);

                if (addressEntity == null)
                {
                    throw new Exception(message: "Address not found");
                }

                if (addressEntity.CustomerId != request.CustomerId)
                {
                    throw new Exception(message: "Invalid customer Id");
                }

                var newAddress = _mapper.Map<BillingAddress>(request);
                _context.BillingAddress.Update(newAddress);
                _context.SaveChanges();

                return _mapper.Map<BillingAddressVm>(newAddress);
            }
            else
            {
                var storeEntity = await _context.User
                    .FirstOrDefaultAsync(x => x.Id == request.CustomerId);

                if (storeEntity == null)
                {
                    throw new Exception(message: "Invalid customer Id");
                }
                var newAddress = _mapper.Map<BillingAddress>(request);
                _context.BillingAddress.Add(newAddress);

                return _mapper.Map<BillingAddressVm>(newAddress);
            }

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }
}
