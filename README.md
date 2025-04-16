# CopilotIntegrationDemo

This repository contains a demo project showcasing the integration of a Blazor Frontend with a Minimal API Backend. The project is structured into three main components: `BlazorFrontEnd`, `MinimalAPIBackEnd`, and `Shared`.

## Project Structure

```pre
CopilotIntegrationDemo.sln
├── BlazorFrontEnd/
│ ├── Pages/
│ │ ├── FetchProducts.razor
│ ├── Layout/
│ │ ├── MainLayout.razor
│ │ ├── NavMenu.razor
│ ├── wwwroot/
│ ├── BlazorFrontEnd.csproj
│ ├── App.razor
│ └── \_Imports.razor
├── MinimalAPIBackEnd/
│ ├── Program.cs
│ ├── MinimalAPIBackEnd.csproj
│ ├── appsettings.json
│ └── appsettings.Development.json
├── Shared/
│ ├── Models/
│ │ ├── Product.cs
│ ├── Shared.csproj
└── CopilotIntegrationDemo.sln
```

## Components

### 1. **BlazorFrontEnd**

- A Blazor WebAssembly project that serves as the frontend for the application.
- Key Features:
  - Fetches and displays a list of products from the backend API.
  - Implements a user-friendly interface using Razor components.
- Notable Files:
  - `Pages/FetchProducts.razor`: Displays the product list fetched from the backend.
  - `Layout/MainLayout.razor` and `Layout/NavMenu.razor`: Define the layout and navigation for the application.

### 2. **MinimalAPIBackEnd**

- A Minimal API project that serves as the backend for the application.
- Key Features:
  - Exposes a REST API endpoint (`/api/products`) to fetch product data.
  - Provides mock product data for demonstration purposes.
- Notable Files:
  - `Program.cs`: Configures the API endpoints and serves the product data.

### 3. **Shared**

- A shared library project that contains common models and logic used by both the frontend and backend.
- Key Features:
  - Defines the `Product` model, which is used for data exchange between the frontend and backend.
- Notable Files:
  - `Models/Product.cs`: Represents the product data structure.

## How It Works

1. The `BlazorFrontEnd` fetches product data from the `MinimalAPIBackEnd` using an HTTP GET request to the `/api/products` endpoint.
2. The `Shared` project provides the `Product` model, ensuring consistency between the frontend and backend.
3. The `FetchProducts.razor` component in the frontend displays the product list or error messages based on the API response.

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
   ```bash
   cd MinimalAPIBackEnd
   dotnet run
   ```
   ```bash
   cd BlazorFrontEnd
   dotnet run
   ```
