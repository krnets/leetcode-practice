using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    private string firstRow = "qwertyuiop";
    private string secondRow = "asdfghjkl";
    private string thirdRow = "zxcvbnm";

    public string[] FindWords(string[] words)
    {
        return words.Where(s => CheckRows(s.ToLower())).ToArray();
    }

    private bool CheckRows(string s)
    {
        return s.All(c => firstRow.Contains(c)) ||
               s.All(c => secondRow.Contains(c)) ||
               s.All(c => thirdRow.Contains(c));
    }
}*/

/*public class Solution
{
    private string firstRow = "qwertyuiop";
    private string secondRow = "asdfghjkl";
    private string thirdRow = "zxcvbnm";

    public string[] FindWords(string[] words)
    {
        return words.Where(s => CheckRows(s.ToLower())).ToArray();
    }

    private bool CheckRows(string s)
    {
        int countMatchingCharsFirst = 0;
        int countMatchingCharsSecond = 0;
        int countMatchingCharsThird = 0;

        foreach (char c in s)
        {
            if (firstRow.Contains(c)) countMatchingCharsFirst++;
            if (secondRow.Contains(c)) countMatchingCharsSecond++;
            if (thirdRow.Contains(c)) countMatchingCharsThird++;
        }

        return s.Length == countMatchingCharsFirst
               || s.Length == countMatchingCharsSecond
               || s.Length == countMatchingCharsThird;
    }
}*/

public class Solution
{
    HashSet<char> firstRow = new HashSet<char>("qwertyuiop");
    HashSet<char> secondRow = new HashSet<char>("asdfghjkl");
    HashSet<char> thirdRow = new HashSet<char>("zxcvbnm");

    public string[] FindWords(string[] words)
    {
        return words.Where(s => CheckRows(s.ToLower())).ToArray();
    }

    private bool CheckRows(string s)
    {
        int countMatchingCharsFirst = 0;
        int countMatchingCharsSecond = 0;
        int countMatchingCharsThird = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (firstRow.Contains(c)) countMatchingCharsFirst++;
            if (secondRow.Contains(c)) countMatchingCharsSecond++;
            if (thirdRow.Contains(c)) countMatchingCharsThird++;
        }

        return s.Length == countMatchingCharsFirst
               || s.Length == countMatchingCharsSecond
               || s.Length == countMatchingCharsThird;
    }
}