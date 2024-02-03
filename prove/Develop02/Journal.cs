public class Journal
{
    public List<Entry> entries;

    PromptGenerator promptInstance = new PromptGenerator();

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void Write()
    {
        string newPrompt = promptInstance.GetPrompt();

        Console.WriteLine($"Prompt: {newPrompt}");
        Console.WriteLine("");
        Console.Write(">> ");


        DateTime dateVar = DateTime.Now;
        string formattedDate = dateVar.ToString("dd MMMM yyyy");

        Entry entry = new Entry();
        entry.prompt = newPrompt;
        entry.response = Console.ReadLine();
        entry.date = formattedDate;

        entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry item in entries)
        {
            Console.WriteLine(item.date);
            Console.WriteLine(item.prompt);
            Console.WriteLine($">> {item.response}");
            Console.WriteLine("");
        }
    }

    public void Save()
    {
        Console.Write("Enter File Name (no extension): ");
        string fileName = Console.ReadLine();
        File.WriteAllText($"{fileName}.txt", string.Empty);
        List<string> individualEntries = entries.Select(entry => $"{entry.date}||{entry.prompt}||{entry.response}").ToList();
        File.WriteAllLines($"{fileName}.txt", individualEntries);
    }

    public void Load()
    {
        entries.Clear();
        Console.Write("Enter File Name (no extension): ");
        string fileName = Console.ReadLine();
        string[] fileEntries = File.ReadAllLines($"{fileName}.txt");
        foreach (string item in fileEntries)
        {
            Entry entry = new Entry();
            var part = item.Split("||");
            entry.date = part[0];
            entry.prompt = part[1];
            entry.response = part[2];
            entries.Add(entry);
        }

    }

    public void JournalOptions(string option)
    {
        if (option == "1")
        {
            int index = entries.Count - 1;
            Console.WriteLine(entries[index].prompt);
            Console.WriteLine("");
            Console.Write(">> ");
            entries[index].response = Console.ReadLine();
        }
        else if (option == "2")
        {
            int index = entries.Count - 1;
            entries.RemoveAt(index);
            Console.WriteLine("Last Entry Removed");
            Console.WriteLine("");
            Console.Write("Press Enter to return to menu. ");
            Console.ReadLine();
        }
        else if (option == "3")
        {
            entries.Clear();
            Console.WriteLine("Journal Cleared");
            Console.WriteLine("");
            Console.Write("Press Enter to return to menu. ");
            Console.ReadLine();
        }
        else
        {
            //return to menu
        }
    }

}