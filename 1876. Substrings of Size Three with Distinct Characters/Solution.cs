using System.Linq;

/*public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        return s.Length < 3
            ? 0
            : Enumerable.Range(0, s.Length - 2)
                .Select(i => s.Substring(i, 3).Distinct())
                .Where(x => x.Count() == 3)
                .Count();
    }
}*/

/*public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        return s.Length < 3
            ? 0
            : Enumerable.Range(0, s.Length - 2)
                .Count(i => s.Substring(i, 3).Distinct().Count() == 3);
    }
}*/

/*public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        if (s.Length < 3)
            return 0;

        int count = 0;

        for (int i = 2; i < s.Length; i++)
            if (s[i - 2] != s[i - 1] && s[i - 1] != s[i] && s[i] != s[i - 2])
                count++;

        return count;
    }
}*/

public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        if (s.Length < 3)
            return 0;

        int count = 0;

        for (int i = 2; i < s.Length; i++)
        {
            char a = s[i - 2];
            char b = s[i - 1];
            char c = s[i];

            if (a != b && b != c && c != a)
                count++;
        }

        return count;
    }
}