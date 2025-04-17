# CopilotIntegrationDemo (InventoryHub)

This repository contains a demo project showcasing the integration of a Blazor Frontend with a Minimal API Backend. The project is structured into three main components: `BlazorFrontEnd`, `MinimalAPIBackEnd`, and `Shared`.

## Project Structure

```plaintext
CopilotIntegrationDemo.sln
├── BlazorFrontEnd/
│   ├── Pages/
│   │   ├── FetchProducts.razor
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   ├── NavMenu.razor
│   ├── Services/
│   │   ├── ProductService.cs
│   ├── wwwroot/
│   ├── BlazorFrontEnd.csproj
│   ├── App.razor
│   └── _Imports.razor
├── MinimalAPIBackEnd/
│   ├── Program.cs
│   ├── MinimalAPIBackEnd.csproj
│   ├── appsettings.json
│   └── appsettings.Development.json
├── Shared/
│   ├── Models/
│   │   ├── Product.cs
│   │   ├── Category.cs
│   ├── Shared.csproj
└── CopilotIntegrationDemo.sln
```

## Components

### 1. **BlazorFrontEnd**

- A Blazor WebAssembly project that serves as the frontend for the application.
- Key Features:
  - Fetches and displays a list of products from the backend API.
  - Implements a user-friendly interface using Razor components.
  - Uses `ProductService` to manage API calls and cache product data to reduce redundant API calls.
- Notable Files:
  - `Pages/FetchProducts.razor`: Displays the product list fetched from the backend.
  - `Services/ProductService.cs`: Handles API calls and caches product data.
  - `Layout/MainLayout.razor` and `Layout/NavMenu.razor`: Define the layout and navigation for the application.

### 2. **MinimalAPIBackEnd**

- A Minimal API project that serves as the backend for the application.
- Key Features:
  - Exposes a REST API endpoint (`/api/products`) to fetch product data.
  - Provides mock product data for demonstration purposes.
  - Returns JSON responses to ensure compatibility with the frontend.
- Notable Files:
  - `Program.cs`: Configures the API endpoints and serves the product data.

### 3. **Shared**

- A shared library project that contains common models and logic used by both the frontend and backend.
- Key Features:
  - Defines the `Product` and `Category` models, which are used for data exchange between the frontend and backend.
- Notable Files:
  - `Models/Product.cs`: Represents the product data structure.
  - `Models/Category.cs`: Represents the category data structure.

## How It Works

1. The `BlazorFrontEnd` fetches product data from the `MinimalAPIBackEnd` using an HTTP GET request to the `/api/products` endpoint.
2. The `Shared` project provides the `Product` and `Category` models, ensuring consistency between the frontend and backend.
3. The `ProductService` in the frontend caches the product data to reduce redundant API calls.
4. The `FetchProducts.razor` component in the frontend displays the product list or error messages based on the API response.

## Getting Started

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- A modern web browser

### Running the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/jzlpr/CopilotIntegrationDemo.git
   cd CopilotIntegrationDemo
   ```

2. Start the backend:

   ```bash
   cd MinimalAPIBackEnd
   dotnet run
   ```

3. Start the frontend:

   ```bash
   cd BlazorFrontEnd
   dotnet run
   ```

4. Open your browser and navigate to `http://localhost:5000` (or the port specified in the console output).

## API Endpoints

### `GET /api/products`

- Returns a list of products in JSON format.
- Example Response:
  ```json
  [
    {
      "id": 1,
      "name": "Laptop",
      "price": 1200.0,
      "stock": 25,
      "category": {
        "id": 101,
        "name": "Electronics"
      }
    },
    {
      "id": 2,
      "name": "Headphones",
      "price": 50.0,
      "stock": 100,
      "category": {
        "id": 102,
        "name": "Accessories"
      }
    }
  ]
  ```

## License

This project is licensed under the [MIT License](./LICENCE).
