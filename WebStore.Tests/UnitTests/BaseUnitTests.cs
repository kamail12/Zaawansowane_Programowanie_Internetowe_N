using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebStore.DAL.DataAccess;
namespace WebStore.Tests.UnitTests
{
    public abstract class BaseUnitTests
    {
        protected readonly ApplicationDbContext DbContext;
        public BaseUnitTests(ApplicationDbContext dbContext)
        {
            DbContext = dbContext; ;
        }
    }
}