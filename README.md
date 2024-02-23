# SimpleAuthNet8

A simple authentication application in .NET 8.

## Description
This application provides a basic implementation of authentication in .NET 8, serving as a starting point for more complex authentication systems.

## Instructions

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Setup and Run
1. Clone the repository:
   ```bash
   git clone https://github.com/ArielAyala/SimpleAuthNet8.git
   cd SimpleAuthNet8
2. Open the solution using Visual Studio

### Run DB server in Docker (Alternative)
You can use the [docker file](https://github.com/ArielAyala/SimpleAuthNet8/blob/master/Dockerfile)

Create the image
```bash
docker build -t nombre-imagen .
```

Run the container
```bash
docker run -d --name sql-server-container -p 1433:1433 nombre-imagen
```

Key magic happens in these two lines:
```c#
// This line sets up the core authentication system for IdentityUser type users.
// It utilizes Entity Framework Core to store user data in the DataContext database.
builder.Services.AddIdentityApiEndpoints<IdentityUser>() .AddEntityFrameworkStores<DataContext>();
```

```c#
// This line maps the configured authentication endpoints to the application pipeline.
// It exposes various endpoints for user registration, login, password management, and more.
app.MapIdentityApi<IdentityUser>();
```
