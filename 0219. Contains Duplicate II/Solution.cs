using System.Collections.Generic;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.Add(nums[i]))
                return true;

            if (set.Count > k)
                set.Remove(nums[i - k]);
        }

        return false;
    }
}

/*public class Solution // 98 % memory efficient but 20x slower the above solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
                if ((nums[i] == nums[j]) && ((j - i) <= k))
                    return true;
        }

        return false;
    }
}*/
