

using System.Diagnostics.Metrics;
using CanculaTOR;


bool loop = true;
while (loop)
{    
    Console.WriteLine("1. Add two numbers");
    Console.WriteLine("2. Add list of numbers");
    string choose = Console.ReadLine();
    if (choose == "1")
    {
        Console.WriteLine("Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Result:{funcions.Add_two_numbers(a, b)}");
    }
    else if (choose == "2")
    {
        Console.WriteLine("Enter comma - separated(,) integer values:");
        string text = Console.ReadLine();
        Console.WriteLine($"Result:{funcions.Add_list_of_numbers(text)}");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("we don't have such caint of category ! If you want to try again press Enter: ");
        
        if (Console.ReadKey().Key != ConsoleKey.Enter)
        {
            loop = false;
        }
    }
}