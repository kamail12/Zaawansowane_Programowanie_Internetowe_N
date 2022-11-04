using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.DAL.Data;
using WebStore.Model.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;
using Xunit;
namespace WebStore.Tests.UnitTests
{
    public class StoreServicesUnitTests : BaseUnitTests
    {
        private readonly IStoreService _storeService;
        public StoreServicesUnitTests(ApplicationDbContext dbContext,
        IStoreService storeService) : base(dbContext)
        {
            _storeService = storeService;
        }
        [Fact]
        public void GetStoreTest()
        {
            var store = _storeService.GetStore(p => p.Id == 1);
            Assert.NotNull(store);
        }
        [Fact]
        public void GetMultipleStoreTest()
        {
            var stores = _storeService.GetStores(p => p.Id >= 1 && p.Id <= 2);
            Assert.NotNull(stores);
            Assert.NotEmpty(stores);
        }
        [Fact]
        public void GetAllStoreTest()
        {
            var stores = _storeService.GetStores();
            Assert.NotNull(stores);
            Assert.NotEmpty(stores);
            Assert.Equal(stores.Count(), stores.Count());
        }
        [Fact]
        public void AddNewStoreTest()
        {
            var newStoreVm = new AddOrUpdateStoreVm()
            {
                Name = "Store1"
            };
            var createdStore = _storeService.AddOrUpdateStore(newStoreVm);
            Assert.NotNull(createdStore);
        }
        [Fact]
        public void UpdateStoreTest()
        {
            var updateStoreVm = new AddOrUpdateStoreVm()
            {
                Id = 1,
                Name = "Store2"
            };
            var editedStoreVm = _storeService.AddOrUpdateStore(updateStoreVm);
            Assert.NotNull(editedStoreVm);
            Assert.Equal(1, editedStoreVm.Id);
        }
    }
}
