using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // Remove spaces and convert to all uppercase
        // the quick brown fox jumps over the lazy dog
        // THEQUICKBROWNFOXJUMPSOVERTHELAZYDOG
        input.Replace(" ", "").ToUpper();

        // Create empty boolean array to hold marked values
        bool[] a = new bool[26];

        var i = 0;
        while (i < input.Length)
        {
            var index = input[i] - 65;
            a[index] = true;
            i++;
        }

        foreach (var item in a)
        {
            System.Console.WriteLine(item);
        }
        return a.All(x => x);
    }

}
