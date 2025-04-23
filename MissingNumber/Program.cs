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
        PrintArray(arr);
        int result = 0;
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Missing Number Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        string? input = "";
        int result = 0;

        Console.WriteLine("Please enter the array of n integers in the format: \"[a, b, ..., c]\"");
        input = Console.ReadLine();

        // Do some better error handling here before processing.
        int[] arr;
        if (input != null)
        {
            arr = Array.ConvertAll(input.Trim('[', ']', ' ').Split(','), Convert.ToInt32);
            result = MissingNumberCalculator.DoOperation(arr);

            Console.WriteLine("This missing number is: " +  result);
        }
        return;
    }
}