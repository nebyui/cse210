using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        string summary1 = assignment1.GetSummary();
        Console.WriteLine(summary1);
        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");
        string summary2 = assignment2.GetSummary();
        string mathSummary = assignment2.GetHomeworkList();
        Console.WriteLine(summary2);
        Console.WriteLine(mathSummary);
        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        string summary3 = assignment3.GetSummary();
        string writingSummary = assignment3.GetWrtingInformation();
        Console.WriteLine(summary3);
        Console.WriteLine(writingSummary);
    }
}