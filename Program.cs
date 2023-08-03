using learningEFCore.Data;
using learningEFCore.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SqlServerContainerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerContext")));
builder.Services.AddRazorPages();

var app = builder.Build();

using var scope = app.Services.CreateScope();
var serviceProvider = scope.ServiceProvider;
var context = serviceProvider.GetRequiredService<SqlServerContainerContext>();

var products = context.Products;


foreach (Product p in products)
{
    Console.WriteLine($"Id:    {p.Id}");
    Console.WriteLine($"Name:  {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}

app.UseRouting();

app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    // Add other endpoints as needed.
});

app.Run();