using System;

class Program
{
    static void Main(string[] args)
    {
        List<Word> words = new List<Word>
        {
            new Word("And", false),
            new Word("it", false),
            new Word("came", false),
            new Word("to", false),
            new Word("pass", false),
        };

        Reference scripturereference = new Reference("1 Nephi", "4", "5");

        Scripture scripture = new Scripture();


        scripture.PrintScripture(scripturereference, words);





    }
}