using System.Linq;

/*public class Solution
{
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
    {
        var first = int.Parse(string.Concat(firstWord.Select(c => $"{c - 'a'}")));
        var second = int.Parse(string.Concat(secondWord.Select(c => $"{c - 'a'}")));
        int target = int.Parse(string.Concat(targetWord.Select(c => $"{c - 'a'}")));

        return first + second == target;
    }
}*/

/*public class Solution
{
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
    {
        return Convert(firstWord) + Convert(secondWord) == Convert(targetWord);
    }

    private static int Convert(string firstWord)
    {
        return int.Parse(string.Concat(firstWord.Select(c => $"{c - 'a'}")));
    }
}*/

/*public class Solution
{
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
    {
        return Convert(firstWord) + Convert(secondWord) == Convert(targetWord);
    }

    private static int Convert(string firstWord)
    {
        return firstWord.Aggregate(0, (acc, c) => acc * 10 + (c - 'a'));
    }
}*/

public class Solution
{
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
    {
        return Convert(firstWord) + Convert(secondWord) == Convert(targetWord);
    }

    private static int Convert(string firstWord)
    {
        int ans = 0;

        foreach (char c in firstWord)
            ans = ans * 10 + (c - 'a');

        return ans;
    }
}