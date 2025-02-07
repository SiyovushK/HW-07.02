class RecExercise7
{
    static void Main()
    {
        int number = 7;
        int primeNo = Prime(number, number/2);

        if (primeNo == 1)
        {
            Console.Write($"The number {number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"The number {number} is not a prime number.");
        }
    }

    static int Prime(int number, int i)
    {
        if (i == 1)
        {
            return 1;
        }
        else
        {
            if (number % i == 0)
            {
                return 0;
            }
            else
            {
                return checkForPrime(number, i - 1);
            }
        }
    }
}
