class Program
{
    static int LargestElement (int[] arr, int index)
    {
        if (index == arr.Length-1)
        {
            return 0;
        }
        int Largest = LargestElement (arr, index + 1);
        return Math.Max(arr[index], Largest);
    }

    static void Main ()
    {
        int[] arr = new int[5]{1, 4, 2, 6, 5};
        int result = LargestElement (arr, 0);
        System.Console.WriteLine(result);
    }
}