using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using WebStore.DAL.DataAccess;
using WebStore.Model.DataModel;
using WebStore.Services.Interfaces;
using WebStore.ViewModels.VM;



namespace WebStore.Services.ConcreteServices;

public class ProductService : BaseService, IProductService
{
    public ProductService(ApplicationDbContext dbContext, IMapper mapper, ILogger logger)
    : base(dbContext, mapper, logger) { }

    public ProductVm AddOrUpdateProduct(AddOrUpdateProductVm addOrUpdateProductVm)
    {
        try
        {
            if (addOrUpdateProductVm == null)
                throw new ArgumentNullException("View model parameter is null");
            var productEntity = Mapper.Map<Product>(addOrUpdateProductVm);
            if (addOrUpdateProductVm.Id.HasValue || addOrUpdateProductVm.Id == 0)
                DbContext.Products.Update(productEntity);
            else
                DbContext.Products.Add(productEntity);
            DbContext.SaveChanges();
            var productVm = Mapper.Map<ProductVm>(productEntity);
            return productVm;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, ex.Message);
            throw;
        }
    }

    public ProductVm GetProduct(Expression<Func<Product, bool>> filterExpression)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ProductVm> GetProducts(Expression<Func<Product, bool>>? filterExpression = null)
    {
        throw new NotImplementedException();
    }
}
