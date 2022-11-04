using Microsoft.EntityFrameworkCore;
using WebStore.DAL.DatabaseContext;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;
using Xunit;

namespace WebStore.Tests.UnitTests
{
    public class StoreServiceUnitTest : BaseUnitTests
    {
        private readonly WSDbContext _context;
        private readonly IStoreService _storeService;

        public StoreServiceUnitTest(WSDbContext context, IStoreService storeService) : base(context)
        {
            _context = context;
            _storeService = storeService;
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public async Task Handle_ShouldReturnStores(int storeId)
        {
            var store = await _storeService.GetStationaryStoreById(storeId);
            Assert.NotNull(store);
            Assert.Equal(store.Id, storeId);
        }

        [Fact]
        public async void GetAllStoresTest()
        {
            var stores = await _storeService.GetStationaryStores();

            Assert.Equal(2, stores.Count());
        }

        [Fact]
        public async void CheckIsAllDataIncluded()
        {
            var store = await _storeService.GetStationaryStoreById(1);

            Assert.NotNull(store.Addresses);
            Assert.NotNull(store.Employees);
            Assert.NotNull(store.Invoices);

            Assert.Equal(2, store.Employees.Count());
        }

        [Fact]
        public async void ShouldAddStore()
        {
            AddStationaryStoreVm request = new()
            {
                Name = "test store"
            };

            var store = await _storeService.AddStationaryStore(request);

            Assert.NotNull(store);
            Assert.True(store.Id > 0);
        }

        // [Fact]
        // public async Task DeleteStoreTest()
        // {
        //     int storeId = 1;

        //     bool doesStoreExistsBefore = await _context.StationaryStore.AnyAsync(x => x.Id == storeId);
        //     await _storeService.DeleteStationaryStore(storeId);
        //     bool doesStoreExistsAfter = await _context.StationaryStore.AnyAsync(x => x.Id == storeId);

        //     Assert.True(doesStoreExistsBefore);
        //     Assert.False(doesStoreExistsAfter);
        // }
    }
}