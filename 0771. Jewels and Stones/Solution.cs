/*public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int count = 0;

        foreach (char stone in stones)
            if (jewels.Contains(stone))
                count++;

        return count;
    }
}*/

using System.Linq;

public class Solution
{
    public int NumJewelsInStones(string jewels, string stones) => stones.Count(jewels.Contains);
}