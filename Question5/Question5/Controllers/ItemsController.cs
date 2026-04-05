// Question 5 : Build a simple ASP.NET Core Web API with one GET and one POST method.

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Question5.Controllers
{
    // This tells ASP.NET that this class handles API web requests
    [ApiController] 
    // This sets the URL to access this controller (e.g., /api/items)
    [Route("api/[controller]")] 
    public class ItemsController : ControllerBase
    {
        // A simple static list to act as our database for this test
        private static readonly List<string> _items = new List<string> { "Laptop", "Mouse", "Keyboard" };

        // 1. GET Method: Fetches data from the server
        [HttpGet]
        public IActionResult GetItems()
        {
            // Returns our list of items with a standard "200 OK" success status
            return Ok(_items); 
        }

        // 2. POST Method: Sends new data to the server
        [HttpPost]
        public IActionResult AddItem([FromBody] string newItem)
        {
            // Safety check: Ensure the user didn't send an empty request
            if (string.IsNullOrWhiteSpace(newItem))
            {
                return BadRequest("Error: Item cannot be empty."); 
            }

            // Add the new item to our list
            _items.Add(newItem);
            
            // Returns a "201 Created" success status with a friendly confirmation message
            return Created(string.Empty, $"Success! '{newItem}' was added.");
        }
    }
}