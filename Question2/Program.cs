//Question 2 : Write a program to find the largest number in an array.

using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Greet the user and explain what the program does
            Console.WriteLine("--- Largest Number Finder ---");
            Console.WriteLine("Let's find the biggest number in our list!");

            // 2. Create a sample list (array) of numbers to check
            int[] numbers = { 15, 82, 4, 99, 23, 42 };

            // 3. Show the user the exact numbers we are looking at
            Console.WriteLine("\n List of numbers: " + string.Join(", ", numbers));

            // 4. Set up our starting point
            // We begin by assuming the very first number is the largest one
            int largestNumber = numbers[0];

            // 5. Look through the rest of the numbers in the list one by one
            for (int i = 1; i < numbers.Length; i++)
            {
                // If the current number we are looking at is bigger than our recorded 'largestNumber'...
                if (numbers[i] > largestNumber)
                {
                    // ...then we update our record with this new, bigger number!
                    largestNumber = numbers[i];
                }
            }

            // 6. Give the user the final, clear result
            Console.WriteLine("\n--- Result ---");
            Console.WriteLine($"Largest number is: {largestNumber}");
            Console.WriteLine("-----------------------------");
        }
    }
}
