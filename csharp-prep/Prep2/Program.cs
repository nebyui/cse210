using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Score: ");
        string input = Console.ReadLine();
        int score = int.Parse(input);
        string letter;  // sample solution: string letter = ""; //

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        if (score >= 70)
        {
            Console.WriteLine("Student Passed");
        }
        else
        {
            Console.WriteLine("Student Failed");
        }
    }
}