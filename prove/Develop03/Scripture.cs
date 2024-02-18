class Scripture
{
    private string fullReference;
    private List<Word> verse = new List<Word>();



    public Scripture(Reference reference, List<Word> words)
    {
        fullReference = reference.GetReference();
        foreach (Word word in words)
        {
            verse.Add(word);
        }
    }

    public void PrintScripture()
    {
        Console.WriteLine("");
        Console.WriteLine(fullReference);
        Console.Write("     ");
        foreach (Word word in verse)
        {
            string retrievedWord = word.GetWord();
            Console.Write(retrievedWord + " ");
        }
        Console.WriteLine("");
    }

    private int totalHiddenWords = 0;
    public void HideVerses()
    {
        int wordCount = verse.Count;
        int hiddenCount = 0;
        Random numberGenerator = new Random();

        while (hiddenCount < 3 && totalHiddenWords < wordCount)
        {
            int randomNumber = numberGenerator.Next(0, wordCount);
            if (verse[randomNumber].GetIsHidden() == false)
            {
                verse[randomNumber].HideWord();
                totalHiddenWords += 1;
                hiddenCount += 1;
            }
        }

    }

}