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
    public class AddressServicesUnitTests : BaseUnitTests
    {
        private readonly IAddressService _addressService;
        public AddressServicesUnitTests(ApplicationDbContext dbContext,
        IAddressService addressService) : base(dbContext)
        {
            _addressService = addressService;
        }
        [Fact]
        public void GetAddressTest()
        {
            var address = _addressService.GetAddress(p => p.Id == 2);
            Assert.NotNull(address);
            //Assert.Equal(address.StreetName, "Czestochowska");
        }
        [Fact]
        public void GetMultipleAddressTest()
        {
            var addresses = _addressService.GetAddresses(p => p.Id >= 1 && p.Id <= 2);
            Assert.NotNull(addresses);
            Assert.NotEmpty(addresses);
            Assert.Equal(2, addresses.Count());
        }
        [Fact]
        public void GetAllAddressesTest()
        {
            var addresses = _addressService.GetAddresses();
            Assert.NotNull(addresses);
            Assert.NotEmpty(addresses);
            Assert.Equal(addresses.Count(), addresses.Count());
        }
        [Fact]
        public void AddNewAddressTest()
        {
            var newAddressVm = new AddOrUpdateAddressVm()
            {
                City = "Koszecin",
                StreetName = "Lubliniecka"
            };
            var createdAddress = _addressService.AddOrUpdateAddress(newAddressVm);
            Assert.NotNull(createdAddress);
            Assert.Equal("Koszecin", createdAddress.City);
        }
        [Fact]
        public void UpdateAddressTest()
        {
            var updateAddressVm = new AddOrUpdateAddressVm()
            {
                Id = 1,
                City = "Koszecin2",
                StreetName = "Lubliniecka2"
            };
            var editedAddressVm = _addressService.AddOrUpdateAddress(updateAddressVm);
            Assert.NotNull(editedAddressVm);
            Assert.Equal("Koszecin2", editedAddressVm.City);
            Assert.Equal("Lubliniecka2", editedAddressVm.StreetName);
        }
    }
}
