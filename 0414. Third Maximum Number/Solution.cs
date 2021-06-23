using System;
using System.Linq;
using System.Threading.Tasks.Sources;

/*public class Solution
{
    public int ThirdMax(int[] nums)
    {
        var max1 = nums.Max();
        var max2 = long.MinValue;
        var max3 = long.MinValue;

        foreach (int x in nums)
            if (x != max1)
                max2 = Math.Max(max2, x);

        foreach (int x in nums)
            if (x != max2 && x != max1)
                max3 = Math.Max(max3, x);


        return (int) (max3 == long.MinValue ? max1 : max3);
    }
}*/

/*public class Solution
{
    public int ThirdMax(int[] nums)
    {
        var max1 = nums.Max();

        var seed = long.MinValue;

        var max2 = nums.Where(x => x != max1)
            .Aggregate(seed, (cur, x) => Math.Max(cur, x));

        var max3 = nums.Where(x => x != max2 && x != max1)
            .Aggregate(seed, (cur, x) => Math.Max(cur, x));

        return (int) (max3 == long.MinValue ? max1 : max3);
    }
}*/

public class Solution
{
    public int ThirdMax(int[] nums)
    {
        int[] array = nums.Distinct().OrderBy(x => x).ToArray();

        return array.Length < 3 ? array[^1] : array[^3];
    }
}