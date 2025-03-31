using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a problem to run:");
        Console.WriteLine("1. Two Sum (Arrays)");
        Console.WriteLine("2. Reverse String (Strings)");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Test1.Run();
                break;
            case "2":
                Test2.Run();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
