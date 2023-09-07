using System;
using System.Collections.Generic;
using System.Text;

class BkgDrop
{
    static void Main(string[] args)
    {
        var options = new BkgOptions(ConsoleColor.DarkBlue, ConsoleColor.White, "(randomized)");

        // Background Color Input
        while (true)
        {
            Console.WriteLine("Background Color: ");
            string? backgroundColorInput = Console.ReadLine();

            if (Enum.TryParse(backgroundColorInput, true, out ConsoleColor backgroundColor))
            {
                options.SetBackgroundColor(backgroundColor);
                Console.WriteLine("Using: " + backgroundColor);
                break; // Exit the loop on valid input
            }
            else
            {
                Console.WriteLine("Invalid color. Please try again.");
            }
        }

        // Text Color Input
        while (true)
        {
            Console.WriteLine("Text Color: ");
            string? textColorInput = Console.ReadLine();

            if (Enum.TryParse(textColorInput, true, out ConsoleColor textColor))
            {
                options.SetTextColor(textColor);
                break; // Exit the loop on valid input
            }
            else
            {
                Console.WriteLine("Invalid color. Please try again.");
            }
        }

        // Clear the console and set background and text colors
        Console.Clear();
        Console.BackgroundColor = options.GetBackgroundColor();
        Console.ForegroundColor = options.GetTextColor();

        while (true)
        {
            // Get the current window size
            int currentConsoleWidth = Console.WindowWidth;
            int currentConsoleHeight = Console.WindowHeight;

            // Generate and display the random ASCII art based on the current window size
            string asciiArt = GenerateRandomAsciiArt(currentConsoleWidth, currentConsoleHeight);
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