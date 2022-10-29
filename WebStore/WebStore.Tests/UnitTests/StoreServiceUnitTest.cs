using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.DatabaseContext;
using WebStore.Services.Interfaces;
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
            System.Console.WriteLine(store.Id);
            Assert.NotNull(store);
            Assert.Equal(store.Id, storeId);
        }
    }
}