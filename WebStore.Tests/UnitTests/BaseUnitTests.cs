using WebStore.DAL.EF;

namespace WebStore.Tests.UnitTests{
    public class BaseUnitTests
    {
        protected readonly ApplicationDbContext dbContext;
        public BaseUnitTests (ApplicationDbContext dbContext){
            DbContext = dbContext;
        }
    }
}