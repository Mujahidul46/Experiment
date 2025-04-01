public abstract class BaseRun
{
    public static void Run<T>() where T : BaseRun, new()
    {
        Console.WriteLine($"{typeof(T).Name} running...\n");
        Console.WriteLine(new T().Run().ToString());
        Console.WriteLine($"\n{typeof(T).Name} completed execution!");
        Console.WriteLine("\nPress ENTER twice to exit.");
        Console.ReadLine();
    }

    protected abstract object Run();
}