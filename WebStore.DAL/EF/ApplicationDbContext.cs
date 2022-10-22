using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;
using Microsoft.AspNetCore.Identity;

namespace WebStore.DAL.ApplicationDbContext;
public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base (options)
    { }
        
        public virtual DbSet<User> User { get; set; } = default!;
        public virtual DbSet<Address> Addresses { get; set; } = default!;
        public virtual DbSet<Category> Category { get; set; } = default!;
        public virtual DbSet<Customer> Customers { get; set; } = default!;
        public virtual DbSet<Invoice> Invoice { get; set; } = default!;    
        public virtual DbSet<Order> Order { get; set; } = default!;
        public virtual DbSet<OrderProduct> OrderProduct { get; set; } = default!;
        public virtual DbSet<Product> Product { get; set; } = default!;
        public virtual DbSet<ProductStock> ProductStock { get; set; } = default!;
        public virtual DbSet<StationaryStore> StationaryStore { get; set; } = default!;
        public virtual DbSet<StationaryStoreEmployee> StationaryStoreEmployee { get; set; } = default!;
        public virtual DbSet<Supplier> Supplier { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
            .ToTable("ApsNetUsers")
            .HasDiscriminator<int>("UserType")
            .HasValue<User>(0)
            .HasValue<Customer>(1)
            .HasValue<Supplier>(2)
            .HasValue<StationaryStoreEmployee>(3);

            modelBuilder.Entity<OrderProduct>()
            .ToTable("OrderProduct")
            .HasKey( x => new {x.OrderId, x.ProductId});

            modelBuilder.Entity<OrderProduct>()
            .HasOne(x => x.Order)
            .WithMany(y => y.OrderProducts);

            modelBuilder.Entity<OrderProduct>()
            .HasOne(x => x.Product)
            .WithMany(y => y.OrderProducts);
        }


    }
