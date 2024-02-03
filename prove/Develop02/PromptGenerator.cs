public class PromptGenerator
{
    Random random = new Random();

    public PromptGenerator()
    {

    }

    string[] prompts =
    {
        "What was the best part of your day?",
        "What is a habit you want to change, stop, or start and how will you do so?",
        "How have you made a positive difference in the world today, big or small?",
        "Who is your favorite character from a movie, tv show, book, etc, and why?",
        "What is your dream career?",
        "If you could visit any place in the world, where would you go?",
        "What has been on your mind lately?",
        "What do you like to do in your free time?"
    };

    public string prompt;




    public string GetPrompt()
    {
        int randomNumber = random.Next(0, prompts.Length);
        return prompt = prompts[randomNumber];
    }



}