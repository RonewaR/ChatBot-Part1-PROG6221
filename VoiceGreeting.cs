using System;
using System.Threading;

public static class VoiceGreeting
{
    public static void PlayGreeting()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Playing greeting sound...");
        Console.ResetColor();

        Console.WriteLine("Hello, welcome to the chatbot!");

        // Simulated sound effect (works everywhere)
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(400);
        }

        Console.WriteLine();

        try
        {
            Console.Beep(700, 150);
            Console.Beep(900, 150);
            Console.Beep(1100, 200);
        }
        catch
        {
            Console.WriteLine("Sound not supported on this device.");
        }
    }
}