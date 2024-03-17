class Eternal : Goals
{
    public Eternal(bool makeGoal) : base(makeGoal)
    {

    }

    public Eternal() : base()
    {

    }

    public override void DisplayItem()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override string SaveGoal()
    {
        string goalLine = $"eternal||{_name}||{_description}||{_points}";
        return goalLine;
    }

    public override void LoadGoal(string[] part)
    {
        _name = part[1];
        _description = part[2];
        _points = int.Parse(part[3]);
    }

    public override int Accomplished()
    {
        return _points;
    }

}