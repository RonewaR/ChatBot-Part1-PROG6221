using System;

public class UIHelper
{
    public static void ShowAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine(@"
   ____ _           _           _   
  / ___| |__   __ _| |_   _ ___| |_ 
 | |   | '_ \ / _` | | | | / __| __|
 | |___| | | | (_| | | |_| \__ \ |_ 
  \____|_| |_|\__,_|_|\__, |___/\__|
                      |___/         
        ");

        Console.ResetColor();
    }
}
