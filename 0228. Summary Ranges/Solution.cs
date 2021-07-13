using System.Collections.Generic;
using System.ComponentModel.Design;
using Xunit.Abstractions;

/*public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var list = new List<string>();

        if (nums.Length == 0)
            return list;

        int rangeStart = 0;
        int rangeEnd = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == 1)
                rangeEnd++;
            else
            {
                list.Add($"{nums[rangeStart]}" + (rangeStart != rangeEnd ? $"->{nums[rangeEnd]}" : ""));
                rangeStart = i;
                rangeEnd = i;
            }
        }

        list.Add($"{nums[rangeStart]}" + (rangeStart != rangeEnd ? $"->{nums[rangeEnd]}" : ""));

        return list;
    }
}*/

/*public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var list = new List<string>();

        for (int i = 0; i < nums.Length; i++)
        {
            int rangeStart = nums[i];

            while (i + 1 < nums.Length && nums[i + 1] - nums[i] == 1)
            {
                i++;
            }

            list.Add(rangeStart == nums[i] ? $"{rangeStart}" : $"{rangeStart}->{nums[i]}");
        }

        return list;
    }
}*/

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var list = new List<string>();

        for (int i = 0; i < nums.Length; i++)
        {
            int rangeStart = nums[i];

            while (i + 1 < nums.Length && nums[i + 1] - nums[i] == 1) i++;

            if (rangeStart == nums[i])
                list.Add($"{rangeStart}");
            else list.Add($"{rangeStart}->{nums[i]}");
        }

        return list;
    }
}