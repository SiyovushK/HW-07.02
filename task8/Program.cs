class Program
{
    static int Factorial (int number)
    {
        if (number == 1)
        {
            return 1;
        }
        return number * Factorial (number - 1);
    }

    static void Main ()
    {
        int number = 5;
        int result = Factorial (number);
        System.Console.WriteLine($"Factorial of {number} is: {result}");
    }
}