using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== C# Functions Demo ===");
        GreetUser("Lian");
        int result = Add(17, 11);
        Console.WriteLine("Sum: " + result);
        MultiplyAndShow(7, 7);
    }

    static void GreetUser(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void MultiplyAndShow(int x, int y)
    {
        int product = x * y;
        Console.WriteLine("Product: " + product);
    }
}
