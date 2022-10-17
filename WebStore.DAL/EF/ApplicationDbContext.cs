using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;

namespace WebStore.DAL.EF
{
public class ApplicationDbContext : IdentityDbContext<User,Role,int>
{
    public virtual DbSet<Order> Orders {get; set; }
    public virtual DbSet<OrderProduct> OrderProducts {get; set; }
    public virtual DbSet<Product> Products {get; set; }
    public virtual DbSet<ProductStock> ProductStocks {get; set; }
    public virtual DbSet<Order> Orders {get; set; }
    public virtual DbSet<Address> Addresses {get; set; }
    public virtual DbSet<Category> Categories {get; set; }
    public virtual DbSet<Invoice> Invoices {get; set; }
    public virtual DbSet<StationaryStore> StationaryStores {get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLazyLoadingProxies();
        }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .ToTable("AspNetUsers")
                .HasDiscriminator<int>("UserType")
                .HasValue<User>((int)RoleValue.User)
                .HasValue<Customer>((int)RoleValue.Customer)
                .HasValue<Supplier>((int)RoleValue.Supplier)
                .HasValue<StationaryStoreEmployee>((int)RoleValue.StationaryStoreEmployee)
        } 
    }
}