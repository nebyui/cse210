using System;

class Program
{
    static void Main(string[] args)
    {


        List<Word> words = new List<Word>
        {
            new Word("And", false),
            new Word("behold,", false),
            new Word("I", false),
            new Word("am", false),
            new Word("the", false),
            new Word("light", false),
            new Word("and", false),
            new Word("the", false),
            new Word("life", false),
            new Word("of", false),
            new Word("the", false),
            new Word("world;", false),
            new Word("and", false),
            new Word("I", false),
            new Word("have", false),
            new Word("drunk", false),
            new Word("out", false),
            new Word("of", false),
            new Word("that", false),
            new Word("bitter", false),
            new Word("cup", false),
            new Word("which", false),
            new Word("the", false),
            new Word("Father", false),
            new Word("hath", false),
            new Word("given", false),
            new Word("me,", false),
            new Word("and", false),
            new Word("have", false),
            new Word("glorified", false),
            new Word("the", false),
            new Word("Father", false),
            new Word("in", false),
            new Word("taking", false),
            new Word("upon", false),
            new Word("me", false),
            new Word("the", false),
            new Word("sins", false),
            new Word("of", false),
            new Word("the", false),
            new Word("world,", false),
            new Word("in", false),
            new Word("the", false),
            new Word("which", false),
            new Word("I", false),
            new Word("have", false),
            new Word("suffered", false),
            new Word("the", false),
            new Word("will", false),
            new Word("of", false),
            new Word("the", false),
            new Word("Father", false),
            new Word("in", false),
            new Word("all", false),
            new Word("things", false),
            new Word("from", false),
            new Word("the", false),
            new Word("beginning.", false),

        };

        Reference scripturereference = new Reference("1 Nephi", "4", "5");
        Scripture scripture = new Scripture(scripturereference, words);

        Console.WriteLine("");
        Console.WriteLine("--- Welcome to the Scripture Memorizer Program! ---");
        Console.WriteLine("");


        double times = Math.Ceiling((double)words.Count / 3);
        for (int i = -1; i < times; i++)
        {
            scripture.PrintScripture();
            Console.WriteLine("");
            Console.Write("Press Enter to hide words. Type \"quit\" to quit - ");
            Console.ReadLine();
            scripture.HideVerses();

        }



    }
}