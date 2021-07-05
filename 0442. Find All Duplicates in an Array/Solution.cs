using System;
using System.Collections.Generic;

/*public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var digitCount = new int[(int) 1e5];
        var duplicates = new List<int>();

        foreach (var x in nums)
        {
            digitCount[x]++;

            if (digitCount[x] == 2)
                duplicates.Add(x);
        }

        return duplicates;
    }
}*/

public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var duplicates = new List<int>();

        foreach (int n in nums)
        {
            int x = Math.Abs(n);

            if (nums[x - 1] < 0)
                duplicates.Add(x);
            else
                nums[x - 1] *= -1;
        }

        return duplicates;
    }
}