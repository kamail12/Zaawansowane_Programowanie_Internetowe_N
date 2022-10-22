using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebStore.DAL.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<User> User => Set<User>();
        public DbSet<BillingAddress> BillingAddress => Set<BillingAddress>();
        public DbSet<ShippingAddress> ShippingAddress => Set<ShippingAddress>();
        public DbSet<Customer> Customer => Set<Customer>();
        public DbSet<Supplier> Supplier => Set<Supplier>();
        public DbSet<Category> Category => Set<Category>();
        public DbSet<Invoice> Invoice => Set<Invoice>();
        public DbSet<Order> Order => Set<Order>();
        public DbSet<OrderProduct> OrderProduct => Set<OrderProduct>();
        public DbSet<Product> Product => Set<Product>();
        public DbSet<StationaryStore> StationaryStore => Set<StationaryStore>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        }

    }
}