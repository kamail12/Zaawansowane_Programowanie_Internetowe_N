using WebStore.DAL.DatabaseContext;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;
using Xunit;

namespace WebStore.Tests.UnitTests;
public class AddressServiceUnitTests : BaseUnitTests
{
    protected WSDbContext _context;
    private readonly IAddressService _addressService;
    public AddressServiceUnitTests(WSDbContext context, IAddressService addressService) : base(context)
    {
        _context = context;
        _addressService = addressService;
    }

    [Fact]
    public async Task ShouldAddAddress()
    {
        var request = new AddOrUpdateAddressVm()
        {
            City = "Częstochowa",
            StreetName = "Szkolna",
            StreetNumber = 34,
            PostCode = "12-345"
        };

        var address = await _addressService.AddOrUpdateAddress(request);

        Assert.True(address.Id > 0);
        Assert.Equal(address.City, request.City);
        Assert.Equal(address.StreetName, request.StreetName);
        Assert.Equal(address.PostCode, request.PostCode);
        Assert.Equal(address.StationaryStoreId, request.StationaryStoreId);
    }

    [Fact]
    public async void ShouldUpdateAdress()
    {
        var request = new AddOrUpdateAddressVm()
        {
            Id = 2,
            StationaryStoreId = 2,
            City = "NewCity",
            StreetName = "Ogrodowa",
            StreetNumber = 12,
            PostCode = "11-232"
        };

        var address = await _addressService.AddOrUpdateAddress(request);

        Assert.Equal(request.Id, address.Id);
        Assert.Equal(request.City, address.City);
        Assert.Equal(request.StationaryStoreId, address.StationaryStoreId);
        Assert.Equal(request.StreetName, address.StreetName);
    }

    // [Theory]
    // [InlineData(1)]
    // [InlineData(2)]
    // public async Task DeleteStoreAddressTest(int addressId)
    // {
    //     bool doesAddressExistsBefore = await _context.Address.AnyAsync(x => x.Id == addressId);
    //     Assert.True(doesAddressExistsBefore);
    //     await _addressService.DeleteStoreAddress(addressId);
    //     bool doesAddressExistsAfter = await _context.Address.AnyAsync(x => x.Id == addressId);

    //     Assert.False(doesAddressExistsAfter);
    // }
}
