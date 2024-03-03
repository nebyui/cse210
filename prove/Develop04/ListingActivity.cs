class ListingActivity : Activity
{
    private List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int numOfResponses = 0;
    private string prompt = "";

    public ListingActivity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void RandomPrompt()
    {
        int listLength = listingPrompts.Count;
        Random random = new Random();
        int randomNumber = random.Next(0, listLength);
        prompt = listingPrompts[randomNumber];
    }

    public void DisplayListingActivity()
    {
        RandomPrompt();
        Console.WriteLine("List as many response you can to the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine("");
        Console.Write("You may begin in - ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(time);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            numOfResponses += 1;
        }

        Console.WriteLine($"You listed {numOfResponses} items.");

    }

}