class Simple : Goals
{
    private bool _isComplete;

    public Simple(bool makeGoal) : base(makeGoal)
    {

    }

    public Simple() : base()
    {

    }

    public override void DisplayItem()
    {
        if (_isComplete == true)
        {
            _isCompleteMark = "X";
        }
        else
        {
            _isCompleteMark = " ";
        }
        Console.WriteLine($"[{_isCompleteMark}] {_name} ({_description})");
    }

    public override string SaveGoal()
    {
        string goalLine = $"simple||{_name}||{_description}||{_points}||{_isComplete}";
        return goalLine;
    }

    public override void LoadGoal(string[] part)
    {
        _name = part[1];
        _description = part[2];
        _points = int.Parse(part[3]);
        _isComplete = bool.Parse(part[4]);
    }

    public override int Accomplished()
    {
        _isComplete = true;
        return _points;
    }
}