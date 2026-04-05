// Question 3 : Create a class Employee with properties (Id, Name, Salary) and demonstrate encapsulation.

using System;

namespace Question3
{
    // 1. Here is our Employee class
    public class Employee
    {
        // 2. Private fields "hide" the actual data. 
        // This is the core of Encapsulation! Nothing outside this class can touch these directly.
        private int _id;
        private string _name = string.Empty; // <-- FIX: Starts as an empty string to prevent the CS8618 warning!
        private double _salary;

        // 3. Public properties act as "gatekeepers", letting us safely get or set the data.
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set 
            { 
                // Encapsulation lets us enforce rules. For example, a name shouldn't be empty.
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Warning: You cannot set an empty name.");
                }
            }
        }

        public double Salary
        {
            get { return _salary; }
            set 
            { 
                // Another rule: Salary cannot be a negative number!
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Warning: Salary cannot be less than zero. Setting it to 0 instead.");
                    _salary = 0;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Employee Encapsulation Demo ---");
            Console.WriteLine("Creating a new employee profile...\n");
            
            // 4. Let's create a new employee object
            Employee newEmployee = new Employee();

            // 5. We assign values using our safe, public properties
            newEmployee.Id = 101;
            newEmployee.Name = "Samruddhi Kangude";
            newEmployee.Salary = 60000;

            // 6. Show the successful creation
            Console.WriteLine("Employee added successfully!");
            Console.WriteLine($"ID: {newEmployee.Id} | Name: {newEmployee.Name} | Salary: Rs. {newEmployee.Salary}");

            // 7. Let's prove that our Encapsulation rules actually work!
            Console.WriteLine("\n--- Testing the Rules ---");
            Console.WriteLine("Trying to give the employee a negative salary of -5000...");
            
            // This will trigger our safety rule and print the warning message
            newEmployee.Salary = -5000; 
            
            Console.WriteLine($"Checked the system, the salary is safely set to: Rs. {newEmployee.Salary}");
            Console.WriteLine("-----------------------------------");
        }
    }
}