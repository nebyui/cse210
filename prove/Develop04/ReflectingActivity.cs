class ReflectingActivity : Activity
{
    private string prompt = "";
    private string question = "";

    private List<string> reflectingPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };


    public ReflectingActivity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void GetRandomPrompt()
    {
        int listLength = reflectingPrompts.Count;
        Random random = new Random();
        int randomNumber = random.Next(0, listLength);
        prompt = reflectingPrompts[randomNumber];
    }

    public void GetRandomQuestion()
    {
        int listLength = questions.Count;
        Random random = new Random();
        int randomNumber = random.Next(0, listLength);
        question = questions[randomNumber];
    }

    public void DisplayReflectingActivity()
    {
        GetRandomPrompt();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine("");
        Console.Write("When you are ready, press Enter ");
        Console.ReadLine();
        for (int i = 0; i < _numberOfTasks; i++)
        {
            GetRandomQuestion();
            Console.WriteLine("\n");
            Console.Write($" - {question}");
            Spinner(10);
            running = false;

        }
    }


}