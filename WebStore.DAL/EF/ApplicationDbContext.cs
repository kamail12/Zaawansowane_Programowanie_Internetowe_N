using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;

namespace WebStore.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {

        public virtual DbSet<Address> Addresses { get; set; } = default!;
        public virtual DbSet<Category> Categories { get; set; } = default!;
        public virtual DbSet<Invoice> Invoices { get; set; } = default!;
        public virtual DbSet<Order> Orders { get; set; } = default!;
        public virtual DbSet<OrderProduct> OrderProducts { get; set; } = default!;
        public virtual DbSet<Product> Products { get; set; } = default!;
        public virtual DbSet<ProductStock> ProductStocks { get; set; } = default!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>()
                .ToTable("tbl_Users")
                .HasDiscriminator<int>("UserType")
                .HasValue<User>(0)
                .HasValue<Customer>(1)
                .HasValue<Supplier>(2)
                .HasValue<StationeryStoreEmployee>(3);
            builder.Entity<Address>().ToTable("tbl_Adresses");
            builder.Entity<Category>().ToTable("tbl_Categories");
            builder.Entity<Invoice>().ToTable("tbl_Invoices");
            builder.Entity<Order>().ToTable("tbl_Orders");
            builder.Entity<OrderProduct>().ToTable("tbl_OrderProducts");
            builder.Entity<Product>().ToTable("tbl_Product");
            builder.Entity<ProductStock>().ToTable("tbl_ProductStocks");
            builder.Entity<StationaryStore>().ToTable("tbl_StationaryStore");

        }

    }
}