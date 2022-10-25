using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // Contains class IdentityDbContext
using Microsoft.AspNetCore.Identity; // Contains class IdnetityRole<int>
using Microsoft.EntityFrameworkCore; // Contains class DbContextOpitons
using WebStore.Model.DataModels;


namespace WebStore.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int> // using in brackets class which inherits for class IdentityUser
    {
        //Table Properties
        public virtual DbSet<Order> Orders {get; set;} 
        public virtual DbSet<OrderProduct> OrderProducts {get; set;}
        public virtual DbSet<Product> Products {get; set;}
        public virtual DbSet<ProductStock> ProductStocks {get; set;}
        public virtual DbSet<Address> Addresses {get; set;}
        public virtual DbSet<Category> Categories {get; set;}
        public virtual DbSet<Invoice> Invoices {get; set;}
        public virtual DbSet<StationaryStore> StationaryStores {get; set;}
        public virtual DbSet<StationaryStoreEmployee> StationaryStoreEmployees {get; set;}


        //Constructor call commands from class IdnetityDbContext constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
        {
        }
        //Method responsible for configuration of relation between classes and database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Method force download datas from Database only when it is neccesery
            optionsBuilder.UseLazyLoadingProxies();
        }
        //In method is possible deffinition fluent API command, for example describe inheretance after 'User' class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .ToTable("WebStoreUsers")
                .HasDiscriminator<string>("UserType")
                .HasValue<User>("User")
                .HasValue<Customer>("Customer")
                .HasValue<Supplier>("Supplier");
        }
    }
}