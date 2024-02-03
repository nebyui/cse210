using System;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();

        var entry = new Entry();

        var prompt = new PromptGenerator();
        string choice = "";
        string option = "";
        Console.Clear();
        Console.WriteLine("Welcome to Journal Program");
        Console.WriteLine("");

        while (choice != "6")
        {
            Console.WriteLine("1) Write");
            Console.WriteLine("2) Display");
            Console.WriteLine("3) Load");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Journal Options");
            Console.WriteLine("6) Quit");
            Console.WriteLine("");
            Console.Write(">> ");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                journal.Write();
            }
            else if (choice == "2")
            {
                journal.Display();
                Console.Write("Press Enter to return to menu. ");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                journal.Load();
            }
            else if (choice == "4")
            {
                journal.Save();
            }
            else if (choice == "5")
            {

                Console.WriteLine("1) Modify Last Entry");
                Console.WriteLine("2) Remove Last Entry");
                Console.WriteLine("3) Clear All Journal");
                Console.WriteLine("4) Return to menu");
                Console.WriteLine("");
                Console.Write(">> ");
                option = Console.ReadLine();
                Console.Clear();
                journal.JournalOptions(option);
            }
            else if (choice == "6")
            {
                // leave loop
            }
            else
            {
                Console.Write("Invalid option, press Enter to return to menu. ");
                Console.ReadLine();
            }
            Console.Clear();




        }

    }
}