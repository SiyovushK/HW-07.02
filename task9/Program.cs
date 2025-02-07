class Program
{
    static string Binary(int number)
    {
        if (number == 0 || number == 1)
        {
            return number.ToString();
        }

        return Binary(number / 2) + (number % 2).ToString();
    }

    static void Main()
    {
        int number = 13;
        string result = Binary(number);
        Console.WriteLine($"Number {number} in binary code will be: {result}");
    }
}
