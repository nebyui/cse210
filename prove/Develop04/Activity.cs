class Activity
{
    private int remainder;
    protected int time;
    protected string _activityName;
    protected string _activityDescription;
    protected int _numberOfTasks;
    protected bool running = true;

    public void DisplayIntro()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine("");
        Console.WriteLine(_activityDescription);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        time = int.Parse(Console.ReadLine());
    }

    public void CalculateTasks()
    {
        _numberOfTasks = time / 10;
        remainder = time % 10;
        if (remainder != 0)
        {
            _numberOfTasks += 1;
        }

    }

    public void Spinner(int seconds)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }

    }

    public void Countdown()
    {
        Console.Clear();
        Console.Write("Get Ready . . . ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
        Console.Clear();
    }

    public void DisplayEnding()
    {
        Console.Write("\n\nWell done! ");
        Spinner(2);
        Console.Write($"\n\nYou completed {time} seconds of the {_activityName} ");
        Spinner(2);
        Console.Clear();
    }
}