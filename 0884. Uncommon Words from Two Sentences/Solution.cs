using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var wordsCountS1 = s1.Split().GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());
        var wordsCountS2 = s2.Split().GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());
        var list = new List<string>();

        foreach (var (key, value) in wordsCountS1)
            if (value == 1)
                if (!wordsCountS2.ContainsKey(key))
                    list.Add(key);

        foreach (var (key, value) in wordsCountS2)
            if (value == 1)
                if (!wordsCountS1.ContainsKey(key))
                    list.Add(key);


        return list.ToArray();
    }
}*/

public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var words = $"{s1} {s2}".Split();
        var seen = new HashSet<string>();
        var result = new HashSet<string>();

        foreach (var word in words)
            if (seen.Contains(word))
                result.Remove(word);
            else
            {
                seen.Add(word);
                result.Add(word);
            }

        return result.ToArray();
    }
}