using Shared.Models;

var builder = WebApplication.CreateBuilder(args);

var clientUrl = "http://localhost:5147";

// Add services to the container
builder.Services.AddCors(options =>
{
    // Define a CORS policy to allow requests from the client application
    options.AddPolicy("AllowClientApp",
        builder => builder.WithOrigins(clientUrl) // Allow requests from the specified client URL
                          .AllowAnyMethod()       // Allow all HTTP methods (GET, POST, etc.)
                          .AllowAnyHeader());     // Allow all headers
});

var app = builder.Build();

// Use the defined CORS policy
app.UseCors("AllowClientApp");

// Define a GET endpoint for "/api/products"
app.MapGet("/api/products", () =>
{
    // Return a list of dummy products with associated categories
    return new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 1200m, Stock = 25, Category = new Category { Id = 101, Name = "Electronics" } },
        new Product { Id = 2, Name = "Headphones", Price = 50m, Stock = 100, Category = new Category { Id = 102, Name = "Accessories" } },
        new Product { Id = 3, Name = "Smartphone", Price = 800m, Stock = 50, Category = new Category { Id = 101, Name = "Electronics" } },
        new Product { Id = 4, Name = "Tablet", Price = 300m, Stock = 30, Category = new Category { Id = 101, Name = "Electronics" } },
        new Product { Id = 5, Name = "Smartwatch", Price = 200m, Stock = 75, Category = new Category { Id = 102, Name = "Accessories" } },
        new Product { Id = 6, Name = "Monitor", Price = 400m, Stock = 20, Category = new Category { Id = 101, Name = "Electronics" } }
    };
});

app.Run();

