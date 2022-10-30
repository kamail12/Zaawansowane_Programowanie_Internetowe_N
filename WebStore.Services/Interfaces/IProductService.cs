using System.Linq.Expressions;
using WebStore.Model.DataModels;
using WebStore.ViewModels.Vm;

namespace WebStore.Services.Interface
{
    public interface IProductService
    {
        ProductVm AddOrUpdateProduct (AddOrUpdateProductVm addOrUpdateProductVm);
        ProductVm GetProduct (Expression<Func<Product,bool>> filterExpression);
        IEnumerable<ProductVm> GetProducts (Expression<Func<Product,bool>> ? filterExpression = null);
    }
}