using Microsoft.AspNetCore.Components.Web; // Import for Blazor components like HeadOutlet
using Microsoft.AspNetCore.Components.WebAssembly.Hosting; // Import for WebAssembly hosting
using BlazorFrontEnd; // Import the namespace for the Blazor application

// Create a WebAssemblyHostBuilder instance with default configurations
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add the root component of the Blazor application to the DOM element with the ID "app"
builder.RootComponents.Add<App>("#app");

// Add the HeadOutlet component to manage elements in the <head> section of the HTML
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register an HttpClient service with a base address set to the host environment's base URI
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5035/") });
// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register the ProductService as a scoped service for dependency injection
builder.Services.AddScoped<ProductService>();

// Build and run the Blazor WebAssembly application
await builder.Build().RunAsync();
