class Program
{
    static int Sum (List<int> numbers, int index = 0)
    {
        if (index == numbers.Count)
        {
            return 0;
        }
        return numbers[index] + Sum (numbers, index + 1);
    }
    static void Main ()
    {
        List<int> numbers = new List<int>() {1, 2, 3, 4, 5};
        int sum = Sum (numbers);
        System.Console.WriteLine("Sum of elements: " + sum);
    }
}
