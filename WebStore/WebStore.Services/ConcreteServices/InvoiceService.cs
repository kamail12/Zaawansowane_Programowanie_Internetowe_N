using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using WebStore.DAL.DatabaseContext;
using WebStore.Model.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;

namespace WebStore.Services.ConcreteServices;
public class InvoiceService : BaseService, IInvoiceService
{
    public InvoiceService(WSDbContext context, IMapper mapper, ILogger logger) : base(context, mapper, logger) { }

    public InvoiceVm AddOrUpdateInvoice(AddOrUpdateInvoiceVm addOrUpdateInvoiceVm)
    {
        try
        {
            if (addOrUpdateInvoiceVm == null)
                throw new ArgumentNullException("View model parameter is null");

            var InvoiceEntity = Mapper.Map<Invoice>(addOrUpdateInvoiceVm);

            if (addOrUpdateInvoiceVm.Id.HasValue || addOrUpdateInvoiceVm.Id == 0)
                DbContext.Invoice.Update(InvoiceEntity);
            else
                DbContext.Invoice.Add(InvoiceEntity);

            DbContext.SaveChanges();

            var InvoiceVm = Mapper.Map<InvoiceVm>(InvoiceEntity);

            return InvoiceVm;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }
    public InvoiceVm GetInvoice(Expression<Func<Invoice, bool>> filterExpression)
    {
        try
        {
            if (filterExpression == null)
                throw new ArgumentNullException("Filter expression parameter is null");
            var InvoiceEntity = DbContext.Invoice.FirstOrDefault(filterExpression);
            var InvoiceVm = Mapper.Map<InvoiceVm>(InvoiceEntity);
            return InvoiceVm;
        }

        catch (Exception ex)
        {
            {
                Logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
    public IEnumerable<InvoiceVm> GetInvoices(Expression<Func<Invoice, bool>>? filterExpression = null)
    {
        try
        {
            var InvoicesQuery = DbContext.Invoice.AsQueryable();
            if (filterExpression != null)
                InvoicesQuery = InvoicesQuery.Where(filterExpression);
            var InvoiceVms = Mapper.Map<IEnumerable<InvoiceVm>>(InvoicesQuery);

            return InvoiceVms;
        }

        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }

    public async Task DeleteInvoice(int InvoiceId)
    {
        try
        {
            var InvoiceEntity = DbContext.Invoice
                .FirstOrDefault(x => x.Id == InvoiceId);

            if (InvoiceEntity == null)
            {
                throw new Exception("Invoice not found");
            }

            DbContext.Invoice.Remove(InvoiceEntity);

            await DbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }
}
