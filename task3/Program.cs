class Program
{
    static int Calculate (int n)
    {
        if (n == 1)
        {
            return 0;
        }
        return n + Calculate (n - 1);
    }

    static void Main ()
    {
        int n = 15;
        int result = Calculate (n);
        System.Console.WriteLine(result);
    }
}
