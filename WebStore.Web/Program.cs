using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Webstore.Model;
using WebStore.DAL.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

builder.Services.AddIdentity<User, IdentityRole<int>>(o =>
{
    o.Password.RequireDigit = false;
    o.Password.RequireUppercase = false;
    o.Password.RequireLowercase = false;
    o.Password.RequireNonAlphanumeric = false;
    o.User.RequireUniqueEmail = false;
}).AddRoleManager<RoleManager<IdentityRole<int>>>()
    .AddUserManager<UserManager<User>>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddAntiforgery(options => options.HeaderName = "X-XSRF-TOKEN");
builder.Services.AddTransient(typeof(ILogger), typeof(Logger<Program>));
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
});

builder.Services.AddControllersWithViews()
.AddNewtonsoftJson(options =>
options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebStore API", Version = "v1" });
});
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebStore API v1"));
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
name: "default",
pattern: "{controller}/{action=Index}/{id?}");
app.MapFallbackToFile("index.html"); ;
app.Run();