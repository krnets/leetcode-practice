/*using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(nums[i]))
                return true;

            set.Add(nums[i]);
        }

        return false;
    }
}*/

/*using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int n in nums)
        {
            if (set.Contains(n))
                return true;

            set.Add(n);
        }

        return false;
    }
}*/


using System.Linq;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return nums.Distinct().Count() < nums.Length;
    }
}