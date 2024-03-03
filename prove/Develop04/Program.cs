using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";

        Console.WriteLine("Welcome to the mindfullness program.");

        while (choice != "4")
        {
            Console.WriteLine("Menu");
            Console.WriteLine("     1) Breathing Activity");
            Console.WriteLine("     2) Reflecting Activity");
            Console.WriteLine("     3) Listing Activity");
            Console.WriteLine("     4) Quit");
            Console.WriteLine("");
            Console.Write("Select Option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you though breathing in and out slowly. Clear you mind and focus on your breathing.");
                    breathing.DisplayIntro();
                    breathing.CalculateTasks();
                    breathing.Countdown();
                    breathing.DisplayBreathingActivity();
                    breathing.DisplayEnding();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.DisplayIntro();
                    reflecting.CalculateTasks();
                    reflecting.Countdown();
                    reflecting.DisplayReflectingActivity();
                    reflecting.DisplayEnding();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.DisplayIntro();
                    listing.Countdown();
                    listing.DisplayListingActivity();
                    listing.DisplayEnding();
                    break;

            }
        }
    }
}