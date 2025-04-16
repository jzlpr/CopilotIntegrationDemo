using Shared.Models;

var builder = WebApplication.CreateBuilder(args);

var clientUrl = "http://localhost:5147";

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowClientApp",
        builder => builder.WithOrigins(clientUrl)
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

var app = builder.Build();

// Use CORS policy
app.UseCors("AllowClientApp");

// app.MapControllers();

app.MapGet("/api/products", () =>
{
    return new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 1200m, Stock = 25 },
        new Product { Id = 2, Name = "Headphones", Price = 50m, Stock = 100 },
        new Product { Id = 3, Name = "Smartphone", Price = 800m, Stock = 50 },
        new Product { Id = 4, Name = "Tablet", Price = 300m, Stock = 30 },
        new Product { Id = 5, Name = "Smartwatch", Price = 200m, Stock = 75 },
        new Product { Id = 6, Name = "Monitor", Price = 400m, Stock = 20 }
    };
});

app.Run();

