using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        // Dictionary<string, int> colors = new Dictionary<string, int>();
        // colors.Add("black", 0);
        // colors.Add("brown", 1);
        // colors.Add("red", 2);
        // colors.Add("orange", 3);
        // colors.Add("yellow", 4);
        // colors.Add("green", 5);
        // colors.Add("blue", 6);
        // colors.Add("violet", 7);
        // colors.Add("grey", 8);
        // colors.Add("white", 9);
        // return colors[color.ToLower()];

        var colors = new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        return Array.IndexOf(colors, color);
    }

    public static string[] Colors()
    {
        var colors = new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return colors;
    }
}