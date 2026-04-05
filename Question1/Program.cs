//Question 1 : Write a C# program to check whether a string is a palindrome

using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask to user for their input
            Console.WriteLine("--- Palindrome Checker ---");
            Console.Write("Enter a word to check if it is a palindrome: ");
            string? userInput = Console.ReadLine();

            // 2. Make sure the user actually typed something
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("It looks like you didn't enter anything. Please restart the program and try again.");
                return; // Exit the program early
            }

            // 3. Clean up the word by making it entirely lowercase. 
            // This ensures that "Racecar" and "racecar" are treated as the same word.
            string wordToCheck = userInput.ToLower();

            // 4. Set up our checking mechanism (Two-Pointer Approach)
            // We look at the first letter and the last letter, then move inwards.
            int leftSide = 0;
            int rightSide = wordToCheck.Length - 1;
            bool isPalindrome = true; 

            // 5. Keep checking until our pointers meet in the middle
            while (leftSide < rightSide)
            {
                // If the letters don't match, we immediately know it's not a palindrome
                if (wordToCheck[leftSide] != wordToCheck[rightSide])
                {
                    isPalindrome = false;
                    break; // Stop checking to save time
                }

                // Move closer to the middle of the word for the next check
                leftSide++;
                rightSide--;
            }

            // 6. Give the user a clear, friendly result
            Console.WriteLine("\n--- Result ---");
            if (isPalindrome)
            {
                Console.WriteLine($"Yes! '{userInput}' is a palindrome......");
            }
            else
            {
                Console.WriteLine($"No, '{userInput}' is not a palindrome......");
            }
        }
    }
}
