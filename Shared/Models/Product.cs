namespace Shared.Models // Define the namespace for shared models
{
    // Represents a product in the system
    public class Product
    {
        public int Id { get; set; } // Unique identifier for the product
        public string? Name { get; set; } // Name of the product (nullable)
        public decimal Price { get; set; } // Price of the product
        public int Stock { get; set; } // Number of items available in stock
        public Category? Category { get; set; } // Associated category of the product (nullable)
    }
}