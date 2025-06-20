using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== C# Functions Demo ===");
        GreetUser("Lian");
        int result = Add(17, 11);
        Console.WriteLine("Sum: " + result);
        Console.WriteLine("Division: " + Divide(10, 2));
    }

    static void GreetUser(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
        return (double)a / b;
    }
}
