class Program
{
    static int FindSum (int number)
    {
        if (number == 0)
        {
            return 0;
        }
        return number%10 + FindSum (number/10);
    }

    static void Main ()
    {
        int number = 12045;
        int result = FindSum (number);
        System.Console.WriteLine("Sum of digits: " + result);
    }
}