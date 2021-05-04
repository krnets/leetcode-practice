/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies.Max();

        return candies.Select(c => c + extraCandies >= max).ToList();
    }
}*/

/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int max = candies.Max();
        var result = new List<bool>();

        for (int i = 0; i < candies.Length; i++)
            result.Add(candies[i] + extraCandies >= max);

        return result;
    }
}*/

/*using System.Collections.Generic;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int max = 0;
        var result = new List<bool>();

        for (int i = 0; i < candies.Length; i++)
            if (max < candies[i])
                max = candies[i];

        for (int i = 0; i < candies.Length; i++)
            result.Add(candies[i] + extraCandies >= max);

        return result;
    }
}*/

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        bool[] result = new bool[candies.Length];
        int max = candies.Max();

        for (int i = 0; i < candies.Length; i++)
            result[i] = (candies[i] + extraCandies >= max);

        return result;
    }
}