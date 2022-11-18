using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;

namespace WebStore.DAL.EF;

public class ApplicationDbContext : IdentityDbContext<User,IdentityRole<int>,int>
{
    public DbSet<User> User => Set<User>();
    public DbSet<Address> Addresses => Set<Address>();
    public DbSet<OrderProduct> OrderProduct => Set<OrderProduct>();
    public DbSet<Product> Product => Set<Product>()!;
    public DbSet<ProductStock> ProductStock => Set<ProductStock>();
    public DbSet<Order> Order => Set<Order>();
    public DbSet<Category> Category => Set<Category>();
    public DbSet<Invoice> Invoice => Set<Invoice>();
    public DbSet<StationaryStore> StationaryStore => Set<StationaryStore>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        base.OnConfiguring(optionsBuilder);
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        

        modelBuilder.Entity<User>()
            .ToTable("AspNetUsers")
            .HasDiscriminator<int>("UserType")
            .HasValue<User>(0)
            .HasValue<Customer>(1)
            .HasValue<Supplier>(2)
            .HasValue<StationaryStoreEmployee>(3);

        modelBuilder.Entity<OrderProduct>()
            .ToTable("OrderProduct")
            .HasKey(x => new { x.OrderId, x.ProductId });
        modelBuilder.Entity<OrderProduct>()
            .HasOne(x => x.Order)
            .WithMany(y => y.OrderProducts)
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<OrderProduct>()
            .HasOne(x => x.Product)
            .WithMany(y => y.OrderProducts)
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Cascade);



            // .HasOne(o => o.Order)
            // .WithMany(op => op.OrderProducts)
            // .HasForeignKey(ord => ord.OrderId)
            // .OnDelete(DeleteBehavior.Restrict);
    }


                
}
