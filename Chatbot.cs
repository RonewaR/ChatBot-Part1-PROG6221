using System;

public class Chatbot
{
    private string userName;

    public Chatbot(string name)
    {
        userName = name;
    }

    public void StartChat()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nHello {userName}! I am your chatbot.");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nAsk me something (type 'exit' to quit): ");
            Console.ResetColor();

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please type something.");
                Console.ResetColor();
                continue;
            }

            string response = Responses.GetResponse(input, userName);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(response);
            Console.ResetColor();

            if (input.ToLower() == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Goodbye!");
                Console.ResetColor();
                break;
            }
        }
    }
}
