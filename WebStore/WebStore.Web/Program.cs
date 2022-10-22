using Microsoft.EntityFrameworkCore;
using WebStore.DAL.DatabaseContext;
using WebStore.Services.Configuration;

var builder = WebApplication.CreateBuilder(args);


// Add auto mapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// Add data context
builder.Services.AddDbContext<WSDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WSDatabaseConntection"));
});


// Add services to the container.

builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
