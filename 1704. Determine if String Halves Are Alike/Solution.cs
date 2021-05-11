using System.Linq;

public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        string vowels = "aeiou";
        string left = s[..(s.Length / 2)].ToLower();
        string right = s[(s.Length / 2)..].ToLower();

        return left.Count(c => vowels.Contains(c)) == right.Count(c => vowels.Contains(c));
    }
}

/*public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        string vowels = "aeiou";
        int leftCount = 0;
        int rightCount = 0;

        for (int i = 0; i < s.Length / 2; i++)
        {
            if (vowels.Contains(char.ToLower(s[i])))
                leftCount++;
            if (vowels.Contains(char.ToLower(s[s.Length - i - 1])))
                rightCount++;
        }

        return leftCount == rightCount;
    }
}*/

/*public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        string vowels = "aeiou";
        int leftCount = 0;
        int rightCount = 0;
        s = s.ToLower();

        for (int i = 0; i < s.Length / 2; i++)
        {
            if (vowels.Contains(s[i])) leftCount++;
            if (vowels.Contains(s[s.Length - i - 1])) rightCount++;
        }

        return leftCount == rightCount;
    }
}*/

