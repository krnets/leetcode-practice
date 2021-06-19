using System.Collections.Generic;

public class Solution
{
    public string[] FindOcurrences(string text, string first, string second)
    {
        var list = new List<string>();
        var words = text.Split();

        for (int i = 0; i < words.Length - 2; i++)
            if (words[i] == first && words[i + 1] == second)
                list.Add(words[i + 2]);

        return list.ToArray();
    }
}