using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;

namespace WebStore.DAL.DatabaseContext;
public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // chnages address not split chnage to Address enitiyt
    // join BillingAddress and ShippingAddress
    public DbSet<BillingAddress> BillingAddress { get; set; } = default!;
    public DbSet<ShippingAddress> ShippingAddress { get; set; } = default!;
    public DbSet<Category> Category { get; set; } = default!;
    public DbSet<Invoice> Invoice { get; set; } = default!;
    public DbSet<Order> Order { get; set; } = default!;
    public DbSet<OrderProduct> OrderProduct { get; set; } = default!;
    public DbSet<Product> Product { get; set; } = default!;
    public DbSet<StationaryStore> StationaryStore { get; set; } = default!;

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