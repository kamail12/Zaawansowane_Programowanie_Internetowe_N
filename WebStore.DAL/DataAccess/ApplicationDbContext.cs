using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;

namespace WebStore.DAL.DataAccess;

public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{

    public virtual DbSet<User> User { get; set; } = default!;
    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; } = default!;
    public virtual DbSet<OrderProduct> OrderProduct { get; set; } = default!;
    public virtual DbSet<Product> Product { get; set; } = default!;
    public virtual DbSet<ProductStock> ProductStock { get; set; } = default!;
    public virtual DbSet<Order> Order { get; set; } = default!;
    public virtual DbSet<Category> Category { get; set; } = default!;
    public virtual DbSet<Invoice> Invoice { get; set; } = default!;
    public virtual DbSet<StationaryStore> StationaryStores { get; set; } = default!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>()
            .ToTable("AspNetUsers")
            .HasDiscriminator<int>("UserType")
            .HasValue<User>(0)
            .HasValue<Customer>(1)
            .HasValue<Supplier>(2)
            .HasValue<StationaryStoreEmployee>(3);

        builder.Entity<OrderProduct>()
            .ToTable("OrderProduct")
            .HasKey(x => new { x.OrderId, x.ProductId });
        builder.Entity<OrderProduct>()
            .HasOne(x => x.Order)
            .WithMany(y => y.OrderProducts)
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.Entity<OrderProduct>()
            .HasOne(x => x.Product)
            .WithMany(y => y.OrderProducts)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}