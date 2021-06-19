using System.Linq;

public class Solution
{
    public bool HasGroupsSizeX(int[] deck)
    {
        var groups = deck.GroupBy(x => x)
            .Select(g => g.Count())
            .ToList();

        for (int i = 2; i <= deck.Length; i++)
            if (groups.All(x => x % i == 0))
                return true;

        return false;
    }
}