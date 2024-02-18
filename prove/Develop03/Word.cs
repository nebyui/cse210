class Word
{
    private string word;
    private bool isHidden;

    public Word(string wordString, bool isHiddenBool)
    {
        word = wordString;
        isHidden = isHiddenBool;
    }

    public string GetWord()
    {
        return word;
    }

    public bool GetIsHidden()
    {
        return isHidden;
    }

    public void HideWord()
    {
        string blankWord = "";
        int wordLength = word.Length;

        for (int i = 0; i < wordLength; i++)
        {
            blankWord += "_";
        }

        word = blankWord;
        isHidden = true;
    }
}
