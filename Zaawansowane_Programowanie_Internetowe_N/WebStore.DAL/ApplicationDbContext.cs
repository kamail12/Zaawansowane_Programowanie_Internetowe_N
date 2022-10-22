using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Model;

namespace WebStore.DAL;

public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Address> Addresses { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;
    public DbSet<Order> Orders { get; set; } = default!;
    public DbSet<OrderProduct> OrderProducts { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<OrderProduct>()
        .HasOne(o => o.Order)
        .WithMany(o => o.OrderProducts)
        .HasForeignKey(fk => fk.OrderId);

        builder.Entity<OrderProduct>()
        .HasOne(p => p.Product)
        .WithMany(p => p.OrderProducts)
        .HasForeignKey(fk => fk.ProductId);

        builder.Entity<OrderProduct>()
        .HasKey(op => new { op.OrderId, op.ProductId });

        builder.Entity<User>()
        .ToTable("AspNetUsers")
        .HasDiscriminator<int>("UserType")
        .HasValue<User>(0)
        .HasValue<Customer>(1)
        .HasValue<Supplier>(2)
        .HasValue<StationaryStoreEmployee>(3);
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseLazyLoadingProxies();


    }
}