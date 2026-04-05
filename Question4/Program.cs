// Question 4 : Write a LINQ query to filter employees with salary > 50,000.

using System;
using System.Collections.Generic;
using System.Linq; // This is strictly required to use LINQ!

namespace Question4
{
    // 1. A simple Employee class to hold our data
    public class Employee
    {
        public int Id { get; set; }
        
        // FIX: Added '= string.Empty;' to completely avoid the CS8618 warning!
        public string Name { get; set; } = string.Empty; 
        
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Greet the user and explain the goal
            Console.WriteLine("--- Employee Salary Filter (LINQ Demo) ---");
            Console.WriteLine("Searching for employees earning more than Rs. 50,000...\n");

            // 3. Create a sample list of employees to test our query
            List<Employee> team = new List<Employee>
            {
                new Employee { Id = 1, Name = "Samruddhi Kangude", Salary = 85000 },
                new Employee { Id = 2, Name = "Jui Kangude", Salary = 65000 },
                new Employee { Id = 3, Name = "Sakshi Pawar", Salary = 50000 }, // Exactly 50k, should NOT be included
                new Employee { Id = 4, Name = "Sneha Patil", Salary = 82000 }
            };

            // 4. The LINQ Query!
            // We use '.Where()' to filter the list so it only keeps employees with Salary > 50000.
            var highEarners = team.Where(emp => emp.Salary > 50000).ToList();

            // 5. Display the results clearly to the user
            Console.WriteLine("--- High Earners List ---");
            
            // Check if our query actually found anyone
            if (highEarners.Count > 0)
            {
                foreach (var emp in highEarners)
                {
                    Console.WriteLine($"- {emp.Name} (Salary: Rs. {emp.Salary})");
                }
            }
            else
            {
                Console.WriteLine("No employees found earning strictly more than 50,000.");
            }
            
            Console.WriteLine("-------------------------");
        }
    }
}