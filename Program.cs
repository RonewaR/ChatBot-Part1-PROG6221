using System;

class Program
{
    static void Main(string[] args)
    {
        UIHelper.ShowAsciiArt();

        // 🔊 Voice greeting (beep sound)
        VoiceGreeting.PlayGreeting();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter your name: ");
        Console.ResetColor();

        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input! Name cannot be empty.");
            Console.ResetColor();
            return;
        }

        Chatbot bot = new Chatbot(name);
        bot.StartChat();
    }
}