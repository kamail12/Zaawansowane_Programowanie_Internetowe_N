using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebStore.DAL.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<BillingAddress> BillingAddress {get;set;} = default!; //=> Set<BillingAddress>();
        public DbSet<ShippingAddress> ShippingAddress {get;set;} = default!;
        public DbSet<Category> Category {get;set;} = default!;
        public DbSet<Invoice> Invoice {get;set;} = default!;
        public DbSet<Order> Order {get;set;} = default!;
        public DbSet<OrderProduct> OrderProduct {get;set;} = default!;
        public DbSet<Product> Product {get;set;} = default!;
        public DbSet<StationaryStore> StationaryStore {get;set;} = default!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // please define here the TPH 
        }

    }
}