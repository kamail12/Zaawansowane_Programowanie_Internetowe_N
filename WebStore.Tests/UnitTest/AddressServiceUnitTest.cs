using WebStore.DAL.EF;
using WebStore.Model.DataModels;
using WebStore.Services.Interface;
namespace WebStore.Test.UnitTest
{
    public class AddressServiceUnitTest : BaseUnitTest
    {
        private readonly IAddressService _addressService;
        public AddressServiceUnitTest(ApplicationDbContext dbContext, IAddressService addressService) 
        : base(dbContext)
        {
            _addressService = addressService;
        }


        [Fact]
        public void UpdateAddressTest()
        {
            var updateAddressVm = new AddOrUpdateAddressVm()
            {
                Id = 2,
                City = "Czestochowa",
                Street = "Lodzka",
                ZipCode = 42210
            };

            var editedAddressVm = _addressService.AddOrUpdateAddress (updateAddressVm);
            Assert.NotNull(editedAddressVm);
            Assert.Equal(42210, editedAddressVm.ZipCode);
        }
    }
}