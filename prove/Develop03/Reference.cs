class Reference
{
    private string book = "";
    private string chapter = "";
    private string verse = "";
    private string endVerse = "";

    public Reference(string bookString, string chapterString, string verseString)
    {
        book = bookString;
        chapter = chapterString;
        verse = verseString;
    }

    public Reference(string bookString, string chapterString, string verseString, string endVerseString)
    {
        book = bookString;
        chapter = chapterString;
        verse = verseString;
        endVerse = endVerseString;
    }
}
