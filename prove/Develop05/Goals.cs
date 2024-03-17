public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _isCompleteMark;

    public Goals(bool makeGoal)
    {
        Console.WriteLine("What is the name of the Goal?");
        Console.Write(">> ");
        _name = Console.ReadLine();
        Console.WriteLine("What is the description of the goal?");
        Console.Write(">> ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the point value of the goal?");
        Console.Write(">> ");
        _points = int.Parse(Console.ReadLine());
    }

    public Goals()
    {

    }


    public abstract void DisplayItem();

    public string GetNameForRecord()
    {
        return _name;
    }

    public abstract string SaveGoal();

    public abstract void LoadGoal(string[] part);

    public abstract int Accomplished();

}
