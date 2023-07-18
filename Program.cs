using learningEFCore.Data;
using learningEFCore.Models;

using SqlServerContainerContext context = new SqlServerContainerContext();

foreach (Customer c in context.Customers)
{
    Console.WriteLine($"Name: {c.FirstLast}");
}



/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();*/