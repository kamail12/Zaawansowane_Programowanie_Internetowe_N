using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModel;

namespace WebStore.DAL.DataAccess
{
    public class DataContext : DbContext
    {

        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users => Set<User>();
    }
}