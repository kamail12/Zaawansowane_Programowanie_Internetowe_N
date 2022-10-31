using WebStore.DAL.EF;
namespace WebStore.Test.UnitTest
{
    public abstract class BaseUnitTest
    {
        protected readonly ApplicationDbContext DbContext;

        public BaseUnitTest(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}