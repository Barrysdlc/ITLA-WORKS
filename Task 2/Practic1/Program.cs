using System;

class MySecondProgram
{
    static void Main()
    {
        
        Console.WriteLine("=== Even or Odd Number Checker ===");

        
        Console.Write("Please enter a number: ");

        
        string input = Console.ReadLine();

        
        if (int.TryParse(input, out int number))
        {
            // Check if the number is even or odd
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is EVEN.");
            }
            else
            {
                Console.WriteLine($"The number {number} is ODD.");
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid integer number.");
        }

        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}


