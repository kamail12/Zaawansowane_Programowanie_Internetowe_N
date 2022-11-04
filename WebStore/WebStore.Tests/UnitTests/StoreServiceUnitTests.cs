using Microsoft.EntityFrameworkCore;
using WebStore.DAL.DatabaseContext;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;
using Xunit;

namespace WebStore.Tests.UnitTests;
public class StoreServiceUnitTests : BaseUnitTests
{
    private readonly IStoreService _service;
    private readonly WSDbContext _context;
    public StoreServiceUnitTests(WSDbContext dbContext,
        IStoreService storeService) : base(dbContext)
    {
        _service = storeService;
        _context = dbContext;
    }

    [Fact]
    public void GetStationaryStoreTest()
    {
        var StationaryStore = _service.GetStationaryStore(p => p.Name == "Store 3");
        Assert.NotNull(StationaryStore);
    }

    [Fact]
    public void GetMultipleStationaryStoresTest()
    {
        var StationaryStores = _service.GetStationaryStores(p => p.Id >= 1 && p.Id <= 2);
        Assert.NotNull(StationaryStores);
        Assert.NotEmpty(StationaryStores);
        Assert.Equal(2, StationaryStores.Count());
    }

    [Fact]
    public void GetAllStationaryStoresTest()
    {
        var StationaryStores = _service.GetStationaryStores();
        Assert.NotNull(StationaryStores);
        Assert.NotEmpty(StationaryStores);
        Assert.Equal(StationaryStores.Count(), StationaryStores.Count());
    }

    [Fact]
    public void AddNewStationaryStoreTest()
    {
        var newStationaryStoreVm = new AddOrUpdateStationaryStoreVm()
        {
            Name = "New Store",
        };

        var createdStationaryStore = _service.AddOrUpdateStationaryStore(newStationaryStoreVm);
        Assert.NotNull(createdStationaryStore);
        Assert.Equal("New Store", createdStationaryStore.Name);
    }

    [Fact]
    public void UpdateStationaryStoreTest()
    {
        var updateStationaryStoreVm = new AddOrUpdateStationaryStoreVm()
        {
            Id = 1,
            Name = "new name"
        };
        var editedStationaryStoreVm = _service.AddOrUpdateStationaryStore(updateStationaryStoreVm);
        Assert.NotNull(editedStationaryStoreVm);
        Assert.Equal("new name", editedStationaryStoreVm.Name);
    }

    [Fact]
    public async Task DeleteStationaryStoreTest()
    {
        int StationaryStoreId = 3;

        bool doesStationaryStoreExistsBefore = await _context.StationaryStore.AnyAsync(x => x.Id == StationaryStoreId);
        await _service.DeleteStationaryStore(StationaryStoreId);
        bool doesStationaryStoreExistsAfter = await _context.StationaryStore.AnyAsync(x => x.Id == StationaryStoreId);

        Assert.True(doesStationaryStoreExistsBefore);
        Assert.False(doesStationaryStoreExistsAfter);
    }
}
