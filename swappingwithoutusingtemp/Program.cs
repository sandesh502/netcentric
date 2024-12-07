using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        // Swapping without a temp variable
        a = a + b; // Step 1
        b = a - b; // Step 2
        a = a - b; // Step 3

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}
