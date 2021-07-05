using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        return Enumerable.Range(1, nums.Length)
            .Except(nums).ToArray();
    }
}*/

/*public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var missing = new List<int>();
        var set = nums.ToHashSet();
        int n = nums.Length;

        for (int i = 1; i <= n; i++)
            if (!set.Contains(i))
                missing.Add(i);

        return missing;
    }
}*/

public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var missing = new List<int>();
        int n = nums.Length;
        var array = new int[n + 1];

        foreach (var x in nums)
            array[x] = 1;

        for (int i = 1; i <= n; i++)
            if (array[i] == 0)
                missing.Add(i);

        return missing;
    }
}