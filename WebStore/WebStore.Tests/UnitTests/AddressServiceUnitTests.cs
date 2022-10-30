using WebStore.DAL.DatabaseContext;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;
using Xunit;

namespace WebStore.Tests.UnitTests;
public class AddressServiceUnitTests : BaseUnitTests
{
    private readonly WSDbContext _context;
    private readonly IAddressService _addressService;
    public AddressServiceUnitTests(WSDbContext context, IAddressService addressService) : base(context)
    {
        _context = context;
        _addressService = addressService;
    }

    [Fact]
    public async Task ShouldAddStoreAddress()
    {
        var request = new AddOrUpdateStoreAddressVm()
        {
            StationaryStoreId = 1,
            City = "Częstochowa",
            StreetName = "Szkolna",
            StreetNumber = 34,
            PostCode = "12-345"
        };

        var address = await _addressService.AddOrUpdateStoreAdress(request);

        Assert.True(address.Id > 0);
        Assert.Equal(address.City, request.City);
        Assert.Equal(address.StreetName, request.StreetName);
        Assert.Equal(address.PostCode, request.PostCode);
        Assert.Equal(address.StationaryStoreId, request.StationaryStoreId);
    }

    [Fact]
    public async Task ShouldAddBillingAddress()
    {
        var request = new AddOrUpdateBillingAddressVm()
        {
            CustomerId = 1,
            City = "Częstochowa",
            StreetName = "Główna",
            StreetNumber = 124,
            PostCode = "12-444"
        };

        var address = await _addressService.AddOrUpdateBillingAddress(request);

        Assert.True(address.Id > 0);
        Assert.Equal(address.City, request.City);
        Assert.Equal(address.StreetName, request.StreetName);
        Assert.Equal(address.PostCode, request.PostCode);
        Assert.Equal(address.CustomerId, request.CustomerId);
    }

    [Fact]
    public async Task ShouldAddShippingAddress()
    {
        var request = new AddOrUpdateShippingAddressVm()
        {
            CustomerId = 1,
            City = "Kraków",
            StreetName = "Boczna",
            StreetNumber = 4,
            PostCode = "33-432"
        };

        var address = await _addressService.AddOrUpdateShippingAdress(request);

        Assert.True(address.Id > 0);
        Assert.Equal(address.City, request.City);
        Assert.Equal(address.StreetName, request.StreetName);
        Assert.Equal(address.PostCode, request.PostCode);
        Assert.Equal(address.CustomerId, request.CustomerId);
    }


    [Fact]
    public async void ShouldUpdateStoreAdress()
    {
        var request = new AddOrUpdateStoreAddressVm()
        {
            Id = 2,
            StationaryStoreId = 2,
            City = "NewCity",
            StreetName = "Ogrodowa",
            StreetNumber = 12,
            PostCode = "11-232"
        };

        var address = await _addressService.AddOrUpdateStoreAdress(request);

        Assert.Equal(request.Id, address.Id);
        Assert.Equal(request.City, address.City);
        Assert.Equal(request.StationaryStoreId, address.StationaryStoreId);
        Assert.Equal(request.StreetName, address.StreetName);
    }
}
