using Microsoft.AspNetCore.Identity; 
using Microsoft.Extensions.DependencyInjection; 
using WebStore.DAL.EF; 
using WebStore.Model.DataModels;

namespace WebStore.Test
{
    public static class Extensions
    {
        //Create sample data
        public static async void SeedData (this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider ();
            var dbContext = serviceProvider.GetRequiredService<ApplicationDbContext> ();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>> ();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();

            //other seed data...

            //Suppliers
            var supplier1 = new Supplier () 
            {
                Id = 1,
                FirstName = "Adam",
                LastName = "Bednarski",
                UserName = "supp1@eg.eg", 
                Email = "supp1@eg.eg", 
                RegistrationDate = new DateTime (2010, 1, 1),
            };
            await userManager.CreateAsync (supplier1, "User1234");

            //Customers
            var customer1 = new Customer () 
            {
                Id = 2,
                FirstName = "Cezary",
                LastName = "Kubek",
                UserName = "cust1@eg.eg", 
                Email = "cust1@eg.eg", 
                RegistrationDate = new DateTime (2020, 2, 2),
            };
            await userManager.CreateAsync (customer1, "User4321");

            //Categories
            var category1 = new Category () 
            { 
                Id = 1, Name = "Computers",
                //Tag = "#computer" 
            };
            await dbContext.AddAsync (category1);

            //Products 
            var p1 = new Product () 
            { 
                Id = 1, 
                CategoryId = category1.Id, 
                SupplierId = supplier1.Id, 
                Description = "Bardzo praktyczny monitor 32 cale", 
                ImageBytes = new byte[] { 0xff, 0xff, 0xff, 0x80 }, 
                Name = "Monitor Dell 32", 
                Price = 1000, 
                Weight = 20,
            }; 
            await dbContext.AddAsync (p1); 
            
            var p2 = new Product () 
            { 
                Id = 2, 
                CategoryId = category1.Id, 
                SupplierId = supplier1.Id, 
                Description = "Precyzyjna mysz do pracy", 
                ImageBytes = new byte[] { 0xff, 0xff, 0xff, 0x70 }, 
                Name = "Mysz Logitech", 
                Price = 500, 
                Weight = 0.5f,
            };
            await dbContext.AddAsync (p2); 

            //Invoices
            var i1 = new Invoice()
            {
                Id = 1,
                TotalAmount = 20,
                //Orders = {new Order(), new Order()}
            } ;
            await dbContext.AddAsync (i1);

            var i2 = new Invoice()
            {
                Id = 2,
                TotalAmount = 400,
                //Orders = {new Order(), new Order()}
            } ;
            await dbContext.AddAsync (i2);

            //Orders
            var o1 = new Order()
            {
                Id = 1,
                CustomerId = customer1.Id,
                InvoiceId = i1.Id,
                DeliveryDate = new DateTime(2021, 5, 1),
                OrderDate = new DateTime(2021, 5, 10),
                TrackingNumber = 1234567890
            };
            await dbContext.AddAsync (o1);

            var o2 = new Order()
            {
                Id = 2,
                CustomerId = customer1.Id,
                InvoiceId = i1.Id,
                DeliveryDate = new DateTime(2022, 5, 2),
                OrderDate = new DateTime(2022, 5, 20),
                TrackingNumber = 78654321
            };
            await dbContext.AddAsync (o2);

            //StarionaryStores
            var store1 = new StationaryStore()
            {
                Id = 1,
                Name = "Kabelki i nie tylko"
                //TODO Add adrress and Employes lists
            };
            await dbContext.AddAsync (store1);

            var store2 = new StationaryStore()
            {
                Id = 2,
                Name = "Tylko w SOFTWARE"
                //TODO Add adrress and Employes lists
            };
            await dbContext.AddAsync (store2);
            
            // save changes 
            await dbContext.SaveChangesAsync ();
        }
    }
}