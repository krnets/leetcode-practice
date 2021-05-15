using System.Linq;

public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        return char.IsUpper(word[0]) && word[1..].All(char.IsLower) ||
               word.All(char.IsUpper) || word.All(char.IsLower);
    }
}