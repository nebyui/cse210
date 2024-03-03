class BreathingActivity : Activity
{

    public BreathingActivity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void DisplayBreathingActivity()
    {
        for (int i = 0; i < _numberOfTasks; i++)
        {
            Console.Write("Breath in . . . ");
            for (int h = 5; h > 0; h--)
            {
                Console.Write(h);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\nBreath out . . . ");
            for (int j = 5; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}