using System.Linq;
using System.Text.RegularExpressions;

/*public class Solution
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        return Regex.Split(paragraph, @"[\s,]")
            .Select(w => Regex.Match(w.ToLower(), "[a-z]+").Value)
            .GroupBy(w => w)
            .Where(g => g.Key.Length > 0 && !banned.Contains(g.Key))
            .OrderBy(g => g.Count())
            .Select(g => g.Key)
            .Last();
    }
}*/

public class Solution
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        return Regex.Matches(paragraph, @"\w+")
            .Select(m => m.Value.ToLower())
            .GroupBy(w => w)
            .Where(g => g.Key.Length > 0 && !banned.Contains(g.Key))
            .OrderBy(g => g.Count())
            .Select(g => g.Key)
            .Last();
    }
}