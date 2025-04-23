using System.Runtime.CompilerServices;
class MissingNumberCalculator
{
    public static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }

    public static int DoOperation(int[] arr)
    {
        // Quicksort array (ascending order)
        Array.Sort(arr);

        // Start at 0 (assumed to always be there)
        int result = 0;
        foreach (int i in arr)
        {
            // Check if the current integer exists
            if (result == i)
            {
                // If it does, check for the next one
                result++;
            }
            else
            {
                // If it doesn't exist, return the missing integer
                return result;
            }
        }
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Console Missing Number Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        string? input = "";
        int result = 0;

        Console.WriteLine("Please enter an array of n integers in the format: \"[a, b, ..., c]\"");
        input = Console.ReadLine();

        // Do some better error handling here before processing
        int[] arr;
        if (input != null)
        {
            arr = Array.ConvertAll(input.Trim('[', ']', ' ').Split(','), Convert.ToInt32);
            result = MissingNumberCalculator.DoOperation(arr);

            Console.WriteLine(result);
        }
        return;
    }
}