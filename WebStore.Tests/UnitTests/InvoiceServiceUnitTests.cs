using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.DAL.EF;
using WebStore.Model.DataModels;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;
using Xunit;

namespace WebStore.Tests.UnitTests
{
    public class InvoiceServiceUnitTests : BaseUnitTests
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceServiceUnitTests(ApplicationDbContext dbContext, IInvoiceService invoiceService) : base(dbContext)
        {
            _invoiceService = invoiceService;
        }

        [Fact]
        public void GetInvoiceTest()
        {
            var invoice = _invoiceService.GetInvoice(i => i.Id == 1);
            Assert.NotNull(invoice);
        }
        [Fact]
        public void GetMultipleInvoicesTest()
        {
            var invoices = _invoiceService.GetInvoices(i => i.Id >= 1 && i.Id <= 2);
            Assert.NotNull(invoices);
            Assert.NotEmpty(invoices);
            Assert.Equal(2, invoices.Count());
        }

        [Fact]
        public void GetAllInvoicesTest()
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
                DateOfIssue = new DateTime(2022, 10, 25, 11, 25, 34)
            };
            var createInvoice = _invoiceService.AddOrUpdateInvoice(newInvoiceVm);
            Assert.NotNull(createInvoice);
            Assert.Equal(new DateTime(2022, 10, 25, 11, 25, 34), createInvoice.DateOfIssue);
        }
        [Fact]
        public void UpdateNewInvoiceTest()
        {
            var updateInvoiceVm = new AddOrUpdateInvoiceVm()
            {
                DateOfIssue = new DateTime(2022, 10, 25, 12, 00, 00)
            };
            var editetInvoiceVm = _invoiceService.AddOrUpdateInvoice(updateInvoiceVm);
            Assert.NotNull(editetInvoiceVm);
            Assert.Equal(new DateTime(2022, 10, 25, 12, 00, 00), updateInvoiceVm.DateOfIssue);
        }

    }
}