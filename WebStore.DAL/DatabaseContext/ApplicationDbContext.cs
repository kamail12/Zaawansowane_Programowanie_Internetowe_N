using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;

namespace WebStore.DAL.DatabaseContext;
public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> User => Set<User>();
    public DbSet<BillingAddress> BillingAddress => Set<BillingAddress>();
    public DbSet<ShippingAddress> ShippingAddress => Set<ShippingAddress>();
    public DbSet<Category> Category => Set<Category>();
    public DbSet<Invoice> Invoice => Set<Invoice>();
    public DbSet<Order> Order => Set<Order>();
    public DbSet<OrderProduct> OrderProduct => Set<OrderProduct>();
    public DbSet<Product> Product => Set<Product>();
    public DbSet<StationaryStore> StationaryStore => Set<StationaryStore>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}