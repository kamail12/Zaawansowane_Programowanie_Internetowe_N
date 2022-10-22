using Microsoft.AspNetCore.Identity;
using WebStore.Services.Interfaces; 
using Microsoft.IdentityModel.Tokens; 
using System.Text; 
using WebStore.ViewModels.VM;
using Microsoft.OpenApi.Models;
using WebStore.Model.DataModels; 
using WebStore.Services.Configuration; 
using Microsoft.AspNetCore.Authentication.JwtBearer;
using WebStore.Services.ConcreteServices;
using WebStore.DAL.EF;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); 
// Add services to the container. 
builder.Services.AddAutoMapper(typeof(MainProfile)); 
builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")) //here you can define a database type. 
); 
builder.Services.Configure<JwtOptionsVm>(options =>builder.Configuration.GetSection("JwtOptions").Bind(options)); 
builder.Services.AddIdentity<User, IdentityRole<int>>(o => 
{ 
    o.Password.RequireDigit = false; 
    o.Password.RequireUppercase = false; 
    o.Password.RequireLowercase = false; 
    o.Password.RequireNonAlphanumeric = false; 
    o.User.RequireUniqueEmail = false; 
    }) .AddRoleManager<RoleManager<IdentityRole<int>>>() 
        .AddUserManager<UserManager<User>>() 
        .AddEntityFrameworkStores<ApplicationDbContext>() 
        .AddDefaultTokenProviders(); 
    builder.Services.AddAntiforgery(options => options.HeaderName = "X-XSRF-TOKEN"); 
    builder.Services.AddTransient(typeof(ILogger), typeof(Logger<Program>)); 
    builder.Services.AddScoped<IProductService, ProductService>(); 
    builder.Services.AddScoped<IAddressService, AddressService>(); 
    builder.Services.AddAuthentication(options => 
            { 
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; 
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; 
            }) 
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
{
