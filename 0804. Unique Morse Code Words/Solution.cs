/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private static string[] morseCode =
    {
        ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
        ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
        "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
    };

    public int UniqueMorseRepresentations(string[] words)
    {
        return words.Select(w => string.Concat(ToMorseCode(w))).Distinct().Count();
    }

    private IEnumerable<string> ToMorseCode(string word)
    {
        return word.Select(c => morseCode[c - 'a']);
    }
}*/

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private static string[] morseCode =
    {
        ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
        ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
        "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
    };

    public int UniqueMorseRepresentations(string[] words)
    {
        var set = new HashSet<string>();

        for (int i = 0; i < words.Length; i++)
        {
            set.Add(string.Concat(words[i].Select(c => morseCode[c - 'a'])));
        }

        return set.Count;
    }
}