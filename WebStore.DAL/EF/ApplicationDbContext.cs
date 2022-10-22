using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;
using Microsoft.AspNetCore.Identity;

namespace WebStore.DAL.ApplicationDbContext;
public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base (options){
            
        public DbSet<User> User => Set<User>();
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Category> Category => Set<Category>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Invoice> Invoice => Set<Invoice>();
        public DbSet<Order> Order => Set<Order>();
        public DbSet<OrderProduct> OrderProduct => Set<OrderProduct>();
        public DbSet<Product> Product => Set<Product>();
        public DbSet<ProductStock> ProductStock => Set<ProductStock>();
        public DbSet<StationaryStore> StationaryStore => Set<StationaryStore>();
        public DbSet<StationaryStoreEmployee> StationaryStoreEmployee => Set<StationaryStoreEmployee>();
        public DbSet<Supplier> Supplier => Set<Supplier>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    } 
}