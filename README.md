# BkgDrop - Randomized ASCII Art Background

BkgDrop is a simple C# console application that allows you to customize the background color, text color, and choose whether to display randomized ASCII art. It provides a visually appealing and interactive experience where you can refresh the ASCII art or quit the program.

## Usage

1. Clone or download this repository to your local machine.

2. Compile and run the `BkgDrop.cs` file using your preferred C# development environment (e.g., Visual Studio, Visual Studio Code, or command line).

3. Follow the on-screen instructions to customize the program:

   - Choose a background color by entering the name of a ConsoleColor (e.g., DarkBlue, Red) or accept the default by pressing Enter.
   - Choose a text color in the same way.
        
4. Enjoy the randomized ASCII art! You can press 'Enter' to refresh the art or 'Q' to quit the program.

## Features

- **Customizable Colors**: You can choose your preferred background and text colors to create a visually appealing display.

- **Interactive**: The program prompts you for input, making it easy to configure the settings.

## Example
![image](https://github.com/la127/BkgDrop/assets/100445409/5cb0510a-add1-4a49-a189-7b13d1540979)

![image](https://github.com/la127/BkgDrop/assets/100445409/bb301b64-5777-4323-87b5-1eb016507741)


![BkgDrop Example](bkgdrop_example.gif)

## BkgOptions Class

The `BkgOptions` class is used to manage the background color, text color, and art text (description) for the ASCII art. It provides methods for setting and getting these properties.

### Properties

- `BackgroundColor`: The background color for the ASCII art.
- `TextColor`: The text color for the ASCII art.
- `ArtText`: A description of the ASCII art.

### Methods

- `SetBackgroundColor(ConsoleColor color)`: Set the background color.
- `SetTextColor(ConsoleColor color)`: Set the text color.
- `SetArtText(string text)`: Set the art text.
- `GetBackgroundColor()`: Get the background color.
- `GetTextColor()`: Get the text color.
- `GetArtText()`: Get the art text.

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/la127/BkgDrop/blob/main/LICENSE) file for details.

---

Feel free to explore, modify, and use this program for your own entertainment or educational purposes! If you have any questions or feedback, please don't hesitate to reach out.
