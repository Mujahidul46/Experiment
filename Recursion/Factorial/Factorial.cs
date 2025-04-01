public class Factorial : BaseRun
{
    protected override object Run()
    {
        return calculateFactorial(5);
    }


    public static int calculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * calculateFactorial(n - 1);
    }
}