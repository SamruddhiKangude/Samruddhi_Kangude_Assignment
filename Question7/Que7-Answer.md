# Question 7: Implementing Dependency Injection in ASP.NET Core

Dependency Injection (DI) is a software design pattern used to achieve Inversion of Control (IoC) between classes and their dependencies. In ASP.NET Core, it is a built-in feature implemented in two main stages.



### 1. Service Registration (The "What")
Services are registered in the **Program.cs** file using the `builder.Services` container. When registering, you must choose a **Service Lifetime** to define how long the object stays in memory:

* **Transient:** Created every time they are requested from the service container.
* **Scoped:** Created once per client request (connection).
* **Singleton:** Created once and used throughout the entire application's lifetime.

**Example Registration:**
```csharp
// Registering an interface with its implementation in Program.cs
builder.Services.AddScoped<IItemService, ItemService>();


### 2. Constructor Injection (The "How")
Once registered, the ASP.NET Core framework automatically provides the service to any class that asks for it in its Constructor. This is most commonly used in Controllers.<br>

**Example Implementation:**

C#
public class ItemsController : ControllerBase
{
    private readonly IItemService _itemService;

    // The framework "injects" the ItemService here automatically
    public ItemsController(IItemService itemService)
    {
        _itemService = itemService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_itemService.GetAllItems());
    }
}


### 3. Benefits of DI

Loose Coupling: Classes are not responsible for creating their own dependencies.<br>

Testability: Makes it easy to swap real services with "Mock" objects for unit testing.<br>

Maintainability: You only need to change the implementation in one place (Program.cs).<br>
