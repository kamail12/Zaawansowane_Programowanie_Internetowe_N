using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using WebStore.DAL.Data;
using WebStore.Model.Models;
namespace WebStore.Tests
{
    public static class Extensions
    {
        // Create sample data
        public static async void SeedData(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var dbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = serviceProvider
            .GetRequiredService<RoleManager<IdentityRole<int>>>();
            // other seed data ...
            //Suppliers
            var supplier1 = new Supplier()
            {
                Id = 1,
                FirstName = "Adam",
                LastName = "Bednarski",
                UserName = "supp1@eg.eg",
                Email = "supp1@eg.eg",
                RegistrationDate = new DateTime(2010, 1, 1),
            };
            await userManager.CreateAsync(supplier1, "User1234");
            var p1 = new Product()
            {
                Id = 1,
                SupplierId = supplier1.Id,
                Description = "Bardzo praktyczny monitor 32 cale",
                ImageBytes = new byte[] { 0xff, 0xff, 0xff, 0x80 },
                Name = "Monitor Dell 32",
                Price = 1000,
                Weight = 20,
            };
            await dbContext.AddAsync(p1);
            var p2 = new Product()
            {
                Id = 2,
                SupplierId = supplier1.Id,
                Description = "Precyzyjna mysz do pracy",
                ImageBytes = new byte[] { 0xff, 0xff, 0xff, 0x70 },
                Name = "Mysz Logitech",
                Price = 500,
                Weight = 0.5f,
            };
            await dbContext.AddAsync(p2);

            // invoices
            var i1 = new Invoice()
            {
                Id = 1,
                TotalPrice = 100,
            };

            await dbContext.AddAsync(i1);


            // orders
            var o1 = new Order()
            {
                Id = 1,
                CustomerId = 1,
                OrderDate = new DateTime(2010, 1, 1),
                DeliveryDate = new DateTime(2012, 1, 1),
                TotalAmount = 10,
                TrackingNumber = 1234,
                InvoiceId = 1,
            };

            await dbContext.AddAsync(o1);

            var a1 = new Address()
            {
                Id = 1,
                City = "Lubliniec",
                StreetName = "Lubliniecka"
            };

            var a2 = new Address()
            {
                Id = 2,
                City = "Czestochowa",
                StreetName = "Czestochowska"
            };

            await dbContext.AddRangeAsync(a1, a2);

            var inv1 = new Invoice()
            {
                Id = 3,
                TotalPrice = 747
            };

            await dbContext.AddAsync(inv1);

            var ord1 = new Order()
            {
                CustomerId = 1,
                InvoiceId = 2,
                TotalAmount = 3
            };

            await dbContext.AddRangeAsync(o1);

            var st1 = new StationaryStore()
            {
                Id = 1,
                Name = "Store1"
            };

            await dbContext.AddAsync(st1);

            // save changes
            await dbContext.SaveChangesAsync();
        }
    }
}