using System;
using System.Collections.Generic;
using System.Text;

class BkgDrop
{
    static void Main(string[] args)
    {
        var options = new BkgOptions(ConsoleColor.DarkBlue, ConsoleColor.White, "(randomized)");

        Console.WriteLine("Background Color: " + options.GetBackgroundColor());
        string? backgroundColorInput = Console.ReadLine();
        if (Enum.TryParse(backgroundColorInput, true, out ConsoleColor backgroundColor))
        {
            options.SetBackgroundColor(backgroundColor);
        }
        else
        {
            Console.WriteLine("Invalid color. Using default.");
        }

        Console.WriteLine("Text Color: " + options.GetTextColor());
        string? textColorInput = Console.ReadLine();
        if (Enum.TryParse(textColorInput, true, out ConsoleColor textColor))
        {
            options.SetTextColor(textColor);
        }
        else
        {
            Console.WriteLine("Invalid color. Using default.");
        }

        // Clear the console and set background and text colors
        Console.Clear();
        Console.BackgroundColor = options.GetBackgroundColor();
        Console.ForegroundColor = options.GetTextColor();

        // Set the initial width and height of the console buffer and window
        int initialConsoleWidth = Console.WindowWidth;
        int initialConsoleHeight = Console.WindowHeight;

        while (true)
        {
            // Generate and display the random ASCII art
            string asciiArt = GenerateRandomAsciiArt(initialConsoleWidth, initialConsoleHeight);
            Console.SetCursorPosition(0, 0); // Reset cursor position
            Console.WriteLine(asciiArt);

            Console.WriteLine("Press 'Enter' to refresh or 'Q' to quit.");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Q)
            {
                break;
            }
        }
    }

    static string GenerateRandomAsciiArt(int width, int height)
    {
        Random random = new Random();
        StringBuilder asciiArt = new StringBuilder();

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                char randomChar = (char)random.Next(32, 127); // ASCII printable characters
                asciiArt.Append(randomChar);
            }
            asciiArt.Append('\n');
        }

        return asciiArt.ToString();
    }
}