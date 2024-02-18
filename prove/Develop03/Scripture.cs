class Scripture
{

    public void PrintScripture(Reference reference, List<Word> words)
    {
        Console.WriteLine(reference);
        foreach (Word word in words)
        {
            Console.Write($"{word.word} ");

        }

    }

}