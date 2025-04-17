using Shared.Models; // Import the shared models namespace to use the Product class
using System.Text.Json; // Import for simplified JSON serialization/deserialization with HttpClient

// Service to manage product-related API calls and caching
public class ProductService
{
    private readonly HttpClient _httpClient; // HttpClient instance for making API calls

    /**
     * The `ProductService` caches the product data in memory (`_cachedProducts`). This ensures that subsequent calls to `GetProductsAsync` 
     * return the cached data instead of making redundant API calls, improving performance and reducing network load.
     * The caching mechanism is simple: it checks if `_cachedProducts` is null before making an API call. If it's not null, it returns the cached data.
     */
    private List<Product>? _cachedProducts; // Cache for storing fetched product data

    // Constructor to inject the HttpClient dependency
    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Asynchronously fetches the list of products from the API.
    /// If the products are already cached, it returns the cached list.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<List<Product>?> GetProductsAsync()
    {
        if (_cachedProducts == null)
        {
            var response = await _httpClient.GetAsync("api/products");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error: Unable to fetch products (Status Code: {response.StatusCode})");
            }

            var contentType = response.Content.Headers.ContentType?.MediaType;
            if (contentType != "application/json")
            {
                throw new Exception("Error: API did not return JSON data.");
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            // Console.WriteLine($"Response: {jsonResponse}");
            // Deserialize the JSON response into a list of Product objects
            _cachedProducts = JsonSerializer.Deserialize<List<Product>>(jsonResponse, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        return _cachedProducts;
    }
}