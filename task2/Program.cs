class Program
{
    static void Print (int min, int max)
    {
        if (min > max)
        {
            return;
        }
        System.Console.Write(min + " ");
        Print (min + 1, max);
    }

    static void Main ()
    {
        System.Console.WriteLine("Natural numbers: ");
        Print (1, 50);
    }
}