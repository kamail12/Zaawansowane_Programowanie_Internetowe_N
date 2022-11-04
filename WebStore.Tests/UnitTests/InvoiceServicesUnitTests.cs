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
    public class InvoiceServicesUnitTests : BaseUnitTests
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceServicesUnitTests(ApplicationDbContext dbContext,
        IInvoiceService invoiceService) : base(dbContext)
        {
            _invoiceService = invoiceService;
        }
        [Fact]
        public void GetInvoiceTest()
        {
            var invoice = _invoiceService.GetInvoice(p => p.StationaryStoreId == 2);
            Assert.NotNull(invoice);
        }
        [Fact]
        public void GetMultipleInvoiceTest()
        {
            var invoices = _invoiceService.GetInvoices(p => p.Id >= 1 && p.StationaryStoreId <= 2);
            Assert.NotNull(invoices);
            Assert.NotEmpty(invoices);
            Assert.Equal(2, invoices.Count());
        }
        [Fact]
        public void GetAllInvoiceTest()
        {
            var invoices = _invoiceService.GetInvoices();
            Assert.NotNull(invoices);
            Assert.NotEmpty(invoices);
            Assert.Equal(invoices.Count(), invoices.Count());
        }
        [Fact]
        public void AddNewInvoiceTest()
        {
            var newInvoiceVm = new AddOrUpdateInvoiceVm()
            {
                TotalPrice = 123,
                StationaryStoreId = 2,
            };
            var createdInvoice = _invoiceService.AddOrUpdateInvoice(newInvoiceVm);
            Assert.NotNull(createdInvoice);
            Assert.Equal(123, createdInvoice.TotalPrice);
        }
        [Fact]
        public void UpdateInvoiceTest()
        {
            var updateInvoiceVm = new AddOrUpdateInvoiceVm()
            {
                Id = 1,
                TotalPrice = 222,
                StationaryStoreId = 2
            };
            var editedInvoicesVm = _invoiceService.AddOrUpdateInvoice(updateInvoiceVm);
            Assert.NotNull(editedInvoicesVm);
            Assert.Equal(1, editedInvoicesVm.Id);
            Assert.Equal(2, editedInvoicesVm.StationaryStoreId);
        }
    }
}
