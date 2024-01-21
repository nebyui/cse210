using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);
        int guess;

        do
        {
            System.Console.Write("Guess a number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > randomNumber)
            {
                System.Console.WriteLine("Too High");
            }

            else if (guess < randomNumber)
            {
                System.Console.WriteLine("Too Low");
            }

            else
            {
                System.Console.Write("Correct");
            }
        } while (guess != randomNumber);


    }
}