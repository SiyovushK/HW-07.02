class Program
{
    static int CountDigits (int number)
    {
        if (number == 0)
        {
            return 0;
        }
        return 1 + CountDigits (number / 10);
    }
    
    static void Main ()
    {
        int number = 1205;
        int result = (number == 0)? 1 : CountDigits (number);
        System.Console.WriteLine("Digits: " + result);
    }
}