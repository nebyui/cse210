class Checklist : Goals
{
    private int _timesToDo;
    private int _timesCompleted = 0;
    private int _bonusPoints;

    public Checklist(bool makeGoal) : base(makeGoal)
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        Console.Write(">> ");
        _timesToDo = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        Console.Write(">> ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public Checklist() : base()
    {

    }



    public override void DisplayItem()
    {
        if (_timesCompleted >= _timesToDo)
        {
            _isCompleteMark = "X";
        }
        else
        {
            _isCompleteMark = " ";
        }

        Console.WriteLine($"[{_isCompleteMark}] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_timesToDo}");
    }

    public override string SaveGoal()
    {
        string goalLine = $"checklist||{_name}||{_description}||{_points}||{_timesToDo}||{_timesCompleted}||{_bonusPoints}";
        return goalLine;
    }

    public override void LoadGoal(string[] part)
    {
        _name = part[1];
        _description = part[2];
        _points = int.Parse(part[3]);
        _timesToDo = int.Parse(part[4]);
        _timesCompleted = int.Parse(part[5]);
        _bonusPoints = int.Parse(part[6]);
    }

    public override int Accomplished()
    {
        int points = _points;
        _timesCompleted += 1;
        if (_timesCompleted == _timesToDo)
        {
            points += _bonusPoints;
        }
        return points;

    }
}