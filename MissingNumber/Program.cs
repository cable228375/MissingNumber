using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
class MissingNumberCalculator
{
    public static int DoOperation(int[] arr)
    {
        int n = arr.Length;

        // The sum of the first n positive integers is: (n(n + 1))/2
        int expectedSum = (n * (n + 1)) / 2;

        /* Find the missing integer by calculating the sum of all integers in the array,
        and subtract that from what is expected */
        int sum = arr.Sum();
        return expectedSum - sum;
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