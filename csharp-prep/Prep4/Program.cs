using System;

class Program
{
    static void Main(string[] args)
    {
        int newNumber = 1;
        int sum = 0;
        float totalItems = 0;
        int largestNumber = 0;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Enter 0 when done.");

        while (newNumber != 0)
        {
            System.Console.Write("Enter Number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        };

        foreach (int number in numbers)
        {
            sum += number;
            totalItems += 1;  // Sample Solution used numbers.Count to get number of items when calculating average//
            if (largestNumber < number)
            {
                largestNumber = number;
            }

        };

        float average = sum / totalItems;
        System.Console.Write("Sum: ");    // could be same lines: System.Console.Write("Sum: {sum}")
        System.Console.WriteLine(sum);
        System.Console.Write("Average: ");
        System.Console.WriteLine(average);
        System.Console.Write("Largest Number: ");
        System.Console.WriteLine(largestNumber);





    }
}