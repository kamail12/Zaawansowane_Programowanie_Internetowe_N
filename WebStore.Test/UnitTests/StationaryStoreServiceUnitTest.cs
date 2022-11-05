using WebStore.DAL.EF; 
using WebStore.Services.Interface; 
using WebStore.ViewModels.Vm; 


namespace WebStore.Test.UnitTest
{
    public class StationaryStoreServiceUnitTest : BaseUnitTest
    {
        private readonly IStationaryStoreService _stationaryStoreService;

        public StationaryStoreServiceUnitTest(ApplicationDbContext dbContext, IStationaryStoreService stationaryStoreService) 
        :base(dbContext)
        {
            _stationaryStoreService = stationaryStoreService;
        }

        [Fact]
        public void GetStationaryStoreTest()
        {
            
            var stationaryStore = _stationaryStoreService.GetStationaryStore(s => s.Name  == "Tylko w SOFTWARE");
            Assert.NotNull (stationaryStore); 
        }

        [Fact]
        public void GetMultipleStationaryStoresTest()
        {
            var stationaryStores = _stationaryStoreService.GetStationaryStores(o => o.Id >= 1 && o.Id <= 2);
            Assert.NotNull(stationaryStores);
            Assert.NotEmpty(stationaryStores);
            Assert.Equal(2, stationaryStores.Count());
        }

        [Fact]
        public void GetAllStationaryStoreTest()
        {
            var stationaryStores = _stationaryStoreService.GetStationaryStores();
            Assert.NotNull(stationaryStores);
            Assert.NotEmpty(stationaryStores);
            Assert.Equal(stationaryStores.Count(), stationaryStores.Count());
        }

        [Fact]
        public void AddNewStationaryStoreTest()
        {
            var newStationaryStoreVm = new AddOrUpdateStationaryStoreVm
            {
                Name = "TYLKO HARDWARE"
            };
            var createdStationaryStore = _stationaryStoreService.AddOrUpdateStationaryStore(newStationaryStoreVm);
            Assert.NotNull(createdStationaryStore);
            Assert.Equal("TYLKO HARDWARE", createdStationaryStore.Name);
        }

        [Fact]
        public void UpdateStationaryStoreTest()
        {
            var updateStationaryStoreVm = new AddOrUpdateStationaryStoreVm()
            {
                Id = 2,
                Name = "Tylko HARDWARE"
            };

            var editedStationaryStoreVm = _stationaryStoreService.AddOrUpdateStationaryStore (updateStationaryStoreVm);
            Assert.NotNull(editedStationaryStoreVm);
            Assert.Equal("Tylko HARDWARE", editedStationaryStoreVm.Name);
        }
    }
}