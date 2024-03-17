using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        string goalType = "";
        string fileName = "";
        int totalPoints = 0;

        List<Goals> goalsList = new List<Goals> { };

        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine($"Your have {totalPoints} points");
            Console.WriteLine("");
            Console.WriteLine("-- Menu --");
            Console.WriteLine("1) Create New Goal");
            Console.WriteLine("2) List Goals");
            Console.WriteLine("3) Save Goals");
            Console.WriteLine("4) Load Goals");
            Console.WriteLine("5) Record Event");
            Console.WriteLine("6) Quit");
            Console.WriteLine("");
            Console.Write(">> ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("What type of goal do want to make?");
                    Console.WriteLine("1) Simple Goal");
                    Console.WriteLine("2) Eternal Goal");
                    Console.WriteLine("3) Checklist Goal");
                    Console.WriteLine("");
                    Console.Write(">> ");
                    goalType = Console.ReadLine();
                    Console.Clear();
                    switch (goalType)
                    {
                        case "1":
                            Simple simple = new(true);
                            goalsList.Add(simple);
                            break;
                        case "2":
                            Eternal eternal = new(true);
                            goalsList.Add(eternal);
                            break;
                        case "3":
                            Checklist checklist = new(true);
                            goalsList.Add(checklist);
                            break;
                    }
                    break;

                case "2":
                    foreach (var goal in goalsList)
                    {
                        goal.DisplayItem();
                    }
                    Console.WriteLine("");
                    Console.Write("Press Enter >> ");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Write("Enter File Name (no extension): ");
                    fileName = Console.ReadLine();
                    File.WriteAllText($"{fileName}.txt", string.Empty);
                    List<string> goalsToWrite = new List<string>();
                    foreach (var item in goalsList)
                    {
                        string goalString = item.SaveGoal();
                        goalsToWrite.Add(goalString);
                    };
                    File.WriteAllLines($"{fileName}.txt", goalsToWrite);
                    File.AppendAllText($"{fileName}.txt", totalPoints.ToString());
                    break;

                case "4":
                    Console.Write("Enter File Name (no extension): ");
                    fileName = Console.ReadLine();
                    string[] fileGoals = File.ReadAllLines($"{fileName}.txt");
                    foreach (string item in fileGoals)
                    {
                        var part = item.Split("||");
                        switch (part[0])
                        {
                            case "simple":
                                Simple simple = new Simple();
                                simple.LoadGoal(part);
                                goalsList.Add(simple);
                                break;
                            case "eternal":
                                Eternal eternal = new Eternal();
                                eternal.LoadGoal(part);
                                goalsList.Add(eternal);
                                break;
                            case "checklist":
                                Checklist checklist = new Checklist();
                                checklist.LoadGoal(part);
                                goalsList.Add(checklist);
                                break;
                            default:
                                break;
                        }

                    }
                    totalPoints += int.Parse(fileGoals[fileGoals.Length - 1]);
                    break;

                case "5":
                    Console.WriteLine("The goals are: ");
                    int counter = 1;
                    foreach (Goals item in goalsList)
                    {
                        string name = item.GetNameForRecord();
                        Console.WriteLine($"{counter}) {name}");
                        counter += 1;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Which goal did you accomplish?");
                    Console.Write(">> ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    int points = goalsList[goalIndex].Accomplished();
                    totalPoints += points;
                    Console.WriteLine("");
                    Console.WriteLine($"You earned {points} points.");
                    Console.WriteLine("");
                    Console.Write("Press Enter >> ");
                    Console.ReadLine();
                    break;

                default:
                    break;
            }



        }

    }
}