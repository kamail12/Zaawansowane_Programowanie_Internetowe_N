using Microsoft.EntityFrameworkCore;
using WebStore.DAL.DatabaseContext;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;
using Xunit;

namespace WebStore.Tests.UnitTests;
public class InvoiceServiceUnitTests : BaseUnitTests
{
    private readonly IInvoiceService _InvoiceService;
    private readonly WSDbContext _context;
    public InvoiceServiceUnitTests(WSDbContext dbContext,
        IInvoiceService InvoiceService) : base(dbContext)
    {
        _InvoiceService = InvoiceService;
        _context = dbContext;
    }

    [Fact]
    public void GetInvoiceTest()
    {
        var Invoice = _InvoiceService.GetInvoice(p => p.TotalPrice == 1423);
        Assert.NotNull(Invoice);
    }

    [Fact]
    public void GetMultipleInvoicesTest()
    {
        var Invoices = _InvoiceService.GetInvoices(p => p.Id >= 1 && p.Id <= 2);
        Assert.NotNull(Invoices);
        Assert.NotEmpty(Invoices);
        Assert.Equal(2, Invoices.Count());
    }

    [Fact]
    public void GetAllInvoicesTest()
    {
        var Invoices = _InvoiceService.GetInvoices();
        Assert.NotNull(Invoices);
        Assert.NotEmpty(Invoices);
        Assert.Equal(Invoices.Count(), Invoices.Count());
    }

    [Fact]
    public void AddNewInvoiceTest()
    {
        var newInvoiceVm = new AddOrUpdateInvoiceVm()
        {
            TotalPrice = 200,
            Date = new DateTime(2010, 12, 11),
            StationaryStoreId = 1,
        };
        var createdInvoice = _InvoiceService.AddOrUpdateInvoice(newInvoiceVm);
        Assert.NotNull(createdInvoice);
        Assert.Equal(200, newInvoiceVm.TotalPrice);
    }

    [Fact]
    public void UpdateInvoiceTest()
    {
        var updateInvoiceVm = new AddOrUpdateInvoiceVm()
        {
            Id = 1,
            TotalPrice = 200,
            Date = new DateTime(2013, 10, 5),
            StationaryStoreId = 1,
        };
        var editedInvoiceVm = _InvoiceService.AddOrUpdateInvoice(updateInvoiceVm);
        Assert.NotNull(editedInvoiceVm);
        Assert.Equal(new DateTime(2013, 10, 5), editedInvoiceVm.Date);
        Assert.Equal(200, editedInvoiceVm.TotalPrice);
    }

    [Fact]
    public async Task DeleteInvoiceTest()
    {
        int InvoiceId = 3;

        bool doesInvoiceExistsBefore = await _context.Invoice.AnyAsync(x => x.Id == InvoiceId);
        await _InvoiceService.DeleteInvoice(InvoiceId);
        bool doesInvoiceExistsAfter = await _context.Invoice.AnyAsync(x => x.Id == InvoiceId);

        Assert.True(doesInvoiceExistsBefore);
        Assert.False(doesInvoiceExistsAfter);
    }
}
