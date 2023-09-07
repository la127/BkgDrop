public class BkgOptions {
    public ConsoleColor BackgroundColor { get; set; }
    public ConsoleColor TextColor {get; set; }
    public string ArtText { get; set; }

    public BkgOptions(ConsoleColor backgroundColor, ConsoleColor textColor, string artText) {
        BackgroundColor = backgroundColor;
        TextColor = textColor;
        ArtText = artText;
    }
    
    public void SetBackgroundColor(ConsoleColor color)
    {
        BackgroundColor = color;
    }

    public void SetTextColor(ConsoleColor color)
    {
        TextColor = color;
    }

    public void SetArtText(string text)
    {
        ArtText = text;
    }

    public ConsoleColor GetBackgroundColor() {
        return BackgroundColor;
    }

    public ConsoleColor GetTextColor() {
        return TextColor;
    }

    public string GetArtText() {
        return ArtText;
    }
}